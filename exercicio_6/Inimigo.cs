namespace RPGPOO {
        class Inimigo {
        public String Nome;
        public int Vida;
        public int Dano;

        public Inimigo (String nome, int vida, int dano){
            Nome = nome;
            Vida = vida;
            Dano = dano;
        }

        public void ExibirStats(){
            Console.WriteLine($"Vida do {Nome}: {Vida}HP");
        }
    }
}
