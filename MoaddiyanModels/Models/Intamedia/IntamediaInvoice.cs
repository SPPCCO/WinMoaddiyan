using DNTPersianUtils.Core;
using RSecurityBackend.Models.Cloud;
using System.Globalization;


namespace TadbirTaxService.Models.Intamedia
{
    /// <summary>
    /// صورتحساب سامانهٔ مؤدیان
    /// </summary>
    public class IntamediaInvoice
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
        /// شماره
        /// </summary>
        public long InvoiceNumber { get; set; }

        /// <summary>
        /// شمارهٔ منحصر به فرد مالیاتی
        /// </summary>
        public string TaxId { get; set; }

        /// <summary>
        /// شماره منحصر به فرد مالیاتی صورتحساب مرجع
        /// </summary>
        public string? RelatedInvoiceTaxId { get; set; }

        /// <summary>
        /// تاریخ و زمان صدور صورتحساب
        /// </summary>
        public DateTime DateTime { get; set; }

        /// <summary>
        /// تاریخ و زمان ایجاد صورتحساب
        /// </summary>
        public DateTime? CreateDate { get; set; }

        /// <summary>
        /// نوع صورتحساب
        /// </summary>
        public IntamediaInvoiceType? InvoiceType { get; set; }

        /// <summary>
        /// الگوی صورتحساب
        /// </summary>
        public IntamediaInvoicePattern? InvoicePattern { get; set; }

        /// <summary>
        /// موضوع صورتحساب
        /// </summary>
        public IntamediaInvoiceSubject InvoiceSubject { get; set; }

        /// <summary>
        /// شماره اقتصادی فروشنده
        /// </summary>
        public string SalerEccCode { get; set; }

        /// <summary>
        /// شماره اقتصادی خریدار
        /// </summary>
        public string? BuyerEccCode { get; set; }

        /// <summary>
        /// ارسال شمارهٔ اقتصادی خریدار
        /// </summary>
        public bool SendBuyerEccCode { get; set; } = true;

        /// <summary>
        /// نوع شخص خریدار
        /// </summary>
        public IntamediaPersonType? TypeOfBuyer { get; set; }

        /// <summary>
        /// کد شعبهٔ فروشنده
        /// </summary>
        public string? SalerBranchCode { get; set; }

        /// <summary>
        /// شناسه ملی/ شماره ملی/شناسه مشارکت مدنی/کد فراگیر اتباع غیر ایرانی خریدار
        /// </summary>
        public string? BuyerIdNumber { get; set; }

        /// <summary>
        /// عدم ارسال شناسهٔ خریدار به سامانه
        /// </summary>
        public bool SendBuyerIdNumber { get; set; } = true;

        /// <summary>
        /// کد پستی خریدار
        /// </summary>
        public string? BuyerPostalCode { get; set; }

        /// <summary>
        /// ارسال کد پستی خریدار
        /// </summary>
        public bool SendBuyerPostalCode { get; set; } = true;

        /// <summary>
        /// کد شعبهٔ خریدار
        /// </summary>
        public string? BuyerBranchCode { get; set; }

        /// <summary>
        /// ارسال کد شعبهٔ خریدار
        /// </summary>
        public bool SendBuyerBranchCode { get; set; } = true;

        /// <summary>
        /// شمارهٔ گذرنامهٔ خریدار
        /// </summary>
        public string? BuyerPassportNo { get; set; }

        /// <summary>
        /// ارسال شمارهٔ گذرنامهٔ خریدار
        /// </summary>
        public bool SendBuyerPassportNo { get; set; } = true;

        /// <summary>
        /// نوع پرواز
        /// </summary>
        public FlightType? FlightType { get; set; }

        /// <summary>
        /// شمارهٔ پروانهٔ گمرکی
        /// </summary>
        public string? SalerCustomsLicenceNo { get; set; }

        /// <summary>
        /// کد گمرک محل اظهار فروشنده
        /// </summary>
        public string? SalerCustomsCode { get; set; }

        /// <summary>
        /// شناسهٔ یکتای ثبت قرارداد فروشنده
        /// </summary>
        public string? SalerContractNo { get; set; }

        /// <summary>
        /// شماره کوتاژ اظهارنامه گمرکی
        /// </summary>
        public string? CustomsCottageNo { get; set; }

        /// <summary>
        /// تاریخ کوتاژ اظهارنامه گمرکی
        /// </summary>
        public DateTime? CustomsCottageDate { get; set; }

