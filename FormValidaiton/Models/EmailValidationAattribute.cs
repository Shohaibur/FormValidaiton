//Email validation with Id 
using System;
using System.ComponentModel.DataAnnotations;

[AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
public class MatchingEmailAttribute : ValidationAttribute
{
    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {
        // Get the value of the ID property
        var idValue = (string)validationContext.ObjectType.GetProperty("Id").GetValue(validationContext.ObjectInstance, null);

        if (idValue == null)
        {
            return new ValidationResult("ID field is empty.");
        }

        // Construct the expected email by appending the ID to @gmail.com
        string expectedEmail = idValue + "@student.aiub.edu";
        string actualEmail = value as string;

        if (actualEmail != expectedEmail)
        {
            return new ValidationResult("Email does not match the expected pattern.");
        }

        return ValidationResult.Success;
    }
}
