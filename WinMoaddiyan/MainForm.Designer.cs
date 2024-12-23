namespace WinMoaddiyan
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            toolStrip = new ToolStrip();
            lblWorkspace = new ToolStripLabel();
            cmbWorkspace = new ToolStripComboBox();
            btnRefreshWorkspaces = new ToolStripButton();
            btnLogout = new ToolStripButton();
            grd = new DataGridView();
            toolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grd).BeginInit();
            SuspendLayout();
            // 
            // toolStrip
            // 
            toolStrip.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            toolStrip.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip.Items.AddRange(new ToolStripItem[] { lblWorkspace, cmbWorkspace, btnRefreshWorkspaces, btnLogout });
            toolStrip.Location = new Point(0, 0);
            toolStrip.Name = "toolStrip";
            toolStrip.Size = new Size(800, 25);
            toolStrip.TabIndex = 0;
            toolStrip.Text = "نوار ابزار";
            // 
            // lblWorkspace
            // 
            lblWorkspace.Name = "lblWorkspace";
            lblWorkspace.Size = new Size(45, 22);
            lblWorkspace.Text = "شرکت:";
            // 
            // cmbWorkspace
            // 
            cmbWorkspace.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbWorkspace.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbWorkspace.Name = "cmbWorkspace";
            cmbWorkspace.Size = new Size(200, 25);
            cmbWorkspace.SelectedIndexChanged += cmbWorkspace_SelectedIndexChanged;
            // 
            // btnRefreshWorkspaces
            // 
            btnRefreshWorkspaces.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnRefreshWorkspaces.Image = (Image)resources.GetObject("btnRefreshWorkspaces.Image");
            btnRefreshWorkspaces.ImageTransparentColor = Color.Magenta;
            btnRefreshWorkspaces.Name = "btnRefreshWorkspaces";
            btnRefreshWorkspaces.Size = new Size(56, 22);
            btnRefreshWorkspaces.Text = "به‌روزآوری";
            btnRefreshWorkspaces.Click += btnRefreshWorkspaces_Click;
            // 
            // btnLogout
            // 
            btnLogout.Alignment = ToolStripItemAlignment.Right;
            btnLogout.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnLogout.Image = (Image)resources.GetObject("btnLogout.Image");
            btnLogout.ImageTransparentColor = Color.Magenta;
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(86, 22);
            btnLogout.Text = "خروج از حساب";
            btnLogout.Click += btnLogout_Click;
            // 
            // grd
            // 
            grd.AllowUserToAddRows = false;
            grd.AllowUserToDeleteRows = false;
            grd.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grd.Dock = DockStyle.Fill;
            grd.Location = new Point(0, 25);
            grd.Name = "grd";
            grd.ReadOnly = true;
            grd.Size = new Size(800, 395);
            grd.TabIndex = 1;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 420);
            Controls.Add(grd);
            Controls.Add(toolStrip);
            Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "MainForm";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            Text = "تدبیر مؤدیان";
            Load += MainForm_Load;
            toolStrip.ResumeLayout(false);
            toolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)grd).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip;
        private ToolStripLabel lblWorkspace;
        private ToolStripComboBox cmbWorkspace;
        private ToolStripButton btnLogout;
        private ToolStripButton btnRefreshWorkspaces;
        private DataGridView grd;
    }
}