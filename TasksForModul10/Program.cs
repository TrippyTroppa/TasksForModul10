using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace TasksForModul10
{
    using System;

    #region Задание 1. Интерфейс и реализация калькулятора
    public interface ICalculator
    {
        double Add(double a, double b);
    }

    public class SimpleCalculator : ICalculator
    {
        public double Add(double a, double b) => a + b;
    }
    #endregion

    #region Задание 2. Логгер с цветным выводом
    public interface ILogger
    {
        void LogInfo(string message);
        void LogError(string message);
    }

    public class ConsoleLogger : ILogger
    {
        public void LogInfo(string message)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"[INFO]  {message}");
            Console.ResetColor();
        }

        public void LogError(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"[ERROR] {message}");
            Console.ResetColor();
        }
    }
    #endregion

    #region Консольное приложение
    class Program
    {
        private readonly ICalculator _calculator;
        private readonly ILogger _logger;

        // «внедрение зависимостей» через конструктор
        public Program(ICalculator calculator, ILogger logger)
        {
            _calculator = calculator;
            _logger = logger;
        }

        static void Main()
        {
            var calc = new SimpleCalculator();
            var log = new ConsoleLogger();
            var app = new Program(calc, log);

            app.Run();
        }

        private void Run()
        {
            _logger.LogInfo("Мини-калькулятор запущен.");
            Console.WriteLine("Введите два числа через пробел (например 3,5  2,1):");

            try
            {
                var parts = Console.ReadLine()!.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                if (parts.Length != 2)
                    throw new FormatException("Ожидается ровно два числа.");

                if (!double.TryParse(parts[0], out double a) ||
                    !double.TryParse(parts[1], out double b))
                    throw new FormatException("Неверный формат чисел.");

                double result = _calculator.Add(a, b);
                _logger.LogInfo($"Результат: {a} + {b} = {result}");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
            }
            finally
            {
                _logger.LogInfo("Работа калькулятора завершена. Нажмите любую клавишу...");
                Console.ReadKey();
            }
        }
    }
    #endregion
}
