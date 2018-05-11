using ResistorService.Interface;
using System.Collections.Generic;

namespace ResistorService.Concrete
{
    public class ResistorBand : IResistorBand
    {               
        private readonly Dictionary<string, int> _bandDictionary;
        private readonly Dictionary<string, double> _toleranceDictionary;

        public ResistorBand() {
            _toleranceDictionary = new Dictionary<string, double>
            {
                { "silver", 10 },
                { "gold", 5 },
                { "brown", 1 },
                { "red", 2 },                
                { "yellow", 5 },
                { "green", 0.5 },
                { "blue", 0.25 },
                { "violet", 0.1 },
                { "gray", 0.05 },
                { "none", 20 }
            };

            _bandDictionary = new Dictionary<string, int>
            {
                { "pink", -3 },
                { "silver", -2 },
                { "gold", -1 },
                { "black", 0 },
                { "brown", 1 },
                { "red", 2 },
                { "orange", 3 },
                { "yellow", 4 },
                { "green", 5 },
                { "blue", 6 },
                { "violet", 7 },
                { "gray", 8 },
                { "white", 9 }
            };
        }

        public int GetBandValue(string bandColor)
        {
            if (string.IsNullOrWhiteSpace(bandColor)) return 0;
            var color = bandColor.ToLower();            
            if (!_bandDictionary.ContainsKey(color)) return 0;
            return _bandDictionary[color];    
        }

        public double GetToleranceValue(string bandColor)
        {
            if (string.IsNullOrWhiteSpace(bandColor)) return _toleranceDictionary["none"];
            var color = bandColor.ToLower();            
            if (!_toleranceDictionary.ContainsKey(color)) return _toleranceDictionary["none"];
            return _toleranceDictionary[color];
        }
    }
}
