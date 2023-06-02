using System;


namespace Corse {
    class Estudantes {

        public string Nome { get; set; }
        public string Gmail { get; set; }

        public Estudantes(string nome, string gmail) {
            Nome = nome;
            Gmail = gmail;
        }

        public override string ToString() {
            return Nome + ", " + Gmail;
        } 
    }
}