using System;

namespace Biblioteca.Models
{
    public class Prestamo
    {
        public Libro Libro { get; set; } = new Libro("", "", 0);
        public Usuario Usuario { get; set; } = new Usuario("", "");
        public DateTime FechaPrestamo { get; set; }
        public DateTime? FechaDevolucion { get; set; }
        public EstadoPrestamo Estado { get; set; }

        public Prestamo()
        {
            Estado = EstadoPrestamo.Activo;
            FechaDevolucion = null;
        }

        public Prestamo(Libro libro, Usuario usuario)
        {
            Libro = libro;
            Usuario = usuario;
            FechaPrestamo = DateTime.Now;
            Estado = EstadoPrestamo.Activo;
            FechaDevolucion = null;
        }

        public bool EstaVencido()
        {
            return (DateTime.Now - FechaPrestamo).Days > 7;
        }

        public int DiasTranscurridos()
        {
            return (DateTime.Now - FechaPrestamo).Days;
        }

        public string ResumenCorto()
        {
            return $"{Libro.Titulo} - {Usuario.Nombre}";
        }

        public string DetalleCompleto()
        {
            return $"Libro: {Libro.Titulo}, Usuario: {Usuario.Nombre}, Estado: {Estado}, Fecha: {FechaPrestamo}";
        }

        public override string ToString()
        {
            return DetalleCompleto();
        }
    }
}