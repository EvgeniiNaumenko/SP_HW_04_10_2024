//using Microsoft.CodeAnalysis.CSharp.Scripting;
//using Microsoft.CodeAnalysis.Scripting;

//class Program
//{
//    static async Task Main(string[] args)
//    {
//        //Создайте консольное приложение, которое позволит пользователю решать арифметические выражения.
//        Console.WriteLine("Введите арифметическое выражение для решения (например, Math.Pow(x, y), Math.Sqrt(x) или 3 + 5 * 2):");

//        //"Math.Sqrt(x)  // Квадратный корень числа x; " 
//        //"Math.Pow(x, y)  // x в степени y; " 
//        //"Math.Sin(angle)  // Синус угла (в радианах); " 
//        //"Math.Cos(angle)  // Косинус угла (в радианах); " 
//        //"Math.Tan(angle)  // Тангенс угла (в радианах); " 
//        //"Math.Acos(value)  // Арккосинус числа value; " 
//        //"Math.Asin(value)  // Арксинус числа value; " 
//        //"Math.Atan(value)  // Арктангенс числа value; " 
//        //"Math.Atan2(y, x)  // Арктангенс частного y/x; " 
//        //"Math.Cosh(value)  // Гиперболический косинус числа value; " 
//        //"Math.Sinh(value)  // Гиперболический синус числа value; " 
//        //"Math.Tanh(value)  // Гиперболический тангенс числа value; " 
//        //"Math.Log(value)  // Натуральный логарифм числа value; " 
//        //"Math.Log10(value)  // Логарифм числа value по основанию 10; " 
//        //"Math.Log(value, base)  // Логарифм числа value по основанию base; " 
//        //"Math.Ceiling(value)  // Округляет число value вверх до ближайшего целого; " 
//        //"Math.Floor(value)  // Округляет число value вниз до ближайшего целого; " 
//        //"Math.Round(value)  // Округляет число value до ближайшего целого; " 
//        //"Math.Abs(value)  // Абсолютное значение числа value; " 
//        //"Math.Min(value1, value2)  // Минимальное значение между value1 и value2; " 
//        //"Math.Max(value1, value2)  // Максимальное значение между value1 и value2."

//        string expression = Console.ReadLine();

//        try
//        {
//            var scriptOptions = ScriptOptions.Default
//                .AddReferences(typeof(System.Math).Assembly)
//                .AddImports("System", "System.Math");
//            var result = await CSharpScript.EvaluateAsync<decimal>(expression, scriptOptions);
//            Console.WriteLine($"Результат: {result}");
//        }
//        catch (CompilationErrorException ex)
//        {
//            Console.WriteLine("Ошибка в выражении:");
//            foreach (var diagnostic in ex.Diagnostics)
//            {
//                Console.WriteLine(diagnostic);
//            }
//        }
//        Console.WriteLine("Нажмите любую клавишу для выхода...");
//        Console.ReadKey();
//    }
//}

//Создайте dll-модуль, который содержит класс для проверки контактных данных пользователя:
//    ФИО, возраст, телефон, email. В классе должны быть статические методы для проверки:

//■ ФИО содержит только буквы; 
//■ Возраст содержит только цифры;
//■ Телефон должен соответствовать заданному формату; 
//■ Email должен соответствовать заданному формату. 
//Подключите dll-модуль к другому проекту и проверьте работу методов.

namespace UserValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            string fullName = "Боб Бобович Бобстер";
            string age = "40";
            string phone = "+380663576869";
            string email = "bob_bobovi4_123@gmail.com";

            if (UserValidator.ValidateFullName(fullName))
            {
                Console.WriteLine("ФИО корректно.");
            }
            else
            {
                Console.WriteLine("Ошибка в ФИО.");
            }
            if (UserValidator.ValidateAge(age))
            {
                Console.WriteLine("Возраст корректен.");
            }
            else
            {
                Console.WriteLine("Ошибка в возрасте.");
            }
            if (UserValidator.ValidatePhone(phone))
            {
                Console.WriteLine("Телефон корректен.");
            }
            else
            {
                Console.WriteLine("Ошибка в телефоне.");
            }
            if (UserValidator.ValidateEmail(email))
            {
                Console.WriteLine("Email корректен.");
            }
            else
            {
                Console.WriteLine("Ошибка в email.");
            }

            Console.ReadLine();
        }
    }
}