// устанавливаем visual студио далее устанавливаем c# плагин
// устанавливаем material icon
// далее в гугле ищем и устанавливаем .net dotnet - нужно чтобы мы могли запускать различные c# проекты
// далее заходим в visual studio и нажимаем создать терминал, чтобы печатать команды
// далее проверяем dotnet --help там всякие основные команды и проверяем установилась ли на комп программа dotnet

// проводник - открыть папку (лучше где нибудь на раб столе и назвать project)
// clear - очистить терминал
// создать папку через терминал mkdir (make directory ) и название папки
// чтобы зайти в папку пишем cd и название папки
// чтобы создать файл (например index.txt) пишем touch и название файла с расширением 
// чтобы выйти из папки на уровень выше пишем cd ../

// new - создаёт новый проект или файл .net - например new console (мб для создания консольного проекта)
// program.cs - это основной файл где будет храниться программа код
// project.csproj - файл где храняться глобальные настройки , там указывается какой форм будет у выходного файла exe ,
// там же указывается какой sdk используется , без него не запустился бы c# проект



// using System;

// namespace project 
// {
//     class program 
//     {
        // public static void Main() 
        // {
           // Переменные
        //    int number = 5;
        //    int num2 = 4;
        //    System.Console.WriteLine("Переменная : " + number + ", " + num2);
        //    System.Console.WriteLine("Переменная : {0}, {1}", number, num2);
        // System.Console.WriteLine($"Переменная :  {number}, {num2}");
        // System.Console.WriteLine($"Переменная :  {number}, {num2+1000}");
        // byte num1 = 100;
        // System.Console.WriteLine(num1);

        // Разные типы данных
        // short num3 = -500;
        // ushort num4 = 1000;
        // int num5 = 5000;
        // uint num6 = 100000;
        // long num7 = 50000000000000;

        // math_operation = Convert.ToChar(Console.ReadLine ()); - можно указывать тип данных math_operation и указывать 
        // char math_operation - вот так выглядит объявление типа данных math operation

        // Числа с точкой
        // float num8 = 100.05f;
        // double num9 = 1000000.666161616161515155515151f;
        // double num10 = 1000000.666161616161515155515151d;

        // Строки и символы
        // char symbol1 = 's';
        // string word = "Hello world!";
        // System.Console.WriteLine(word);

        // Bool
        // bool isHasAnimal = false;


        // Комбо и лайфкахи как быстрее вносить инф
        // int num11 = 110, num12 = 120;

        // Константы
        // const byte NUMBER1 = 100;
        // NUMBER1 = 200;

        // Особенные типы данных
        // var some_new = "text";
        // dynamic some_new2 = 1000;

        


        // Домашнее задание 

        // byte num1 = 16;
        // string text1 = "test1";
        // char text2 = 's';
        // float num2 = 100.100000f;
        // short num3 = 500;
        // int num4 = 15151515;
        // bool isReal = true;
        // int num9;


        // Обработка данных от пользователя ( у readLine стоит по умолчанию string, поэтому нужно преобразовывать типы данных)

        // string some = null;
        // Console.WriteLine("Введите текст");
        // string? user_input = Console.ReadLine();
        // System.Console.WriteLine($"Значение: {user_input}");

        // Преобразование стринг в инт
        // Console.WriteLine("Введите текст: ");
        // int user_number = Convert.ToInt32(Console.ReadLine());
        // System.Console.WriteLine($"Значение: {user_number}");

        // Преобразование в тип данных short
        // Console.WriteLine("Введите текст: ");
        // short user_number = Convert.ToInt16(Console.ReadLine());
        // System.Console.WriteLine($"Значение: {user_number}");

        // Преобразование в тип данных float (цифры с точками)
        // Console.WriteLine("Введите текст: ");
        // int user_number = Convert.ToInt32(Console.ReadLine());
        // short user_number1 = Convert.ToInt16(Console.ReadLine());
        // float user_number2 = Convert.ToSingle(Console.ReadLine());
        // double user_number3 = Convert.ToDouble(Console.ReadLine());
        // bool isCorrect = Convert.ToBoolean(Console.ReadLine());
        // System.Console.WriteLine($"Значение: {user_number}");

        // string? some = null;

        // Альтернативные способы конвертации данных
        // string? user_input = Console.ReadLine();
        // float number5 = Single.Parse(user_input);
        // bool isTrue = Boolean.Parse()

        // Получение символа (удобно использовать метод readKey когда нужно нажать одну кнопку, например выход при нажатии esc и прочее, у readLine стоит по умолчанию int, 
        // а read когда нужно ввести символ и enter))
        // System.Console.WriteLine("Введите символ : ");
        // int user_number = Console.Read();
        // System.Console.WriteLine($"Введенный символ: {user_number}");
        // System.Console.WriteLine(user_number);
        // Не забывать, что он выводит именно КОД первого числа! поэтому путаница

        
        // Математическое выражение , ToString в console writeline в фигурных скобках если добавить , то тип данных преобразовывается 
        // в стринг(строку)
        // System.Console.Write("Введите первое число (можно даже через запятую): ");
        // float user_num1, user_num2, result;
        // user_num1 = Convert.ToSingle(Console.ReadLine());
        // System.Console.Write("Введите второе число (можно даже через запятую): ");
        // user_num2 = Convert.ToSingle(Console.ReadLine());
        // result = user_num1 + user_num2;
        // System.Console.WriteLine($"Добавление: {result.ToString()}");
        // result = user_num1 - user_num2;
        // System.Console.WriteLine($"Вычитание: {result.ToString()}");
        // result = user_num1 * user_num2;
        // System.Console.WriteLine($"Умножение: {result.ToString()}");
        // result = user_num1 / user_num2;
        // System.Console.WriteLine($"Деление: {result.ToString()}");
        // result = user_num1 % user_num2; // ОСТАТОК ПРИ ДЕЛЕНИИ
        // System.Console.WriteLine($"Проценты: {result.ToString()}");


        // Сокращенные действия
        // int num = 500;
        // num = num + 50;
        // num += 50; // это тоже самое что и int num = 500 , только сокращенное
        // num -= 50; // это тоже самое что и num = num - 50 (так же можно делать и с /(делением) *(умножением) и с %(остатком при делении))
        // num++; // это тоже самое что и num = num + 1 что и num += 1
        // num--; // это тоже самое что и num = num - 1 что и num -= 1
        // num--;
        // System.Console.WriteLine(num);

        // // Класс Math
        // System.Console.WriteLine(Math.PI);
        // System.Console.WriteLine(Math.E);
        // System.Console.WriteLine(Math.Abs(-4)); // метод МОДУЛЬ в классе Math обозначается как Abs
        // // с помощью math можно вычислить и синус и косинус Math.Sin(тут ввести число) или Math.Cos(тут ввести число)
        // System.Console.WriteLine(Math.Floor(4.567f)); // floor (пол) всегда округляет числа в меньшую сторону
        // System.Console.WriteLine(Math.Ceiling(4.567f)); // ceiling (потолок) всегда округляет в большую сторону
        // System.Console.WriteLine(Math.Round(4.567f)); // Округление к какому числу ближе
        // System.Console.WriteLine(Math.Pow(4,2)); // Возвредение в степень 4(четыре) во втрой степени(2) = 16
        // System.Console.WriteLine(Math.Min(5, 4)); // метод Min в классе Math помогает найти минимальное число (например из чисел 5 и 4 нужны узнать какое из них наименьшее)
        // System.Console.WriteLine(Math.Max(5, 4)); // метод Max помогает найти наибольшее число(из чисел 5 и 4)
        
        // Площадь треугольника
        // float a, b, beta;
        // System.Console.WriteLine("Введите размер стороны а: ");
        // a = Convert.ToSingle(Console.ReadLine());
        //  System.Console.WriteLine("Введите размер стороны b: ");
        // b = Convert.ToSingle(Console.ReadLine());
        //  System.Console.WriteLine("Введите угол (beta): ");
        // beta = Convert.ToSingle(Console.ReadLine());

        // // result = Convert.ToSingle(0.5f * a * b * Math.Sin(beta));
        // //  можно написать так или сделать как строчкой ниже , т.к. math sin высчитывает в типе данных double, еще нужно удалить переменную result в начале
        // double result = 0.5f * a * b * Math.Sin(beta);
        // System.Console.WriteLine($"Площадь треугольника равна: {result}");

       
       
       
        // Условный оператор if else
        // можно использовать в if > < == !=(не равно)
        // IsNullOrWhiteSpace - если не равно нулю или пустой строке
        // булевые значения можно сокращать - if(isHasCar == true) равна if(isHasCar) , а if(isHasCar == false) равна if(!isHasCar)
        // Length считает количество символов
        // если после { только одна строчка кода, то их(фигурные скобки) можно не указывать
        // else всегда пишется в конце когда закрывается }
        // || - означает ИЛИ
        // %% - означает И

        // bool isHasCar = false;
        // // if(isHasCar == true);

        // System.Console.WriteLine("Enter number :");
        // int user_input = Convert.ToInt32(Console.ReadLine());
        // if(user_input > 5 || isHasCar)
        // {
        //     System.Console.WriteLine("User enter bigger than 5");
        //     string? word = Console.ReadLine();
        //     if(!string.IsNullOrWhiteSpace(word) && word.Length == 3)
        //         if(word.Length == 3)
        //             System.Console.WriteLine("word is 3 symbol");
        // }
        // else if (user_input == 5)
        //     System.Console.WriteLine("user enter 5");
        // else if (user_input < 0)
        //     System.Console.WriteLine("user enter less than 0");
        // else if (user_input == 4)
        //     System.Console.WriteLine("user enter 4");
        // else if (user_input == 2)
        //     System.Console.WriteLine("user enter 2");
        // else 
        //     System.Console.WriteLine("User enter not 5");


        // // Тернарный оператор (как сокращенно делать if else)
        // //// string? res = user_input == 0 ? "zero" : "unknown"; // означает что если юзер инпут равен нулю отображается зеро, а если нет ункновн
        // string? res = user_input == 0 || !isHasCar ? "zero" : "unknown";
        // // if(user_input == 0)
        // //     res = "zero";
        // // else
        // //     res = "unknown";   
        // System.Console.WriteLine(res);    

        // Практическое применение условных операторов , примитивная авторизация
        // Key == ConsoleKey.D - обращение к клавишам, т.е. пользователь нажимает на какую то клавишу
        // ConsoleKey.D - обращение к перечислениям
        // Console.ReadKey().Key == ConsoleKey.D - сверяем введенную клавишу с клавишей D
        // else if  - еще одно "Если" условие 
        // string login = "admin", password = "12345";
        // System.Console.Write("Введите логин и потом пароль: ");
        // if (Console.ReadLine() == login && Console.ReadLine() == password)
        // {
        //     System.Console.WriteLine("Пользователь авторизован\nНажмите на букву D или нажмите на букву E: ");
        //     if(Console.ReadKey().Key == ConsoleKey.D)
        //         System.Console.WriteLine("Вы удалили пользователя");
        //     else if(Console.ReadKey().Key == ConsoleKey.E)
        //         System.Console.WriteLine("Вы вышли из системы");
        //     else
        //         System.Console.WriteLine("Мы ничего не поняли");                           
        // }
        // else         
        //     System.Console.WriteLine("Вы не авторизованы");        



        // Домашнее задание
        // int num1, num2, result;
        // System.Console.WriteLine("Введите число 1");
        // num1 = Convert.ToInt32(Console.ReadLine());
        // System.Console.WriteLine("Введите число 2");
        // num2 = Convert.ToInt32(Console.ReadLine());
        // result = num1 / num2;
        // System.Console.WriteLine($"{num1} / {num2} = {result}");

        
        
        
        
        
        // Switch case 
        // в switch case проверяем всегда на точное совпадение, нельзя написать > или <
        // default - это что то вроде else , т.е. выполняется если не выполнены все остальные case(if, if else)
        // default является необязательным
        // short num = 500;
        // switch(num) 
        // {
        //     case 40: 
        //         System.Console.WriteLine("Enter 40");
        //         break;
        //     case 45: 
        //         System.Console.WriteLine("Enter 45");
        //         break;
        //     case 3: 
        //         System.Console.WriteLine("Enter 3");
        //         break;
        //     case 50: 
        //         System.Console.WriteLine("Enter 50");
        //         break;    
        //     case 4: 
        //         System.Console.WriteLine("Enter 4");
        //         break;     
        //     default:
        //         System.Console.WriteLine("Default number");
        //         break;
        // }

        // Новый синтаксис для switch case , в нем всегда после закрывающей }(фиг скобки) нужно вводить ; 
        // тут если выполняется совпадение то меняется значение переменной
        // тут обязательно нужно указывать defaulut(_)
        // _ - это по сути default
        // int a = 5, b = 5;
        // int res = num switch 
        // {
        //     1 => a + b, // это выражение означает, что если num будет равно 1, то значение int меняется на a+b, т.е. res будет равна 10
        //     2 => a - b,
        //     3 => a * b,
        //     4 => a / b,
        //     _ => 0      

        // };
        // System.Console.WriteLine(res);
        
        // // Домашнее задание switch case   
        //     System.Console.WriteLine("Введите первое произвольное целое число");
        // int num1 = Convert.ToInt16(Console.ReadLine());
        //     System.Console.WriteLine("Введите второе произвольное целое число");
        // int num2 = Convert.ToInt16(Console.ReadLine());
        //     System.Console.WriteLine("Введите какое действие вы ходите произвести между перым и вторым числом цифра 1 - сложение, цифра 2 - вычитание");
        //     // char math_operation ---- можно было объявить тип данных матем операцию (эти три строчки)
        //     // math_operation = Convert.ToChar(Console.ReadLine ()) ---- можно было объявить тип данных матем операцию (эти три строчки)
        //     // switch (math_operation) ---- можно было объявить тип данных матем операцию (эти три строчки)
        // int num3 = Convert.ToInt16(Console.ReadLine());
        // int result;
        
        // switch(num3)
        // {
        //     case 1:
        //     result = num1 + num2;
        //     System.Console.WriteLine($"{num1} + {num2} = {result}");  
        //     break;   

        //     case 2:
        //     result = num1 - num2;
        //     System.Console.WriteLine($"{num1} - {num2} = {result}");  
        //     break;
        // }  
        


       
       
       
        //Массив данных
        // new byte[3] - выделение памяти, 3 байта, значит массив может содержать 3 элемента , но бывают и динамические массивы или коллекции, их изучим позже
        // nums[0] - так мы обращаемся к первому элементу, в массивах отсчет начинается с 0 и до предпоследнего
        // System.Console.WriteLine(++nums[1]); - это отобразит увеличенный элемент [1] на единицу(тоесть +1)
        // byte [] nums = new byte[3]; // тут мы создали массив и выделили память[3]
        // nums[0] = 5; // тут мы в нулевой(на самом деле первый) элемент добавили значение 5  
        // nums[1] = 15; // тут мы в первый(во втрой элемен) добавили значение 15
        // nums[2] = 4; // тут мы в последний второй(тертий) элемент добавили значение 4
        // // nums[3] = 5; // не отобразиться
        // nums[1] = 7;
        // // nums[1]--; //если нужно чтобы сначала произвелось действие ++(увел на 1), то нужно писать до nums, а если не важно, то можно после (эту и след строку смотреть)
        // System.Console.WriteLine(++nums[1]); // если нужно чтобы сначала произвелось действие ++(увел на 1), то нужно писать до nums, а если не важно, то можно после (эту и пред строку смотреть)
        // string[] names =  {
        //     "Bob", 
        //     "Alex", 
        //     "John", 
        //     "Josh" 
        //     }; // это второй вид записи массивов, тут можно сразу указывать значения, new string[] - это можно удалить если записывать в таком виде массив, тут тоже можно использовать ^1 и так далее
        // System.Console.WriteLine($"Наш первый пользователь: {names[^1]}"); // {names[^1]} - ^1 - взять с конца первый элемент(важно обратить внимание, что отсчет идёт не с нуля а с 1), {names[^2]} - ^2 - взять с конца второй элемент, {names[0]} - взять первый элемент


        // Многомерные массивы
        // если писать byte [,] - это означает, что у нас теперь будет двумерный массив, т.е. в каждом элементе есть еще по массиву
        // new byte[3,2]; - 3 означает что есть три элемента(массива), 2  означает что в каждом массиве по 2 элемента
        // // byte [,] numbers = new byte[3,2];
        // // byte [,] numbers = { {1,5}, {5,6}, {6,7} };

        // byte [,] numbers = 
        // { 
        //     {1,5}, 
        //     {5,6}, 
        //     {6,7}, 
        //     {8,9}
        // }; 
        // numbers[1,1] = 56; // тут я поменял значение во втором массиве во втором элементе с 6 на 56 // в двумерных массивах нельзя использовать ^
        // System.Console.WriteLine(numbers[1,1]);

        //трехмерный массив можно записать вот так
        // byte [,,] nums3 = new byte[3,3,3]
        
        // byte [,,] nums3 = 
        // { 
        //     {
        //         {3,5},
        //         {5,6}
        //     }, 
        //     {
        //         {3,5},
        //         {5,6}
        //     }, 
        //     {
        //         {3,5},
        //         {5,6}
        //     } 
        // };
        // nums3[1,0,1] = 54; // обращение ко второму вложенному массиву(первому по индексу), далее обращаемся к первому вложенному массиву(нулевому по индексу) и далее обращаемся ко второму элементу(первому по индексу)

        //// byte [] - так объявляется одномерный массив, byte [,] - так объявл двумерный массив, byte [,,] - так объявляется трёхмерный массик, и т.д.
        // { {1,5}, {5,6}, {6,7} }

        // еще один вариант записи двумерного массива
        // вместо [,] можно еще записать [][] - в таком случае можно указывать разное количество во внутренних массивах
        // { {1,5}, {5,6,0}, {6,7,8,9,10,11} }

        // short [][] nums1 =  new short [3][]; // new short [3][] - это означает что в массиве будет три элемента, а во вложенных массивах может быть разное кол-во элементов
        // nums1[0] = new short[2]; // тут мы указали(выделили память), что в первом вложенном массиве будет два элемента
        // nums1[1] = new short[3]; // тоже самое, но для второго вложенного массива, но там будет 3 элемента
        // nums1[1] = new short[6];
        // nums1[0][0] = 56;
        // System.Console.WriteLine(++nums1[0][0]);

        // { {1,5}, {5,6,0}, {6,7,8,9,10,11} }

        // int [][] nums2 = { 
        //     new int[]{1,5}, 
        //     new int[]{5,6,0}, 
        //     new int[]{6,7,8,9,10,11},
        //     new int[]{3}
        //     }; // можно тоже самое, что и выше записать так, массивы где во вложенных массивах разное количество элементов называют "Зубчастыми массивами"
        //     nums2 [^2][^2] = 5; // тут(в зубчастых массивах) тоже можно использоватьл ^(какое знач с конца)

        //Дополнительные методы которые позволяют производить действия для массивов
        //Length - возвращает количество элементов в массиве. К примеру, для массива arr, 
        //который состоит из 3 элементов мы можем применить функцию следующим образом: arr.Length. Эта запись выдаст число 3;

        //Arrays.Clear - очищает массив и устанавливает в качестве новых значений параметр, который вы передаете в него. Пример:
        // int[] arr = new int[] { 1, 2, 3, 5 };
        // Array.Clear(arr, 0, arr.Length); // Установит повсюду 0
        // Console.Write(arr[1]); // Выведет значение 0

        //Arrays.CopyTo - копирование массива в новый массив. Пример:
        //int[] arr = new int[] { 1, 2, 3, 5 }; // Основной массив
        //int[] newOne = new int [4]; // Новый массив
        //arr.CopyTo(newOne, 0); // Копирование начиная с элемента под индексом 0
        //Console.Write(newOne[2]); // Выведет 3


        //Домашняя работа(Решена правильно)
        //
        // int[] arr_1 = {1,2,3,4}; 
        // int[] arr_2 = {5,6,7,8};
        // int[] newarr = new int[4];
        // arr_1.CopyTo(newarr, 0);
        // Array.Clear(arr_1, 0, arr_1.Length);
        // arr_2.CopyTo(arr_1,0);
        // Array.Clear(arr_2, 0, arr_2.Length);
        // newarr.CopyTo(arr_2,0);
        // System.Console.WriteLine(arr_1[1]);
        // System.Console.WriteLine(arr_2[1]);




        // Циклы

