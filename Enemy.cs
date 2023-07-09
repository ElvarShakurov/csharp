// // Наследование
// // Создаём класс наследник Enemy от класс Person

// using System;  
// namespace project;

// class Enemy : Person { // называем класс далее пишем : и указываем от какого класса наследуем
    
//     // Скопировали конструктор из класса player сюда, но без magicpower
//     public Enemy(string name, string type, int age, Dictionary<string,bool>? places) : base (name,type,age,places) {

//     }

// }







// // Наследование2, ПОЛИМОРФИЗМ
// // Создаём класс наследник Enemy от класс Person

// using System;  
// namespace project;

// class Enemy : Person {   
//     public Enemy(string name, string type, int age, Dictionary<string,bool>? places) : base (name,type,age,places) {
//     }
// }






// // Модификатор доступа static

// using System;  
// namespace project;

// class Enemy : Person {   
//     public Enemy(string name, string type, int age, Dictionary<string,bool>? places) : base (name,type,age,places) {
//     }
// }







// Модификатор доступа static2
// Модификатор доступа static3
// // Модификатор доступа static4

// using System;  
// namespace project;

// class Enemy : Person {   
//     public Enemy(string name, string type, int age, Dictionary<string,bool>? places) : base (name,type,age,places) {
//     }
// }





// // Перечисления

// using System;  
// namespace project;

// class Enemy : Person {   
//     public Enemy(string name, PersonType type, int age, Dictionary<string,bool>? places) : base (name,type,age,places) {
//     }
// }









// // Абстрактные классы

// using System;  
// namespace project;

// class Enemy : Person 
// {   

//     // реализовываем абстрактный аксессор Health, который был описан в person cs
//     // модиф доступа должен быть такой же как и в родительском кл
//     protected override int Health { get; set;} //не забываем про override, т.к. мы переписываем аксессор или метод

//     public Enemy(string name, PersonType type, int age, Dictionary<string,bool>? places) : base (name,type,age,places) 
//     {
//     }

// // ну и создаём тут асбтрактный метод, который был описан в person.cs
//     public override void Action() { //добавляем override, чтобы указать, что мы переписываем абстрактный метод Action из нашего родительского кл
//     System.Console.WriteLine("Мы тебя ударили");
//     }
// }






// // Интерфейсы

// using System;  
// namespace project;

// class Enemy : Person //, ITalk //чтобы реализовать интерфейс тут через запятую прописываем назв интерф ITalk 
// // нужно реализовать обязательно только те парам и методы в которых нет минимальных действий
// // тоже самое можно было бы реализовать в абстракт классе в файле person и тогда он был бы доступен и в enemy и в player
// {   

//     protected override int Health { get; set;} 
    
//     public Enemy(string name, PersonType type, int age, Dictionary<string,bool>? places) : base (name,type,age,places) 
//     {
//     }


//     public override void Action() { 
//     System.Console.WriteLine("Мы тебя ударили");
//     }
// }










// // Интерфейсы IEnumerable и IEnumerator

// using System;  
// namespace project;

// class Enemy : Person 
// {   

//     protected override int Health { get; set;} 
    
//     public Enemy(string name, PersonType type, int age, Dictionary<string,bool>? places) : base (name,type,age,places) 
//     {
//     }


//     public override void Action() { 
//     System.Console.WriteLine("Мы тебя ударили");
//     }
// }



// Операторы is as2
namespace project;

// создаём еще один класс

class Enemy : Person { } // он у нас будет всё насл от кл Person
// далее идём в Program.cs