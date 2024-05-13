using System;
namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            //khai báo ba biến number1, number2 và temp
            int number1 = 10, number2 = 20, temp = 0;
            //hiển thị hai số trước khi hoán đổi
            Console.WriteLine($"Truoc khi hoan doi: number1= {number1}, number2 = {number2}");
            temp = number1; //temp = 10
            number1 = number2; //number1 = 20      
            number2 = temp; //number2 = 10    
            Console.WriteLine($"Sau khi hoan doi: number1= {number1}, number2 = {number2}");
            Console.Read;
        }
    }
}