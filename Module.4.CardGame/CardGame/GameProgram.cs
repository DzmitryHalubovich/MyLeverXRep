using Module4;
using ShuffledDeckOfCards;

Console.Write("Set deck size: ");
int deckSize = int.Parse(Console.ReadLine());
while (deckSize<=0 || deckSize%2 != 0 || deckSize>20)
{
    Console.Write("Attention! The size of the deck must be greater than 0 and be even (max size = 20)\nSet deck size: ");
    deckSize = int.Parse(Console.ReadLine());
}

FirstGame game = new FirstGame(deckSize);

game.CheckBothPlayersPiles();
Console.WriteLine("\n" + game.MainGame());



