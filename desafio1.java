// 
import java.util.Scanner;

public class desafio1 {

    public static void main(String[] args) {
        Scanner leitor = new Scanner(System.in);
        System.out.println("Qual o valor do seu salário: ");
        float valorSalario = leitor.nextFloat();
        System.out.println("Qual o valor do seu benefício: ");
        float valorBeneficio = leitor.nextFloat();

        float valorImposto = 0;
        if(valorSalario < 0){
            System.out.println("Valor inválido");
        }
        else if(valorSalario >= 0 && valorSalario <= 1100){
            valorImposto = 0.05f * valorSalario;
        } else if (valorSalario >= 1100.01 && valorSalario <= 2500){
            valorImposto = 0.10f * valorSalario;
        } else {
            valorImposto = 0.15f * valorSalario;
        }

        float saida = valorSalario - valorImposto + valorBeneficio;
        System.out.println("O valor final do salário é: " + String.format("%.2f", saida));
    }
}
