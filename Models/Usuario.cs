using System;

namespace Biblioteca.Models
{
    public class Usuario
    {
        public string Nombre { get; set; }
        public string Email { get; set; }
        public bool Activo { get; set; }

        public Usuario()
        {
            Activo = true;
        }

        public Usuario(string nombre, string email)
        {
            Nombre = nombre;
            Email = email;
            Activo = true;
        }

        public string ResumenCorto()
        {
            return $"{Nombre} - {Email}";
        }

        public string DetalleCompleto()
        {
            return $"Nombre: {Nombre}, Email: {Email}, Activo: {Activo}";
        }

        public override string ToString()
        {
            return DetalleCompleto();
        }
    }
}