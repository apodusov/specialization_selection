// Написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше либо равна 3 символа.
// Примеры:
// ["hello", "2", "world', ":-)"] -> ["2", ":-)"]
// ["1234", "1567", "-2", "computer science"] -> ["-2"]
// ["Russia", "Denmark", "Kazan"] -> [ ]

string [] startingArray = new string[] {"hello", "5", "SPb", "Moscow"};
string[] resultArray = new string [0];

foreach (var item in startingArray)
{
    if (item.Length <= 3)
    {
    Array.Resize(ref resultArray, resultArray.Length + 1);
    resultArray [resultArray.Length-1] = item;
    }
}

Console.WriteLine($"[{String.Join("; ", resultArray)}]");


//string[] stringArray = {"hello", "2", "world", "!", "-65", "Kazan", "and", "computer science", ":)"};
