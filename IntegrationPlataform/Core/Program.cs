// See https://aka.ms/new-console-template for more information
using Core.Csv;
using Core.Txt;

Console.WriteLine("Hello, World!");

CsvImporter csvImporter = new CsvImporter();

csvImporter.Import();