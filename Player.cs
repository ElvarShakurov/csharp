// // Наследование
// // Создали новый файл для описания нового класса(наследника от Person.cs) для игрока

// using System;  
// // using System.Collections;  //это закомментили, т.к. он тут не понадобиться
// namespace project; 

// class Player : Person {  //созд класс наследник , называем новый класс далее : и указываем от какого класса наследуем, 
// // важно что насл можно только от 1 класса

// // создаём новое поле и аксессор:

// private string? magicPower;
// public string? MagicPower {
//     get => magicPower;
//     set{
//         if (value == "heal")
//         this.magicPower = value;
//         else
//         System.Console.WriteLine("Такого нет");

//     }
// }

// // создаём конструктор, поля берём те же которые есть в в классе Person
// // public Player(string name, string type, int age, Dictionary<string,bool>? places, string magicpower){
//     // this.Age = age; //т.к. в классе Person эти поля имеют модиф private к ним мы можем обр только через методы и аксессоры, тут аксессор
//     // this.SetName(name) //а тут исп метод

// // ОДНАКО , т.к. в классе Person уже имеется конструктор принимающий те же параметры(кроме поля magicpower), то пишем вот так:
// // пишем : и далее пишем base - это что то вроде this но относится и к полям и к конструкторам(т.е. можно обращ и брать поля из родительск класса)
// // -и внутри () пишем какие параметры будут передаваться
// public Player(string name, string type, int age, Dictionary<string,bool>? places, string MP) : base (name,type,age,places) {
// // можно было еще написать вот так:
// // base.SetData(name,type,age,places) // и всё бы обработалось правильно
// this.MagicPower = MP;
// // ну и получилось, что мы все параметры кроме magicpower передали в констр в родит классе , а параметр magicpower передадим отдельно еще
// }

// // чтобы не выдавало ошибку создаём еще констр по умолч(т.к. у нас теперь только один констр)
// public Player(){}

// }








// // Наследование2 , ПОЛИМОРФИЗМ

// using System;  
// namespace project; 

// class Player : Person {  

// private string? magicPower;
// public string? MagicPower {
//     get => magicPower;
//     set{
//         if (value == "heal")
//         this.magicPower = value;
//         else
//         System.Console.WriteLine("Такого нет");

//     }
// }

// public Player(string name, string type, int age, Dictionary<string,bool>? places, string MP) : base (name,type,age,places) {
// this.MagicPower = MP;
// }

// public Player(){ }

// public override void GetInfo(){ //вставили сюда метод из кл person, и тут мы уже меняем virtual на override, т.е. мы его будем переделывать
//     // тут мы обращ к нашему род классу(с помощью base.) к методу GetInfo, т.е. сначала мы выполним весь метод GetInfo
//     base.GetInfo();
//     System.Console.WriteLine($"Magic Power: {MagicPower}");
    
// }

// }








// // Модификатор доступа static

// using System;  
// namespace project; 

// class Player : Person {  

// private string? magicPower;
// public string? MagicPower {
//     get => magicPower;
//     set{
//         if (value == "heal")
//         this.magicPower = value;
//         else
//         System.Console.WriteLine("Такого нет");

//     }
// }

// public Player(string name, string type, int age, Dictionary<string,bool>? places, string MP) : base (name,type,age,places) {
// this.MagicPower = MP;
// }

// public Player(){ }

// public override void GetInfo(){ 
//     base.GetInfo();
//     System.Console.WriteLine($"Magic Power: {MagicPower}");
    
// }

// }






// Модификатор доступа static2, практика
// Модификатор доступа static3
// // Модификатор доступа static4

// using System;  
// namespace project; 

// class Player : Person {  

// private string? magicPower;
// public string? MagicPower {
//     get => magicPower;
//     set{
//         if (value == "heal")
//         this.magicPower = value;
//         else
//         System.Console.WriteLine("Такого нет");

//     }
// }

// public Player(string name, string type, int age, Dictionary<string,bool>? places, string MP) : base (name,type,age,places) {
// this.MagicPower = MP;
// }

// public Player(){ }

// public override void GetInfo(){ 
//     base.GetInfo();
//     System.Console.WriteLine($"Magic Power: {MagicPower}");
    
// }

// }







// // Перечисления

// using System;  
// namespace project; 

// class Player : Person {  

// private string? magicPower;
// public string? MagicPower {
//     get => magicPower;
//     set{
//         if (value == "heal")
//         this.magicPower = value;
//         else
//         System.Console.WriteLine("Такого нет");

//     }
// }

// public Player(string name, PersonType type, int age, Dictionary<string,bool>? places, string MP) : base (name,type,age,places) {
// this.MagicPower = MP;
// }

// public Player()
// {
   
// }

// public override void GetInfo(){ 
//     base.GetInfo();
//     System.Console.WriteLine($"Magic Power: {MagicPower}");
    
// }

// }









// // Абстрактные классы

// using System;  
// namespace project; 

// class Player : Person {  

