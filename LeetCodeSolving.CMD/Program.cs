// For some tests

using LeetCodeSolving.Easy;

var words = new string[] { "a", "aa", "aaa", "a" };
var minLenghtOfWord = words.Min(w => w.Length);

Console.WriteLine(minLenghtOfWord);
