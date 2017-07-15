using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FlowersBack.Models
{
    public class Flower
    {
        [Key]
        public int FlowerId { get; set; }

        [Required(ErrorMessage ="You must enter a {0}")]
        [StringLength(50, ErrorMessage = "The filed {0} can contain maximum {1} and minimum {2} characters", MinimumLength =1)]
        [Index("Flower_Description_Index",IsUnique =true)]
        public string Description { get; set; }

        //[DisplayFormat(DataFormatString = "{0:N2", ApplyFormatInEditMode = false)]
        public decimal Price { get; set; }
    }
}