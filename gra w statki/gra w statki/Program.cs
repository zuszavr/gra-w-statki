using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography;
using System.Xml;

string[,] planszag = new string[10, 10];
string[,] planszag2 = new string[10, 10];

string[,] plansza = new string[10, 10];
string[,] plansza2 = new string[10, 10];
int s1 = 0;
int s2 = 0;

Random r1 = new Random();



bool gra = true;

int statki = 10;
int statkig = 20;

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
uststatki();
wypiszg();
wypisz();
while (gra)
{
    strzalg();
    strzalb();
    wypiszg();
    wypisz();
}

void wypisz()
{
    Console.WriteLine(" A  B  C  D  E  F  G  H  I  J");

    for (int j = 0; j < 10; j++)
    {
        for (int i = 0; i < 10; i++)
        {
            string pole = plansza[i, j];

            if (pole == null)
            {
                pole = "~";
            }

            if (pole == "~")
            {
                Console.BackgroundColor = ConsoleColor.Blue;
            }
            else if (pole == "O")
            {
                Console.BackgroundColor = ConsoleColor.DarkGray;
            }
            else if (pole == "x")
            {
                Console.BackgroundColor = ConsoleColor.Red;
            }
            else if (pole == "S")
            {
                Console.BackgroundColor = ConsoleColor.Green;
            }

            Console.Write(" " + pole + " ");
            Console.ResetColor();
        }

        Console.Write("  " + (j + 1));
        Console.WriteLine();
    }

    Console.WriteLine();
    Console.WriteLine("zostało: " + statki + " statków");
}

void wypiszg()
{
    Console.WriteLine(" A  B  C  D  E  F  G  H  I  J");

    for (int j = 0; j < 10; j++)
    {
        for (int i = 0; i < 10; i++)
        {
            string pole = planszag[i, j];
            if (pole == null) pole = "~";

            if (pole == "~") Console.BackgroundColor = ConsoleColor.DarkCyan;
            else if (pole == "S") Console.BackgroundColor = ConsoleColor.DarkRed;
            else if (pole == "x") Console.BackgroundColor = ConsoleColor.DarkGreen;
            else if (pole == "O") Console.BackgroundColor = ConsoleColor.DarkGray;

            Console.Write(" " + pole + " ");
            Console.ResetColor();
        }

        Console.Write("  " + (j + 1));
        Console.WriteLine();
    }
    Console.WriteLine();
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
            return strzal1();
    }
}
int strzal2()
{
    Console.WriteLine("Wybierz pole od 1 do 10");
    int.TryParse(Console.ReadLine(), out int x);
    switch (x)
    {
        case 1:
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
            return strzal2();
    }
}

void strz()
{
    s2 = strzal2();
}

