namespace JeffersonCountyLibrary.Models
{
    public class Branch
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ApplicationUser? Librarian { get; set; }
        public List<Book> Books { get; set; } = new List<Book>();
    }
}