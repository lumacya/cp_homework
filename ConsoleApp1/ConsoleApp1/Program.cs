using System;
using System.Collections.Generic;

class Program
{
    static List<Player> players = new List<Player>();
    static List<GameHistory> history = new List<GameHistory>();

    static void Main(string[] args)
    {
        bool exit = false;
        while (!exit)
        {
            Console.WriteLine("\n1. New Game");
            Console.WriteLine("2. Show Player Games");
            Console.WriteLine("3. Show Leaderboard");
            Console.WriteLine("4. Exit");
            Console.Write("Choose: ");

            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    StartGame();
                    break;
                case "2":
                    ShowPlayerGames();
                    break;
                case "3":
                    ShowLeaderboard();
                    break;
                case "4":
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Wrong choice!");
                    break;
            }
        }
    }

    static void StartGame()
    {
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();

        Player player = null;
        foreach (Player p in players)
        {
            if (p.Name == name)
            {
                player = p;
                break;
            }
        }

        if (player == null)
        {
            player = new Player(name);
            players.Add(player);
        }

        Game game = new Game();
        game.StartGame(player);
        history.Add(new GameHistory(name, game.Result, game.Points));
    }

    static void ShowPlayerGames()
    {
        Console.Write("Enter player name: ");
        string name = Console.ReadLine();

        bool found = false;
        foreach (GameHistory record in history)
        {
            if (record.PlayerName == name)
            {
                found = true;
                Console.WriteLine($"{record.PlayerName} | {record.Result} | Points: {record.Points} | Date: {record.Date}");
            }
        }

        if (!found)
        {
            Console.WriteLine("No games found!");
        }
    }

    static void ShowLeaderboard()
    {
        players.Sort((p1, p2) => p2.TotalPoints.CompareTo(p1.TotalPoints));

        Console.WriteLine("\nLeaderboard:");
        Console.WriteLine("Name\t\tWins\tLoses\tPoints");
        foreach (Player p in players)
        {
            Console.WriteLine($"{p.Name}\t\t{p.TotalWins}\t{p.TotalLoses}\t{p.TotalPoints}");
        }
    }
}

class Player
{
    public string Name;
    public int TotalWins;
    public int TotalLoses;
    public int TotalPoints;

    public Player(string name)
    {
        Name = name;
        TotalWins = 0;
        TotalLoses = 0;
        TotalPoints = 0;
    }
}

class Game
{
    private int secretNumber;
    private int attempts = 7;
    public string Result;
    public int Points;

    public Game()
    {
        Random rand = new Random();
        secretNumber = rand.Next(1, 101);
    }

    public void StartGame(Player player)
    {
        Console.WriteLine("\nTry to guess number between 1-100. You have 7 attempts!");

        while (attempts > 0)
        {
            Console.Write($"Attempt #{8 - attempts}: ");
            int guess = Convert.ToInt32(Console.ReadLine());

            if (guess == secretNumber)
            {
                Console.WriteLine("Correct! You win!");
                Points = attempts * 10;
                player.TotalPoints += Points;
                player.TotalWins++;
                Result = "WIN";
                return;
            }
            else if (guess < secretNumber)
            {
                Console.WriteLine("Too small!");
            }
            else
            {
                Console.WriteLine("Too big!");
            }

            attempts--;
        }

        Console.WriteLine("Game over! You lose!");
        Points = 15;
        player.TotalPoints = Math.Max(0, player.TotalPoints - Points);
        player.TotalLoses++;
        Result = "LOSE";
    }
}

class GameHistory
{
    public string PlayerName;
    public string Result;
    public int Points;
    public string Date;

    public GameHistory(string name, string result, int points)
    {
        PlayerName = name;
        Result = result;
        Points = points;
        Date = DateTime.Now.ToString("g");
    }
}