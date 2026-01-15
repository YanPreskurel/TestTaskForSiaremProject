namespace WebContactsOperations.Models
{
    public class Contact
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string MobilePhone { get; set; } = null!;
        public string JobTitle { get; set; } = null!;
        public DateTime Birthdate { get; set; }
    }
}
