// создание классов1
// Файлы лучше всегда называть как и классы

// using System;  // подключая его я сразу смогу исп классы console convert и пр 
// , но пока он нам даже не понадобиться

// using System.Collections; // для работы с КОЛЛЕКЦИЯМИ НЕ ЗАБЫВАЕМ ПОДКЛ ЭТОТ НЕЙМСПЕЙС !

// namespace project; // подкл простр имён как и в др файлах // и тут можно будет исп классы и методы из др файлов
// // если прописать другое простр имён, то при подключении его в др файле нужно будет прописать using и назв простр имён


// class Person { // для созд класса пишем class ,потом назв класса(как назв файла) , 
// // внутри класса можно прописывать поля(переменные), функции(методы) ну и также аксессоры инструкторы и пр
// // существуют модификаторы public, private, protected - их нужно добавлять в класс Person в файле Person.cs
// // модификатор public - если его прописать в классе, то поля(перем) будут видны как внутри класса так и вне
// // модификатор private - видно только внутри класса(только внутри класс person в файле person.cs)
// // модификатор protected - видно только внутри класса и в классах наследниках (изучим его когда будем изучать наследование)

// public string? name, type; // ну и создаём поля(переменные), значения не указываем, обычно их указыв при создании объектов на основе этого класса
// // string? name;  //можем прописать ? чтобы было понятно что перемен может быть 0
// // string[]  //можем созд массивы, коллекции и пр.
// // НЕ ЗАБЫВАЕМ ДОБАВИТЬ PUBLIC ЧТОБЫ ПОЛЯ(ПЕРЕМЕННЫЕ) МОЖНО БЫЛО ИСП И ВНУТРИ КЛАССА И ВНЕ

// public int age;
// // string? type; // type засунули рядом с name ,т.к. исп один и тот же тип данных и так меньше кода
// // НЕ ЗАБЫВАЕМ ДОБАВИТЬ PUBLIC ЧТОБЫ ПОЛЯ(ПЕРЕМЕННЫЕ) МОЖНО БЫЛО ИСП И ВНУТРИ КЛАССА И ВНЕ

// public Dictionary<string,bool> places = new Dictionary <string,bool>(); // создали словарь(ключи стринг, знач булевое) и выделили память
// // для обычных переменных выделять память не нужно, но для коллекций нужно выделять память
// // НЕ ЗАБЫВАЕМ ДОБАВИТЬ PUBLIC ЧТОБЫ ПОЛЯ(ПЕРЕМЕННЫЕ) МОЖНО БЫЛО ИСП И ВНУТРИ КЛАССА И ВНЕ

// // ДАЛЕЕ НА ОСНОВЕ ЭТОГО КЛАССА В ФАЙЛЕ PROGRAM.CS СОЗДАЁМ ОБЪЕКТ
// }


// // Продолжаем практиковаться // создание классов2

// using System;  
// using System.Collections; 
// namespace project; 

// class Person { 
// public string? name, type; 
// public int age;
// public Dictionary<string,bool> places = new Dictionary <string,bool>(); 

// }


// // Продолжаем практиковаться // создание классов3

// using System;  
// using System.Collections; 
// namespace project; 

// class Person { 
// public string? name, type; 
// public int age;
// public Dictionary<string,bool> places = new Dictionary <string,bool>(); 

// // создадим метод, который будет добавлять значения внутри вышеуказанных полей:
// // НЕ ЗАБЫВАЕМ ПРОПИСАТЬ PUBLIC, ЧТОБЫ МЕТОД БЫЛ ВИДЕН И ВНУТРИ КЛАССА И В ДР КЛАССАХ ЭТОГО ПРОСТР ИМЁН
// public void SetData(string _name, string _type, int _age, Dictionary<string, bool> _places) { // внутри кругл пишем, что хотим получать и назв
//     // name = name; // так будет выдаваться ошибка, т.к. компилятор не поймёт к какому парам мы обращаемся это параметр или поле
//     // поэтому внутри кругл скобок перем назвать лучше по другому например вместо name пишем _name, так мы будем их отличать по назв



//     // теперь пишем вот так: 
//     name = _name;
//     type = _type;
//     age = _age;
//     places = _places;
//     // теперь данные в файле програм в другом классе можно добавлять через метод через запятую, например вот так:
//     // alex.SetData("Alex","player",25, ); // т.е. это теперь такой же полноценный метод как и cw 
//     // ,но чтобы добавить Dictionary нужно предварительно его создать(см. в файле program.cs)
// }

// }






// Продолжаем практиковаться // создание классов4

// using System;  // не забываем подключать это простр имён чтобы можно было использовать cw
// using System.Collections; 
// namespace project; 

// class Person { 
// public string? name, type; 
// public int age;
// public Dictionary<string,bool>? places = new Dictionary <string,bool>(); 

// public void SetData(string _name, string _type, int _age, Dictionary<string, bool>? _places=null) { 

//     // внутри кругл скобок можно использовать и ref и out и in и можно задавать знач по умолчанию вот так: Dictionary<string, bool>? _places=null (не забываем про ? , т.к. null)

//     name = _name;
//     type = _type;
//     age = _age;
//     // places = _places; // т.к. мы установили знач по умолч выше в кругл скобках для places тут теперь нужно писать так:
//     // places = _places ?? new Dictionary<string, bool>(); // это сделано для того если значение будет null , то мы будем выделять память
//     // либо оставляем как было:
//     places = _places; // но выше пишем ? в public Dictionary<string,bool>? places = new Dictionary <string,bool>(); 
// }

// public void SetAge(int _age) { // создаём метод который будет устанавливать только возвраст 
//     if (_age < 0) // ну и проверяем чтобы возраст был больше нуля, если меньше то отобр сообщение
//         System.Console.WriteLine("Возвраст должен быть больше 0");
//     else
//         age = _age; // ну а если возвраст нормальный тогда будем устанавливать значение которое будет передаваться в методе
// }

// }







