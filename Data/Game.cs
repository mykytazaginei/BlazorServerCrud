using System.ComponentModel.DataAnnotations;

namespace BlazorServerCrud.Data
{
    public class Game
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Enter a Name")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Enter a Developer")]
        public string? Developer { get; set; }

        public DateTime? Release { get; set; }
    }
}
