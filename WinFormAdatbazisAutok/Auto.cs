using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormAdatbazisAutok
{
    class Auto
    {
        readonly ulong id;
        string rendszam;
        string marka;
        DateTime forgalombaHelyezes;

        public ulong Id => id;
        public string Rendszam { get => rendszam; set => rendszam = value; }
        public string Marka { get => marka; set => marka = value; }
        public DateTime ForgalombaHelyezes { get => forgalombaHelyezes; set => forgalombaHelyezes = value; }

        public Auto(ulong id, string rendszam, string marka, DateTime forgalombaHelyezes)
        {
            this.id = id;
            Rendszam = rendszam;
            Marka = marka;
            ForgalombaHelyezes = forgalombaHelyezes;
        }

        public override string ToString()
        {
            return $"{id} {rendszam}, {marka} ({forgalombaHelyezes.ToString("d")})";
        }
    }
}