// ПРИМЕР1: тут мы выводим НЕЧЕТНЫЕ числа от 0 до 10 используя условные операторы и циклы
// using System;

// namespace project 
// {
//     class program 
//     {
//         public static void Main() 
//         {
    
//             for (int i = 0; i <= 10; i++)
//             {
//                 if (i % 2 != 0 ) 
//                 { System.Console.WriteLine(i); }
//             }
//             ;

//         }
        
//     }

// }    


// ПРИМЕР2 , тут мы выводим все четные цифры из массива

// namespace project 
// {
//     class program 
//     {
//         public static void Main() 
//         {
//             int[] nums = {5, 7, 4, 30, 45, 3, -2, 57, 7, 9};
//             foreach(int el in nums) 
//                 {
//                 if (el % 2 != 0 ) 
//                     System.Console.WriteLine(el);
//                 }

//         }
//     }
// }

// можно было еще записать тоже самое вот так:
// namespace project 
// {
//     class program 
//     {
//         public static void Main() 
//         {
//             int[] nums = {5, 7, 4, 30, 45, 3, -2, 57, 7, 9};
//             for(int el = 0; el<nums.Length; el++) 
//                 {
//                 if (nums[el] % 2 != 0 ) 
//                     System.Console.WriteLine(nums[el]);
//                 }
//         }
//     }
// }




        //  for() {}
        // в циклах принято переменные называть одним символом
        // сначала объявляется переменная потом указывается до каких пор цикл будет работать и потом указывается условие(++значит за цикл i будет увеличиваться на 1)
        // -- уменьшаться на один(еще можно указать -=1), деление /=,
        // i -= 10 - это означает, что в каждом цикле будет отниматься от i 10 
        //  цикл for это конструкция, которая позволяет выполнить код несколько раз подряд, внутри циклов можно указывать всякие штуки типа cw и условий if
        // если внутри цикла используется только одна строчка кода то фигурные скобки({}) можно не использовать (по аналогии ис условными операторами)
        // for(int i = 10; i >= 1; i -= 1) 
        //     System.Console.WriteLine($"Element: {i}");

        // while(){} // тоже самое что и for только записывается по другому в круглых скобках указывается только условие, а все остальные параметры записываются вне цикла
        // bool isInLoop = true;
        // while(isInLoop){
        //     System.Console.WriteLine("Мы в цикле");
        //     if(Console.ReadKey().Key == ConsoleKey.E)
            // isInLoop = false; 
        // }

        // int i = 0;
        // while(i<10){
        //     System.Console.WriteLine($"Element: {i}");
        //     i++;
        // }  // запись while как for

        // float i = 100;
        // while(i>10){
        //     System.Console.WriteLine($"Element: {i}");
        //     i /= 2;
        //     // i /= 2; - вот так записывается деление в каждом цикле, чтобы переменная i делилась на 2 каждый цикл
        // }  

        // do while
        // int i = 1;
        // do 
        // {
        //         System.Console.WriteLine($"Element: {i}");
        //         i ++;
        // } while(i<10);

        // Операторы в цифрах
        // for(int el = 1; el < 40; el += 5 )
        // {

        // if(el >= 20)
        // break;

        // if(el % 2 != 0) // если el при делении на два не равен нулю, тоесть если el будет нечетным числом
        // continue; // сcontinue - пропуск круга или пропуск итерации

        // System.Console.WriteLine($"Element: {el}");

        // Практическое применение циклов
        // Циклы удобно использовать с массивами
        // int[] nums1 = {5,6,7,8, -23, 567};
        // for(int i = 0; i< nums1.Length; i++)
        // {
        // nums1[i] += 50; // это действие добавит к каждому числу перед отображением 50    
        // System.Console.WriteLine(nums1[i]); //вместо nums[0] или nums[1] можно написать nums1[i] чтобы не указывать 4 раза nums[1] nums[2] и так далее

        // short[] nums2 = new short[3];
        // int i = 0;
        // while(i < nums2.Length) {
        //     System.Console.WriteLine($"Введите значение для элемента по {i}");    
        //     nums2[i] = Convert.ToInt16(Console.ReadLine());    
        //     i++;
        // }     

        // for(int j = 0; j < nums2.Length; j++) 
        // System.Console.WriteLine(nums2[j]);

        // foreeach - по результату показывает тоже самое что и выше для for, но намного упрощеннее
        // var -  переменная которая изначально с неизвестным типом данных, 
        // для var тип данных будет присвоен в зависимости от того какой массив вы будете перебирать, в данном случае массив nums2
        // foreach(var el in nums2){
        //     System.Console.WriteLine(el);
        // }  

        // Двумерные массивы
        // int [,] nums = {
        //     {5,6,7},
        //     {55,26,37},
        //     {45,56,67}
        // };

        // foreach(int el in nums) {
        //     System.Console.WriteLine(el); // foreach настолько крут, что не нужно прописывать для каждого элемента el[0,0] - а можно указать el и он сам обратиться ко всем
        // }

        // как сделать тоже самое что и выше для foreach с цилом for (это может понадобиться на собесе), для этого понадобиться сделать цикл в цикле
        //i < nums.Length - это значит что цикл будет двигаться вплоть до длины всего массива
        // nums.GetLength(1) - этот метод определяет длину основного массива или вложенных массивов, если указать (0), то он посчитает длину основного массива, 
        // а (1) определяет длину вложенных массивов
        // int summ = 0; // как подсчитать сумму (продолжение sum += nums[i, j])

        // for(int i = 0; i < nums.GetLength(0); i++){
        //     for(int j = 0; j < nums.GetLength(1); j++){
        //         summ += nums[i, j]; // тут мы перебираем каждый элемент и к текущей сумме добавляем значение текущего элемента
        //         System.Console.WriteLine(nums[i, j]); // индекс i - индекс основного массива, индекс j - индекс каждого конкретного элемента во вложенном массиве
        //     } 
        // } 
        // System.Console.WriteLine($"Сумма: {summ} ");
        
        // Домашняя работа
    //     for (int i = 24; i < 30; i++)
	//     Console.WriteLine(i);

        // int i = 24; // Создание переменной
        // while (i <= 30) { // Здесь только условие
	    // Console.WriteLine(i);
	    // i++; // Увеличение переменной

        // for (int i = 10; i < 30; i++) {
	    // Console.WriteLine("Введите число: ");
        // int nums2 = Convert.ToInt32(Console.ReadLine());
        // if (nums2 == 0) 
        // break;
        // else if (nums2 == 1) {
        // System.Console.WriteLine("One more iteration");
        // continue;
        // }
        // }

        // }




        // Методы и функции
        // Методы - Функции - небольшие подпрограммы, которые мы сами можем создавать и вызывать их в любом удобном для нас месте.
        // Функции это методы, но в классах функции называются методами, а в других местах (вне классов) они называются функциями. По сути разницы никакой, 
        // но поскольку C# это объектно ориентированный язык, то лучше говорить методы, вместо функций, хотя это абсолютно на ваше усмотрение.
        // Точно такая же ситуация с переменным и полями. Поля - в классах, переменные - вне классов, хотя это одно и то же самое.
        
        // public static void - VOID значит ничего не будет возвращать
        // public static void PrintInfo () {} - PrintInfo - нельзя метод название метода начинать с цирфы или спец знаками
        // () - в круглых скобках указываются принимаемые параметры(переменные)
        // {} - внутри фигурных скобок находится само тело нашего метода, при вызове метода выполнится именно он
        // Main единственный метод, который вызывается автоматически, 
        // любой другой метод чтобы он сработал его нужно вызвать в ручную
        // соответственно новый метод PrintInfo будем вызывать в методе Main
        // Чтобы вызвать новый метод в методе Main достаточно написать "PrintInfo ();"
        // нужно стараться называть методы по тому, что он будет делать

    //    using System;

// namespace project 
// {
//     class program 
//     { 
//         public static void Main() 
//         {

        // // PrintInfo("Hello");
        // // string some = "some";
        // // PrintInfo(some);
        // // PrintInfo("World");

        // int res1 = AddTwoNumbers(4, 5); // можно сразу в скобках передать значения
        // PrintInfo(res1.ToString());
        // // // int x = 5, y = 10; // или создать переменные 
        // // // AddTwoNumbers(x, y); // и в методе передать созданные строчкой выше переменные

        // }

        // public static void PrintInfo (string word) // внутри круглых скобок указывают параметры (работают они как обычные переменные)
        // {
        //     Console.Write(word);
        //     Console.Write("!\n");
        // }

        // public static int AddTwoNumbers(int a, int b)   // можно в круглых скобках создавать два параметра
        // {
        //     int result = a + b;
        //     // // Console.Write($"Result: {result}");
        //     PrintInfo(result.ToString()); // тут мы обратились к методы принтинфо чтобы отобразить результат, но перед этим сконвертировали , т.к. там стринг

        //     return result;


        

        // Практическое применение методов и функций
        // Нахождение наименьшего значения из массива
// namespace project 
// {
//     class program 
//     { 
//         public static void Main() 
//         {
//             int[] nums1 = {5, 8, 0, -3, 6, 89};
//             int min1 = SearchMinimal(nums1);

//             int[] nums2 = {5, 8, -4, 0, -3, 6, 89};
//             int min2 = SearchMinimal(nums2);

//             int[] nums3 = {5, 8, 0, -3, 6, 89, -10, 5, 6};
//             int min3 = SearchMinimal(nums3);
            
//             if (min1 < min2 && min1 < min3)
//                 System.Console.WriteLine($"Минимум {min1}");
//             else if (min2 < min1 && min2 < min3)
//                 System.Console.WriteLine($"Минимум {min2}");
//             else 
//                 System.Console.WriteLine($"Минимум {min3}");
//         }        


//         public static int SearchMinimal(int[] nums) {
//             int min = nums[0];
//             for(int i=0; i < nums.Length; i++) 
//             {
//                 if(nums[i] < min)
//                     min = nums[i];
//             }
//             // // System.Console.WriteLine($"Минимум: {min}");

//             return min;
//         }

//     }
// }    



//     }
        
// }


// методы , РЕКУРСИЯ - это когда внутри метода вызываем этот же метод
// namespace project 
// {
//     class program 
//     { 
//         public static void Main() 
//         {

//             GetUserInput();

//         }

//         public static void GetUserInput() {
//             System.Console.WriteLine("Введите число: ");
//             int number = Convert.ToInt32(Console.ReadLine());
//             if (number != 50){
//                 GetUserInput();
//             }
//             else 
//             System.Console.WriteLine("Все готово!");
//             }

//     }



// }


// методы, ОБЛАСТЬ ВИДИМОСТИ
// namespace project 
// {
//     class program 
//     { 
//         public static void Main() 
//         {
//             int x = 10; // это добавили
//             GetUserInput();

//         }

//         public static void GetUserInput() {
//             int x = 15; // это добавили , обратите внимание, что ошибка не выдаётся хотя одинаковые названия перем
//             // // это связано с тем, что перем в одном методе не видны в другом методе , ЭТО И ЕСТЬ ОБЛАСТЬ ВИДИМОСТИ
//             // // тоже самое и в ЦИКЛАХ , если внутри цикла создать переменную, то за её пределами к ней нельзя будет обратиться
//             // // грубо говоря, перем внутри фиг скобок не видны внутри других фиг скобок
//             // // но если перем и цикл в одних скобках и перем названа раньше, то в цикле эту перем можно использовать
//             System.Console.WriteLine("Введите число: ");
//             int number = Convert.ToInt32(Console.ReadLine());
//             if (number != 50){
//                 GetUserInput();
//             }
//             else 
//             System.Console.WriteLine("Все готово!");
//             }
//     }

// }


// // Методы, СОКРАЩЕННЫЙ СИНТАКСИС ДЛЯ СОЗДАНИЯ МЕТОДА
// // если метод состоит из одной строчки кода, то можно не использовать {} , а написать => 

// namespace project 
// {
//     class program 
//     { 
//         public static void Main() 
//         {
//             AddTwoNumbers(4,5); 
//             // //PrintAndAddNumbers(5.6f, 7.5f, "Результат: ");// числа с точкой пишутся с буквой f , и нужно писать точки, а не запятые
//             // //PrintAndAddNumbers(15.6f, 7.5f, "Результат: ");
//             // //PrintAndAddNumbers(5.6f, 27.5f, "Результат: ");
//             // // после указания " string result = "Результат: " " , можно писать вот так(убрать третье значение):
//             PrintAndAddNumbers(5.6f); // чтобы присвоить значение не float a , а float b, пишем:
//             PrintAndAddNumbers(b: 5.6f);
//             // // еще можно вот так написать:
//             PrintAndAddNumbers(b: 5.6f, a: 7.5f);
//             PrintAndAddNumbers(15.6f, 7.5f);
//             PrintAndAddNumbers(5.6f, 27.5f, "Result: "); // но если значение передаётся, то проставляется оно, а не по умолчанию
//             // // еще можно написать вот так:
//             PrintAndAddNumbers(5.6f, 27.5f, result: "Result: ");
//         }
        
//         // // public static void Print() {
//         // //    System.Console.WriteLine("Hello");
//         // //}
//         // // вместо кода выше можно написать так(если в методе всего одна строчка кода):
//         public static void Print() => System.Console.WriteLine("Hello");
//         // // Еще можно вот так написать:
//         public static void AddTwoNumbers(byte a, byte b) => System.Console.WriteLine(a+b);
        


//         // // public static void PrintAndAddNumbers(float a, float b, string result) {
//         // // вместо строчки выше, если третье знач не важно и оно всегда повторяется, можно сразу присвоить значение по умолчанию:
//         public static void PrintAndAddNumbers(float a = 5.0f, float b=5.0f, string result = "Результат: ") { // "=" - так проставляются знач по умолч 
//         // // значения по умолч проставляются с конца, т.е. сначала для string result , затем для float b, затем float a
//         // // если нужно проставить значение по умолчанию для float a, то нужно float a и float b переставить местами, вот так:
//         // // public static void PrintAndAddNumbers(float b, float a = 5.7f, string result = "Результат: ") {

//             float res = a + b;
//             System.Console.WriteLine(result + res.ToString());
//         }
//     }
// }



// Методы, операторы, передача параметров по ссылке , ref
// namespace project 
// {
//     class program 
//     { 
//         public static void Main() 
//         {
//             short x = 10;
//             Test(ref x); // используем ref когда нужно чтобы в другом методе произвели действие(a++) и вернули изменившуюся переменную
//             System.Console.WriteLine(x);
//         }
//         public static void Test(ref short a){ // если используем ref , то в методе тоже нужно его указать
//             a++;
//         }
//     }
// }


// Методы, операторы, передача параметров по ссылке , out - когда значение переменной не задано в осн методе, но задаётся в методе Test
// namespace project 
// {
//     class program 
//     { 
//         public static void Main() 
//         {
//             short x;
//             Test(out x); // используем out когда нужно чтобы в другом методе произвели действие(a++) и вернули изменившуюся переменную
//             // // когда в методе main в переменной не задано значение, оно задаётся в методе Test
//             System.Console.WriteLine(x);
//         }
//         public static void Test(out short a){ // если используем ref , то в методе тоже нужно его указать
//             a = 5;
//             a++;
//         }
//     }
// }


// //  Методы, операторы, IN -  когда в методе перем исп только для чтения(т.е. изменить её нельзя), 
// // но можно использовать для отображения cw например, можно использовать в циклах и т.д.

// namespace project 
// {
//     class program 
//     { 
//         public static void Main() 
//         {
//             short x;
//             Test(out x); // используем out когда нужно чтобы в другом методе произвели действие(a++) и вернули изменившуюся переменную
//             // // когда в методе main в переменной не задано значение, оно задаётся в методе Test
//             System.Console.WriteLine(x);

//             Test2(in x);
//         }
//         public static void Test(out short a){ // если используем ref , то в методе тоже нужно его указать
//             a = 5;
//             a++;
//         }
//         public static void Test2(in short a){
//             System.Console.WriteLine(a);
//         }
//     }
// }







//  ДАТА и ВРЕМЯ .
// using System;

// namespace project 
// {
//     class program 
//     {
//         public static void Main() 
//         {

//             // бывают классы DateTime - для получения даты и времени (по моему его удобнее всегда использовать), 
//             // бывают классы DateOnly - для получения только даты
//             // TimeOnly - для получения только времени
//             // работает это как с объявлением переменной, нужно указать класс DateTime и далее название
//             DateTime now = DateTime.Now; // объявили время, настоящее(на текущий момент)
//             // now = now.AddHours(3); // добавляет часы к текущей дате , можно еще добавить days years и т.д. , можно отнять часы(-3 например)
//             // System.Console.WriteLine(now.ToString("Сегодня день: yyyy-mm-dd , время: hh:mm:ss")); // время нужно преобразовать в string для отображения, в скобках и ковычках указывается формат отображения(маска как я понял)
//             System.Console.WriteLine(now.AddHours(3).AddDays(3).ToString("Сегодня день: yyyy-mm-dd , время: hh:mm:ss")); // можно добавлять часы и дни сразу при отображении


//             // Date only
//             DateOnly nowDate = DateOnly.FromDateTime(DateTime.Now); // вместо DateTime.Now можно было указать переменную now
//             System.Console.WriteLine(nowDate.Day); // тут не получится ToString преобразовать? можно указать Day, DayOfWeek или DayOfYear , текущ мес Month , текущ год Year


//             // Time only
//             TimeOnly nowTime = TimeOnly.FromDateTime(DateTime.Now); // вместо DateTime.Now можно было указать переменную now
//             // System.Console.WriteLine(nowTime.Hour); // тут работает так же как и в Date only , можно указать часы секунды минуты и пр.
//             System.Console.WriteLine($"Время {nowTime.Hour}:{nowTime.Minute}");


//         }
//     }
// }






// // Отладка кода , отслеживание ошибок
// using System;

// namespace project 
// {
//     class program 
//     {
//         public static void Main() 
//         {


// // первое для поиска ошибок можно комментировать отдельно строчки кода и пробовать запускать их
// //  второе можно остановить код на определенной строке , слева нужно нажать на номер строки, такиъ точек можно делать много, 
// // код там будет стопариться
// // затем код нужно запустить через верхнее меню(а не через терминал) (Выполнить - запустить отладку)


//             string name = "Alex";

//             int[] nums = {5,6,8,23};
//             foreach(int el in nums) 
//                 Console.WriteLine(el);
            






//         }
//     }
// }






        // Интенсив
        // ДЗ 
        //  первое задание , задание первое: 
        // Напишите программу на C#, что будет высчитывать сумму чисел кратных 3 или 5. Числа должны быть от 0 до 1000.
// using System;

// namespace project 
// {
//     class program 
//     {
//         public static void Main() 
//         {
    
//             int sum = 0;
//             for (int i = 0; i <= 1000; i++)
//             {
//                 if (i % 3 == 0 || i % 5 == 0) { sum += i; }
//             }
//             Console.WriteLine(sum);

//         }
        
//     }

// }    


// ЗАДАНИЕ ВТОРОЕ: Создайте двумерный массив, в котором найдёте минимальный элемент среди всех элементов массива. 
// Важно учесть, что нахождение минимального элемента должно производиться при помощи циклов. 
// Массив: int[,] x = { {20, 34, 2}, {9, 12, 18}, {3, 4, 5} };

        
// using System;

// namespace project 
// {
//     class program 
//     {

//     public static void Main() 
//     {

//     int[,] x = { {20, 34, 2}, {9, 12, 18}, {3, 4, 5} };
//     int min = x[0,0];
//         for(int i = 0; i < x.GetLength(0); i++){
//             for(int j = 0; j < x.GetLength(1); j++){
//                 if(x[i,j]<min)
//                 min = x[i,j];
//         }
//         }
//         System.Console.WriteLine($"Минимум: {min}");

    
//     }

//     }
// }

    





// Отладка кода , отслеживание ошибок
// using System;

// namespace project 
// {
//     class program 
//     {
//         public static void Main() 
//         {


// первое для поиска ошибок можно комментировать отдельно строчки кода и пробовать запускать их
// второе можно остановить код на определенной строке , слева нужно нажать на номер строки, такиъ точек можно делать много, 
// код там будет стопариться
// затем код нужно запустить через верхнее меню(а не через терминал) (Выполнить - запустить отладку)


//             string name = "Alex";

//             int[] nums = {5,6,8,23};
//             foreach(int el in nums) 
//                 Console.WriteLine(el);
            






//         }
//     }
// }





// Необязтальные параметры и перегрузка методов

