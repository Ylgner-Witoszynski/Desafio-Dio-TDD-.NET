namespace Calculadora.Core;

public class Calculadora
{
    public int Somar(int a, int b)
    {
        return a + b;
    }

    public int Subtrair(int a, int b)
    {
        return a - b;
    }

    public int Multiplicar(int a, int b)
    {
        return a * b;
    }

    public int Dividir(int a, int b)
    {
        if (b == 0)
        {
            throw new ArgumentException("Não é possível dividir por zero.", nameof(b));
        }
        return a / b;
    }
}