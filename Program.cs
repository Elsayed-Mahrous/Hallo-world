using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Diagnostics.Metrics;
using System.Collections.Generic;

namespace Hallo_world
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> myList = new List<int>();
            string yourOption;
            do
            {
                Console.WriteLine("\n\n\nP - Print numbers");
                Console.WriteLine("A - Add a number");
                Console.WriteLine("M - Display mean of the numbers");
                Console.WriteLine("S - Display the smallest number");
                Console.WriteLine("L - Display the largest number");
                Console.WriteLine("Q - Quit");
                Console.WriteLine("F - Find a number");
                Console.WriteLine("C - Clear The whole list");
                Console.WriteLine("W - Swap numbers");
                Console.Write("Enter your choice: ");

                 yourOption = Console.ReadLine().ToUpper();

                switch(yourOption)
                {
                    case "P":
                        if (myList.Count() > 0)
                        {
                            Console.Write("[ ");
                            for (int i = 0; i < myList.Count(); i++)
                            {
                                Console.Write(myList[i] + " ");

                            }
                            Console.Write("]");
                        }
                        else
                            Console.WriteLine("[] - The list is empty");
                        break;


                    case "A":
                        Console.Write("Enter the number to add: ");
                        int num = Convert.ToInt32(Console.ReadLine());
                        bool isHere = false;
                        if (myList.Count() > 0)
                        {
                            for (int i = 0; i < myList.Count(); i++)
                            {
                                if (num == myList[i])
                                {
                                    Console.WriteLine($"sorry the duplicat is not allow {num} is here already! ");
                                    isHere = true;
                                    break;
                                }
                            }
                        }
                        if(!isHere)
                        {
                            myList.Add(num);
                            Console.WriteLine($"{num} added");
                        }
                        break;

                    case "M":
                        if (myList.Count() > 0)
                        {
                            int sum =0;
                            for (int i = 0; i < myList.Count(); i++)
                            {
                                sum += myList[i];
                            }
                            double mean = (double)sum / myList.Count;
                            Console.WriteLine($"The mean is {mean} ");
                        }
                        else
                            Console.WriteLine("Unable to calculate the mean - no data");
                        break;


                    case "S":
                        if (myList.Count() > 0)
                        {
                            int smallestNumber = myList[0];
                            for (int i = 0; i < myList.Count(); i++)
                            {
                                if (smallestNumber > myList[i])
                                    smallestNumber = myList[i];
                            }
                            Console.WriteLine($"The smallest number is {smallestNumber}");
                        }
                        else
                            Console.WriteLine("Unable to determine the smallest number - list is empty");
                        break;

                    case "L":
                        if (myList.Count() > 0)
                        {
                            int largestNumber = myList[0];
                            for (int i = 0; i < myList.Count(); i++)
                            {
                                if (myList[i] > largestNumber)
                                    largestNumber = myList[i];
                            }
                            Console.WriteLine($"The largest Number is {largestNumber}");
                        }
                        else
                            Console.WriteLine("Unable to determine the smallest number - list is empty");
                        break;

                    case "F":
                        if (myList.Count() > 0)
                        {
                            Console.WriteLine("enter the number to find: ");
                            int numToFind = Convert.ToInt32(Console.ReadLine());
                            int indexOfNum = -1;
                            for (int i = 0; i < myList.Count(); i++)
                            {
                                if (numToFind == myList[i])
                                {
                                    indexOfNum = i;
                                    break;
                                }
                            }
                            if (indexOfNum == -1)
                                Console.WriteLine("The number is not find!");
                            else
                                Console.WriteLine($"The Index the Number is {indexOfNum}");

                        }
                        else
                            Console.WriteLine("Unable to determine the smallest number - list is empty");
                        break;


                    case "C":
                        myList.Clear();
                        Console.WriteLine("List clear succfully");
                        break;

                    case "Q":
                        Console.WriteLine("Good bye");
                        break;

                    case "W":
                        Console.WriteLine("Enter 2 Numbers you want swap between them one space: ");
                        string[] swapNumbers = Console.ReadLine().Split(" ");
                        int temp = 0;
                        if (myList.Count() > 0)
                        {
                            for (int i = 0; i < myList.Count(); i++)
                            {
                                if (myList[i] == Convert.ToInt32(swapNumbers[0]))
                                {
                                    for (int a = 0; a < myList.Count(); a++)
                                    {
                                        if (myList[a] == Convert.ToInt32(swapNumbers[1]))
                                        {
                                            temp = myList[i];
                                            myList[i] = myList[a];
                                            myList[a] = temp;
                                        }
                                    }
                                }
                            }
                        }
                        else
                            Console.WriteLine("no there data in list!");


                        break;

                    default:
                        Console.WriteLine("Unknown selection, please try again");
                        break;
                }

            } while (yourOption != "Q");
        }
    }
}






