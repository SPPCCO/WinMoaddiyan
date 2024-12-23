namespace TadbirTaxService.Models.Intamedia
{
    /// <summary>
    /// کالاهای دارای شناسه
    /// </summary>
    public class IntamediaStuff
    {
        /// <summary>
        /// id
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// شناسه کالا
        /// </summary>
        /// <sample>
        /// 2720000000050
        /// </sample>
        public string StuffId { get; set; }

        /// <summary>
        /// Type
        /// </summary>
        /// <sample>
        /// شناسه عمومی تولید داخل(کالا)
        /// </sample>
        public string StuffType { get; set; }

        /// <summary>
        /// Date
        /// </summary>
        /// <sample>
        /// 1401-07-24
        /// </sample>
        public string StuffDate { get; set; }

        /// <summary>
        /// RunDate
        /// </summary>
        /// <sample>
        /// 1400-10-13
        /// </sample>
        public string RunDate { get; set; }

        /// <summary>
        /// ExpirationDate
        /// </summary>
        /// <sample>
        /// 1400-10-13
        /// </sample>
        public string ExpirationDate { get; set; }

        /// <summary>
        /// SpecialOrGeneral
        /// </summary>
        public string SpecialOrGeneral { get; set; }

        /// <summary>
        /// TaxableOrFree
        /// </summary>
        /// <sample>
        /// معاف
        /// </sample>
        /// <sample>
        /// مشمول
        /// </sample>
        public string TaxableOrFree { get; set; }

        /// <summary>
        /// Vat
        /// </summary>
        /// <sample>
        /// 10
        /// </sample>
        public decimal Vat { get; set; }

        /// <summary>
        /// VatCustomPurposes
        /// </summary>
        public decimal? VatCustomPurposes { get; set; }

        /// <summary>
        /// DescriptionOfID
        /// </summary>
        public string DescriptionOfID { get; set; }

        /// <summary>
        /// Normalized field for search
        /// </summary>
        public string NormalizedField { get; set; }
    }
}
