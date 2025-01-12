namespace TadbirTaxService.Models.Import
{
    public class ColumnMapping
    {
        /// <summary>
        /// id
        /// </summary>
        public Guid Id { get; set; }
        /// <summary>
        /// field
        /// </summary>
        public ImportFieldType Field { get; set; }
        /// <summary>
        /// column
        /// </summary>
        public string Column { get; set; }
        /// <summary>
        /// default value
        /// </summary>
        public string NoExcelValue { get; set; }

    }
}
