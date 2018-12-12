using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DHLDeWebService.Attributes
{
    public class AcceptedValuesAttribute : ValidationAttribute
    {
        private List<string> Values { get; set; }

        public AcceptedValuesAttribute(params string[] arg)
        {
            Values = arg.ToList();
        }

        public override bool IsValid(object value)
        {
            return Values.FirstOrDefault(x => x.Equals(value.ToString())) != null;
        }

    }
}
