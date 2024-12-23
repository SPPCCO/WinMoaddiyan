using RSecurityBackend.Models.Cloud.ViewModels;

namespace TadbirTaxService.Models.Workspace
{
    public class WorkspaceExViewModel
    {
        /// <summary>
        /// workspace information
        /// </summary>
        public WorkspaceViewModel Workspace { get; set; }

        /// <summary>
        /// tax info
        /// </summary>
        public RWorkspaceTaxInfo TaxInfo { get; set; }

        /// <summary>
        /// to string
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Workspace.Name;
        }
    }
}
