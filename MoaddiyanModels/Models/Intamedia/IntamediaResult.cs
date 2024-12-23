namespace TadbirTaxService.Models.Intamedia
{
    public class IntamediaResult
    {
        /// <summary>
        /// Id
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Invoice Id
        /// </summary>
        public Guid? IntamediaInvoiceId { get; set; }

        /// <summary>
        /// نوع
        /// </summary>
        public IntamediaResultType ResultType { get; set; }

        /// <summary>
        /// کد خطا
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// متن خطا
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// راهنمای رفع اشکال
        /// </summary>
        public string ResolutionGuidLines { get; set; }
    }
}
