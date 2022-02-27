// программа вывода первого найденного индекса элемента массива по его заданному значению
void FillArray (int[] collection) // создание процедуры заполнения массива путем генерации случайных чисел от 0 до 10
{
int Length = collection.Length;
int index =  0;
while (index < Length)
{
   collection[index] = new Random().Next(1,10);
index++;
}

}

void PrintArray (int[] collection1) // создания процедуры распечатки массива
{
int Length1 = collection1.Length;
int index1 =  0;
while (index1 < Length1)
{
   Console.WriteLine(collection1[index1]);
index1++;
}

}

int[] array = new int[10]; // создается массив из 10 элементов с нулевыми значениями

FillArray(array); // заполнили массив из 10 элементов случайными числами с помощью процедуры
PrintArray(array); // распечатали заполненный массив с помощью процедуры

int IndexFind (int[] collection2, int find) // функция (метод) для поиска индекса элемента со значением указанной в переменной Find
{
int Length2 = collection2.Length;
int index2 =  0;
int position = -1; // -1 выводиться , когда нет элемента с заданным значением 
while (index2 < Length2)
{
    if (collection2[index2] == find)
    {
        position = index2;
        break;
    }
index2++;
}
return position;
}
Console.WriteLine();
int pos = IndexFind(array, 4); // обращение в функцию по выводу первого индекса элемента из массива со значением 4
Console.WriteLine(pos);