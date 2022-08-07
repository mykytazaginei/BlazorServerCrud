using System.ComponentModel.DataAnnotations;

namespace BlazorServerCrud.Data
{
    public class Game
    {
        public int Id { get; set; }

        public string? Name { get; set; } 

        public string Developer { get; set; } = string.Empty ;

        public DateTime? Release { get; set; }
    }
}
