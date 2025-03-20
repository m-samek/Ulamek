using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7Ulamek
{
    /// <summary>
    /// Represents a fraction with a numerator and a denominator.
    /// Provides methods for arithmetic operations, comparisons, and conversions.
    /// Implements IComparable interface.
    /// Overrides ToString, Equals, GetHashCode, and CompareTo methods.
    /// Overload operators: *, +, -, /, >, >=, <, <=, ==, !=, explicit operator double.
    /// Returns a string that represents the current object.
    /// </summary>
    public class Ulamek : IComparable<Ulamek>
    {
        public int Licznik { get; }
        public int Mianownik { get; }

        public Ulamek(int inLicznik, int inMianownik)
        {
            if (inMianownik == 0)
            {
                throw new DivideByZeroException("Mianownik nie może być 0");
            }

            this.Licznik = inLicznik;
            this.Mianownik = inMianownik;
        }

        public override string ToString()
        {
            return Licznik.ToString() + "/" + Mianownik.ToString();
        }

        public static Ulamek operator *(Ulamek u1, Ulamek u2)
        {
            int licznik = u1.Licznik * u2.Licznik;
            int mianownik = u1.Mianownik * u2.Mianownik;
            return new Ulamek(licznik, mianownik);
        }

        public static Ulamek operator +(Ulamek u1, Ulamek u2)
        {
            int licznik = u1.Licznik * u2.Mianownik + u2.Licznik * u1.Mianownik;
            int mianownik = u1.Mianownik * u2.Mianownik;
            return new Ulamek(licznik, mianownik);
        }

        public static Ulamek operator -(Ulamek u1, Ulamek u2)
        {
            int licznik = u1.Licznik * u2.Mianownik - u2.Licznik * u1.Mianownik;
            int mianownik = u1.Mianownik * u2.Mianownik;
            return new Ulamek(licznik, mianownik);
        }

        public static Ulamek operator /(Ulamek u1, Ulamek u2)
        {
            int licznik = u1.Licznik * u2.Mianownik;
            int mianownik = u1.Mianownik * u2.Licznik;
            return new Ulamek(licznik, mianownik);
        }

        public static bool operator >(Ulamek u1, Ulamek u2)
        {
            return (u1.Licznik * u2.Mianownik) > (u2.Licznik * u1.Mianownik);
        }

        public static bool operator >=(Ulamek u1, Ulamek u2)
        {
            return (u1.Licznik * u2.Mianownik) >= (u2.Licznik * u1.Mianownik);
        }

        public static bool operator <(Ulamek u1, Ulamek u2)
        {
            return (u1.Licznik * u2.Mianownik) < (u2.Licznik * u1.Mianownik);
        }

        public static bool operator <=(Ulamek u1, Ulamek u2)
        {
            return (u1.Licznik * u2.Mianownik) <= (u2.Licznik * u1.Mianownik);
        }

        public static bool operator ==(Ulamek u1, Ulamek u2)
        {
            return (u1.Licznik * u2.Mianownik) == (u2.Licznik * u1.Mianownik);
        }

        public static bool operator !=(Ulamek u1, Ulamek u2)
        {
            return (u1.Licznik * u2.Mianownik) != (u2.Licznik * u1.Mianownik);
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            Ulamek u = obj as Ulamek;
            if (u == null)
            {
                return false;
            }
            return (this.Licznik * u.Mianownik) == (u.Licznik * this.Mianownik);
        }

        public override int GetHashCode()
        {
            return this.Licznik * this.Mianownik;
        }

        public static explicit operator double(Ulamek u)
        {
            return (double)u.Licznik / u.Mianownik;
        }

        public int CompareTo(Ulamek other)
        {
            if (this.Licznik * other.Mianownik > other.Licznik * this.Mianownik)
            {
                return 1;
            }
            else if (this.Licznik * other.Mianownik < other.Licznik * this.Mianownik)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Ulamek polowa = new Ulamek(1, 2);
            Ulamek cwierc = new Ulamek(1, 4);

            Console.WriteLine(polowa);
            Console.WriteLine(cwierc);

            Ulamek poMnozeniu = polowa * cwierc;
            Console.WriteLine("Po pomonozeniu " + poMnozeniu);

            Ulamek poDodaniu = polowa + cwierc;
            Console.WriteLine("Po dodaniu " + poDodaniu);

            Ulamek poOdejmowaniu = polowa - cwierc;
            Console.WriteLine($"Po odejmowaniu {poOdejmowaniu}");

            Ulamek poDzieleniu = polowa / cwierc;
            Console.WriteLine($"Po dzieleniu {poDzieleniu}");

            if (polowa > cwierc)
            {
                Console.WriteLine($"Połowa: {polowa} jest większa od {cwierc}");
            }
            else
            {
                Console.WriteLine($"Połowa: {polowa} jest mniejsza od {cwierc}");
            }

            Ulamek liczbaX = new Ulamek(1, 3);
            double liczbaWDouble = (double)liczbaX;
            Console.WriteLine($"Po pomnozeniu w double {liczbaWDouble}");
            Console.WriteLine($"Po pomnozeniu w double {liczbaX}");

            Ulamek[] tablica = { new Ulamek(1, 7), new Ulamek(6, 7), new Ulamek(3, 7), new Ulamek(2, 7) };
            Console.WriteLine("Tablica przed sortowaniem");

            foreach (Ulamek temp in tablica)
            {
                Console.WriteLine(temp);
            }

            Array.Sort(tablica);
            Console.WriteLine("Tablica po sortowaniu");

            foreach (Ulamek temp in tablica)
            {
                Console.WriteLine(temp);
            }
        }
    }
}
