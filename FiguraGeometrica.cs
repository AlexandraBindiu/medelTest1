using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rezolvareModel
{
    class FiguraGeometrica
    {
        // constante
        public const string TRIUNGHI = "Triunghi";
        public const string PATRULATER = "Patrulater";
        public const string PENTAGON = "Pentagon";
        //proprietati auto implementate
        public string Denumire { get; set; }
        public int NrLaturi { get; set; }

        //constructor fara parametri
        public FiguraGeometrica()
        {
            Denumire = string.Empty;
            NrLaturi = 0;
        }
        
        //constructor cu parametri
        public FiguraGeometrica(string _Denumire, int _NrLaturi)
        {
            Denumire = _Denumire;
            NrLaturi = _NrLaturi;
        }
        
        //proprietate care returneaza informatii despre fig 
        public string TipFigura
        {
            get
            {
                switch(NrLaturi)
                {
                    case 3:
                        return TRIUNGHI;
                    case 4:
                        return PATRULATER;
                    case 5:
                        return PENTAGON;
                    default:
                        return "Nedeterminat";

                }
            }
        }

        // Proprietate care returneaza daca denumirea este identica cu tipul determinat al figurii
        // sub forma unei valori de tipul 'bool' (adevarat sau fals)
        public bool EsteCorectaDenumirea
        {
            get
            {
                return TipFigura.ToLower() == Denumire.ToLower();
            }
        }
    }
}
