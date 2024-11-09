using System;

class Progran{

    static void Main(string [] arg){

        int availableMeat = 250;
        int firstOrder, secondOrder, thirdOrder, fourthOrder, fifthOrder;

        firstOrder = 10;
        secondOrder = 25;
        thirdOrder = 50;
        fourthOrder = 100;
        fifthOrder = 200;

        int remainingMeat;

        char selection;

        Console.WriteLine("Welcome to Group 7 Butcher Program here is our Program Menu with " + availableMeat + "kg at the store");
        Console.WriteLine("A. 10kg  B. 25kg  C. 50kg  D. 100Kg  E. 200kg ");
        Console.WriteLine();
        Console.Write("Please,place your order from the selection : ");
        

        selection = Convert.ToChar(Console.ReadLine());

            switch(selection){

                case 'a':
                Console.WriteLine();
                Console.WriteLine("You have successfully placed an order for 10kg");
                remainingMeat = availableMeat - firstOrder;
                Console.WriteLine("Available meat is " + remainingMeat + "kg");
                break;
                
                case 'b':
                Console.WriteLine();
                Console.WriteLine("You have successfully placed an order for 25kg");
                remainingMeat = availableMeat - secondOrder;
                Console.WriteLine("Available meat is " + remainingMeat + "kg");
                break;

                case 'c':
                Console.WriteLine();
                Console.WriteLine("You have successfully placed an order for 50kg");
                remainingMeat = availableMeat - thirdOrder;
                Console.WriteLine("Available meat is " + remainingMeat + "kg");
                break;

                case 'd':
                Console.WriteLine();
                Console.WriteLine("You have successfully placed an order for 100kg");
                remainingMeat = availableMeat - fourthOrder;
                Console.WriteLine("Available meat is " + remainingMeat + "kg");
                break;

                case 'e':
                Console.WriteLine();
                Console.WriteLine("You have successfully placed an order for 200kg");
                remainingMeat = availableMeat - fifthOrder;
                Console.WriteLine("Available meat is " + remainingMeat + "kg");
                break;

                default:
                Console.WriteLine("Invalid input! Please choose from the Program menu.");
                break;

            }
        

    }
}