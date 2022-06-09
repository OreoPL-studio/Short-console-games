Console.WriteLine("Witaj w grze w wisielca");
Console.WriteLine("Podaj wyraz ");
string wyraz = Console.ReadLine();
string odgadywany_wyraz = "";
bool gameOver = false;
odgadywany_wyraz = podlogi();
int counter = 0;

Console.WriteLine(odgadywany_wyraz);
while (gameOver == false)
{
    guessing();
    szubienica();
}

string podlogi()
{
    for (int i = 0; i < wyraz.Length; i++)
    {
        odgadywany_wyraz += "_";
    }
    return odgadywany_wyraz;
}

void guessing()
{
    Console.WriteLine("Wpisz literę: ");
    char guess = Console.ReadKey().KeyChar;
    char[] odgadywany_wyraz_char = odgadywany_wyraz.ToCharArray();

    for (int i = 0; i < wyraz.Length; i++)
    {

        if (wyraz[i] == guess)
        {
            odgadywany_wyraz_char[i] = guess;

            if (odgadywany_wyraz[i] == guess)
            {
                Console.WriteLine(" \n Ta litera została już użyta");
                guessing();
            }
            Console.WriteLine("");

            if (odgadywany_wyraz_char.Contains('_'))
            {
                gameOver = false;
            }
            else
            {
                gameOver = true;
                Console.WriteLine("Zgadujący wygrali!");
            }
        }
        if (wyraz.Contains(guess) == false)
        {
            counter++;
        }
    }
    odgadywany_wyraz = new string(odgadywany_wyraz_char);
    Console.WriteLine("");
    Console.WriteLine(odgadywany_wyraz);
}

void szubienica()
{
    if (counter >= wyraz.Length)
    {
        Console.WriteLine("\t &-----@");
        if (counter >= wyraz.Length * 2)
        {
            Console.WriteLine("\t |     |");
            if (counter >= (wyraz.Length * 3))
            {
                Console.WriteLine("\t|_|    |");
                if (counter >= (wyraz.Length * 4))
                {
                    Console.WriteLine("\t/|\\    |");
                    if (counter >= wyraz.Length * 5)
                    {
                        Console.WriteLine("\t/ \\    |");
                        if (counter >= wyraz.Length * 6)
                        {
                            Console.WriteLine("\t       |");
                            if (counter >= wyraz.Length * 7)
                            {
                                Console.WriteLine("\t_______|");
                                gameOver = true;
                                Console.WriteLine("Zgadujący przegrali!");
                            }
                        }
                    }
                }
            }
        }
    }
}