using System;


namespace Open_Lab_02._02
{
    public class Formatter
    {
        public void Format(double[] numbers)
        {
            int k;

            for (k = 0; k < numbers.Length; k++)
            {

                double Cislo = numbers[k];
                if (k == 0)
                {
                    Console.Write(Math.Round(Cislo, 2).ToString().Replace(",", "."));
                }
                else
                {
                    Console.Write(" " + Math.Round(Cislo, 2).ToString().Replace(",", "."));
                }
               
                
                
            }
            
             


        }
        




    }




    
}






      