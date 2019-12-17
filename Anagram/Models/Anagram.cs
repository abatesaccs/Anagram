using System;
using System.Collections.Generic;

namespace AnagramCheck.Models
{
  public class Anagram
  {
      public List<string> CheckWords { get; set; }
      public List<string> Anagrams { get; set; }
      public string Base { get; set; }
      public int MatchSize { get; set; }

      public Anagram(string baseWord)
      {
        CheckWords = new List<string>();
        Anagrams = new List<string>();
        Base = baseWord;
        MatchSize = 0;
      }

      public void AddWord(string word)
      {
        CheckWords.Add(word);
      }

      public List<string> Check()
      {
        while(CheckWords.Count >= 1)
        {
          CheckWord(CheckWords[0], CheckWords[0].Length);
          if(MatchSize == CheckWords[0].Length)
          {
            Anagrams.Add(CheckWords[0]);
          }
          CheckWords.RemoveAt(0);
          MatchSize = 0;
        }
        if(Anagrams.Count > 0)
        {
          return Anagrams;
        }
        Anagrams.Add("no anagrams");
        return Anagrams;
      }

      private void CheckWord(string word, int size)
      {
        if(size == 0)
        {
          return;
        } else {
          size -= 1;
          for(int i = 0; i < Base.Length; i++)
          {
            if(word[size] == Base[i])
            { 
              MatchSize += 1;
              break;
            }
          }
          CheckWord(word, size);
        }
      }
  }
}