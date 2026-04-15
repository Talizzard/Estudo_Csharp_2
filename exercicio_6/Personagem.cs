namespace RPGPOO {
        class Personagem{
        public String Nome;
        public int Nivel;
        public int Xp;
        public int Vida;

        public Personagem (String nome, int nivel, int xp){
            Nome = nome;
            Nivel = nivel;
            Xp = xp;
        }

        public void ExibirStats(Personagem p){
            Console.WriteLine($"Vida do {p.Nome}: {p.Vida}HP");
        }

        public void LevelUp(){
            if (Xp >= 100){
                Xp = 0;
                Nivel++;
            }
        }

        public int XpComum(){
            Random rand = new Random();
            int exp = rand.Next(1, 21);
            return exp;
        }
    }
}
