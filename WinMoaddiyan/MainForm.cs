using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Newtonsoft.Json;
using RSecurityBackend.Models.Auth.ViewModels;
using RSecurityBackend.Models.Generic;
using System.Net;
using System.Text;
using TadbirTaxService.Models.Intamedia;
using TadbirTaxService.Models.Workspace;
using WinMoaddiyan.Properties;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace WinMoaddiyan
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            var statusList = IntamediaInvoiceStatusDescriptor.Values;
            cmbStatus.Items.AddRange(statusList);
            cmbStatus.SelectedItem = statusList.Where(x => x.IntamediaInvoiceStatus == IntamediaInvoiceStatus.Current).Single();
        }

        private async void btnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("آیا از خروج از حساب کاربری خود اطمینان دارید؟", "تأییدیه", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign) == DialogResult.No)
            {
                return;
            }

            LoggedOnUserModel? loggedOnUser = JsonConvert.DeserializeObject<LoggedOnUserModel>(Settings.Default.LoggenOnUserJson);
            if (loggedOnUser == null)
            {
                Settings.Default.LoggenOnUserJson = "";
                Settings.Default.Token = "";
                Settings.Default.SessionId = Guid.Empty;
                Settings.Default.Save();

                Application.Restart();
                return;
            }

            Enabled = false;
            Application.DoEvents();

            try
            {
                using (HttpClient httpClient = new HttpClient())
                {
                    await MoaddiyanSessionChecker.PrepareClientAsync(httpClient);
                    var response = await httpClient.DeleteAsync
                        (
                        $"https://api.moaddiyan.com/api/users/delsession?userId={loggedOnUser.User.Id}&sessionId={Settings.Default.SessionId}"
                        );
                    if (response.StatusCode != HttpStatusCode.OK)
                    {
                        Cursor = Cursors.Default;
                        Enabled = true;
                        MessageBox.Show(JsonConvert.DeserializeObject<string>(await response.Content.ReadAsStringAsync()));
                        return;
                    }
                    response.EnsureSuccessStatusCode();


                    Settings.Default.LoggenOnUserJson = "";
                    Settings.Default.Token = "";
                    Settings.Default.SessionId = Guid.Empty;
                    Settings.Default.Save();

                    Application.Restart();
                }
            }
            catch (Exception exp)
            {
                Cursor = Cursors.Default;
                Enabled = true;
                MessageBox.Show(exp.ToString());
            }



        }

        private async void MainForm_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Settings.Default.WorkspacesJson))
            {
                var workspaces = JsonConvert.DeserializeObject<WorkspaceExViewModel[]>(Settings.Default.WorkspacesJson);
                if (workspaces != null)
                {
                    cmbWorkspace.Items.AddRange(workspaces);
                    if (workspaces.Any(w => w.Workspace.Id == Settings.Default.WorkspaceId))
                    {
                        cmbWorkspace.SelectedItem = workspaces.Where(w => w.Workspace.Id == Settings.Default.WorkspaceId).Single();
                        return;
                    }
                    if (workspaces.Any())
                    {
                        cmbWorkspace.SelectedIndex = 0;
                        Settings.Default.WorkspaceId = ((WorkspaceExViewModel)cmbWorkspace.SelectedItem).Workspace.Id;
                        Settings.Default.Save();
                    }
                    return;
                }
            }

            await LoadWorkspacesAsync();


        }

        private async Task LoadWorkspacesAsync()
        {
            Enabled = false;
            Application.DoEvents();

            try
            {
                using (HttpClient httpClient = new HttpClient())
                {
                    await MoaddiyanSessionChecker.PrepareClientAsync(httpClient);
                    var response = await httpClient.GetAsync
                        (
                        $"https://api.moaddiyan.com/api/workspace/ex?onlyActive=true&onlyOwned=false&onlyMember=false"
                        );
                    if (response.StatusCode != HttpStatusCode.OK)
                    {
                        Cursor = Cursors.Default;
                        Enabled = true;
                        MessageBox.Show(JsonConvert.DeserializeObject<string>(await response.Content.ReadAsStringAsync()));
                        return;
                    }
                    response.EnsureSuccessStatusCode();
                    Cursor = Cursors.Default;
                    Enabled = true;
                    var json = await response.Content.ReadAsStringAsync();
                    var workspaces = JsonConvert.DeserializeObject<WorkspaceExViewModel[]>(json);
                    if (workspaces != null)
                    {
                        Settings.Default.WorkspacesJson = json;
                        Settings.Default.Save();
                        cmbWorkspace.Items.AddRange(workspaces);

                        if (workspaces.Any(w => w.Workspace.Id == Settings.Default.WorkspaceId))
                        {
                            cmbWorkspace.SelectedItem = workspaces.Where(w => w.Workspace.Id == Settings.Default.WorkspaceId).Single();
                            await LoadinvoicesAsync();
                            return;
                        }
                        if (workspaces.Any())
                        {
                            cmbWorkspace.SelectedIndex = 0;
                            Settings.Default.WorkspaceId = ((WorkspaceExViewModel)cmbWorkspace.SelectedItem).Workspace.Id;
                            Settings.Default.Save();
                            await LoadinvoicesAsync();
                        }
                        return;
                    }
                }
            }
            catch (Exception exp)
            {
                Cursor = Cursors.Default;
                Enabled = true;
                MessageBox.Show(exp.ToString());
            }
        }

        private async void btnRefreshWorkspaces_Click(object sender, EventArgs e)
        {
            await LoadWorkspacesAsync();
        }

        private async Task LoadinvoicesAsync()
        {
            if (cmbWorkspace.SelectedItem == null || cmbStatus.SelectedItem == null) return;
            Enabled = false;
            Cursor = Cursors.WaitCursor;
            Application.DoEvents();

            try
            {
                using (HttpClient httpClient = new HttpClient())
                {
                    await MoaddiyanSessionChecker.PrepareClientAsync(httpClient);
                    var response = await httpClient.GetAsync
                        (
                        $"https://api.moaddiyan.com/api/invoice/{Settings.Default.WorkspaceId}?PageNumber=1&PageSize=50&status={(cmbStatus.SelectedItem as IntamediaInvoiceStatusDescriptor).IntamediaInvoiceStatus}&invoiceNumber=0"
                        );
                    if (response.StatusCode != HttpStatusCode.OK)
                    {
                        Cursor = Cursors.Default;
                        Enabled = true;
                        MessageBox.Show(JsonConvert.DeserializeObject<string>(await response.Content.ReadAsStringAsync()));
                        return;
                    }
                    response.EnsureSuccessStatusCode();
                    Cursor = Cursors.Default;
                    Enabled = true;
                    var invoices = JsonConvert.DeserializeObject<IntamediaInvoice[]>(await response.Content.ReadAsStringAsync());
                    if (invoices != null)
                    {
                        grd.DataSource = invoices;
                    }

                    var pagingMeta = JsonConvert.DeserializeObject<PaginationMetadata>(response.Headers.GetValues("paging-headers").Single());
                    lblPaging.Text = $"صفحهٔ {pagingMeta.currentPage} از {pagingMeta.totalPages} - تعداد کل: {pagingMeta.totalCount}";
                }
            }
            catch (Exception exp)
            {
                Cursor = Cursors.Default;
                Enabled = true;
                MessageBox.Show(exp.ToString());
            }
        }

        private async void cmbWorkspace_SelectedIndexChanged(object sender, EventArgs e)
        {
            Settings.Default.WorkspaceId = ((WorkspaceExViewModel)cmbWorkspace.SelectedItem).Workspace.Id;
            Settings.Default.Save();

            await LoadinvoicesAsync();
        }

        private async void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            await LoadinvoicesAsync();
        }

        private async void btnAddInvoice_Click(object sender, EventArgs e)
        {
            if (cmbWorkspace.SelectedItem == null || cmbStatus.SelectedItem == null) return;
            Enabled = false;
            Cursor = Cursors.WaitCursor;
            long invoiceNumber = 1;
            try
            {
                using (HttpClient httpClient = new HttpClient())
                {
                    await MoaddiyanSessionChecker.PrepareClientAsync(httpClient);
                    var response = await httpClient.GetAsync
                        (
                        $"https://api.moaddiyan.com/api/invoice/{Settings.Default.WorkspaceId}/last"
                        );
                    if (response.StatusCode != HttpStatusCode.OK)
                    {
                        Cursor = Cursors.Default;
                        Enabled = true;
                        MessageBox.Show(JsonConvert.DeserializeObject<string>(await response.Content.ReadAsStringAsync()));
                        return;
                    }
                    response.EnsureSuccessStatusCode();
                    Cursor = Cursors.Default;
                    Enabled = true;
                    var lastInvoice = JsonConvert.DeserializeObject<IntamediaInvoice>(await response.Content.ReadAsStringAsync());
                    if(lastInvoice != null)
                    {
                        invoiceNumber = lastInvoice.InvoiceNumber + 1;
                    }
                }
            }
            catch (Exception exp)
            {
                Cursor = Cursors.Default;
                Enabled = true;
                MessageBox.Show(exp.ToString());
                return;
            }
            Application.DoEvents();

            var measurementUnit = IntamediaMeasurementUnit.Units.Where(u => u.Name == "عدد").Single(); //واحد اقلام صورتحساب

            IntamediaInvoice invoice = new IntamediaInvoice()
            {
                WorkspaceId = Settings.Default.WorkspaceId, //شرکت
                InvoiceNumber = invoiceNumber, //شماره یا سریال داخلی صورتحساب
                DateTime = DateTime.Now, //تاریخ و زمان صدور صورتحساب
                InvoiceSubject = IntamediaInvoiceSubject.Main,// موضوع صورتحساب
                InvoiceType = IntamediaInvoiceType.Type2, //نوع صورتحساب
                InvoicePattern = IntamediaInvoicePattern.Pattern1NormalSales,//الگوی صورتحساب
                RecalculateSums = true,//جمع‌ها به طور خودکار حساب شود
                Items =
                [
                    new IntamediaInvoiceItem()
                    {
                        StuffId = "2900750000016",//شناسهٔ کالا / خدمت
                        Description = "نرم‌افزار تدبیر",//شرح
                        Amount = 2,//تعداد یا مقدار
                        MeasurementUnitCode = measurementUnit.Code,
                        MeasurementUnitName = measurementUnit.Name,
                        UnitPrice = 10_000_000,//مبلغ واحد به ریال
                        Discount = 0, //تخفیف سطر به ریال
                        ValueAddedTaxRateInPercent = 10,//درصد مالیات بر ارزش افزوده
                    },
                    new IntamediaInvoiceItem()
                    {
                        StuffId = "2330002811587",
                        Description = "خدمات پشتیبانی",
                        Amount = 3,
                        MeasurementUnitCode = measurementUnit.Code,
                        MeasurementUnitName = measurementUnit.Name,
                        UnitPrice = 2_000_000,
                        Discount = 500_000,
                        ValueAddedTaxRateInPercent = 10,
                    },
                ]
            };


            try
            {
                using (HttpClient httpClient = new HttpClient())
                {
                    await MoaddiyanSessionChecker.PrepareClientAsync(httpClient);
                    var response = await httpClient.PostAsync
                        (
                        $"https://api.moaddiyan.com/api/invoice/{Settings.Default.WorkspaceId}",
                         new StringContent(JsonConvert.SerializeObject(invoice), Encoding.UTF8, "application/json")
                        );
                    if (response.StatusCode != HttpStatusCode.OK)
                    {
                        Cursor = Cursors.Default;
                        Enabled = true;
                        MessageBox.Show(JsonConvert.DeserializeObject<string>(await response.Content.ReadAsStringAsync()));
                        return;
                    }
                    response.EnsureSuccessStatusCode();
                    var newInvoice = JsonConvert.DeserializeObject<IntamediaInvoice>(await response.Content.ReadAsStringAsync());
                    await LoadinvoicesAsync();
                }
            }
            catch (Exception exp)
            {
                Cursor = Cursors.Default;
                Enabled = true;
                MessageBox.Show(exp.ToString());
                return;
            }
        }
    }
}
