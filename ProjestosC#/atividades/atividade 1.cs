namespace atividade_1
{
    class Atividade_1
    {
        public void CalcularTriangulo()
        {
            Console.Write("Qual a  Base do Triângulo: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Qual a  Altura do Triângulo: ");
            double h = double.Parse(Console.ReadLine());
            double area = (b * h) / 2;
            Console.WriteLine("A área do triângulo é: " + area);
            
        }
    }
}