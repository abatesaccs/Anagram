using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AnagramCheck.Models;
using System.Collections.Generic;

namespace AnagramCheck.Tests
{
    [TestClass]
    public class AnagramTester
    {
        [TestMethod]
        public void Anagram_CheckAnagram_Conversation()
        {
            Anagram newAnagram = new Anagram("dave");
            newAnagram.AddWord("vade");
            newAnagram.AddWord("deva");
            List<string> results = newAnagram.Check();
            Assert.AreEqual("deva",results[1]);
        }
 
    }
}