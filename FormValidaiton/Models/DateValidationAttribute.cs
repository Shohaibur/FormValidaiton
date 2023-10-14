using System;
using System.ComponentModel.DataAnnotations;

[AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
public class MinimumAgeAttribute : ValidationAttribute
{
    private readonly int _minimumAge;

    public MinimumAgeAttribute(int minimumAge)
    {
        _minimumAge = minimumAge;
    }

    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {
        if (value is DateTime Date)
        {
            var today = DateTime.Today;
            var age = today.Year - Date.Year;

            if (Date.Date > today.AddYears(-age)) age--;

            if (age < _minimumAge)
            {
                return new ValidationResult($"Age must be at least {_minimumAge} years.");
            }
        }

        return ValidationResult.Success;
    }
}
