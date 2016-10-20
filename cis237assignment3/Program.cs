using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    class Program
    {

        static void Main(string[] args)
        {
            int option;
            DroidCollection x = new DroidCollection();
            Console.WriteLine("1 would you like to add Drone\n2 print list\n3 calculate total cost");
            option = Convert.ToInt32(Console.ReadLine());
            while(option == 1)
            {
                x.addDroid();
                Console.WriteLine("would you like to add another drone?\n1 yes \n2 print list\n3 calculate total\n4 exit");
                option = Convert.ToInt32(Console.ReadLine());
            }
            if(option == 2){
                x.printList();
            }
            if(option == 3){
                x.totalCost();
            }

        }
    }
}

  