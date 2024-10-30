
class Estudiante
{
    // Propiedades del estudiante
    public int Creditos { get; set; }
    public int Estrato { get; set; }
    public double ValorCredito { get; set; }

    // Constructor para inicializar las propiedades
    public Estudiante(int creditos, int estrato, double valorCredito)
    {
        Creditos = creditos;
        Estrato = estrato;
        ValorCredito = valorCredito;
    }

    // Método para calcular el costo de la matrícula
    public double CalcularMatricula()
    {
        double costo = 100000;
        if (Creditos <= 20)
        {
            costo = Creditos * ValorCredito;
        }
        else
        {
            costo = 20 * ValorCredito + (Creditos - 20) * ValorCredito * 2;
        }

        double descuento = 0;
        switch (Estrato)
        {
            case 1:
                descuento = 0.80;
                break;
            case 2:
                descuento = 0.50;
                break;
            case 3:
                descuento = 0.30;
                break;
        }

        costo = costo * (1 - descuento);
        return costo;
    }


    // Método para calcular el subsidio
    public double CalcularSubsidio()
    {
        if (Estrato == 1)
        {
            return 200000;
        }
        else if (Estrato == 2)
        {
            return 100000;
        }
        else
        {
            return 0;
        }
    }
}