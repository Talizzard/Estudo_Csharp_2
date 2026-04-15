namespace RPGPOO {
        class Paladino : Personagem {
        public int Dano;

        public Paladino (String nome, int nivel, int xp, int vida, int dano) : base(nome, nivel, xp){
            Vida = vida;
            Dano = dano;
        }
    }
}
