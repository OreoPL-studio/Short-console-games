Console.WriteLine("Witaj w grze w kółko i krzyżyk");

int[,] tablica = new int[3, 3];

bool gameOver = false;

wyswietl();

while (gameOver == false)
{
    ruchGracza(1);
    if (game(1))
        break;
    wyswietl();
    ruchGracza(2);
    if (game(2))
        break;
    wyswietl();
}

wyswietl();

bool game(int gracz)
{
    if (tablica[0, 0] == gracz && tablica[0, 1] == gracz && tablica[0, 2] == gracz)
    {
        Console.WriteLine("Gracz numer " + gracz + " wygrał!");
        return true;
    }
    else if (tablica[1, 0] == gracz && tablica[1, 1] == gracz && tablica[1, 2] == gracz)
    {
        Console.WriteLine("Gracz numer " + gracz + " wygrał!");
        return true;
    }
    else if (tablica[2, 0] == gracz && tablica[2, 1] == gracz && tablica[2, 2] == gracz)
    {
        Console.WriteLine("Gracz numer " + gracz + " wygrał!");
        return true;
    }
    else if (tablica[0, 0] == gracz && tablica[1, 0] == gracz && tablica[2, 0] == gracz)
    {
        Console.WriteLine("Gracz numer " + gracz + " wygrał!");
        return true;
    }
    else if (tablica[0, 1] == gracz && tablica[1, 1] == gracz && tablica[2, 1] == gracz)
    {
        Console.WriteLine("Gracz numer " + gracz + " wygrał!");
        return true;
    }
    else if (tablica[0, 2] == gracz && tablica[1, 2] == gracz && tablica[2, 2] == gracz)
    {
        Console.WriteLine("Gracz numer " + gracz + " wygrał!");
        return true;
    }
    else if (tablica[0, 0] == gracz && tablica[1, 1] == gracz && tablica[2, 2] == gracz)
    {
        Console.WriteLine("Gracz numer " + gracz + " wygrał!");
        return true;
    }
    else if (tablica[0, 2] == gracz && tablica[1, 1] == gracz && tablica[2, 0] == gracz)
    {
        Console.WriteLine("Gracz numer " + gracz + " wygrał!");
        return true;
    }
    else
    {
        return false;
    }
}

void wyswietl()
{
    for (int i = 0; i < tablica.Length / 3; i++)
    {
        for (int j = 0; j < 3; j++)
        {
            Console.Write(tablica[i, j]);
        }
        Console.Write("\n");
    }
}

void ruchGracza(int gracz)
{
    Console.WriteLine("Ruch gracza numer: " + gracz);
    Console.WriteLine("Podaj współrzędne x i y");
    string input_xS = Console.ReadLine();
    int input_x = int.Parse(input_xS);
    string input_yS = Console.ReadLine();
    int input_y = int.Parse(input_yS);


    if (tablica[input_x, input_y] == 0)
    {
        tablica[input_x, input_y] = gracz;
    }
    else
    {
        Console.WriteLine("To miejsce jest już zajęte!");
        ruchGracza(gracz);
    }
}