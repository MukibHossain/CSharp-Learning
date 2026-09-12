using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Eventing.Reader;

public class RegistrationForm
{
    [Required(ErrorMessage = "ID should not be null")]
    public int? Id { get; set; }

    [Required(ErrorMessage = "Name is mandatory")]
    [StringLength(10, MinimumLength = 5, ErrorMessage = "Name should be 5 to 10 characters")]
    public string Name { get; set; }

    [Required(ErrorMessage = "Email is mandatory")]
    [EmailAddress(ErrorMessage = "Invalid email format")]
    public string Email { get; set; }

    [Required(ErrorMessage = "Confirm Email is mandatory")]
    [Compare("Email", ErrorMessage = "Confirm Email should match with Email")]
    public string ConfirmEmail { get; set; }

    [Required(ErrorMessage = "Country is mandatory")]
    [RegularExpression(@"^[A-Z][a-zA-Z\s]*$", ErrorMessage = "Country should start with a capital letter")]
    public string Country { get; set; }

    [Required(ErrorMessage = "Password is mandatory")]
    [DataType(DataType.Password)]
    public string Password { get; set; }

    [Required(ErrorMessage = "Confirm Password is mandatory")]
    [DataType(DataType.Password)]
    [Compare("Password", ErrorMessage = "Confirm Password should match with Password")]
    public string ConfirmPassword { get; set; }

    [Required(ErrorMessage = "Booking Date is mandatory")]
    [FutureDate(ErrorMessage = "Booking Date should always be a future date")]
    public DateTime BookingDate { get; set; }
}

// Custom Annotation for Booking Date
public class FutureDateAttribute : ValidationAttribute
{
    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {
        if (value is DateTime date)
        {
            if (date.Date <= DateTime.Now.Date)
            {
                return new ValidationResult(ErrorMessage ?? "Date must be in the future");
            }
        }
        return ValidationResult.Success;
    }
}