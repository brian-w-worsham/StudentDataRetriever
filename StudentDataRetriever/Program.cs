using System;
using System.IO;

// read text from StudentNames.txt and display it on the console

// create StreamReader object
// store the relative path to the file in a string variable   
string filePath = @"C:\Users\Brian_Worsham\source\StudentDataRetriever\StudentDataRetriever\StudentNames.txt";
string[] lines = File.ReadAllLines(filePath);
foreach (string line in lines)
{
    Console.WriteLine(line);
}

