using RSecurityBackend.Models.Cloud.ViewModels;

namespace TadbirTaxService.Models.Workspace
{
    public class NewWorkspaceExModel
    {
        /// <summary>
        /// main model
        /// </summary>
        public NewWorkspaceModel NewWorkspaceModel { get; set; }

        /// <summary>
        /// tax info
        /// </summary>
        public RWorkspaceTaxInfo TaxInfo { get; set; }
    }
}
