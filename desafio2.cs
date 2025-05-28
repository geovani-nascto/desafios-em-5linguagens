using System;

public class desafio2{

    // Lê os valores de Entrada:
    float valorSalario = float.Parse(Console.ReadLine());
    float valorBeneficio = float.Parse(Console.ReadLine());

    float valorImposto = 0;
    if(valorSalario >= 0 && valorSalario <= 1100){
        valorImposto = 0.05f * valorSalario;
    }

    float salarioFinal = valorSalario - valorImposto + valorBeneficio;
    Console.Write(saida.ToString("0.00"))
}