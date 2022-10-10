using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_04._10_Seul_bon
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Entrez un mot dont la premiere et dernière lettre seront permutées"); //Q1
            string retournement = Convert.ToString(Console.ReadLine());
            char[] result = Retournement(retournement);
            Console.Write("Le résultat est : ");
            for (int i = 0; i < result.Length; i++)
            {
                Console.Write(result[i]);
            }

            Console.Write("\n");

            bool t = Q2(); //Q2
            Console.Write(t);

            Console.Write("\n");

            char c = Convert.ToChar(Console.ReadLine()); //Q3
            int ascii = ASCII(c);
            Console.Write(ascii);

            Console.Write("\n");

            Q3bis(); //Q3bis

            Console.Write("\n");

            string chaine = Convert.ToString(Console.ReadLine()); //Q4
            char[] ascii2 = ASCIIORDRE(chaine);
            for (int i = 0; i < ascii2.Length; i++)
            {
                Console.Write(ascii2[i]);
            }

            Console.ReadKey();
        }
        static char[] Retournement(string retournement) //Q1
        {

            char[] recup = new char[retournement.Length];

            recup[0] = retournement[retournement.Length - 1];
            recup[recup.Length - 1] = retournement[0];
            for (int i = 1; i <= recup.Length - 2; i++)
            {
                recup[i] = retournement[i];
            }
            return recup;
        }

        static bool Q2() //Q2
        {
            int[] tab = { 1, 2, 3, 4, 5, 6, 7 };
            int[] sq = { 2, 3, 4 };

            if (sq.Length > tab.Length)
            {
                return false;
            }

            int cpt = 0;

            for (int i = 0; i < tab.Length; i++)
            {
                if (tab[i] == sq[cpt])
                {
                    cpt++;
                    if (cpt == sq.Length)
                    {
                        return true;
                    }
                }
                else
                {
                    cpt = 0;
                }
            }
            return false;
        }

        static int ASCII(char c) //Q3
        {
            int value = (int)c;

            return value;
        }

        static char[] Q3bis() //Q3bis
        {
            string word = "abcdefghijklmnopqrstuvwxyz";

            int[] tab = new int[word.Length];
            char[] tab2 = new char[word.Length];

            for (int i = 0; i < tab.Length; i++)
            {
                tab[i] = (int)word[i];
            }

            int a = 0;

            for (int i = 0; i < tab2.Length; i++)
            {
                Console.Write(word[i] + " ");
            }
            Console.Write("\n ");

            while (tab[0] < tab[1])
            {
                for (int i = 0; i < tab.Length - 1; i++)
                {
                    if (tab[i] < tab[i + 1])
                    {
                        a = tab[i];
                        tab[i] = tab[i + 1];
                        tab[i + 1] = a;
                    }
                }
            }
            for (int i = 0; i < tab2.Length; i++)
            {
                tab2[i] = (char)tab[i];
            }
            for (int i = 0; i < tab2.Length; i++)
            {
                Console.Write(tab2[i] + " ");
            }
            return tab2;
        }

        static char[] ASCIIORDRE(string c) //Q4
        {
            int[] value = new int[c.Length];
            char[] valueCopie = new char[c.Length];
            string cCopie = c;
            int max = value[0];
            int cpt = 0;
            int cpttableau = 0;
            int j = 0;
            int[] value2 = new int[value.Length];
            for (int i = 0; i < value.Length; i++)
            {
                value[i] = ASCII(c[i]);
                valueCopie[i] = c[i];
            }
            for (int i = 0; j < value.Length; i++)
            {
                if (i == value.Length)
                {
                    i = 0;
                }
                if (max < value[i])
                {
                    max = value[i];
                    cpttableau = i;
                }
                cpt++;
                if (cpt == value.Length)
                {
                    cpt = 0;
                    valueCopie[j] = cCopie[cpttableau];
                    value[cpttableau] = 0;
                    j++;
                    max = 0;
                    i = 0;
                }
            }
            return valueCopie;
        }
    }
}
