using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler17
{
    public class Algorithm
    {
        private const string OneThousand = "one thousand";
        private const string Hundred = "Hundred";
        private const string And = "And";
        private readonly Dictionary<int, string> dict;

        public Algorithm()
        {
            dict = new Dictionary<int, string>
            {
                {1, "One" },
                {2, "Two" },
                {3, "Three" },
                {4, "Four" },
                {5, "Five" },
                {6, "Six" },
                {7, "Seven" },
                {8, "Eight" },
                {9, "Nine" },
                {10, "Ten" },
                {11, "Eleven" },
                {12, "Twelve" },
                {13, "Thirteen" },
                {14, "Fourteen" },
                {15, "Fifteen" },
                {16, "Sixteen" },
                {17, "Seventeen" },
                {18, "Eighteen" },
                {19, "Nineteen" },
                {20, "Twenty" },
                {30, "Thirty" },
                {40, "Forty" },
                {50, "Fifty" },
                {60, "Sixty" },
                {70, "Seventy" },
                {80, "Eighty" },
                {90, "Ninety" },
            };
        }
        public int Run()
        {
            int counter = 0;

            for (int i = 1; i<1000; i++)
            {
                int temp = i / 100;
                if (temp != 0)
                {
                    counter += this.dict[temp].Length + Hundred.Length;
                    if (i % 100 != 0)
                    {
                        counter += And.Length;
                    }
                }

                temp = i % 100;
                if (temp != 0)
                {
                    if (temp < 21)
                    {
                        counter += this.dict[temp].Length;
                    }
                    else
                    {
                        counter += this.dict[temp - (temp % 10)].Length;
                        temp = i % 10;
                        if (temp != 0)
                        {
                            counter += this.dict[temp].Length;
                        }
                    }
                }
            }

            return counter += OneThousand.Replace(" ", string.Empty).Length;
        }

        public void WriteNumbers()
        {
            string counter = "";

            for (int i = 1; i < 1000; i++)
            {
                int temp = i / 100;
                if (temp != 0)
                {
                    counter += this.dict[temp] + Hundred;
                    if (i % 100 != 0)
                    {
                        counter += And;
                    }
                }

                temp = i % 100;
                if (temp != 0)
                {
                    if (temp < 21)
                    {
                        counter += this.dict[temp];
                    }
                    else
                    {
                        counter += this.dict[temp - (temp % 10)];
                        temp = i % 10;
                        if (temp != 0)
                        {
                            counter += this.dict[temp];
                        }
                    }
                }
                Console.WriteLine(i + " " + counter);
                counter = "";
            }

            Console.WriteLine(OneThousand.Replace(" ", string.Empty));
        }
    }
}
