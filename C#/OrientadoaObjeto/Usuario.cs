using System;

namespace OrientadoaObjeto {
    class Usuario {
        //static void Main(string[] args)
        //{
        string nome;
        string senha;
        string cpf;
        string email;

        //setter
        public void setSenha (string senha) {
            this.senha = senha;
        }
        //getter
        public string getSenha () {
            return this.senha;
        }
        //}   

    }
}