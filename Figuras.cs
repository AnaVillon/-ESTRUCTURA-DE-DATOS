// Clase Circulo: encapsula el radio como dato primitivo
// y proporciona métodos para calcular el área y el perímetro.

public class Circulo
{
    // Atributo privado (encapsulamiento)
    private double radio;

    // Constructor para inicializar el radio del círculo
    public Circulo(double radio)
    {
        this.radio = radio;
    }

    // CalcularArea es un método que devuelve un valor double
    // Utiliza la fórmula: área = PI * radio^2
    public double CalcularArea()
    {
        return Math.PI * radio * radio;
    }

    // CalcularPerimetro devuelve un valor double
    // Fórmula: perímetro = 2 * PI * radio
    public double CalcularPerimetro()
    {
        return 2 * Math.PI * radio;
    }
}


// Clase Rectangulo: encapsula la base y la altura como datos primitivos
// y proporciona métodos para calcular el área y el perímetro.

public class Rectangulo
{
    // Atributos privados
    private double baseRect;
    private double altura;

    // Constructor para inicializar base y altura del rectángulo
    public Rectangulo(double baseRect, double altura)
    {
        this.baseRect = baseRect;
        this.altura = altura;
    }

    // Método para calcular el área
    // Fórmula: base * altura
    public double CalcularArea()
    {
        return baseRect * altura;
    }

    // Método para calcular el perímetro
    // Fórmula: 2 * (base + altura)
    public double CalcularPerimetro()
    {
        return 2 * (baseRect + altura);
    }
}


