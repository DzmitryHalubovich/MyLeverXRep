using Module4;

Random rand = new Random();

MyList<int> shuffle = new MyList<int>();



for (int i = 0; i < 4; i++) 
{
    for (int j = 1; j < 11; j++)
    {
        shuffle.Add(j);
    }
}

shuffle.Shuffle(); //перемешиваем

List<int> player1 = shuffle.GetRange(0,5); // GetRange(0,20);
List<int> player2 = shuffle.GetRange(5, 5); // GetRange(20, 20);
MyList<int> discardPile1 = new MyList<int>();
MyList<int> discardPile2 = new MyList<int>();
List<int> tempPile = new List<int>();

//foreach (int i in player1) { Console.Write(i + " "); }
//Console.WriteLine();
//foreach (int i in player2) { Console.Write(i + " "); }


while (true) 
{
    int card1 = 0;
    int card2 = 0;

    foreach (int i in player1) { Console.Write(i + " "); } //For debug
    Console.WriteLine();
    foreach (int i in player2) { Console.Write(i + " "); } //For debug

    while (player1.Count>0 && player2.Count > 0)
    {
        //Console.ReadKey();
        card1 = player1.Last();
        card2 = player2.Last();
        Console.WriteLine($"\nPlayer 1 ({player1.Count} + {discardPile1.Count} res cards): {card1}");
        Console.WriteLine($"Player 2 ({player2.Count} + {discardPile2.Count} res cards): {card2}");
        Thread.Sleep(400);

        if (card1 == card2)
        {
            tempPile.Add(card1);
            tempPile.Add(card2);
            player1.RemoveAt(player1.Count-1);
            player2.RemoveAt(player2.Count-1);
            Console.WriteLine("No winner in this round");
        }
        else if (card1>card2)
        {
            discardPile1.Add(card2);
            discardPile1.Add(card1);
            player1.RemoveAt(player1.Count-1);
            player2.RemoveAt(player2.Count-1);
            if (tempPile.Count()>0)
            {
                discardPile1.AddRange(tempPile);
                tempPile.Clear();
            }
            Console.WriteLine("Player 1 wins this round");
        }
        else if (card1<card2)
        {
            discardPile2.Add(card2);
            discardPile2.Add(card1);
            player1.RemoveAt(player1.Count-1);
            player2.RemoveAt(player2.Count-1);
            if (tempPile.Count()>0)
            {
                discardPile2.AddRange(tempPile);
                tempPile.Clear();
            }
            Console.WriteLine("Player 2 wins this round");
        }
    }

    if (player1.Count == 0 && discardPile1.Count ==0)
    {
        Console.WriteLine("Player 2 wins this game!");
        break;
    }
    else if (player2.Count == 0 && discardPile2.Count ==0)
    {
        Console.WriteLine("Player 1 wins this game!");
        break;
    }
    else if (player1.Count==0)
    {
        discardPile1.Shuffle();
        player1.AddRange(discardPile1);
        discardPile1.Clear();
    }
    else if (player2.Count==0)
    {
        discardPile2.Shuffle();
        player2.AddRange(discardPile2);
        discardPile2.Clear();
    }
} 

