using System;
using System.Collections.Generic;
using System.Text;

namespace TaxCalculator
{
    public class DefaultTaxCalculator : TaxCalculator
    {
        public DefaultTaxCalculator(int year) : base(year)
        {

        }

        public override int CalculateTax(Vehicle vehicle)
        {
            if (vehicle.DateOfFirstRegistration.Year == this.Year)
            {
                if (vehicle.Co2Emissions >= 1 &&
                    vehicle.Co2Emissions <= 50)
                    return 10;

                if (vehicle.Co2Emissions >= 51 &&
                    vehicle.Co2Emissions <= 75)
                    return 25;

                if (vehicle.Co2Emissions >= 76 &&
                    vehicle.Co2Emissions <= 90)
                    return 105;
            }
        }
    }
}
