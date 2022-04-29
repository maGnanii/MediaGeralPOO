using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaGeralPOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Título
            Console.Title = "### Média Geral dos Alunos ###";

            Console.WriteLine("Quantos alunos?");
            int nAlunos = int.Parse(Console.ReadLine());

            //Quebra de linha
            Console.WriteLine(); 

            //Um vetor do tipo Aluno (nossa classe) para preencher com os alunos;
            Aluno[]alunos = new Aluno[nAlunos]; 
            for(int i = 0; i < nAlunos; i++)
            {
                Console.Clear();
                Console.Write("Aluno #" + (i + 1) + " Nome..: ");
                string nome = Console.ReadLine();

                Console.Write("Aluno #" + (i + 1) + " Provas: ");
                int provas = int.Parse(Console.ReadLine());

                alunos[i] = new Aluno(nome, provas);

                //Método inserir notas do aluno
                Console.WriteLine("Insira as notas do aluno " + nome);
                alunos[i].InserirNotas();
            }

            //Limpar a tela
            Console.Clear(); 

            double mediaGeral = 0;
            foreach(Aluno aluno in alunos) //A cada passagem da nossa variável "aluno", será atribuido um elemento do nosso array;
            {
                Console.WriteLine("Aluno: " + aluno.Nome);
                Console.WriteLine("Media: " + aluno.Media);
                Console.WriteLine();

                mediaGeral += aluno.Media;
            }

            double resultadoFinal = mediaGeral / alunos.Length;

            Console.WriteLine("Média geral dos alunos: " + resultadoFinal);
            Console.ReadKey();
        }
    }
}
