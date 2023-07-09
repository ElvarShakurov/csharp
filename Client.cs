

// async await2 

// using System.Net.Http; //подключаем это пространство, чтобы ниже использовать в создании поля метод httpClient
// namespace project;

// class Client {

// //создаём статичные поля и методы:
// // для этого поля private, т.к. оно будет исп только внутри класса
// private static HttpClient client = new HttpClient(); //поле на осн метода HttpClient и далее пишем назв поля и далее выделяем память
// // суть HttpClient это то что мы можем с помощью можем создавать обращение по определённому url адресу 
// // и с определённого url адреса можем получать определённые ответы

// // создаём еще один статичный метод, он будет публичным, т.к. мы к нему будет обр через название класса через точку (в program cs видимо):
// public static async Task<string> GetData() { //Task добавили, чтобы было с ожиданием

// // создаём внутри метода строку для ответа по url адр:
// string responce = await client.GetStringAsync("https://regres.in/api/users/2"); //тут обр к методу client и через точку к спец-у методу GetStringAsync
// // метод GetStringAsync позволяет получить данные асинхронно
// // и т.к. данные получаются асинхронно мы добавляем await
// // грубо говоря мы создали асинхронный метод , который возвращает Task , который будет ожидать ответа по определённому url адресу
// // внутри "" пишем url по которому обращаемся (api)

// return responce; //чтобы мы могли возвращать переменную, а не только ожидание пишем сверху Task<> (обобщение) и внутри пропис string
// }

// }


using System.Net.Http; //подключаем это пространство, чтобы ниже использовать в создании поля метод httpClient
namespace project;

class Client {
private static HttpClient client = new HttpClient();
public static async Task<string> GetData() { 
return await client.GetStringAsync("https://jsonplaceholder.typicode.com/todos/1"); //меняем url
}
}