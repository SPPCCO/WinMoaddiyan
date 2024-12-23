namespace TadbirTaxService.Models.Intamedia
{
    public class IntamediaMeasurementUnit
    {
        /// <summary>
        /// Id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// نام
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// کد
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// Units
        /// </summary>
        public static List<IntamediaMeasurementUnit> Units
        {
            get
            {
                return [
                  new IntamediaMeasurementUnit(){ Id = 1, Name= "لنگه", Code= "1611"},
                  new IntamediaMeasurementUnit(){Id= 2, Name = "عدل",  Code = "1612"},
                  new IntamediaMeasurementUnit(){Id= 3, Name = "جعبه",  Code = "1613"},
                  new IntamediaMeasurementUnit(){Id= 4, Name = "توپ",  Code = "1618"},
                  new IntamediaMeasurementUnit(){Id= 5, Name = "ست",  Code = "1619"},
                  new IntamediaMeasurementUnit(){Id= 6, Name = "دست",  Code = "1620"},
                  new IntamediaMeasurementUnit(){Id= 7, Name = "کارتن",  Code = "1624"},
                  new IntamediaMeasurementUnit(){Id= 8, Name = "عدد",  Code = "1627"},
                  new IntamediaMeasurementUnit(){Id= 9, Name = "بسته",  Code = "1628"},
                  new IntamediaMeasurementUnit(){Id= 10, Name = "پاکت",  Code = "1629"},
                  new IntamediaMeasurementUnit(){Id= 11, Name = "دستگاه",  Code = "1631"},
                  new IntamediaMeasurementUnit(){Id= 12, Name = "تخته",  Code = "1640"},
                  new IntamediaMeasurementUnit(){Id= 13, Name = "رول",  Code = "1641"},
                  new IntamediaMeasurementUnit(){Id= 14, Name = "طاقه",  Code = "1642"},
                  new IntamediaMeasurementUnit(){Id= 15, Name = "جفت",  Code = "1643"},
                  new IntamediaMeasurementUnit(){Id= 16, Name = "متر مربع",  Code = "1645"},
                  new IntamediaMeasurementUnit(){Id= 17, Name = "پالت",  Code = "1649"},
                  new IntamediaMeasurementUnit(){Id= 18, Name = "دوجین",  Code = "1661"},
                  new IntamediaMeasurementUnit(){Id= 19, Name = "رینگ (حلقه)",  Code = "1668"},
                  new IntamediaMeasurementUnit(){Id= 20, Name = "قراص",  Code = "1673"},
                  new IntamediaMeasurementUnit(){Id= 21, Name = "(bundle)  قراصه",  Code = "1694"},
                  new IntamediaMeasurementUnit(){Id= 22, Name = "لیتر",  Code = "1637"},
                  new IntamediaMeasurementUnit(){Id= 23, Name = "ساشه",  Code = "1650"},
                  new IntamediaMeasurementUnit(){Id= 24, Name = "کپسول",  Code = "1683"},
                  new IntamediaMeasurementUnit(){Id= 25, Name = "بندیل",  Code = "1656"},
                  new IntamediaMeasurementUnit(){Id= 26, Name = "حلقه (رول)",  Code = "1630"},
                  new IntamediaMeasurementUnit(){Id= 27, Name = "قالب",  Code = "163"},
                  new IntamediaMeasurementUnit(){Id= 28, Name = "شانه",  Code = "1660"},
                  new IntamediaMeasurementUnit(){Id= 29, Name = "متر مكعب",  Code = "1647"},
                  new IntamediaMeasurementUnit(){Id= 30, Name = "ثوب",  Code = "1689"},
                  new IntamediaMeasurementUnit(){Id= 31, Name = "نیم دوجین",  Code = "1690"},
                  new IntamediaMeasurementUnit(){Id= 32, Name = "قرقره",  Code = "1635"},
                  new IntamediaMeasurementUnit(){Id= 33, Name = "کیلوگرم",  Code = "164"},
                  new IntamediaMeasurementUnit(){Id= 34, Name = "بطری",  Code = "1638"},
                  new IntamediaMeasurementUnit(){Id= 35, Name = "برگ",  Code = "161"},
                  new IntamediaMeasurementUnit(){Id= 36, Name = "سطل",  Code = "1625"},
                  new IntamediaMeasurementUnit(){Id= 37, Name = "ورق",  Code = "1654"},
                  new IntamediaMeasurementUnit(){Id= 38, Name = "شاخه",  Code = "1646"},
                  new IntamediaMeasurementUnit(){Id= 39, Name = "قوطی",  Code = "1644"},
                  new IntamediaMeasurementUnit(){Id= 40, Name = "جلد",  Code = "1617"},
                  new IntamediaMeasurementUnit(){Id= 41, Name = "تیوب",  Code = "162"},
                  new IntamediaMeasurementUnit(){Id= 42, Name = "متر",  Code = "165"},
                  new IntamediaMeasurementUnit(){Id= 43, Name = "کلاف",  Code = "1610"},
                  new IntamediaMeasurementUnit(){Id= 44, Name = "کیسه",  Code = "1615"},
                  new IntamediaMeasurementUnit(){Id= 45, Name = "طغرا",  Code = "1680"},
                  new IntamediaMeasurementUnit(){Id= 46, Name = "بشكه",  Code = "1639"},
                  new IntamediaMeasurementUnit(){Id= 47, Name = "گالن",  Code = "1614"},
                  new IntamediaMeasurementUnit(){Id= 48, Name = "فاقد بسته بندی",  Code = "1687"},
                  new IntamediaMeasurementUnit(){ Id= 49, Name = " کارتن (master case)",  Code = "1693"},
                  new IntamediaMeasurementUnit(){Id= 50, Name = "صفحه",  Code = "166"},
                  new IntamediaMeasurementUnit(){Id= 51, Name = "مخزن",  Code = "1666"},
                  new IntamediaMeasurementUnit(){Id= 52, Name = "تانكر",  Code = "1626"},
                  new IntamediaMeasurementUnit(){Id= 53, Name = "دبه",  Code = "1648"},
                  new IntamediaMeasurementUnit(){Id= 54, Name = "سبد",  Code = "1684"},
                  new IntamediaMeasurementUnit(){Id= 55, Name = "تن",  Code = "169"},
                  new IntamediaMeasurementUnit(){Id= 56, Name = "بانكه",  Code = "1651"},
                  new IntamediaMeasurementUnit(){Id= 57, Name = "سیلندر",  Code = "1633"},
                  new IntamediaMeasurementUnit(){Id= 58, Name = "فوت مربع",  Code = "1679"},
                  new IntamediaMeasurementUnit(){Id= 59, Name = "حلب",  Code = "168"},
                  new IntamediaMeasurementUnit(){Id= 60, Name = "شیت",  Code = "1665"},
                  new IntamediaMeasurementUnit(){Id= 61, Name = "چلیك",  Code = "1659"},
                  new IntamediaMeasurementUnit(){Id= 62, Name = "جام",  Code = "1636"},
                  new IntamediaMeasurementUnit(){Id= 63, Name = "گرم",  Code = "1622"},
                  new IntamediaMeasurementUnit(){Id= 64, Name = "نخ",  Code = "1616"},
                  new IntamediaMeasurementUnit(){Id= 65, Name = "شعله",  Code = "1652"},
                  new IntamediaMeasurementUnit(){Id= 66, Name = "قیراط",  Code = "1678"},
                  new IntamediaMeasurementUnit(){Id= 67, Name = "میلی لیتر",  Code = "16100"},
                  new IntamediaMeasurementUnit(){Id= 68, Name = "میلی متر",  Code = "16101"},
                  new IntamediaMeasurementUnit(){Id= 69, Name = "میلی گرم",  Code = "16102"},
                  new IntamediaMeasurementUnit(){Id= 70, Name = "ساعت",  Code = "16103"},
                  new IntamediaMeasurementUnit(){Id= 71, Name = "روز",  Code = "16104"},
                  new IntamediaMeasurementUnit(){Id= 72, Name = "تن کیلومتر",  Code = "16105"},
                  new IntamediaMeasurementUnit(){Id= 73, Name = "کیلووات ساعت",  Code = "1669"},
                  new IntamediaMeasurementUnit(){Id= 74, Name = "نفر",  Code = "1676"},
                  new IntamediaMeasurementUnit(){Id= 75, Name = "ثانیه",  Code = "16110"},
                  new IntamediaMeasurementUnit(){Id= 76, Name = "دقیقه",  Code = "16111"},
                  new IntamediaMeasurementUnit(){Id= 77, Name = "ماه",  Code = "16112"},
                  new IntamediaMeasurementUnit(){Id= 78, Name = "سال",  Code = "16113"},
                  new IntamediaMeasurementUnit(){Id= 79, Name = "قطعه",  Code = "16114"},
                  new IntamediaMeasurementUnit(){Id= 80, Name = "سانتی متر",  Code = "16115"},
                  new IntamediaMeasurementUnit(){Id= 81, Name = "سانتی متر مربع",  Code = "16116"},
                  new IntamediaMeasurementUnit(){Id= 82, Name = "فروند",  Code = "1632"},
                  new IntamediaMeasurementUnit(){Id= 83, Name = "واحد",  Code = "1653"},
                  new IntamediaMeasurementUnit(){Id= 84, Name = "لیوان",  Code = "16108"},
                  new IntamediaMeasurementUnit(){Id= 85, Name = "نوبت",  Code = "16117"},
                  new IntamediaMeasurementUnit(){Id= 86, Name = "مگا وات ساعت",  Code = "16118"},
                  new IntamediaMeasurementUnit(){Id= 87, Name = "گیگا بایت بر ثانیه",  Code = "16119"},
                  new IntamediaMeasurementUnit() { Id = 88, Name = "ویال",  Code = "1681"},
                  new IntamediaMeasurementUnit() { Id = 89, Name = "حلقه (دیسك)",  Code = "1667"},
                  new IntamediaMeasurementUnit() { Id = 90, Name = "نسخه (جلد)",  Code = "16120"},
                  new IntamediaMeasurementUnit() { Id = 91, Name = " نفر- ساعت",  Code = "16121"},
                  new IntamediaMeasurementUnit() { Id = 92, Name = " کیلومتر",  Code = "16122"},
                  new IntamediaMeasurementUnit() { Id = 93, Name = " آمپر",  Code = "16125"},
                  new IntamediaMeasurementUnit() { Id = 94, Name = " میلی آمپر",  Code = "16126"},
                  new IntamediaMeasurementUnit() { Id = 95, Name = " مثقال",  Code = "16127"},
                  new IntamediaMeasurementUnit() { Id = 96, Name = " سیر",  Code = "16128"},
                  new IntamediaMeasurementUnit() { Id = 97, Name = "(time)دفعه",  Code = "16129"},
                  new IntamediaMeasurementUnit() { Id = 98, Name = "مگا یونیت",  Code = "16130"},
                  new IntamediaMeasurementUnit() { Id = 99, Name = "کادر",  Code = "16131"},
                  new IntamediaMeasurementUnit() { Id = 100, Name = "پرس",  Code = "16132"},
                  new IntamediaMeasurementUnit() { Id = 101, Name = "بلوک",  Code = "16133"},
                ];
            }
        }

    }
}
