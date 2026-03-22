namespace Biblioteca;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Sistema de Biblioteca");
        Console.WriteLine("Bienvenido al sistema");

        ShowMainMenu();

        Console.ReadLine();
    }
    
  static void ShowMainMenu()
{
    Console.WriteLine("1. Libros");
    Console.WriteLine("2. Usuarios");
    Console.WriteLine("3. Préstamos");
    Console.WriteLine("4. Búsquedas y reportes");
    Console.WriteLine("5. Guardar / Cargar datos");
    Console.WriteLine("6. Salir");
}
}
