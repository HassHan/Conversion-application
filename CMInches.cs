using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_4
{
    class CMInches : Program
    {
        private double OneCMI; //One CM and Inches is declared as a private double.
        private int cmiLimit; //CM and Inches Limit is declared as a private integer.

        public CMInches(int c)
        {
            OneCMI = 0.394;  //One Centimetre is 0.394 inches.
            cmiLimit = c; //Limit is equal to c.
        }

        public void CMITable()
        {

            double HalfVal = 0.5; //Half is 0.5.
            Console.WriteLine("\n   CM   : Inches"); //Displays titles for the conversions.

            while (HalfVal < OneCMI) HalfVal = HalfVal + .5; //If the half value is less than one Litre/Gallon, half value is equal to half value + 0.5.

            for (int i = 1; i <= this.cmiLimit; i++) //i is equal to 1, i is less than or equal too the Litre/Gallon limit and then i adds 1. 
            {
                Console.WriteLine("{0,7:0.000} {1,7:0.000}", i, i * OneCMI); //Linear values are displayed on the application.

                while (HalfVal / this.OneCMI < i + 1 && i < this.cmiLimit) //Half Value divides by the conversion rate and adds a row each time a 0.5 appears uptil the user specified limit.
                {
                    Console.WriteLine("{0,7:0.000} {1,7:0.000}", HalfVal / OneCMI, HalfVal); //half unit values are displayed on the application.
                    HalfVal = HalfVal + .5; //half value is equal to half value + 0.5.
                }

            }
        }
    }
}
