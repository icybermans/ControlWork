// метод для создания массива строк
string[] CreateStringArray(int size){
    string[] array = new string[size];
    for(int i = 0; i < size; i++){
        Console.Write($"Введи {i}й элемент массива: ");
        array[i] = Console.ReadLine();
    }
    return array;
}

// метод для вывода элементов массива 
void ShowArray(string[] arr){
    for(int i = 0; i < arr.Length; i++) Console.Write(arr[i] + " ");
}

// метод для вывода элементов массива (строк), длина которых <= 3
void ShowConvertedArray(string[] array){
    for(int i = 0; i < array.Length; i++)
        if (array[i].Length <= 3) Console.Write(array[i] + " ");
}

// блок ввода-вывода 
Console.WriteLine("Привет! Начнем решение контрольной задачи :)");
Console.Write("Укажи размер создаваемого массива: ");
int size = Convert.ToInt32(Console.ReadLine());
string[] initialArray = CreateStringArray(size);
ShowArray(initialArray);
Console.WriteLine();

Console.Write("Новый массив будет содержать элементы: ");
ShowConvertedArray(initialArray);
