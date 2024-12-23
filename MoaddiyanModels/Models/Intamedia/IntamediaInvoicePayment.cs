using RSecurityBackend.Models.Cloud;

namespace TadbirTaxService.Models.Intamedia
{
    /// <summary>
    /// پرداخت صورتحساب
    /// </summary>
    public class IntamediaInvoicePayment
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
        /// شماره سوییچ پرداخت
        /// </summary>
        public string?  SwitchNo { get; set; }

        /// <summary>
        /// شماره پذیرنده فروشگاهی
        /// </summary>
        public string? AcceptingCompanyNo { get; set; }

        /// <summary>
        /// شماره پایانه
        /// </summary>
        public string? TerminalNo { get; set; }

        /// <summary>
        /// روش پرداخت
        /// </summary>
        public IntamediaPaymentMeans? PaymentMeans { get; set; }

        /// <summary>
        /// شماره پیگیری / شماره مرجع
        /// </summary>
        public string? TrackingNo { get; set; }

        /// <summary>
        /// شماره کارت
        /// </summary>
        public string? CardNo { get; set; }

        /// <summary>
        /// شماره / شناسهٔ ملی/کد فراگیر پرداخت‌کنندهٔ صورتحساب
        /// </summary>
        public string? PersonIdNo { get; set; }

        /// <summary>
        /// تاریخ و زمان پرداخت صورتحساب
        /// </summary>
        public DateTime? DateTime { get; set; }

        /// <summary>
        /// مبلغ پرداختی
        /// </summary>
        public long? Value { get; set; }
    }
}