// // Конструкторы
// // Конструкторы, модификаторы и аксессоры
// // Конструкторы - это что то вроде методов, только конструкторы вызываются автоматически в момент создания самого объекта
// // Консукторы бывают максимально полезны когда нам необходимо выполнить код сразу же после создания объекта
// // на самом деле все классы содержат конструкторы , вот только эти констр являются конструкторами по умолчанию
// // по этой причине мы их попросту и не видим

// using System;  // не забываем подключать это простр имён чтобы можно было использовать cw
// using System.Collections; 
// namespace project; 

// class Person { 

// // описываем конструктор:
// //public Person() {} // а вот и конструктор ПО УМОЛЧАНИЮ, т.к. мы созд-м констр-р по умолч, то в кругл и фиг скобках ничего не указываем,
// // т.е. мы ничего не принимаем в нём и ничего не выполняем, обрати внимание, что на этот конструктор два раза уже ссылались(2references),
// // это потомучто в файле Program.cs прописывали Person , 
// // сначала исп модификатор public(если исп private, то в др файле не создастся объект на основе этого класса)
// // НО В ОТЛИЧИЕ ОТ МЕТОДОВ НАМ НЕ НУЖНО УКАЗЫВАТЬ ВОЗВРАЩАЕМЫЙ ТИП ДАННЫХ (НАПРИМЕР VOID), Т.К. КОНСТР-Р ПО УМОЛЧАНИЮ ВОЗВРАЩАЕТ СОЗДАННЫЙ ОБЪЕКТ
// // далее сразу пишем название, обычно название пишем такое же как и у класса (person), 
// // Я ТАК ПОНЯЛ, ЧТО КОНСТРУКТОРЫ ПРОПИСЫВАЮТСЯ ТАМ ЖЕ ГДЕ И КЛАССЫ И С ТЕМ ЖЕ НАЗВАНИЕМ

// // решили изменить конструктор:
// public Person() {
//     System.Console.WriteLine("Person is created");
// } // ну и каждый раз при создании объекта на осн класса person будете выводиться это сообщение

// public string? name, type; 
// public int age;
// public Dictionary<string,bool>? places = new Dictionary <string,bool>(); 

// public void SetData(string _name, string _type, int _age, Dictionary<string, bool>? _places=null) { 
//     name = _name;
//     type = _type;
//     age = _age;
//     places = _places; 
// }

// public void SetAge(int _age) { 
//     if (_age < 0) 
//         System.Console.WriteLine("Возвраст должен быть больше 0");
//     else
//         age = _age; 
// }

// }







// // Конструкторы2
// // Конструкторы чаще всего используют для установки значений сразу же после создания объекта

// using System;  // не забываем подключать это простр имён чтобы можно было использовать cw
// using System.Collections; 
// namespace project; 

// class Person { 

// public string? name, type; 
// public int age;
// public Dictionary<string,bool>? places = new Dictionary <string,bool>(); 

// public Person(string _name, string _type, int _age, Dictionary<string, bool>? _places) { //указали, что констр Person будет принимать name type places,-
//     //- причем, у places убрали значение по умолчанию(=null), т.к. теперь он будет принимать значение

//     System.Console.WriteLine("Person is created");
//     name = _name; // вставили кусок кода из setData(name, type, age, places)
//     type = _type;
//     age = _age;
//     places = _places; 
// } 

// Создали еще один конструктор, но который будет принимать только три параметра
// public Person(string _name, string _type, int _age) { 
//     // можно выше из public Person(string _name, string _type, int _age) удалили из кругл скобок Dictionary<string, bool>? _places
//     // -и теперь он сможет принимать только три параметра, без словаря

//     System.Console.WriteLine("Person is created");
//     name = _name; // вставили кусок кода из setData(name, type, age, places)
//     type = _type;
//     age = _age;
// } 

// // Чтобы можно было и передавать значения и внутри кругл скобок в файле Program.cs при создании объекта вот так:
// // Person alex = new Person("Alex","player",25);
// // И ЧТОБЫ МОЖНО БЫЛО ПЕРЕДАВАТЬ ЗНАЧЕНИЯ В МЕТОДЕ SETDATA И SETAGE , т.е. чтобы кругл скобки могли оставаться и пустыми при создании объекта(и заполн), 
// // ,а значения могли передаваться через и методы setAge setData и в кругл скобках при создании объектов, 
// // МЫ РЕАЛИЗУЕМ ПЕРЕГРУЗКУ КОНСТРУКТОРА:
// public Person (){} // для описания перегрузки конструктора прописываем название конструктора и если мы укажем другое количество параметров-
// // -или другой тип, то будет считаться как перегрузка конструктора
// // ВАЖНО! МОЖНО В КРУГЛ СКОБКАХ НИЧЕГО НЕ ПИСАТЬ, А В ФИГУРН СКОБКАХ ЧТО ТО ПРОПИСАТЬ! И БУДУТ ВЫПОЛНЯТЬСЯ ОПРЕДЕЛЕННЫЕ ДЕЙСТВИЯ
// // тоесть если в program.cs в строчке Person bob = new Person(); - в кругл скобках ничего не передать, то будет использоваться-
// // -этот конструктор(перегрузка конструктора) и будет использоваться метод SetData например, -
// // -а если в кругл скобках передать 4 параметра, то будет исп-ться ранее описанный конструктор Person

// // можно эти конструкторы использовать как удобно, например из 

// public void SetData(string _name, string _type, int _age, Dictionary<string, bool>? _places=null) { 
//     name = _name;
//     type = _type;
//     age = _age;
//     places = _places; 
// } 

// // точно также перегрузку можно сделать с методом как и с конструктором, чтобы например метод принимал три значения, а не четыре:
// // public void SetData(string _name, int _age, Dictionary<string, bool>? _places=null) { // type = _type; убрали
// //     name = _name;
// //     type = _type;
// //     age = _age;
// //     places = _places; 
// // } 

// public void SetAge(int _age) { 
//     if (_age < 0) 
//         System.Console.WriteLine("Возвраст должен быть больше 0");
//     else
//         age = _age; 
// }

// }






// // Конструкторы3

// using System;  
// using System.Collections; 
// namespace project; 

