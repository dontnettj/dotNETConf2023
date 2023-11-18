var lamdaMethod = (string menuName = "Home page") => $"<li>{menuName}</li>";

Console.WriteLine(lamdaMethod());
Console.WriteLine(lamdaMethod("About us"));