using System;

namespace ClassificadorDeHeroi
{
    public class Heroi
    {
        public string Nome { get; set; }
        public int XP { get; set; }

        public Heroi(string nome, int xp)
        {
            Nome = nome;
            XP = xp;
        }

        public string ClassificarNivel()
        {
            if (XP < 1000)
            {
                return "Ferro";
            }
            else if (XP <= 2000)
            {
                return "Bronze";
            }
            else if (XP <= 5000)
            {
                return "Prata";
            }
            else if (XP <= 7000)
            {
                return "Ouro";
            }
            else if (XP <= 8000)
            {
                return "Platina";
            }
            else if (XP <= 9000)
            {
                return "Ascendente";
            }
            else if (XP <= 10000)
            {
                return "Imortal";
            }
            else
            {
                return "Radiante";
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o nome do herói: ");
            string nome = Console.ReadLine();

            Console.Write("Digite a quantidade de XP do herói: ");
            int xp;
            while (!int.TryParse(Console.ReadLine(), out xp))
            {
                Console.WriteLine("Por favor, insira um número válido para a quantidade de XP.");
                Console.Write("Digite a quantidade de XP do herói: ");
            }

            Heroi heroi = new Heroi(nome, xp);
            string nivel = heroi.ClassificarNivel();

            Console.WriteLine($"O Herói de nome {heroi.Nome} está no nível de {nivel}");
        }
    }
}
