using ResistorService.Interface;
using System;
using System.Collections.Generic;

namespace ResistorService.Concrete
{
    public class OhmValueCalculator : IOhmValueCalculator
    {
        private readonly IResistorBand _resistorBand;

        public OhmValueCalculator(IResistorBand resistorBand)
        {
            _resistorBand = resistorBand;
        }

        public int CalculateOhmValue(string bandAColor, string bandBColor, string bandCColor)
        {
            int band1value = _resistorBand.GetBandValue(bandAColor);
            int band2value = _resistorBand.GetBandValue(bandBColor);
            int multiplier = _resistorBand.GetBandValue(bandCColor);

            int bandresult = ((band1value * 10) + (band2value));
            if (multiplier == 0)
                return bandresult;
            
            return bandresult * (int)(Math.Pow(10, multiplier));                      
        }

        public IList<double> CalculateTolerance(string bandColor, int ohmsValue)
        {
            var tolerances = new List<double>();
            var tolerancevalue = _resistorBand.GetToleranceValue(bandColor);
            var lowerohms = (1 - (tolerancevalue / 100)) * ohmsValue;
            var upperohms = (1 + (tolerancevalue / 100)) * ohmsValue;
            tolerances.Add(lowerohms);
            tolerances.Add(upperohms);        
            return tolerances;
        }
    }
}
