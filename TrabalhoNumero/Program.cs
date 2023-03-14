using System;

class Programa {
    static void Main(string[] args) {
        Console.Write("Digite um número: ");
        int valor = int.Parse(Console.ReadLine());
        Console.WriteLine(NumeroPorExtenso(valor));
    }
    
    static string NumeroPorExtenso(int valor) {
        if (valor == 0) {
            return "zero";
        }
        if (valor < 0) {
            return "menos " + NumeroPorExtenso(-valor);
        }
        if (valor <= 19) {
            string[] unidade = {
                "um", "dois", "três", "quatro", "cinco",
                "seis", "sete", "oito", "nove", "dez",
                "onze", "doze", "treze", "quatorze", "quinze",
                "dezesseis", "dezessete", "dezoito", "dezenove"
            };
            return unidade[valor - 1];
        }
        if (valor <= 99) {
            string[] dezena = {
                "vinte", "trinta", "quarenta", "cinquenta",
                "sessenta", "setenta", "oitenta", "noventa"
            };
            string resultado = dezena[valor / 10 - 2];
            if (valor % 10 != 0) {
                resultado += " e " + NumeroPorExtenso(valor % 10);
            }
            return resultado;
        }
        if (valor <= 999) {
            string resultado = NumeroPorExtenso(valor / 100) + "cento";
            if (valor % 100 != 0) {
                resultado += " e " + NumeroPorExtenso(valor % 100);
            }
            return resultado;
        }
        if (valor <= 999999) {
            string resultado = NumeroPorExtenso(valor / 1000) + " mil";
            if (valor % 1000 != 0) {
                resultado += " e " + NumeroPorExtenso(valor % 1000);
            }
            return resultado;
        }
        if (valor <= 999999999) {
            string resultado = NumeroPorExtenso(valor / 1000000) + " milhões";
            if (valor % 1000000 != 0) {
                resultado += " e " + NumeroPorExtenso(valor % 1000000);
            }
            return resultado;
        }
        return "número muito grande";
    }
}
