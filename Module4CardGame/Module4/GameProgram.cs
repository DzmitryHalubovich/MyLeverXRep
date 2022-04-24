using Module4;

Random rand = new Random();

MyList<int> shuffle = new MyList<int>();



for (int i = 0; i < 4; i++) //Инициализируем массив (Я для себя пишу комменты, по этому на русском)
{
    for (int j = 1; j < 11; j++)
    {
        shuffle.Add(j);
    }
}


//shuffle.Initialization();
shuffle.Shuffle(); //перемешиваем
//Console.WriteLine(shuffle.Count()); //ОТЛАДКА
//foreach (int i in shuffle) { Console.Write(i+ " "); }

List<int> player1 = shuffle.GetRange(0,20);
List<int> player2 = shuffle.GetRange(20, 20);
List<int> discardPile1 = new List<int>(); 
List<int> discardPile2 = new List<int>();

int ScoreOfPlayer1 = 0;
int ScoreOfPlayer2 = 0;

//Console.WriteLine("\n////////");
//foreach (int i in player1) { Console.Write(i+ " "); }
//Console.WriteLine();
//foreach (int i in player2) { Console.Write(i+ " "); }

//Play
while (player1.Count()>0 || player2.Count()>0)
{
    Console.ReadKey();
    //for (int i = 0; player1.Count > 0 || player2.Count > 0; i++)
    //{
    //    ScoreOfPlayer1 += player1[i];
    //    ScoreOfPlayer2 += player2[i];
    //    discardPile1.Add(player1[i]);
    //    discardPile2.Add(player2[i]);
    //}

    if (player1.Last()>player2.Last())
    {
        discardPile1.Add(player2.Last());
        discardPile1.Add(player1.Last());
        //player1.Insert(0,player2.Last());
        //player1.Add(player2.First());
        player1.RemoveAt(player2.Last());
        player2.RemoveAt(player2.Last());
        Console.WriteLine($"Player 1 ({player1.Count} cards): {player1.Last()}");
        Console.WriteLine($"Player 2 ({player2.Count} cards): {player2.Last()}");
        Console.WriteLine("Player 1 wins this round\n");
    }
    if (player1.Last()<player2.Last())
    {
        discardPile2.Add(player1.Last());
        discardPile2.Add(player2.Last());
        //player2.Insert(0,player1.Last());
        //player1.RemoveAt(player1.Last());
        player1.RemoveAt(player2.Last());
        player2.RemoveAt(player2.Last());
        Console.WriteLine($"Player 1 ({player1.Count + discardPile1.Count} cards): {player1.Last()}");
        Console.WriteLine($"Player 2 ({player2.Count+discardPile2.Count} cards): {player2.Last()}");
        Console.WriteLine("Player 2 wins this round");
    }
    if (player1.Last()==player2.Last())
    {
        //discardPile1.Add(player1.Last());
        //discardPile2.Add(player2.Last());
        player1.RemoveAt(player1.Last());
        player2.RemoveAt(player2.Last());
    }
}
if (player1.Count()>0)
{
    Console.WriteLine("Player 1 wins the game!");
}
else
{
    Console.WriteLine("Player 2 wins the game!");
}

//Console.WriteLine("\nСумма всех карт первого игрока " + player1.Sum(x => x));
//Console.WriteLine("Сумма всех карт второго игрока " + player2.Sum(x => x));