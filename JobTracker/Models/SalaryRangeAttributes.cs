using System.ComponentModel.DataAnnotations;

namespace JobTracker.Models;

public class SalaryRangeAttribute : ValidationAttribute
{
    protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
    {
        var job = (JobApplication)validationContext.ObjectInstance;

        if (job.SalaryRangeLowerBound.HasValue != job.SalaryRangeUpperBound.HasValue)
            return new ValidationResult("Both salary bounds must be set, or neither.");

        if (job.SalaryRangeLowerBound > job.SalaryRangeUpperBound)
            return new ValidationResult("Lower bound must be less than upper bound.");

        return ValidationResult.Success;
    }
}