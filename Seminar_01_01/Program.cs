/*
Виды трансляций:
- Компилляция (C#, C++, Pascal ...)
- Интерпретация (Python, Javascript)


C# (Статическая типизация данных) : int n = 10; -> [10]

Python (динамическая типизация данных) : n = 10 -> class <`int`> -> [10]

*/

// Ввод и вывод данных
//Console.Clear();
//Console.Write("Hello, world! ") ; // Строки внутри C# обрамляются двойными кавычками//
//Console.Write("Rady\n"); //  \n - принудительный перенос на новую строку
//Console.WriteLine("Hello Rady! ");
//Console.WriteLine("Hello Rady! ");
// Write - Написать данные в консоль
// Read -  считать данные из консоли
// Writeline - вывод  в одну строчку
//Console.Write("Введите имя:  ");
//string name = Console.ReadLine()!;
//Console.WriteLine($"Привет, {name}!"); // форматированный вывод данных


// Console.Write("Введите 1-ое число: ");
// int n = int.Parse(Console.ReadLine()!); // быстрее
// Console.Write("Введите 2-ое число: ");
// int m = int.Parse(Console.ReadLine()!); // double если дробное число, int целое число
// int m = Convert.ToInt32(Console.ReadLine()); // эта строка медленнее
// "456" -> 456 -> n = 456
// Console.WriteLine($"{n} + {m} = {n + m}");
// Console.WriteLine($"{n} - {m} = {n - m}");
// Console.WriteLine($"{n} * {m} = {n * m}");
// Console.WriteLine($"{n} : {m} = {n / m} (ост. {n % m})");

// Операторы ветвления
// Задание 1
// Проверяет на входе два целых числа = первое число квадратом второго?
//Console.Clear();
//Console.Write("Введите 1-ое число: ");
//int n = int.Parse(Console.ReadLine()!);
//Console.Write("Введите 2-ое число: ");
//int m = int.Parse(Console.ReadLine()!);
// = - действие присвоение значения
// == - проверка на равенство
// != - проверка на неравенство
//if (m * m == n) // ЗАПРЕЩЕНО ставить точку с запятой
//     Console.WriteLine("yes");
//else
//      Console.WriteLine("no");
// Фигурные скобки нужно ставить, когда внутри конструкции выполняется две и более строчки


// int n = int.Parse(Console.ReadLine()!);
// "231" -> ["231"] -> 231 -> 231

// Задание 2 (версия 1  цикл FOR)
// принимает целое число N, на выходе все целые числа от N до -N

//Console.Clear();
//Console.Write("Введите число: ");
//int n = int.Parse(Console.ReadLine()!);
// for(begin, condition, step) начальное значение, условие, шаг
// одно повторение - одна итерация
//for(int i = -n; i <= n; i++)  // i = (-1) * n  i++ <-> i = i + 1
 //  Console.Write($"{i}\n ");        // i + " " и сделал принудительный перевод /n стоки на новую строчку

 // 1: i = -2              первая итерация
          
 //         -2
 // 2:     i++ <-> i = -2 + 1 = -1    вторая итерация
                             
 //                            -1
//  3:                           i++ <-> i = -1 + 1 = 0       третья итерация и так далее  , пока не пройдет проверку i <= n                   


 // break <-> метод флажка


// Задание 2 (версия 1  цикл WHILE)
// принимает целое число N, на выходе все целые числа от N до -N
/*
Console.Clear();
Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine()!);
int i = -n;
while (i <= n)
{
    Console.Write($"{i}\n ");
    i++;
}

*/
// Закоментировать можно начало /* и конец */



// Задание 3 


/*
Console.Clear();
Console.Write("Введите трехначное число: ");
int n = int.Parse(Console.ReadLine()!);
// 456 : 10 = 45 (остаток 6)
// 456 : 100 = 4 (остаток 56)
int n3 = n % 10; // остаток при делении на 10 показывает последнюю цифру числа у ЛЮБОГО числа
int n1 = n / 100;
Console.Write(n1 + n3);

*/

//Вариант В

Console.Clear();
Console.Write("Введите трехзначное число: ");
int n = int.Parse(Console.ReadLine()!);
int n3 = n % 10;
Console.Write("n3\n");
