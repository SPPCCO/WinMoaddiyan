
namespace TadbirTaxService.Models.Intamedia
{
    public class IntamediaInvoiceStatusDescriptor
    {
        public IntamediaInvoiceStatus IntamediaInvoiceStatus { get; set; }
        public override string ToString()
        {
            return Strings[IntamediaInvoiceStatus];
        }

        public static IntamediaInvoiceStatusDescriptor[] Values
        {
            get
            {
                return Enum.GetValues<IntamediaInvoiceStatus>()
                    .Select(x => new IntamediaInvoiceStatusDescriptor()
                {
                        IntamediaInvoiceStatus = x,
                }).ToArray();
            }
        }

        private Dictionary<IntamediaInvoiceStatus, string> Strings
        {
            get
            {
                return new Dictionary<IntamediaInvoiceStatus, string>
                {
                    { IntamediaInvoiceStatus.Draft, "ارسال نشده"},
                    { IntamediaInvoiceStatus.Queued , "در صف ارسال"},
                    { IntamediaInvoiceStatus.Sending , "در دست ارسال"},
                    { IntamediaInvoiceStatus.Inquirying , "در دست استعلام"},
                    { IntamediaInvoiceStatus.Errornous , "دارای خطا"},
                    { IntamediaInvoiceStatus.Succeeded , "ارسال موفق"},
                    { IntamediaInvoiceStatus.Edited , "ویرایش شده پس از ارسال"},
                    { IntamediaInvoiceStatus.InProgress , "در حال پردازش"},
                    { IntamediaInvoiceStatus.WaitingForInquiry , "در بازهٔ انتظار پیش از استعلام"},
                    { IntamediaInvoiceStatus.NotFound , "NOT_FOUND"},
                    { IntamediaInvoiceStatus.Unknown , "خطای ناشناخته"},
                    { IntamediaInvoiceStatus.InquiryAborted , "خروج دستی از صف استعلام"},
                    { IntamediaInvoiceStatus.SendFailed , "خطا در ارتباط با سامانه"},
                    { IntamediaInvoiceStatus.SucceededInLastSession , "ارسال موفق (اخیر)"},
                    { IntamediaInvoiceStatus.ChargeRunOut , "عدم ارسال به دلیل شارژ ناکافی"},
                    { IntamediaInvoiceStatus.Timeout , "پردازش طولانی"},
                    { IntamediaInvoiceStatus.NotCurrent , "غیرجاری"},
                    { IntamediaInvoiceStatus.Reserved17 , "Reserved17"},
                    { IntamediaInvoiceStatus.Reserved18 , "Reserved18"},
                    { IntamediaInvoiceStatus.Reserved19 , "Reserved19"},
                    { IntamediaInvoiceStatus.Current , "جاری"},
                    { IntamediaInvoiceStatus.All , "همه"},
                };
            }
        }
    }
}
