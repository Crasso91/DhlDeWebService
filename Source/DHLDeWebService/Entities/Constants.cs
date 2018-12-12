using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DHLDeWebService.Entities
{
    public class Constants
    {
        public const string DateValidationRegex = "[0-9]{4}-[0-9]{2}-[0-9]{2}";
        public const string OnlyNumbersValidationRegex = "[0-9]*";
        public const string EmailValidationRegex = @"[A-z0-9\.\-]*@[A-z0-9]*.[A-z]{2,3}";
        public const string IBANValidationRegex = @"^([A-Z]{2}[ \-]?[0-9]{2})(?=(?:[ \-]?[A-Z0-9]){9,30}$)((?:[ \-]?[A-Z0-9]{3,5}){2,7})([ \-]?[A-Z0-9]{1,3})?$";
        public const string ZipCodeValidationRegex = "[0-9]{1,10}";
        public const string ISOValidationRegex = "[A-z]{2}";

        public enum TranslactionLanguages
        {
            it, en, de
        }
    }
}