// class Person { 

// public string? name, type; 
// public int age;
// public Dictionary<string,bool>? places = new Dictionary <string,bool>(); 

// public Person(string _name, string _type, int _age, Dictionary<string, bool>? _places) 
// {
//     System.Console.WriteLine("Person is created");
//     // name = _name; // эти параметры удалили
//     // type = _type;
//     // age = _age; 
//     // places = _places; 
//     SetData(_name, _type, _age, _places); // и добавили эту строчку, использовали для удобства метод SetData и сразу в него передали значения
//     // сделали это, т.к. это сократило код, т.к. мы одни и теже строчки указываем, что устанавливаем данные
// } 

// public Person(string _name, string _type, int _age) 
// {
//     System.Console.WriteLine("Person is created");
//     name = _name; // тут установку значений оставим без изменений через name = _name, т.к. мы тут принимаем три параметра, а не четыре, а в методе
//     // - SetData мы должны принимать четыре значения
//     type = _type;
//     age = _age; 
// } 

// public Person (){}

// public void SetData(string _name, string _type, int _age, Dictionary<string, bool>? _places=null) { 
//     name = _name;
//     type = _type;
//     age = _age;
//     places = _places; 
// } 

// public void SetAge(int _age) { 
//     if (_age < 0) 
//         System.Console.WriteLine("Возвраст должен быть больше 0");
//     else
//         age = _age; 
// }

// }





// // Конструкторы4, указатель this

// using System;  
// using System.Collections; 
// namespace project; 

// class Person { 

// public string? name, type; 
// public int age;
// public Dictionary<string,bool>? places = new Dictionary <string,bool>(); 

// public Person(string _name, string _type, int _age, Dictionary<string, bool>? _places) 
// {
//     System.Console.WriteLine("Person is created");
//     // name = _name; // эти параметры удалили
//     // type = _type;
//     // age = _age; 
//     // places = _places; 
//     SetData(_name, _type, _age, _places); 
// } 

// public Person(string _name, string _type, int _age) 
// {
//     System.Console.WriteLine("Person is created");
//     name = _name;
//     type = _type;
//     age = _age; 
// } 

// public Person (){}

// public void SetData(string name, string type, int age, Dictionary<string, bool>? places=null) { //изменили назв параметров
// // назвали их как и названия полей вместо string _name теперь string name
//     this.name = name; // ну и тут тоже вместо name = _name; написали name = name;- 
//     //-комп-р видит ошибки потомучто мы в наш параметр подставляем его же значение, в общем он не понимает, что здесь происходит
//     // ПОЭТОМУ ВОТ ТУТ КАК РАЗ И НУЖЕН THIS указатель
//     // благодаря этому указателю мы можем указать, то что мы конкретно из нашего класса берем либо какое либо поле либо какой то метод
//     // поэтому ПЕРЕД name пишем this. - таким образом я как бы говорю, что мы должны обратиться к ЭТОМУ ЖЕ КЛАССУ-
//     // -и из этого класса взять такое поле как name, 
//     // -а в качестве значения мы подставляем то значение которое передаётся в кругл скобках в качестве параметра
//     this.type = type; // ну и тоже самое(this.) подставляем и для других полей
//     // this.age = age; //т.к. мы ниже прописали this.SetAge(age); , то эту строчку можно закомментировать/удалить
//     this.places = places; 

//     // ну и так же с помощтю this. можно обращаться не только к параметрам, но и к МЕТОДАМ:
//     this.SetAge(age);  // на самом деле если бы было написано SetAge(age); - то тоже бы всё сработало корректно, -
//     // -просто .this даёт понять явно, что метод(или параметр) берётся из этого класса!
//     // В ОБЩЕМ this нужен, чтобы обращаться к каким либо элементам(параметрам и методам) ВНУТРИ! КЛАССА! 

// } 

// public void SetAge(int _age) { 
//     if (_age < 0) 
//         System.Console.WriteLine("Возвраст должен быть больше 0");
//     else
//         age = _age; 
// }

// }







// // Конструкторы5, МОДИФИКАТОР ДОСТУПА read only 

// using System;  
// using System.Collections; 
// namespace project; 

// class Person { 

// создаём еще одно поле в классе person , но с модификатором доступа readonly:
// public readonly int score;//после модификаторов public(или private) пишем уже readonly , далее указываем тип данных-
// // ТАКИМ ОБРАЗОМ МЫ ПРОПИСАЛИ ПОЛЕ В КОТОРОЕ МЫ СМОЖЕМ УСТАНОВИТЬ ЗНАЧЕНИЕ ЛИБО СРАЗУ ЖЕ ЗДЕСЬ ВНУТРИ КЛАССА(public readonly int score=5)
// // -ЛИБО! МЫ В ЭТО ПОЛЕ СМОЖЕМ УСТАНОВИТЬ ЗНАЧЕНИЕ ЛИШЬ ОДИН РАЗ ПРИ СОЗДАНИИ ОБЪЕКТА, Т.Е. ВНУТРИ КОНСТРУКТОРА
// // ТОЕСТЬ НАПРИМЕР В КОНСТРУКТОРЕ внутри ФИГУРНЫХ! СКОБОК МЫ МОЖЕМ НАПИСАТЬ this.score = 5; и всё сработает хорошо, 
// // НО если тоже самое написать уже в МЕТОДЕ(напр.SetData), то будет выдаваться ошибка
// // тоже ошибку будет выдавать если обратиться через объект(т.е. через файл Program.cs) и написать в объекте bob: bob.Score = 0; (тоже будет ошибк)

// // если модификатор доступа readonly то в параметр мы сможем при создании объекта установить значение
// // И ПОТОМ СМОЖЕМ ТОЛЬКО СЧИТЫВАТЬ И ВЫВОДИТЬ ИНФУ, НО УСТАНОВИТЬ ЗНАЧЕНИЕ В ОБЪЕКТЕ В PROGRAM.CS УЖЕ НЕ ПОЛУЧИТЬСЯ

// public string? name, type; 
// public int age;
// public Dictionary<string,bool>? places = new Dictionary <string,bool>(); 

