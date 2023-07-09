// модификатор доступа2 static
// namespace project;

// // этот класс создаём для примера, поэтому не используем принципы инкапсуляции 
// class Users { 
//     public static int count; // создали поле // добавили модификатор доступа static
// }
// // можно для поля установить модиф доступа вместо public установить private или protected тогда поле будет доступно только внутри класса и 
// // классов наследников , или уст readonly тогда устан знач можно будет 1 раз далее только считывать инфу







// модификатор доступа static2, практика
// namespace project;
// using System;

// // этот класс создаём для примера, поэтому не используем принципы инкапсуляции 
// class Users { 
//     public static int count; // создали поле // добавили модификатор доступа static

//     // создаём метод, который будет выводить количество всех наших пользователей:
//     public static void GetCount() => System.Console.WriteLine($"Количество: {count}");
//     // с модиф дост static нельзя использовать .this , будет выводиться ошибка
//     // ЕСЛИ У НАС ПОЛЕ STATIC , ТО И МЕТОД ДЛЯ ЕГО ВЫВОДА НУЖНО ДЕЛАТЬ С МОДИФ ДОСТ STATIC (ИНАЧЕ БУДЕТ ВОЗН ОШИБКА)
// }
// // можно для поля установить модиф доступа вместо public установить private или protected тогда поле будет доступно только внутри класса и 
// // классов наследников , или уст readonly тогда устан знач можно будет 1 раз далее только считывать инфу






// // модификатор доступа static3
// namespace project;
// using System;


// static class Users { //создали статичн класс(добавили перед class "static")
//     public static int count; 
//     public static void GetCount() => System.Console.WriteLine($"Количество: {count}");

//     // создаём статичный конструктор для самого класса, в таком случае он сработает лишь один раз при создании первого объекта:
//     static Users(){
//         System.Console.WriteLine("user created");
//     }
//     // указыв static далее указ назв(обычно совп с назв класса)
//     // public не указываем если создаём статичн конструктор

// }









// // модификатор доступа static4
// namespace project;
// using System;


// static class Users { 
//     public static int count; 
//     public static void GetCount() => System.Console.WriteLine($"Количество: {count}");


//     static Users(){
//         System.Console.WriteLine("user created");
//     }

// }





// //Перечисления
// namespace project;
// using System;


// static class Users { 
//     public static int count; 
//     public static void GetCount() => System.Console.WriteLine($"Количество: {count}");


//     static Users(){
//         System.Console.WriteLine("user created");
//     }

// }






// //Абстрактные классы
// namespace project;
// using System;


// static class Users { 
//     public static int count; 
//     public static void GetCount() => System.Console.WriteLine($"Количество: {count}");


//     static Users(){
//         System.Console.WriteLine("user created");
//     }

// }





// //Интерфейсы
// namespace project;
// using System;


// static class Users { 
//     public static int count; 
//     public static void GetCount() => System.Console.WriteLine($"Количество: {count}");


//     static Users(){
//         System.Console.WriteLine("user created");
//     }

// }









// // Интерфейсы IEnumerable и IEnumerator
// namespace project;
// using System;


// static class Users { 
//     public static int count; 
//     public static void GetCount() => System.Console.WriteLine($"Количество: {count}");


//     static Users(){
//         System.Console.WriteLine("user created");
//     }

// }

