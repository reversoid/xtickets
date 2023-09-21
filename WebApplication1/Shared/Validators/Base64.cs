namespace TodoApi.Shared.Validators;

using System;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

public partial class Base64 : ValidationAttribute
{
    protected override ValidationResult IsValid(object? value, ValidationContext validationContext)
    {
        if (value is not string stringValue)
            return new ValidationResult("Property must be a string.");

        var regex = Base64Regex();

        if (!regex.IsMatch(stringValue) || stringValue.Length % 4 != 0)
            return new ValidationResult("String is not a valid Base64 encoded string.");

        return ValidationResult.Success;
    }

    [GeneratedRegex("^[a-zA-Z0-9\\+/]*={0,3}$")]
    private static partial Regex Base64Regex();
}

