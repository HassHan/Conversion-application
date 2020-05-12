using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_4
{
    class PoundsKG : Program
    {
        private double OneKGP; //One KG and Pounds is declared as a private double.
        private int KGPLimit; //KG and Pounds Limit is declared as a private integer.

        public PoundsKG(int p)
        {
            OneKGP = 0.454; //One Pound s 0.454 KG.
            KGPLimit = p; //Limit is equal to p.
        }

        public void KGPTable()
        {

            double HalfVal = 0.5; //Half is 0.5.
            Console.WriteLine("\n  lbs   :  KG"); //Displays titles for the conversions.

            while (HalfVal < OneKGP) HalfVal = HalfVal + .5; //If the half value is less than one Litre/Gallon, half value is equal to half value + 0.5.

            for (int i = 1; i <= this.KGPLimit; i++) //i is equal to 1, i is less than or equal too the Litre/Gallon limit and then i adds 1. 
            {
                Console.WriteLine("{0,7:0.000} {1,7:0.000}", i, i * OneKGP); //Linear values are displayed on the application.

                while (HalfVal / this.OneKGP < i + 1 && i < this.KGPLimit) //Half Value divides by the conversion rate and adds a row each time a 0.5 appears uptil the user specified limit.
                {
                    Console.WriteLine("{0,7:0.000} {1,7:0.000}", HalfVal / OneKGP, HalfVal); //half unit values are displayed on the application.
                    HalfVal = HalfVal + .5; //half value is equal to half value + 0.5.
                }

            }
        }
    }
}
