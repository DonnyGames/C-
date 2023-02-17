// See https://aka.ms/new-console-template for more information


//verander algemene info

using System;



namespace My_Program {
    class Program {
        static void Main(string[] args)
        {
Console.WriteLine("Welcome to my minigame, Type Play to start");
var playresponse  = Console.ReadLine();
if(playresponse == "Play"){
    Console.WriteLine("What is your username");
} else {
    Console.WriteLine("start?, what is your name?");
  
}

 var name = Console.ReadLine();

 if(name == "Marc Erso"){
   Console.WriteLine("Marc tief de fuck up op pls en waag het je age in te vullen als je moeder");
 }
 
  else if(name == "Jason"){
   Console.WriteLine("Hallo meneer java :)))");
 }

   else if(name == "donny"){
      Console.WriteLine("eyyy pikkie. Baron Erso hier. Haal nou is mijn goud kut! Want Goud verzoet...\n inderdaad de arbeid");
   }
 else{
   Console.WriteLine("Hello " + name + " I am the big C# god (reply wow or boring)");
 }
 var reply  = Console.ReadLine();
 if(reply == "wow"){
    Console.WriteLine("I know its amazing isn't it, C# is amazing.\n may i know your age?");
 } else if(reply == "boring"){
    Console.WriteLine("C# ISN'T BORING " + name + "\nBut now what is your age?");
 } else {
    Console.WriteLine("May i know ur age good sir?");
 }
 var age =Console.ReadLine();

 Console.WriteLine("Okay so " + age + "... \nThanks for your personal information BYE ");
 var response = Console.ReadLine();

 
 if(response == "steals back"){
    Console.WriteLine("NOO MY ITEMS, I have nothing now except u. \nMaybe we can be friends? (good ending)");
 }



 else {
    Console.WriteLine("Helaas pindakaas(normal ending)");
 }

           Console.ReadKey(); 
        }
    }
}