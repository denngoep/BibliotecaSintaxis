using System;

namespace Biblioteca.Models
{
    public class Libro
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int Anio { get; set; }
        public bool Disponible { get; set; }

        public Libro()
        {
            Disponible = true;
        }

        public Libro(string titulo, string autor, int anio)
        {
            Titulo = titulo;
            Autor = autor;
            Anio = anio;
            Disponible = true;
        }

        public string ResumenCorto()
        {
            return $"{Titulo} - {Autor}";
        }

        public string DetalleCompleto()
        {
            return $"Título: {Titulo}, Autor: {Autor}, Año: {Anio}, Disponible: {Disponible}";
        }

        public override string ToString()
        {
            return DetalleCompleto();
        }
    }
}