﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista8PR2._
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    internal class Program
    {
      
        
            public static void Exercicio1()
            {
                Console.WriteLine("Exercicio 1");

                int nprod, preço, total = 0;

                while (true)
                {
                    Console.WriteLine("Digite 0 para finalizar o programa! ");

                    Console.WriteLine("Digite a quantidade do produto ");
                    nprod = int.Parse(Console.ReadLine());

                    if (nprod == 0)
                    {
                        break;
                    }

                    Console.WriteLine("Qual o valor do produto? ");
                    preço = int.Parse(Console.ReadLine());

                    total = preço * nprod + total;

                    if (total == 0)
                    {
                        break;
                    }

                }
                Console.WriteLine("O valor total é igual a: " + total);

            }
            public static void Exercicio2()
            {
                Console.WriteLine("Exercicio 2");
                double valor, quant, valortotal, vm, vmL;

                string nome, nm, nmm;

                Console.WriteLine("Digite o nome do produto: ('parar'- para parar)");

                nome = Console.ReadLine();

                if (nome == "parar")

                {



                }

                Console.WriteLine("Digite o preço do produto: ");

                valor = double.Parse(Console.ReadLine());

                Console.WriteLine("Digite o a quantidade do produto: ");

                quant = double.Parse(Console.ReadLine());

                valortotal = quant * valor;

                vm = valortotal;

                nm = nome;

                vmL = valortotal;

                nmm = nome;

                while (nome != "parar")

                {

                    Console.WriteLine("digite o nome do produto (digite 'parar' para finalizar o programa)");

                    nome = Console.ReadLine();

                    if (nome == "parar")

                    {

                        break;

                    }

                    Console.WriteLine("Valor do produto: ");

                    valor = double.Parse(Console.ReadLine());

                    Console.WriteLine("Quantidade do produto: ");

                    quant = double.Parse(Console.ReadLine());

                    valortotal = quant * valor;

                    if (valortotal > vm)

                    {

                        nm = nome;

                    }

                    if (valortotal < vmL)

                    {

                        nmm = nome;

                    }
                    int a = 0;
                    a++;
                }

                Console.WriteLine("Produto com + investimento: " + nm + "Com o total igual: " + vm + " Produto com - investimento: " + nmm + "Com o total igual" + vmL);
            }
            public static void Exercicio3()
            {
                Console.WriteLine("Exercicio 3");
                double na, pda, pt;

                Console.WriteLine("Digite a qauntidade de avaliações que terão neste bimestre: ");

                na = double.Parse(Console.ReadLine());

                pt = 0;
                int i = 0;
                while (i < na)

                {

                    Console.WriteLine("Digite o peso das avaliações: ");

                    pda = double.Parse(Console.ReadLine());

                    pt = pt + pda;
                    i++;

                }

                pt = pt * 10;

                if (pt > 100)

                {

                    Console.WriteLine("\nOs pesos ultrapassam 100%");



                }

                if (pt == 100)

                {

                    Console.WriteLine("\nOs pesos chegam em 100%");



                }

                if (pt > 100)

                {

                    Console.WriteLine("\nOs pesos nao alcançam 100%");



                }
            }
            public static void Exercicio4()
            {
                Console.WriteLine("Exercicio 4");
                string Sg;

                Console.WriteLine("Digite a sigla do estado: ");

                Sg = Console.ReadLine();

                switch (Sg)

                {

                    case "AM":
                        Console.WriteLine("Amazonas");
                        break;

                    case "AL":
                        Console.WriteLine("Alagoas");
                        break;

                    case "AP":
                        Console.WriteLine("Amapa");
                        break;

                    case "ES":
                        Console.WriteLine("Espirito Santo ");
                        break;

                    case "AC":
                        Console.WriteLine("Acre");
                        break;

                    case "BA":
                        Console.WriteLine("Bahia");
                        break;

                    case "CE":
                        Console.WriteLine("Ceara");
                        break;


                    case "GO":
                        Console.WriteLine("Goias");
                        break;

                    case "MA":
                        Console.WriteLine("Maranhao");
                        break;


                    case "MS":
                        Console.WriteLine("Mato Grosso do sul");
                        break;

                    case "MG":
                        Console.WriteLine("Minas Gerais");
                        break;

                    case "PA":
                        Console.WriteLine("Paraiba");
                        break;

                    case "PR":
                        Console.WriteLine("Parana");
                        break;

                    case "PE":
                        Console.WriteLine("Pernambuco");
                        break;

                    case "MT":
                        Console.WriteLine("Mato Grosso");
                        break;

                    case "PI":
                        Console.WriteLine("Piaui");
                        break;


                    case "RJ":
                        Console.WriteLine("Rio de Janeiro");
                        break;

                    case "RN":
                        Console.WriteLine("Rio Grande do Norte");
                        break;

                    case "RO":
                        Console.WriteLine("Rondonia");
                        break;

                    case "RR":
                        Console.WriteLine("Roraima");
                        break;

                    case "TO":
                        Console.WriteLine("Tocantins");
                        break;

                    case "SC":
                        Console.WriteLine("Santa Catrina");
                        break;


                    case "SE":
                        Console.WriteLine("Sergipe");
                        break;

                    case "DF":
                        Console.WriteLine("Distrito Federal");
                        break;

                    case "RS":
                        Console.WriteLine("Rio Grande do Sul");
                        break;


                    default:
                        Console.WriteLine("Sigla não reconhecida");
                        break;

                }

            }
            public static void Exercicio5()
            {
                Console.WriteLine("Exercicio 5");

                int mês, dia;
                Console.WriteLine("Escolha um mês! ");

                mês = int.Parse(Console.ReadLine());

                switch (mês)

                {

                    case 1:

                        Console.WriteLine("Estação que corresponde é: verão");

                        break;

                    case 2:

                        Console.WriteLine("Estação que corresponde é: verão");

                        break;

                    case 3:

                        Console.WriteLine("Digite o dia: ");

                        dia = int.Parse(Console.ReadLine());

                        if (dia < 20 && dia > 1)

                            Console.WriteLine("A estação correspondente é: verão");

                        if (dia >= 20 && dia < 31)

                            Console.WriteLine("A estação correspondente é: outono");

                        break;

                    case 4:

                        Console.WriteLine("A estação correspondente é verão");

                        break;

                    case 5:

                        Console.WriteLine("A estação correspondente é: verão");

                        break;

                    case 6:

                        Console.WriteLine("Escolha o dia: ");

                        dia = int.Parse(Console.ReadLine());

                        if (dia < 21 && dia > 1)

                            Console.WriteLine("Estação que corresponde é: outono");

                        if (dia >= 21 && dia < 30)

                            Console.WriteLine("Estação corresponde é: inverno");

                        break;

                    case 7:

                        Console.WriteLine("Estação corresponde é: inverno");

                        break;

                    case 8:

                        Console.WriteLine("A estação corresponde é: inverno");

                        break;

                    case 9:

                        Console.WriteLine("Digite o dia?");

                        dia = int.Parse(Console.ReadLine());

                        if (dia < 23 && dia > 1)

                            Console.WriteLine("A estação correspondente é: inverno");

                        if (dia >= 23 && dia < 30)

                            Console.WriteLine("A estação correspondente é: primavera");

                        break;

                    case 10:

                        Console.WriteLine("A estação correspondente é: primavera");

                        break;

                    case 11:

                        Console.WriteLine("A estação correspondente é: primavera");

                        break;

                    case 12:

                        Console.WriteLine("Escolha o dia:");

                        dia = int.Parse(Console.ReadLine());

                        if (dia < 22 && dia > 1)

                            Console.WriteLine("a estação correspondente é: primavera");

                        if (dia >= 22 && dia < 30)

                            Console.WriteLine("A estação correspondente é: verão");

                        break;

                    default:

                        Console.WriteLine("O valor é invalido");

                        break;

                }
            }
            public static void Exercicio6()
            {
                Console.WriteLine("exercicio 6");
                float peso, alt, imc;
                Console.WriteLine("Qual o seu peso ?");
                peso = float.Parse(Console.ReadLine());
                Console.WriteLine("Qual a sua altura ?");
                alt = float.Parse(Console.ReadLine());

                imc = peso / alt * alt;

                if (imc <= 18.5)
                    Console.WriteLine("Abaixo do peso");
                else if (imc <= 24.9 && imc >= 18.5)
                    Console.WriteLine("Peso ideal");
                else if (imc >= 25 && imc <= 29.5)
                    Console.WriteLine("Sobrepeso");
                else if (imc >= 30 && imc <= 34.9)
                    Console.WriteLine("obesidade grau 1");
                else if (imc >= 35 && imc <= 39.9)
                    Console.WriteLine("obsedidade grau 2");
                else
                    Console.WriteLine("obsediade grau 3 (morbida)");
            }
            public static void Exercicio7()
            {
                Console.WriteLine("exercicio 7");
                int num, n;
                Console.WriteLine("Digite um número:");
                num = int.Parse(Console.ReadLine());

                if (num <= 0)
                    Console.WriteLine("O número informado deve ser maior que 0!");

                string divisores = "";

                n = 1;
                while (n < num + 1)
                {
                    if (num % n == 0) divisores += n + " ";
                    n++;
                }

            }
            static void Main(string[] args)
            {
                int opcao;
                do
                {
                    Console.WriteLine(">>>>MENU<<<<");
                    Console.WriteLine("PARA SAIR 0");
                    Console.WriteLine("EXERCICIO 1");
                    Console.WriteLine("EXERCICIO 2");
                    Console.WriteLine("EXERCICIO 3");
                    Console.WriteLine("EXERCICIO 4");
                    Console.WriteLine("EXERCICIO 5");
                    Console.WriteLine(">>>>><<<<<<");
                    opcao = int.Parse(Console.ReadLine());

                    switch (opcao)
                    {
                        case 0:
                            Console.WriteLine("obrigada");
                            break;
                        case 1:
                            Exercicio1();
                            break;
                        case 2:
                            Exercicio2();
                            break;
                        case 3:
                            Exercicio3();
                            break;
                        case 4:
                            Exercicio4();
                            break;
                        case 5:
                            Exercicio5();
                            break;
                        default:
                            Console.WriteLine("não existe esse exercicio");
                            break;

                    }

                } while (opcao != 0);
            }
    }
}
