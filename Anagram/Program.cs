using System;
using System.Collections.Generic;

namespace AnagramCheck.Models {
  public class Program {
    static void Main()
    {
    
      Console.WriteLine("Please enter a base word.");
      string UserInput = Console.ReadLine().ToLower();
      Anagram MyAnagram = new Anagram(UserInput);
      while(UserInput != "|")
      { 
        Console.WriteLine("\nPlease enter words to compare,\nor enter | to confirm all options\n");
        UserInput = Console.ReadLine().ToLower();
        if (UserInput == "|")
        {
          break;
        }
        else
        {
          MyAnagram.AddWord(UserInput);
        }
      }
      List<string> results = MyAnagram.Check();
      Console.WriteLine("Anagrams: ");
      foreach(string w in results)
      {
        Console.WriteLine(w);
      }
    }
  }
}