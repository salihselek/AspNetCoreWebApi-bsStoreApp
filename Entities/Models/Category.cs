namespace Entities.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        // Ref : Collection navigation property
        //public ICollection<Book> Books { get; set; }
    }
}