// Необязательные параметры
// using System;

// namespace project 
// {
//     class program 
//     {
//         public static void Main() 
//         {
//             Test1("result",4);
//             Test1("", 4,6);
//             Test1("",4,6,78,8,-10,2);
//             }


//         public static void Test1(string word, params int[] nums){ // нужно указать params и важно чтобы все параметры были с одним типом данных, можно указать массив []
//         // // если нужно прописать еще и обязательные параметры, то их нужно прописывать перед params
//         foreach(int el in nums){
//         System.Console.WriteLine(el);
//         }

//         }
//     }
// }


// Перегрузка методов

// namespace project 
// {
//     class program 
//     {
//         public static void Main() 
//         {
//             int x1 = 5, y1 = 50;
//             AddNumbersInt(x1, y1);

//             float x2 = 5.5f, y2 = 50.56f;
//             AddNumbersFloat(x2, y2);

//             string x3 = "Hello", y3 = " World";
//             AddNumbersString(x3, y3);

//         }
        
//         public static void AddNumbersInt(int a, int b){
//         System.Console.WriteLine(a+b);
//         }

//         public static void AddNumbersFloat(float a, float b){
//         System.Console.WriteLine(a+b);
//         }

//         public static void AddNumbersString(string a, string b){
//         System.Console.WriteLine(a+b);
//         }


//     }
// }

// // Чтобы не писать под каждый тип данных разные методы с разными типами(как выше) данных можно указывать одно и тоже название для методов
// // для разных типов данных, и они не будут конфликтовать, пример ниже:

// namespace project 
// {
//     class program 
//     {
//         public static void Main() 
//         {
//             int x1 = 5, y1 = 50;
//             AddNumbers(x1, y1, "string");

//             float x2 = 5.5f, y2 = 50.56f;
//             AddNumbers(x2, y2);

//             string x3 = "Hello", y3 = " World";
//             AddNumbers(x3, y3);

//         }
        
//         public static void AddNumbers(int a, int b, string c){
//         System.Console.WriteLine(a+b);
//         }

//         public static void AddNumbers(float a, float b){
//         System.Console.WriteLine(a+b);
//         }

//         public static void AddNumbers(string a, string b){
//         System.Console.WriteLine(a+b);
//         }


//     }
// }

// так же с перегрузкой работает например CW ведь в нем мы можем указать и string и переменные с разными типами данных и числа






// Работа со строками и файлами
// Раньше на языке c вместо string(строки) были char [] c массивами , где каждый элемент значил какой то символ, а при слож получ слово
// на текущий момент строка остается так же массивом и по идее мы можем обратиться к каждому отд элементу(символу) отдельно
// Например: string word = "Hello";             System.Console.WriteLine(word[1]);
// Или можем посчитать количество элементов: string word = "Hello";  System.Console.WriteLine(word.Length);

// namespace project 
// {
//     class program 
//     {
//         public static void Main() 
//         {
//             string word = "   Hello   ";
//             // System.Console.WriteLine(word.Length);
//             // System.Console.WriteLine(word.Trim()); // Trim() удаляет лишние пробелы до и после слова Hello
//             // System.Console.WriteLine(word.ToUpper()); // ToUpper переводит все символы в верхний регистр, а ToLower переводит в нижн регистр
//             // // свойство SubString(2) обрезает строку, например на два символа
//             // // можно написать SubString(2, 2) - значит два символа пропускаем и далее два символа берём
//             // System.Console.WriteLine(word.Trim().ToUpper().ToLower().Substring(2,2)); // операторы можно комбинировать
//             // // существует спец класс String

//             word += "!"; // так мы можем добавить в строку !
//             word = String.Concat("He","llo"); // string-это метод, Cancat соединяет строки
            
//             string cars = "BMW/Audi/Mercedes/Volvo"; // мы можем поделить каждый элемент по какому то символу напр / (можно по , или asd)
//             string[] names = cars.Split(new char[]{'/'}); // Split позволяет разделить строку по определенному символу (в нашем случае /)
//             // foreach(var el in names) 
//             //     System.Console.WriteLine(el);

//             string newCars = String.Join(", ",names); // Join наоборот соединяет обратно строки
//             System.Console.WriteLine(newCars);
//         }

//     }
// }



// Работа с директориями , класс DirectoryInfo , ДИРЕКТОРИИ ЭТО ПАПКИ!
// namespace project 
// {
//     class program 
//     {
//         public static void Main() 
//         {
//         DirectoryInfo info = new DirectoryInfo("Test"); // тут выделили память и указали папку Test
//         if(!info.Exists) // Exist нужен, чтобы узнать существует ли такая папка Test , ! - условие если не существует такой папки
//         {                
//             System.Console.WriteLine("Не существует");
//             info.Create();  // create метод нужен, чтобы создалась папка если её нет
//             // // info.Delete() // delete метод нужен, чтобы удалять папки
//         }   
//         else 
//         {
//             string[] files = Directory.GetFiles("Test"); // а тут с помощью метода GetFiles будем перебирать файлы в папке Test
//             foreach(var el in files) // перебираем всё что в папке
//             System.Console.WriteLine(el); // и выводим на экран
//         }
//         }

//     }
// }







// Работа с файлами

// using System;
// using System.IO; // ДЛЯ РАБОТЫ  С ФАЙЛАМИ НУЖНО ПОДКЛЮЧИТЬ ЕЩЕ ОДНО ПРОСТРАНСТВО ИМЁН, io- input output
// // оно подключает классы для работы с файлами

// namespace project 
// {
//     class program 
//     {
//         public static void Main() 
//         {

            
        // FileStream file = new FileStream("info.txt", FileMode.OpenOrCreate); // для работы с файлами исп класс FileStream создаём объект file и выделяем память
        //     // // в круглых скобках указываем параметры, 
        //     // // первый парам - файл с которым будем взаимодействовать file.txt либо можно указать полный путь к файлу - test/info.txt
        //     // // если не указывать полный путь - info.txt, то программа будет искать файл в корневой папке с файлом Program.cs
        //     // // если не указывать полный путь, но указать название, то он создаст файл с указанным названием
        //     // // ВТОРЫМ парам указываем режим открытия самого этого файла - в нашем случае FileMode - это перечисление
        //     // // FileMode - это как будто список из которого мы можем выбрать определенные значения
        //     // // и соответственно после точки указываем выбранное значение
        //     // // Append - позволяет открыть файл и добавлять информацию к уже существующей информации в этом файле
        //     // // Сreate - создаёт новый файл, если он уже существует новый не создаёт
        //     // // Create new - создаёт новый файл даже в том случае если он уже существует, т.е. если файл был он его удалит и создаст новый
        //     // // Open - просто открывают существующий файл, если его не существует, то выдаст ошибку
        //     // // OpenOrCreate - пытается открыть файл, если его не сущ, то он создаст новый
        //     // // Truncate - позволяет открыть файл для его удаления
        // byte[] array = System.Text.Encoding.Default.GetBytes("some");     
        // // МЫ ПРЕОБРАЗОВЫВАЕМ ТЕКСТ В БАЙТЫ, ЭТО НУЖНО ЧТОБЫ МОЖНО БЫЛО ПЕРЕДАТЬ ИНФУ В ФАЙЛ
        // // тут мы обращ к простр имён System(выше указ), далее обр к классу Text
        // // // через кл Text обращ к влож классу Encoding через него обр к Default и дальш обр к методу GetBytes
        // file.Write(array); // обращ-я к файлу и исп метод write - позвол-т вписать какие либо данные, данные нужно указ-ть преобразов-е в байты(см.строкой выше)
        // // // и мы соответств вписали array
        // file.Close(); // файл обязательно необх закрывать, если не будете закр будет утечка памяти и програмка будет тормозить и ломаться
        // // // лучше сразу указывать открытие и закрытие файла, а затем по середите прописывать действия


//         }

//     }
// }



// Практика , работа с файлами

// using System;
// using System.IO;

// namespace project 
// {
//     class program 
//     {
//         public static void Main() 
//         {
//         System.Console.WriteLine("Введите текст");   
//         // // string? user_input = Console.ReadLine() == null ? "" : ""; // ТАК КАК readline может возвращать 0, то после string необх указывать ?
//         // // еще необх указать тернар оператор
//         // // == null ? "" : "" - это тернар оператор, значит если значение 0, то подставл пустую строку, 
//         // // а если не равны 0 то подст др строку(не понятно что подст), ПОЭТОМУ НЕ ПОДХОДИТ ЭТО!

//         // // решили записать вот так:
//         string? user_input = Console.ReadLine() ?? ""; // это альтернатива терн оператору, если
//         // // ?? "" - если знач 0, то подставляем пустую строку


//         // // FileStream file = new FileStream("info.txt", FileMode.OpenOrCreate); 
//         // // // if (user_input != null)   - можно исп усл опер чтобы проверить указано ли что то в user_input 
//         // // // либо можно исп тернар опер(см выше где read line)       
//         // // byte[] array = System.Text.Encoding.Default.GetBytes(user_input);  // желтым подсв, т.к. мы не провер указано ли чтото в user_input
//         // // file.Write(array); 
//         // // file.Close(); 
        
//         // // вместо шести строк выше можно написать проще:
//         // // // за счет конструкции using мы создаём закрытое окруж-е, все что внутри вып выполн-я безопасно и она сама закроет файл в конце
//         // // using(FileStream file = new FileStream("info.txt", FileMode.OpenOrCreate))
//         // // {
//         // //     byte[] array = System.Text.Encoding.Default.GetBytes(user_input);
//         // //     file.Write(array);
//         // // }

//         // // обращаем внимание, что мы переписываем текст, если будет меньше текста, то будут отобр остатки предыдущей записи
//         // // чтобы такого не было используем Append вместо OpenOrCreate , он будет оставлять предыдущ текст и добавлять новый
//         // // если не хотите добавлять то можно исп Truncate - т.к. в нашем случае он всё очистит и добавит новый текст
//         // using(FileStream file = new FileStream("info.txt", FileMode.Truncate))
//         // {
//         // byte[] array = System.Text.Encoding.Default.GetBytes(user_input);
//         // file.Write(array);
//         // }


//         }

//     }
// }


// Работа с файлами, считывание информации

// using System;
// using System.IO;

// namespace project 
// {
//     class program 
//     {
//         public static void Main() 
//         {
        
//     using(FileStream file = File.OpenRead("info.txt")) // выделение памяти тут происходит по другому, File.OpenRead -позволяет открыть файл для чтения
//     {
//         byte[] array = new byte[file.Length]; // тут мы созд массив байтов, выделяем память и обр к его length- длине, с такой длиной массив байтов и создаем получается  
//         file.Read(array); // тут в общем мы считываем данные из file и помещаем в массив array

//         string text = System.Text.Encoding.Default.GetString(array); // ТУТ мы преобразовали эти байты в строку
//         System.Console.WriteLine(text); // ну и соответственно отображаем инф на экране из файла
           
//     }
//         }

//     }
// } 






// Исключения , обработчик исключений

// using System;
// using System.IO;

// namespace project 
// {
//     class program 
//     {
//         public static void Main() 
//         {
//                 int[] nums = {5, 6};
//                 try{
//                 System.Console.WriteLine(nums[3]); // тут мы обратились к несуществующему индексу, ошибка будет появлятся именно во время выполнения самий программы, а не в момент запуска
//                 // именно ошибки, которые возникают во время выполнения программы мы и можем обрабатывать
//                 // в терминале можно увидеть класс, который отслеж эту ошибку - System.IndexOutOfRangeException
//                 } catch(IndexOutOfRangeException ex)  // если будет выявлена ошибка в блоке try, то сработает блок catch и наоборот, Exception - главн класс ошибок, за счет него мы отслеживаем любую возможн ошибку
//                 {
//                 // в нашем случае лучше отследить класс IndexOutOfRangeException, т.к. именно эта ошибка выдавалась в терминале, плюс мы можем создать в нем объект куда будет записываться инф
//                 System.Console.WriteLine($"У нас есть ошибка: {ex.Message}."); // ну и тут выводим инф какую ошибку нашли, не забываем дописывать .Message
//                 }
//         }

//     }
// } 


// Практическое применение обработчика исключений
// using System;
// using System.IO;

// namespace project 
// {
//     class program 
//     {
//         public static void Main() 
//         {
//             try
//             {
//             System.Console.WriteLine("Введите текст: ");
//             int num = Convert.ToInt32(Console.ReadLine());
//             }
//             catch(FormatException) // ну и соотв исп тот же класс, который был в ошибке, запомин их не нужно, можно брать из консоли при возн ошибки
//             // // тут тоже можно было создать объект ex, но тут и так понятно почему возникла ошибка 
//             {  
//                 System.Console.WriteLine("Вы ввели не числоо!!!");
//             }
//         }

//     }
// } 

// // но выше мы не добились от пользователя ввода нужных значений(чисел), поэтому поправим код, и созд отд класс:

// using System;
// using System.IO;

// namespace project 
// {
//     class program 
//     {
//         public static void Main() 
//         {           

//             GetUserInput();
            
//         }
//         public static void GetUserInput() { // создаём новый метод
//             try
//             {
//                 System.Console.WriteLine("Введите первое число: ");
//                 float num1 = Convert.ToSingle(Console.ReadLine());

//                 System.Console.WriteLine("Введите второе число: ");
//                 float num2 = Convert.ToSingle(Console.ReadLine());

//                 if(num2 == 0.0f) // если num2 равен нулю(не забыв про f в конце, т.к. мы работаем с float)
//                     throw new DivideByZeroException(); // тут текст не прописали, т.к. этот класс исп ниже и там текст уже указан

//                 if(num1 < 0 || num2 < 0) // мы можем сами выбрасывать ошибку, допустим когда числа больше нуля
//                     throw new Exception("Числа должны быть больше 0"); // чтобы выбросить свою ошибку исп-м throw, далее выдел-м память, указ тип и указыв отобр-е сообщ

//                 float result = num1 / num2;
                
//                 System.Console.WriteLine($"Result = {result}");
//             }
//             catch(FormatException) 
//             {  
//                 System.Console.WriteLine("Вы ввели не числоо!!!");
//                 GetUserInput(); // ну и даём пользователю повторно ввести значения
//             }
//             catch(DivideByZeroException){ // добавили еще одн исключение, на ноль ведь делить нельзя, условий catch можн использовать сколько угодно
//                 // // DivideByZeroException - будет срабатывать только с типом данных int(c типом float он не сработает)
//                 // // чтобы DivideByZeroException сработал, нужно выбрасывать свою ошибку(см. выше)
//                 System.Console.WriteLine("Вы ввели второе число 0");
//                 GetUserInput();
//             }
//             catch(Exception ex){ // вот такую штуку еще можно прописать, отобразит любую др ошибку
//                 System.Console.WriteLine(ex.Message);
//             }
//             finally {     // то что в блоке finally всегда запустится, неважно была ли ошибка в коде или при вводе данных
//             // например программе нужно поработать в БД и не важно открылась она или нет, но в конце соединение нужно обяз закрыть
//             // в нашем случае напр нам нужно открыть и поработать с опред файлом и если будет ошибка, то файл не закроется,
//             // тут мы как раз и будем в finally указывать чтобы файл закрылся
            
//             }
//         }

//     }
// } 






// Пространство имён - эта та вещь, котор запис-я в в файле сверху, в ней мы указываем к чему будет принадлежать этот конкретный файл
// её можно расценивать как некую папку, в которой может находится множество различных файлов и все эти файлы будут видеть друг друга
// и смогут взаимодействовать друг с другом, просто потомучто будут находится в одной папке в одном простр имён
// внутри одного проекта можно создавать не только одно простр имён и далее их можно подключать внутри других файлов
// мы создали файл some.cs

// using System;
// using System.IO;
// using itproger; // добавили простр имён 

// namespace project; // заметь тут вместо фиг скобок теперь точка с запятой
// class program  // внутри класса program мы можем обращаться к файлу Some.cs
// {
//     public static void Main() 
//     {
//         itproger.Some.Print(); // тут мы обр к классу из др файла и указываем метод и простр имён, т.к. оба класса и оба файла находятся в одн простр имён
//     }

// }

// это должно находиться в другом файле под названием some.cs
// Пространство имён - эта та вещь, котор запис-я в в файле сверху, в ней мы указываем к чему будет принадлежать этот конкретный файл
// её можно расценивать как некую папку, в которой может находится множество различных файлов и все эти файлы будут видеть друг друга
// и смогут взаимодействовать друг с другом, просто потомучто будут находится в одной папке в одном простр имён
// внутри одного проекта можно создавать не только одно простр имён и далее их можно подключать внутри других файлов

// мы создали новый файл some с расширением cs (cs - это расширение c#(с sharp))
// и тут попробуем использовать тоже пространство что и для файла Program.cs

// namespace Project {  // тут мы подкл простр имён и всё что будет прописано в фигурн скобках будет относ к простр имён Project
// }

// // либо можем прописать вот так:
// using System;
// using System.IO;
// // namespace project; // всё что будет написано после будет относ к простр имён Project
// // // меняем простр имён
// namespace itproger;


// class Some // создали новый класс
// {
//     public static void Print() => System.Console.WriteLine("Hello"); // создали новый метод, к нему можно будет обратиться из другого файла, если он в простр имён Project
// }






// Коллекции - можно представить как массивы данных, только коллекции содержат больше функций, возможностей и действий нежели массивы
// Например сначала коллекция сначала может содержать один элемент, а в ходе вып программы может добавиться еще неск элементов
// в обычном массиве если указать, что там 5 элементов, то во время вып программы нельзя добавить шестой элемент, нужно созд нов массив

// стоит понимать, что коллекции сжирают больше оператив памяти, если вам не нужно создавать динамич массивы, куда нужно добавл числа
// то тогда создавайте обычные массивы
// using System;
// using System.Collections; // для работы с коллекциями нужно подкл еще это простр имён, 
// // // оно предоставит дост к классам для описания разных типов коллекций

// namespace project 
// {
//     class program 
//     {
//         public static void Main() 
//         {   
//             List<byte> nums = new List<byte>(); // класс List для раб с колл-и, указ тип данных, далее выделяем память new List<byte>(), тут мы создали пуст коллекцию
//             // // List<byte[]> nums - можно было написать вот так, тогда кажд элемент будет массивом
//             nums.Add(4); // тут мы добавили элемент в коллекцию
//             nums.Add(50);
//             nums.Add(150);
//             nums.Add(5); // после добавл элементов с ними можно работать, см. ниже:

//             // // nums.Insert(0,45); // Insert позволяет вставить элем , сначала указ на какое место по инд потом указ какую цифру
//             // // nums.AddRange(new byte[] { 5, 6, 8 }); // чтобы добавить неск элементов нужно созд массив и исп метод AddRange

//             // // nums.RemoveAll(); - этот метод позволяет удалить все элементы в коллекции
//             // // nums.Remove(50); // этот метод позволяет удалить элемент по его значению(а не по индексу!)
//             // // nums.RemoveAt(0); // удаление элемента по индексу
//             // // nums.RemoveAt(nums.Count-1); // Count подсчитывает все элементы в коллекции(в массивах мы исп-ли Length),
//             // // -1 отнимает последний элемент в коллекции

//             // // nums.Sort(); // метод sort нужен чтобы сортировать элементы по возрастанию
//             // // nums.Reverse(); // этот метод сотрирует элем в обратном порядке
//             // // sort и reverse можно комбинировать, т.е. сначала сортируем, а потом переворачиваем
//             System.Console.WriteLine(nums.Contains(50)); // этот метод(Contains) позволяет находить элем (true или false)

//             nums[0] = 5; // ну и с коллекциями можно работать как с обычн массива(в кв скобк пишем инд и задаём новое знач)
//             System.Console.WriteLine(nums[0]);

//             foreach(byte el in nums) // исп цикл для отобр элементов
//                 System.Console.WriteLine(el);
            
//             // // List<dynamic> nums2 = new List<dynamic>();//тут мы исп тип данных dynamic ,т.к. var исп не можем, тут мы можем исп разные типы данных, ну и выделяем память
//             // // nums2.Add(5);
//             // // nums2.Add(4.5f); // заметь тут разные типы данных
//             // // можно еще записать вот так:
//             List<dynamic> nums2 = new List<dynamic>() {5,7, true, "word",'D'}; // можно элементы добавлять прямо тут
//             nums2.Add(5);
//             nums2.Add(4.5f);

//         }

//     }
// } 


