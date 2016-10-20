using System;

namespace cis237assignment3
{
    internal class UI
    {
        string droid;
        IDroid x;

        string model;
        string material;
        string color;
        bool connection;
        bool toolbox;
        bool arm;
        int numberOfShips;
        bool fireEx;
        bool vacuum;
        bool trashCompactor;

        int toolNum;
        int connectionNum;
        int armNum;


        public UI()
        { }
        public IDroid createDroid() {
            Console.WriteLine("pick model:\n1 R2D2\n2 C3P0\n3 BB-8");
            int modelNum = Convert.ToInt32(Console.ReadLine());
            switch (modelNum)
            {
                case 1:
                    model = "R2D2";
                    break;
                case 2:
                    model = "C3P0";
                    break;
                case 3:
                    model = "BB-8";
                    break;
            }
            Console.WriteLine("pick material:\n1 titanium\n2 aluminum\n3 steel");
            int materialNum = Convert.ToInt32(Console.ReadLine());
            switch (materialNum)
            {
                case 1:
                    material = "titanium";
                    break;
                case 2:
                    material = "aluminum";
                    break;
                case 3:
                    material = "steel";
                    break;
            }
            Console.WriteLine("Choose custom color");
            color = Console.ReadLine();

            Console.WriteLine("Pick droid type\n1 Protocol\n2 janitor\n3 astromech");
            int droidtype = Convert.ToInt32(Console.ReadLine());
            switch (droidtype)
            {
                case 1:
                    Console.WriteLine("enter number of languages");
                    int numLang = Convert.ToInt32(Console.ReadLine());
                    x = new Protocol(material, model, color, numLang);

                    break;
                case 2:
                    Console.WriteLine("would you connection?\n1 yes\n2 no");
                    connectionNum = Convert.ToInt32(Console.ReadLine());
                    if (connectionNum == 1)
                    {
                        connection = true;
                    }
                    Console.WriteLine("would you toolbox?\n1 yes\n2 no");
                    toolNum = Convert.ToInt32(Console.ReadLine());
                    if (toolNum == 1)
                    {
                        toolbox = true;
                    }
                    Console.WriteLine("would you arm?\n1 yes\n2 no");
                    armNum = Convert.ToInt32(Console.ReadLine());
                    if (armNum == 1)
                    {
                        arm = true;
                    }
                    Console.WriteLine("would you vacuum?\n1 yes\n2 no");
                    int vacNum = Convert.ToInt32(Console.ReadLine());
                    if (vacNum == 1)
                    {
                        vacuum = true;
                    }
                    Console.WriteLine("would you trashCompactor?\n1 yes\n2 no");
                    int trashNum = Convert.ToInt32(Console.ReadLine());
                    if (trashNum == 1)
                    {
                        trashCompactor = true;
                    }
                    x = new Janitor(material, model, color, connection, toolbox, arm, trashCompactor, vacuum);
                    droid = x.ToString();

                    break;
                case 3:
                    Console.WriteLine("would you connection?\n1 yes\n2 no");
                    connectionNum = Convert.ToInt32(Console.ReadLine());
                    if (connectionNum == 1)
                    {
                        connection = true;
                    }
                    Console.WriteLine("would you toolbox?\n1 yes\n2 no");
                    toolNum = Convert.ToInt32(Console.ReadLine());
                    if (toolNum == 1)
                    {
                        toolbox = true;
                    }
                    Console.WriteLine("would you arm?\n1 yes\n2 no");
                    armNum = Convert.ToInt32(Console.ReadLine());
                    if (armNum == 1)
                    {
                        arm = true;
                    }
                    Console.WriteLine("Would you like a fire exstingusiher?\n1 yes\n2 no");
                    int fireNum = Convert.ToInt32(Console.ReadLine());
                    if (fireNum == 1)
                    {
                        fireEx = true;
                    }
                    Console.WriteLine("how many ships do you want?");
                    numberOfShips = Convert.ToInt32(Console.ReadLine());

                    x = new AstroMech(material, model, color, connection, toolbox, arm, numberOfShips, fireEx);
                    droid = x.ToString();
                    break;


            }
            return x;
            }

            public IDroid getDroid(){
            return x;
            }

        }
    }





    

