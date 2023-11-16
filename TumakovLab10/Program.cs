using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TumakovLab10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Упражнение 10.1(Создать интерфейс ICipher, который определяет методы поддержки шифрования строк)");
            ICipher aCipher = new ACipher();
            string text = "Hello";
            string encodedTextA = aCipher.encode(text);
            Console.WriteLine("Зашифрованный текст: " + encodedTextA);
            string decodedTextA = aCipher.decode(encodedTextA);
            Console.WriteLine("Дешифрованный текст: " + decodedTextA);
            Console.WriteLine();
            ICipher bCipher = new BCipher();
            string text1 = "Hello";
            string encodedTextB = bCipher.encode(text1);
            Console.WriteLine("Зашифрованный текст: " + encodedTextB);
            string decodedTextB = bCipher.decode(encodedTextB);
            Console.WriteLine("Дешифрованный текст: " + decodedTextB);
            Console.WriteLine() ;

            Console.WriteLine("Домашнее задание 10.1(Создать класс Figure для работы с геометрическими фигурами)");
            Point point = new Point(5, 15, "Yellow", true);
            point.MoveX(5);
            point.ChangeColor("Black");
            point.Print();
            Console.WriteLine();

            Circle circle = new Circle(3, 7, "Blue", false, 10);
            circle.MoveY(15);
            double circleArea = circle.CalculateAreaCircle();
            Console.WriteLine("Circle area: {0}", circleArea);
            circle.Print();
            Console.WriteLine();

            Rectangle rectangle = new Rectangle(50, 60, "Orange", true, 20, 30);
            rectangle.MoveX(10);
            int rectangleArea = rectangle.CalculateAreaRectangle();
            Console.WriteLine("Rectangle area: {0}", rectangleArea);
            rectangle.Print();
            Console.WriteLine();

        }
    }
}
