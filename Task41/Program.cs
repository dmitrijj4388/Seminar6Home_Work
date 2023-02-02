// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3


 

int[] ConvToIntArr(string[] num1)
{
   int a = num1.Length;
   int[] newArray = new int[a];
   for (int i = 0;i < a; i++)
   {
      bool result = int.TryParse(num1[i], out int b);
      if (result)
      {
        newArray[i] = int.Parse(num1[i]);

      }
      else
      {
       newArray[i] = 0;
      }
     
   }


   return newArray;
}

int CountPositive(int[] arr)
{
   int count = 0;
   for (int i = 0; i < arr.Length; i++)
   {
      if (arr[i] > 0) count++;
   }
   return count;
}


Console.Clear();

Console.WriteLine("Введите числа через запятую: ");
string numbers = Console.ReadLine()!;
string[] num1 = numbers.Split(',', ' ');
int[] newNum = ConvToIntArr(num1);
int count = CountPositive(newNum);

System.Console.WriteLine($"Положительных чисел {count}.");











