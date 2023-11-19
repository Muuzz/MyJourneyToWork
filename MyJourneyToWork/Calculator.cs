using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Numerics;

namespace Calculator
{
    /*
     * List of Transport Modes
     */
    public enum TransportModes
    {
        [Display(Name = "Petrol")] petrol,
        [Display(Name = "Diesel")] deisel,
        [Display(Name = "Hybrid")] hybrid,
        [Display(Name = "Electric")] electric,
        [Display(Name = "Motorbike")] motorbike,
        [Display(Name = "Electric Bike or Scooter")] electricbike,
        [Display(Name = "Train")] train,
        [Display(Name = "Bus")] bus,
        [Display(Name = "Tram")] tram,
        [Display(Name = "Cycling")] cycling,
        [Display(Name = "Walking")] walking
    }

    public enum DistanceMeasurement
    {
        [Display(Name = "Miles")] miles,
        [Display(Name = "Kilometers")] kms
    }

    public class Calculator
    {
        private List<double> transportModeWeighting = new List<double> { 8, 10, 6, 4, 3, 2, 3, 3, 3, 0.005, 0.005 };

        public const double distanceMinMiles = 1;
        public const double distanceMaxMiles = 1000;
        public const double distanceMinKms = 1;
        public const double distanceMaxKms = 1609.344; // Approximately 1000 miles in kilometers

        [DisplayName("Enter Your Distance to work (KMs/miles):")]
        public double distance { get; set; }


        [DisplayName("Select A Distance Measurement:")]
        public DistanceMeasurement milesOrKms { get; set; }

        public const int daysMin = 1;
        public const int daysMax = 7;

        [Range(daysMin, daysMax, ErrorMessage = "Invalid num of days - Only Available from 1 to 7 days")]
        [DisplayName("Enter the number of days you travel to work:")]
        public double numDays { get; set; }

        [DisplayName("Select A Transport mode:")]
        public TransportModes transportMode { get; set; }

        //Ensure that distance is in miles for calculation
        private double convertDistance()
        {
            if (milesOrKms == DistanceMeasurement.kms)
            {
                return this.distance / 1.609344; // Convert kilometers to miles
            }
            else
            {
                return this.distance;
            }
        }
        [ExcludeFromCodeCoverage]
        public bool IsDistanceValid()
        {
            if (milesOrKms == DistanceMeasurement.kms)
            {
                return distance >= distanceMinKms && distance <= distanceMaxKms;
            }
            else
            {
                return distance >= distanceMinMiles && distance <= distanceMaxMiles;
            }
        }

        // calculate sustainability number
        [DisplayName("Your Sustainability Weighting:")]
        public double sustainabilityWeighting
        {
            // Total =  (Transport method Weighting * distance to work (in miles) * (onsite num Days per week*2))
            get
            {
                double total = 0;

                if (transportMode.Equals(TransportModes.petrol))
                {
                    total = transportModeWeighting[(int)TransportModes.petrol] * convertDistance() * (this.numDays * 2);
                }
                else if (transportMode.Equals(TransportModes.deisel))
                {
                    total = transportModeWeighting[(int)TransportModes.deisel] * convertDistance() * (this.numDays * 2);
                }
                else if (transportMode.Equals(TransportModes.hybrid))
                {
                    total = transportModeWeighting[(int)TransportModes.hybrid] * convertDistance() * (this.numDays * 2);
                }
                else if (transportMode.Equals(TransportModes.electric))
                {
                    total = transportModeWeighting[(int)TransportModes.electric] * convertDistance() * (this.numDays * 2);
                }
                else if (transportMode.Equals(TransportModes.motorbike))
                {
                    total = transportModeWeighting[(int)TransportModes.motorbike] * convertDistance() * (this.numDays * 2);
                }
                else if (transportMode.Equals(TransportModes.electricbike))
                {
                    total = transportModeWeighting[(int)TransportModes.electricbike] * convertDistance() * (this.numDays * 2);
                }
                else if (transportMode.Equals(TransportModes.train))
                {
                    total = transportModeWeighting[(int)TransportModes.train] * convertDistance() * (this.numDays * 2);
                }
                else if (transportMode.Equals(TransportModes.bus))
                {
                    total = transportModeWeighting[(int)TransportModes.bus] * convertDistance() * (this.numDays * 2);
                }
                else if (transportMode.Equals(TransportModes.tram))
                {
                    total = transportModeWeighting[(int)TransportModes.tram] * convertDistance() * (this.numDays * 2);
                }
                else if (transportMode.Equals(TransportModes.cycling))
                {
                    total = transportModeWeighting[(int)TransportModes.cycling] * convertDistance() * (this.numDays * 2);
                }
                else if (transportMode.Equals(TransportModes.walking))
                {
                    total = transportModeWeighting[(int)TransportModes.walking] * convertDistance() * (this.numDays * 2);
                }


                return total;
            }
        }
        [ExcludeFromCodeCoverage]
        public class SustainabilityMessagePrinter
        {
            [ExcludeFromCodeCoverage]
            public void PrintMessage(double sustainabilityWeighting)
            {
                if (sustainabilityWeighting > 150)
                {
                    Console.WriteLine("Please use more carbon-friendly transport.");
                }
                else
                {
                    Console.WriteLine("Thank you for being environmentally friendly.");
                }
            }
        }
        [ExcludeFromCodeCoverage]
        [DisplayName("Carbon friendly check:")]
        public String EnvirementMessage
        {

            get
            {
                string message;
                if (sustainabilityWeighting > 150)
                {
                    message = "Please use more carbon-friendly transport.";
                }
                else
                {
                    message = "Thank you for being environmentally friendly.";
                }


                return message;
            }
        }
    }
}
