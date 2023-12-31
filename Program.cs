﻿string continuar = "0";
do {
    //Coletando os dados:
    Console.Write("Digite seu nome: ");
    string nome = (Console.ReadLine());

    Console.Write("Digite sua idade: ");
    int idade = Convert.ToInt32(Console.ReadLine());

    Console.Write("Digite sua altura: ");
    double altura = Convert.ToDouble(Console.ReadLine());

    Console.Write("Digite seu peso: ");
    double peso = Convert.ToDouble(Console.ReadLine());

    //Calculando IMC
    double imc = peso / (altura * altura);

    string faixaEtaria = "0";
    if (idade >= 0 && idade <= 11) {
        faixaEtaria = "Criança";
    }
    else if (idade >= 12 && idade <= 17) {
        faixaEtaria = "Adolescente";
    }
    else if (idade >= 18 && idade <= 59) {
        faixaEtaria = "Adulto";
    }
    else if (idade >= 60) {
        faixaEtaria = "Idoso";
    }

    string imcInfo = "0";
    if (imc < 18.5) {
        imcInfo = "Abaixo do peso";
    }
    else if (imc >= 18.6 && imc <= 24.9) {
        imcInfo = "Peso ideal";
    }
    else if (imc >= 25.0 && imc <= 29.9) {
        imcInfo = "Levemente acima do peso";
    }
    else if (imc >= 30.0 && imc <= 34.9) {
        imcInfo = "Obesidade";
    }
    else if (imc >= 35.0 && imc <= 39.9) {
        imcInfo = "Obesidade Severa";
    }
    else if (imc >= 40) {
        imcInfo = "Obesidade Mórbida";
    }

    //Relatório
    Console.WriteLine("\n =-=-=-=-=-=-= Informações =-=-=-=-=-=-=");
    Console.WriteLine($"\tNome: {nome}\n");
    Console.WriteLine($"\tIdade: {idade}\n");
    Console.WriteLine("\tFaixa etária: " + faixaEtaria);
    Console.WriteLine("\tIMC: " + imc);
    Console.WriteLine("\tStatus: " + imcInfo);
    Console.Write("\nDeseja continuar (s/n)?\n");
    continuar = Console.ReadLine().ToLower();
    Console.WriteLine("\n =-=-=-=-=-=-= =---------= =-=-=-=-=-=-=");

} while (continuar.ToLower() == "s");

Console.WriteLine("\tFinalizando programa.");
Console.WriteLine("\n =-=-=-=-=-=-= =---------= =-=-=-=-=-=-=");