// Коллекции2, другие классы
// разница между разными типами коллекций в том, что они по разному добавляют элемент и вытягивают элемент из коллекции
// коллекции likedlist - он сохраняет для каждого элемента значение предыдущего и значение последующего элемента (во всём остальном это та же коллекция)


// using System;
// using System.Collections;
// namespace project 
// {
//     class program 
//     {
//         public static void Main() 
//         {  
//             LinkedList<string> cars = new LinkedList<string>(); // выделили память и назвали коллекцию
//             cars.AddFirst("BMW"); // добавляет эл в самое начало
//             cars.AddLast("Audi"); // добавл эл в самый конец
//             cars.AddFirst("Volvo"); // снова добавили эл в самое начало
            
//             System.Console.WriteLine(cars.First?.Next?.Next?.Value); // First - берет первый эл, Next - берет след элемент, можно исп по отдельности , ? - нужен т.к. первый эл может быть ноль (просто надо прописать)
//             System.Console.WriteLine(cars.Last?.Previous?.Value); // Last - берёт первый эл, Previous - предыдущий эл, Value - чтобы выводилось значение(если не писать, то будет ошибка)
//             // // System.Console.WriteLine(cars.ElementAt(0)); // в коллек-х нельзя как в массивах обратиться в квадр скобках, чтобы исп cw , тут мы исп ElementAt и указ индекс

//             // // cars.RemoveFirst(); // удаляет перввый эл
//             // // cars.RemoveLast(); // удаляет последний эл
//             // // cars.Remove(); // удаляет эл по индексу


//             // // foreach (var el in cars)
//                 // // System.Console.WriteLine(el);
//         }

//     }
// } 



// Коллекции 3, ArrayList - если в коллекции будут разные типы данных лучше исп его, чтобы не исп List<dynamic>

// using System;
// using System.Collections;
// namespace project 
// {
//     class program 
//     {
//         public static void Main() 
//         {  
//             ArrayList list = new ArrayList(); // тут мы выделяем память, обрати вним-е, что не используются <>
//             list.Add(5); // элементы добавляются также как и в list
//             list.Add(5.5f);
//             list.Add("5");
//             list.Add(new List<int>() {6, 7, 8}); // можно даже добавлять целый список на осн класса List

//             // // list[0] = 4; // изменить элемент по индексу , НУ и остальные действия можно делать как с коллекцией с классом List 
//         }

//     }
// } 





// Коллекции3
// using System;
// using System.Collections; // не забываем подключать неймспейс System.Collections , без него коллекции работать не будут
// // Dictionary - СЛОВАРЬ,  c помощью этого класса мы присвоим для каждого элемента свой индекс
// namespace project 
// {
//     class program 
//     {
//         public static void Main() 
//         {  
//             Dictionary<string, string> people = new Dictionary<string, string>();// сначала указали ключи - string, далее указываю тип данных для каждого конкретного значения, назвали эту коллекцию people и далее выделяем память
//             // так же после скобок можно написать фиг скобки и в них указывать ключи и значения(с новой строчки) стринговые "":"" - внутри ковычек ключ и знач
//             people.Add("alex","Admin"); // внутри ковычек(т.к. это стринг) нужно через запятую указать ключ и значение
//             people.Add("bob","redactor");

//             // System.Console.WriteLine(people["alex"]); // для вывода обращаемся к коллекции и к ключу(алекс)
            
            
//             // people.ContainsKey("alex"); // полезный метод, он метод позволяет находить элемент по ключу, например вот так:
//             // System.Console.WriteLine(people.ContainsKey("alex"));

//             // people.ContainsValue("Admin"); // полезный метод, он метод позволяет находить элемент по значению, например вот так:
//             // System.Console.WriteLine(people.ContainsValue("Admin"));


//             // foreach(string el in people.Keys) // чтобы перебрать ключи нужно писать Keys , чтобы перебрать значения пишем Values
//             // {
//             //     System.Console.WriteLine(el);
//             // }

//             // ну а если мы хотим чтобы воводились все ключи и все значения то пишем:
//             // foreach (KeyValuePair <string,string> el in people) // тут вмест типа данн указыв класс KeyValuePair и внутри<> указ типы данных, но можно было исп var
//             // {
//             //     System.Console.WriteLine(el.Key); // ну и тут мы теперь по др пишем - el.Key вместо el , тут мы обр к ключам
//             //     System.Console.WriteLine(el.Value); // а тут мы обр к значениям
//             // }
//             // но проще написать вот так:
//             foreach (var el in people) // ну а тут мы написали тип данных var , т.к. так проще
//             {
//                 System.Console.WriteLine(el); // а тут мы обр к значениям
//             }

            
            
//             // в будущем мы можем исп коллекции dictionary с разными типами данных, например:
//             Dictionary<bool, char[]> test = new Dictionary<bool, char[]>(); // тут ключи будут true или false, а знач будут массивы
//             test.Add(true, new char[]{'G', 'O'});

//             Dictionary<string, List<int>> test2 = new Dictionary<string, List<int>>(); // тут в значении один эл сделали List(коллекц),а ключ string
//             test2.Add("true", new List<int>{6,7,9}); // ну а тут где list нужно выделить память и сразу указать знач в массиве


//         }

//     }
// } 





// Коллекции4 , очередь
// using System;
// using System.Collections; // не забываем подключать неймспейс System.Collections , без него коллекции работать не будут
// // Queue - очереди, т.е. элементы из коллекции можно вытаскивать только по очереди
// // Stack - стэк, суть такая - первый вошел в коллекцию и первый же вышел, т.е. элементы бы мы получали с конца
// namespace project 
// {
//     class program 
//     {
//         public static void Main() 
//         {  
//             // // Очереди Queue
//             // Queue<string> names = new Queue <string>();
//             // names.Enqueue("Alex"); // обрати внимание тут для добавл эл-в нужно исп метод Enqueue
//             // names.Enqueue("John");
//             // names.Enqueue("Bob");

//             // // names.Peek(); // нужен чтобы выводить эл без его удаления
//             // System.Console.WriteLine(names.Dequeue()); // Dequeue - получ эл и стирает его
//             // // System.Console.WriteLine(names.Peek()); // тут мы бы уже получ эл без его удаления , тут уже будет не алекс а джон
//             // System.Console.WriteLine(names.Dequeue()); 
//             // System.Console.WriteLine(names.Dequeue());


//             // // СТЭК Stack
//             Stack<string> names = new Stack<string>(); // объявили коллекцию и выделили память
//             names.Push("Alex"); // для добавл элементов тут исп метод Push
//             names.Push("John");
//             names.Push("Bob");

//             // System.Console.WriteLine(names.Peek()); // Peek тут тоже только выводит элемент без удаления
//             System.Console.WriteLine(names.Pop()); // Pop как и Dequeue выводит элемент и удаляет его
//             System.Console.WriteLine(names.Pop());
//             System.Console.WriteLine(names.Pop());

//         }   

//     }
// } 







// Делегаты - это объекты , что могут хранить ссылку на какой либо метод
// это что то вроде переменной, где вместо значения мы можем вложить метод, далее мы этот метод можем выполнять
// обычно делегаты описываются вне каких либо методов(иногда даже вне классов)
// часто делегаты используют в качестве параметров в методах
// using System;
// namespace project 
// {
//     class program 
//     {


//         delegate void Message(); // если бы мы в методах принимали string name , то тут тоже нужно было бы указать string name
//         // // delegate - знач мы созд объект куда поместим метод, далее нужно указать точный скелет метода, который мы будем использовать:
//         // // void - возвращаемый тип данных, далее указ любое назв нашего делегата 
//         // // и в конце кругл скобки куда укажем какие парам будет принимать наш делегат
//         // // если бы мы создали еще один метод где нужно принимать данные, то наш делегат(его конструкция) бы не подошел бы для него

//         // // внутрь делегата можно указать сразу несколько методов
//         public static void Main() 
//         {  
//             Message mess; // тут мы созд объект на осн нашего делегата(указыв Message и название объекта)

//             if(DateTime.Now.Hour < 12) // обр к DateTime т.к. он проще чтобы отобр текущ время
//             mess = GoodDay; // ну и тут в объект mess(делегат) устанавливаем(помещаем) метод GoodDay , кругл скобки нужно удалить
//             else
//             mess = GoodNight; // в зависимости от времени записываем в делегат либо метод GoodDay либо метод GoodNight

//             mess += Hello; // с помощью += мы поместили еще один метод внутрь делегата
//             // // чтобы удалить метод из делегата используем -= , например: mess -= Hello;

//             System.Console.WriteLine("Work");
//             mess(); // ну а тут при необх если нужно вывести инф обращаемся просто к нашему делегату и выполняем его как функцию(метод)
//             // // и выводим ту функцию что будет записана внутрь этого делегата
        
//         }   
//         public static void GoodDay(){
//             System.Console.WriteLine("Good day");
//         }
//         public static void GoodNight(){
//             System.Console.WriteLine("Good night");
//         }

//         public static void Hello() => System.Console.WriteLine("Hello");

//     }
// } 


// Делегаты2 , дальше практикуемся
// делегаты часто используют в качестве параметров в методах


// using System;
// namespace project;

// delegate int Action(int x1, int y1); // важно указать какие параметры принимает делегат(назв от перем в методах могут отлич) и возвращ int
// // // обрати внимаение, что делегат ВЫНЕСЕН ЗА ПРЕДЕЛЫ КЛАССА, чтобы его видел метод Calculate, т.е. мы сделали его макс глобальным, его видно будет во всём файле

//     class program 
//     {

//         delegate void Message(); 
//         public static void Main() 
//         {  
        
//             Calculate(5,7, Add); // ВАЖНО! ТУТ мы используем созданный делегат, НУЖНО ТРЕТЬИМ ЧИСЛОМ УКАЗАТЬ МЕТОД чтобы далее отобр ответ
//             Calculate(5,7, Minus);
//             Calculate(5,7, Mult);

//         }   

//         public static void Hello() => System.Console.WriteLine("Hello");

//         public static int Add(int x, int y) => x + y; // создали простой метод который возвращает ответ сложение двух чисел 

//         public static int Minus(int x, int y) => x - y; // создали простой метод который возвращает ответ вычитание двух чисел 

//         public static int Mult(int x, int y) => x * y; // создали метод который возвращ ответ умнож двух чисел

//         // // delegate int Action(int x1, int y1);   // // этот делегат мы вынесли за пределы класса, чтобы его было видно     

//         public static void Calculate (int x, int y, Action action) { // тут мы созд метод который принимает intx inty и ДЕЛЕГАТ и назоваем его action (а не Action как сам делегат)
//         // // теперь в делегат action можно указать какой либо метод (Add, Minus, Mult) и он отобразит ответ на выраж между двумя этими числами
//             System.Console.WriteLine(action(x,y)); // 
//         }

        
//     }






// Методы расширений LinQ -
// они нам позволяют быстро и легко находить нужные нам элементы в различных массивах данных 
// массивы могут быть разные - обычные массивы, коллекции и даже объекты

// сначала мы научимся писать лямдавыражения - маленькие функции(методы)
// по сути лямдавыражение - это когда вы создаете делегат, который ссылается на метод, но только вместо того чтобы ссылаться на созданный-
// -метод мы прописывает сразу же его и прописываем тут
// мы сейчас как раз перепишем методы Hello и метод add (которые закомментированы)

// using System;
// using System.Collections; 
// namespace project 
// {
//     class program 
//     {
//         public static void Main() 
//         {  
//             var hello = () => System.Console.WriteLine("Hello"); // в делегате мы бы прописали просто var hello = Hello (т.е. сослались бы на метод)
//             // hello(); // ну а тут мы используем ранее созданный делегат
//             var add = (int x, int y) => x+y; // ну а тут создали делегат который складыв два числа, вначале в кругл скобках указ , что приним два числа инт(x и y)
//             int res = add(5,8); // тут создали переменную и использовали ранее созданный делеган, а в скобках числа которые нужно сложить
//             System.Console.WriteLine(res); // ну и вывели созданную ранее переменную, которая равна сложению двух чисел
//         }   

//         // public static void Hello() => System.Console.WriteLine("Hello"); // что бы так не писать, можно использовать лямда выражения и писать их внутри др метода
//         // public static int Add(int x, int y) => x+y; // что бы так не писать, можно использовать лямда выражения и писать их внутри др метода

//     }
// } 


// Linq2 практикуемся дальше

// using System;
// using System.Collections; 
// namespace project 
// {
//     class program 
//     {
//         delegate void Mess(string name); // создали делегат, который ничего не возвращает и который принимает string name
//         public static void Main() 
//         {  
//             var hello = () => System.Console.WriteLine("Hello"); 
//             var add = (int x, int y) => x+y; 
//             int res = add(5,8); 
//             System.Console.WriteLine(res); 

//             Mess mess = word => {
//             System.Console.Write(word);// тут пропис, что на основе созд делегата, мы созд объект и тут же создаём используемый метод
//             // если мы принимает один единственный параметр, то кругл скобки можно не указывать
//             // и можно ДАЖЕ НЕ ПРОПИСЫВАТЬ ТИП ДАННЫХ
//             System.Console.WriteLine("!");
//             };  // И ОБЯЗАТЕЬНО ПИСАТЬ ТОЧКУ С ЗАПЯТОЙ ПРИ ЗАКРЫТИИ ФИГ СКОБОК (ОБЫЧНО МЫ ЕЁ НЕ ПИШЕМ!)
//             // если нужно прописать ламдувыражение которое будет состоять из нескольких строчек, то пишем вот так(с фиг скобками)
//             // mess ("Hello");
//             mess (res.ToString()); // ну и тут выводим res, только сначала конвертируем в string
//         }   

//     }
// } 




// LinkQ3
// сначала мы будем исп простые массивы, но в будущем можем исп и коллекции

// using System;
// using System.Collections; 
// using System.Linq; //ПРИ РАБОТЕ С LINQ ОБЯЗАТЕЛЬНО НУЖНО ПОДКЛЮЧАТЬ ЭТО ПРОСТРАНСТВО ИМЁН!
// namespace project 
// {
//     class program 
//     {
//         public static void Main() 
//         { 
//             int[] nums = {5, 7, 4, 30, 45, 3, -2, 57, 7, 9};

//             List<int> list = nums.Where(el => el%2 != 0 && el>=0).ToList(); //ищем нечетные элементы и больше нуля (можно по идее исп циклы для этого, но мы будем исп расширения)
//             // сначала обр к методу Where, далее в кругл скобках указ исп-й фильтр в формате лямдавыражения
//             // сначала указ, что каждый элемент будем перебирать как переменная el, далее указ => и указ-м условие
//             // В КОНЦЕ НЕ ЗАБУДЬТЕ ПРЕОБРАЗОВАТЬ либо в коллекцию .ToList ЛИБО В МАССИВ .ToArray и вначале вместо var list пишем:  List<int> list
//             foreach(int el in list)
//             System.Console.WriteLine(el); // выводим что получилось (по моему кст проще было записать циклами)
//             // System.Console.WriteLine(list); // ну и выводим, что получилось
//         }   

//     }
// } 

// тоже самое можно было записать вот так:
// using System;
// using System.Collections; 
// using System.Linq; //ПРИ РАБОТЕ С LINQ ОБЯЗАТЕЛЬНО НУЖНО ПОДКЛЮЧАТЬ ЭТО ПРОСТРАНСТВО ИМЁН!
// namespace project 
// {
//     class program 
//     {
//         public static void Main() 
//         { 
//             int[] nums = {5, 7, 4, 30, 45, 3, -2, 57, 7, 9};

//             var list = nums.Where(el => el%2 != 0 && el>=0).ToArray(); // тут мы как раз конвертировали в массив
//             foreach(int el in list) // ну и тут указываем что вытаскиваем инф из nums
//             System.Console.WriteLine(el); 
//         }   

//     }
// } 

// или вот так:

// using System;
// using System.Collections; 
// using System.Linq; //ПРИ РАБОТЕ С LINQ ОБЯЗАТЕЛЬНО НУЖНО ПОДКЛЮЧАТЬ ЭТО ПРОСТРАНСТВО ИМЁН!
// namespace project 
// {
//     class program 
//     {
//         public static void Main() 
//         { 
//             int[] nums = {5, 7, 4, 30, 45, 3, -2, 57, 7, 9};

//             nums = nums.Where(el => el%2 != 0 && el>=0).ToArray(); // тут мы как раз конвертировали в массив
//             foreach(int el in nums) // и тут указыв, что вытаскив инфу из nums
//             System.Console.WriteLine(el); 
//         }   

//     }
// } 

// linQ3 , изучаем методы дальше
// using System;
// using System.Collections; 
// using System.Linq; //ПРИ РАБОТЕ С LINQ ОБЯЗАТЕЛЬНО НУЖНО ПОДКЛЮЧАТЬ ЭТО ПРОСТРАНСТВО ИМЁН!
// namespace project 
// {
//     class program 
//     {
//         public static void Main() 
//         { 
//             List<int> nums = new List<int>{5, 7, 4, 30, 45, 3, -2, 57, 7, 9}; // тут лектор решил изменить массив на коллекцию, но с массивами работать точно так же

//             // int res = nums.Where(el => el%2 != 0 && el>=0).Count(); // Count подсчитывает элементы после выборки(Where) //  и вместо List<int> написал просто int list
//             // int res = nums.Where(el => el%2 != 0 && el>=0).Sum(); // Sum - считает сумму элементов после выборки
//             // double res = nums.Where(el => el%2 != 0 && el>=0).Average(); // Average - считает среднее арифметическое, нужно изменить int на double , т.к. Average возвращает double
//             // int res = nums.Where(el => el%2 != 0 && el>=0).Min(); // Min - возвращает минимальн число после выборки
//             int res = nums.Where(el => el % 2 != 0 && el>=0).Max(); // Max - возвращает максимальное число после выборки
//             System.Console.WriteLine(res); // ну и выводим кол-во полученных после выборки чисел
            

//         }   

//     }
// } 

// Продолжаем linq4
// using System;
// using System.Collections; 
// using System.Linq; //ПРИ РАБОТЕ С LINQ ОБЯЗАТЕЛЬНО НУЖНО ПОДКЛЮЧАТЬ ЭТО ПРОСТРАНСТВО ИМЁН!
// namespace project 
// {
//     class program 
//     {
//         public static void Main() 
//         { 
//             int[] nums = {5, 7, 4, 30, 45, 3, -2, 57, 7, 9};

//             // List<int> list = nums.Skip(3).Where(el => el%2 != 0 && el>=0).ToList(); // Skip пропускает первые три элемента
//             // List<int> list = nums.Where(el => el%2 != 0 && el>=0).Skip(3).ToList(); // Skip можно указывать и вначале и в конце

//             // List<int> list = nums.Skip(3).Take(3).Where(el => el%2 != 0 && el>=0).ToList(); // Take выбирает указанное кол-во элементов
//             // List<int> list = nums.Skip(3).Where(el => el%2 != 0 && el>=0).Take(2).ToList(); // Take можно указывать и в начале и в конце (в любом порядке вообще можно)


//             List<int> list = nums.Where(i => i>15).Select(i => i*2 ).OrderBy(i => i).ToList(); // не забываем в конце писать ToList чтобы преобр в колл-ю иначе работать не будет
//             // внутри кругл скобок с Select нужно указать переменную  потом пишем => и что мы с ней делаем (если будет указано просто i=>i то он просто выберет все элементы)
//             // в нашем случае умножаем на два, можно увеличивать на единицу прописав i => i++ и тд(можно еще строковые операции проделывать)
//             // вместо i можно еще записать el , будет одно и тоже
//             // ну и с Where можно делать так же (исп всякие матем действия)
//             // для сортировки исп метод OrderBy() , если написать OrderBy(i => i) , то числа отсортир по увеличению, (i => -i) - то в обратном порядке

//             // List<int> list = nums.Skip(3).ToList(); //Where не обязательно использовать, можно написать так, отобразим все эл кроме первых трёх

            
//             foreach(int el in list)
//             System.Console.WriteLine(el); 
//         }   

//     }
// } 




// Продолжаем linq5 , альтернативные способы записи методов
// using System;
// using System.Collections; 
// using System.Linq; //ПРИ РАБОТЕ С LINQ ОБЯЗАТЕЛЬНО НУЖНО ПОДКЛЮЧАТЬ ЭТО ПРОСТРАНСТВО ИМЁН!
// namespace project 
// {
//     class program 
//     {
//         public static void Main() 
//         { 
//             List<int> nums = new List<int>() {5, 7, 4, 30, 45, 3, -2, 57, 7, 9};

