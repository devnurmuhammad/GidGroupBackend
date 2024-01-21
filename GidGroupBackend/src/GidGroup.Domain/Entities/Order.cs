namespace GidGroup.Domain.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public string Size { get; set; } = default!;
        public string Style { get; set; } = default!;
        public string WhenNeed { get; set; } = default!;
        public string Phone { get; set; } = default!;
        public string? Email { get; set; }
    }
}
