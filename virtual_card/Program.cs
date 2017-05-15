using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cards;
using Virtual;

namespace virtual_card_task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter full name: ");
            string fullname = Console.ReadLine();

            Virtual_card virtual_card = new Virtual_card(fullname);
            Card myCard = new Card("senem qenberova");


            if (fullname == myCard.FullName)
            {
                Console.WriteLine("Card was created by " + fullname);
            }
            else
            {
                Console.WriteLine("Card was not created");
            }

            Console.ReadKey();
        }
    }
}
