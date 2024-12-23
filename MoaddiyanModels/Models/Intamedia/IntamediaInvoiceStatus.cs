namespace TadbirTaxService.Models.Intamedia
{
    public enum IntamediaInvoiceStatus
    {
        Draft = 0,
        Queued = 1,
        Sending = 2,
        Inquirying = 3,
        Errornous = 4,
        Succeeded = 5,
        Edited = 6,
        InProgress = 7,
        WaitingForInquiry = 8,
        NotFound = 9,
        Unknown = 10,
        InquiryAborted = 11,//خروج از صف استعلام
        SendFailed = 12,
        SucceededInLastSession = 13,
        ChargeRunOut = 14,
        Timeout = 15,
        NotCurrent = 16,//غیرجاری
        Reserved17 = 17,
        Reserved18 = 18,
        Reserved19 = 19,
        Current = 20,
        All = 21,

    }
}