// public Person(string _name, string _type, int _age, Dictionary<string, bool>? _places) 
// {
//     System.Console.WriteLine("Person is created");
//     // name = _name; // эти параметры удалили/закомментили , Т.К. ниже ИСПОЛЬЗУЕТСЯ SetData
//     // type = _type;
//     // age = _age; 
//     // places = _places; 
//     SetData(_name, _type, _age, _places); 
//     // this.score = 5; //вот тут если написать все будет окей
// } 

// public Person(string _name, string _type, int _age) 
// {
//     System.Console.WriteLine("Person is created");
//     name = _name;
//     type = _type;
//     age = _age; 
// } 

// public Person (){}

// public void SetData(string name, string type, int age, Dictionary<string, bool>? places=null) {
//     this.name = name;
//     this.type = type; 
//     this.places = places; 
//     this.SetAge(age);  
//     // this.score = 5; //а вот тут если прописать, то будет ошибка, 
//     // -т.к. при исп модиф readonly назначать параметр можно только через констр(при созд объекта)
//     // однако если параметр score исп для вывода в объекте в файле program.cs:
//     // и написать: System.Console.WriteLine(bob.score); //, тоже всё будет окей, тоесть этот параметр можно использовать для чтения и вывода, 
//     // -но не для изменения
    
// } 

// public void SetAge(int _age) { 
//     if (_age < 0) 
//         System.Console.WriteLine("Возвраст должен быть больше 0");
//     else
//         age = _age; 
// }

// }





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

// // Теперь во всех ПОЛЯХ меняем public на private

// using System;  
// using System.Collections; 
// namespace project; 

// class Person { 

// private readonly int score; 

// private string? name, type; 
// private int age;
// private Dictionary<string,bool>? places = new Dictionary <string,bool>(); 

// public Person(string _name, string _type, int _age, Dictionary<string, bool>? _places) 
// {
//     System.Console.WriteLine("Person is created");
//     SetData(_name, _type, _age, _places); 
// } 

// public Person(string _name, string _type, int _age) 
// {
//     System.Console.WriteLine("Person is created");
//     name = _name;
//     type = _type;
//     age = _age; 
// } 

// public Person (){}

// public void SetData(string name, string type, int age, Dictionary<string, bool>? places=null) {
//     this.name = name;
//     this.type = type; 
//     this.places = places; 
//     this.SetAge(age);  
// } 

// public void SetAge(int _age) { 
//     if (_age < 0) 
//         System.Console.WriteLine("Возвраст должен быть больше 0");
//     else
//         age = _age; 
// }

// public void SetName(string _name) {  //создали еще метод, который задаёт имя и ниже метод который задаёт type
//     this.name = _name;
// }

// public void SetType(string _type) { 
//     this.type = _type;
// }

// public int GetAge() => this.age; // создали новый метод, однострочный(но можно и прописать больше), который будет возвращать age из класса
// // мы его используем вместо System.Console.WriteLine(alex.age);  вот это System.Console.WriteLine(alex.GetAge); 
// // -т.к. мы же согласно принц инкапс и private не можем напрямую обратиться к параметру, а только через методы


// public string? GetName() => this.name; //ну и тоже самое делаем и для других полей

// public string? GetPersonType() => this.type; 
// тоже самое, что написано строчкой выше можно написать вот так:
// public string GetType() {
// return this.type;
// }

// }

// // ИТОГ:
// // НУ И СООТВЕТСТВ ПО ПРИНЦИПУ ИНКАПС И Т.К. ВЕЗДЕ УСТАНОВИЛИ МОДИФ ДОСТ PRIVATE МЫ ТЕПЕРЬ МОЖЕМ УСТАНАВЛИВАТЬ ЗНАЧЕНИЯ ПОЛЕЙ ТОЛЬКО 
// // -ЧЕРЕЗ МЕТОДЫ И ПОЛУЧАТЬ ДАННЫЕ ИЗ ПОЛЕЙ ТОЖЕ ТОЛЬКО ЧЕРЕЗ МЕТОДЫ






// // Конструкторы7 , АКСЕССОРЫ
// // 

// using System;  
// using System.Collections; 
// namespace project; 

// class Person { 

// // private readonly int score;  //эту строчку закомментили, чтобы не возникало ошибки

// private string? name, type; 
// private int age;
// private Dictionary<string,bool>? places = new Dictionary <string,bool>(); 

// // public float PosX { //создаём аксессор(начинать читать через 10 строк в комменте)
// // get{
// //     return PosX; //тут мы прописали, что возвращаем то, что находится внутри нашего аксессора PosX 
// //     //также по желанию до return можно еще прописать код, например выводить что то с помощью cw
// // } 
// // set{
// //     if(value < 0 || value > 100) //ну и добавили условие, что если знач будет устанавливаться менее 0 или более 100 будет отобр ошибка
// //     System.Console.WriteLine("Неверное значение");
// //     else //ну а если значение между 0 и 100 , то оно будет записываться в value
// //     PosX = value; //тут мы указали, что при установке значения в PosX оно(значение) будет записываться в value

// // }
// // } //создаём аксессор, модиф доступа можно исп public и доступ будет напрямую, т.к. это никак не повлияет на концепцию инкапсуляции
// // ,т.к. мы не будем ссылаться напрямую к полям, а сможем ссылаться к аксессору, а он не является полем
// // далее указываем тип данных , В ЭТОМ ПОЛЕ МЫ ХРАНИМ ПОЗИЦИЮ ПОЛЬЗОВАТЕЛЯ ПО ИКСУ(XW)
// // далее мы не прописываем сразу =4, т.к. это было бы обычным полем, а прописываем фиг скобки, причем ; в конце добавлять не нужно
// // далее прописываем два метода get;(получ знач) и set;(уст знач), 
// // перед get и set можно прописать модиф дост private(напр private get;) тогда нельзя будет получ или установить знач
// // если private не прописывать, то будет использ-я public, т.к. он прописан раньше
// // далее после get и set открываем фиг скобки(тогда убираем ;, если не открываем, то не убир) и внутри прописываем что то вроде функций(методов)

