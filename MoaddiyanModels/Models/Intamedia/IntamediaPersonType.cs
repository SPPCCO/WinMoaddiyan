namespace TadbirTaxService.Models.Intamedia
{
    public enum IntamediaPersonType
    {
        /// <summary>
        /// حقیقی
        /// </summary>
        IranianPerson = 1,
        /// <summary>
        /// حقوقی
        /// </summary>
        Company = 2,
        /// <summary>
        /// مشارکت مدنی: دو یا چند نفر شریک هستند و پروندهٔ مالیاتی شراکتی دارند
        /// </summary>
        MultiplePerson = 3,
        /// <summary>
        /// اتباع غیرایرانی
        /// </summary>
        NonIranian = 4,
    }
}
