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
Console.WriteLine(shuffle.Count()); //ОТЛАДКА
foreach (int i in shuffle) { Console.Write(i+ " "); }

List<int> player1 = shuffle.GetRange(0,20);
List<int> player2 = shuffle.GetRange(20, 20);
Console.WriteLine("\n////////");
foreach (int i in player1) { Console.Write(i+ " "); }
Console.WriteLine();
foreach (int i in player2) { Console.Write(i+ " "); }


Console.WriteLine("\nСумма всех карт первого игрока " + player1.Sum(x => x));
Console.WriteLine("Сумма всех карт второго игрока " + player2.Sum(x => x));