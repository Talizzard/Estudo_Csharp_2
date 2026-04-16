namespace RPGPOO {
    class Batalha {
        public bool BatalhaAtiva = true;
        public void AtaqueInimigo (Inimigo ini, Personagem perso) {
            Console.WriteLine($"O {ini.Nome} lhe atacou");
            perso.Vida -= ini.Dano;
            perso.ExibirStats(perso);
        }

        public void SeuAtaque (Inimigo ini, Personagem perso) {
            Console.WriteLine($"{perso.Nome} o ataca!");
            ini.Vida -= perso.Dano;
            if(ini.Vida<=0) {
                int xpGerado = perso.XpComum();
                Console.WriteLine($"{perso.Nome} derrotou o {ini.Nome}!");
                Console.WriteLine($"Ganhe {xpGerado} de XP");
                perso.Xp += xpGerado;
                perso.LevelUp();
                BatalhaAtiva = false;
            }
        }
    }
}
