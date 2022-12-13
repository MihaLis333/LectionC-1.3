
/*
void Method2(string msg)
{
    Console.WriteLine(msg);
}
Method2("Hello");
*/
                             // Выводит одинакого!
/*
void Method1()
{
    Console.WriteLine("Hello");
}
Method1();
*/

/*
int Method3()
{
    return DateTime.Now.Year;
}

int year = Method3();
Console.WriteLine(year);
*/

// Задача: В текста нужно все пробелы заменить на черточки (|), маленькие буквы (к) заменить больш. (К), а больш. (С) маленьк. (с).

/*
string text = " Это пробный вариант. для видимой замены символов и строк!";

// string s = "qwerty"
//             012345
// s[3] это буква r

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;

    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if(text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result;
}

string newText = Replace(text, ' ', '|');

Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(newText, 'к', 'К');
Console.WriteLine(newText);
*/

// Сортировка элементов в массиве


int[] arr = {1, 5, 4, 3, 2, 6, 7, 1, 1};

void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for(int i = 0; i < array.Length -1; i++ )
    {
        int minPosition = i;

        for(int j = i + 1; j < array.Length; j++ )
        {
            if(array[j] < array[minPosition]) minPosition = j;
        }

        int temprary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temprary;
    }
} 


PrintArray(arr);
SelectionSort(arr);

PrintArray(arr);
