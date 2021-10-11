namespace Pluralize
{
    public static class PluralizeTask
    {
        public static string PluralizeRubles(int count)
        {
            // проверяет, заканчивается число на 11-14 либо на 0 либо на 5-9
            if (count % 100 > 10 && count % 100 < 15 || count % 10 == 0 || count % 10 >= 5)
                return "рублей";
            // проверяет, заканчивается число на 1 или заканчивается на 2-4
            return count % 10 == 1 ? "рубль" : "рубля";
        }
    }
}