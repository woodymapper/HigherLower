


    Random r = new Random();

    int Card1 = r.Next(1, 10);


main();
int main()
{
    int opcja;
    opcja = Int32.Parse(Console.ReadLine());

    if (opcja == Card1)
    {
        Console.WriteLine("Wygrałeś");

        if (Card1 < opcja) { Console.WriteLine("Liczba była mniejsza"); }
        else if (Card1 > opcja) { Console.WriteLine("Liczba była Większa"); }

    }
    else if (opcja != Card1)
    {
        Console.WriteLine("Przegrałeś ");
        if (Card1 < opcja) { Console.WriteLine("Liczba była mniejsza"); }
        else if (Card1 > opcja) { Console.WriteLine("Liczba była Większa"); }

        main();
    }

    return Card1;
}









