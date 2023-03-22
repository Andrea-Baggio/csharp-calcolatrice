public class CalcoliHelper
{
    public static int Sum (int num1, int num2)
    {
        int result = num1 + num2;
        return result;
    }

    public static double Sum(double num1, double num2)
    {
        double result = num1 + num2;
        return result;
    }

    public static int Difference(int num1, int num2)
    {
        int result = num1 / num2;
        return result;
    }

    public static double Difference(double num1, double num2)
    {
        double result = num1 / num2;
        return result;
    }

    public static int Multiplication(int num1, int num2)
    {
        int result = num1 * num2;
        return result;
    }

    public static double Multiplication(double num1, double num2)
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

    public static double AbsoluteValue(double num)
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

    public static int Minimum(int num1, int num2)
    {
        if (num1 > num2)
        {
            return num2;
        }
        else if (num1 < num2)
        {
            return num1;
        }
        return 0;
    }

    public static double Minimum(double num1, double num2)
    {
        if (num1 > num2)
        {
            return num2;
        }
        else if (num1 < num2)
        {
            return num1;
        }
        return 0;
    }

    public static int Maximum(int num1, int num2)
    {
        if (num1 > num2)
        {
            return num1;
        }
        else if (num1 < num2)
        {
            return num2;
        }
        return 0;
    }

    public static double Maximum(double num1, double num2)
    {
        if (num1 > num2)
        {
            return num1;
        }
        else if (num1 < num2)
        {
            return num2;
        }
        return 0;
    }
}