// // ПО СУТИ МЫ СОЗДАЛИ КАК БУДЕТО НЕКОЕ ПОЛЕ И В НЁМ СРАЗУ ЖЕ ПРОПИСАЛИ МЕТОДЫ НЕОБХОДИМЫЕ ДЛЯ УСТАНОВКИ И ПОЛУЧЕНИЯ ЗНАЧЕНИЙ ПОЛЯ
// // кстати при помощи аксессоров можно даже работать с существующими полями например написать:
// public int Age{
//     get=> age;
//        set {
//             if(value > 0)
//             age = value;
//        }
// }

// // !!!!!! В ПОДДЕРЖКЕ МНЕ СКАЗАЛИ, ЧТО СНАЧАЛА СОЗДАЁМ ПОЛЕ С PRIVATE , А ЗАТЕМ УЖЕ ИСПОЛЬЗУЕМ для него МОДИФИКАТОР(или аксессор?):
// private float _posX; 

// public float PosX { 
//     get {
//         return _posX; 
//     } 
//     set{
//         if(value < 0 || value > 100) 
//             System.Console.WriteLine("Неверное значение");
//         else 
//             this._posX = value; 
    
//     }
// }


// // создаём второй аксессор, для позиции пользователя по Y
// public float PosY{
//     get=> PosY; //тут также получаем знач из PosY
//     set=> PosY = value; //а тут также записываем получ знач в value
// }
// // тоже самое(что выше) можно было записать вот так(код бы работал точно также, т.к. там нет никаких доп проверок):
// // public float PosY{
// //     get;
// //     set;
// // }

// public Person(string _name, string _type, int _age, Dictionary<string, bool>? _places) 
// {
//     System.Console.WriteLine("Person is created");
//     SetData(_name, _type, _age, _places); 
// } 

// public Person(string _name, string _type, int _age) 
// {
//     System.Console.WriteLine("Person is created");
//     name = _name;
//     type = _type;
//     age = _age; 
// } 

// public Person (){}

// public void SetData(string name, string type, int age, Dictionary<string, bool>? places=null) {
//     this.name = name;
//     this.type = type; 
//     this.places = places; 
//     this.SetAge(age);  
// } 

// public void SetAge(int _age) { 
//     if (_age < 0) 
//         System.Console.WriteLine("Возвраст должен быть больше 0");
//     else
//         age = _age; 
// }

// public void SetName(string _name) {  
//     this.name = _name;
// }

// public void SetType(string _type) { 
//     this.type = _type;
// }

// public int GetAge() => this.age; 


// public string? GetName() => this.name; 
// public string? GetPersonType() => this.type; 

// }

// // ИТОГ: ПРИ РАБОТЕ С КЛАССАМИ И ПОЛЯМИ ВСЕГДА НЕОБХОДИМО ДЛЯ НИХ УКАЗЫВАТЬ ИНКАПСУЛЯЦИЮ, Т.Е. ТО ЧТО ВСЕ ПОЛЯ ИМЕЮТ МОДИФ ДОСТУПА PRIVATE 
// // ИЛИ PROTECTED(О НЁМ ПОГОВОРИМ ПОЗЖЕ) , Т.Е. ПОЛЯ НЕ ДОЛЖНЫ БЫТЬ МАКС ПУБЛИЧ-И, ОНИ ДОЛЖНЫ БЫТЬ ВИДНЫ ЛИБО В ЭТОМ КЛАССЕ ЛИБО В КЛАСС НАСЛЕДН
// // ТАК ВОТ МЫ МОЖЕМ ЛИБО ПРОПИСЫВАТЬ МОДИФИКАТОРЫ ДОСТУПА ДЛЯ ПОЛЕЙ ЛИБО МОЖЕМ ИСПОЛЬЗОВАТЬ АКСЕССОРЫ С ПОМОЩЬЮ КОТОРЫХ МЫ ЛИБО
// // -РАБОТАЕМ С КАКИМИ ЛИБО ПОЛЯМИ ЛИБО САМ ПО СЕБЕ АКСЕССОР ОН И БУДЕТ СЧИТАТЬСЯ ПОЛНОЦ ПОЛЕМ И ПОЛНОЦ ЗНАЧЕН












// // Наследование


// using System;  
// using System.Collections; 
// namespace project; 

// class Person { 

// // private readonly int score;  //эту строчку закомментили, чтобы не возникало ошибки

// private string? name, type; 
// private int age;
// private Dictionary<string,bool>? places = new Dictionary <string,bool>(); 



// // ПО СУТИ МЫ СОЗДАЛИ КАК БУДЕТО НЕКОЕ ПОЛЕ И В НЁМ СРАЗУ ЖЕ ПРОПИСАЛИ МЕТОДЫ НЕОБХОДИМЫЕ ДЛЯ УСТАНОВКИ И ПОЛУЧЕНИЯ ЗНАЧЕНИЙ ПОЛЯ
// // кстати при помощи аксессоров можно даже работать с существующими полями например написать:
// public int Age{
//     get=> age;
//        set {
//             if(value > 0 && value < 100)
//             age = value;
//             else 
//             System.Console.WriteLine("Возраст должен быть больше чем 0");
//        }
// }

// public Person(string _name, string _type, int _age, Dictionary<string, bool>? _places) 
// {
//     System.Console.WriteLine("Person is created");
//     SetData(_name, _type, _age, _places); 
// } 

// public Person(string name, string type, int age) //корректируем конструктор
// {
//     System.Console.WriteLine("Person is created");
//     this.name = name;
//     this.type = type;
//     this.age = age; 
// } 

// public Person (){
//     System.Console.WriteLine("Object is created");
// } // если тут внутри фиг скобок что то прописать(напр cw), то если не передаются никакие данные в program.cs выведется это сообщение

// public void SetData(string name, string type, int age, Dictionary<string, bool>? places=null) {
//     this.name = name;
//     this.type = type; 
//     this.places = places; 
//     // this.SetAge(age);  // это тоже удалим , т.к. нет метода SetAge больше
//     this.age = age; // а эту строчку добавили
// } 

