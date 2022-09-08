// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.Write($"Введи число М(количество чисел): ");
int m = Convert.ToInt32(Console.ReadLine());
int[] array = new int[m];

void InputNumbers(int m){
for (int i = 0; i < m; i++)
  {
    Console.Write($"Введи {i+1} число: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
  }
}

int MoreZero(int[] a)
{
  int count = 0;
  for (int i = 0; i < a.Length; i++)
  {
    if(array[i] > 0 ) count += 1; 
  }
  return count;
}

InputNumbers(m);
Console.WriteLine($"Введено чисел > 0: {MoreZero(array)} ");
