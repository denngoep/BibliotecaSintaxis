namespace Biblioteca;

class Program
{
    // Lista para guardar libros
    static List<string> libros = new List<string>();

    static void Main(string[] args)
    {
        Console.WriteLine("Sistema de Biblioteca");
        Console.WriteLine("Bienvenido al sistema");

        ShowMainMenu();
    }

    static void ShowMainMenu()
    {
        string option = "";

        while (option != "6")
        {
            Console.WriteLine("\n=== MENÚ PRINCIPAL ===");
            Console.WriteLine("1. Libros");
            Console.WriteLine("2. Usuarios");
            Console.WriteLine("3. Préstamos");
            Console.WriteLine("4. Búsquedas y reportes");
            Console.WriteLine("5. Guardar / Cargar datos");
            Console.WriteLine("6. Salir");

            option = Console.ReadLine();

            if (option == "1")
            {
                ShowBooksMenu();
            }
        }
    }

    static void ShowBooksMenu()
    {
        string option = "";

        while (option != "3")
        {
            Console.WriteLine("\n=== MENÚ LIBROS ===");
            Console.WriteLine("1. Agregar libro");
            Console.WriteLine("2. Listar libros");
            Console.WriteLine("3. Volver");

            option = Console.ReadLine();

            if (option == "1")
            {
                AddBook();
            }
            else if (option == "2")
            {
                ListBooks();
            }
        }
    }

    static void AddBook()
    {
        Console.Write("Ingrese el nombre del libro: ");
        string nombre = Console.ReadLine();

        libros.Add(nombre);

        Console.WriteLine("Libro agregado correctamente");
    }

    static void ListBooks()
    {
        Console.WriteLine("\nLISTA DE LIBROS:");

        if (libros.Count == 0)
        {
            Console.WriteLine("No hay libros registrados.");
        }
        else
        {
            for (int i = 0; i < libros.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {libros[i]}");
            }
        }
    }
}
