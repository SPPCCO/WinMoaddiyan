namespace TadbirTaxService.Models.Intamedia
{
    public enum IntamediaInvoicePattern
    {
        /// <summary>
        /// الگوی اول (فروش)
        /// </summary>
        Pattern1NormalSales = 1,
        /// <summary>
        /// الگوی دوم (فروش ارز)
        /// </summary>
        Pattern2CurrencySales = 2,
        /// <summary>
        /// الگوی سوم(صورتحساب طلا،جواهر و پلاتین)
        /// </summary>
        Pattern3Gold = 3,
        /// <summary>
        ///  الگوی چهارم (قرارداد پیمانکاری
        /// </summary>
        Pattern4Contract = 4,
        /// <summary>
        /// الگوی پنجم (قبوض خدماتی)
        /// </summary>
        Pattern5ServiceBills = 5,
        /// <summary>
        /// الگوی ششم (بلیط هواپیما)
        /// </summary>
        Pattern6AirlineTicket = 6,
        /// <summary>
        /// الگوی هفتم (صادرات)
        /// </summary>
        Pattern7Export = 7,
        /// <summary>
        /// الگوی هشتم (بارنامه)
        /// </summary>
        Pattern8BillOfLading = 8,
        /// <summary>
        /// الگوی یازدهم (بورس اوراق بهادار مبتنی بر کالا)
        /// </summary>
        Pattern11Bourse = 11,
    }
}
