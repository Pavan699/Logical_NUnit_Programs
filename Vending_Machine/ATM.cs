using System;
using System.Collections.Generic;
using System.Text;

namespace Vending_Machine
{
    class ATM
    {
        int[] notes = new int[] {1000,500,100,50,10,5,2,1};
        int[] counter = new int[8];
        public void Check(int rupees)
        {
            for (int i = 0 ; i < notes.Length ; i++)
            {
                if (rupees >= notes[i])
                {
                    counter[i] = rupees / notes[i] ;
                    rupees = rupees - counter[i] * notes[i];
                }
            }
            for(int j = 0 ; j < notes.Length ; j++)
            {
                if(counter[j] != 0)
                {
                    Console.WriteLine(notes[j]+" ==> "+counter[j]);
                }
            }
        }
    }
}
