using System;

namespace TsukaAirLines {
    public class Passageiro {
        string nome;
        int numeroPassagem;
        DateTime data;

        public void setNome(string nome){
            this.nome = nome;
        }

        public string getNome(){
            return this.nome;
        }

        public void setNumero(int numeroPassagem){      //Feito em casa (inicio)
            this.numeroPassagem = numeroPassagem;
        }

        public int getNumero(){
            return this.numeroPassagem;
        }

        public void setData(DateTime data){
            this.data = data;
        }

        public getData(){               //Feito em casa (Final)
            return this.data;
        }
    }
}