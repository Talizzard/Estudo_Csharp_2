namespace RPGPOO {
    class Batalha {
        public bool BatalhaAtiva = true;
        public void AtaqueInimigo (Inimigo ini, Paladino pal) {
            Console.WriteLine($"O {ini.Nome} lhe atacou");
            pal.Vida -= ini.Dano;
            pal.ExibirStats(pal);
        }

        public void SeuAtaque (Inimigo ini, Paladino pal) {
            Console.WriteLine($"{pal.Nome} o ataca!");
            ini.Vida -= pal.Dano;
            if(ini.Vida<=0) {
                Console.WriteLine($"{pal.Nome} derrotou o {ini.Nome}!");
                Console.WriteLine($"Ganhe {pal.XpComum()} de XP");
                pal.Xp += pal.XpComum();
                pal.LevelUp();
                BatalhaAtiva = false;
            }
        }
    }
}
