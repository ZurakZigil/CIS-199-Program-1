/*
Grading ID: W9957
Program#: 1
Due Date: 2/13/2018 11:59.00
Course Section: 199-01

Description:
A calculater that goes and prompts the user for several inputs to calculate the number of gallons needed to paint a room,
and the price it will cost to do so.

*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_1
{
    class Program
    {
        static void Main(string[] args)
        {

            double parameter=0;             //variable set to the parameter
            double wall1, wall2, height;    //used to calculate the parameter if the user has a rectangle room
            string roomQuestion;            //used to determine if the user has a rectangle room

            int numDoors;                   //variable set to the number of doors
            const int doorSize = 20;        //constant for size subtracted from the room for a door

            int numWindows;
            const int windowSize = 15;      //constant for size subtracted from the room for a door

            double wallSpace=0;             //used to calculate the area of the space on the wall            
            double wallSpacePaint;          //used after multiplying for how many coats of paint

            int numPaint;                   //the coats of paint needed
            double paintCost;               //price of paint
            double totalPaint;              //the amount of paint you needed
            int gallonsToBuy;               //final rouneded number of gallons to buy
            const int paintSize = 375;      //constant for amount of paint per gallon

            double totalPrice;              //the final price needed

            Console.WriteLine("This program is meant to calculate how much it will cost to paint a room.");

            while (parameter == 0)      //loops so the user doesn't mess up the question
            {
                Console.Write("STEP 1: Is your room a rectangle? Y = Yes N = No : ");
                roomQuestion = (Console.ReadLine());
                //if statement meant to force the user to submit proper data
                //first if, if they have a rectangle room
                if (roomQuestion == "y" || roomQuestion == "Y" || roomQuestion == "Yes" || roomQuestion == "yes")
                {
                    Console.Write("Length of 1st wall (in feet): ");
                    wall1 = double.Parse(Console.ReadLine());
                    Console.Write("Length of 2nd wall (in feet): ");
                    wall2 = double.Parse(Console.ReadLine());

                    parameter = (wall1 * 2) + (wall2 * 2);
                    Console.WriteLine(parameter);

                }
                //second if, if they want to just put in the total amount
                else if (roomQuestion == "n" || roomQuestion == "N" || roomQuestion == "No" || roomQuestion == "no")
                {
                    Console.Write("Total length of walls (in feet) :");
                    parameter = double.Parse(Console.ReadLine());
                }
                //if their reply isn't valid
                else
                {
                    Console.Write("Please type a valid answer. Restarting...\n\n");
                }
            }

            //calculates area of wall space
            Console.Write("STEP 2: height of the walls (in feet) :");
            height = double.Parse(Console.ReadLine());
            wallSpace = parameter * height;

            //calculates area of wall space - doors
            Console.Write("STEP 3: Number of doors :");
            numDoors = int.Parse(Console.ReadLine());
            wallSpace = wallSpace - (numDoors * doorSize);

            //calculates are of wall space after doors - windows
            Console.Write("STEP 4: Number of windows :");
            numWindows = int.Parse(Console.ReadLine());
            wallSpace = wallSpace - (numWindows * windowSize);

            //how many coats of paint is needed * wallspace after doors and windows
            //eventually solves how many gallons
            Console.Write("STEP 5: Number of coats of paint :");
            numPaint = int.Parse(Console.ReadLine());   
            wallSpacePaint = wallSpace * numPaint;         
            totalPaint = wallSpacePaint / paintSize;        //divides by how much area a gallon of paint can cover
            gallonsToBuy = (int)Math.Ceiling(totalPaint);   //round the # of gallons up

            //decalres cost per gallon
            Console.Write("STEP 6: cost per gallon of paint (in $) :$");
            paintCost = double.Parse(Console.ReadLine());

            //calculates cost
            totalPrice = gallonsToBuy * paintCost;
            Console.Write("\n");

            //final statement 
            Console.WriteLine($"You need a minimum of {totalPaint:F2} gallons of paint.\nYou'll need to buy {gallonsToBuy} gallons, though, at a cost of {totalPrice:C}.");
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadLine();

        }
    }
}
