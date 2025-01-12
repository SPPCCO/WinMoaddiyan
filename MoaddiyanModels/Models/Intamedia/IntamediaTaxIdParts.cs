namespace TadbirTaxService.Models.Intamedia
{
    public class IntamediaTaxIdParts
    {
        /// <summary>
        /// memory id
        /// </summary>
        public string MemoryId { get; set; }
        /// <summary>
        /// شماره
        /// </summary>
        public long InvoiceNumber { get; set; }

        /// <summary>
        /// utc
        /// </summary>
        public DateTime DateTime { get; set; }
    }

}