// // public void SetAge(int _age) { 
// //     if (_age < 0) 
// //         System.Console.WriteLine("Возвраст должен быть больше 0");
// //     else
// //         age = _age; 
// // }  // этот метод удалили, т.к. есть аксессор age через который можно задавать age


// // public int GetAge() => this.age; // этот метод удалили, т.к. есть аксессор age через который можно получать age

// public void SetName(string _name) {  
//     this.name = _name;
// }

// public void SetType(string _type) { 
//     this.type = _type;
// }



// public string? GetName() => this.name; 
// public string? GetPersonType() => this.type; 



// // создаём новый метод для вывода инф
// public void GetInfo(){
//     System.Console.WriteLine($"Игрок: {this.GetName()}. Тип: {this.GetPersonType()}. Возраст: {Age}.");
//     if(places == null || places.Count == 0)
//     return; // если places равен null или количество = 0, то просто выходим из функции
    
//     foreach(var el in places.Keys) { //тут мы перебир ключи, но можно и ключи и значения
//         System.Console.WriteLine(el); // и выводим всё что найдём
//     }
// }

// }







// // Наследование2, ПОЛИМОРФИЗМ


// using System;  
// using System.Collections; 
// namespace project; 

// class Person { 


// protected string? name, type; //изменили модификатор доступа с private на protected'
// // protected означает что элементы будут доступны только внутри класса и классов наследников, , т.е. через объект к нему обр не получится
// // ,но например в классе наследнике(напр player) внутри констр или метода можно прописать this.name = "lilCarrot";
// protected int age; //ну и во всех полях изм модиф доступа на protected, т.к. это логично, т.к. это родит класс
// protected Dictionary<string,bool>? places = new Dictionary <string,bool>(); 


// public int Age{
//     get=> age;
//        set {
//             if(value > 0 && value < 100)
//             age = value;
//             else 
//             System.Console.WriteLine("Возраст должен быть больше чем 0");
//        }
// }

// public Person(string _name, string _type, int _age, Dictionary<string, bool>? _places) 
// {
//     System.Console.WriteLine("Person is created");
//     SetData(_name, _type, _age, _places); 
// } 

// public Person(string name, string type, int age) 
// {
//     System.Console.WriteLine("Person is created");
//     this.name = name;
//     this.type = type;
//     this.age = age; 
// } 

// public Person (){
//     System.Console.WriteLine("Object is created");
// } 

// public void SetData(string name, string type, int age, Dictionary<string, bool>? places=null) {
//     this.name = name;
//     this.type = type; 
//     this.places = places; 
    
//     this.age = age; 
// } 


// public void SetName(string _name) {  
//     this.name = _name;
// }

// public void SetType(string _type) { 
//     this.type = _type;
// }


// public string? GetName() => this.name; 
// public string? GetPersonType() => this.type; 


// public virtual void GetInfo(){ //сделали этот метод виртуальным(virtual добавили) , 
// // это означает, что в классах наследниках он может быть переопределен
//     System.Console.WriteLine($"Игрок: {this.GetName()}. Тип: {this.GetPersonType()}. Возраст: {Age}.");
//     if(places == null || places.Count == 0)
//     return; 
    
//     foreach(var el in places.Keys) { 
//         System.Console.WriteLine(el); 
//     }
// }

// }







// // Модификатор доступа static


// using System;  
// using System.Collections; 
// namespace project; 

// class Person { 


// protected string? name, type; 
// protected int age; 
// protected Dictionary<string,bool>? places = new Dictionary <string,bool>(); 


// public int Age{
//     get=> age;
//        set {
//             if(value > 0 && value < 100)
//             age = value;
//             else 
//             System.Console.WriteLine("Возраст должен быть больше чем 0");
//        }
// }

// public Person(string _name, string _type, int _age, Dictionary<string, bool>? _places) 
// {
//     System.Console.WriteLine("Person is created");
//     SetData(_name, _type, _age, _places); 
// } 

// public Person(string name, string type, int age) 
// {
//     System.Console.WriteLine("Person is created");
//     this.name = name;
//     this.type = type;
//     this.age = age; 
// } 

// public Person (){
//     System.Console.WriteLine("Object is created");
// } 

// public void SetData(string name, string type, int age, Dictionary<string, bool>? places=null) {
//     this.name = name;
//     this.type = type; 
//     this.places = places; 
    
//     this.age = age; 
// } 


// public void SetName(string _name) {  
//     this.name = _name;
// }

// public void SetType(string _type) { 
//     this.type = _type;
// }


// public string? GetName() => this.name; 
// public string? GetPersonType() => this.type; 


// public virtual void GetInfo(){ 
//     System.Console.WriteLine($"Игрок: {this.GetName()}. Тип: {this.GetPersonType()}. Возраст: {Age}.");
//     if(places == null || places.Count == 0)
//     return; 
    
//     foreach(var el in places.Keys) { 
//         System.Console.WriteLine(el); 
//     }
// }

// }








// Модификатор доступа static2, практика
// Модификатор доступа static3
// // Модификатор доступа static4


// using System;  
// using System.Collections; 
// namespace project; 

// class Person { 


// protected string? name, type; 
// protected int age; 
// protected Dictionary<string,bool>? places = new Dictionary <string,bool>(); 


// public int Age{
//     get=> age;
//        set {
//             if(value > 0 && value < 100)
//             age = value;
//             else 
//             System.Console.WriteLine("Возраст должен быть больше чем 0");
//        }
// }

// public Person(string _name, string _type, int _age, Dictionary<string, bool>? _places) 
// {
//     System.Console.WriteLine("Person is created");
//     SetData(_name, _type, _age, _places); 
//     Users.count++;
// } 

// public Person(string name, string type, int age) 
// {
//     System.Console.WriteLine("Person is created");
//     this.name = name;
//     this.type = type;
//     this.age = age; 
//     Users.count++;
// } 

// public Person (){
//     System.Console.WriteLine("Object is created");
//     Users.count++;
// } 

