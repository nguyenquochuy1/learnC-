// See https://aka.ms/new-console-template for more information
Console.WriteLine("Tìm số chẵn !!!!");
List<int> numbers = [1, 2, 3, 4, 5, 6, 7];
var soChanNumbers = numbers.Where(x => x % 2 == 0).ToList();

soChanNumbers.ForEach(x => System.Console.WriteLine("Các số chẵn là : " + x));




