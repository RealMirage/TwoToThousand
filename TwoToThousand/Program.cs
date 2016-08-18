using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace TwoToTheThousand
{
    class Program
    {

        static void Main(string[] args)
        {
            //Create an array able to store each of the individual digits.
            int[] numArray = new int[1000];
            int power = 0;
            int quotient;
            int remainder;
            int max = 0;
            int sum = 0;
            numArray[0] = 1;

            //Multiply each element by 2
            while (power < 1000)
            {
                for (int i = 0; i <= max; i++)
                {
                    numArray[i] *= 2;
                }



                Console.WriteLine();

                power += 1;

                for (int j = 0; j <= max; j++)
                {
                    quotient = numArray[j] / 10;
                    remainder = numArray[j] % 10;
                    if (quotient >= 1)
                    {
                        numArray[j + 1] += quotient;
                        numArray[j] = remainder;
                        if (j == max)
                        {
                            max += 1;
                        }
                    }
                }

                for (int k = max; k >= 0; k--)
                {
                    Console.Write(numArray[k].ToString());
                }

            }

            Console.WriteLine();
            Console.WriteLine("That was for 2 to the " + power.ToString() + "th!");
            Console.WriteLine();
            for (int s = 0; s <= max; s++)
            {
                sum += numArray[s];
            }
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
