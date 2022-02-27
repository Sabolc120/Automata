using System;
using System.Collections.Generic;
using System.Text;

namespace automata
{
    class Calculator
    {
        public void Calculate(int cash, int order_price, int szazasok, int otvenesek, int huszasok, int tizesek, int otosok, int quantity)
        {

            cash -= order_price;
            if (cash / 100 >= 1)
            {

                szazasok = cash / 100; //Elosztja százzal a bedobott pénzt
                cash -= szazasok * 100; //Bedobott pénz: 1250, - 12 *100, akkor marad még 50 forint és tovább megy//az if branch
            }
            if (cash / 50 >= 1)
            {
                otvenesek = cash / 50;
                cash -= otvenesek * 50;
            }
            if (cash / 20 >= 1)
            {
                huszasok = cash / 20;
                cash -= huszasok * 20;
            }
            if (cash / 10 >= 1)
            {
                tizesek = cash / 10;
                cash -= tizesek * 10;
            }
            if (cash / 5 >= 1)
            {
                otosok = cash / 5;
                cash -= otosok * 5;
            }
            if(szazasok >=1 || otvenesek >=1 || huszasok >=1 || tizesek >=1 || otosok >= 1 || quantity <=20) //Ne fusson le feleslegesen ha nincsen visszajáró
            {
                Console.WriteLine("\n");
                Console.WriteLine("Visszajáró százasokban: {0}", szazasok);
                Console.WriteLine("Visszajáró ötvenesekben: {0}", otvenesek);
                Console.WriteLine("Visszajáró huszasokban: {0}", huszasok);
                Console.WriteLine("Visszajáró tizesekben: {0}", tizesek);
                Console.WriteLine("Visszajáró ötösökben: {0}", otosok);
            }
        }
        public void ellenorzo(int order_price, int cash)
        {
            if (cash < order_price)
            {
                Console.WriteLine("Nem elegendő pénz!");
                Console.WriteLine("Bedobott pénz: {0}, rendelés összege: {1}", cash, order_price);
                Console.WriteLine("Kilépés..Pénz kidobása.");
            }
        }
        public void quantity_check(int quantity, string name)
        {
            if(quantity > 20)
            {
                Console.WriteLine("Nincen {0} elérhető {1} az automatában!(Out Of Stock)! Próbáljon meg kissebb mennyiségben rendelni.",quantity,name);
                Console.WriteLine("Kilépés..");
                System.Environment.Exit(0);
            }
        }
    }
}