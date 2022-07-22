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
    }
}
