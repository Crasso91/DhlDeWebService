using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DHLDeWebService.Attributes
{
    public class ValidateObjectAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            ValidationResult result = ValidationResult.Success;
            if (value != null)
            {
                var results = new List<ValidationResult>();
                var context = new ValidationContext(value, null, null);
                if (value.GetType().GetInterfaces().FirstOrDefault(x => x.Name.Contains("List")) == null)
                {
                    Validator.TryValidateObject(value, context, results, true);

                    if (results.Count != 0)
                    {
                        var compositeResults = new CompositeValidationResult(String.Format("Validation for {0} failed!", validationContext.DisplayName));
                        results.ForEach(compositeResults.AddResult);

                        return compositeResults;
                    }
                }
                else
                {
                    foreach (var el in (value as IList))
                    {
                        if (el == null) continue;
                        context = new ValidationContext(el, null, null);
                        Validator.TryValidateObject(el, context, results, true);

                        if (results.Count != 0)
                        {
                            var compositeResults = new CompositeValidationResult(String.Format("Validation for {0} failed!", validationContext.DisplayName));
                            results.ForEach(compositeResults.AddResult);

                            return compositeResults;
                        }
                    }
                }
                result = ValidationResult.Success;
            }
            return result;
        }
    }
}
