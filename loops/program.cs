void EvenNumbers(int HowMany)
{
    for (int i = 0; i < HowMany; i++)
    {
        if (i % 2 == 0)
        {
            Console.WriteLine($"Wynik z zadania 1 to: {i}");
        }
    }
}

EvenNumbers(50);

int AddNumbers(int arg)
{
    int temp = 0;
    int suma = 0;

    while (temp != arg)
    {
        temp++;
        suma += temp;
    }

    return suma;
}

int zad2 = AddNumbers(50);

Console.WriteLine($"Wynik z zadania 2 to {zad2}");

int[] arrray = { 1, 2, 3, 5, 6, 124, 4, 24, 53425, 9 };

int BiggestNumber()
{
    int biggest = 0;
    foreach (int i in arrray)
    {
        if (i > biggest)
        {
            biggest = i;
        }
    }
    return biggest;
}

int zad3 = BiggestNumber();

Console.WriteLine($"Wynik z zadania 3 to: {zad3}");

string sentence = "Samcio nie jest dobrym kumplem";

void ArrayBackwards(string arg)
{
    string reverseString = String.Empty;

    for (int i = arg.Length - 1; i >= 0; i--)
    {
        reverseString += arg[i];
    }
    Console.WriteLine($"Wynik z zadania 4 to: {reverseString}");
}

ArrayBackwards(sentence);
/*
5.Napisz funkcje, która przy pomocy zagnieżdżonej pętli for wydrukuje tabliczkę mnożenia od 1 do wartości argumentu funkcji.*/

void Multiplication(int arg)
{
    for (int i = 0;  i <= arg; i++)
    {
        Console.Write(i + "\t");
        for (int j = 1; j <= 3; j++)
        {
            if (i > 0) Console.Write(i * j + "\t");
            else Console.Write(j + "\t");
        }
        Console.Write("\n");
    }
}

Multiplication(5);