using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rezolvareModel
{
    class Program
    {
        private const int NR_MINIM_FIGURI = 0;
        private const int NR_MAXIM_FIGURI = 10;
        static void Main()
        {
            string optiune;
            int nrFiguri;
            FiguraGeometrica[] figuri = new FiguraGeometrica[nrFiguri];

            do
            {
                Console.WriteLine("A. Adauga figura");
                Console.WriteLine("L. Afisare date despre toate figurile");
                Console.WriteLine("P. Afisare date despre figurile Patrulater");
                Console.WriteLine("C. Afisare denumirea corecta pentru toate figurile");
                Console.WriteLine("X. Exit");
                Console.WriteLine("Alege o optiune: ");
                optiune = Console.ReadLine();
                
                switch(optiune.ToUpper())
                {
                    case "A":
                        //avem un vectSor de obiecte
                        //int nrFiguri;
                        
                        do
                        {
                            Console.Write("Introduceti nr de figuri: ");
                            Int32.TryParse(Console.ReadLine(), out nrFiguri);
                        } while (nrFiguri <= NR_MINIM_FIGURI || nrFiguri > NR_MAXIM_FIGURI);

                        //construim un obiect nou
                        //FiguraGeometrica[] figuri = new FiguraGeometrica[nrFiguri];

                        for(int i = 0; i <= nrFiguri; i++ )
                        {
                            Console.Write("Introduceti denumirea figurii: ");
                            string denumire = Console.ReadLine();
                            Console.Write("Introduceti nr de laturi: ");
                            int nrLaturi = Convert.ToInt32(Console.ReadLine());
                            FiguraGeometrica figuraNoua = new FiguraGeometrica(denumire, nrLaturi);
                            figuri[i] = figuraNoua;
                        }
                        break;
                    case "L":
                        //afisare toate figurile introduse
                        
                        Console.WriteLine("Informatii despre figurile introduse sunt: ");
                        foreach(FiguraGeometrica figura in figuri )
                        {
                            AfisareFigura(figura);
                        }
                        break;
                    case "P":
                        Console.WriteLine("\nFigurile cu tipul *Patrulater* sunt:");
                        bool gasit = false;
                        foreach (FiguraGeometrica figura in figuri)
                        {
                            if (figura.TipFigura == FiguraGeometrica.PATRULATER)
                            {
                                Console.WriteLine(figura.Denumire);
                                gasit = true;
                            }
                        }

                        if (!gasit)
                        {
                            Console.WriteLine("Nu am gasit nici o figura de tipul patrulater");
                        }
                        break;
                    case "C":

                        AfisareFiguriCuDenumiriIncoerente(figuri);
                        break;
                    case "X":
                        return;
                    default:
                        Console.WriteLine("Ati introdus o tasta gresita!");
                        break;
                }
            } while (optiune.ToUpper() != "X");

            Console.ReadKey();
        }

        //functie afisare figura
        private static void AfisareFigura(FiguraGeometrica figura)
        {
            Console.WriteLine("Figura" + figura.Denumire + " are " + figura.NrLaturi + "laturi");
        }


        private static void AfisareFiguriCuDenumiriIncoerente(FiguraGeometrica[] figuri)
        {
            foreach (FiguraGeometrica figura in figuri)
            {
                if (!figura.EsteCorectaDenumirea)
                {
                    Console.WriteLine($"\nFigura *{ figura.Denumire}* are denumirea diferita de tipul determinat *{figura.TipFigura}*");
                }
            }
        }
    }
}
