using System;

public class desafio2
{

    public static void Main()
    {

        // Lê os valores de Entrada:
        float valorSalario = float.Parse(Console.ReadLine());
        float valorBeneficio = float.Parse(Console.ReadLine());

        float valorImposto = 0;
        if(valorSalario >= 0 && valorSalario <= 1100)
        {
            valorImposto = 0.05F * valorSalario;
        }
        else if(valorSalario >= 1100.01 && valorSalario <= 2500)
        {
            valorImposto = 0.10F * valorSalario;
        }
        else
        {
            valorImposto = 0.15F * valorSalario;
        }
        float salarioFinal = valorSalario - valorImposto + valorBeneficio;
        Console.WriteLine(salarioFinal.ToString("0.00"));
    }
}