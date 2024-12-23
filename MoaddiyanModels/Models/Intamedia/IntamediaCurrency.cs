namespace TadbirTaxService.Models.Intamedia
{
    /// <summary>
    /// according to https://www.six-group.com/dam/download/financial-information/data-center/iso-currrency/lists/list-one.xls
    /// </summary>
    public class IntamediaCurrency
    {
        /// <summary>
        /// Id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// entity
        /// </summary>
        public string Entity { get; set; }

        /// <summary>
        /// currency
        /// </summary>
        public string Currency { get; set; }

        /// <summary>
        /// Alphabetic Code
        /// </summary>
        public string AlphabeticCode { get; set; }

        /// <summary>
        /// Numeric Code
        /// </summary>
        public string NumericCode { get; set; }

        /// <summary>
        /// Minor Unit
        /// </summary>
        public int MinorUnit { get; set; }

        /// <summary>
        /// Fund
        /// </summary>
        public bool Fund { get; set; }
    }
}
