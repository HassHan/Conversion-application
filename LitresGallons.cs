using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_4
{
    class LitresGallons : Program
    {
        private double OneLG; //One Litre and Gallon is declared as a private double.
        private int LGLimit; //Litre and Gallon Limit is declared as a private integer.

        public LitresGallons(int l)
        {
            OneLG = 0.220; //One Litre is 0.220 Gallons.
            LGLimit = l; //Limit is equal to l.
        }

        public void LGTable()
        {

            double HalfVal = 0.5; //Half is 0.5.
            Console.WriteLine("\n Litres : Gallons"); //Displays titles for the conversions.

            while (HalfVal < OneLG) HalfVal = HalfVal + .5; //If the half value is less than one Litre/Gallon, half value is equal to half value + 0.5.

            for (int i = 1; i <= this.LGLimit; i++) //i is equal to 1, i is less than or equal too the Litre/Gallon limit and then i adds 1. 
            {
                Console.WriteLine("{0,7:0.000} {1,7:0.000}", i, i * OneLG); //Linear values are displayed on the application.

                while (HalfVal / this.OneLG < i + 1 && i < this.LGLimit) //Half Value divides by the conversion rate and adds a row each time a 0.5 appears uptil the user specified limit.
                {
                    Console.WriteLine("{0,7:0.000} {1,7:0.000}", HalfVal / OneLG, HalfVal); //half unit values are displayed on the application.
                    HalfVal = HalfVal + .5; //half value is equal to half value + 0.5.
                }

            }
        }
    }
}
