namespace Core.Entities
{
    public class Notif
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Message { get; set; }
        public DateTime DateSent { get; set; }
    }
}
