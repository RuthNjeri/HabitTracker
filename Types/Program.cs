﻿// See https://aka.ms/new-console-template for more information
using Types;

var p1 = new Mutablepoint(1, 2);
var p2 = p1;
p2.Y = 200;

Console.WriteLine($"{nameof(p1)} after {nameof(p2)} is modified: {p1}");
Console.WriteLine($"{nameof(p2)}: {p2}");

MutateAndDisplay(p2);
Console.WriteLine($"{nameof(p2)} after passing to a method: {p2}");


static void MutateAndDisplay(Mutablepoint p)
{
	p.X = 100;
	Console.WriteLine($"Point mutated in a method: {p}");
}