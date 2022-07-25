namespace API.Dtos
{
    public class TotalAndDomainRevenueBreakdownDto
    {
       public double Total { get; set; }
       //public Dictionary<string,double> domainRevenueBreakdownDictionarys { get; set; }
        public ICollection<BreakdownDto> domainRevenueBreakdownIColection { get; set; }
    }
}
