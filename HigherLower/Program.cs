using System;


class Program
{
    static void CardType(int Card, int num)
    {
        switch (Card)
        {
            case 11: Console.WriteLine("Karta " + num + " był to: Jopek."); break;
            case 12: Console.WriteLine("Karta " + num + " była to: Królowa."); break;
            case 13: Console.WriteLine("Karta " + num + " był to: Król."); break;
            default: Console.WriteLine("Karta " + num + " była: " + Card + "."); break;
        }
    }
    static void Main(string[] args)
    {
        bool p = true;
        while (p)
        {
            Random r = new Random();
            int Card1 = r.Next(1, 13);
            int Card2 = r.Next(1, 13);          //randomowość
            while (Card1 == Card2) Card2 = r.Next(1, 13);
            CardType(Card1, 1);
            Console.WriteLine("Czy Karta 1 jest (W)iększa czy (M)niejsza w porównaniu do karty 2?(domyślnie jest higher):"); //pytanie
            bool which = true; // higher to true lower to false
            if (Console.ReadLine() == "M") which = false;
            CardType(Card2, 2);                                                                                                        
            if (!which && Card2 > Card1 || which && Card1 > Card2) Console.WriteLine("Wygrałeś wpisz end aby zakończyć lub kontynuj."); //!which to false czyli lower 
            else Console.WriteLine("Przegrałeś wpisz end aby zakończyć lub kontynuj.");
            if (Console.ReadLine() == "end") p = false;
        }
        Console.WriteLine("GG");
    }
}
