﻿// имеется одномерный массив array из n элементов.
// требуется найти элемент массива, равный find
// 1) установить счетчик index в позицию 0
// 2) Если array[index] = find, алгоритм завершил 
// работу успешно
// 3) увеличить index на 1
// 4) если index < n, то перейти к шагу 2.
// В противном случае алгоритм завершил 
// работу безуспешно


int[] array = {1,12,31,4,18,15,16,17,18};

int n = array.Length;
int find = 18;

int index = 0;

while (index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break; // прервать работу
    }
    //index = index + 1;
    index++;
}