//             // List<int> list = nums.Where(i => i>15).Select(i => i*2 ).OrderBy(i => i).ToList(); // не забываем в конце писать ToList чтобы преобр в колл-ю иначе работать не будет

//             List<int> list = (from el in nums where el % 2 == 0 && el > 0 select el).ToList(); // from in - пишем вместо методов Where , Select
//             // структура from in такая: после from пишем переменную(i или el) , после in пишем с каким массивом мы работаем(nums)
//             // дальше прописываем метод (например select или where) потом пишем условие потом указываем select el(чтобы выбр все элементы)
//             // и конвертируем в ToList  , где select можно еще указать например: el+2 или el*2


//             // List<int> list = nums.Where(i => i>15).Select(i => i*2 ).OrderBy(i => i).ToList();
                 
//             foreach(int el in list)
//             System.Console.WriteLine(el); 
//         }   

//     }
// } 





// Продолжаем linq6 , закрепление знаний
// using System;
// using System.Collections; 
// using System.Linq; //ПРИ РАБОТЕ С LINQ ОБЯЗАТЕЛЬНО НУЖНО ПОДКЛЮЧАТЬ ЭТО ПРОСТРАНСТВО ИМЁН!
// namespace project 
// {
//     class program 
//     {
//         public static void Main() 
//         { 
//             // List<int> nums = new List<int>() {5, 7, 4, 30, 45, 3, -2, 57, 7, 9};
//             // List<int> list = nums.Where(i => i>15).Select(i => i*2 ).OrderBy(i => i).ToList();

//             string[] cars = {"BMW", "Volvo", "Bugatii", "Audi", "Ford", "Alfa Romeo"};
//             cars = cars.Where(i=> i.ToLower().StartsWith("a")).OrderBy(i=>i).ToArray(); //сначала преобр все строки с тачками в нижний регистр ToLower
//             // StartsWith("a") - выбираем слова, которые начинаются на а
//             // ToArray - ну и преобразовали всё это в массив
//             // OrderBy(i=>i) - сортировка, (i=>i) - в нашем случае отсортирует по алфавиту
                 
//             foreach(var el in cars)
//             System.Console.WriteLine(el); 
//         }   

//     }
// } 





// Продолжаем linq7 , объединяем коллекции и массивы воедино
// using System;
// using System.Collections; 
// using System.Linq; //ПРИ РАБОТЕ С LINQ ОБЯЗАТЕЛЬНО НУЖНО ПОДКЛЮЧАТЬ ЭТО ПРОСТРАНСТВО ИМЁН!
// namespace project 
// {
//     class program 
//     {
//         public static void Main() 
//         { 
//             string[] fruits1 = {"Apple", "Orange"}; //точно так же можно было бы использовать коллекции
//             string[] fruits2 = {"Tomato", "Apple"};
//             // var result = fruits1.Except(fruits2); // except удаляет повтор значения 
//             // var result = fruits1.Intersect(fruits2); // Intersect наоборот от exception, оставляет только повторяющиеся значения
//             // var result = fruits1.Union(fruits2); // Union просто объединяет два массива, при этом повторные значения повторно не добавляются
//             // var result = fruits1.Concat(fruits2); // Concat объединяет два массива в том числе и повторяющиеся знач добавляет повторно

//             var result = fruits1.Zip(fruits2, (x,y)=>x+"-"+y); // Zip объединяет два массива,
//             // в zip далее нужно указать функцию, x и y это как будто два наших масива fruits1 и fruits2
//             // далее нужно указать как мы будем добавлять элементы(массивы) x+"-"+y -тут мы добавляем два массива и по середине прописывать девис
//             // ну и получается мы к первому элементу первого массива добавили перв эл второго массива и по середине девис и также со вторыми элементами

//             System.Console.WriteLine(fruits1.All(i=>i.StartsWith("A"))); // All позволяет проверить условие для всех наших элементов в массиве
//             // All(i=>i.StartsWith("A")- проверяет что все элементы начинаются с символа А (true -да , false -нет)

//             System.Console.WriteLine(fruits1.Any(i=>i.StartsWith("A"))); 
//             // Any(i=>i.StartsWith("A") - проверяет что любой элемент начинается с символа А (true -да , false -нет)
                 
//             foreach(var el in result)
//             System.Console.WriteLine(el); 
//         }   

//     }
// } 





// Практическое задание из второго блока!!!!
// Создайте цикл, что сработает 3 раза. Внутри цикла получайте от пользователя информацию. 
// Вам нужно получать от пользователя каждый раз по две строки: первая будет хранить название файла, вторая будет хранить текст для файла. 
// Полученные данные записывайте в коллекцию «Словарь».
// При помощи методов LINQ найдите в словаре лишь те элементы, где ключи начинаются с буквы «q».
// На основе отфильтрованных элементов создайте файлы в проекте. Они должны быть с теми названиями, 
// что указал пользователь и должны содержать тот текст, который также указывал пользователь.



// using System;
// using System.Collections; 
// using System.Linq; 
// using System.IO;
// namespace project 
// {
//     class program 
//     {
//         public static void Main() 
//         { 
        
//         Dictionary<string, string> NewFile = new Dictionary<string, string>();

//         for (int i = 0; i <= 2; i++)
//         {
//             System.Console.WriteLine("Введите название файла");
//             string? FileName = Console.ReadLine();

//             System.Console.WriteLine("Введите текст файла");
//             string? FileText = Console.ReadLine();

//             NewFile.Add($"{FileName}",$"{FileText}");;
//         }

//         var FileStartQ = NewFile.Where(el => el.Key.StartsWith("q"));

//         foreach(var el in FileStartQ)
//         {
//         FileStream file = new FileStream(el.Key, FileMode.Create);

//         byte[] array = System.Text.Encoding.Default.GetBytes(el.Value); 

//         file.Write(array);

//         file.Close();
//         }
            
//         }   

//     }
// } 


// ООП
// Поле и переменная это одно и тоже
// внутри классов поле, вне классов переменные

// Класс в Java - это шаблон для создания объекта, а объект - это экземпляр класса.

// Объект - Если немного упростить, можно сказать, что объект в Java — это область памяти, которая содержит переменные, 
// объявленные в классе (поля класса). Или по-другому — переменные, объединенные в группы.

// Полиморфизм - Один интерфейс - много методов - это когда допустим один метод может принимать разные типы данных и выполнять разные действия

// Наследование - Наследование – это свойство системы, позволяющее описать новый класс на основе уже существующего 
// с частично или полностью заимствующейся функциональностью. Класс, от которого производится наследование, 
// называется базовым или родительским. Новый класс – потомком, наследником или производным классом.

// Инкапсуляция - засекречивание , защита кода от внешнего вмешастельства



// Создание классов и объектов
// Класс - скелет в котором мы можем описать какое то действие или некий объект

// using System;
// using System.Collections; 
// using System.Linq; 
// using System.IO;
// namespace project // т.к. оба класса и person и program в одном простр имён, то дополнительно подкл ничего не нужно
// {
//     class program 
//     {
//         public static void Main() 
//         { 

//     // Обычно в одном файле содержится какой то один основной класс! 
//     // ПОЭТОМУ МЫ ДЛЯ НОВОГО КЛАССА СОЗДАДИМ НОВЫЙ ФАЙЛ Person.cs

//         Person alex = new Person();// СОЗДАЁМ ОБЪЕКТ, сначала в кач-ве типа данных указ класс Person, потом указ название
//         // потом выделяем память(пишем new далее указ какой класс исп и указ () круг скобки), 
//         // если не выделять(написать сразу ;), то мы ничего с этим объектом не сможем сделать
//         // тем самым объект Alex имеет доступ ко всем полям которые указаны в файле Person.cs в классе Person
//         // alex.name = ""; // вот так добавить данные не получиться, нужно сначала добавить модификаторы в исп класс
//         alex.name = "alex"; // после добавления модификатора public в файле и классе Person, можно писать и alex.name = "alex";

//         // существуют модификаторы public, private, protected - их нужно добавлять в класс Person в файле Person.cs
//         // модификатор public - если его прописать в классе, то поля(перем) будут видны как внутри класса так и вне
//         // модификатор private - видно только внутри класса(только внутри класс person в файле person.cs)


//         Person bob = new Person(); // ну и созд еще один объект

//         }

//     }

// } 

// Обычно в одном файле содержится какой то один основной класс! 
// ПОЭТОМУ МЫ ДЛЯ НОВОГО КЛАССА СОЗДАДИМ НОВЫЙ ФАЙЛ Person.cs
// Файлы лучше всегда называть как и классы

// ,но в одном файле можно создавать неск классов, они будут в одн простр имён и можно будет обращаться друг к другу, но это будет путаница




// // Продолжаем практиковаться // создание классов2

// using System;
// using System.Collections; 
// using System.Linq; 
// using System.IO;
// namespace project // т.к. оба класса и person и program в одном простр имён, то дополнительно подкл ничего не нужно
// {
//     class program 
//     {
//         public static void Main() 
//         { 
//         Person alex = new Person();
//         alex.name = "Alex"; // ну и добавляем значения для полей
//         alex.type = "player";
//         alex.age = 25;
//         alex.places.Add("USA", true); // чтобы добавить знач в словарь пишем .Add
//         alex.places.Add("Germany", false);  // в Германии не был, а в США был

//         Person bob = new Person(); 
//         bob.name = "Bob";
//         bob.type = "enemy";
//         bob.age = 35;
//         bob.places.Add("USA", false);

//         // Чтобы вывести инф пишем:
//         System.Console.WriteLine(alex.name); // точно также можно обращаться и к другим полям type age places
//         System.Console.WriteLine(bob.name);
//         }

//     }

// } 






// // Продолжаем практиковаться // создание классов3

// using System;
// using System.Collections; 
// using System.Linq; 
// using System.IO;
// namespace project // т.к. оба класса и person и program в одном простр имён, то дополнительно подкл ничего не нужно
// {
//     class program 
//     {
//         public static void Main() 
//         { 
//         Person alex = new Person();

//         // теперь данные в файле програм в другом классе можно добавлять через метод через запятую, например вот так:
//         Dictionary<string, bool> places = new Dictionary<string, bool>(); // это нужно чтобы добавить внутри alex.SetData() словарь 
//         places.Add("USA", true); // далее добавляем в словарь один элемент и затем его можно будет прописать внутри alex.SetData()
//         alex.SetData("Alex","player",25, places); // т.е. это теперь такой же полноценный метод как и cw 
//         // ,но чтобы добавить Dictionary нужно предварительно его создать(см. выше)
        

//         // после написанного выше написанное ниже(5 строчек) могу закомментировать, т.к. я значения добавлял через метод SetData
//         // alex.name = "Alex"; 
//         // alex.type = "player";
//         // alex.age = 25;
//         // alex.places.Add("USA", true); 
//         // alex.places.Add("Germany", false);  

//         Person bob = new Person(); 
//         bob.name = "Bob";
//         bob.type = "enemy";
//         bob.age = 35;
//         bob.places.Add("USA", false);

//         // Чтобы вывести инф пишем:
//         System.Console.WriteLine(alex.name); // точно также можно обращаться и к другим полям type age places
//         System.Console.WriteLine(bob.name);
//         }

//     }

// } 








// Продолжаем практиковаться // создание классов4
// тут и ранее мы создали класс для пользователей, точно также можно создавать классы для машинок или предметов(деревья, ручка столы и пр.)
// профит в том что все значения для конкретного объекта храняться в одном единств месте, 
// грубо говоря создав 1000 объектов при этом все его возможности и характеристики описаны в единственном классе
// допустим если нам нужно добавить какую то возможность для объектов, то мне не нужно делать это в каждом объекта,
// а мне нужно зайти в класс и добавить туда какую то характеристику (допустим метод какой нибудь) и опишу там функционал
//  и соответственно все объекты будут наследовать этот функционал

// using System;
// using System.Collections; 
// using System.Linq; 
// using System.IO;
// namespace project // т.к. оба класса и person и program в одном простр имён, то дополнительно подкл ничего не нужно
// {
//     class program 
//     {
//         public static void Main() 
//         { 
//         Person alex = new Person();

//         Dictionary<string, bool> places = new Dictionary<string, bool>(); 
//         places.Add("USA", true); 
//         // alex.SetData("Alex","player",25, places);  // теперь places можно убрать, т.к. в Person.cs мы добавили для places знач по умолч (null) 
//         alex.SetData("Alex","player",25);

//         Person bob = new Person(); 
//         bob.SetData("Bob","enemy",35); // точно также как и для alex добавляем значения через новый метод SetData
//         bob.SetAge(30); // ну и добавили возвраст с помощью нового метода SetAge, ну а если установить -10 выведется ошибка

//         // bob.name = "Bob";
//         // bob.type = "enemy";
//         // bob.age = 35;
//         // bob.places.Add("USA", false);

//         System.Console.WriteLine(alex.name); // отображаться всё будет как и раньше, разница только в том, 
//         // что мы устанавливаем знач через отд метод
//         System.Console.WriteLine(bob.name);
//         }

//     }

// } 










// // Конструкторы, модификаторы и аксессоры
// // Конструкторы - это что то вроде методов, только конструкторы вызываются автоматически в момент создания самого объекта
// // Консукторы бывают максимально полезны когда нам необходимо выполнить код сразу же после создания объекта
// // на самом деле все классы содержат конструкторы , вот только эти констр являются конструкторами по умолчанию
// // по этой причине мы их попросту и не видим

// using System;
// using System.Collections; 
// using System.Linq; 
// using System.IO;
// namespace project // т.к. оба класса и person и program в одном простр имён, то дополнительно подкл ничего не нужно
// {
//     class program 
//     {

//         // public program() {} // точно такой же конструктор по умолчанию мы можем создать и в файле program.cs в классе program
//         // // но он нам сейчас особо не нужен, т.к. мы на основе класса program не создаём объекты, а на основе класса Person создали уже
//         public static void Main() 
//         { 
//         Person alex = new Person(); 
//         alex.SetData("Alex","player",25);

//         Person bob = new Person(); 
//         bob.SetData("Bob","enemy",35); 
//         bob.SetAge(-10); 

//         System.Console.WriteLine(alex.name); 
//         System.Console.WriteLine(bob.name);
//         }

//     }

// } 








// // Конструкторы2
// // Конструкторы чаще всего используют для установки значений сразу же после создания объекта

// using System;
// using System.Collections; 
// using System.Linq; 
// using System.IO;
// namespace project // т.к. оба класса и person и program в одном простр имён, то дополнительно подкл ничего не нужно
// {
//     class program 
//     {

//         public static void Main() 
//         { 
//         Person alex = new Person("Alex","player",25); // теперь эти четыре значения передаём тут
//         // Т.К. мы в файле person.cs удалили последний параметр(словарь), то тут мы его тоже передавать уже не будем(удалили)

//         // alex.SetData("Alex","player",25); // ну а т.к. строчкой выше мы передали значения, то эту строчку закомментируем

//         Person bob = new Person(); 
//         bob.SetData("Bob","enemy",35); 
//         bob.SetAge(-10); 

//         System.Console.WriteLine(alex.name); 
//         System.Console.WriteLine(bob.name);
//         }

//     }

// } 







// // Конструкторы3 , тут ничего не меняли, изменения были в Person.cs


// using System;
// using System.Collections; 
// using System.Linq; 
// using System.IO;
// namespace project;

//     class program 
//     {

//         public static void Main() 
//         { 
//         Person alex = new Person("Alex","player",25); 

//         Person bob = new Person(); 
//         bob.SetData("Bob","enemy",35); 
//         bob.SetAge(10); 

//         System.Console.WriteLine(alex.name); 
//         System.Console.WriteLine(bob.name);
//         }

//     }





// // Конструкторы4, , указатель this , тут ничего не меняли, изменения были в Person.cs


// using System;
// using System.Collections; 
// using System.Linq; 
// using System.IO;
// namespace project;

//     class program 
//     {

//         public static void Main() 
//         { 
//         Person alex = new Person("Alex","player",25); 

//         Person bob = new Person(); 
//         bob.SetData("Bob","enemy",35); 
//         bob.SetAge(10); 

//         System.Console.WriteLine(alex.name); 
//         System.Console.WriteLine(bob.name);
//         }

//     }





// // Конструкторы5, указатель this


// using System;
// using System.Collections; 
// using System.Linq; 
// using System.IO;
// namespace project;

//     class program 
//     {

//         public static void Main() 
//         { 
//         Person alex = new Person("Alex","player",25); 

//         Person bob = new Person(); 
//         bob.SetData("Bob","enemy",35); 
//         bob.SetAge(10); 
//         // bob.score = 0; //тут тоже если прописать то будет ошибка, 
//         // -т.к. при исп модиф readonly назначать параметр можно только через констр(при созд объекта)(в файле person.cs)
//         // однако если параметр score исп для вывода в объекте в файле program.cs и написать:
//         System.Console.WriteLine(bob.score); //, тоже всё будет окей, тоесть этот параметр можно использовать для чтения и вывода, 
//         // -но установить значение в score в объекте уже не получиться, будет ошибка

//         System.Console.WriteLine(alex.name); 
//         System.Console.WriteLine(bob.name);
//         }

//     }







// // Конструкторы6, инкапсуляция
// // Инкапсуляция - одно из важнейший концепций ООП - она нам говорит о том, что любые поля что описанны внутри класса-
// // -они должны иметь модификатор доступа как private , а сам доступ к этим полям он должен осуществляться через конструкторы-
// // -либо через методы, что будут описаны внутри самого же этого класса

// // почему существует такая концепция? - она существует потому что если мы имеем прямой доступ к какому либо полю,
// // -то в таком случае мы впринципе в это поле можем записать всё что угодно и при этом мы не имеем никаких дополнительных проверок
// // -при установке значений , но если мы будем для каждого поля создавать отдельный метод по установке значения, то 
// //  в таком случае в каждом этом методе мы можем прописать какие то условные констуркции и просто проверять что конкретно мы
// // пытаемся туда записать и это как бы считается более корректным форматом установки значений нежели просто прямая 
// // подстановка данных как это было у нас до этого

// // // Теперь в файле person.cs во всех ПОЛЯХ меняем public на private

// using System;
// using System.Collections; 
// using System.Linq; 
// using System.IO;
// namespace project;

//     class program 
//     {

//         public static void Main() 
//         { 
//         Person alex = new Person("Alex","player",25);  //НУ И СООТВЕТСТВЕННО МЫ МОЖЕМ ТЕПЕРЬ ЗАДАВАТЬ ЗНАЧЕНИЯ ПОЛЕЙ ТОЛЬКО ЧЕРЕЗ КОНСТРУКТОРЫ
//         System.Console.WriteLine(alex.GetAge()); //поменяли с alex.age на alex.GetAge, т.к. напрямую нельзя обращаться т.к. исп-я private

//         Person bob = new Person(); 
//         bob.SetData("Bob","enemy",35); //ЛИБО ЧЕРЕЗ МЕТОДЫ
//         bob.SetAge(10); 

//         System.Console.WriteLine(alex.GetName()); //И ПОЛУЧАТЬ ДАННЫЕ ТОЖЕ ТОЛЬКО ЧЕРЕЗ МЕТОДЫ
//         System.Console.WriteLine(bob.GetName());
//         }

//     }










// // Конструкторы7, АКСЕССОРЫ

// using System;
// using System.Collections; 
// using System.Linq; 
// using System.IO;
// namespace project;

//     class program 
//     {

//         public static void Main() 
//         { 
//         Person alex = new Person("Alex","player",25);  
//         System.Console.WriteLine(alex.GetAge());
//         alex.PosX = 1; //ну и тут мы устанавливаем значение в аксессор
        
        

//         Person bob = new Person(); 
//         bob.SetData("Bob","enemy",35); 
//         bob.SetAge(10); 

//         System.Console.WriteLine(alex.GetName()); 
//         System.Console.WriteLine(bob.GetName());
//         System.Console.WriteLine(alex.PosX);
//         }

//     }








// Наследование

// using System;
// using System.Collections; 
// using System.Linq; 
// using System.IO;
// namespace project;

//     class program 
//     {

