public class CalcoliHelper
{
    public static int Sum (int num1, int num2)
    {
        int result = num1 + num2;
        return result;
    }

    public static double DoubleSum(double num1, double num2)
    {
        double result = num1 + num2;
        return result;
    }

    public static int Difference(int num1, int num2)
    {
        int result = num1 / num2;
        return result;
    }

    public static double DifferenceDouble(double num1, double num2)
    {
        double result = num1 / num2;
        return result;
    }

    public static int Multiplication(int num1, int num2)
    {
        int result = num1 * num2;
        return result;
    }

    public static double MultiplicationDouble(double num1, double num2)
    {
        double result = num1 * num2;
        return result;
    }

    public static int AbsoluteValue(int num)
    {
        if (num == 0)
        {
            return 0;
        }
        else if (num < 0)
        {
            return -num;
        }
        return num;
    }

    public static double AbsoluteValueDouble(double num)
    {
        if (num == 0)
        {
            return 0;
        }
        else if (num < 0)
        {
            return -num;
        }
        return num;
    }
}