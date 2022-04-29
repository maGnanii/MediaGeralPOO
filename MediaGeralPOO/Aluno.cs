using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaGeralPOO
{
    internal class Aluno
    {
        //Com o get e set, podemos obter os valores a partir do objeto com o Get e definir os valores com o set;
        public string Nome { get; private set; } //privamos o "set" para que os nomes dos alunos, não sejam alterados.

        //Um array que irá guardar as notas dos alunos
        private double[] _notas; 

        //Propriedade que irá retornar a média das notas;
        public double Media 
        {
            get
            {
                return CalcularMedia();
            }
        }

        //Um método construtor que irá guardar o nome do nosso aluno e a quantidade de provas;
        public Aluno(string nome, int provas)
        {
            Nome = nome;
            _notas = new double[provas]; //Aqui estamos definindo o tamanho do Array, com a quantidade de provas. Caso fez 2 provas, são 2 notas; 

        }

        //Método para ser inseridas as notas;
        public void InserirNotas()
        {
            for (int i = 0; i < _notas.Length; i++) //Essa propriedade ".Length está sendo utilizada para dizer/transparecer a quantidade de provas;
            {
                Console.Write("Nota #" + (i + 1) + ": ");
                _notas[i] = double.Parse(Console.ReadLine());
            }
        }

        //Método para calcular a média da nota deste aluno acima;
        private double CalcularMedia()
        {
            double total = 0;
            for(int i = 0; i < _notas.Length; i++)
            {
                total +=_notas[i];
            }

            return total / _notas.Length;
        }
    }
}
