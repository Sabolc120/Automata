using System;

namespace automata
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator szamolo = new Calculator();
            Console.WriteLine("\t 1. Kávé");
            Console.WriteLine("\t 2. Tea");
            Console.WriteLine("\t 3. Csoki szelet");
            Console.WriteLine("\t 4. Tuc keksz");
            Console.WriteLine("\t 5. Energiaital");
            Console.WriteLine("\t 6. Víz");


            int anwser = int.Parse(Console.ReadLine());
            int quantity = 0, price_coffee = 200, price_tea = 150, price_chocobar = 300, price_biscuit = 350,
                price_energydrink = 220, price_water = 150, order_price, cash;
            int szazasok = 0, otvenesek = 0, huszasok = 0, tizesek = 0, otosok = 0;
            String item = "";
            bool machineOn = true;


            while (machineOn)
            {
                if (anwser == 1)
                {
                    item = "Kávé";
                    Console.Write("Mennyi {0}?: ",item);
                    quantity = int.Parse(Console.ReadLine());
                    szamolo.quantity_check(quantity, item);

                    order_price = price_coffee * quantity; //Kiszámolja a teljes árat mennyiség és ár alapján       
                    Console.WriteLine("Rendelés összege ennyi lesz: {0}", order_price);

                    Console.Write("Kérem, dobja be a pénzt: ");
                    cash = int.Parse(Console.ReadLine());

                    szamolo.ellenorzo(order_price, cash); //Lefutattja azt az ellnőrzőtt ami megnézi elegendő a pénz.
                    szamolo.Calculate(cash, order_price, szazasok, otvenesek, huszasok, tizesek, otosok, quantity); //Kiszámolja a visszajárót
                }
                if (anwser == 2)
                {
                    item = "Tea";
                    Console.Write("Mennyi {0}: ",item);
                    quantity = int.Parse(Console.ReadLine());
                    szamolo.quantity_check(quantity, item);

                    order_price = price_tea * quantity;
                    Console.WriteLine("Rendelés összege ennyi lesz: {0}", order_price);

                    Console.Write("Kérem, dobja be a pénzt: ");
                    cash = int.Parse(Console.ReadLine());

                    szamolo.ellenorzo(order_price, cash);
                    szamolo.Calculate(cash, order_price, szazasok, otvenesek, huszasok, tizesek, otosok, quantity);
                }
                if (anwser == 3)
                {
                    item = "Csoki szelet";
                    Console.Write("Mennyi {0}?: ",item);
                    quantity = int.Parse(Console.ReadLine());
                    szamolo.quantity_check(quantity, item);

                    order_price = price_chocobar * quantity; //Kiszámolja a teljes árat mennyiség és ár alapján
                    Console.WriteLine("Rendelés összege ennyi lesz: {0}", order_price);

                    Console.Write("Kérem, dobja be a pénzt: ");
                    cash = int.Parse(Console.ReadLine());

                    szamolo.ellenorzo(order_price, cash);
                    szamolo.Calculate(cash, order_price, szazasok, otvenesek, huszasok, tizesek, otosok, quantity);
                }
                if (anwser == 4)
                {
                    item = "Tuc keksz";
                    Console.Write("Mennyi {0}?: ",item);
                    quantity = int.Parse(Console.ReadLine());
                    szamolo.quantity_check(quantity, item);

                    order_price = price_biscuit * quantity; //Kiszámolja a teljes árat mennyiség és ár alapján
                    Console.WriteLine("Rendelés összege ennyi lesz: {0}", order_price);

                    Console.Write("Kérem, dobja be a pénzt: ");
                    cash = int.Parse(Console.ReadLine());

                    szamolo.ellenorzo(order_price, cash);
                    szamolo.Calculate(cash, order_price, szazasok, otvenesek, huszasok, tizesek, otosok, quantity);
                }
                if (anwser == 5)
                {
                    item = "Energiaital";
                    Console.Write("Mennyi {0}?: ",item);
                    quantity = int.Parse(Console.ReadLine());
                    szamolo.quantity_check(quantity, item);

                    order_price = price_energydrink * quantity; //Kiszámolja a teljes árat mennyiség és ár alapján
                    Console.WriteLine("Rendelés összege ennyi lesz: {0}", order_price);

                    Console.Write("Kérem, dobja be a pénzt: ");
                    cash = int.Parse(Console.ReadLine());

                    szamolo.ellenorzo(order_price, cash);
                    szamolo.Calculate(cash, order_price, szazasok, otvenesek, huszasok, tizesek, otosok, quantity);
                }
                if (anwser == 6)
                {
                    item = "Vizes palack";
                    Console.Write("Mennyi {0}?: ",item);
                    quantity = int.Parse(Console.ReadLine());
                    szamolo.quantity_check(quantity, item);

                    order_price = price_water * quantity; //Kiszámolja a teljes árat mennyiség és ár alapján
                    Console.WriteLine("Rendelés összege ennyi lesz: {0}", order_price);

                    Console.Write("Kérem, dobja be a pénzt: ");
                    cash = int.Parse(Console.ReadLine());

                    szamolo.ellenorzo(order_price, cash);
                    szamolo.Calculate(cash, order_price, szazasok, otvenesek, huszasok, tizesek, otosok, quantity);
                }
                machineOn = false;
            }
        }
    }
}