        /// <summary>
        /// شماره اشتراک / شناسه قبض بهره‌بردار
        /// </summary>
        public string? BillId { get; set; }

        /// <summary>
        /// مجموع مبلغ قبل از کسر تخیف
        /// </summary>
        public decimal? SumOfItemPriceNotIncludingDiscounts { get; set; }

        /// <summary>
        /// مجموع تخفیفات
        /// </summary>
        public decimal? SumOfItemDiscounts { get; set; }

        /// <summary>
        /// مجموع مبلغ پس از کسر تخیف
        /// </summary>
        public decimal? SumOfItemTotalPriceMinusDiscounts { get; set; }

        /// <summary>
        /// مجموع مالیات بر ارزش افزوده
        /// </summary>
        public decimal? SumOfItemValueAddedPrices { get; set; }

        /// <summary>
        /// مجموع سایر مالیات، عوارض و وجوه قانونی
        /// </summary>
        public decimal? SumOfItemOtherTaxes { get; set; }

        /// <summary>
        /// مجموع صورتحساب
        /// </summary>
        public decimal? TotalBill { get; set; }

        /// <summary>
        /// مجموع وزن خالص بر حسب کیلوگرم اظهارشدهٔ گمرکی
        /// </summary>
        public decimal? SumofItemNetWeightInCustoms { get; set; }

        /// <summary>
        /// مجموع ارزش ریالی اظهارشدهٔ گمرکی
        /// </summary>
        public decimal? SumOfCustomsClaimedPriceInRials { get; set; }

        /// <summary>
        /// مجموع ارزش ارزی بر اساس ارز اظهارنامهٔ گمرکی
        /// </summary>
        public decimal? SumOfCustomsClaimedPriceInCurrency { get; set; }

        /// <summary>
        /// روش تسویه
        /// </summary>
        public IntamediaInvoicePaymentType? PaymentType { get; set; }

        /// <summary>
        /// مبلغ پرداخت نقدی
        /// </summary>
        /// <remarks>
        /// اگر روش تسویه نقدی/نسیه باشد
        /// </remarks>
        public decimal? CashPartOfPayments { get; set; }

        /// <summary>
        /// مبلغ نسیه
        /// </summary>
        /// <remarks>
        /// اگر روش تسویه نقدی/نسیه باشد
        /// </remarks>
        public decimal? InDebtPartOfPayments { get; set; }

        /// <summary>
        /// مجموع سهم مالیات بر ارزش افزوده از پرداخت
        /// </summary>
        public decimal? TotalValueAddedPricePartOfCashPayment { get; set; }

        /// <summary>
        /// مالیات موضوع ماده ۱۷
        /// </summary>
        public decimal? Tax17 { get; set; }

        /// <summary>
        /// شماره اقتصادی آژانس
        /// </summary>
        public string? FlightTourAgentEccCode { get; set; }

        /// <summary>
        /// نام خریدار
        /// </summary>
        public string? BuyerName { get; set; }

        /// <summary>
        /// نشانی خریدار
        /// </summary>
        public string? BuyerAddress { get; set; }

        /// <summary>
        /// وضعیت مالیاتی خریدار
        /// </summary>
        public string? BuyerTaxpayerStatus { get; set; }

        /// <summary>
        /// نوع مالیاتی خریدار
        /// </summary>
        public string? BuyerTaxpayerType { get; set; }

        /// <summary>
        /// تلفن خریدار
        /// </summary>
        public string? BuyerPhoneNo { get; set; }

        /// <summary>
        /// نمابر خریدار
        /// </summary>
        public string? BuyerFaxNo { get; set; }

        /// <summary>
        /// ایمیل خریدار
        /// </summary>
        public string? BuyerEmail { get; set; }

        /// <summary>
        /// شمارهٔ ثبت شرکت خریدار
        /// </summary>
        public string? BuyerRegistrationNumber { get; set; }

        /// <summary>
        /// شماره پیگیری داخلی
        /// </summary>
        public string? InternalRefNumber { get; set; }

        /// <summary>
        /// توضیح اضافی برای صورتحساب
        /// </summary>
        public string? AdditionalNote { get; set; }

        /// <summary>
        /// توضیح اضافی برای چاپ
        /// </summary>
        public string? PrintNote { get; set; }

