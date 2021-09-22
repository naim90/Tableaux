using System;

namespace Tableaux
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] tableau1 = new char[3];
            char[] tableau2 = new char[3];
            char[] tableau3 = new char[tableau1.Length+tableau2.Length];

            tableau1[0] = 'b';
            tableau1[1] = 'u';
            tableau1[2] = 'e';
            tableau2[0] = 'n';
            tableau2[1] = 'o';
            tableau2[2] = '!';


            tableau1.CopyTo(tableau3, 0);
            //tableau2.CopyTo(tableau3, 3);


            Array.ConstrainedCopy(tableau2, 0, tableau3, tableau1.Length, tableau2.Length);

            Console.Write(tableau3);


        }
    }
}
