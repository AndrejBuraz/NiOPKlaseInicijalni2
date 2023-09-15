using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InicijalnoPonavljanjeKlase2
{
    class GeometrijskiLik
    {
        public int BrojStranica;
        public double[] Stranice = new double[10];

        public void UcitajStranice()
        {
            for(int i = 0; i < this.BrojStranica; i++)
            {
                Console.WriteLine("Unesi " + (i + 1) + ". stranicu: ");
                this.Stranice[i] = Convert.ToInt32(Console.ReadLine());
            }
        }

        public double Opseg()
        {
            double rez = 0;
            for(int j = 0; j < this.BrojStranica; j++)
            {
                rez += this.Stranice[j];
            }
            return rez;
        }
    }

    class Trokut : GeometrijskiLik
    {
        public Trokut()
        {
            this.BrojStranica = 3;
        }
    }

    class Cetverokut : GeometrijskiLik
    {
        public Cetverokut()
        {
            this.BrojStranica = 4;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Trokut x = new Trokut();
            Cetverokut y = new Cetverokut();
            Console.WriteLine("Trokut: ");
            x.UcitajStranice();
            Console.WriteLine("Cetverokut: ");
            y.UcitajStranice();
            Console.WriteLine("Opseg trokuta: " + x.Opseg());
            Console.WriteLine("Opseg cetverokuta: " + y.Opseg());
            Console.ReadKey();

        }
    }
}
