using System.ComponentModel.DataAnnotations;

namespace BlazorServerCrud.Data
{
    public class Game
    {
        public int Id { get; set; }

        [StringLength(100, MinimumLength = 3)]
        [Required(ErrorMessage = "Enter a Name")]
        public string? Name { get; set; }

        [StringLength(100, MinimumLength = 3)]
        [Required(ErrorMessage = "Enter a Developer")]
        public string? Developer { get; set; }

        public DateTime? Release { get; set; }
    }
}
