using System.ComponentModel.DataAnnotations;

namespace TheLDTS.Models
{
    public class DateLessThanOrEqualToToday : ValidationAttribute
    {
        public override string FormatErrorMessage(string name)
        {
            return "Date must not be in the future!";
        }

        protected override ValidationResult IsValid(object objValue,ValidationContext validationContext)
        {
            var dateValue = objValue as DateTime? ?? new DateTime();
            if (dateValue.Date > DateTime.Now)
            {
                return new ValidationResult(FormatErrorMessage(validationContext.DisplayName));
            }
            return ValidationResult.Success;
        }
    }
}