        /// <summary>
        /// محاسبهٔ خودکار جمع‌ها
        /// </summary>
        public bool RecalculateSums { get; set; }

        /// <summary>
        /// وضعیت
        /// </summary>
        public IntamediaInvoiceStatus InvoiceStatus { get; set; }

        /// <summary>
        /// زمان قرار گرفتن در صف ارسال
        /// </summary>
        public DateTime? QueueTime { get; set; }

        /// <summary>
        /// نشانی ارسال (سندباکس یا اصلی)
        /// </summary>
        public string? TransferApiUrl { get; set; }

        /// <summary>
        /// زمان ارسال
        /// </summary>
        public DateTime? TransferTime { get; set; }

        /// <summary>
        /// جزئیات خطا
        /// </summary>
        public string? TransferErrorDetail { get; set; }

        /// <summary>
        /// کد خطای ارسال
        /// </summary>
        public string? TransferErrorCode { get; set; }

        /// <summary>
        /// شناسهٔ استعلام
        /// </summary>
        public string? InquiryUUId { get; set; }

        /// <summary>
        /// رفرنس استعلام
        /// </summary>
        public string? InquiryReferenceNumber { get; set; }

        /// <summary>
        /// زمان مقرر شده برای استعلام
        /// </summary>
        public DateTime? InquiryDueDate { get; set; }

        /// <summary>
        /// تعداد استعلام‌های انجام شده
        /// </summary>
        public int InquiryAttempts { get; set; }

        /// <summary>
        /// وضعیت ارسال در سامانه
        /// </summary>
        public string IntamediaStatus { get; set; }

        /// <summary>
        /// حافظهٔ ارسال
        /// </summary>
        public string? TransferFiscalId { get; set; }

        /// <summary>
        /// پکت تایپ ارسال
        /// </summary>
        public string? TranferPacketType { get; set; }

        /// <summary>
        /// اعتبار مصرف شده
        /// </summary>
        public Guid? CreditConsumptionId { get; set; }

        /// <summary>
        /// کاربر ارسال کننده
        /// </summary>
        public Guid? TransferUserId { get; set; }

        /// <summary>
        /// شناسهٔ صف ارسال
        /// </summary>
        public Guid? SendQueueItemId { get; set; }

        /// <summary>
        /// شناسهٔ توسعه‌دهندهٔ ارسال
        /// </summary>
        public Guid? DeveloperId { get; set; }

        /// <summary>
        /// اقلام صورتحساب
        /// </summary>
        public ICollection<IntamediaInvoiceItem> Items { get; set; }

        /// <summary>
        /// پرداخت‌ها
        /// </summary>
        public ICollection<IntamediaInvoicePayment> Payments { get; set; }

        /// <summary>
        /// خطاها و هشدارها
        /// </summary>
        public ICollection<IntamediaResult> Results { get; set; }

        /// <summary>
        /// وضعیت در کارپوشه
        /// </summary>
        public IntamediaPostSendStatus? PostSendStatus { get; set; }

        /// <summary>
        /// متن وضعیت در کارپوشه
        /// </summary>
        public string? PostSendStatusText { get; set; }

        /// <summary>
        /// تاریخ درج در کارپوشه
        /// </summary>
        public DateTime? IntamediaInsertDate { get; set; }

        /// <summary>
        /// نقش مؤدی در کارپوشه
        /// </summary>
        public string? IntamediaSalerRole { get; set; }

        /// <summary>
        /// نام شعبهٔ خریدار
        /// </summary>
        public string? BuyerBranchName { get; set; }

        /// <summary>
        /// نام تجاری فروشنده
        /// </summary>
        public string? BuyerBrandName { get; set; }

        /// <summary>
        /// سال و دورهٔ فروشنده
        /// </summary>
        public string? SalerYearAndPeriod { get; set; }

        /// <summary>
        /// تاریخ صدور صورتحساب ارجاعی ابطال
        /// </summary>
        public DateTime? ReferringCancelInvoiceDate { get; set; }

        /// <summary>
        /// شماره بارنامه
        /// </summary>
        public string? LoadingNo { get; set; }

        /// <summary>
        /// شمارهٔ بارنامهٔ مرجع
        /// </summary>
        public string? LoadingReferenceNo { get; set; }

        /// <summary>
        /// کشور مبدأ
        /// </summary>
        public string? OriginCountryCode { get; set; }

