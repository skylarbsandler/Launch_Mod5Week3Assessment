namespace JeffersonCountyLibrary.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public ApplicationUser? CheckedOutBy { get; set; }
        public DateTime? DueDate { get; set; }
        public Branch Branch { get; set; }
        public int BranchId { get; set; }
    }
}