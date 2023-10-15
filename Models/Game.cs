using System.ComponentModel.DataAnnotations;

namespace GameList.Models
{
    public class Game
    {
        public int GameId { get; set; }
        [Required(ErrorMessage ="Please enter a name")]
        public string Name { get; set; }

        [Required(ErrorMessage ="PKease enter a year")]
        public int? Year { get; set; }

        [Required(ErrorMessage ="Please entera  rating")]
        public int? Rating { get; set; }

        

    }
}
