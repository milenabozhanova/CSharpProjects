using System;

class PrintNullableTypes
{
    static void Main()
        {
            Nullable<int> ni = null;
            double? di = null;

            Console.WriteLine("ni = {0}", ni);
            Console.WriteLine("di = {0}", di);

            Console.WriteLine("ni = {0}", ni.GetValueOrDefault());
            Console.WriteLine("di = {0}", di.GetValueOrDefault());

            ni = 10;
            di = 5;

            Console.WriteLine("ni = {0}", ni);
            Console.WriteLine("di = {0}", di);
        }
}

