namespace RPGPOO {
    using System;
    class Program{
        static void Main(string [] args){
            Paladino p1 = new Paladino("Jorge Herrera", 1, 0, 100, 20);
            Inimigo n1 = new Inimigo("Goblin", 50, 10);
            Batalha arena = new Batalha();

            while(arena.BatalhaAtiva) {
                arena.AtaqueInimigo(n1, p1);
                arena.SeuAtaque(n1, p1);
            }
            Console.WriteLine($"Vida restante: {p1.Vida}HP | XP total: {p1.Xp}");
        }
    }
}
