// See https://aka.ms/new-console-template for more information
using static Attributes.Program;

// Natural type
var parse = (string s) => int.Parse(s);

// Declared return type
var choose = object (bool b) => b ? 1 : "two"; // Func<bool, object>

// Attributes can be applied to lambda expressions
var printAuthor = [Author("Ran Bi")] () => Console.WriteLine("author");
