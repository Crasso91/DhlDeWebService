using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DHLDeWebService.Attributes
{
    public class CompositeValidationResult : ValidationResult
    {
        private readonly List<ValidationResult> _results = new List<ValidationResult>();

        public IEnumerable<ValidationResult> Results
        {
            get
            {
                return _results;
            }
        }
        public bool HasChilds { get { return Results.Count() > 0; } }
        public CompositeValidationResult(string errorMessage) : base(errorMessage) { }
        public CompositeValidationResult(string errorMessage, IEnumerable<string> memberNames) : base(errorMessage, memberNames) { }
        protected CompositeValidationResult(ValidationResult validationResult) : base(validationResult) { }

        public void AddResult(ValidationResult validationResult)
        {
            _results.Add(validationResult);
        }

        public List<string> GetErrors()
        {
            var result = new List<string>();
            Results.ToList().ForEach(x => result.Add(x.ErrorMessage));
            Results.ToList().ForEach(x =>
            {
                if (typeof(CompositeValidationResult).IsAssignableFrom(x.GetType()))
                {
                    result.AddRange(((CompositeValidationResult)x).GetChildErrors());
                }
                else
                {
                    result.Add(x.ErrorMessage);
                }
            });
            return result;
        }

        public List<string> GetChildErrors()
        {
            var result = new List<string>();
            Results.ToList().ForEach(x =>
            {
                if (typeof(CompositeValidationResult).IsAssignableFrom(x.GetType()))
                {
                    result.AddRange(((CompositeValidationResult)x).GetErrors());
                }
                else
                {
                    result.Add(x.ErrorMessage);
                }
            });
            return result;
        }
    }
}
