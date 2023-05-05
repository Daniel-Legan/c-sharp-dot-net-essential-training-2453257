// See https://aka.ms/new-console-template for more information

/*
auto-added with .NET 6.0

using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
*/

Console.WriteLine("Hello, World!");

string response;
Console.WriteLine("What's your name?");
response = Console.ReadLine();

Console.WriteLine($"Enjoy the course, {response}!");

OperatingSystem thisOS = Environment.OSVersion;
Console.WriteLine(thisOS.Platform);
Console.WriteLine(thisOS.VersionString);