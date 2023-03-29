using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace lista3pr2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //LISTA-3
            int numero;

            Console.WriteLine("==========MENU==========");
            Console.WriteLine("1- EXERCÍCIO 1");
            Console.WriteLine("2- EXERCÍCIO 2");
            Console.WriteLine("3- EXERCÍCIO 3");
            Console.WriteLine("4- EXERCÍCIO 4");
            Console.WriteLine("5- EXERCÍCIO 5");
            Console.WriteLine("6- EXERCÍCIO 6");
            Console.WriteLine("=======================");

            numero = int.Parse(Console.ReadLine());

            switch (numero) 
            {
                case 1://exercicio 1
                    int number;

                    Console.WriteLine("==========MENU==========");
                    Console.WriteLine("DOMINGO");
                    Console.WriteLine("SEGUNDA");
                    Console.WriteLine("TERÇA");
                    Console.WriteLine("QUARTA");
                    Console.WriteLine("QUINTA");
                    Console.WriteLine("SEXTA");
                    Console.WriteLine("SÁBADO");
                    Console.WriteLine("=======================");

                    Console.WriteLine("Escolha um dia de 1 a 7: ");
                    number = int.Parse(Console.ReadLine()); 

                    switch (number)
                    {
                        case 1:
                            Console.WriteLine("DOMINGO");
                            break;

                        case 2:
                            Console.WriteLine("SEGUNDA");
                            break;

                        case 3:
                            Console.WriteLine("TERÇA");
                            break;

                        case 4:
                            Console.WriteLine("QUARTA");
                            break;

                        case 5:
                            Console.WriteLine("QUINTA");
                            break;

                        case 6:
                            Console.WriteLine("SEXTA");
                            break;

                        case 7:
                            Console.WriteLine("SÁBADO");
                            break;
                        default:
                            Console.WriteLine("Opção Invalida");
                            break;

                    }

                    break;
                case 2://exercicio 2

                    float N, valor, descont1, valordes;

                      Console.WriteLine("Digite o valor da sua compra: ");
                      valor = float.Parse(Console.ReadLine());

                      Console.WriteLine("Escolha um dos metodos de pagamento");
                     
                  
                      Console.WriteLine("==========MENU==========");
                      Console.WriteLine("PAGAR Á VISTA NO DINHEIRO");
                      Console.WriteLine("PAGAR Á VISTA NO PIX");
                      Console.WriteLine("PAGAR NO DÉBITO");
                      Console.WriteLine("PAGAR NO CRÉDITO"); 
                      Console.WriteLine("=======================");

                      N = float.Parse(Console.ReadLine()); 

                     switch (N)
                    {
                        case 1:

                            descont1 = (15 * valor) / 100;

                            valordes = valor - descont1;

                            Console.WriteLine("O valor da sua compra é: " + valordes);
                            break;

                        case 2:

                            descont1 = (10 * valor) / 100;

                            valordes = valor - descont1;

                            Console.WriteLine("O valor da sua compra é: " + valordes);
                            break;

                        case 3:

                            descont1 = (5 * valor) / 100;

                            valordes = valor + descont1;
                           
                            Console.WriteLine("O valor da sua compra é: " + valordes);
                            break;

                        case 4:

                            descont1 = (10 * valor) / 100;

                            valordes = valor + descont1;

                            Console.WriteLine("O valor da sua compra é: " + valordes);
                            break;

                        default:
                            Console.WriteLine("Opção Invalida");
                            break;

                    }

                    break;

                case 3://exercicio 3

                    int meses;

                    Console.WriteLine("==========MENU==========");
                    Console.WriteLine("mês-1");
                    Console.WriteLine("mês-2");
                    Console.WriteLine("mês-3");
                    Console.WriteLine("mês-4");
                    Console.WriteLine("mês-5");
                    Console.WriteLine("mês-6");
                    Console.WriteLine("mês-7");
                    Console.WriteLine("mês-8");
                    Console.WriteLine("mês-9");
                    Console.WriteLine("mês-10");
                    Console.WriteLine("mês-11");
                    Console.WriteLine("mês-12");
                    Console.WriteLine("=======================");

                    Console.WriteLine("Escolha um mês de 1 a 12: ");
                    meses = int.Parse(Console.ReadLine());

                    switch (meses)
                    {
                        case 1:
                            Console.WriteLine("JANEIRO - 31 DIAS");
                            break;

                        case 2:
                            Console.WriteLine("FEVEREIRO - 28 DIAS(CASO FOR UM ANO BISSEXTO, FEVEREIRO TEM 29 DIAS)");
                            break;

                        case 3:
                            Console.WriteLine("MARÇO - 31 DIAS ");
                            break;

                        case 4:
                            Console.WriteLine("ABRIL - 30 DIAS");
                            break;

                        case 5:
                            Console.WriteLine("MAIO - 31 DIAS");
                            break;

                        case 6:
                            Console.WriteLine("JUNHO - 30 DIAS");
                            break;

                        case 7:
                            Console.WriteLine("JULHO - 31 DIAS");
                            break;
                        
                        case 8:
                            Console.WriteLine("AGOSTO - 31 DIAS");
                            break;  
                        
                        case 9:
                            Console.WriteLine("SETEMBRO - 30 DIAS");
                            break;
                        
                        case 10:
                            Console.WriteLine("OUTUBRO - 31 DIAS");
                            break;  
                        
                        case 11:
                            Console.WriteLine("NOVEMBRO - 30 DIAS");
                            break;
                        
                        case 12:
                            Console.WriteLine("DEZEMBRO - 31 DIAS");
                            break;

                        default:
                            Console.WriteLine("Opção Invalida");
                            break;
                        
                    }
                            break;

                case 4://exercicio 4


                    int valor1, valor2, op, resultado, resultado2;

                    Console.WriteLine("Digite o primeiro valor: ");
                    valor1 = int.Parse(Console.ReadLine());
                    
                    Console.WriteLine("Digite o segundo valor: ");
                    valor2 = int.Parse(Console.ReadLine());

                    Console.WriteLine("Escolha uma das operações:");


                    Console.WriteLine("==========MENU==========");
                    Console.WriteLine("1 - SUBTRAÇÃO");
                    Console.WriteLine("2 - ADIÇÃO");
                    Console.WriteLine("3 - DIVISÃO");
                    Console.WriteLine("4 - MULTIPLICAÇÃO");
                    Console.WriteLine("5 - POTÊNCIA AO QUADRADO");
                    Console.WriteLine("=======================");

                    op = int.Parse(Console.ReadLine());

                    switch (op)
                    {
                        case 1:

                            resultado = valor1 - valor2;
                            Console.WriteLine("O resultado da sua SUBTRAÇÃO é: " + resultado);

                            break;

                        case 2:

                            resultado = valor1 + valor2;
                            Console.WriteLine("O resultado da sua ADIÇÃO é:" + resultado);

                            break;

                        case 3:

                            resultado = valor1 / valor2;
                            Console.WriteLine("O resultado da sua DIVISÃO é: " + resultado);

                            break;
                        
                        case 4:

                            resultado = valor1 * valor2;
                            Console.WriteLine("O resultado da sua MULTIPLICAÇÃO é: " + resultado);

                            break;

                        case 5:

                            resultado = valor1 * valor1;
                            resultado2 = valor2 * valor2;

                            Console.WriteLine("O resultado da sua primeira POTÊNCIA é: " + resultado);
                            Console.WriteLine("O resultado da sua segunda POTÊNCIA é: " + resultado2);

                            break;
                        default:
                            Console.WriteLine("Opção Invalida");
                            break;


                    }

                    break;

                case 5://exercicio 5

                    float salario, percentual, salarionovo, n;

                    Console.WriteLine("qual é o seu salario? ");
                    salario = float.Parse(Console.ReadLine());
                  

                    Console.WriteLine("Escolha de acordo com seu codigo:");


                    Console.WriteLine("==========MENU==========");
                    Console.WriteLine("101");
                    Console.WriteLine("102");
                    Console.WriteLine("103");
                    Console.WriteLine("204");
                    Console.WriteLine("206");
                    Console.WriteLine("301");
                    Console.WriteLine("302");
                    Console.WriteLine("=======================");

                    n = float.Parse(Console.ReadLine());

                    switch (n)
                    {
                        case 101:

                            percentual = (7.5f * salario) / 100;

                            salarionovo = salario + percentual;


                            Console.WriteLine("Olá Professor(a), seu novo salario é: {0}, e o seu salario antigo é:{1} e a diferença é: {2} ", salarionovo, salario, percentual);
                            break;

                        case 102:
                            
                            percentual = (9.7f * salario) / 100;

                            salarionovo = salario + percentual;


                            Console.WriteLine("Olá Secretario(a), seu novo salario é: {0}, e o seu salario antigo é:{1} e a diferença é: {2} ", salarionovo, salario, percentual);
                            break;

                        case 103:
                           
                            percentual = (11.7f * salario) / 100;

                            salarionovo = salario + percentual;


                            Console.WriteLine("Olá PUblicitario(a), seu novo salario é: {0}, e o seu salario antigo é:{1} e a diferença é: {2} ", salarionovo, salario, percentual);
                            break;

                        case 204:
                           
                            percentual = (8.9f * salario) / 100;

                            salarionovo = salario + percentual;


                            Console.WriteLine("Olá Jornalista, seu novo salario é: {0}, e o seu salario antigo é:{1} e a diferença é: {2} ", salarionovo, salario, percentual);
                            break;

                        case 206:
                           
                            percentual = (13.24f * salario) / 100;

                            salarionovo = salario + percentual;


                            Console.WriteLine("Olá Mecanico(a), seu novo salario é: {0}, e o seu salario antigo é:{1} e a diferença é: {2} ", salarionovo, salario, percentual);
                            break;

                        case 301:
                           
                            percentual = (10.4f * salario) / 100;

                            salarionovo = salario + percentual;


                            Console.WriteLine("Olá Estagiario(a), seu novo salario é: {0}, e o seu salario antigo é:{1} e a diferença é: {2} ", salarionovo, salario, percentual);
                            break;

                        case 302:
                           
                            percentual = (14.6f * salario) / 100;

                            salarionovo = salario + percentual;


                            Console.WriteLine("Olá Tecnico(a) em TI, seu novo salario é: {0}, e o seu salario antigo é:{1} e a diferença é: {2} ", salarionovo, salario, percentual);
                            break;

                        
                        default:
                            percentual = (43.5f * salario) / 100;

                            salarionovo = salario + percentual;


                            Console.WriteLine("Olá, Voce não está cadastrado mas seu novo salario é: {0}, e o seu salario antigo é:{1} e a diferença é: {2} ", salarionovo, salario, percentual);
                            break;
                    }
                    break;

                case 6://exercicio 6

                    float sala;

                    Console.WriteLine("DIgite seu salario: ");
                    sala = float.Parse(Console.ReadLine());

                    if(sala )




                   




                    break;
                default:
                    Console.WriteLine("Opção Invalida");
                    break;
                
               }
           
            Console.ReadKey();

        }
    }
}
