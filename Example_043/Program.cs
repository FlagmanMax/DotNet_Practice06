// Задача 43. Напишите программу, которая найдёт точку
// пересечения двух прямых, заданных уравнениями y = k1 *
// x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются
// пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 =
// 9 -> (-0,5; 5,5)
void FindCrossPoint(double[] coef1, double[] coef2)
{
    if (coef1[0]==coef2[0])
    {
        if (coef1[1] == coef2[1])
        {
            Console.WriteLine("Прямые совпадают");
        }
        else
        {
            Console.WriteLine("Прямые не пересекаются");
        }
    }
    else
    {
        double x = (coef2[1]-coef1[1])/(coef1[0]-coef2[0]);
        double y = coef1[0]*x + coef1[1];
        Console.WriteLine($"Координаты точки пересечения прямых ({x},{y})");
    }
}

void InputCoefForLine(double[] coef)
{
    Console.WriteLine("Введите коэффициенты k и b прямой:");
    Console.Write("k=");
    coef[0] = Convert.ToDouble(Console.ReadLine());
    Console.Write("b=");
    coef[1] = Convert.ToDouble(Console.ReadLine());
}

double[] line1 = new double[2];
double[] line2 = new double[2];

InputCoefForLine(line1);
InputCoefForLine(line2);
FindCrossPoint(line1, line2);


