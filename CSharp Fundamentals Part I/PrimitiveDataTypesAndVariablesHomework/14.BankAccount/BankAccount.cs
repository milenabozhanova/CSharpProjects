using System;

    class BankAccount
    {
        static void Main(string[] args)
        {
            
            //Console.Write("Please write your first name:");
            //string fullName = Console.ReadLine();
            string fullName = "Milena Venzislavova Bozhanova";

            uint balance = 3000;
            //Console.WriteLine("{0:C2}", 123.456);

            string bankName = "Unicredit Bulbank";

            string iban = "BG11UNCR12345678901234";

            string bicCode = "UNCRBGAA";

            string creditCard1Number = "1111-1111-1111-1116";

            string creditCard2Number = "8888-1231-2323-4444";

            string creditCard3Number = "0000-1234-0000-1234";

            Console.WriteLine("Your bank account in {0}", bankName);
            Console.WriteLine();
            Console.WriteLine("Holder: {0}", fullName);
            Console.WriteLine("Balance: {0:C2}", balance);
            Console.WriteLine("IBAN: {0}", iban);
            Console.WriteLine("BIC: {0}", bicCode);
            Console.WriteLine("Creditcard's numbers: {0} \n {1} \n {2}",
            creditCard1Number, creditCard2Number.PadLeft(40, ' '), creditCard3Number.PadLeft(40, ' '));
        }
    }
