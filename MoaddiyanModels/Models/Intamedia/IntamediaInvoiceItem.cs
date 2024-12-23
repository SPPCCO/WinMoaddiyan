using RSecurityBackend.Models.Cloud;

namespace TadbirTaxService.Models.Intamedia
{
    /// <summary>
    /// قلم اطلاعاتی صورتحساب
    /// </summary>
    public class IntamediaInvoiceItem
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
        public string StuffId { get; set; }

        /// <summary>
        /// شرح کالا / خدمت
        /// </summary>
        public string? Description { get; set; }

        /// <summary>
        /// تعداد / مقدار
        /// </summary>
        public decimal? Amount { get; set; }

        /// <summary>
        /// کد واحد اندازه‌گیری
        /// </summary>
        public string? MeasurementUnitCode { get; set; }

        /// <summary>
        /// نام واحد اندازه‌گیری
        /// </summary>
        public string? MeasurementUnitName { get; set; }

        /// <summary>
        /// وزن خالص
        /// </summary>
        public decimal? NetWeightInCustoms { get; set; }

        /// <summary>
        /// قیمت واحد
        /// </summary>
        public decimal? UnitPrice { get; set; }

        /// <summary>
        /// میزان ارز
        /// </summary>
        public decimal? UnitPriceInCurrency { get; set; }

        /// <summary>
        /// کد ارز
        /// </summary>
        public string? IntamediaCurrencyCode { get; set; }

        /// <summary>
        /// نرخ برابری ارز با ریال
        /// </summary>
        public decimal? CurrencyExchangeRateInRial { get; set; }

        /// <summary>
        ///  ارزش ریالی کالا بر اساس اظهارنامهٔ گمرکی
        /// </summary>
        public decimal? CustomsClaimedPriceInRials { get; set; }

        /// <summary>
        /// ارزش ارزی کالا بر اساس اظهارنامهٔ گمرکی
        /// </summary>
        public decimal? CustomsClaimedPriceInCurrency { get; set; }

        /// <summary>
        /// مبلغ قبل از تخفیف
        /// </summary>
        ///<remarks>
        ///حاصل ضرب مقدار در قیمت واحد کالا
        ///</remarks>
        public decimal? AmountByUnitPrice { get; set; }

        /// <summary>
        /// مبلغ تخفیف
        /// </summary>
        public decimal? Discount { get; set; }

        /// <summary>
        /// مبلغ بعد از تخفیف
        /// </summary>
        public decimal? AmountByUnitPriceMinusDiscount { get; set; }

        /// <summary>
        /// نرخ مالیات بر ارزش افزوده
        /// </summary>
        public decimal? ValueAddedTaxRateInPercent { get; set; }

        /// <summary>
        /// مبلغ قیمت واحد از روی مبلغ مالیات بر ارزش افزوده حساب شود
        /// </summary>
        public bool UnitPriceIsRecalculated { get; set; }

        /// <summary>
        /// مبلغ مالیات بر ارزش افزوده
        /// </summary>
        public decimal? ValueAddedTaxRateInPercentByAmountByUnitPriceMinusDiscountDiv100 { get; set; }

        /// <summary>
        /// موضوع سایر مالیات و عوارض
        /// </summary>
        public string? OtherTax1Description { get; set; }

        /// <summary>
        /// نرخ سایر مالیات و عوارض
        /// </summary>
        public decimal? OtherTax1RateInPercent { get; set; }

        /// <summary>
        /// مبلغ سایر مالیات و عوارض
        /// </summary>
        public decimal? OtherTax1RateInPercentByAmountByUnitPriceMinusDiscountDiv100 { get; set; }

        /// <summary>
        /// موضوع سایر وجوه قانونی
        /// </summary>
        public string? OtherTax2Description { get; set; }

        /// <summary>
        /// نرخ سایر وجوه قانونی
        /// </summary>
        public decimal? OtherTax2RateInPercent { get; set; }

        /// <summary>
        /// مبلغ سایر وجوه قانونی
        /// </summary>
        public decimal? OtherTax2RateInPercentByAmountByUnitPriceMinusDiscountDiv100 { get; set; }

        /// <summary>
        /// اجرت ساخت طلا
        /// </summary>
        public decimal? GoldConstructionCost { get; set; }

        /// <summary>
        /// سود فروشندهٔ طلا
        /// </summary>
        public decimal? GoldSalerProfit { get; set; }

        /// <summary>
        /// حق‌العمل فروش طلا
        /// </summary>
        public decimal? GoldBrokerShare { get; set; }

        /// <summary>
        /// جمع کل اجرت، حق‌العمل و سود فروش طلا
        /// </summary>
        public decimal? GoldConstructionCostPlusGoldSalerProfitPlusGoldBrokerShare { get; set; }

        /// <summary>
        /// مبلغ نهایی سطر پس از کسر تخفیفات و افزودن اضافات
        /// </summary>
        public decimal? FinalPrice { get; set; }

        /// <summary>
        /// سهم نقدی از پرداخت
        /// </summary>
        public decimal? FinalPriceByInvoiceCashPartOfPaymentsDivInvoiceSumOfItemTotalPriceMinusDiscounts { get; set; }

        /// <summary>
        /// سهم مالیات بر ارزش افزوده از پرداخت
        /// </summary>
        /// <remarks>
        /// ValueAddedTaxRateInPercent*(Amount*UnitPrice-Discount)/100*InvoiceCashPartOfPayments/InvoiceSumOfItemTotalPriceMinusDiscounts
        /// </remarks>
        public decimal? ValueAddedTaxPartOfPayment { get; set; }

        /// <summary>
        /// شناسهٔ یکتای ثبت قرارداد حق‌العمل کاری
        /// </summary>
        public string? IntamediaUniqueContractNumber { get; set; }

        /// <summary>
        /// عیار طلا
        /// </summary>
        public decimal? GoldKarat { get; set; }

        /// <summary>
        /// تفاوت نرخ خرید و فروش ارز / کارمزد فروش ارز - این فیلد حذف شده
        /// </summary>
        public decimal? CurrencySalesProfitInRials { get; set; }

        /// <summary>
        /// نرخ خرید ارز
        /// </summary>
        public decimal? CurrencySalesPurchaseInRials { get; set; }


        /// <summary>
        /// مأخذ مالیات بر ارزش افزوده در فروش ارز - می‌شود همان تفاوت نرخ خرید و فروش ارز
        /// </summary>
        public long? CurrencySalesVatReferenceOrProfitInRials { get; set; }
    }
}