//         public static void Main() 
//         { 
//         Player alex = new Player("Alex", "player", 23, null, "heal");  // тут теперь вместо классa Person указ Player , пока нет констр нельзя внутри кругл скобок задавать знач
//         // -,но т.к. класс насл имеет доступ к полям класса родителя и к аксессорам родителя, то можно прописать вот так:
//         // alex.Age = 233; // ну и тут мы задали возвраст с помощью АКСЕССОРА Age
//         // alex.MagicPower = "heal"; // эту строчку и выше закомментили, т.к. передали знач в () через констр
        
//         alex.GetInfo(); // ну и теперь мы можем выводить с помощью метода GetInfo инфу о персонаже(имя, тип, возр, места) 
//         // несмотря на то что он в родит классе
        
//         Dictionary<string, bool> places = new Dictionary<string, bool>(); //для разнообразия создали словарь
//         places.Add("USA", true); //добавили в словарь пару городов
//         places.Add("Germany", false);
//         Enemy bob = new Enemy("Bob","enemy",35,places); // тут теперь вместо классa Person указ Enemy //и добавили созданный выше словарь сюда(places)
//         // bob.Age = 56;
//         bob.GetInfo();
//         }

//     }











// Наследование2, ПОЛИМОРФИЗМ и МОДИФИКАТОР ДОСТУПА PROTECTED
// ПОЛИМОРФИЗМ - переопределение методов в классах наследниках
// В КЛАССЕ РОДИТЕЛЕ СНАЧАЛА НУЖНО В МЕТОДЕ ПРОПИСАТЬ VIRTUAL , А В ЭТОМ ЖЕ МЕТОДЕ(ОДНОИМЁННОМ) В КЛАССЕ НАСЛЕДНИКЕ НАПИСАТЬ OVERRIDE 
// И МОЖНО ЕГО ИЗМЕНИТЬ , И СООТВЕТСТВЕННО ОДИН И ТОТ ЖЕ МЕТОД СМОЖЕТ ВЫПОЛНЯТЬ РАЗНЫЕ ДЕЙСТВИЯ
// но лучше кардинально метод не менять, чтобы не ломать логику, а добавлять возможно туда доп инфу, если нужен кардинально др метод,
// то лучше создать новый метод

// protected означает что элементы будут доступны только внутри класса и классов наследников, т.е. через объект к нему обр не получится

// using System;
// using System.Collections; 
// using System.Linq; 
// using System.IO;
// namespace project;

//     class program 
//     {

//         public static void Main() 
//         { 
//         Player alex = new Player("Alex", "player", 23, null, "heal");
//         alex.GetInfo(); // И ТЕПЕРЬ ДЛЯ РАЗНЫХ КЛАССОВ ОДИН И ТОТ ЖЕ МЕТОД БУДЕТ ВЫВОДИТЬ РАЗНУЮ ИНФОРМАЦИЮ
        
//         Dictionary<string, bool> places = new Dictionary<string, bool>(); 
//         places.Add("USA", true); 
//         places.Add("Germany", false);
//         Enemy bob = new Enemy("Bob","enemy",35,places); 
//         bob.GetInfo();
//         }

//     }






// // Модификатор доступа static
// // он означает, что поле, конструктор или метод не будут принадлежать к объектам, а они будут принадлежать к классу в целом
// // далее создаём файл Users.cs
// using System;
// using System.Collections; 
// using System.Linq; 
// using System.IO;
// namespace project;

//     class program 
//     {

//         public static void Main() 
//         { 
//         Player alex = new Player("Alex", "player", 23, null, "heal");
//         alex.GetInfo(); 
        
//         Dictionary<string, bool> places = new Dictionary<string, bool>(); 
//         places.Add("USA", true); 
//         places.Add("Germany", false);
//         Enemy bob = new Enemy("Bob","enemy",35,places); 
//         bob.GetInfo();


//         // создаём объект на основе поля count из класса Users
//         // Users user = new Users();
//         // далее мы можем обратиться к этому объекту:
//         // user.count = 50; //ну и присвоили значение объекту //теперь выдаёт ошибку(т.к. в Users.cs для поля прописали модиф дост static)
//         // ошибка возникает, т.к. мы не можем присвоить значение полю через какой то объект
//         // ТАК КАК ДЛЯ ПОЛЯ БЫЛ ПРОПИСАН МОДИФ ДОСТУПА STATIC ТЕПЕРЬ, ЧТОБЫ ПРИСВ ЗНАЧЕНИЕ ПОЛЮ COUNT НУЖНО ПИСАТЬ ТАК:
//         Users.count = 50; //пишем назв класса, далее через точку назв поля и призваиваем значение(=50)

//         }

//     }






// //  Модификатор доступа static2,   Практика

// // сделаем так, чтобы мы могли подсчитывать общее количество созданных объектов на основе класса Person

// // ну и попимо статичных полей можно создавать еще статичные методы(создаём метод в кл Users)
// // созданный метод будет выводить количество всех наших пользователей
// using System;
// using System.Collections; 
// using System.Linq; 
// using System.IO;
// namespace project;

//     class program 
//     {

//         public static void Main() 
//         { 
//         Player alex = new Player("Alex", "player", 23, null, "heal");
//         alex.GetInfo(); 
        
//         Dictionary<string, bool> places = new Dictionary<string, bool>(); 
//         places.Add("USA", true); 
//         places.Add("Germany", false);
//         Enemy bob = new Enemy("Bob","enemy",35,places); 
//         bob.GetInfo();

//         // предварительно в классе PErson в конструкторах прописал Users.count++
//         // и далее выводим, что получили(посчитали скко объектов было создано на основе кл Person):
//         // System.Console.WriteLine(Users.count);
//         // итог: Users.count можно вызывать из любого класса и его значение сохраняется

//         Users.GetCount(); // ну и теперь мы можем получать инф-ю c помощью метода
//         //     ТОЧНО ТАК ЖЕ МЫ ОБРАЩАЕМСЯ К МЕТОДУ System.Console.WriteLine();
//         }

//     }





// //  Модификатор доступа static3, статичн конструкторы, статичные классы
// // статичные классы - любое поле, любой метод, любой конструктор - он должен быть статичным, иначе будет возникать ошибка


// using System;
// using System.Collections; 
// using System.Linq; 
// using System.IO;
// namespace project;

//     class program 
//     {

//         public static void Main() 
//         { 
//         Player alex = new Player("Alex", "player", 23, null, "heal");
//         alex.GetInfo(); 
        
//         Dictionary<string, bool> places = new Dictionary<string, bool>(); 
//         places.Add("USA", true); 
//         places.Add("Germany", false);
//         Enemy bob = new Enemy("Bob","enemy",35,places); 
//         bob.GetInfo();
//         Users.GetCount(); 

//         // Users user = new Users(); // создали объект и выделили память
//         // Users user2 = new Users(); // создали еще один пустой объект (должен сработать констр по умолчанию(пустой))
//         // обрати внимание, что код выполнился лишь один раз, ну и статич констр так и будут работать, если создано неск объектов,
//         // то сработает только один раз
//         // ПОСЛЕ ТОГО КАК КЛАСС USERS СДЕЛАЛИ СТАТИЧНЫМ  4 СТРОЧКИ ВЫШЕ ЗАКОММЕНТИЛИ, Т.К. ОНИ НАЧАЛИ СВЕТИТЬСЯ КРАСНЫМ(ОШИБКА)

//         // // теперь пишем вот так (мы через точку можем обращаться к его различным полям):
//         // Users.count = 0;
//         }

//     }







// //  Модификатор доступа static4


// using System;
// using System.Collections; 
// using System.Linq; 
// using System.IO;
// namespace project;

//     class program 
//     {

//         // в классе program мы тоже можем создавать поля как в др классах, но важно чтобы поля были статичными
//         // private static int score;

//         public static void Main() //в методе main всегда исп static, чтобы программа поняла, что это гл метод, с которого необх запуст прогр
//         // т.е. это стандартный синтаксис для метода Main
//         { 
//                 // score = 50; // ну и тут теперь можем задавать знач для созданного поля
//         Player alex = new Player("Alex", "player", 23, null, "heal");
//         alex.GetInfo(); 
        
//         Dictionary<string, bool> places = new Dictionary<string, bool>(); 
//         places.Add("USA", true); 
//         places.Add("Germany", false);
//         Enemy bob = new Enemy("Bob","enemy",35,places); 
//         bob.GetInfo();
//         Users.GetCount(); 
//         }

//         protected static void GetInfo() {} //создаём новый метод
//         // тут писать static обязательно, т.к. мы не можем из статичного метода обратиться к нестатичному методу или нестатичн полям
//         // ,но если бы метод Main и метод GetInfo были бы нестатичным, то мы бы к нему спокойно обратились

//     }







// // Перечисления
// // это список из которого мы можем выбирать определ значения 
// // они удобны для разраб-в, т.к. мы можем в одном месте описать все возможные варианты и далее мы просто будет обращаться к этому перечислению
// // и через точку находится сразу нужные для нас вариант
// // СНАЧАЛА СОЗДАДИМ ПЕРЕЧИСЛ В ФАЙЛЕ NowDay.cs
// // ЗАТЕМ БУДЕм СОЗД ПЕРЕЧИСЛ В PERSON.CS


// using System;
// using System.Collections; 
// using System.Linq; 
// using System.IO;
// namespace project;

//     class program 
//     {

//         public static void Main() 
//         { 
// // НИЖЕ СТРОЧКИ ВРЕМЕННО ЗАКОММЕНТИРУЕМ //затем вернули всё обратно
//         Player alex = new Player("Alex", PersonType.Player, 23, null, "heal"); // ну а тут вместо "player" нужно написать перечисление
//         alex.GetInfo(); 
        
//         Dictionary<string, bool> places = new Dictionary<string, bool>(); 
//         places.Add("USA", true); 
//         places.Add("Germany", false);
//         Enemy bob = new Enemy("Bob",PersonType.Enemy,35,places); //а тут вместо "enemy" тоже нужно прописать PersonType.enemy
//         bob.GetInfo();

//         Users.GetCount(); 
//         GetInfo();

//         // // обращаемся и присваиваем значение к перечислению вот так: 
//         NowDay nowDay = NowDay.Saturday;
//         nowDay = NowDay.Friday; // а вот так можно переустанавливать значение в перечислении
//         if(nowDay == NowDay.Friday)
//         System.Console.WriteLine("Пора гулять!");
//         else 
//         System.Console.WriteLine("Work");

//         // мы использовали перечисления в FileMode:
//         // FileMode. и выбирали с помощью какого режима нужно открыть файл


//         }

//         protected static void GetInfo() {} 

//     }









// // абстрактные классы
// // в абстрактных классах мы можем создавать абстрактные методы, которые 100% должны быть реализованы в классах наследниках
// // также на основе абстрактных классов мы не можем создавать никаких объектов
// // т.е. он может что либо описывать, но объекты на его основе мы не можем создавать 


// using System;
// using System.Collections; 
// using System.Linq; 
// using System.IO;
// namespace project;

//     class program 
//     {

//         public static void Main() 
//         { 

//         Player alex = new Player("Alex", PersonType.Player, 23, null, "heal"); 
//         alex.Action (); // ну и применяем созданный метод
//         alex.GetInfo(); 
        
//         Dictionary<string, bool> places = new Dictionary<string, bool>(); 
//         places.Add("USA", true); 
//         places.Add("Germany", false);
//         Enemy bob = new Enemy("Bob",PersonType.Enemy,35,places); 
//         bob.Action(); // ну и применяем созданный метод
//         bob.GetInfo();

//         Users.GetCount(); 
//         GetInfo();

 
//         NowDay nowDay = NowDay.Saturday;
//         nowDay = NowDay.Friday; 
//         if(nowDay == NowDay.Friday)
//         System.Console.WriteLine("Пора гулять!");
//         else 
//         System.Console.WriteLine("Work");

//         }

//         protected static void GetInfo() {} 

//     }






// Интерфейсы
// Интерфейсы - они позволяют абстрактно описать  действие и в этом плане они очень схожи с абстрактными классами
// разница в том что абстрактные классы обычно служат для описания какого нибудь большого предмета или большого действия
// а интерфейсы служат для описания чего либо маленького - например просто процесс разговора, тут подойдёт 
// интерфейс и интерфейсы занимают меньше памяти
// НА основе интерфейсов тоже нельзя создавать объекты, интерфейсы содержат лишь описания методов, а их реализация будет уже 
// в классах наследниках
// любой класс может содержать множество интерфейсов,
// если говорить о наследовании, то класс может наследоваться от класса родителя, а с интерфейсами по другоу
// любой класс может иметь множество интерфейсов

// далее мы создаём отдельный файл Italk.cs
// хорошим тоном считается при названии файла первую букву указать большую i (т.е. I) , напр ITalk.cs


// using System;
// using System.Collections; 
// using System.Linq; 
// using System.IO;
// namespace project;

//     class program 
//     {

//         public static void Main() 
//         { 

//         Player alex = new Player("Alex", PersonType.Player, 23, null, "heal"); 
//         // alex.Action (); 
//         // alex.GetInfo(); эти две строчки закомментили(эта и выше)
//         alex.Talk("Hello"); //ну и тут используем созданный ранее метод, у нас не получилось его использ, т.к. мы не прописали его в наследниках, 
//         // минимальная реализация не проканала, мы подкорректировали метод и всё заработало, и еще изменили в аксессоре массив на коллекцию
//         alex.Talk("World"); //грубо говоря тут мы с помощью Talk говорим фразы и каждый раз заносим их в коллекцию и далее отображаем, что занесли
//         alex.Talk("Name");
        
//         System.Console.WriteLine(alex.AllWords()); // этот метод по сути должен нам вернуть строку // обворачиваем его в cw для вывода инф
        
//         // Dictionary<string, bool> places = new Dictionary<string, bool>(); // эту строчку и четыре ниже тоже закомментили
//         // places.Add("USA", true); 
//         // places.Add("Germany", false);
//         // Enemy bob = new Enemy("Bob",PersonType.Enemy,35,places); 
//         // bob.Action(); 
//         // bob.GetInfo();

//         Users.GetCount(); 
//         GetInfo();

 
//         NowDay nowDay = NowDay.Saturday;
//         nowDay = NowDay.Friday; 
//         if(nowDay == NowDay.Friday)
//         System.Console.WriteLine("Пора гулять!");
//         else 
//         System.Console.WriteLine("Work");

//         }

//         protected static void GetInfo() {} 

//     }




// // Интерфейсы IEnumerable и IEnumerator
// // это встроенные интерфейсы, которые есть в языке c#
// // с помощью них мы можем выполнять перебор различных объектов, на основе их и был создан цикл foreach
// // IEnumerable - простой инт , который содержит один метод, который на другой интерфейс IEnumerator 
// // IEnumerator - определяет функционал для перебора всех объектов 
// using System;
// using System.Collections; // подкл это простр имён, т.к. будем исп коллекции

// namespace project;

//     class program 
//     {

//         public static void Main() 
//         { 
//                 string[] cars = {"BMW", "Volvo", "Audi" };

//                 IEnumerator enumarator = cars.GetEnumerator(); 
//                 // создаём переменную и обращаемся к нашему массиву cars , далее обращаемся к методу GetEnumarator
//                 // GetEnumarator метод - позволяет перебрать элементы в каком либо массиве или коллекции, причём он делает это нестандартно
//                 // ,он перебирает элементы причем сохраняет позиции текущего элемента
//                 // ,чтобы посмотреть как это работает мы обр ниже к movenext
//                 // помним, что объект тут сразу создать не получиться, т.к. это интерфейс,
//                 // ,но можно создать переменную и воткнуть туда данные

//                 // Ниже всё закомментили
//                 // enumarator.MoveNext(); // этот метод позволит нам получить первый элемент
//                 // // ну и выводим этот элемент на экран
//                 // System.Console.WriteLine(enumarator.Current); //current значит текущий элемент (тут он выведет БМВ)
//                 // System.Console.WriteLine(enumarator.Current); // тут тоже будет БМВ
//                 // enumarator.MoveNext(); // тут уже получим второй элемент
//                 // // , т.е. мы с помощью интерфейса IEnumarator и методов GetEnumarator и MoveNext перебирать элементы постепенно
//                 // System.Console.WriteLine(enumarator.Current); // а вот тут уже будет вольво(второй эл из массива)


//                 // решили перебрать всё с помощью цикла while:
//                 while(enumarator.MoveNext()){
//        ////             object el = (string)enumarator.Current; // изначально enumarator.Current возвращает нам тип данных object,
//                         // ,но мы его преобразуем в string прописав (string) , еще можно было приписать после Current .string
//                         //в кач-ве перечисления обр к enumarator далее обр к методу moveNext
//                         // moveNext будет постоянно нам возвращать значение true до тех пор пока у нас будут еще элементы
//                         // как только у нас элементов уже не будет, то соответственно он вернёт нам значение false
//                         // ну и мы выйдем полностью из этого цикла

//                         System.Console.WriteLine(el);

//                         // если вы хотите начать список с самого начала, то прописываем условие:.
//                         if(Console.ReadKey().Key==ConsoleKey.Tab)
//                                 enumarator.Reset();
//                         // от пользователя будем получать некий символ, этот же символ мы будем проверять, если это будет R
//                         // , то обр к enumarator и далее обр к методу reset , который начнёт список с самого начала
//                 } 

                
//         }

//     }






// // Интерфейсы IEnumerable и IEnumerator 2
// // сначала создали новый файл и новый класс: Cars.cs

// using System;
// namespace project;

//     class program 
//     {

//         public static void Main() 
//         { 
//                 // теперь мы можем создать объект
//         Cars cars = new Cars ();
//         // теперь объект cars мы можем перебрать с помощью foreach
//         foreach(var el in cars )
//         System.Console.WriteLine(el);

// // ГРУБО ГОВОРЯ МЫ СОЗДАЛИ КЛАСС CARS И ПЕРЕПИСАЛИ МЕТОД GetEnumarator и теперь тут мы можем перебирать значения в объекте с помощью foreach
//         }

//     }






// // События
// // Позволяют указать системе, что произошло некое действие, и нам нужно выполнить тоже соответствующее действие, т.к. что то произошло
// // ДАЛЕЕ создаём новый класс player.cs (в нашем случае он уже существует, мы просто туда вписываем инфу)

// using System;
// namespace project;

//     class program // это основной класс
//     {

//         public static void Main()  
//         { 
//                 // создаём объект на осн класса player.cs
//         Player player1 = new Player();
//         player1.ActionHealth += DisplayMess;
//         player1.Damage(50); // отнимаем с помощью метода из класса player.cs 50 жизней
//         player1.Heal(20); // далее лечим его на 20 жизней

//         // обычно для событий используются делегаты(это что то вроде переменных в которых содержаться методы, 
//         // т.е. в зависимости от разных получаемых данных будут использоваться различные методы)
//         // далее мы идём в класс player.cs и создаём делегат

//         // в нашем случае вместо простого отображения cw о состоянии здоровья внутри метода Heal или Damage мы решили использовать делегат,
//         // , т.к. бывают случаи когда для всех игрокой данный метод оповещения о состоянии здоровья не подойдёт и нужно выполнять еще
//         // какие то действия

//         // создаём еще один объект:
//         Player player2 = new Player();
//         player2.ActionHealth += DisplayMessGreen;
//         player2.Damage(50); // отнимаем с помощью метода из класса player.cs 50 жизней
//         player2.Heal(20);
//         }

//         // создаём еще один метод:
//         // созд публичный статичный метод, который ничего возвр не будет, кот будем вызывать из метода Main
//         // ВАЖНО: МЕТОД ДОЛЖЕН СОВПАДАТЬ С ДЕЛЕГАТОМ - НИЧЕГО НЕ ВОЗВРАЩАЕТ (VOID) , ПРИНИМАЕТ ОДИН ПАРАМЕТР (INT HEALTH)
//         public static void DisplayMess(int health) //принимать будет один парам int health(текущ уров жизни)
//         { 
//                 System.Console.WriteLine($"Жизнь игрока: {health}");
//         }
//         // далее идём на след строчку после: Player player1 = new Player();


// // после создания второго объекта создани второй метод:
//         public static void DisplayMessGreen(int health)
//         { 
//                 Console.BackgroundColor = ConsoleColor.Green;
//                 System.Console.WriteLine($"Жизнь игрока: {health}");
//         }

//     }


// // ИТОГ: 
// // мы создали объект на осн класса player затем указали событие которое с помощью делегата предварительно создали в классе player
// // это событие поместили внутрь методов Heal и Damage, и когда мы обращаемся к этим методам мы просто говорим, что 
// // это событие сработало 

// // далее мы тут создали два метода, которые выводят поле(или переменную(я так и не понял)) health

