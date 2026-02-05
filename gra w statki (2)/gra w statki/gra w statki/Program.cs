string[,] plansza = new string[10, 10];
string[,] plansza2 = new string[10, 10];
int s1 = 0;
int s2 = 0;
Random r1 = new Random();
int p1 = 0;
int k1 = 10;
int wyl1 = r1.Next(p1 , k1);
int wyl2 = r1.Next(p1 , k1);
int p = 1;

bool o = false;

Console.WriteLine(wyl1);
Console.WriteLine(wyl2);

plansza2[wyl1, wyl2] = "S";

wypisz();
s1 = strzal1();
s1 = s1 - 1;
s2 = s2 - 1;
wypisz();

void wypisz()
{   

    Console.WriteLine("  A B C D E F G H I J");
    int j = 0;
    for (int ii = 0; ii < 10; ii++)
    {
        Console.Write(p);
        p = p + 1;
        if (p == 11) { p = 1; }
        for (int i = 0; i < 10; i++)
        {
            Console.Write(" ");
            if (plansza[i, j] == plansza[s1, s2])
            {
                if (plansza[s1, s2] == plansza[0,0] && o == false)
                {
                    plansza[i, j] = "~";
                }
                else
                {
                    if (plansza2[s1, s2] == "S")
                    {
                        plansza[s1, s2] = "x";
                    }
                    else
                    {
                        plansza[s1, s2] = "O";
                    }
                    
                }
                    
            }
            else if (plansza[i ,j] == null)
            {
                plansza[i, j] = "~";
            }
                
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
    Console.WriteLine(x);
    int y = (int)x;
    Console.WriteLine(y);
    y = y - 64;
    Console.WriteLine(y);
    switch (y)
    {
        case 1:
            strz();
            return 1;
        case 2:
            strz();
            return 2;
        case 3:
            strz();
            return 3;
        case 4:
            strz();
            return 4;
        case 5:
            strz();
            return 5;
        case 6:
            strz();
            return 6;
        case 7:
            strz();
            return 7;
        case 8:
            strz();
            return 8;
        case 9:
            strz();
            return 9;
        case 10:
            strz();
            return 10;
        default:
            Console.Clear();
            Console.WriteLine("Nie możesz tego dać");
            wypisz();
            strzal1();
            return 0;
    }
}
int strzal2()
{
    Console.WriteLine("Wybierz pole od 1 do 10");
    int.TryParse(Console.ReadLine(), out int x);
    switch (x)
    {
        case 1:
            o = true;
            return 1;
        case 2:

            return 2;
        case 3:

            return 3;
        case 4:

            return 4;
        case 5:

            return 5;
        case 6:

            return 6;
        case 7:

            return 7;
        case 8:

            return 8;
        case 9:

            return 9;
        case 10:

            return 10;
        default:
            Console.Clear();
            Console.WriteLine("Nie możesz tego dać");
            wypisz();
            strzal2();
            return 0;
    }
}

void strz()
{
    o = true;
    s2 = strzal2();
}