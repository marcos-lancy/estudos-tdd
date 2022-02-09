using System;
using System.Collections.Generic;
using System.Text;

namespace Sol.Carrinhodecompra.NumeroRomano
{
    public class ConversorDeNumeroromano
    {
        public string Numero { get; set; }

        public int Converte(string numeroEmRomano)
        {
            if (numeroEmRomano.Equals("I"))
            {
                return 1;
            }
            else if (numeroEmRomano.Equals("V"))
                return 5;

            return 0;
        }
    }
}
