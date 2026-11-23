namespace atividade_3
{
    class Atividade_3
    {
        public void Renda()
        {
            Console.Write("Qual seu Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Qual sua Idade: ");
            int idade = int.Parse(Console.ReadLine());

            Console.Write("Tem ingresso: ");
            bool temIngresso = bool.Parse(Console.ReadLine());

            if (idade >= 18 && temIngresso == true)
            {
                Console.WriteLine("Pode entrar");
            }
            else
            {
                Console.WriteLine("Não pode entrar");
            }

            Console.WriteLine("=========== segunda parte ===========");

            Console.Write("Qual a Renda do Mês: ");
            double renda = double.Parse(Console.ReadLine());

            if (renda <= 1000)
            {
                Console.WriteLine("Você é de baixa renda");
            }
            else if (renda > 1000 && renda <= 5000)
            {
                Console.WriteLine("Você é de média renda");
            }
            else
            {
                Console.WriteLine("Você é de alta renda");
            }

        }
    }
}