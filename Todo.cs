// обработка json

// +мы установили библиотеку через терминал (позже на курсе через visual studio мы мы научимся устанавливать библиотеки 
// через пакетный менеджер nuGet сразу же из графического интерфейса)
// чтобы подкл библ через терм пишем: dotnet add(добавл) package(пакет) Newtonsoft.Json(назв библ)
// проверить установку библ можно в файле project.csproj в тэге <ItemGroup>

namespace project;

class Todo {
    // создаём поля:
    public int userId, id;
    public string? title; // не забываем ?

    public bool completed;

}
