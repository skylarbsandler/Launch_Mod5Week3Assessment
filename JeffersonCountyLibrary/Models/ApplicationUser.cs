using Microsoft.AspNetCore.Identity;

namespace JeffersonCountyLibrary.Models
{
    public class ApplicationUser : IdentityUser
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public List<Book> CheckedOutBooks { get; set; } = new List<Book>();
    }
}
