﻿// See https://aka.ms/new-console-template for more information

/*
Console.WriteLine("Hello, World!");
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Generating invoices for customer \"ABC Corp\" ...\n");
Console.WriteLine("Invoice: 1021\t\tComplete!");
Console.WriteLine("Invoice: 1022\t\tComplete!");
Console.WriteLine("\nOutput Directory: \t");
Console.Write(@"c:\Invoices"); 
//Console.WriteLine(@" c:\source\repos (this is where your code goes)"); // Kon'nichiwa world
Console.WriteLine("\u3053\u3093\u306B\u3061\u306F World"); // Estudar mais sobre caracteres Unicode.

//To generate Japanese invoices:
//Nihon no sikyu-sho o seisei suru ni wa
Console.Write("\n\n\u65e5\u672c\u306e\u8acb\u6c42\u66f8\u3092\u751f\u6210\u3059\u308b\u306f\uff1a\n\t");
Console.WriteLine(@"c:\invoices\app.exe -j");
*/

// ----------------- >>>>> Concatenação de cadeias de caracteres <<<<<< --------------------------------- \\

//string firstName = "Bob";
//string greeting = "Hello";
//string message = greeting + " " + firstName + "!";
//Console.WriteLine(message);

//string firstName = "Bob";
//string greeting = "Hello";
//Console.WriteLine(greeting + " " + firstName + "!");

// ------------------------ >>>>> Interpolação de cadeia de caracteres <<<<<< --------------------------------- \\

// --- 1
//string firstName = "Bob";
//string message = $"Hello {firstName}!";
//Console.WriteLine(message);
// --- 2
//string firstName = "Bob";
//string greeting = "Hello";
//string message = $"{greeting} {firstName}!";
//Console.WriteLine(message);
// --- 3
//string firstName = "Bob";
//string greeting = "Hello"; 
//Console.WriteLine($"{greeting} {firstName}!");

// --- 4
//string projectName = "First-Project";
//Console.WriteLine($@"c:\Output\{projectName}\Data");

// -------------------------- >>>>> Desafio <<<<<< --------------------------------- \\


//string projectName = "ACME";
//string englishLocation = "View english output:\n";


//Console.WriteLine($@"{englishLocation}
//    c:\Exercise\{projectName}\data.txt");

//Console.WriteLine($@"{russianMessage}
//    c:\Exercise\{projectName}\data.txt");

//string projectName = "ACME";
//string englishLocation = $@"c:\Exercise\{projectName}\data.txt";
//Console.WriteLine($"view English output: \n\t\t{englishLocation}\n");

//string russianMessage = "\u041f\u043e\u0441\u043e\u0442\u0440\u0435\u0442\u044c \u0440\n";
//string russianLocation = $@"c:\Exercise\{projectName}\ru\RU\data.txt";
//Console.WriteLine($"{russianMessage}:\n\t\t{russianLocation}\n");



//string primeiroNome = "Bob";
//string mensagem = "Olá " + primeiroNome;
//Console.WriteLine(mensagem);

string primeiroNome = "Matheus";
string cumprimento = "Olà";
string mensagem = $"{cumprimento}{primeiroNome}!";
Console.WriteLine(mensagem);

string nomeDoProjeto = "Primeiro projeto";
Console.WriteLine($@"C:Output\{nomeDoProjeto}\Data");