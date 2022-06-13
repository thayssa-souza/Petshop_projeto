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

            Animal pet = new Animal();
            Console.WriteLine("Bem-vindo ao Pet shop do seu bairro.");
            Console.WriteLine("Qual o nome do animal que você gostaria de cadastrar?");
            pet.Nome = Console.ReadLine();
            Console.WriteLine($"Qual a especie do(a) {pet.Nome}?");
            Console.WriteLine("Digite 1 para Especie Cachorro ou digite 2 para Especie Gato:");
            while (respostaCorreta == false)
            {
                resposta = Console.ReadLine();
                if ((resposta == "1") || (resposta == "um") || (resposta == "UM") || (resposta == "uM") || (resposta == "Um"))
                {
                    pet.Especie = Especie.Cachorro;
                    respostaCorreta = true;
                }
                else if ((resposta == "2") || (resposta == "dois") || (resposta == "Dois") || (resposta == "DOIS"))
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
                if ((respostaPorte == "1") || (respostaPorte == "um") || (respostaPorte == "UM") || (respostaPorte == "uM") || (respostaPorte == "Um"))
                {
                    pet.Porte = Porte.Pequeno;
                    respostaPorteCorreta = true;
                }
                else if ((respostaPorte == "2") || (respostaPorte == "dois") || (respostaPorte == "Dois") || (respostaPorte == "DOIS"))
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
            Console.WriteLine($"O/a {pet.Nome} é agressivo?");
            Console.WriteLine("Digite 1 para Sim ou digite 2 para Não");
            while (respostaAgressivoCorreta == false)
            {
                respostaAgressivo = Console.ReadLine();
                if ((respostaAgressivo == "1") || (respostaAgressivo == "um") || (respostaAgressivo == "UM") || (respostaAgressivo == "uM") || (respostaAgressivo == "Um") || (respostaAgressivo == "Sim") || (respostaAgressivo == "SIM") || (respostaAgressivo == "sim"))
                {
                    pet.Agressivo = true;
                    Console.WriteLine("Lamentamos, mas, por enquanto, nosso petshop não atende animais agressivos.");
                    respostaAgressivoCorreta = true;
                    return;
                }
                else if ((respostaAgressivo == "2") || (respostaAgressivo == "dois") || (respostaAgressivo == "Dois") || (respostaAgressivo == "DOIS") || (respostaAgressivo == "Não") || (respostaAgressivo == "Nao") || (respostaAgressivo == "NÃO") || (respostaAgressivo == "NAO") || (respostaAgressivo == "não") || (respostaAgressivo == "nao"))
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
                if ((respostaSexo == "1") || (respostaSexo == "um") || (respostaSexo == "UM") || (respostaSexo == "uM") || (respostaSexo == "Um") || (respostaSexo == "F") || (respostaSexo == "f") || (respostaSexo == "feminino") || (respostaSexo == "FEMININO") || (respostaSexo == "Feminino"))
                {
                    pet.Sexo = 'F';
                    respostaSexoCorreta = true;
                }
                else if ((respostaSexo == "2") || (respostaSexo == "dois") || (respostaSexo == "Dois") || (respostaSexo == "DOIS") || (respostaSexo == "M") || (respostaSexo == "m") || (respostaSexo == "masculino") || (respostaSexo == "MASCULINO") || (respostaSexo == "Masculino"))
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
            Console.WriteLine("----------------------------------");
            Console.WriteLine("CADASTRO FINALIZADO:");
            Console.WriteLine(pet.Nome);
            Console.WriteLine(pet.Especie);
            Console.WriteLine(pet.Raca);
            Console.WriteLine(pet.Cor);
            Console.WriteLine(pet.Porte);
            Console.WriteLine(pet.Peso);
            Console.WriteLine(pet.Nascimento);
            Console.WriteLine(pet.Agressivo);
            Console.WriteLine(pet.Sexo);
        }
    }
}