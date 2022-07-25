namespace API.Dtos
{
    public class TotalAndEmailRevenueBreakdownDto
    {
        public double Total { get; set; }
        public ICollection<BreakdownDto> emailRevenueBreakdownIColection { get; set; }
    }
}