        /// <summary>
        /// نام کشور مبدأ
        /// </summary>
        public string? OriginCountryName { get; set; }

        /// <summary>
        /// شهر مبدأ
        /// </summary>
        public string? OriginCityCode { get; set; }

        /// <summary>
        /// نام شهر مبدأ
        /// </summary>
        public string? OriginCityName { get; set; }

        /// <summary>
        /// کشو مقصد
        /// </summary>
        public string? DestinationCountryCode { get; set; }

        /// <summary>
        /// نام کشور مقصد
        /// </summary>
        public string? DestinationCountryName { get; set; }

        /// <summary>
        /// شهر مقصد
        /// </summary>
        public string? DestinationCityCode { get; set; }

        /// <summary>
        /// نام شهر مقصد
        /// </summary>
        public string? DestinationCityName { get; set; }

        /// <summary>
        /// شناسه ملی/شماره ملی/ شناسه مشارکت مدنی/ کد فراگیر اتباع غیر ایرانی فرستنده
        /// </summary>
        public string? TransmitterId { get; set; }

        /// <summary>
        /// شناسه ملی/شماره ملی/ شناسه مشارکت مدنی/ کد فراگیر اتباع غیر ایرانی گیرنده
        /// </summary>
        public string? ReceiverId { get; set; }

        /// <summary>
        /// نوع حمل
        /// </summary>
        public IntamediaInvoiceLoadingType? LoadingType { get; set; }

        /// <summary>
        /// شماره ناوگان
        /// </summary>
        public string? ContainerNo { get; set; }

        /// <summary>
        /// شناسه ملی/شماره ملی/ شناسه مشارکت مدنی/ کد فراگیر اتباع غیر ایرانی راننده (در حمل و نقل جاده ای)
        /// </summary>
        public string? DriverId { get; set; }

        /// <summary>
        /// کالاهای حمل شده
        /// </summary>
        public ICollection<IntamediaInvoiceShippingGood> ShippingGoods { get; set; }

        /// <summary>
        /// شمارهٔ اعلامیهٔ فروش
        /// </summary>
        public string? AnnouncementSalesNumber { get; set; }

        /// <summary>
        /// تاریخ اعلامیهٔ فروش
        /// </summary>
        public DateTime? AnnouncementSalesDate { get; set; }

        public static IntamediaTaxIdParts DecomposeTaxId(string taxId)
        {
            string hexTime = taxId.Substring(6, 5);
            int timeDayRange = int.Parse(hexTime, NumberStyles.HexNumber);
            int unixTimeSeconds = timeDayRange * 3600 * 24;

            var hexSerial = taxId.Substring(11, 10);

            return new IntamediaTaxIdParts()
            {
                MemoryId = taxId.Substring(0, 6),
                DateTime = DateTimeOffset.FromUnixTimeSeconds(unixTimeSeconds).DateTime,
                InvoiceNumber = long.Parse(hexSerial, NumberStyles.HexNumber)
            };
        }

