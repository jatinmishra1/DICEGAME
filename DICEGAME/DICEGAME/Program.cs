using DICEGAME.Game;

var random =new Random(12);
var dice = new Dice(random,6);
var guessignGame=new GuessingGame(dice);

GameResult gameResult=guessignGame.Play();

guessignGame.PrintResult(gameResult);



for(int i = 0; i < 3; i++)
{
    Console.WriteLine(random.Next(1,11));
}

Console.WriteLine("helllo");
