using System;
class Game
{
    public static void Main(string[] args)
    {
        Random random=new Random();
        Console.Write("Enter Rock or Paper or Scissor : ");
        string Player=Console.ReadLine();
        int ran=random.Next(1,4);
        string computer;
        if(ran==1)
        {
            computer="Rock";
        }
        else if(ran==2)
        {
            computer="Paper";
        }
        else
        {
            computer="Scissor";
        }
        Console.Write("Computer Choice : ");
        Console.WriteLine(computer);
        if(Player==computer)
        {
            Console.WriteLine("Result : Draw");
        }
        else if(Player=="Rock"&&computer=="Paper")
        {
            Console.WriteLine("Result : Computer Won");
        }
        else if(Player=="Rock"&&computer=="Scissor")
        {
            Console.WriteLine("Result : You Won");
        }
        else if(Player=="Paper"&&computer=="Scissor")
        {
            Console.WriteLine("Result : Computer Won");
        }
        else if(Player=="Paper"&&computer=="Rock")
        {
            Console.WriteLine("Result : You Won");
        }
        else if(Player=="Scissor"&&computer=="Rock")
        {
            Console.WriteLine("Result : Computer Won");
        }
        else if(Player=="Scissor"&&computer=="Paper")
        {
            Console.WriteLine("Result : You Won");
        }
        
    }
}