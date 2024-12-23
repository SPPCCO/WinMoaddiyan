namespace TadbirTaxService.Models.Intamedia
{
    /// <summary>
    /// روش تسویه
    /// </summary>
    public enum IntamediaInvoicePaymentType
    {
        /// <summary>
        /// نقد
        /// </summary>
        Cash = 1,
        /// <summary>
        /// نسیه
        /// </summary>
        PayLater = 2,
        /// <summary>
        /// نقد و نسیه
        /// </summary>
        CashAndPayLater = 3,
    }
}
