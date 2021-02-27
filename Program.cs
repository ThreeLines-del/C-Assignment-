using System;

namespace AssignmentMTN
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("    Menu");
            Console.WriteLine("(1) Transfer Money");
            Console.WriteLine("(2) MoMoPay & Pay Bill");
            Console.WriteLine("(3) Airtime and Bundles");
            Console.WriteLine("(4) Allow CAshout");
            Console.WriteLine("(5) Financial Services");
            Console.WriteLine("(6) My Wallet");

            a = Console.Read();

            if (a == '1')
            {
                Console.WriteLine("(1) MoMo User");
                Console.WriteLine("(2) Non MoMo User");
                Console.WriteLine("(3) Send with Care");
                Console.WriteLine("(4) Favourite");
                Console.WriteLine("(5) Other Networks");
                Console.WriteLine("(6) Bank Account");
                Console.WriteLine("(0) Back");

            }
            else if (a == '2')
            {
                Console.WriteLine("(1) MoMo Pay");
                Console.WriteLine("(2) Pay Bill");
                Console.WriteLine("(0) Back");
            }
            else if (a == '3')
            {
                Console.WriteLine("(1) Airtime");
                Console.WriteLine("(2) Internet Bundles");
                Console.WriteLine("(0) Back");
            }
            else if (a == '4') {
                Console.WriteLine("(1) Yes");
                Console.WriteLine("(2) No");
                Console.WriteLine("(0) Back");
            }
            else if (a == '5') {
                Console.WriteLine("(1) Bank Services");
                Console.WriteLine("(2) Savings");
                Console.WriteLine("(3) Loans");
                Console.WriteLine("(4) Pensions and Investments");
                Console.WriteLine("(5) Insurance");
                Console.WriteLine("(6) Trade Shares");
                Console.WriteLine("(0) Back");
            }
            else if (a == '6') {
                Console.WriteLine("(1) Check Balance");
                Console.WriteLine("(2) Allow Cashout");
                Console.WriteLine("(3) My Approvals");
                Console.WriteLine("(4) Report Fraud");
                Console.WriteLine("(5) Statements");
                Console.WriteLine("(6) Change & Reset PIN");
                Console.WriteLine("(7) Airtime");
                Console.WriteLine("# for next");
            }

           
           
        }
    }
}
