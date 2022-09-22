namespace API.Helpers
{
    public static class ConfigContentHelper
    {
        public static List<Tuple<string, string>> projectPhase = getProjectPhase();
        public static List<Tuple<string, string>> projectNature = getProjectNature();
        public static List<Tuple<string, string>> projectNature2 = getProjectNature2();
        private static List<Tuple<string, string>> getProjectPhase()
        {
            List<Tuple<string, string>> list = new List<Tuple<string, string>>();
            list.Add(new Tuple<string, string>("1", "Internal Project"));
            list.Add(new Tuple<string, string>("2", "Building Project"));
            list.Add(new Tuple<string, string>("3", "Project ended w maintenance"));
            list.Add(new Tuple<string, string>("4", "Project ended w/o maintenance"));
            return list;

        }

        private static List<Tuple<string, string>> getProjectNature()
        {
            List<Tuple<string, string>> list = new List<Tuple<string, string>>();
            list.Add(new Tuple<string, string>("1", "Internal"));
            list.Add(new Tuple<string, string>("2", "Retail"));
            list.Add(new Tuple<string, string>("3", "Real Estate"));
            list.Add(new Tuple<string, string>("4", "F&B"));
            list.Add(new Tuple<string, string>("5", "Manufacturing, Engineering, and Technology"));
            list.Add(new Tuple<string, string>("6", "Sports"));
            list.Add(new Tuple<string, string>("7", "Education"));
            list.Add(new Tuple<string, string>("8", "Medical"));
            list.Add(new Tuple<string, string>("9", "Professional Services"));
            list.Add(new Tuple<string, string>("10", "Event & Hospitality "));
            list.Add(new Tuple<string, string>("11", "Construction"));
            list.Add(new Tuple<string, string>("12", "Automobile"));
            list.Add(new Tuple<string, string>("13", "Non-profit Organisation/ Social Enterprise"));
            list.Add(new Tuple<string, string>("14", "Beauty & Fashion"));
            list.Add(new Tuple<string, string>("15", "Art, Music & Entertainment"));
            return list;
        }

        private static List<Tuple<string, string>> getProjectNature2()
        {
            List<Tuple<string, string>> list = new List<Tuple<string, string>>();
            list.Add(new Tuple<string, string>("1", "Corporate Website"));
            list.Add(new Tuple<string, string>("2", "E-Commerce Website"));
            list.Add(new Tuple<string, string>("3", "E-Commerce Website (PSG)"));
            list.Add(new Tuple<string, string>("4", "E-Commerce Website (TNG)"));
            list.Add(new Tuple<string, string>("6", "Mobile Application"));
            list.Add(new Tuple<string, string>("7", "Admin Panel"));
            list.Add(new Tuple<string, string>("8", "EDG Productivity"));
            list.Add(new Tuple<string, string>("9", "Consultancy (SBMD)"));
            list.Add(new Tuple<string, string>("10", "Consultancy (JD)"));
            list.Add(new Tuple<string, string>("11", "Design Project"));
            return list;
        }
    }
}
