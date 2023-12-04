using Prova_Ereditarietà;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova_Ereditarietà
{
    class Diplom
    {   
        public string eta = "";
        public Diplom(int voto, string nome, string cognome)
        {
            bool verifica = false;
            while (verifica == false)
            {
                if (voto < 36 || voto > 100)
                {
                    Console.WriteLine("Inserire voto giusto");
                }
                else
                {
                    verifica = true;
                }
            }                       
            if (voto >= 36 && voto <= 60)
            {
                eta = "Vecchio";
            }
            else
            if (voto >= 61 && voto <= 100)
            {
                eta = "Nuovo";
            }
        }
        public void MostraA()
        {
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        { 
            Console.WriteLine("Inserici numero di diplomati");
            int diplomati = int.Parse(Console.ReadLine());
            Diplom[] array = new Diplom[diplomati];
            for (int i = 0; i < diplomati; i++)
            {
                Console.WriteLine($"Inserici il voto del {diplomati+1} diplomato");
                int voto = int.Parse(Console.ReadLine());
                Console.WriteLine($"Inserici il nome del {diplomati + 1} diplomato");
                string nome = Console.ReadLine();
                Console.WriteLine($"Inserici il cognome del {diplomati + 1} diplomato");
                string cognome = Console.ReadLine();
                array[i] = new Diplom(voto, nome, cognome);
            }
        }
    }
}

