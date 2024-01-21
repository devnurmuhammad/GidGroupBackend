namespace GidGroup.Web.ViewModels
{
    public class ContactDTO
    {
        public string? Name { get; set; }
        public string Phone { get; set; } = default!;
        public string RoomSize { get; set; } = default!;
        public string? Comment { get; set; }
    }
}