// // и таким сложным хитросплетением получится, что каждый раз обращаясь к методам Heal или Damage у нас будет
// // выводиться текущее значение поля(или переменной(я так и не понял))

// // ну и можно сделать так чтобы для разных объектов на осн одного класса вызывался разный метод(наверно это главная идея)





// // ЗАДАНИЕ классы и объекты в c#

// using System;
// namespace project;

// class program 
// {
// public static void Main()  
// { 
// Player bot = new Player();
// Player alex = new Player(Variants.Paper, "Alex");

// WhoWin(bot, alex);

// System.Console.WriteLine("Чтобы запустить игру снова нажмите таб, чтобы выйти нажмите любую другую клавишу");
// if(Console.ReadKey().Key == ConsoleKey.Tab)
// Main();

// }

// public static void WhoWin(Player bot, Player alex)  
// {
//         if (bot.type == Variants.Paper && alex.type == Variants.Scissors || bot.type == Variants.Rock && alex.type == Variants.Paper 
//         || bot.type == Variants.Scissors && alex.type == Variants.Rock ) {
//                 System.Console.WriteLine($"Player: {alex.name} win");}
        
//         else if (bot.type == Variants.Paper && alex.type == Variants.Paper || bot.type == Variants.Rock && alex.type == Variants.Rock 
//         || bot.type == Variants.Scissors && alex.type == Variants.Scissors)
//                 System.Console.WriteLine("Equal");

//         else
//         System.Console.WriteLine("Alex lose");
// }

// }






// // Операторы is as
// // сначала создали кл person.cs далее создали кл player.cs и он наследует всё от кл person.cs

// using System;
// namespace project;

// class program 
// {
// public static void Main()  
// { 
// // создаём объ на осн кл person.cs:
// // Person person = new Person(); //помимо этого мы можем использовать АП КЭСТИНГ(UpCasting),
// // суть такова, что для создания объ мы можем исп кл родитель(person.cs), а для выделения памяти можем исп кл наследн(player)
// // тут объ создаётся на осн класса person, но конструктор будет исп, который находится в кл player:
// Person person = new Player(); // UpCasting
// // // также используя эту же логику мы можем исп тип данных object 
// // object - тип данных в c# , по сути это как бы основной класс на основе которого строятся все другие типы данных
// // и на основе которого строятся все наши собственные классы, т.е. object это как класс родитель как самый топовый класс родитель
// // , который есть в языке c#
// // поскольку object это самый топовый класс родитель от которого вообще всё наследуется, 
// // то в таком случае мы можем создать еще некий объект:
// object person1 = new Player(); // указываем, что объ создаётся на осн типа данных object, при этом в кач-ве
// // конструктора мы можем исп Person (,но если захочу могу исп и Player либо любой др кл)

// // существует также противоположное действие, оно называется ДАВН КЭСТИНГ(DownCasting):
// // Player player = new Player(); // создаём объ, выдел память
// // , НО ВМЕСТО выделения памяти мы можем указать то что сюда будет помещаться объект person(созданный выше):
// // Player player = person; //тут у нас возникает ошибка, ведь объ person создан на осн более высокого класса(Person)
// // и при этом мы пытаемся его записать в кл более низкий, кот по сути явл насл 
// // соответственно пишем теперь вот так:
// Player player = (Player)person; // DownCasting
// // тут мы перед объектом указываем приведение типа,
// // и в качестве типа мы указываем то что мы приводим наш объ person к такому типу как Player


// }

// }





// // Операторы is as2


// using System;
// namespace project;
// using System.Collections;

// class program 
// {
// public static void Main()  
// { 
// Person person = new Player(); // UpCasting
// object person1 = new Player(); 

// Player player = (Player)person; // DownCasting

// // создаём коллекцию на осн класса person, которая будет в себе содержать различные элементы различные объекты на осн
// // либо класса person либо кл player , далее перебирём их через цикл и будем использовать ЭТИ СПЕЦИАЛЬНЫЕ ОПЕРАТОРЫ(IS AS)
// List<Person> people = new List<Person>();
// people.Add(person); //так мы добавляем объекты в коллекцию poeple, сначала добавили объект person
// people.Add(player);
// people.Add((Person)person1); // тут перед person1 добавляем (Person) , т.е. исп down casting, иначе будет выдавать ошибку
// people.Add(new Player()); // тут мы добавл объ на осн кл player
// // далее мы создаём новый файл Enemy.cs (он у нас уже есть, мы просто в него переходим)
// people.Add(new Enemy()); //теперь добавл объ в коллекц на осн кл Enemy
// people.Add(new Enemy());
// people.Add(new Person());

// // далее создаём цикл, чтобы перебрать эл
// foreach(var el in people) {
//         System.Console.WriteLine(el.GetType()); // ну и сначала мы перебираем все элементы и через точку обр к методу GetType для получ типа объ
// }
// // далее запускаем код и замечаем, что все объекты отображ на осн кл Player(кроме посл-х 3-х), т.к. мы исп конструкторы кл Player
// }

// }





// // Операторы is as3
// ОПЕРАТОР is


// using System;
// namespace project;
// using System.Collections;

// class program 
// {
// public static void Main()  
// { 
// Person person = new Player(); // UpCasting
// object person1 = new Player(); 

// Player player = (Player)person; // DownCasting

// List<Person> people = new List<Person>();
// people.Add(person);
// people.Add(player);
// people.Add((Person)person1); 
// people.Add(new Player()); 

// people.Add(new Enemy()); 
// people.Add(new Enemy());
// people.Add(new Person());


// foreach(var el in people) {
//         // сейчас воспользуемся оператором is
//         // if(el is Enemy) //если элемента на осн класса player , то мы его будем выводить // 
//         // System.Console.WriteLine(el.GetType()); 
//         // НО, если прописать Person вместо Player или Enemy, то выведутся все элементы, т.к. они созд на осн кл Person
//         // if(el is Person) // также можно было написать object, т.к. он класс родитель всех других классов
//         // можно еще написать is not Person (т.е. не на осн кл Person):
//         if(el is not Enemy) 
//         System.Console.WriteLine(el.GetType()); 

//         // можно еще вот такую проверку сделать:
//         // if("5" is string) // проверять является ли "5" стрингом
// }
// }

// }





// Операторы is as4
// оператор AS


// using System;
// namespace project;
// using System.Collections;

// class program 
// {
// public static void Main()  
// { 
// Person person = new Player(); // UpCasting
// object person1 = new Player(); 



// // Player player = (Player)person; // DownCasting
// // за счёт оператора as мы можем выполнять приведение типов
// // двумя строчками выше мы приводили типы при помощи круглых скобок( (Player)person) ), а можно прописать вот так:
// Player? player = person as Player; // это означ, что мы работаем с объ person как с объектом на осн класса Player
// // не забываем про ? , т.к. мы можем принять знач 0 (еще ниже надо прописать ?? new Player() (описание ниже))


// List<Person> people = new List<Person>();
// people.Add(person);
// // people.Add(player); // тут тоже надо прописать вот так:
// people.Add(player ?? new Player()); //это значит, что если тут(в player) значение 0, то в таком случае мы просто будем сюда
// // подставлять пустой объект на основе кл Player

// people.Add((Person)person1); 
// people.Add(new Player()); 

// people.Add(new Enemy()); 
// people.Add(new Enemy());
// people.Add(new Person());


// foreach(var el in people) {
//         if(el is not Enemy) 
//         System.Console.WriteLine(el.GetType()); 
// }
// }

// }








// Структуры данных
// Структуры данных максимально схожи с классами, только они служат для описания чего либо маленького

// создаём файл Computer.cs

// using System;
// namespace project;

// В итоге я решил спросить что такое структуры у чата gpt и прислать мне примеры, ниже будет объяснение и примеры:

// В C# структура (struct) является пользовательским типом данных, 
// который позволяет объединить несколько переменных разных типов данных в одну единицу.

// Структуры могут быть полезны в следующих случаях:

// Когда нужно хранить небольшое количество данных и не хочется создавать отдельный класс для этого
// Когда нужно передавать данные между методами и 
// функциями в качестве единой единицы, например, для передачи нескольких значений из одного метода в другой
// Когда нужно определить тип данных для работы с низкоуровневыми операциями, например, с байтами или битами
// Вот несколько примеров использования структур в C#:

// Определение структуры для представления точки в двумерном пространстве:
// arduino
// Copy code
// struct Point {
//    public int X;
//    public int Y;
// }
// Определение структуры для представления даты:
// arduino
// Copy code
// struct Date {
//    public int Day;
//    public int Month;
//    public int Year;
// }
// Определение структуры для представления прямоугольника:
// arduino
// Copy code
// struct Rectangle {
//    public int Width;
//    public int Height;
//    public Point TopLeft;
// }
// Здесь мы можем использовать предыдущую структуру Point 
// внутри структуры Rectangle для представления координат верхнего левого угла прямоугольника.

// Структуры также могут иметь методы и конструкторы, которые позволяют упростить работу с данными, хранящимися внутри структуры.




// alminashakurova@gmail.com
// зачем использовать struct если можно использовать class?
// Хотя структуры и классы могут выполнять многие из одинаковых функций в C#, 
// есть несколько причин, почему можно использовать структуры вместо классов в некоторых случаях:

// Экономия памяти: объекты классов хранятся в куче, 
// а объекты структур хранятся в стеке или в куче в зависимости от того, 
// где они определены и как они используются. Поскольку объекты в стеке выделяются намного быстрее, чем объекты в куче, 
// использование структур может быть более эффективным с точки зрения памяти.

// Семантика значения: когда объект структуры передается в метод или функцию, 
// он передается по значению, что означает, что происходит копирование всей структуры, 
// а не ссылки на нее. Это может быть полезно в тех случаях, когда требуется работать с объектами, которые должны быть уникальными.

// Иммутабельность: структуры по умолчанию являются неизменяемыми, 
// что означает, что их значения не могут быть изменены после создания. 
// Это может быть полезно в тех случаях, когда нужно убедиться, 
// что данные не будут изменены, что может снизить риск ошибок программирования и упростить программу.

// Однако структуры также имеют свои ограничения. 
// Например, они не могут наследоваться, не могут содержать конструкторов, которые не принимают параметры, 
// и не могут быть упакованы или распакованы. Кроме того, они не могут использоваться для создания иерархии объектов.

// В целом, использование структур или классов зависит от конкретной задачи, которую вы решаете. 
// Если вы работаете с небольшими наборами данных и хотите сэкономить память или использовать семантику значения, 
// то структуры могут быть хорошим выбором. Если же вы работаете с более сложными объектами, 
// которые должны наследоваться или иметь конструкторы, то классы будут лучшим выбором.



// Сериализация данных

// Сериализация данных в C# - это процесс преобразования объектов в формат, 
// который можно сохранить в файле или передать по сети, чтобы потом восстановить объекты из этого формата. 
// В C# есть несколько способов сериализации данных, но в основном это делается с помощью библиотеки System.Runtime.Serialization, 
// System.Text.Json, или System.Xml.Serialization.

// Вот примеры кода для сериализации объектов в формат JSON, XML и бинарный формат, и последующей их десериализации:

// Сериализация в JSON:

// csharp
// Copy code
// using System.Text.Json;

// public class Person
// {
//     public string Name { get; set; }
//     public int Age { get; set; }
// }

// Person person = new Person { Name = "John", Age = 30 };
// string json = JsonSerializer.Serialize(person);
// Здесь мы создаем класс Person с двумя свойствами - Name и Age. 
// Затем мы создаем экземпляр класса Person и заполняем его значениями. 
// После этого мы сериализуем объект в JSON-формат с помощью метода JsonSerializer.Serialize() 
// и сохраняем результат в строковую переменную json.

// Десериализация из JSON:

// csharp
// Copy code
// Person deserializedPerson = JsonSerializer.Deserialize<Person>(json);
// Здесь мы десериализуем JSON-строку json в объект типа Person с помощью метода JsonSerializer.Deserialize(). 
// Результат сохраняется в переменной deserializedPerson.

// Сериализация в XML:

// csharp
// Copy code
// using System.Xml.Serialization;

// public class Person
// {
//     public string Name { get; set; }
//     public int Age { get; set; }
// }

// Person person = new Person { Name = "John", Age = 30 };
// XmlSerializer serializer = new XmlSerializer(typeof(Person));
// using (var stream = new StreamWriter("person.xml"))
// {
//     serializer.Serialize(stream, person);
// }
// Здесь мы создаем класс Person с двумя свойствами - Name и Age. 
// Затем мы создаем экземпляр класса Person и заполняем его значениями. 
// После этого мы сериализуем объект в XML-формат с помощью класса XmlSerializer и метода Serialize(). 
// Результат сохраняется в файл person.xml.

// Десериализация из XML:

// csharp
// Copy code
// using System.Xml.Serialization;

// Person deserializedPerson;
// XmlSerializer serializer = new XmlSerializer(typeof(Person));
// using (var stream = new StreamReader("person.xml"))
// {
//     deserializedPerson = (Person)serializer.Deserialize(stream);
// }
// Здесь мы создаем переменную deserializedPerson, в которую мы будем десериализовывать данные. 
// Затем мы создаем экземпляр класса XmlSerializer с типом Person и десериализуем данные из файла person.xml с помощью метода Deserialize(). 
// Результат сохраняется в переменной deserializedPerson.

// Сериализация в бинарный формат:

// csharp
// Copy code
// using System.IO;
// using System.Runtime.Serialization.Formatters.Binary;

// public class Person
// {
//     public string



// alminashakurova@gmail.com
// допиши пожалуйста
// using System.IO;
// using System.Runtime.Serialization.Formatters.Binary;

// public class Person
// {
// public string Name { get; set; }
// public int Age { get; set; }
// }

// Person person = new Person { Name = "John", Age = 30 };
// BinaryFormatter formatter = new BinaryFormatter();
// using (var stream = new FileStream("person.bin", FileMode.Create))
// {
// formatter.Serialize(stream, person);
// }

// go
// Copy code

// Здесь мы создаем класс `Person` с двумя свойствами - `Name` и `Age`. 
// Затем мы создаем экземпляр класса `Person` и заполняем его значениями. 
// После этого мы сериализуем объект в бинарный формат с помощью класса `BinaryFormatter` и метода `Serialize()`. 
// Результат сохраняется в файл `person.bin`.

// Десериализация из бинарного формата:

// ```csharp
// using System.IO;
// using System.Runtime.Serialization.Formatters.Binary;

// Person deserializedPerson;
// BinaryFormatter formatter = new BinaryFormatter();
// using (var stream = new FileStream("person.bin", FileMode.Open))
// {
//     deserializedPerson = (Person)formatter.Deserialize(stream);
// }
// Здесь мы создаем переменную deserializedPerson, в которую мы будем десериализовывать данные. 
// Затем мы создаем экземпляр класса BinaryFormatter и десериализуем данные из файла person.bin с помощью метода Deserialize(). 
// Результат сохраняется в переменной deserializedPerson.

// Каждая строчка кода в примерах имеет следующий смысл:

// using System.Text.Json; 
// - подключаем пространство имен, содержащее классы для работы с JSON-сериализацией и десериализацией данных.

// public class Person { public string Name { get; set; } public int Age { get; set; } } 
// - создаем класс Person с двумя свойствами - Name и Age.

// Person person = new Person { Name = "John", Age = 30 }; 
// - создаем экземпляр класса Person и заполняем его значениями.

// string json = JsonSerializer.Serialize(person); 
// - сериализуем объект person в JSON-строку с помощью метода JsonSerializer.Serialize(). 
// Результат сохраняется в переменную json.

// Person deserializedPerson = JsonSerializer.Deserialize<Person>(json); 
// - десериализуем JSON-строку json в объект типа Person с помощью метода JsonSerializer.Deserialize(). 
// Результат сохраняется в переменной deserializedPerson.

// using System.Xml.Serialization; 
// - подключаем пространство имен, содержащее классы для работы с XML-сериализацией и десериализацией данных.

// XmlSerializer serializer = new XmlSerializer(typeof(Person)); 
// - создаем экземпляр класса XmlSerializer с типом Person.

// using (var stream = new StreamWriter("person.xml")) { serializer.Serialize(stream, person); } 
// - открываем файл person.xml для записи и сериализуем объект person в XML-формат с помощью метода Serialize().










// SOLID

// Вот краткий обзор каждого из пяти принципов SOLID:

// Single Responsibility Principle (Принцип единственной ответственности) - класс должен иметь только одну причину для изменения. 
// То есть каждый класс должен быть ответственен только за одну конкретную задачу или функцию.

// Open/Closed Principle (Принцип открытости/закрытости) - программные сущности должны быть открыты для расширения, 
// но закрыты для изменения. Это означает, что вы можете добавлять новые функции или поведения к существующему коду, не изменяя его.

// Liskov Substitution Principle (Принцип подстановки Лисков) - объекты в программе должны быть заменяемы друг на друга без изменения 
// корректности программы. Это означает, что подклассы должны быть взаимозаменяемы с их суперклассами.

// Interface Segregation Principle (Принцип разделения интерфейсов) - клиенты не должны зависеть от интерфейсов, 
// которые они не используют. Это означает, что вместо создания одного большого интерфейса, вы должны создавать 
// много маленьких интерфейсов, каждый из которых будет иметь только те методы, которые необходимы клиентам.

// Dependency Inversion Principle (Принцип инверсии зависимостей) - зависимости в коде должны зависеть от абстракций, 
// а не от конкретных реализаций. Это означает, что вы должны использовать интерфейсы и абстрактные классы для описания зависимостей, 
// а не конкретные классы.

// Соблюдение принципов SOLID помогает создавать более гибкий, расширяемый и легко поддерживаемый код. 
// Эти принципы также помогают избежать некоторых распространенных проблем в программировании, 
// таких как сложные зависимости, жесткая связность и хрупкость кода.








// REF
// ref в C# - это ключевое слово, которое используется для передачи параметра метода по ссылке, а не по значению. Это означает, что изменения, внесенные в параметр внутри метода, будут видны за его пределами.

// Например, предположим, что у нас есть метод Increment, который принимает число и увеличивает его на единицу:

// csharp
// Copy code
// static void Increment(int x)
// {
//     x++;
//     Console.WriteLine($"Значение x внутри метода: {x}");
// }
// Если мы вызовем этот метод с аргументом 5, то результат будет выглядеть так:

// csharp
// Copy code
// int x = 5;
// Increment(x);
// Console.WriteLine($"Значение x после вызова метода: {x}");
// Copy code
// Значение x внутри метода: 6
// Значение x после вызова метода: 5
// Значение переменной x внутри метода увеличилось на единицу, 
// но значение переменной x в вызывающем коде не изменилось. Это произошло из-за того, что параметр x был передан методу по значению.

// Теперь давайте посмотрим, что произойдет, если мы изменим метод Increment и будем использовать ключевое слово ref при передаче параметра:

// csharp
// Copy code
// static void Increment(ref int x)
// {
//     x++;
//     Console.WriteLine($"Значение x внутри метода: {x}");
// }
// Теперь, если мы вызовем метод Increment с аргументом 5, 
// то результат будет выглядеть так:

// csharp
// Copy code
// int x = 5;
// Increment(ref x);
// Console.WriteLine($"Значение x после вызова метода: {x}");
// Copy code
// Значение x внутри метода: 6
// Значение x после вызова метода: 6
// Теперь значение переменной x в вызывающем коде также увеличилось на единицу. 
// Это произошло из-за того, что параметр x был передан методу по ссылке с помощью ключевого слова ref.




// Обощение классов

// Конечно, вот еще один пример:

// В C# есть механизм наследования, который позволяет определить новый класс, 
// который наследует все свойства и методы существующего класса, называемого базовым классом. 
// Это позволяет сократить дублирование кода и улучшить его переиспользуемость.

// Когда класс наследует другой класс, он может переопределить методы базового класса или добавить 
// свои собственные методы и свойства. Это называется расширением класса.

// Однако, иногда требуется создать класс, который наследует от нескольких базовых классов. 
// Это называется множественным наследованием, которое в C# не поддерживается. 
// Вместо этого в C# используется механизм обобщения классов и методов.

// Обобщение класса позволяет определить класс, который может использоваться с разными типами данных. 
// Для этого определяется обобщенный тип данных с использованием ключевого слова T. 
// Затем этот тип данных может быть использован в определении свойств, методов и конструкторов класса.
// public class Pair<T1, T2>
// {
//     public T1 First { get; set; }
//     public T2 Second { get; set; }

