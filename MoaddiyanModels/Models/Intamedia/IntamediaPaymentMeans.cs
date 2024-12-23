namespace TadbirTaxService.Models.Intamedia
{
    /// <summary>
    /// روش پرداخت
    /// </summary>
    public enum IntamediaPaymentMeans
    {
        /// <summary>
        /// چک
        /// </summary>
        Cheque = 1,
        /// <summary>
        /// تهاتر
        /// </summary>
        SettOff = 2,
        /// <summary>
        /// وجه نقد
        /// </summary>
        Cash = 3,
        /// <summary>
        /// POS
        /// </summary>
        Pos = 4,
        /// <summary>
        /// درگاه پرداخت اینترنتی
        /// </summary>
        OnlinePaymet = 5,
        /// <summary>
        /// کارت به کارت
        /// </summary>
        CardTransfer = 6,
        /// <summary>
        /// انتقال به حساب
        /// </summary>
        AccountTransfer = 7,
        /// <summary>
        /// سایر
        /// </summary>
        Other = 8,
    }
}