// public void SetData(string name, string type, int age, Dictionary<string, bool>? places=null) {
//     this.name = name;
//     this.type = type; 
//     this.places = places; 
    
//     this.age = age; 
// } 


// public void SetName(string _name) {  
//     this.name = _name;
// }

// public void SetType(string _type) { 
//     this.type = _type;
// }


// public string? GetName() => this.name; 
// public string? GetPersonType() => this.type; 


// public virtual void GetInfo(){ 
//     System.Console.WriteLine($"Игрок: {this.GetName()}. Тип: {this.GetPersonType()}. Возраст: {Age}.");
//     if(places == null || places.Count == 0)
//     return; 
    
//     foreach(var el in places.Keys) { 
//         System.Console.WriteLine(el); 
//     }
// }

// }





// // Перечисления


// using System;  
// using System.Collections; 
// namespace project; 

// // создаём перечисление для поля type
// enum PersonType { Player, Enemy } //НЕ ЗАБЫВАЕМ , ЧТО ОНО НАХОДИТСЯ ЗА КЛАССОМ PERSON

// class Person { 


// protected string? name; //отсюда удаляем type

// // и создаём поле на основе перечисления PersonType:
// protected PersonType type; //ДАЛЕЕ ИСПРАВЛЯЕМ ОШИБКИ ВО ВСЕХ КОНСТР ВО ВСЕХ МЕТОДАХ И ВО ВСЕХ ФАЙЛАХ И КЛАССАХ СТАВИМ PersonType вместо string
// // для поля Type
// protected int age; 
// protected Dictionary<string,bool>? places = new Dictionary <string,bool>(); 


// public int Age{
//     get=> age;
//        set {
//             if(value > 0 && value < 100)
//             age = value;
//             else 
//             System.Console.WriteLine("Возраст должен быть больше чем 0");
//        }
// }

// public Person(string _name, PersonType _type, int _age, Dictionary<string, bool>? _places) 
// {
//     System.Console.WriteLine("Person is created");
//     SetData(_name, _type, _age, _places); 
//     Users.count++;
// } 

// public Person(string name, PersonType type, int age) 
// {
//     System.Console.WriteLine("Person is created");
//     this.name = name;
//     this.type = type;
//     this.age = age; 
//     Users.count++;
// } 

// public Person (){
//     System.Console.WriteLine("Object is created");
//     Users.count++;
// } 

// public void SetData(string name, PersonType type, int age, Dictionary<string, bool>? places=null) {
//     this.name = name;
//     this.type = type; 
//     this.places = places; 
    
//     this.age = age; 
// } 


// public void SetName(string _name) {  
//     this.name = _name;
// }

// public void SetType(PersonType _type) { 
//     this.type = _type;
// }


// public string? GetName() => this.name; 
// public string GetPersonType() { //меняем этот метод, чтобы выводилось не число, а текст
//     switch(this.type)
//     {
//         case PersonType.Player: return "Игрок"; //break прописывать не нужно, т.к. return когда исп, то выходит из этой функции
//         case PersonType.Enemy: return "Враг"; 
//         default: return "Такого нет"; //не забываем прописать default чтобы не выдавало ошибки
//     }
//     }


// public virtual void GetInfo(){ 
//     System.Console.WriteLine($"Игрок: {this.GetName()}. Тип: {this.GetPersonType()}. Возраст: {Age}.");
//     if(places == null || places.Count == 0)
//     return; 
    
//     foreach(var el in places.Keys) { 
//         System.Console.WriteLine(el); 
//     }
// }

// }










// // Абстрактные классы


// using System;  
// using System.Collections; 
// namespace project; 

// enum PersonType { Player, Enemy }

// abstract class Person { // т.к. мы не создаём на основе класса person объекты(а создаём объекты только на основе классов наследн) 
// // делаем его абстрактным

// // абстрактные методы - это такой метод, который мы не реализуем внутри абстракт класса, но при этом мы его обяз должны реализ в кл-х насл-х
// // например нам нужен метод,который будет во всех наших дочерних классах,
// //  который если будет вызываться в классе player он будет выполнять действие "Идти",
// // а если будет вызываться в методе enemy он будет выполнять действие "Ударять", 
// // т.е. метод для разных классов будет выполнять разные действия


// protected string? name; 
// protected PersonType type; 
// protected int age; 
// protected Dictionary<string,bool>? places = new Dictionary <string,bool>(); 


// public int Age{
//     get=> age;
//        set {
//             if(value > 0 && value < 100)
//             age = value;
//             else 
//             System.Console.WriteLine("Возраст должен быть больше чем 0");
//        }
// }

// // создаём аксессор
// protected abstract int Health {get; set;} // ну и также если необходимо чтобы они были указаны в классах наследниках,
// // то приписываем abstract // еще тут нельзя писать get{} , т.к. это абстрактный аксессор
// // далее идём в player cs и в enemy cs и реализовываем этот аксессор

// public Person(string _name, PersonType _type, int _age, Dictionary<string, bool>? _places) 
// {
//     System.Console.WriteLine("Person is created");
//     SetData(_name, _type, _age, _places); 
//     Users.count++;
// } 

// public Person(string name, PersonType type, int age) 
// {
//     System.Console.WriteLine("Person is created");
//     this.name = name;
//     this.type = type;
//     this.age = age; 
//     Users.count++;
// } 

// public Person (){
//     System.Console.WriteLine("Object is created");
//     Users.count++;
// } 

// // создаём абстрактный метод:
// public abstract void Action(); // тут мы не пишем фигурные скобки, ведь тут мы описываем только скелет

// public void SetData(string name, PersonType type, int age, Dictionary<string, bool>? places=null) {
//     this.name = name;
//     this.type = type; 
//     this.places = places; 
    
//     this.age = age; 
// } 


// public void SetName(string _name) {  
//     this.name = _name;
// }

// public void SetType(PersonType _type) { 
//     this.type = _type;
// }


// public string? GetName() => this.name; 
// public string GetPersonType() { 
//     switch(this.type)
//     {
//         case PersonType.Player: return "Игрок"; 
//         case PersonType.Enemy: return "Враг"; 
//         default: return "Такого нет"; 
//     }
//     }


