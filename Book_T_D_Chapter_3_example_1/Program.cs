
public class Program
{

    static void LocalVarDeclarations()
    {
        Console.WriteLine("=> Data Declarations:");

        // локальная переменная иициализируются так:
        // типДанных имяПеременной = начальноеЗначение

        int myInt = 0;

        // Объявлять и присваивать можно также в двух отдельных строках

        string myString;
        myString = "This is my character data";

        // Объявить три переменных типа bool в одной строке
        bool b1 = true, b2 = false, b3 = b1;

        // Использовать тип данных System.Boolean для объявления булевской переменной
        System.Boolean b4 = false;


        Console.WriteLine("Your data: {0}, {1}, {2}, {3}, {4}, {5}", myInt, myString, b1, b2, b3, b4);

        Console.WriteLine();

    }

} 