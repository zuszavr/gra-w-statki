using System.Runtime.Intrinsics.X86;
using System.Xml;



string[,] plansza = new string[10, 10];
string[,] plansza2 = new string[10, 10];
int s1 = 0;
int s2 = 0;

Random r1 = new Random();


int p = 1;

bool o = false;
bool gra = true;

statekpoj(4);
for (int i = 0; i < 2; i++)
{
    statekpoj(3);
}
for (int i = 0; i < 3; i++)
{
    statekpoj(2);
}
for (int i = 0; i < 4; i++)
{
    statekpoj(1);
}


Console.WriteLine("   _____   __            __     __      _ \r\n  / ___/  / /_  ____ _  / /_   / /__   (_)\r\n  \\__ \\  / __/ / __ `/ / __/  / //_/  / / \r\n ___/ / / /_  / /_/ / / /_   / ,<    / /  \r\n/____/  \\__/  \\__,_/  \\__/  /_/|_|  /_/\r\n \r\n ");

wypisz();
while (gra)
{
    strzalg();
    wypisz();
}

void wypisz()
{

    Console.WriteLine(" A B C D E F G H I J");
    int j = 0;
    for (int ii = 0; ii < 10; ii++)
    {
        Console.BackgroundColor = ConsoleColor.Black;
        for (int i = 0; i < 10; i++)
        {
            Console.Write(" ");
            Console.BackgroundColor = ConsoleColor.Blue;
            if (plansza[i, j] == plansza[s1, s2])
            {
                if (plansza[s1, s2] == plansza[0, 0] && o == false)
                {
                    plansza[i, j] = "~";
                }
                else
                {
                    string St = plansza2[s1, s2];
                    if (St == "S")
                    {
                        plansza[s1, s2] = "x";
                    }
                    else
                    {
                        plansza[s1, s2] = "O";
                    }

                }

            }
            else if (plansza[i, j] == null)
            {
                plansza[i, j] = "~";
            }

            Console.Write(plansza[i, j]);
        }
        Console.BackgroundColor = ConsoleColor.Black;
        Console.Write(" ");
        Console.Write(p);
        p++;
        if (p == 11) { p = 1; }
        Console.Write("\n");
        j++;

    }
}

int strzal1()
{
    Console.WriteLine("Wybierz pole od A do J");
    char.TryParse(Console.ReadLine().ToUpper(), out char x);
    int y = (int)x;
    y = y - 64;
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

void strzalg()
{
    s1 = strzal1();
    s1--;
    s2--;
    if (s1 < 0) { s1 = 0; }
    if (s2 < 0) { s2 = 0; }

}
bool statekspr(int x, int y, bool kier, int dlug)
{
    for (int i = 0; i < dlug; i++)
    {
        int nx;
        int ny;

        if (kier)
        {
            nx = x;
            ny = y + i;
        }
        else
        {
            nx = x + i;
            ny = y;
        }

        if (nx < 0 || nx >= 10 || ny < 0 || ny >= 10)
            return false;

        for (int dx = -1; dx <= 1; dx++)
        {
            for (int dy = -1; dy <= 1; dy++)
            {
                int sx = nx + dx;
                int sy = ny + dy;

                if (sx >= 0 && sx < 10 && sy >= 0 && sy < 10)
                {
                    if (plansza2[sx, sy] == "S")
                        return false;
                }
            }
        }
    }

    return true;
}

void statekpoj(int dlug)
{
    bool post = false;

    while (!post)
    {
        int x = r1.Next(0, 10);
        int y = r1.Next(0, 10);
        bool kier = r1.Next(0, 2) == 0;

        if (statekspr(x, y, kier, dlug))
        {
            for (int i = 0; i < dlug; i++)
            {
                if (kier)
                    plansza2[x, y + i] = "S";
                else
                    plansza2[x + i, y] = "S";
            }

            post = true;
        }
    }
}
