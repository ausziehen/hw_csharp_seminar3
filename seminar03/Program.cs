// Task 19. Напишите программу, которая принимает 
// на вход пятизначное число и проверяет, является ли оно палиндромом.

// bool Palindrom(int index)
// {
//    int first = index;
//    int last = 0;
//    while (index >0)
//    {
//     int numb = index % 10;
//     last = last * 10 + numb;
//     index = index / 10;
//    }
//    return first == last;
// }
// Console.WriteLine("Input your number: ");
// int num = Convert.ToInt32(Console.ReadLine());
// bool paly = Palindrom(num);
// Console.Write(paly);


// Task 21. Напишите программу, которая принимает на вход 
// координаты двух точек и находит расстояние между ними в 3D пространстве.

// Console.Write("Введите координату X первой точки: ");
// double x1 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите координату Y первой точки: ");
// double y1 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите координату Z первой точки: ");
// double z1 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите координату X второй точки: ");
// double x2 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите координату Y второй точки: ");
// double y2 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите координату Z второй точки: ");
// double z2 = Convert.ToDouble(Console.ReadLine());
// double a = x2 - x1;
// double b = y2 - y1;
// double c = z1 - z2;
// double distance = Math.Round(Math.Sqrt(a * a + b * b + c * c), 2);
// Console.WriteLine("Длина отрезка: " + distance);

// Task 23. Напишите программу, которая принимает на вход
// число (N) и выдаёт таблицу кубов чисел от 1 до N.

// int num, i;
// void TableCube(int num)
// {
//     for (i = 1; i < num + 1; i++) Console.WriteLine($"{i} - {i * i * i}");
// }
// Console.WriteLine("Введите число: ");
// num = Convert.ToInt32(Console.ReadLine());

// TableCube(num);