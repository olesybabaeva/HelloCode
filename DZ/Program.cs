//Задача 1
// using System;

// public class Answer {
//     static void CompareNumbers(int firstNumber, int secondNumber)
//     {
//         // Введите свое решение ниже
//         if (firstNumber < secondNumber)
//         {
//             Console.WriteLine("Первое число `"  +  firstNumber + "` меньше чем второе число `" + secondNumber + "`");
//         }
//         else if (firstNumber > secondNumber)
//         {
//             Console.WriteLine("Первое число `" +  firstNumber + "` больше чем второе число `" + secondNumber + "`");
//         }
//         else
//         {
//             Console.WriteLine("Введенные числа равны `" + firstNumber + "`");
//         }
//     }


//   // Не удаляйте и не меняйте метод Main! 
//     static public void Main(string[] args) {
//         int firstNumber, secondNumber;

//         if (args.Length >= 2) {
//             firstNumber = int.Parse(args[0]);
//             secondNumber = int.Parse(args[1]);
//         } else {
//            // Здесь вы можете поменять значения для отправки кода на Выполнение
//             firstNumber = 5;
//             secondNumber = 5;
//         }

//         // Не удаляйте строки ниже
//         CompareNumbers(firstNumber, secondNumber);
//     }
// }

// задача 1 - идеальное решение
// using System;

// public class Answer {
//     static void CompareNumbers(int firstNumber, int secondNumber)
//     {
//         if (firstNumber == secondNumber)
//         {
//             Console.WriteLine($"Введенные числа равны `{firstNumber}`");
//         }
//         if (firstNumber > secondNumber)
//         {
//             Console.WriteLine($"Первое число `{firstNumber}` больше чем второе число `{secondNumber}`");
//         }
//         if (firstNumber < secondNumber)
//         {
//             Console.WriteLine($"Первое число `{firstNumber}` меньше чем второе число `{secondNumber}`");
//         }
//     }

//     static public void Main(string[] args) {
//         int firstNumber, secondNumber;

//         if (args.Length >= 2) {
//             firstNumber = int.Parse(args[0]);
//             secondNumber = int.Parse(args[1]);
//         } else {
//             firstNumber = 5;
//             secondNumber = 5;
//         }

//         CompareNumbers(firstNumber, secondNumber);
//     }
// }

//Задача 2

// using System;

// public class Answer {
    
//   static int FindMax(int a, int b, int c)
//     {
//       // Введите свое решение ниже
//       int max = a;
//       if (b > max) max = b;
//       if (c > max) max = c;
//       return max;
//     }

//   // Не удаляйте и не меняйте метод Main! 
//   static public void Main(string[] args) {
//         int a, b, c;

//         if (args.Length >= 3) {
//            a = int.Parse(args[0]);
//            b = int.Parse(args[1]);
//            c = int.Parse(args[2]);
//         } else {
//            // Здесь вы можете поменять значения для отправки кода на Выполнение
//            a = 51;
//            b = 6;
//            c = 7;
//         }

//         // Не удаляйте строки ниже
//         int result = FindMax(a, b, c);
//         System.Console.WriteLine($"{result}");
//     }
// }

// задача 2- идеальное решениеusing System;

// public class Answer {
//     static int FindMax(int a, int b, int c)
//     {
//       int max = a;
//         if (max < b)
//         {
//             max = b;
//         }
//         if (max < c)
//         {
//             max = c;
//         }
//         return max;
//     }

//     static public void Main(string[] args) {
//         int a, b, c;

//         if (args.Length >= 3) {
//             a = int.Parse(args[0]);
//             b = int.Parse(args[1]);
//             c = int.Parse(args[2]);
//         } else {
//             a = 5;
//             b = 6;
//             c = 7;
//         }

//         int result = FindMax(a, b, c);
//         System.Console.WriteLine($"{result}");
//     }
// }

//задача 3

// using System;

// class Answer {
//     static void CheckIfEven(int number)
//     {
//       // Введите свое решение ниже
//       if (number % 2 == 0)
//       {
//       Console.WriteLine("Число `" + number + "` чётное");
//       }
//       else
//       {
//         Console.WriteLine("Число `" + number + "` нечётное");
//       }
//     }
  

//   // Не удаляйте и не меняйте метод Main! 
//     static public void Main(string[] args) {
//         int number;

//         if (args.Length >= 1) {
//             number = int.Parse(args[0]);
//         } else {
//            // Здесь вы можете поменять значения для отправки кода на Выполнение
//             number = 5;
//         }

//         // Не удаляйте строки ниже
//         CheckIfEven(number);
//     }
// }

// Задача 3 - идеальное решение 
// using System;

// class Answer {
//     static void CheckIfEven(int number)
//     {
//         if ((number % 2) == 0)
//         {
//             Console.WriteLine($"Число `{number}` чётное");
//         }
//         else
//         {
//             Console.WriteLine($"Число `{number}` нечётное");
//         }
//     }

//     static public void Main(string[] args) {
//         int number;

//         if (args.Length >= 1) {
//             number = int.Parse(args[0]);
//         } else {
//             number = 6;
//         }

//         CheckIfEven(number);
//     }
// }

//Задача 4

// using System;

// public class Answer {
//     static void PrintEvenNumbers(int number)
//     {
//       // Введите свое решение ниже
//       int index = 2;
//       Console.Write("number = " + number + " -> ");
//       while (index <= number)
//       {
//         Console.Write($"{index} \t");
//         index +=2;
//       }
//     }


//   // Не удаляйте и не меняйте метод Main! 
//     static public void Main(string[] args) {
//         int number;

//         if (args.Length >= 1) {
//             number = int.Parse(args[0]);
//         } else {
//            // Здесь вы можете поменять значения для отправки кода на Выполнение
//             number = 8;
//         }

//         // Не удаляйте строки ниже
//         PrintEvenNumbers(number);
//     }
// }
// Задача 4 - идеальное решение
// using System;

// public class Answer {
//     static void PrintEvenNumbers(int number)
//     {
//         for (int count = 2; count <= number; count += 2)
//         {
//             Console.Write($"{count}\t");
//         }
//     }

//     static public void Main(string[] args) {
//         int number;

//         if (args.Length >= 1) {
//             number = int.Parse(args[0]);
//         } else {
//             number = 6;
//         }

//         PrintEvenNumbers(number);
//     }
// }