        public void AutoFix()
        {
            if (InvoiceType == null && InvoiceSubject == IntamediaInvoiceSubject.Main)
            {
                if (string.IsNullOrEmpty(BuyerEccCode))
                {
                    InvoiceType = IntamediaInvoiceType.Type2;
                }
                else
                {
                    InvoiceType = IntamediaInvoiceType.Type1;
                }
            }

            CreateDate = null;
            if (InvoiceType == IntamediaInvoiceType.Type2)
            {
                TypeOfBuyer = null;
                SendBuyerIdNumber = false;
                SendBuyerPassportNo = false;
                SendBuyerPostalCode = false;
                SendBuyerEccCode = false;
                SendBuyerBranchCode = false;
            }
            if (string.IsNullOrWhiteSpace(BuyerBranchCode) || BuyerBranchCode == "0")
            {
                BuyerBranchCode = null;
            }
            if (string.IsNullOrWhiteSpace(BuyerPostalCode) || BuyerPostalCode == "0")
            {
                BuyerPostalCode = null;
            }
            if (string.IsNullOrWhiteSpace(BuyerPassportNo) || BuyerPassportNo == "0")
            {
                BuyerPassportNo = null;
            }
            if (string.IsNullOrWhiteSpace(BuyerIdNumber) || BuyerIdNumber == "0")
            {
                BuyerIdNumber = null;
            }
            if (BuyerEccCode == "0")
            {
                BuyerEccCode = null;
            }


            if (string.IsNullOrEmpty(RelatedInvoiceTaxId))
            {
                RelatedInvoiceTaxId = null;
            }

            if (PaymentType == IntamediaInvoicePaymentType.Cash)
            {
                CashPartOfPayments = null;
                InDebtPartOfPayments = null;
            }

            if (Items != null)
            {
                foreach (var item in Items)
                {
                    if (!string.IsNullOrEmpty(item.Description))
                    {
                        item.Description = item.Description.Trim().ApplyCorrectYeKe();
                    }

                    if (string.IsNullOrWhiteSpace(item.IntamediaUniqueContractNumber))
                    {
                        item.IntamediaUniqueContractNumber = null;
                    }
                    if (string.IsNullOrEmpty(item.OtherTax1Description) || item.OtherTax1Description == "0")
                    {
                        item.OtherTax1Description = null;
                        item.OtherTax1RateInPercent = null;
                    }
                    if (item.OtherTax1RateInPercent == 0)
                    {
                        item.OtherTax1RateInPercent = null;
                    }
                    if (string.IsNullOrEmpty(item.OtherTax2Description) || item.OtherTax2Description == "0")
                    {
                        item.OtherTax2Description = null;
                        item.OtherTax2RateInPercent = null;
                    }
                    if (item.OtherTax2RateInPercent == 0)
                    {
                        item.OtherTax2RateInPercent = null;
                    }
                }
            }


            if (InvoicePattern != IntamediaInvoicePattern.Pattern3Gold)
            {
                if (Items != null)
                {
                    foreach (var item in Items)
                    {
                        item.GoldBrokerShare = null;
                        item.GoldConstructionCost = null;
                        item.GoldConstructionCostPlusGoldSalerProfitPlusGoldBrokerShare = null;
                        item.GoldKarat = null;
                        item.GoldSalerProfit = null;
                    }
                }
            }

            if (InvoicePattern != IntamediaInvoicePattern.Pattern7Export)
            {
                if (Items != null)
                {
                    foreach (var item in Items)
                    {
                        item.NetWeightInCustoms = null;
                        item.CustomsClaimedPriceInCurrency = null;
                        item.CustomsClaimedPriceInRials = null;
                    }
                }

                SalerCustomsLicenceNo = null;
                SalerCustomsCode = null;
                SumOfCustomsClaimedPriceInCurrency = null;
                SumOfCustomsClaimedPriceInRials = null;
                if (InvoicePattern != IntamediaInvoicePattern.Pattern8BillOfLading)
                {
                    SumofItemNetWeightInCustoms = null;
                }

                CustomsCottageDate = null;
                CustomsCottageNo = null;
            }

            if (InvoicePattern != IntamediaInvoicePattern.Pattern4Contract)
            {
                SalerContractNo = null;
            }

            if (InvoicePattern != IntamediaInvoicePattern.Pattern2CurrencySales && InvoicePattern != IntamediaInvoicePattern.Pattern7Export)
            {
                if (Items != null)
                {
                    foreach (var item in Items)
                    {
                        item.CurrencyExchangeRateInRial = null;
                        item.CurrencySalesProfitInRials = null;
                        item.IntamediaCurrencyCode = null;
                        item.UnitPriceInCurrency = null;
                        item.CurrencySalesVatReferenceOrProfitInRials = null;
                        item.CurrencySalesPurchaseInRials = null;
                    }
                }
            }

            if (InvoicePattern != IntamediaInvoicePattern.Pattern6AirlineTicket)
            {
                FlightTourAgentEccCode = null;
                FlightType = null;
            }

            if (InvoicePattern != IntamediaInvoicePattern.Pattern8BillOfLading)
            {
                LoadingNo = null;
                LoadingReferenceNo = null;
                OriginCountryCode = null;
                OriginCountryName = null;
                OriginCityCode = null;
                OriginCityName = null;
                DestinationCountryCode = null;
                DestinationCountryName = null;
                DestinationCityCode = null;
                DestinationCityName = null;
                TransmitterId = null;
                ReceiverId = null;
                LoadingType = null;
                ContainerNo = null;
                DriverId = null;
                ShippingGoods = null;
            }

            if (InvoicePattern != IntamediaInvoicePattern.Pattern11Bourse)
            {
                AnnouncementSalesNumber = null;
                AnnouncementSalesDate = null;
            }
        }
    }
}
