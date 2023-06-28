using System;
using System.Collections.Generic;

namespace URPGDesktopCalc.Classes
{
    public class Pokemon
    {
        public string Name { get; set; }
        public string Type1 { get; set; }
        public string Type2 { get; set; }
        public double MaxHP { get; set; }
        public double ATT { get; set; }
        public double DEF { get; set; }
        public double SPA { get; set; }
        public double SPD { get; set; }
        public double SPE { get; set; }
        public string TeraType { get; set; }

        public Pokemon()
        {
        }

        public Pokemon(IReadOnlyList<string> values)
        {
            if (values.Count == 0) return;

            Name = values[0];

            Type1 = values[1];
            Type2 = values[2];
            TeraType = values[3];

            MaxHP = double.Parse(values[4]);
            ATT = double.Parse(values[5]);
            DEF = double.Parse(values[6]);
            SPA = double.Parse(values[7]);
            SPD = double.Parse(values[8]);
            SPE = double.Parse(values[9]);
        }
    }
}
