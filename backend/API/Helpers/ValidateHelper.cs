using System.Net.Mail;
using System.Text.RegularExpressions;
namespace API.Helpers
{
    public class ValidateHelper
    {
        public static bool ValidateWrongStringLength50(string s)
        {
            if(s.Count()>50)
                return true;
            return false;  
        }
        public static bool ValidateWrongNumber(string s)
        {
            if (!Regex.Match(s, @"^[0-9][0-9,\.]+$").Success)
                return true;
            return false;
        }
        public static bool ValidateWrongNumberDouble(string s)
        {
            double value;
            bool isDouble = Double.TryParse(StringHelper.SplitStringIncludesListComma(s), out value);
            if (isDouble)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public static bool ValidateWrongNumberInt(string s)
        {
            int value;
            bool isInt = int.TryParse(StringHelper.SplitStringIncludesListComma(s), out value);
            if (isInt)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public static bool ValidateWrongStringName(string s)
        {
            if (string.IsNullOrEmpty(s) || string.IsNullOrWhiteSpace(s))
                return true;
            return false;
        }
        public static bool ValidateWrongStringEmail(string s)
        {
            try
            {
                MailAddress m = new MailAddress(s);

                return false;
            }
            catch (FormatException)
            {
                return true;
            }
        }
        public static bool ValidateWrongStringPhoneNumber(string s)
        {
            if (!Regex.Match(s, @"^[(]{0,1}[0-9]{1,4}[)]{0,1}[-\s\./0-9]*$").Success || string.IsNullOrEmpty(s) || string.IsNullOrWhiteSpace(s))
                return true;
            return false;
        }
        public static bool InValidURL(string URL)
        {
            string Pattern = @"^(?:http(s)?:\/\/)?[\w.-]+(?:\.[\w\.-]+)+[\w\-\._~:/?#[\]@!\$&'\(\)\*\+,;=.]+$";
            Regex Rgx = new Regex(Pattern, RegexOptions.Compiled | RegexOptions.IgnoreCase);
            return !Rgx.IsMatch(URL);
        }
    }
}
