using DHLDeWebService.Attributes;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DHLDeWebService.Entities.Misc
{
    [Serializable]
    public class ReturnReceiver 
    {
        /// <summary>
        /// Name of the Return Receiver
        /// </summary>
        [Required, ValidateObject]
        public Name Name { get; set; } = new Name();
        /// <summary>
        /// Contains address data.
        /// </summary>
        [Required, ValidateObject]
        public Address Address { get; set; } = new Address();
        /// <summary>
        /// Information about communication.
        /// </summary>
        [Required, ValidateObject]
        public Communication Communication { get; set; } = new Communication();

        
    }
}