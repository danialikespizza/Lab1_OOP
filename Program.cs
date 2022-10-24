using System;
using Lab1_OOP;

class Program
{
    public static void Main(string[] args)
    {
        GameAccount Zheka = new GameAccount("Zheka");
        GameAccount Ihor = new GameAccount("Ihor");


        Random rd = new Random();

        Game game1 = new Game(Ihor, Zheka, rd.Next(1, 35));
        game1.Result(game1);
        Game game2 = new Game(Ihor, Zheka, rd.Next(1, 35));
        game2.Result(game2);
        Game game3 = new Game(Ihor, Zheka, rd.Next(1, 35));
        game3.Result(game3);
        Game game4 = new Game(Ihor, Zheka, rd.Next(1, 35));
        game4.Result(game4);

        //Wrong raiting for demonstrating exception, change to positive number and everything gonna be fine:)
        Game game5 = new Game(Ihor, Zheka, rd.Next(1, 35));
        game5.Result(game5);

        Zheka.GetStats();
        Ihor.GetStats();

        Console.ReadLine();


    }

}