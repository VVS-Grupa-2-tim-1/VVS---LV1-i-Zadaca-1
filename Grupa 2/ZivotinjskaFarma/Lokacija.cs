using System;
using System.Collections.Generic;
using System.Linq;

namespace ZivotinjskaFarma
{
    public class Lokacija
    {
        #region ATRIBUTI

        string naziv, adresa, grad, država;
   
        int brojUlice, poštanskiBroj;
    
        double površina;

        #endregion

        #region PROPERTIES
        public string Naziv { get => naziv; set => naziv = value; }
        public string Adresa { get => adresa; set => adresa = value; }
        public string Grad { get => grad; set => grad = value; }
        public string Država { get => država; set => država = value; }
        public int BrojUlice { get => brojUlice; set => brojUlice = value; }
        public int PoštanskiBroj { get => poštanskiBroj; set => poštanskiBroj = value; }

        public double Površina { get => površina; set
            {
                if (value < 0.01)
                    throw new ArgumentException("Površina zemljišta mora biti barem 0.01 m2!");
                površina = value;
            } }
        #endregion


        #region KONSTRUKTOR
        public Lokacija(List<string> parametri, double površina)
        {
           
            if (parametri.Any(p => p==null || p.Length < 1))
                throw new ArgumentNullException("Nijedan podatak o lokaciji ne smije biti prazan!");
            if (parametri.Count < 6)
                throw new ArgumentException("Neispravan broj parametara!");

            Površina = površina;
            naziv = parametri.ElementAt(0);
            adresa = parametri.ElementAt(1);
            brojUlice = Int32.Parse(parametri.ElementAt(2)); 
            grad = parametri.ElementAt(3);
            poštanskiBroj = Int32.Parse(parametri.ElementAt(4));
            država = parametri.ElementAt(5);
        }
        #endregion
    }

}
