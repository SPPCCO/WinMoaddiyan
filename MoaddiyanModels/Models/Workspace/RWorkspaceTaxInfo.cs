using RSecurityBackend.Models.Cloud;
using RSecurityBackend.Models.Image;

namespace TadbirTaxService.Models.Workspace
{
    /// <summary>
    /// Workspace tax info
    /// </summary>
    public class RWorkspaceTaxInfo
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
        /// Workspace
        /// </summary>
        public RWorkspace Workspace { get; set; }

        /// <summary>
        /// brand name (نام متداول برند)
        /// </summary>
        public string BrandName { get; set; }

        /// <summary>
        /// Official Name (نام ثبت شدهٔ قانونی)
        /// </summary>
        public string OfficialName { get; set; }

        /// <summary>
        /// National Id (شناسهٔ ملی)
        /// </summary>
        public string NationalId { get; set; }

        /// <summary>
        /// Tax Payer Identification Number (کد اقتصادی)
        /// </summary>
        public string EconomicCode { get; set; }

        /// <summary>
        /// کد شعبهٔ فروشنده
        /// </summary>
        public string BranchCode { get; set; }

        /// <summary>
        /// logo image id
        /// </summary>
        public Guid? LogoImageId { get; set; }

        /// <summary>
        /// logo image
        /// </summary>
        public virtual RImage LogoImage { get; set; }

        /// <summary>
        /// tax memory id
        /// </summary>
        public string TaxMemoryId { get; set; }

        /// <summary>
        /// private key
        /// </summary>
        public string TaxPrivateKey { get; set; }

        /// <summary>
        /// Governmental / Non-Governmental
        /// </summary>
        public string OrganizationType { get; set; } = "Non-Governmental";

        /// <summary>
        /// Subunit 1 in Persian
        /// </summary>
        public string OrganizationUnitLevel1 { get; set; } = "";

        /// <summary>
        /// Subunit 2  in Persian
        /// </summary>
        public string OrganizationUnitLevel2 { get; set; } = "";

        /// <summary>
        /// Subunit 3  in Persian
        /// </summary>
        public string OrganizationUnitLevel3 { get; set; } = "";

        /// <summary>
        /// Organization Unit [Stamp] in English
        /// </summary>
        /// <smaple>
        /// pardazeshmoviazisaman
        /// </smaple>
        public string OrganizationUnitOrNameFamilyInEnglish { get; set; } = "";

        /// <summary>
        /// Email
        /// </summary>
        /// <sample>
        /// info@sppc.co.ir
        /// </sample>
        public string Email { get; set; } = "";

        /// <summary>
        /// csr first name
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// SurName in Persian
        /// </summary>
        /// <sample>
        /// حسن
        /// </sample>
        public string Surname { get; set; } = "";

        /// <summary>
        /// First Name in Persian
        /// </summary>
        /// <sample>
        /// حسینی
        /// </sample>
        public string GivenName { get; set; } = "";

        /// <summary>
        /// Provice in Persian
        /// </summary>
        /// <sample>
        /// مرکزی
        /// </sample>
        public string Province { get; set; } = "";

        /// <summary>
        /// City in Persian
        /// </summary>
        /// <sample>
        /// اراک
        /// </sample>
        public string City { get; set; } = "";

        /// <summary>
        /// Role
        /// </summary>
        /// <sample>
        /// مدیر عامل
        /// </sample>
        public string Role { get; set; } = "";

        /// <summary>
        /// نشانی
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// کد پستی
        /// </summary>
        public string PostalCode { get; set; }

        /// <summary>
        /// شماره تلفن
        /// </summary>
        public string PhoneNumber { get; set; }

        /// <summary>
        /// نمابر
        /// </summary>
        public string FaxNumber { get; set; }

        /// <summary>
        /// متن عمومی قابل استفاده در فاکتور شماره ۱
        /// </summary>
        public string FactorsNote1 { get; set; }

        /// <summary>
        /// متن عمومی قابل استفاده در فاکتور شماره ۲
        /// </summary>
        public string FactorsNote2 { get; set; }

        /// <summary>
        /// متن عمومی قابل استفاده در فاکتور شماره ۳
        /// </summary>
        public string FactorsNote3 { get; set; }

        /// <summary>
        /// stamp image id
        /// </summary>
        public Guid? StampImageId { get; set; }

        /// <summary>
        /// stamp image
        /// </summary>
        public virtual RImage StampImage { get; set; }

        /// <summary>
        /// ارسال اطلاعات به سندباکس
        /// </summary>
        public bool SandBox { get; set; }

        /// <summary>
        /// شماره ثبت شرکت
        /// </summary>
        public string? RegistrationNumber { get; set; }

        /// <summary>
        /// کلید عمومی
        /// </summary>
        public string? TaxPublicKey { get; set; }

        /// <summary>
        /// درخواست گواهی امضا
        /// </summary>
        public string? CertificateSignReq { get; set; }

    }
}
