using System;
string firstFriend = "Alice";
string secondFriend = "Sage";
Console.WriteLine($"My friends are {firstFriend} and {secondFriend}.");
System.Console.WriteLine($"the name {firstFriend} has {firstFriend.Length} letters.");
System.Console.WriteLine($"the name {secondFriend} has {secondFriend.Length} letters.");

string greeting="       Hello World!     ";
System.Console.WriteLine($"[{greeting}]");
string trimmedGreeting = greeting.Trim();
System.Console.WriteLine($"[{trimmedGreeting}]");
trimmedGreeting = greeting.TrimStart();
System.Console.WriteLine($"[{trimmedGreeting}]");
trimmedGreeting = greeting.TrimEnd();
System.Console.WriteLine($"[{trimmedGreeting}]");

string sayHello = "Hello World!";
System.Console.WriteLine(sayHello);
sayHello=sayHello.Replace("Hello", "Greetings");
System.Console.WriteLine(sayHello);

System.Console.WriteLine(sayHello.ToUpper());
System.Console.WriteLine(sayHello.ToLower());

string songLyrics = "The rain in Spain stays mainly in the plain.";
System.Console.WriteLine(songLyrics.Contains("rain"));
System.Console.WriteLine(songLyrics.Contains("snow"));
System.Console.WriteLine(songLyrics.StartsWith("The rain"));
System.Console.WriteLine(songLyrics.EndsWith("plain."));