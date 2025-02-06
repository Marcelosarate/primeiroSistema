using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace primeiroSistema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
          int idAluno = 009;                   // declaração de variável idAluno e atribuição de valor
          Console.WriteLine(idAluno);          // WriteLine - mostra o texto na tela para o usuário
                                               //  Write - mostra texto na tela sem quebrar linha.
                                
          double  salAluno = (10.50);   
          Console.WriteLine(salAluno);
          string telAluno = ("1599995555");
          Console.WriteLine(telAluno);

           string minhaCid;
           minhaCid = ("Rio Claro");
           Console.WriteLine(minhaCid);
            int meuNum;                          // declaração de variável.
           meuNum = 10;                         //atribuição de valor para variavel

           const int meuNum1= 10;               //declaração de constante - valor é imutável
           Console.WriteLine(meuNum1);

           string paisAluno = "Brasil";         //usando interpolação de string para separar o texto do valor da variavel (novo)
           Console.WriteLine("O aluno nasceu no:" + paisAluno);
          /*diferença entre cancatenação e interpolação --> A interpolação  ($"...") permite inserir variaveis diretamente na string, melhorando a legibilidade.
            ambas as abordagens funcionam, mas a interpolação da string e mais moderna e facilita a manutenção do código*/

            /*string nomeAluno = "Marcelo";
            Console.WriteLine(nomeAluno);*/

            /* Usando concatenação com espaços explícitos (antigo)
             Console.WriteLine("O aluno nasceu no:" + paisAluno + "Seja bem vindo! " + nomeAluno);*/


            /* Atividade I C#- Declarando variáveis
             Declarar as variáveis abaixo

             idCurso, nomeCurso,dtInicioCurso, dtFimCurso, idadeMinimaCurso, qtdAlunosCurso.

             Mostrar na tela do usuário a seguinte mensagem:

             O nomecurso de id idcurso inicia datainiciocurso e finaliza datafinalcurso, podendo ter quantidadealunos turma.

             *** Utilizando interpolação */

            /*int x = 10;
            int y = 20; 
            Console.WriteLine(x+y);
            int A = 20, B = 20, Z = 30;
            Console.WriteLine(A + B + Z);
 /
             Atividade - Tipos de dados*/

            /* int meuCodigo = 10;
             double meuSalario = 1.000;
             char minhaInicial = 'G';
             bool meuBooleano = false;
             string meuTexto = "Olá TI";8*/


            /*int meuInt = 10;
              double meuDouble = meuInt; //conversão de int para double

             Console.WriteLine(meuInt);
             Console.WriteLine(meuDouble);*/


            /* double meuDouble1 = 10.50;
             int meuInt1 = (int) meuDouble1; //conversão de double para int
             Console.WriteLine(meuDouble1);
             Console.WriteLine(meuInt1);


            int meuInt2 = 10;
            double meuDouble2 = 8.15;
            bool meuBool = true;

            Console.WriteLine(Convert.ToString(meuInt2)); //Converte int para string
            Console.WriteLine(Convert.ToDouble(meuInt2)); //Converte int para double
            Console.WriteLine(Convert.ToInt32(meuDouble2));//Converte double para int
            Console.WriteLine(Convert.ToString(meuBool));//Converte booleand para int


             Console.WriteLine("Digite seu nome");
             string nomeUser = Console.ReadLine(); //Aguarda entrada do usuário
             Console.WriteLine($"Olá,{nomeUser}!");*/

            /* Console.WriteLine("digite uma data");
             string dtUser = Console.ReadLine();
             Console.WriteLine($"Olá,{dtUser}");*/



            /*Atividade I - Converesão de idade*/

            /* Console.WriteLine("Digite sua idade");              // O usuário digita a idade
             int idUser = Convert.ToInt32(Console.ReadLine());     // Conversão de string para int
             Console.WriteLine($"Você tem,{idUser}");   */         // Aparece na tela de usuário - você tem 30 anos

            /*Atividade II - Soma de dois números*/

            /* Console.WriteLine("Digite o primeiro número");
             Console.WriteLine("Digite o segundo número");
             int primeiro numero + int segundo numero;*/



            int c = 4;
            int d = 6;
            Console.WriteLine(c+d);
            Console.WriteLine(c-d);
            Console.WriteLine(c*d);
            Console.WriteLine(c/d);
            Console.WriteLine(c%d);

            // Operador de incremento
            int w = 10;
            w++;
            Console.WriteLine(w);

            // Operador decremento
            int p = 5;
            p--;




            // Operador de atribuição
            int valoV = 300;
            Console.WriteLine(valoV);



            /* OPERADORES DE ATRIBUIÇÃO
             =
            +=
            -=
            *=
            /=
            %=          */


            // OPERADOR DE COMPARAÇÃO
            int U = 5;
            int v = 6;
            Console.WriteLine(U>v);

            /*
             == igual a
            != diferente
            > maior que
            < menor que
            >= maior e igual
            <= menor e igual
            */
          /*  Console.WriteLine("Hello word!");
            Console.WriteLine("Olá mundo");*/

        }
    }
}
