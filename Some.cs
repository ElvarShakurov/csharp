// // Пространство имён - эта та вещь, котор запис-я в в файле сверху, в ней мы указываем к чему будет принадлежать этот конкретный файл
// // её можно расценивать как некую папку, в которой может находится множество различных файлов и все эти файлы будут видеть друг друга
// // и смогут взаимодействовать друг с другом, просто потомучто будут находится в одной папке в одном простр имён
// // внутри одного проекта можно создавать не только одно простр имён и далее их можно подключать внутри других файлов

// // мы создали новый файл some с расширением cs (cs - это расширение c#(с sharp))
// // и тут попробуем использовать тоже пространство что и для файла Program.cs

// // namespace Project {  // тут мы подкл простр имён и всё что будет прописано в фигурн скобках будет относ к простр имён Project
// // }

// // // либо можем прописать вот так:
// using System;
// using System.IO;
// // namespace project; // всё что будет написано после будет относ к простр имён Project
// // // меняем простр имён
// namespace itproger;


// class Some // создали новый класс
// {
//     public static void Print() => System.Console.WriteLine("Hello"); // создали новый метод, к нему можно будет обратиться из другого файла, если он в простр имён Project
// }

