using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KvetinarstviSemPrace.Class
{
    public enum DruhyKvetin
    {
        PokojoveRostliny,
        VenkovniRostliny,
        Bylinky,
        Orchideje,
        KaktusySukulenty,
        VodniRostliny,
        PopinaveRostliny,
        Ostatni
    }

    public static class DruhyKvetinInfo
    {
        public static readonly int Pocet = Enum.GetValues(typeof(DruhyKvetin)).Length;

        public static IEnumerable Druhy
        {
            get
            {
                foreach (DruhyKvetin druhy in Enum.GetValues(typeof(DruhyKvetin)))
                {
                    yield return druhy;
                }
            }
        }

        public static string DejNazevDruhu(DruhyKvetin druh)
        {
            switch (druh)
            {
                case DruhyKvetin.PokojoveRostliny: return "Pokojové rostliny";
                case DruhyKvetin.VenkovniRostliny: return "Venkovní rostliny";
                case DruhyKvetin.Bylinky: return "Bylinky";
                case DruhyKvetin.Orchideje: return "Orchideje";
                case DruhyKvetin.KaktusySukulenty: return "Kaktusy a Sukulenty";
                case DruhyKvetin.VodniRostliny: return "Vodní rostliny";
                case DruhyKvetin.Ostatni: return "Ostatní";
                default: return "";
            }
        }
    }
}
