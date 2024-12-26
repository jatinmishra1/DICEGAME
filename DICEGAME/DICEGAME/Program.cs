var random =new Random(12);
var dice = new Dice(random,6);
var guessignGame=new GuessingGame(dice);

GameResult gameResult=guessignGame.Play();

for(int i = 0; i < 3; i++)
{
    Console.WriteLine(random.Next(1,11));
}

Console.WriteLine("helllo");

public class GuessingGame
{
    private readonly Dice _dice;
    private const int InitialTries = 3;

    public GuessingGame(Dice dice)
    {
        _dice = dice;
    }
    public GameResult Play()
    {
        var diceRollResult = _dice.Roll();
        Console.WriteLine($"Dice rolled guess what it shows ,in {InitialTries} tries");
        var triesLeft=InitialTries;
        while (triesLeft > 0)
        {
            var guess = ConsoleReader.ReadInteger("Guess The Number:");
            if (guess == diceRollResult) {
                return GameResult.Victory;
            }
            Console.WriteLine("wrong Number");
            --triesLeft;
        }
        return GameResult.Loss;
    }
   
};
public enum GameResult
{
    Victory,
    Loss

}

public static class ConsoleReader 
{
    public static int ReadInteger(string message)
    {
        int result;
        do
        {
            Console.WriteLine(message);
        } while (!int.TryParse(Console.ReadLine(), out result));
        return result;
    }
};


public class Dice
{
    private readonly Random _random;
    private readonly int _sidesCount;

    public Dice(Random random, int sidesCount)
    {
        _sidesCount = sidesCount;
        _random = random;

    }

    public int Roll() => _random.Next(1,_sidesCount+1);  
    
}