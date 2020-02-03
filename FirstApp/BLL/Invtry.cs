using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp.BLL
{
    public class Invtry
    {
        public static List<decimal> GetArborSpacers(string mach)
        {
            switch (mach)
            {
                case "60 ST":
                    //ST 60 Slitter
                    return new List<decimal> { 3.000m, 2.000m, 1.000m, 0.600m, 0.300m, 0.200m, 0.100m, 0.080m, 0.065m, 0.058m, 0.054m, 0.052m, 0.051m, 0.050m };
                case "72 ST":
                    //ST 72 Slitter
                    return new List<decimal>() { 3.200m, 1.600m, 0.800m, 0.400m, 0.200m, 0.100m, 0.075m, 0.065m, 0.058m, 0.054m, 0.052m, 0.051m, 0.0505m, 0.050m };
                case "60 MI":
                    //MI 60 Slitter
                    return new List<decimal> { 3.000m, 2.000m, 1.000m, 0.600m, 0.300m, 0.200m, 0.100m, 0.080m, 0.065m, 0.058m, 0.054m, 0.052m, 0.051m, 0.505m, 0.050m };
                case "72 AR":
                    // AR 72 slitter
                    return new List<decimal> { 3.2000m, 1.6000m, 0.8000m, 0.4000m, 0.2000m, 0.1000m, 0.0750m, 0.0650m, 0.0580m, 0.0540m, 0.0520m, 0.0510m, 0.050m, 0.0505m };
                default:
                    //Kevin McGuire tooling
                    return new List<decimal>() { 3.200m, 1.600m, 0.800m, 0.400m, 0.200m, 0.160m, 0.150m, 0.140m, 0.130m, 0.126m, 0.120m, 0.110m, 0.106m, 0.105m, 0.104m, 0.103m, 0.102m, 0.101m, 0.100m, 0.1005m };
            }
        }

        public static List<decimal> GetKnives(string mach)
        {
            switch (mach)
            {
                case "60 ST":
                    //ST 60 Slitter
                    return new List<decimal> { 0.180m, 0.245m, 0.360m, 0.4925m, 1.000m };
                case "72 ST":
                    //ST 72 Slitter
                    return new List<decimal>() { 0.360m, 1.000m };
                case "60 MI":
                    //MI 60 Slitter
                    return new List<decimal>() { 0.180m, 0.250m, 0.375m, 0.4925m, 0.750m, 1.000m };
                case "72 AR":
                    //AR 72 slitter
                    return new List<decimal> { 0.1800m, 0.3750m, 0.5000m, 0.2500m};
                default:
                    //Kevin McGuire tooling
                    return new List<decimal>() { 0.245m, 0.375m, 0.500m, 0.750m };
            }
        }
    }
}
