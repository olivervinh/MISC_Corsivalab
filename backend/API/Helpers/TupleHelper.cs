namespace API.Helpers
{
    public class TupleHelper
    {
        public static string GetProjectNature(int Id)
        {
            foreach(Tuple<string,string> item in ConfigContentHelper.projectNature2)
            {
                if (item.Item1 == Id.ToString())
                {
                    return item.Item2;
                }
            }
            return string.Empty;
        }
        public static string getPhase(int id)
        {
            foreach (Tuple<string, string> s in ConfigContentHelper.projectPhase)
            {
                if (s.Item1 == id.ToString())
                {
                    return s.Item2;
                }
            }
            return "-";
        } 
    }
}
