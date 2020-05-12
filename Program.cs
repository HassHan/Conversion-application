using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Console Application produces a conversion chart of the equivalent values for litres and gallons and 3 additional conversions too.

namespace Question_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hassan Hanif"); //Author Name.
            Console.WriteLine("\nPrint a conversion chart showing the equivalent values for litres");
            Console.WriteLine("and gallons (1 gallon = 4.54609 litres).");

            Console.WriteLine("\nPress 1 and then enter for Litres and Gallons Conversion Chart"); //First Option.
            Console.WriteLine("Press 2 and then enter for Centimetres and Inches Conversion Chart"); //Second Option.
            Console.WriteLine("Press 3 and then enter for Pounds and KG Conversion Chart"); //Third Option.
            Console.WriteLine("Press 4 and then enter to Create your own Conversion Chart"); //Fourth Option
            Console.WriteLine("Press 5 and then enter to Exit"); //Fifth Option
            Console.Write("\nEnter Option: "); //User enters their choice for any of the conversion charts listed above.

            LitresGallons Conversion; //Litre and Gallon Class declared as the first conversion.
            CMInches Conversion1; //CM and Inches Class declared as the second conversion.
            PoundsKG Conversion2; //Pounds and KG Class declared as the third conversion.
            CustomConversion Conversion3; //Custom Conversion declared as the fifth conversion.

            int val, l; //Declaring the inputted value and limit as a integer.
            int menuOption = 0; //numbers are declared for the menu system.
            string fr, to; //Declaring from and to for the custom conversion as a string.
            double r; //Declaring rate for the custom conversion as a double.

            do
            {
                menuOption = Convert.ToInt32(Console.ReadLine()); //Number selection for the menu.
                switch (menuOption)
                {
                    case 1: //When 1 is pressed on the keyboard, the user will then enter any number and the conversion chart will display from 1 up to the limit they have inputted.
                        {
                            if (menuOption == 1) //if 1 is selected as an option

                                Console.Write("\nEnter a limit: "); //User enters any limit of their choice.

                            while (!int.TryParse(Console.ReadLine(), out val)) ; //Console reads the number inputted by the user.

                            Conversion = new LitresGallons(val); //Calls the LitresGallons class.
                            Conversion.LGTable(); //LitresGallons table displays.

                            Console.Write("\nPress ANY key to exit..."); //User can press any key on the keyboard to exit the application.
                            Console.ReadKey(); //Reads the key selected to exit the application.

                        }
                        break;

                    case 2: //When 2 is pressed on the keyboard, the user will then enter any number and the conversion chart will display from 1 up to the limit they have inputted.
                        {

                            if (menuOption == 2) //if 2 is selected as an option

                                Console.Write("\nEnter a limit: "); //User enters any limit of their choice.

                            while (!int.TryParse(Console.ReadLine(), out val)) ; //Console reads the number inputted by the user.

                            Conversion1 = new CMInches(val); //Calls the CMInches class.
                            Conversion1.CMITable(); //CMInches table displays.

                            Console.Write("\nPress ANY key to exit..."); //User can press any key on the keyboard to exit the application.
                            Console.ReadKey(); //Reads the key selected to exit the application.

                        }
                        break;

                    case 3:  //When 3 is pressed on the keyboard, the user will then enter any number and the conversion chart will display from 1 up to the limit they have inputted.
                        {
                            if (menuOption == 3) //if 3 is selected as an option

                                Console.Write("\nEnter a limit: "); //User enters any limit of their choice.

                            while (!int.TryParse(Console.ReadLine(), out val)) ; //Console reads the number inputted by the user.

                            Conversion2 = new PoundsKG(val); //Calls the PoundsKG class.
                            Conversion2.KGPTable(); //PoundsKG table displays.

                            Console.Write("\nPress ANY key to exit..."); //User can press any key on the keyboard to exit the application.
                            Console.ReadKey(); //Reads the key selected to exit the application.

                        }
                        break;

                    case 4:

                        if (menuOption == 4) //if 4 is selected as an option
                        {
                            Console.Write("From: "); //User enters unit that they want to convert from.
                            fr = Console.ReadLine(); //Reads user input.

                            Console.Write("To: ");  //User enters unit they want to convert to.
                            to = Console.ReadLine(); //Reads user input.


                            do
                            {
                                Console.Write("\nEnter the conversion rate: "); //Enter conversion rate.

                            } while (!double.TryParse(Console.ReadLine(), out r)); //If conversion rate a number, go to limit. If not a number, repeate process until correct input.


                            do
                            {
                                Console.Write("\nEnter a limit: "); //Enter the limit.

                            } while (!int.TryParse(Console.ReadLine(), out l)); //If conversion rate a number, go to output. If not a number, repeate process until correct input.

                            Conversion3 = new CustomConversion(fr, to, r, l); //Calls the custom conversion chart.
                            Conversion3.CCTable(); //Displays output of the custom conversions.

                            Console.Write("\nPress ANY key to exit..."); //User can press any key on the keyboard to exit the application.
                            Console.ReadKey(); //Reads the key selected to exit the application.
                        }
                        break;

                    case 5:
                        if (menuOption == 5) //if 5 is selected as an option.
                        {
                            Environment.Exit(0); //program will exit.
                        }
                        break;

                    default:

                        //if user enters a value greater than 5, error message will appear until user enters correct value within the range.
                        Console.Write("Error. Please enter the correct menu option: ");
                        break;
                }
            }
            while (menuOption > 5); //error message appears if user input for menu selection is greater than 5.
        }
    }
}