using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Globalization;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace Cows_and_Bulls_project
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //generate random number
            int num1 = 0;
            int num2 = 0;
            int num3 = 0;
            int num4 = 0;
            bool Unique = false;
            while (Unique == false)

            {
                Random rnd = new Random();

                num1 = rnd.Next(1, 9);
                num2 = rnd.Next(0, 9);
                num3 = rnd.Next(0, 9);
                num4 = rnd.Next(0, 9);



                if (num1 != num2)
                {
                    if (num1 != num3)
                    {
                        if (num1 != num4)
                        {
                            if (num2 != num3)
                            {
                                if (num2 != num4)
                                {
                                    if (num3 != num4)
                                    {
                                        Unique = true;
                                    }
                                }
                            }
                        }
                    }
                }


            }
            int[] number = { num1, num2, num3, num4 };

            bool valid = false;

            int guess1 = 0;
            int guess2 = 0;
            int guess3 = 0;
            int guess4 = 0;

            while (valid == false)
            {

                Console.WriteLine("please input each digit of your quess individually");
                 guess1 = Convert.ToInt32(Console.ReadLine());
                 guess2 = Convert.ToInt32(Console.ReadLine());
                 guess3 = Convert.ToInt32(Console.ReadLine());
                 guess4 = Convert.ToInt32(Console.ReadLine());

                if (guess1 > 0)
                {
                    if (guess1 < 9)
                    {
                        if (guess1 != guess2)
                        {
                            if (guess1 != guess3)
                            {
                                if (guess1 != guess4)
                                {
                                    if (guess2 != guess3)
                                    {
                                        if (guess2 != guess4)
                                        {
                                            if (guess3 != guess4)
                                            {
                                                valid = true;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }

                if (valid == false)
                {
                    Console.WriteLine("invalid input, try again");
                }

            }

            Console.WriteLine("input valid");

            int bulls = 0;
            int cows = 0;

            if (guess1 == num1)
            {
                bulls = bulls + 1;
            }
            else if (guess1 == num2)
            {
                cows = cows + 1;
            }
            else if (guess1 == num3)
            {
                cows = cows + 1;
            }
            else if (guess1 == num4)
            {
                cows = cows + 1;
            }

           if (guess2 == num2)
           {
                bulls = bulls + 1;
           }
           else if (guess2 == num1)
            {
                cows = cows + 1;
            }
            else if (guess2 == num3)
            {
                cows = cows + 1;
            }
            else if (guess2 == num4)
            {
                cows = cows + 1;
            }

           if (guess3 == num3)
            {
                bulls = bulls + 1;
            }
            else if (guess3 == num1)
            {
                cows = cows + 1;
            }
            else if (guess3 == num2)
            {
                cows = cows + 1;
            }
            else if (guess3 == num4)
            {
                cows = cows + 1;
            }

            if (guess4 == num4)
            {
                bulls = bulls + 1;
            }
            else if (guess4 == num1)
            {
                cows = cows + 1;
            }
            else if (guess4 == num2)
            {
                cows = cows + 1;
            }
            else if (guess4 == num3)
            {
                cows = cows + 1;
            }

            Console.WriteLine("bulls: " + bulls);
            Console.WriteLine("cows: " + cows);

            Console.WriteLine("try again");

            bulls = 0;
            cows = 0;
            bool correct = false;
            int attempts = 1;

            while (correct != true)
            {
                while (valid == false)
                {

                    Console.WriteLine("please input each digit of your quess individually");
                    guess1 = Convert.ToInt32(Console.ReadLine());
                    guess2 = Convert.ToInt32(Console.ReadLine());
                    guess3 = Convert.ToInt32(Console.ReadLine());
                    guess4 = Convert.ToInt32(Console.ReadLine());

                    if (guess1 > 0)
                    {
                        if (guess1 < 9)
                        {
                            if (guess1 != guess2)
                            {
                                if (guess1 != guess3)
                                {
                                    if (guess1 != guess4)
                                    {
                                        if (guess2 != guess3)
                                        {
                                            if (guess2 != guess4)
                                            {
                                                if (guess3 != guess4)
                                                {
                                                    valid = true;
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }

                }
                if (guess1 == num1)
                {
                    bulls = bulls + 1;
                }
                else if (guess1 == num2)
                {
                    cows = cows + 1;
                }
                else if (guess1 == num3)
                {
                    cows = cows + 1;
                }
                else if (guess1 == num4)
                {
                    cows = cows + 1;
                }

                if (guess2 == num2)
                {
                    bulls = bulls + 1;
                }
                else if (guess2 == num1)
                {
                    cows = cows + 1;
                }
                else if (guess2 == num3)
                {
                    cows = cows + 1;
                }
                else if (guess2 == num4)
                {
                    cows = cows + 1;
                }

                if (guess3 == num3)
                {
                    bulls = bulls + 1;
                }
                else if (guess3 == num1)
                {
                    cows = cows + 1;
                }
                else if (guess3 == num2)
                {
                    cows = cows + 1;
                }
                else if (guess3 == num4)
                {
                    cows = cows + 1;
                }

                if (guess4 == num4)
                {
                    bulls = bulls + 1;
                }
                else if (guess4 == num1)
                {
                    cows = cows + 1;
                }
                else if (guess4 == num2)
                {
                    cows = cows + 1;
                }
                else if (guess4 == num3)
                {
                    cows = cows + 1;
                }



                Console.WriteLine("bulls: " + bulls);
                Console.WriteLine("cows: " + cows);

                if (bulls == 4)
                {
                    Console.WriteLine("well done, that is correct, you guessed in " + attempts + " attempts");
                    correct = true;
                }

                if (bulls != 4)
                {
                    Console.WriteLine("try again");

                    bulls = 0;
                    cows = 0;
                    attempts = attempts + 1;
                }
                
                
                
                

            }

        }
    }
}
