namespace GidGroup.Web.ViewModels
{
    public class OrderDTO
    {
        public string Size { get; set; } = default!;
        public string Style { get; set; } = default!;
        public string WhenNeed { get; set; } = default!;
        public string Phone { get; set; } = default!;
        public string? Email { get; set; }
    }
}
