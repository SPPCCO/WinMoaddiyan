using RSecurityBackend.Models.Cloud;

namespace TadbirTaxService.Models.Import
{
    public class ExcelMapping
    {
        /// <summary>
        /// Id
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// عنوان
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// شرکت مالک
        /// </summary>
        public Guid? WorkspaceId { get; set; }

        /// <summary>
        /// شرکت
        /// </summary>
        public virtual RWorkspace? Workspace { get; set; }

        /// <summary>
        /// نگاشت ستونها
        /// </summary>
        public ICollection<ColumnMapping> Mappings { get; set; }

        /// <summary>
        /// تنظیمات اکسل
        /// </summary>
        public ICollection<ExcelOption> Options { get; set; }

        /// <summary>
        /// tostring
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Title;
        }
    }
}
