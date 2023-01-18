using System;

namespace _18._01._23
{
    class Program
    {
        static void Main(string[] args)
        {
            StandartPhone standartPhone = new StandartPhone();
            standartPhone.Call("4567890");
            standartPhone.AddAccount("Tina");
            standartPhone.AddAccount("Mark");
            standartPhone.AddAccount("Bob");
            standartPhone.PrintAllAccounts();
            standartPhone.PrintInfo();

        }
    }
}
