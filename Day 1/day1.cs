using System;
using System.IO;

int a = 5;
a += 9;
Console.WriteLine(a);
// Output: 14

string story = "Start. ";
story += "End.";
Console.WriteLine(story);
// Output: Start. End.

Action<int> printer = (int s) => Console.WriteLine(s);
printer += (int s) => Console.WriteLine(2 * s);
printer(3);
// Output:
// 3
// 6