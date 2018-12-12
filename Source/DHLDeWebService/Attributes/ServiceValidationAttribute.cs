using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DHLDeWebService.Attributes
{
    [AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
    public class ServiceValidationAttribute : ValidationAttribute
    {
        public enum ValidationRule
        {
            Regex,
            MaxOccurrence,
            MaxLength,
            MinLength,
            Length
        }

        private string RegexPattern { get; set; }
        private int MaxOccurrence { get; set; }
        private int MaxLength { get; set; }
        private int MinLength { get; set; }
        private int Length { get; set; }
        private ValidationRule RuleType { get; set; }

        public ServiceValidationAttribute(ValidationRule validationType, string rule)
        {
            RuleType = validationType;
            switch (RuleType)
            {
                case ValidationRule.Regex:
                    RegexPattern = rule;
                    break;
                case ValidationRule.MaxOccurrence:
                    MaxOccurrence = int.Parse(rule);
                    break;
                case ValidationRule.MaxLength:
                    MaxLength = int.Parse(rule);
                    break;
                case ValidationRule.MinLength:
                    MinLength = int.Parse(rule);
                    break;
                case ValidationRule.Length:
                    Length = int.Parse(rule);
                    break;
                default:
                    break;
            }
        }

        public override bool IsValid(object value)
        {
            var _result = false;
            if (value != null)
            {
                switch (RuleType)
                {
                    case ValidationRule.Regex:
                        _result = Regex.IsMatch((string)value, RegexPattern) || string.IsNullOrEmpty((string)value);
                        break;
                    case ValidationRule.MaxOccurrence:
                        var collection = value as ICollection;
                        _result = collection.Count <= MaxOccurrence;
                        break;
                    case ValidationRule.MaxLength:
                        _result = value.ToString().Length <= MaxLength;
                        break;
                    case ValidationRule.MinLength:
                        _result = value.ToString().Length >= MinLength;
                        break;
                    case ValidationRule.Length:
                        _result = value.ToString().Length == Length;
                        break;
                    default:
                        break;
                }
            }
            else _result = true;
            //if (string.IsNullOrEmpty(RegexPattern) && value.GetType().Equals(typeof(string))) 
            //{
            //    _result = Regex.IsMatch((string)value, RegexPattern);
            //}
            //if (MaxOccurrence != -1 && value.GetType().GetInterfaces().SingleOrDefault(x=>x.GetType().Equals(typeof(IList))) != null)
            //{
            //    var collection = value as ICollection;
            //    _result = collection.Count >= MaxOccurrence;
            //}
            //if(MaxLength != -1)
            //{
            //    _result = value.ToString().Length <= MaxLength;
            //}
            return _result;
        }
    }
}
