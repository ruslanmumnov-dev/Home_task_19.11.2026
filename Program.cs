System.Console.WriteLine($"TAsk-1   ");
// TAsk 1


List <int> numbers = new List<int>{1,2,3,4,5,6,7,8,9,};
int sum=0;
foreach (var item in numbers)
{
    sum+=item;
}
System.Console.WriteLine($"Sum: {sum}");

System.Console.WriteLine($"TAsk-2   ");
// Task 2

List <string> texts = new List<string>{"Hello","word","!"};
 foreach (var item in texts)
{
    System.Console.Write($"{item} ");
}
System.Console.WriteLine();
System.Console.WriteLine($"TAsk-3   ");
// Task 3


System.Console.WriteLine($"TAsk-4   ");
// Task 4 
 List <double > number = new List<double>{3.5, 2.7, 6.9, 1.2};
 double sm=0;
foreach (var item in number)
{
    sm+=item;
}
double everage = sm / number.Count;
System.Console.WriteLine($"Everage of double numbers: {everage}");


System.Console.WriteLine($"TAsk-5   ");
// TAsk 5
List<int> numberss = new List<int>{ 1, 2, 3, 4, 5 };
foreach(var n in numberss)
{
    if (n % 2 == 0)
    {
        System.Console.Write($"The filtered numbers are: {n}");
    }
}
System.Console.WriteLine();

System.Console.WriteLine($"TAsk-6   ");
// Task 6
List <bool> bools = new List<bool>();
System.Console.Write("Are all the values in the list true?");
foreach(var n in bools)
{
    if (n == true)
    {
        System.Console.Write(n);
    }
}
// Task 7

List<string> fruits = new List<string>{ "apple", "banana", "cherry" };


Console.WriteLine("Is the element found? " + );
