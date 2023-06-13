using System.ComponentModel.DataAnnotations;

namespace CityInfo.API.Models
{
    public class MaxLengthWithErrorAttribute : ValidationAttribute
    {
        private readonly int _maxLength;
        private readonly string _errorMessage;

        public MaxLengthWithErrorAttribute(int maxLength, string errorMessage)
        {
            _maxLength = maxLength;
            _errorMessage = errorMessage;
        }

        protected override ValidationResult IsValid(object? value, ValidationContext validationContext)
        {
            if (value != null)
            {
                string? stringValue = value.ToString() ?? string.Empty;
                if (stringValue?.Length > _maxLength)
                {
                    return new ValidationResult(_errorMessage);
                }
            }

                return ValidationResult.Success!;
            
        }
    }
    public class PointOfInterestForCreationDto
    {
        [Required(ErrorMessage = "What even are you?")]
        [MaxLength(50)]
        public string Name { get; set; } = string.Empty;

        [MaxLengthWithError(200, "That's too long, bitch!")]
        public string? Description { get; set; }
    }

}
