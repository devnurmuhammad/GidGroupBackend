namespace GidGroup.Domain.Entities
{
    public class ContactUs
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string Phone { get; set; } = default!;
        public string RoomSize { get; set; } = default!;
        public string? Comment { get; set; }
    }
}
