
using DHLDeWebService.Attributes;
using System;
using System.ComponentModel;

namespace DHLDeWebService.Entities.Misc
{
    [Serializable]
    public class DHLService 
    {
        [ValidateObject]
        public DayOfDelivery DayOfDelivery  { get; set; } //optional
        [ValidateObject]
        public DeliveryTimeframe DeliveryTimeframe  { get; set; }
        [ValidateObject]
        public PreferredTime PreferredTime  { get; set; }
        [ValidateObject]
        public IndividualSenderRequirement IndividualSenderRequirement  { get; set; }
        [ValidateObject]
        public DHLServiceBaseType PackagingReturn  { get; set; }
        [ValidateObject]
        public DHLServiceBaseType ReturnImmediately  { get; set; }
        [ValidateObject]
        public DHLServiceBaseType NoticeOfNonDeliverability { get; set; }
        [ValidateObject]
        public ShipmentHandling ShipmentHandling { get; set; }
        [ValidateObject]
        public Endorsement Endorsement { get; set; }
        [ValidateObject]
        public VisualCheckOfAge VisualCheckOfAge { get; set; }
        [ValidateObject]
        public PreferredLocation PreferredLocation { get; set; }
        [ValidateObject]
        public PreferredNeighbour PreferredNeighbour { get; set; }
        [ValidateObject]
        public PreferredDay PreferredDay { get; set; }
        [ValidateObject]
        public DHLServiceBaseType GoGreen { get; set; }
        [ValidateObject]
        public DHLServiceBaseType Perishables { get; set; }
        [ValidateObject]
        public DHLServiceBaseType NoNeighbourDelivery { get; set; }
        [ValidateObject]
        public DHLServiceBaseType NamedPersonOnly { get; set; }
        [ValidateObject]
        public DHLServiceBaseType ReturnReceipt { get; set; }
        [ValidateObject]
        public DHLServiceBaseType Personally { get; set; }
        [ValidateObject]
        public DHLServiceBaseType Premium { get; set; }
        [ValidateObject]
        public CashOnDelivery CashOnDelivery { get; set; }
        [ValidateObject]
        public AdditionalInsurance AdditionalInsurance { get; set; }
        [ValidateObject]
        public DHLServiceBaseType BulkyGoods { get; set; }
        [ValidateObject]
        public IdentCheck IdentCheck { get; set; }
        [ValidateObject]
        public ParcelOutletRouting ParcelOutletRouting { get; set; }

        
    }
}