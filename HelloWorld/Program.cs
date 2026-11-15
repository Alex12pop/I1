// Console.WriteLine("Hello, World!");


// Console.WriteLine("Привет от ИСП-242!");
// Console.WriteLine("Автор: Изингер Алексей");
// Console.WriteLine("Год: 2026");


// int age = 20;
// double gpa = 4.5;
// bool isStudent = true;
// string name = "Алексей";

// Console.WriteLine(name);
// Console.WriteLine(age);
// Console.WriteLine(gpa);
// Console.WriteLine(isStudent);



// var city = "Москва"; // тип определится как string
// var year = 2026;     // тип определится как int
// var pi = 3.14159;    // тип определится как double
// var isActive = true; // тип определится как bool



// string myName = "Алексей";
// int myAge = 20;
// string myGroup = "ИСП-242";

// Console.WriteLine($"Меня зовут {myName}, мне {myAge} лет, я учусь в группе {myGroup}.");



// // Текстовый ввод
// Console.Write("Введите ваше имя: ");
// string name2 = Console.ReadLine();
// Console.WriteLine($"Привет, {name2}!");

// // Числовой ввод с конвертацией
// Console.Write("Введите ваш возраст: ");
// string input = Console.ReadLine();
// int age2 = int.Parse(input);
// Console.WriteLine($"Через 10 лет вам будет {age2 + 10} лет.");



// int x = 10;
// int y = 3;
// Console.WriteLine(x + y); // 13
// Console.WriteLine(x - y); // 7
// Console.WriteLine(x * y); // 30
// Console.WriteLine(x / y); // 3 (целочисленное деление!)
// Console.WriteLine(x % y); // 1 (остаток от деления)



// string firstName = "Алексей";
// string lastName = "Изингер";
// string group = "ИСП-242";
// int birthYear = 2007;
// double gpa = 4.5;
// bool hasScholarship = true;

// int currentYear = 2026;
// int age = currentYear - birthYear;

// Console.WriteLine("Студенческое удостоверение");
// Console.WriteLine($"Имя: {firstName} {lastName}");
// Console.WriteLine($"Группа: {group}");
// Console.WriteLine($"Возраст: {age} лет");
// Console.WriteLine($"Средний балл: {gpa}");
// Console.WriteLine($"Стипендия: {hasScholarship}");

// Console.Write("\nВведите ваш любимый предмет: ");
// string subject = Console.ReadLine();
// Console.WriteLine($"Отлично! {firstName} любит {subject}.");


// int a = 15;
// int b = 4;

// Console.WriteLine($"Сумма: {a + b}");
// Console.WriteLine($"Разность: {a - b}");
// Console.WriteLine($"Произведение: {a * b}");
// Console.WriteLine($"Частное (int): {a / b}");
// Console.WriteLine($"Остаток: {a % b}");

// // Дробный результат через casting
// double result = (double)a / b;
// Console.WriteLine($"Частное (double): {result}");



// Console.WriteLine(Math.Abs(-5));
// Console.WriteLine(Math.Pow(2, 10));
// Console.WriteLine(Math.Sqrt(144));
// Console.WriteLine(Math.Max(10, 25));
// Console.WriteLine(Math.Min(10, 25));
// Console.WriteLine(Math.Round(3.567, 2));

// Console.WriteLine("Калькулятор");
// Console.Write("Введите первое число: ");
// double num1 = double.Parse(Console.ReadLine());

// Console.Write("Введите второе число: ");
// double num2 = double.Parse(Console.ReadLine());

// Console.WriteLine($"Сумма: {num1 + num2}");
// Console.WriteLine($"Разность: {num1 - num2}");
// Console.WriteLine($"Произведение: {num1 * num2}");

// if (num2 != 0)
// {
//     Console.WriteLine($"Частное: {num1 / num2}");
// }
// else
// {
//     Console.WriteLine("Деление на ноль невозможно!");
// }


// Console.WriteLine(int.MaxValue);
// Console.WriteLine(int.MinValue);
// Console.WriteLine(double.MaxValue);
// Console.WriteLine(double.MinValue);

// int metr1 = 1;
// System.Int32 metr2 = 1;


// Console.WriteLine("Добро пожаловать в анкету!");


// Console.Write("Введите ваше имя: ");
// string name = Console.ReadLine();

// Console.Write("Введите вашу фамилию: ");
// string surname = Console.ReadLine();

// Console.Write("Введите вашу группу: ");
// string group = Console.ReadLine();

// Console.Write("Введите ваш год рождения: ");
// int birthYear = int.Parse(Console.ReadLine());

// Console.Write("Введите ваш средний балл (например, 4.5): ");
// double gpa = double.Parse(Console.ReadLine());


// int currentYear = 2026;
// int age = currentYear - birthYear;
// bool isExcellent = gpa >= 4.5;


// string status = isExcellent ? "Отличник" : "Хорошист";

// Console.WriteLine("\nВаша анкета");
// Console.WriteLine($"Имя: {name} {surname}");
// Console.WriteLine($"Группа: {group}");
// Console.WriteLine($"Возраст: {age} лет");
// Console.WriteLine($"Средний балл: {gpa}");
// Console.WriteLine($"Статус: {status}");
// Console.WriteLine($"Лет до 30: {30 - age}");

// Console.WriteLine("\nНажмите Enter для выхода...");
// Console.ReadLine();




string favoriteMedia = "LuckyStar"; 
int favoriteNumber = 7;
double piValue = 3.1415926535;
char favoriteLetter = 'Z';

Console.WriteLine($"Любимая игра/кино/аниме: {favoriteMedia}");
Console.WriteLine($"Любимая цифра: {favoriteNumber}");
Console.WriteLine($"Значение числа пи: {piValue}");
Console.WriteLine($"Любимая буква алфавита: {favoriteLetter}");


Console.WriteLine("I");
Console.WriteLine("need");
Console.WriteLine("more");
Console.WriteLine("power!");


Console.WriteLine("\"Hello There\"");



int monitorPrice = int.Parse(Console.ReadLine());
int casePrice = int.Parse(Console.ReadLine());
int keyboardPrice = int.Parse(Console.ReadLine());
int mousePrice = int.Parse(Console.ReadLine());

int totalCostOnePc = monitorPrice + casePrice + keyboardPrice + mousePrice;
int totalCostThreePcs = totalCostOnePc * 3;

Console.WriteLine(totalCostThreePcs);



int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());


double result = 3 * Math.Pow(a + b, 3) + 275 * Math.Pow(b, 2) - 127 * a - 41;

Console.WriteLine(result);


double celsius = double.Parse(Console.ReadLine());

double fahrenheit = (celsius * 9 / 5) + 32;

Console.WriteLine($"Температура: {fahrenheit}°F");