//     public Pair(T1 first, T2 second)
//     {
//         First = first;
//         Second = second;
//     }
// }
// Этот класс определяет пару значений, где T1 и T2 могут быть любыми типами данных. 
// Класс содержит свойства First и Second, которые представляют первый и второй элементы пары соответственно. 
// Также в классе определен конструктор, который принимает два параметра типа T1 и T2 и инициализирует свойства First и Second.

// Можно создать экземпляр класса Pair<T1, T2> с использованием конкретных типов данных, например:

// Pair<string, int> pair = new Pair<string, int>("Hello", 123);
// Console.WriteLine(pair.First); // выводит "Hello"
// Console.WriteLine(pair.Second); // выводит 123
// Этот код создает экземпляр класса Pair<string, int>, который представляет пару значений типа string и int. 
// Свойства First и Second могут быть получены для этого экземпляра так же, как и для любого другого экземпляра класса Pair<T1, T2>.






// потоки данных

// using System;
// using System.Threading;
// namespace project;

// class Program 
// {
//         public static void Main()
//         {
//                 System.Console.WriteLine("Sleep");
//                 Thread.Sleep(2500); //sleep останавливает программу на указанное количество секунд
//                 System.Console.WriteLine("Start");
//         }
// }
// тут у нас просто программа показывает сообщение затем останавливается на указанное время затем снова показывает сообщение



// using System;
// using System.Threading;
// namespace project;

// class Program 
// {
//         public static void Main()
//         {
//                 Thread tread = new Thread(Print); // обр к методу Thread, создаём поток, назыв его, внутри указываем исп метод, но без скобок
//                 tread.Start(); //ну и запускаем поток


//                 for(int i = 0; i < 5; i++)
//                 {
//                         Thread.Sleep(500); //перед запуском осн программы останавливаем на 500 милисек
//                         System.Console.WriteLine(i);
//                 } 

//                 // Print();
//         }

//         public static void Print(){
//                 {
//                 for(int i = 0; i < 5; i++)
//                 {
//                         Thread.Sleep(500); // ну и сюда тоже самое бахнули
//                         System.Console.WriteLine($"El: {i}");
//                 } 
//         }
//         }
// }

// // ну и в итоге мы увидим что постепенно друг за другом выполняется цикл





// // TPL - параллельное программирование

// using System;
// using System.Threading;
// using System.Threading.Tasks; // для работы с TPL нужно подключать эту библиотеку
// namespace project;

// class Program 
// {
//         public static void Main()
//         {
//                 Task task = new Task(Print); //внутри скобок указ какой метод будем исп
//                 task.Start();// чтобы запустить поток данных используем start

//                 // Thread.Sleep(1000); //добавляем этот поток, если будет только одна таска, то она почему то ничего не будет выводить
//                 task.Wait(1000); //либо вместо строчки выше можно написать это
//                 // wait ждет когда задачка будет завершена, чтобы затем выполнить код дальше
//         }

//         public static void Print() => System.Console.WriteLine("Task1");

// }



// // TPL 2 - параллельное программирование

// using System;
// using System.Threading;
// using System.Threading.Tasks; // для работы с TPL нужно подключать эту библиотеку
// namespace project;

// class Program 
// {
//         public static void Main()
//         {
//                 // Task task = new Task(Print); 
//                 // task.Start();
//                 // второй способ запуска задач:
//                 // Task task = Task.Factory.StartNew(Print); //сделает тоже самое, что и выше
//                 // третий способ:
//                 Task task = Task.Run(Print); // делает тоже самое, что и два способа выше

//                 // создаём массив, в которой каждый элемент будет отдельная task 


//                 // Thread.Sleep(1000); 
//                 task.Wait(1000); 
//         }

//         public static void Print() => System.Console.WriteLine("Task1");

// }







// // TPL 3 - параллельное программирование

// using System;
// using System.Threading;
// using System.Threading.Tasks; // для работы с TPL нужно подключать эту библиотеку
// namespace project;

// class Program 
// {
//         public static void Main()
//         {
//                 // Task task = Task.Run(Print); 

//                 // создаём массив, в которой каждый элемент будет отдельная task , далее переберём весь массив и каждый task запустим
//                 Task[] tasks = { //можно было прописать new Task и кол-во элементов либо сразу открыть фиг скобки
//                 new Task(Print),
//                 new Task(()=>{
//                         System.Console.WriteLine("Task 2"); //тут мы создали анонимную функцию(без названия и ничего не возвращает, 
//                         // но выполняет какое то действие)
//                         Task task = Task.Run(()=>{ // ну а тут мы создали еще одну таску внутри таски (как экзибит)
//                                 Thread.Sleep(2000); //ну и добавляем задержку
//                                 System.Console.WriteLine("Task 3"); //и добавили в неё анонимную функцию
//                         });
//                 })
//                 }; //не забываем точку с запятой в конце

//                 foreach(var task in tasks)
//                         task.Start(); // ну и тут мы перебираем все элементы и запускаем их

//                 Thread.Sleep(3000); //тут должно быть время больше чем в тасках иначе основная программа уснёт раньше и ничег не произ-т
//                 // task.Wait(1000); 
//                 // если у нас имеется несколько тасок, то мы можем использовать другой метод:
//                 // Task.WaitAll(tasks); //внутри передаём тот массив в котором таски
//                 // Task.WaitAny(tasks); // этот метод ждём когда любой из тасок внутри массива завершиться
//                 // используя waitAll у нас при запуске отобразится только task 1 и task2 , а таск 3 не отобразится, 
//                 // т.к. он не явл элемен-м массива
//         }

//         public static void Print() => System.Console.WriteLine("Task 1");

//         

// }






// // TPL 4 - параллельное программирование

// using System;
// using System.Threading;
// using System.Threading.Tasks; // для работы с TPL нужно подключать эту библиотеку
// namespace project;

// class Program 
// {
//         public static void Main()
//         {
//         // для создания методов, что будут выполняться параллельно друг другу необх исп спец-й класс Paralell:
//         Parallel.Invoke(  //обр к Parallel и к статич методу Invoke внутри него можно передавать неск параметров и все они будут запуск паралл
//         Print, //тут пишем назв методов которые будут выполняться, без круглых скобок
//         ()=> System.Console.WriteLine("Data"), // создали еще анонимн функцию , не забываем в конце писать , вместо ;
//         ()=> { //создали еще одну анонимн функц
//                 System.Console.WriteLine("Task 3"); 
//                 Thread.Sleep(2000); //ну и добавили задержку
//         }

//         );
//         }

//         public static void Print() => System.Console.WriteLine("Task 1");

//         // итог: в такой реализации тоже всё будет выполняться параллельно

// }








// конструкции async & await в c# 1
// Конструкции async и await в C# предназначены для облегчения работы с асинхронным кодом. 
// Они позволяют писать код, который выполняется асинхронно, не блокируя основной поток выполнения. 
// Простыми словами, async говорит компилятору, что метод может выполняться асинхронно, а await указывает, 
// где нужно ждать результатов асинхронных операций.

// using System;
// using System.Threading;
// using System.Threading.Tasks; 
// namespace project;

// class Program 
// {
//         public static async Task Main() //тут добавл async чтобы await print ниже не выдавал ошибку
//         //и тут выше тоже void нужно заменить на Task
//         {
//         System.Console.WriteLine("Основной метод");
//         await Print(); // тут тоже добавляем задержку
//         System.Console.WriteLine("Finish");
//         //в общем основной код будет завершен только после того как мы получим ответ от метода Print
//         }
//         public static async Task Print(){ //тут вместо void изменим на Task, т.к. выше await print будет выдавать ошибку и нуж чтото возвр
//         //обращаем вним что тут нет return, т.к. await выполняет ту же самую роль
//                 await Task.Delay(3000);    //тут обр к классу Task, далее обр к статич методу delay (что то вроде sleep, отлож выполн прогр)
//                 // без async и await у нас задержки 3000мсек не будет
//                 // await без async будет выдавать ошибку, await можн исп только в асинх методах
//                 System.Console.WriteLine("Дождались");
//         }
// }



// async await 2

//ПЕРВЫМ ДЕЛОМ пошли создавать файл Client.cs

// using System;
// using System.Threading;
// using System.Threading.Tasks; 
// namespace project;

// class Program 
// {
//         public static async Task Main() 
//         {
//         System.Console.WriteLine("Основной метод");
//         // добавляем следующее:
//         string result = await Client.GetData(); //исп await и далее через точку обр к классу Client и методу GetData
//         //внутри можно было бы в Client.cs в методе GetData в принимаемых параметрах указать параметр
//         // который был бы url , тогда метод бы мог обр к разным сайтам
//         // обернули await Client.GetData() в переменную result (соотв туда будем помещ инф которую будем получать)
//         System.Console.WriteLine(result);//ну и соотв выводим получ инф 

// // всё что ниже закомментили
//         // await Print(); 
//         // System.Console.WriteLine("Finish");
//         }
//         // public static async Task Print(){
//         //         await Task.Delay(3000); 
//         //         System.Console.WriteLine("Дождались");
//         // }
// }







// Обработка json

// идём сначала в client.cs и сменили там url
// далее создали новый файл и класс todo.cs

// using System;
// using System.Threading;
// using System.Threading.Tasks; 
// // подключаем установленное пространство имён:
// using Newtonsoft.Json; //теперь у нас есть доступ к классам, которые работают с json
// namespace project;



// class Program 
// {
//         public static async Task Main() 
//         {
//         try{
//         System.Console.WriteLine("Основной метод");
//         string result = await Client.GetData(); 
//         //используем теперь доступный (теперь) новый класс:
//         Todo todo = JsonConvert.DeserializeObject<Todo>(result) ?? throw new Exception("No data"); //обр к jsonConvert далее обр к статич методу DeserializeObject
//         // поскольку DeserializeObject является обобщ методом, то мы должны передать класс, который будет описывать каждый объект
//         // внутри полученного json, соотв внутри <> указываем, что каждый эл внутри json будет описываться с помощью кл Todo,
//         // соотв на основе этого класса будут созд объекты
//         // далее пишем () - т.к. это ведь метод, туда передаём result
//         // упаковываем это всё в объект (Todo todo =)
//         // ?? throw new Exception("No data") - это добавили на случай если ответ будет нулевой и вывежем сообщ no data
//         // добавляем еще и try catch , чтобы отслеж ошибки
//         // System.Console.WriteLine(result); //это закомментили и изменили:
//         System.Console.WriteLine($"ID: {todo.id}. User id: {todo.userId}. Title: {todo.title} Completed: {todo.completed}");
//         } catch (Exception ex){
//                 System.Console.WriteLine(ex.Message); // ну а если будет ошибка, то выводим сообщение ошибки
//         }
//         }
// }








// git установка и настройка1
// используем терминал и пишем git --version //проверяем вер

// далее пишем git init // инициал гит и у нас создаётся новая скрытая папка .git (т.к. нет название , есть только расшир)

// далее устанавливаем глобальные настройки для нашего осн пользователя, т.е. для нас самих
// пишем: git config --global user.name 'George'
// чтобы проверить пишем: git config --global user.name  (т.е. без установки имени) , то отобр установл ранее имя

// далее устанавливаем почту git config --global user.email 'тут пишем почту'  // проверять уст почту git config --global user.email 

// далее нам рекомендуют установить расшир git lens //и идём устанавливать
// оно нам помогает в интерактивн формате просматривать все различн изменения, которые были внесены в наш проект








// // git добавление файлов в локальный репозиторий

// // локальный репозиторий - можно представить как папку находящуюся у меня на компе локально
// //  в будущем вы из этой папки можете указать то что все файлы будете загружать в удалённый репозиторий

// // удалённый репозиторий - это по сути та же самая папка вот только такая папка будет находиться где либо на сервере
// // причём на сервере технологии git (как бы на сайте компании gitHub)
// // соответственно туда загружаете все файлы из вашего проекта, там же вы их можете просматривать 
// // + что самое важное это то что любой другой разроботчик сможет скачать файлы к себе на компьютер из этого удалённого репозитория

// // но прежде чем перейти к удалённому репозиторию необходимо разобраться как добавлять файлы в локальный репозиторий, а уже
// // позже мы их сможет спокойно выгружать в удалённый репозиторий



// // чтобы добавить файл в локальный репозиторий:
// // пишем в терминале git add и пишем что хотим добавить в репозиторий например git add bin/ - так мы добавляем всё из папки bin
// // если хотим добавить один файл, то пишем git add program.cs
// // git add *.cs -так добавляем все файлы с таким расширением , можно еще указ git add bin/*.cs - соотв добавим из папки bin все файл с .cs
// // либо указать git add bin/program.* - добавл все файлы из папки bin с назв program не важно с каким расшир

// // решили что добавим все файлы с расшир .cs , пишем git add *.cs
// // *важно* git add не добавляет файлы в репозиторий, а как бы только подготавливает их, указывая что из необх добавить

// // чтобы проверить какие файлы готовы к добавл в локаль репозиторий пишем: git status
// // команда показывает какие файлы и папки готовы на коммит (commit)
// // commit - это когда мы уже выгружаем готовы файлы и папки в локальн репозиторий

// // далее пишем git add bin/ 

// // чтобы удалить из списка готовых файлов пишем git rm --cached Program.cs (эт для примера)
// // важно обр вним, что папки (bin напр) удалить не получится
// // т.е. при rm (remove) нужно указ полный путь к файлу

// // чтобы удалить все файлы из status (ну спис файлов готовых к коммиту) пишем: git rm -r --cached . (точку не забудьте в конце)

// // далее в итоге добавляем файлы git add *.cs

// // далее идём к процессу добавл файлов в локальн репозиторий, обращаемся к процессу коммита:
// // пишем git commit -m "First version"
// // после commit пишем сообщение (комментарий) пишем -m "" (внутри ковычек и будет ккомент)
// // нужно это чтобы потом можно было просмотреть историю комментов при коммите 
// // т.е. в будущем когда мы это дело выгрузим в удалённый репозиторий, то там будут отображаться все вот эти комментарии 
// // далее мы быстро по этим комментам будем понимать в какой момент какие были внесены изменения или 
// // сможем просматривать разные версии нашего проекта , это будет полезно и для нас и для других программистов, кот будут работать над этим проек

// using System;
// namespace project;



// class Program 
// {
//         public static void Main() 
//         {
//                 System.Console.WriteLine("Hello");
//         }

// }


// // написали весь код что выше, соотв этих изменений в репозитории еще нет, их необх закоммитить
// // пишем add Program.cs (т.к. изменили только его)
// // далее проверяем статус git status // заметим что program.cs написано теперь modified
// // далее уже коммитим: git commit -m "Изменили файл Program.cs"
// // далее мы будем из локальн репозитория переносить файлы и изменения в удалённый репозиторий



// +++







// git игнорирование файлов
// .git ignore - предназначение, чтобы при добавление всех файлов в репозиторий этот файл игнорировался и не добавлялся

// создаём файл .gitingore и туда вносим файлы и папки, которые необх игнорировать
// вместо some.txt в файле .gitingore можно указать *.txt тогда он будет игнорировать все файлы с таким расширением
// после сохранения файла, те папки и файлы которые были занесены в .gitingore будут светиться тусклым серым цветом

// теперь файлы к готовности можно добавлять командой git add . (файлы занесенные в файл игнор будут игнорироваться)










// git ветвление и слияние
// когда нам необходимо разработать свою собственную часть в дополнение к уже существующей системе
// чтобы не затрагивать других разработчиков
// тогда мы создаём новую ветку и в ней работаем, 
// когда мы завершим работу мы произведём слияние с основной веткой

// чтобы узнать на какой ветке мы находимся можем прописать git status  (сейчас будет отв on branch master - мы на осн ветке)

// создаём новую ветку, пишем:
// git branch forum (назв любое можно)
// ЧТОБЫ ПЕРЕКЛЮЧИТЬСЯ НА НОВУЮ СОЗДАННУЮ ВЕТКУ ПИШЕМ: git checkout forum 
// если эта новая ветка уже выгружена в удалённый репозиторий, то на неё смогут подключаться уже и другие разработчики

// далее создаём папку и файл Forum
// пишем git add . // далее проверяем сатус git status
// ну и далее коммитим это дело в локальн репозиторий на ветку forum (!!!) git commit -m "Add new folder'

// далее переходим на ветку master : git checkout master
// ЗАМЕТЬ как только мы переключились на другую ветку папка исчезла (магия))
// далее переключаемся на ветку forum и папка появляется git checkout forum

// НАКОНЕЦ ЧТОБЫ СДЕЛАТЬ СЛИЯНИЕ ВЕТОК ПИШЕМ СЛЕДУЮЩЕЕ:
// переходим на осн ветку git checkout master (меняем назв веток если нужно)
// далее мерджим (делаем слияние) пишем: git merge forum (вместо forum может быть другая ветка)










// git УДАЛЕННЫЙ РЕПОЗИТОРИЙ
// зашли на сайт, зарегались, создали репозиторий
// далее отобращился список команд за счёт которых можно подключиться к текущему репозирию и выгрузить весь наш проект
//  echo "# csharp" >> README.md - эта команда нужна для создания readme
// git init - для инициализации репозитория (для нас не актуально мы уже инициализировали)
// git add README.md - добавл файла в ожидание на коммит
// git commit -m "first commit" - эт соответственно чтобы закоммитить
// git branch -M main - команда переименовывает ветку в main (используем её, затем обратно на master)
// git remote add origin https://github.com/ElvarShakurov/csharp.git - ПОДКЛЮЧЕНИЕ К УДАЛЁННОМУ РЕПОЗИТОРИЮ (origin - название, его можн изм)
// чтобы отключиться от удалённого репозитория пишем: git remote remove origin (origin - название соответственно)
// git remote - команда показывает к чему вы подключены, если ничего не отобр значит ни к чему не подкл

// новые файлы не будут добавляться в удалённый репозиторий пока мы не добавим их в локальный репозиторий

// git push -u origin master - команда выгружает файлы в удалённый репозиторий (НЕ ЗАБУДЬ СМЕНИТЬ НАЗВАНИЕ ВЕТКИ ЕСЛИ НУЖНО)

// иногда нужна авторизация чтобы выгрузить код, нужно либо через браузер авторизоваться 
// либо через настройки генерим токен (настройки для разраб) ставим галочки repo
// на маке надо найти связку ключей далее найти github с типом пароль интернета (или создать)
// далее указать имя например github.com далее указать пароль это токен сгенерированный
// НА ВИНДЕ находим windows credentials или диспетчер учетных данных далее учетные данные для интернета (ТАКОГО НЕ НАШЁЛ!)
// название нужно писать git:https://github.com , логин из логина github пароль указываем сгенерированный токен
// для линукса: 
// For Linux, you need to configure the local GIT client with a username and email address,
// $ git config --global user.name "your_github_username"
// $ git config --global user.email "your_github_email"
// $ git config -l
// далее 
// Once GIT is configured, we can begin using it to access GitHub. Example:
// $ git clone https://github.com/YOUR-USERNAME/YOUR-REPOSITORY (тут указываем наш url)
// > Cloning into `YOUR-REPOSITORY`...
// Username: <type your username> (тут логин шита)
// Password: <type your password or personal access token (GitHub) (ну а тут сегенированный токен)

// если нам нужна доп ветка в удал репоз, то её также грузим

// далее рекомендовано моздать файл README.md // создаём его 
// md - марк даун - спец формат файла текст в котором затем трансФОРМИРУЕТСЯ в различн заголовки, списки и т.д.(можно загуглить)
// # - заголовок 1-го уровн
// ## - заголовок 2-го уровня и т.д.
// обыцчный текст - текст
//  - текст -отобр как список
// _GitHub_ - курсив когда _ и _

// далее все это закоммитили и запушили в удалённый репозиторий  git push -u origin master   origin - назв удал репоз

// историю коммитов смотрим через значок таймера // при нажатии видно что менялось

// чтобы скачать проект можно нажать на code и скачать zip


// видео 20:35


// далее через файл открываем новое окно и создаём там новую папку New и открываем её
// чтобы скопировать туда с репозитория файлы заходим на GitHub через кнопку code копируем ссылку
// и в открытом новом окне пишем git clone https://github.com/ElvarShakurov/csharp.git
// соотв все файлы скачались в эту новую папку New 
// еще visual studio автоматом добавил папки bin obj т.к. понял, что я работаю с проектом

// далее мы практикуемся: создаём в папке project файл car.cs