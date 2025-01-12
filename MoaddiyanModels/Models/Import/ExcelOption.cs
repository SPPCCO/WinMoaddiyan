namespace TadbirTaxService.Models.Import
{
    public class ExcelOption
    {
        /// <summary>
        /// Id
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// نام تنظیم
        /// </summary>
        public string OptionName { get; set; }

        /// <summary>
        /// مقدار تنظیم
        /// </summary>
        public string OptionValue { get; set; }
    }
}
