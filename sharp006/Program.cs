﻿int a = 2;
int b = 5;
int c = 9 ;
int d = 11;
int e = 3;

int max = a;

if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;
if (d > max) max = d;
if (e > max) max = e;

Console.Write("max = ");
Console.WriteLine(max);
