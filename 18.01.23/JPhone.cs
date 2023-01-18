using System;
using System.Collections.Generic;
using System.Text;

namespace _18._01._23
{
    internal abstract class JPhone
    {
        protected string DeviceName { get; set; }
        protected int Memory { get; set; }
        internal int Count { get; set; } = 0;
        internal abstract string[] Accounts { get; set; }
        internal abstract void Call(string phoneNumber);
        internal abstract void AddAccount(string accountName);
        internal void PrintAllAccounts();
        internal abstract void PrintInfo();
    }

    internal class StandartPhone : JPhone
    {
        private string[] _accounts = new string[3];
        internal override string[] Accounts { get => _accounts; set => _accounts = value; }

        public StandartPhone(string deviceName)
        {
            DeviceName = deviceName;
            Memory = 32;
        }
        internal override void AddAccount(string accountName)
        {
            if (Count >= 3)
            {
                Console.WriteLine("You cannot add more accounts, limit is reached");

                return;
            }


        }
        internal override void Call(string phoneNumber)
        {
            if (!(phoneNumber.Length >= 6 && phoneNumber.Length <= 8))

            {
                Console.WriteLine("invalid phone number, please check the number!");

                return;
            }
               

            if (!(phoneNumber.StartsWith('4')|| phoneNumber.StartsWith('6')))

            {
                Console.WriteLine("invalid phone number, please check the number!");

                return;
            }
           


            for (int i = 0; i< phoneNumber.Length; i++)
            {
                if (!char.IsDigit(phoneNumber[i]))
                {
                    Console.WriteLine("invalid phone number, please check the number! ");

                    return;
                }    
            }

            Console.WriteLine($"Callinng to number {phoneNumber}");
        }

        internal override void PrintAllAccounts()
        {
            if (Count == 0)
            {
                Console.WriteLine("No users accounts to disolay");

                return;
            }

            for (int i = 0; i < Count; i++)
            {
                Console.WriteLine(_accounts[i]);
            }
        }

        internal override void PrintInfo()
        {
            Console.WriteLine($"JPhone is called {DeviceName}, it has 32GB of memory ");
        }
    }
}