void strzalg()
{
    s1 = strzal1();
    s1--;
    s2--;
    if (s1 < 0) s1 = 0;
    if (s2 < 0) s2 = 0;

    if (plansza2[s1, s2] == "S")
    {
        if (plansza[s1, s2] == "x" || plansza[s1, s2] == "O" || plansza[s1, s2] == "S")
        {
            Console.WriteLine("nie możesz tego dać");
            strzalg();
        }
        else
        {
            plansza[s1, s2] = "x";
            zatop(s1, s2);
        }
    }
    else
    {
        if (plansza[s1, s2] == "x" || plansza[s1, s2] == "O" || plansza[s1, s2] == "S")
        {
            Console.WriteLine("nie możesz tego dać");
            strzalg();
        }
        else
        {
            plansza[s1, s2] = "O";
        }
    }
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

void zatop(int x, int y)
{
    int startX = x;
    int endX = x;
    int startY = y;
    int endY = y;

    while (startX > 0 && plansza2[startX - 1, y] == "S")
    {
        startX--;
    }

    while (endX < 9 && plansza2[endX + 1, y] == "S")
    {
        endX++;
    }

    while (startY > 0 && plansza2[x, startY - 1] == "S")
    {
        startY--;
    }

    while (endY < 9 && plansza2[x, endY + 1] == "S")
    {
        endY++;
    }

    if (startX != endX)
    {
        for (int i = startX; i <= endX; i++)
        {
            if (plansza[i, y] != "x")
            {
                return;
            }
        }

        for (int i = startX; i <= endX; i++)
        {
            plansza[i, y] = "S";
        }
        statki--;
    }

    else if (startY != endY)
    {
        for (int i = startY; i <= endY; i++)
        {
            if (plansza[x, i] != "x")
            {
                return;
            }
        }

        for (int i = startY; i <= endY; i++)
        {
            plansza[x, i] = "S";
        }
        statki--;
    }


    else
    {
        if (plansza[x, y] == "x")
        {
            plansza[x, y] = "S";
            statki--;
        }
    }

    if (statki == 0)
    {
        gra = false;
        Console.Clear();
        Console.WriteLine("WYGRAŁEŚ");
    }
}

void uststatki()
{
    Console.WriteLine("Ustaw statki");

    uststatek(4);

    for (int i = 0; i < 2; i++)
        uststatek(3);

    for (int i = 0; i < 3; i++)
        uststatek(2);

    for (int i = 0; i < 4; i++)
        uststatek(1);
}

void uststatek(int dlug)
{
    bool postawiono = false;

    while (postawiono == false)
    {
        wypiszg();
        Console.WriteLine("Ustaw statek o długości: " + dlug);

        Console.WriteLine("Wybierz pole od A do J");
        char litera;
        char.TryParse(Console.ReadLine().ToUpper(), out litera);

        int x = litera - 'A';

        Console.WriteLine("Wybierz pole od 1 do 10");
        int y;
        int.TryParse(Console.ReadLine(), out y);
        y = y - 1;

        if (x < 0 || x > 9 || y < 0 || y > 9)
        {
            Console.WriteLine("Nie możesz tego dać");
            continue;
        }

        Console.WriteLine("Podaj kierunek:");
        Console.WriteLine("1 - poziomo");
        Console.WriteLine("2 - pionowo");

        string kierunek = Console.ReadLine().ToUpper();

        bool pion = false;

        if (kierunek == "1")
        {
            pion = true;
        }
        else if (kierunek == "2")
        {
            pion = false;
        }
        else
        {
            Console.WriteLine("Niepoprawny kierunek");
            continue;
        }

        if (spr(x, y, dlug, pion))
        {
            for (int i = 0; i < dlug; i++)
            {
                if (pion == true)
                {
                    planszag[x, y + i] = "S";
                }
                else
                {
                    planszag[x + i, y] = "S";
                }
            }

            postawiono = true;
        }
        else
        {
            Console.WriteLine("Nie można tu postawić statku");
        }
    }
}
bool spr(int x, int y, int dlug, bool pion)
{
    for (int i = 0; i < dlug; i++)
    {
        int nx = x;
        int ny = y;

        if (pion == true)
        {
            ny = y + i;
        }
        else
        {
            nx = x + i;
        }

        if (nx < 0 || nx > 9 || ny < 0 || ny > 9)
        {
            return false;
        }

        if (planszag[nx, ny] == "S")
        {
            return false;
        }

        for (int dx = -1; dx <= 1; dx++)
        {
            for (int dy = -1; dy <= 1; dy++)
            {
                int sx = nx + dx;
                int sy = ny + dy;

                if (sx >= 0 && sx <= 9 && sy >= 0 && sy <= 9)
                {
                    if (planszag[sx, sy] == "S")
                    {
                        return false;
                    }
                }
            }
        }
    }

    return true;
}

void strzalb()
{

    bool w = false;

    while (w == false)
    {
        int x = r1.Next(0, 10);
        int y = r1.Next(0, 10);

        if (planszag[x, y] == "S")
        {
            planszag[x, y] = "x";
            statkig--;

            w = true;
        }
        else if (planszag[x, y] == null)
        {
            planszag[x, y] = "O";
            w = true;
        }
    }
    if (statkig == 0)
    {
        gra = false;
        Console.Clear();
        Console.WriteLine("PRZEGRAŁEŚ");
    }
}