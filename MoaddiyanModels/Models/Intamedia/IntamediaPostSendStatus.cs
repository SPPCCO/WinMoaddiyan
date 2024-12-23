namespace TadbirTaxService.Models.Intamedia
{
    public enum IntamediaPostSendStatus
    {
        /// <summary>
        /// در انتظار واکنش
        /// </summary>
        WaitingForAction = 0,

        /// <summary>
        /// عدم نیاز به واکنش
        /// </summary>
        NoActionNeeded = 1,

        /// <summary>
        /// عدم امکان واکنش
        /// </summary>
        ActionDenied = 2,

        /// <summary>
        /// تأیید سیستمی
        /// </summary>
        SystemApproved = 3,

        /// <summary>
        /// تأیید شده
        /// </summary>
        Approved = 4,

        /// <summary>
        /// رد شده
        /// </summary>
        Rejected = 5,

        /// <summary>
        /// باطل شده
        /// </summary>
        Cancelled = 6,

    }
}
