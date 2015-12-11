using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WordHive.Models
{
    public class Puzzle
    {
        public int PuzzleID { get; set; }
        public int Difficulty { get; set; }
        public int MinWordLength { get; set; }
        public int MinVowels { get; set; }
        public int MaxVowels { get; set; }
        public char[] Required { get; set; }
        public char[] Optional { get; set; }
        public char[] Inverse { get; set; }
        public char[] Forbidden { get; set; }
        public string[] Answers { get; set; }
    }
}