// public virtual void GetInfo(){ 
//     System.Console.WriteLine($"Игрок: {this.GetName()}. Тип: {this.GetPersonType()}. Возраст: {Age}.");
//     if(places == null || places.Count == 0)
//     return; 
    
//     foreach(var el in places.Keys) { 
//         System.Console.WriteLine(el); 
//     }
// }

// }








// // Интерфейсы


// using System;  
// using System.Collections; 
// namespace project; 

// enum PersonType { Player, Enemy }

// abstract class Person : ITalk //решили интерфейс подключать всё таки тут(подробнее в player)
// // и т.к. мы тут прописали этот интерфейс он будет доступен и в enemy и в player
// { 

// protected string? name; 
// protected PersonType type; 
// protected int age; 
// protected Dictionary<string,bool>? places = new Dictionary <string,bool>(); 

// // указываем реализацию нашего аксессора
// public List<string> Words {get; set;} = new List <string>(); //модиф доступа изменили с protected на public, т.к. в ITalk он public по умолчанию
// // (даже если не прописан, т.к. это интерфейс)
// // изменили с массива на коллекцию
// // не забываем выделить память!


// public int Age{
//     get=> age;
//        set {
//             if(value > 0 && value < 100)
//             age = value;
//             else 
//             System.Console.WriteLine("Возраст должен быть больше чем 0");
//        }
// }


// protected abstract int Health {get; set;} 
// public Person(string _name, PersonType _type, int _age, Dictionary<string, bool>? _places) 
// {
//     System.Console.WriteLine("Person is created");
//     SetData(_name, _type, _age, _places); 
//     Users.count++;
// } 

// public Person(string name, PersonType type, int age) 
// {
//     System.Console.WriteLine("Person is created");
//     this.name = name;
//     this.type = type;
//     this.age = age; 
//     Users.count++;
// } 

// public Person (){
//     System.Console.WriteLine("Object is created");
//     Users.count++;
// } 

// public abstract void Action(); 

// public void SetData(string name, PersonType type, int age, Dictionary<string, bool>? places=null) {
//     this.name = name;
//     this.type = type; 
//     this.places = places; 
    
//     this.age = age; 
// } 


// public void SetName(string _name) {  
//     this.name = _name;
// }

// public void SetType(PersonType _type) { 
//     this.type = _type;
// }


// public string? GetName() => this.name; 
// public string GetPersonType() { 
//     switch(this.type)
//     {
//         case PersonType.Player: return "Игрок"; 
//         case PersonType.Enemy: return "Враг"; 
//         default: return "Такого нет"; 
//     }
//     }


// public virtual void GetInfo(){ 
//     System.Console.WriteLine($"Игрок: {this.GetName()}. Тип: {this.GetPersonType()}. Возраст: {Age}.");
//     if(places == null || places.Count == 0)
//     return; 
    
//     foreach(var el in places.Keys) { 
//         System.Console.WriteLine(el); 
//     }
//     }

//     // реализуем еще один метод:
//     // метод нужен чтобы перебирать элеенты из аксессора и возвращаем строку
//     public string AllWords() {
//     //     string result = "";
//     //     foreach(var el in Words){
//     //         result += el + ", ";
//     //     }
//     // return result; //эту часть кода упростили использовав join:
//         return String.Join(", ", Words);
//     }

//     public void Talk(string word) {
//         Words.Add(word);
//         System.Console.WriteLine(word); //добавили этот метод из ITalk, добавили модиф дост public // изменили немного метод
//     }
// }









// // Интерфейсы IEnumerable и IEnumerator


// using System;  
// using System.Collections; 
// namespace project; 

// enum PersonType { Player, Enemy }

// abstract class Person : ITalk 
// { 

// protected string? name; 
// protected PersonType type; 
// protected int age; 
// protected Dictionary<string,bool>? places = new Dictionary <string,bool>(); 

// // указываем реализацию нашего аксессора
// public List<string> Words {get; set;} = new List <string>(); 


// public int Age{
//     get=> age;
//        set {
//             if(value > 0 && value < 100)
//             age = value;
//             else 
//             System.Console.WriteLine("Возраст должен быть больше чем 0");
//        }
// }


// protected abstract int Health {get; set;} 
// public Person(string _name, PersonType _type, int _age, Dictionary<string, bool>? _places) 
// {
//     System.Console.WriteLine("Person is created");
//     SetData(_name, _type, _age, _places); 
//     Users.count++;
// } 

// public Person(string name, PersonType type, int age) 
// {
//     System.Console.WriteLine("Person is created");
//     this.name = name;
//     this.type = type;
//     this.age = age; 
//     Users.count++;
// } 

// public Person (){
//     System.Console.WriteLine("Object is created");
//     Users.count++;
// } 

// public abstract void Action(); 

// public void SetData(string name, PersonType type, int age, Dictionary<string, bool>? places=null) {
//     this.name = name;
//     this.type = type; 
//     this.places = places; 
    
//     this.age = age; 
// } 


// public void SetName(string _name) {  
//     this.name = _name;
// }

// public void SetType(PersonType _type) { 
//     this.type = _type;
// }


// public string? GetName() => this.name; 
// public string GetPersonType() { 
//     switch(this.type)
//     {
//         case PersonType.Player: return "Игрок"; 
//         case PersonType.Enemy: return "Враг"; 
//         default: return "Такого нет"; 
//     }
//     }


// public virtual void GetInfo(){ 
//     System.Console.WriteLine($"Игрок: {this.GetName()}. Тип: {this.GetPersonType()}. Возраст: {Age}.");
//     if(places == null || places.Count == 0)
//     return; 
    
//     foreach(var el in places.Keys) { 
//         System.Console.WriteLine(el); 
//     }
//     }


//     public string AllWords() {
//         return String.Join(", ", Words);
//     }

//     public void Talk(string word) {
//         Words.Add(word);
//         System.Console.WriteLine(word); 
//     }
// }





// // Операторы is as

namespace project;

class Person{}