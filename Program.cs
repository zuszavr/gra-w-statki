string[,] plansza = new string[10, 10];

wypisz();
strzal1();

void wypisz()
{
    int j = 0;
    for (int ii = 0; ii < 10; ii++)
    {
        for (int i = 0; i < 10; i++)
        {
            plansza[i, j] = "~";
            Console.Write(plansza[i, j]);
        }
        Console.Write("\n");
        j++;
    }
}

int strzal1()
{
    Console.WriteLine("Wybierz pole od A do J");
    char.TryParse(Console.ReadLine(), out char x);
    int y = (int)x;
    y = y - 64;
    switch (y)
    {
        case 1:
            strzal2();
            return 1;
        case 2:
            strzal2();
            return 2;
        case 3:
            strzal2();
            return 3;
        case 4:
            strzal2();
            return 4;
        case 5:
            strzal2();
            return 5;
        case 6:
            strzal2();
            return 6;
        case 7:
            strzal2();
            return 7;
        case 8:
            strzal2();
            return 8;
        case 9:
            strzal2();
            return 9;
        case 10:
            strzal2();
            return 10;
        default:
            Console.Clear();
            Console.WriteLine("Nie możesz tego dać");
            wypisz();
            strzal1();
            return 0;
    }
}
void strzal2()
{
    Console.WriteLine("Wybierz pole od 1 do 10");
    int.TryParse(Console.ReadLine(), out int x);
    switch (x)
    {
        case 1:

            break;
        case 2:

            break;
        case 3:

            break;
        case 4:

            break;
        case 5:

            break;
        case 6:

            break;
        case 7:

            break;
        case 8:

            break;
        case 9:

            break;
        case 10:

            break;
        default:
            Console.Clear();
            Console.WriteLine("Nie możesz tego dać");
            wypisz();
            strzal2();
            break;
    }
}

