namespace API.Dtos
{
    public class TotalAndHostingRevenueBreakdownDto
    {
        public double Total { get; set; }
        public ICollection<BreakdownDto> hostingRevenueBreakdownIColection { get; set; }
    }
}
