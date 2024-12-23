using RSecurityBackend.Models.Cloud;

namespace TadbirTaxService.Models.Intamedia
{
    public class IntamediaInvoiceShippingGood
    {
        /// <summary>
        /// Id
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Workspace Id
        /// </summary>
        public Guid WorkspaceId { get; set; }

        /// <summary>
        /// شرکت
        /// </summary>
        public RWorkspace Workspace { get; set; }

        /// <summary>
        /// Invoice Id
        /// </summary>
        public Guid? IntamediaInvoiceId { get; set; }

        /// <summary>
        /// شماره ردیف
        /// </summary>
        public int RowNumber { get; set; }

        /// <summary>
        /// شناسهٔ کالا/خدمت ۱۳ کاراکتری از سایت stuffid.tax.gov.ir
        /// </summary>
        public string? StuffId { get; set; }

        /// <summary>
        /// شرح کالا / خدمت
        /// </summary>
        public string? Description { get; set; }
    }
}
