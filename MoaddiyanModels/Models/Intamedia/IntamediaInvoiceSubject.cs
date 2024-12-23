namespace TadbirTaxService.Models.Intamedia
{
    public enum IntamediaInvoiceSubject
    {
        /// <summary>
        /// صفر
        /// </summary>
        Reserved = 0,
        /// <summary>
        /// اصلی
        /// </summary>
        Main = 1,
        /// <summary>
        /// اصلاحی
        /// </summary>
        Edit = 2,
        /// <summary>
        /// ابطالی
        /// </summary>
        Cancel = 3,
        /// <summary>
        /// برگشتی
        /// </summary>
        Return = 4,
    }
}
