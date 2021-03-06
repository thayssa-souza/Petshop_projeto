using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petshop_projeto
{
    public class Animal : DadosCadastro //nossa classe que trará nossa herança
    {
        //    private Guid Codigo = Guid.NewGuid(); - está na nossa classe Dados Cadastro
        public string Nome { get; set; }
        public Especie Especie { get; set; }
        public string Raca { get; set; }
        public string Cor { get; set; }
        public Porte Porte { get; set; }
        public decimal Peso { get; set; }
        //   public int Idade {get {return DateTime.Now.Year - Nascimento.Year; }} -Como a propriedade foi criada, não precisamos mais do método
        public int Idade { get { return IdadeCompleta(); } }
        public DateTime Nascimento { get; set; }
        private List<string> DoencasAlergias { get; set; } = new(); //esse new é para inicializar a lista; se não houvesse o get set, fariamos assim: = new List<string>()
        public bool Agressivo { get; set; }
        public char Sexo { get; set; }
        public bool Castrado { get; set; }
        //   private DateTime DataCadastrado { get { return DateTime.Now; }} //aqui também não tá inicializado


        //        public void SetarCodigo(Guid codigo)
        //        {
        //            this.Codigo = codigo; <<- REFORMULAR DEVIDO A NOVA CLASSE DE HERANÇA
        //        }

        public int IdadeCompleta()
        {
            if (Nascimento.Month > DateTime.Now.Month)
            {
                return DateTime.Now.Year - Nascimento.Year - 1;
            }
            else if (Nascimento.Month < DateTime.Now.Month)
            {
                return (DateTime.Now.Year - Nascimento.Year);
            }
            else
            {
                if (Nascimento.Day < DateTime.Now.Day)
                    return (DateTime.Now.Year - Nascimento.Year);

                else
                    return (DateTime.Now.Year - Nascimento.Year) - 1;
            }
        }
        //        public DateTime ObterDataCadastro()
        //        {
        //            return DataCadastrado; <<- REFORMULAR DEVIDO A NOVA CLASSE DE HERANÇA
        //        }

        public List<string> ObterNecessidadesEespeciais()
        {
            return DoencasAlergias;
        }

        public bool NecessidadesEspeciais()
        {
            return DoencasAlergias.Any();
        }

        // public int Idade()  Como a propriedade foi criada, não precisamos mais do método
        // {
        //     return DateTime.Now.Year - Nascimento.Year;
        // }

        public void RegistrarNascimento(int ano, int mes, int dia = 1)
        {
            Nascimento = new DateTime(ano, mes, dia);
        }
        public void AdicionarDoencasAlergias(string doencaAlergia)
        {
            DoencasAlergias.Add(doencaAlergia);
        }

        public void ImprimirAnimal()
        {
            Console.WriteLine("Imprimindo Pet");
            Console.WriteLine("Codigo: " + Codigo);
            Console.WriteLine("Nome: " + Nome);
            Console.WriteLine("Especie: " + Especie);
            Console.WriteLine("Raça: " + Raca);
            Console.WriteLine("Cor: " + Cor);
            Console.WriteLine("Porte: " + Porte);
            Console.WriteLine("Peso: " + Peso);
            Console.WriteLine("Data de nascimento: " + Nascimento);
            Console.WriteLine("Apresenta necessidades especiais. " + NecessidadesEspeciais());

            if (NecessidadesEspeciais())
            {
                Console.WriteLine("Doenças e Alergias:");
                foreach (string doencaalergia in DoencasAlergias)
                {
                    Console.WriteLine("Necessida especial: " + doencaalergia);
                }
            }
            Console.WriteLine("Pet agressivo: " + Agressivo);
            Console.WriteLine("Sexo do animal: " + Sexo);
            Console.WriteLine("Animal castrado: " + Castrado);
            Console.WriteLine("Data do cadastro no Petshop: " + DataCadastro);
            Console.WriteLine("");
        }

    }
}