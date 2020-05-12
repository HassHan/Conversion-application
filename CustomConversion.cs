using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_4
{
    class CustomConversion : Program
    {
        private string From, To; //Declaring the from and to units.
        private double CR; //Declaring the conversion rate.
        private int L; //Declaring the limit.

        public CustomConversion(string fr, string to, double r, int l)
        {
            this.From = fr; //From this unit.
            this.To = to; //To this unit.
            this.CR = r; //This conversion rate.
            this.L = l; //This Limit.
        }

        public void CCTable()
        {

            double HalfVal = 0.5; //Half is 0.5.
            Console.WriteLine("\n  {0,-9}    {1,-7}", this.From, this.To); //Displays titles for the conversions.

            while (HalfVal < CR) HalfVal = HalfVal + .5;  //If the half value is less than one Litre/Gallon, half value is equal to half value + 0.5.

            for (int i = 1; i <= this.L; i++) //i is equal to 1, i is less than or equal too the Litre/Gallon limit and then i adds 1. 
            {
                Console.WriteLine("{0,7:0.000}      {1,7:0.000}", i, i * CR);  //Linear values are displayed on the application.

                while (HalfVal / this.CR < i + 1 && i < this.L)  //Half Value divides by the conversion rate and adds a row each time a 0.5 appears uptil the user specified limit.
                {
                    Console.WriteLine("{0,7:0.000}      {1,7:0.000}", HalfVal / CR, HalfVal); //half unit values are displayed on the application.
                    HalfVal = HalfVal + .5; //half value is equal to half value + 0.5.
                }
            }
        }
    }
}
