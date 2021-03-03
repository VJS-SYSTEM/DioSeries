using System;

namespace Dio.Series
{
    public class Serie : EntidadeBase
    {
        //Atributos
        private Genero Genero {get; set;}
        private string Titulo {get; set;}
        private string Descsricao {get; set;}
        private int Ano {get; set;}
        private bool Excluido {get; set;}


       //Métodos
       public Serie(int id, Genero genero, string titulo, string descicao, int ano)
       {
           this.ID = id;
           this.Genero = genero;
           this.Titulo = titulo;
           this.Descsricao = descicao;
           this.Ano = ano;
           this.Excluido = false;
       }

        public override string ToString()
        {
            string retorno = "";
            retorno += "Genero: " + this.Genero + Environment.NewLine;
            retorno += "Titulo: " + this.Titulo + Environment.NewLine;
            retorno += "Descsricao: " + this.Descsricao + Environment.NewLine;
            retorno += "Ano de Inicio: " + this.Ano + Environment.NewLine;
            retorno += "Excluído: " + this.Excluido;
            return retorno;
        }

        public string retornaTitulo()
        {
            return this.Titulo;
        }

        public int retornaId()
        {
            return this.ID;
        }

        public void Exclui()
        {
            this.Excluido = true;
        }
           public bool retornaExcluido()
        {
            return this.Excluido;
        }

        
    }
}