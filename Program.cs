Console.WriteLine("\t \t \t \t \t Hello, welcome to my Dice game in c#");
Random rnd = new Random();
int oppchoice;
Console.WriteLine("Play ");
Console.WriteLine("1.Vs computer ");
Console.WriteLine("2.1 Vs 1 ");
Console.Write("............");
Thread.Sleep(2000);
oppchoice = Convert.ToInt32(Console.ReadLine()); switch (oppchoice)
{
    case 1:
        Console.WriteLine("choose level: \n 1->Easy \n 2->Normal \n 3->hard");
        var levelchoice = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Press R or r to roll");
        Console.ReadKey(true);
        Thread.Sleep(2000);
        Console.Clear();
        if (levelchoice == 1)
        {
            var playerchoice = rnd.Next(7);
            var computerchoice = rnd.Next(1, 3);
            Console.WriteLine($"you rolled {playerchoice} \n");
            Thread.Sleep(4000);
            Console.WriteLine($"Computer rolled {computerchoice} \n");
            Thread.Sleep(4000);
            Console.Clear();
            if (playerchoice > computerchoice)
                Console.WriteLine("You won");
            else if (playerchoice == computerchoice)
                Console.WriteLine("oops, looks like we have a tie");
            else
                Console.WriteLine("Computer Won");
        }
        else if (levelchoice == 2)
        {
            var playerchoice = rnd.Next(7);
            var computerchoice = rnd.Next(7);
            Console.WriteLine($"you rolled {playerchoice} \n");
            Console.WriteLine($"Computer rolled {computerchoice} \n");
            if (playerchoice > computerchoice)
                Console.WriteLine("You won");
            else if (playerchoice == computerchoice)
                Console.WriteLine("oops, looks like we have a tie");
            else
                Console.WriteLine("Computer Won");
        }
        else if (levelchoice == 3)
        {
            var playerchoice = rnd.Next(7);
            var computerchoice = rnd.Next(5, 7);
            Console.WriteLine($"you rolled {playerchoice} \n");
            Console.WriteLine($"Computer rolled {computerchoice} \n");
            if (playerchoice > computerchoice)
                Console.WriteLine("You won");
            else if (playerchoice == computerchoice)
                Console.WriteLine("oops, looks like we have a tie");
            else
                Console.WriteLine("Computer Won");
        }

        break;
    case 2:
        Thread.Sleep(3000);
        Console.Clear();
        Console.WriteLine("This is turn of first player, please press R or r to roll");
        Console.ReadKey(true);
        var player1_roll = rnd.Next(1, 7);
        Thread.Sleep(2000);
        Console.Clear();
        Console.WriteLine("Now, it's turn of the second player, press r or R to roll");
        Console.ReadKey(true);
        var player2_roll = rnd.Next(1, 7);
        Thread.Sleep(2000);
        Console.Clear();
        Console.WriteLine($"player 1 rolls {player1_roll}");
        Console.WriteLine($"player 2 rolls {player2_roll}");
        Thread.Sleep(4000);
        Console.Clear();
        if (player1_roll > player2_roll)
            Console.WriteLine("player 1 wins");
        else if (player1_roll == player2_roll)
            Console.WriteLine("oh, looks like we have a tie");
        else
            Console.WriteLine("Player 2 wins");
        break;
}
Console.WriteLine("Now It's over, thanks for trying my game / Abdelrahman Sherif");
Thread.Sleep(10000);
Console.Clear();