namespace Petshop_projeto
{
    class Program
    {
        static void Main(string[] args)
        {
            bool respostaCorreta = false;
            string resposta = "";
            bool respostaPorteCorreta = false;
            string respostaPorte = "";
            bool respostaAgressivoCorreta = false;
            string respostaAgressivo;
            bool respostaSexoCorreta = false;
            string respostaSexo = "";
            bool respostaCastradoCorreta = false;
            string respostaCastrado = "";
            bool respostaNecessidadesCorreta = false;
            string respostaNecessidadesEspeciais = "";

            Animal pet = new Animal();
            Console.WriteLine("Bem-vindo ao Pet shop do seu bairro.");
            Console.WriteLine("Qual o nome do animal que você gostaria de cadastrar?");
            pet.Nome = Console.ReadLine();
            Console.WriteLine($"Qual a especie do(a) {pet.Nome}?");
            Console.WriteLine("Digite 1 para Especie Cachorro ou digite 2 para Especie Gato:");
            while (respostaCorreta == false)
            {
                resposta = Console.ReadLine();
                if ((resposta == "1") || (resposta.ToUpper() == "UM"))
                {
                    pet.Especie = Especie.Cachorro;
                    respostaCorreta = true;
                }
                else if ((resposta == "2") || (resposta.ToUpper() == "DOIS"))
                {
                    pet.Especie = Especie.Gato;
                    respostaCorreta = true;
                }
                else
                {
                    Console.WriteLine("Resposta inválida.");
                    Console.WriteLine($"Digite 1 se {pet.Nome} for Cachorro(a) ou digite 2 se for Gato(a):");
                    continue;
                }
            }
            Console.WriteLine("Qual a raça?");
            pet.Raca = Console.ReadLine();
            Console.WriteLine("Qual a cor?");
            pet.Cor = Console.ReadLine();
            Console.WriteLine("Qual o porte?");
            Console.WriteLine("Digite 1 para Porte Pequeno ou digte 2 para Porte Grande:");
            while (respostaPorteCorreta == false)
            {
                respostaPorte = Console.ReadLine();
                if ((respostaPorte == "1") || (respostaPorte.ToUpper() == "UM"))
                {
                    pet.Porte = Porte.Pequeno;
                    respostaPorteCorreta = true;
                }
                else if ((respostaPorte == "2") || (respostaPorte.ToUpper() == "DOIS"))
                {
                    pet.Porte = Porte.Grande;
                    respostaPorteCorreta = true;
                }
                else
                {
                    Console.WriteLine("Resposta inválida.");
                    Console.WriteLine($"Digite 1 se {pet.Nome} for Porte Pequeno ou digite 2 se for Porte Grande:");
                    continue;
                }
            }
            Console.WriteLine("Qual o peso do animal em kgs?");
            pet.Peso = Decimal.Parse(Console.ReadLine());
            Console.WriteLine("Qual a data de nascimento do seu pet? Digite DD/MM/AAAA.");
            Console.WriteLine("Caso não saiba o dia exato, escreva 00 no local do dia.");
            pet.Nascimento = DateTime.Parse(Console.ReadLine());
            Console.WriteLine($"O/a {pet.Nome} tem alguma necessidade especial?");
            Console.WriteLine("Digite 1 para Sim ou digite 2 para Não.");
            while (respostaNecessidadesCorreta == false)
            {
                respostaNecessidadesEspeciais = Console.ReadLine();
                if ((respostaNecessidadesEspeciais == "1") || (respostaNecessidadesEspeciais.ToUpper() == "UM") || (respostaNecessidadesEspeciais.ToUpper() == "SIM"))
                {
                    while (true)
                    {
                        Console.WriteLine("Digite abaixo qual a doença e/ou alergia do pet:");
                        pet.AdicionarDoencasAlergias(Console.ReadLine());
                        Console.WriteLine("Há outra doença e/ou alergia? Digite 1 se houver ou digite 2 se não houver.");
                        string respostaDoencaAlergia = Console.ReadLine();
                        if (respostaDoencaAlergia == "1" || respostaDoencaAlergia.ToUpper() == "UM" || respostaDoencaAlergia.ToUpper() == "SIM")
                            continue;
                        else
                        {
                            respostaNecessidadesCorreta = true;
                            break;
                        }
                    }
                }
                else if ((respostaNecessidadesEspeciais == "2") || (respostaNecessidadesEspeciais.ToUpper() == "DOIS") || (respostaNecessidadesEspeciais.ToUpper() == "NÃO"))
                {
                    respostaNecessidadesCorreta = true;
                }
                else
                {
                    Console.WriteLine("Respota inválida.");
                    Console.WriteLine($"Digite 1 se {pet.Nome} necessita de Necessidades Especiais ou digite 2 se Não necessita:");
                    continue;
                }
            }
            Console.WriteLine($"O/a {pet.Nome} é agressivo?");
            Console.WriteLine("Digite 1 para Sim ou digite 2 para Não");
            while (respostaAgressivoCorreta == false)
            {
                respostaAgressivo = Console.ReadLine();
                if ((respostaAgressivo == "1") || (respostaAgressivo.ToUpper() == "UM") || (respostaAgressivo.ToUpper() == "SIM"))
                {
                    pet.Agressivo = true;
                    Console.WriteLine("Lamentamos, mas, por enquanto, nosso petshop não atende animais agressivos.");
                    respostaAgressivoCorreta = true;
                    return;
                }
                else if ((respostaAgressivo == "2") || (respostaAgressivo.ToUpper() == "DOIS") || (respostaAgressivo.ToUpper() == "NÃO"))
                {
                    pet.Agressivo = false;
                    respostaAgressivoCorreta = true;
                }
                else
                {
                    Console.WriteLine("Respota inválida.");
                    Console.WriteLine($"Digite 1 se {pet.Nome} for Agressivo ou digite 2 se Não for agressivo:");
                    continue;
                }
            }
            Console.WriteLine("Qual o sexo do animal?");
            Console.WriteLine("Digite 1 para Sexo Feminino ou digite 2 para Sexo Masculino:");
            while (respostaSexoCorreta == false)
            {
                respostaSexo = Console.ReadLine();
                if ((respostaSexo == "1") || (respostaSexo.ToUpper() == "UM") || (respostaSexo.ToUpper() == "F") || (respostaSexo.ToUpper() == "FEMININO"))
                {
                    pet.Sexo = 'F';
                    respostaSexoCorreta = true;
                }
                else if ((respostaSexo == "2") || (respostaSexo.ToUpper() == "DOIS") || (respostaSexo.ToUpper() == "M") || (respostaSexo.ToUpper() == "MASCULINO"))
                {
                    pet.Sexo = 'M';
                    respostaSexoCorreta = true;
                }
                else
                {
                    Console.WriteLine("Respota inválida.");
                    Console.WriteLine($"Digite 1 se {pet.Nome} for do sexo Feminino ou digite 2 se for do sexo Masculino:");
                    continue;
                }
            }

            Console.WriteLine("Seu pet é castrado?");
            Console.WriteLine("Digite 1 para Sim ou digite 2 para Não.");
            while (respostaCastradoCorreta == false)
            {
                respostaCastrado = Console.ReadLine();
                if ((respostaCastrado == "1") || (respostaCastrado.ToUpper() == "UM") || (respostaCastrado.ToUpper() == "SIM"))
                {
                    pet.Castrado = true;
                    respostaCastradoCorreta = true;
                }
                else if ((respostaCastrado == "2") || (respostaCastrado.ToUpper() == "DOIS") || (respostaCastrado.ToUpper() == "NÃO"))
                {
                    pet.Castrado = false;
                    respostaCastradoCorreta = true;
                }
                else
                {
                    Console.WriteLine("Respota inválida.");
                    Console.WriteLine($"Digite 1 se {pet.Nome} for Castrado ou digite 2 se Não for castrado:");
                    continue;
                }
            }
            Console.WriteLine("----------------------------------");
            Console.WriteLine("CADASTRO FINALIZADO:");
            pet.ImprimirAnimal(); //chamando a função
        }
    }
}