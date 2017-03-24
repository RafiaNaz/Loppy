using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoppyProject2
{
    class Loppy
    {
        static void Main(string[] args)
        {
            //Declare the planets and each gravity constent that goes with it
            double Mercury = 0.37;
            double Venus = 0.88;
            double Mars = 0.38;
            double Jupiter = 2.64;
            double Saturn = 1.15;
            double Uranus = 1.15;
            double Neptune = 1.12;
            double Pluto = 0.04;


            //Print out the list of planets
            Console.WriteLine("List of planet" + "\n" + "1.Mercury" + "  " + "2.Venus" + "  " + "3.Earth" + "  ");
            Console.WriteLine("\n" + "4.Mars" + "  " + "5.Jupiter" + "  " + "6.Saturn" + "  ");
            Console.WriteLine("\n" + "7.Uranus" + "  " + "8.Neptune" + "  " + "9.Quit" + "  ");

            //Assign data types to both the Planet selection and weight user input
            int MenuChoice;
            int Weight;

            //Start of the Do while loop. Ask the user for input at the beginning of the loop. The input must be inside the loop so that it dies not run infinitely.
            do
            {
                //Asking the User to input the Menu Choice listed above
                Console.Write("\n" + "Enter Your Menu Choice: ");
                //Declare the function name for the input Planet Number nad use Convert to convert it from String to a Double
                MenuChoice = Convert.ToInt32(Console.ReadLine());

                //Asking the User to input their weight
                Console.Write("\n" + "Enter your weight on Earth: ");
                //Declare the function name for the weight
                Weight = Convert.ToInt32(Console.ReadLine());

                //Run the switch method on the MenuChoice
                switch (MenuChoice)
                {
                    //For each case, calculate the weight on another planet. eg: for int 1 calculate the weight on mercury.
                    //Run through each case if the number the user input matches the case number
                    case 1:
                        //Declare the data types for the answer to be a double. Each planet will have a different answer variable.
                        double Answer1 = (Mercury * Weight);
                        //Print the result
                        Console.WriteLine("Your weight of " + "" + Weight + "" + "pounds on Earth would be" + "" + Answer1 + "" + " pounds on Mercury.");
                        break;
                    case 2:
                        double Answer2 = (Venus * Weight);
                        Console.WriteLine("Your weight of " + Weight + "pounds on Earth would be" + Answer2 + " pounds on Venus.");
                        break;
                    case 3:
                        double Answer3 = (Mars * Weight);
                        Console.WriteLine("Your weight of " + Weight + "pounds on Earth would be" + Answer3 + " pounds on Mars.");
                        break;
                    case 4:
                        double Answer4 = (Jupiter * Weight);
                        Console.WriteLine("Your weight of " + Weight + "pounds on Earth would be" + Answer4 + " pounds on Jupiter.");
                        break;
                    case 5:
                        double Answer5 = (Saturn * Weight);
                        Console.WriteLine("Your weight of " + Weight + "pounds on Earth would be" + Answer5 + " pounds on Saturn.");
                        break;
                    case 6:
                        double Answer6 = (Uranus * Weight);
                        Console.WriteLine("Your weight of " + Weight + "pounds on Earth would be" + Answer6 + " pounds on Uranus.");
                        break;
                    case 7:
                        double Answer7 = (Neptune * Weight);
                        Console.WriteLine("Your weight of " + Weight + "pounds on Earth would be" + Answer7 + " pounds on Neptune.");
                        break;
                    case 8:
                        double Answer8 = (Pluto * Weight);
                        Console.WriteLine("Your weight of " + Weight + "pounds on Earth would be" + Answer8 + " pounds on Pluto.");
                        break;
                        /*For case 9, Do not out out any results other than the print line listed below
                         . I do not know which command to use to exit the console so I have just let the console do it itself*/
                    case 9:
                        Console.WriteLine("The program will terminate now . Goodbye!!");
                        return;
                        break;
                        //for any input other than integers 1-9, ask the user to input the menu number again. 
                        //This line also prints out the  user input for weight for some reason.
                    default:
                        Console.WriteLine("Please choose from the list above");
                        Console.Write("\n" + "Enter Your Menu Choice: ");
                        MenuChoice = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }
            //Run the Do while loop above as long as the MenuChoice ot the index numbers are not equal to 9.
            //So Run as long as the statement below is true

            while (MenuChoice != 9);

             
                Console.ReadLine();
        }
    }
}









