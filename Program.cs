using System;
using System.Runtime.InteropServices;
using static System.Console;

public static class Program
{
  public static void Main(string[] args) 
  {
        string message = "Dotnet-bot: Welcome to using .NET Core!";
          
        if (args.Length > 0) 
        {
          message = String.Join(" ",args);
        }

        WriteLine(GetBot(message));
        WriteLine("**Environment**");
        WriteLine($"Platform: .NET Core 1.1");
        WriteLine($"OS: {RuntimeInformation.OSDescription}");
        WriteLine();
  }

  public static string GetBot(string message) 
  {
          string bot = $"\n        {message}";
          bot += @"
.NET Core with Docker

        .
        :
     ___:____     |'\/'|
   ,'        `.    \  /
   |  O        \___/  |
 ~^~^~^~^~^~^~^~^~^~^~^~^~
";
  return bot;
  }
}
