namespace ProjestosC_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Selecione: ");
            var switch_on = Console.ReadLine(); 

            switch (switch_on)
            {
                case "1":
                    Console.WriteLine("Atividade 1");
                    new atividade_1.Atividade_1().CalcularTriangulo();
                    break;
            }
        }
    }
}