// private string? magicPower;
// public string? MagicPower {
//     get => magicPower;
//     set{
//         if (value == "heal")
//         this.magicPower = value;
//         else
//         System.Console.WriteLine("Такого нет");

//     }
// }

// // реализовываем абстрактный аксессор Health, который был описан в person cs
// // модиф доступа должен быть такой же как и в родительском кл
// protected override int Health { get; set;} //не забываем про override, т.к. мы переписываем аксессор или метод

// public Player(string name, PersonType type, int age, Dictionary<string,bool>? places, string MP) : base (name,type,age,places) {
// this.MagicPower = MP;
// }

// public Player()
// {
   
// }

// public override void GetInfo(){ 
//     base.GetInfo();
//     System.Console.WriteLine($"Magic Power: {MagicPower}");
    
// }

// // ну и создаём тут асбтрактный метод, который был описан в person.cs
//     public override void Action() { //добавляем override, чтобы указать, что мы переписываем абстрактный метод Action из нашего родительского кл
//     System.Console.WriteLine("Мы просто ходим");
//     }

// }







// // Интерфейсы

// using System;  
// namespace project; 

// class Player : Person {  

// private string? magicPower;
// public string? MagicPower {
//     get => magicPower;
//     set{
//         if (value == "heal")
//         this.magicPower = value;
//         else
//         System.Console.WriteLine("Такого нет");

//     }
// }

// protected override int Health { get; set;} 

// public Player(string name, PersonType type, int age, Dictionary<string,bool>? places, string MP) : base (name,type,age,places) {
// this.MagicPower = MP;
// }

// public Player()
// {
   
// }

// public override void GetInfo(){ 
//     base.GetInfo();
//     System.Console.WriteLine($"Magic Power: {MagicPower}");
    
// }
//     public override void Action() { 
//     System.Console.WriteLine("Мы просто ходим");
//     }

// }









// // Интерфейсы IEnumerable и IEnumerator

// using System;  
// namespace project; 

// class Player : Person {  

// private string? magicPower;
// public string? MagicPower {
//     get => magicPower;
//     set{
//         if (value == "heal")
//         this.magicPower = value;
//         else
//         System.Console.WriteLine("Такого нет");

//     }
// }

// protected override int Health { get; set;} 

// public Player(string name, PersonType type, int age, Dictionary<string,bool>? places, string MP) : base (name,type,age,places) {
// this.MagicPower = MP;
// }

// public Player()
// {
   
// }

// public override void GetInfo(){ 
//     base.GetInfo();
//     System.Console.WriteLine($"Magic Power: {MagicPower}");
    
// }
//     public override void Action() { 
//     System.Console.WriteLine("Мы просто ходим");
//     }

// }



// // События
// using System;
// namespace project;
// class Player {

//     // создаём делегат:
//     public delegate void HealthHandler(int health); //лектор забыл добавить public
//     // прописываем delegate далее void(ничего не будет возвращ) далее название и далее в кругл скобках, что мы будем принимать
//     // далее помимо делегата создаём СОБЫТИЕ:
//     public event HealthHandler? ActionHealth; //лектор забыл добавить public
//     // для создания события исп тип данных event , далее указ, что событие будет основано на нашем делегате(который прописан выше: HealthHandler)
//     // далее прописываем название события(у нас ActionHealth)

//     private int health; // значение можно было установить сразу тут, но мы решили это сделать через констр по умолч

//     public Player() { // не забываем про модиф доступа
//         this.health = 100;
//         // чтобы событие ActionHealth вызвать пишем:
//         // ActionHealth(3); //событие основанно на делегате, а делегат у нас принимает int поэтому в кругл скобках пишем число
//         // строчку выше мы закомментили (событие бы вызывалось при осздании объекта), мы решили запилить его в методах Heal  и Damage
//     }

//     // Дополнительно создадим два метода:
//     public void Heal(int heal) { // этот метод будет прибавлять жизни
//         this.health += heal;
//         // ActionHealth(3); //добавили событие , но решили его изменить:
//         ActionHealth?.Invoke(this.health); //invoke нужен чтобы мы могли после ActionHealth добавить ?
//     }

//     public void Damage(int damage) { // этот метод будет отнимать жизнь
//         this.health -= damage;
//         ActionHealth?.Invoke(this.health);
//     }

// }
// // в этом классе будет несколько полей и мы будем пытаться отнять жизнь у игрока или же добавить наоборот жизнь




// // Задание классы и объекты в ООП

// using System;
// namespace project;

// enum Variants { Rock, Paper, Scissors }
// class Player {

// public Variants type;
// public string? name; 

// public Player(Variants type, string name) { 

//     this.type = type;
//     this.name = name; 

// } 

// Random rnd = new Random();
// public Player (){

//     name = "bot";
//     type = (Variants)rnd.Next(3);

// } 




// }




// Операторы is as
// тут мы наследуем всё из кл Person.cs

namespace project;

class Player : Person{}