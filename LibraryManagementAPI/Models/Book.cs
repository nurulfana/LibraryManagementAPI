using System.ComponentModel.DataAnnotations;

namespace LibraryManagementAPI.Models
{
    public class Book
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Author { get; set; }

        [Required]
        public string Genre { get; set; }

        [Required]
        public int YearPublished { get; set; }
    }
}