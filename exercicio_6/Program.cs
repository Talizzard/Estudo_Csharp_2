namespace RPGPOO {
    using System;
    class Program{
        static void Main(string [] args){
            Console.WriteLine("Digite o nome do seu personagem: ");
            String nome = Console.ReadLine() ?? "Bob";
            Console.WriteLine("Escolha sua classe: 1. MAGO ou 2. PALADINO\nDigite o número para escolher.");
            int classe = int.Parse(Console.ReadLine()!);
            Personagem? perso = null;
            switch (classe) {
                case 1:
                    perso = new Mago(nome, 1, 0, 80, 40);
                    break;
                case 2:
                    perso = new Paladino(nome, 1, 0, 100, 20);
                    break;
                default:
                    Console.WriteLine("Número invalido!");
                    return;
            }
            Inimigo n1 = new Inimigo("Goblin", 50, 10);
            Batalha arena = new Batalha();
            while(arena.BatalhaAtiva) {
                arena.AtaqueInimigo(n1, perso);
                arena.SeuAtaque(n1, perso);
            }
            Console.WriteLine($"Vida restante: {perso.Vida}HP | XP total: {perso.Xp}");
        }
    }
}
