using System.ComponentModel.DataAnnotations;

namespace CityInfo.API.Models
{
    public class PointOfInterestForUpdateDto
    {
        [Required(ErrorMessage = "What even are you?")]
        [MaxLength(50)]
        public string Name { get; set; } = string.Empty;

        [MaxLengthWithError(200, "That's too long, bitch!")]
        public string? Description { get; set; }
    }
}
