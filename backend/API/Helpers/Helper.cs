namespace API.Helpers
{
    public class Helper
    {
        public static string getNextOneYear(DateTime date)
        {
            var a = date.Year + 1;
            return a.ToString();
        }
        public static string getNextTwoYear(DateTime date)
        {
            var a = date.Year + 2;
            return a.ToString();
        }
        public static string getLastYear(DateTime date)
        {
            var a = date.Year - 1;
            return a.ToString();
        }
        public static bool IsDigitsOnly(string str)
        {
            if (string.IsNullOrEmpty(str) || string.IsNullOrWhiteSpace(str))
            {
                return false;
            }
            if (str.Contains("Corsiva lab") || str.Contains("Customer"))
            {
                return false;
            }
            return true;
        }
        public static bool IsIntergerOnly(int? a)
        {
            if (a != null)
            {
                return true;
            }
            return false;
        }
        public static bool CheckObjNull(object a)
        {
            if (a != null)
            {
                return true;
            }
            return false;
        }
    }
}
