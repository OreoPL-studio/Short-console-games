Console.WriteLine("Witaj w grze w wojnę");
List<string> karty = new List<string>();
List<string> karty_nr1 = new List<string>();
List<string> karty_nr2 = new List<string>();

string kartaWRuchu_nr1;
string kartaWRuchu_nr2;
int pointCounter_nr1 = 0;
int pointCounter_nr2 = 0;
bool gameOver = false;

wszystkie_karty();
rozdanie_kart();

//while (gameOver == false)
//{
    kartaWRuchu_nr1 = ruch_Gracza_nr1();
    kartaWRuchu_nr2 = ruch_Gracza_nr2();
    //punkty(kartaWRuchu_nr1, kartaWRuchu_nr2);


//}


void rozdanie_kart()
{
    bool isEmpty = karty.Any();
    while (isEmpty)
    {
        var random1 = new Random();
        int index1 = random1.Next(karty.Count());

        if (karty.Count() > 0 && index1 < karty.Count())
        { 
            karty_nr1.Add(karty[index1]);
            karty.RemoveAt(index1);
        }

        var random2 = new Random();
        int index2 = random2.Next(karty.Count());

        if (karty.Count() > 0 && index2 < karty.Count())
        {
            karty_nr2.Add(karty[index2]);
            karty.RemoveAt(index2);
        }

        if (karty.Count == 0)
        {
            break;
        }
    }
}

string ruch_Gracza_nr1()
{
    Console.WriteLine("Ruch gracza numer 1");
    var randomMove = new Random();
    int index = randomMove.Next(karty_nr1.Count());
    string numer = "";
    if(karty_nr1.Count() > 0 && index < karty_nr1.Count())
    {
        numer = karty_nr1[index];
    }
    return numer;
}

string ruch_Gracza_nr2()
{
    Console.WriteLine("Ruch gracza numer 2");
    var randomMove = new Random();
    int index = randomMove.Next(karty_nr1.Count());
    string numer = "";
    if (karty_nr2.Count() > 0 && index < karty_nr2.Count())
    {
        numer = karty_nr2[index];
    }
    return numer;
}

void wszystkie_karty()
{
    for (int j = 0; j < 4; j++)
    {
        for (int i = 2; i < 11; i++)
        {
            karty.Add(i.ToString());
        }
    }

    for (int i = 0; i < 4; i++)
    {
        karty.Add("As");
        karty.Add("Król");
        karty.Add("Dama");
        karty.Add("Jupek");
    }
}

//int punkty(string karta_1)
//{
//    int punkty;

//    switch(karta_1)
//    {
//        case "2":
//        punkty = 1;
//        break;
        
//        case "3":
//        punkty = 2;
//        break;

//        case "4":
//        punkty = 3;
//        break;

//        case "5":
//        punkty = 4;
//        break;

//        case "6":
//        punkty = 5;
//        break;

//        case "7":
//        punkty = 6;
//        break;

//        case "8":
//        punkty = 7;
//        break;

//        case "9":
//        punkty = 8;
//        break;

//        case "10":
//        punkty = 9;
//        break;

//        case "Jupek":
//        punkty = 10;
//        break;

//        case "Dama":
//        punkty = 8;
//        break;

//        case "Król":
//        punkty = 8;
//        break;

//        case "As":
//        punkty = 8;
//        break;
//    }
//}