using System;

namespace ProvaLivro.Models
{
    public class Livro
    {
        public int Id { get; set; }
        public Livro() => DataAdc = DateTime.Now;

        public string Nome { get; set; }

        public string Genero { get; set; }

        public int Ano { get; set; }

        public DateTime DataAdc { get; set; }

        public override string ToString() =>
            $"Nome: {Nome} | Genero: {Genero} | Ano: {Ano} | Data de Adição: {DataAdc}";


    }
}