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
    Console.WriteLine("U NEED TO START DUMBASS, Whatever. What is your name?");
  
}

 var name = Console.ReadLine();
 if(name == "marc erso"){
   Console.WriteLine("ga weg marc wat is je mening van het programma (wow or boring)");
 }
 else if(name == "Marc Erso"){
   Console.WriteLine("Marc tief de fuck up op pls en waag het je age in te vullen als je moeder");
 }
  else if(name == "Marc"){
   Console.WriteLine("hoi(cool)");
 }
  else if(name == "Jason"){
   Console.WriteLine("Hallo meneer java :)))");
 }
   else if(name == "jason"){
   Console.WriteLine("Hallo meneer java :)))");
 }
   else if(name == "donny"){
      Console.WriteLine("eyyy pikkie. Baron Erso hier. Haal nou is mijn goud kut! Want Goud verzoet...\n inderdaad de arbeid");
   }
 else{
   Console.WriteLine("Hello " + name + " I am the big C# god (reply wow or boring)");
 }
 var godreply  = Console.ReadLine();
 if(godreply == "wow"){
    Console.WriteLine("I know its amazing isn't it, C# is amazing.\n may i know your age?");
 } else if(godreply == "boring"){
    Console.WriteLine("C# ISN'T BORING U STUPID " + name + "\nBut now what is your age?");
 } else {
    Console.WriteLine("May i know ur age good sir?");
 }
 var age =Console.ReadLine();

 Console.WriteLine("Okay so " + age + "... \nThanks for your personal information BYE BITCH");
 var response = Console.ReadLine();
 if(response == "WAIT"){
    Console.WriteLine("NO BYE BYE BISH HAHAHA (bad ending)");
 }
 else if (response == "cum"){
    Console.WriteLine("NOOO THE CUM (cum ending)");
    
 }
 else if (response == "fortnite"){
    Console.WriteLine("Wanna play like fr fr? \n YAAAAAASS. (fortnite ending)");
 } else if(response == "steals back"){
    Console.WriteLine("NOO MY ITEMS U FUCKER I have nothing now except u. \nMaybe we can be friends? (good ending)");
 }
 else if(response == "amongus"){
   Console.WriteLine("NOOOO NOT THE AMONGUSSSS");
 }
else if(response == "je moeder"){
   Console.WriteLine("No u (je moeder ending)");
 }
 else if(response == "javascript"){
   Console.WriteLine("Is dat zijn kop \nDaar bij die deurknop \nIs dat nou Jason van Schaick");
 }
 else {
    Console.WriteLine("Helaas pindakaas(normal ending)");
 }

           Console.ReadKey(); 
        }
    }
}