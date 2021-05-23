using System;

namespace ShoppingCart
{
    class program
    {
       static void Main()
        {
            SumNumers(1);
        }

        public static void SumNumers(int parameter)
        {
            if(parameter==251)
            {
                return;
            }

            Console.WriteLine(parameter);

            parameter = parameter + 1;

            SumNumers(parameter);
        }
    }
}
