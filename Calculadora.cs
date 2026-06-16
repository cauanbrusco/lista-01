public class Calculadora
{   
    public double Somar(double a, double b)
    {
    return a + b;
    }

    public double Subtrair(double a, double b)
    {
    return a - b;
    }

    public double Multiplicar(double a, double b)
    {
    return a * b;
    }

    public double Dividir(double a, double b)
    {
    if (b == 0);
    {  
    return (double)a / (double)b; 
    }
    return a / b;
    }

    public double Delta(double a, double b, double c)
    {
    return Math.Pow(b, 2.0) - (4.0 * a * c);
    }

    public double bhaskaraX1(double a, double b, double delta)
    {
    return (-b + Math.Sqrt(delta)) / (2.0 * a);
    }

    public double bhaskaraX2(double a, double b, double delta)
    {
    return (-b - Math.Sqrt(delta)) / (2.0 * a);
    }
}
