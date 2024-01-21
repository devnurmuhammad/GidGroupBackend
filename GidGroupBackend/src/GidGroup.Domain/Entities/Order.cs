using GidGroup.Domain.Enums;

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
        public DateTime Date { get; set; } = DateTime.UtcNow;
        public StatusEnums.Status Status { get; set; } = StatusEnums.Status.Recieved;
    }
}