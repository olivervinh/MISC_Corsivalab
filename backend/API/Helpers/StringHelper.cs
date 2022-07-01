namespace API.Helpers
{
    public class StringHelper
    {
        public static string SplitReqString(string s)
        {
            if (s.Contains(","))
            {
                string[] a = s.Split(',');
                return a[0];
            }
            return s;
        }
        public static string SplitHourAcessString(string s)
        {
            string[] a = s.Split(' ');
            return a[0];
        }
        public static string SplitStringIncludesListComma(string s)
        {
            if (s.Contains(","))
            {
                string[] a = s.Split(',');
                var c = "";
                for (int i = 0; i < a.Length; i++)
                {
                    c += a[i];
                }
                return c;
            }
            else
            {
                return s;
            }
        }
    }
}