namespace Biblioteca;

class Program
{
    static List<string> libros = new List<string>();
    static List<string> usuarios = new List<string>();

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

            option = Console.ReadLine() ?? "";

            if (option == "1")
                ShowBooksMenu();
            else if (option == "2")
                ShowUsersMenu();
        }
    }

    // ================= LIBROS =================
    static void ShowBooksMenu()
    {
        string option = "";

        while (option != "3")
        {
            Console.WriteLine("\n=== MENÚ LIBROS ===");
            Console.WriteLine("1. Agregar libro");
            Console.WriteLine("2. Listar libros");
            Console.WriteLine("3. Volver");

            option = Console.ReadLine() ?? "";

            if (option == "1")
                AddBook();
            else if (option == "2")
                ListBooks();
        }
    }

    static void AddBook()
    {
        Console.Write("Ingrese el nombre del libro: ");
        string nombre = Console.ReadLine() ?? "";

        libros.Add(nombre);
        Console.WriteLine("Libro agregado correctamente");
    }

    static void ListBooks()
    {
        Console.WriteLine("\nLISTA DE LIBROS:");

        if (libros.Count == 0)
            Console.WriteLine("No hay libros registrados.");
        else
        {
            for (int i = 0; i < libros.Count; i++)
                Console.WriteLine($"{i + 1}. {libros[i]}");
        }
    }

    // ================= USUARIOS =================
    static void ShowUsersMenu()
    {
        string option = "";

        while (option != "3")
        {
            Console.WriteLine("\n=== MENÚ USUARIOS ===");
            Console.WriteLine("1. Agregar usuario");
            Console.WriteLine("2. Listar usuarios");
            Console.WriteLine("3. Volver");

            option = Console.ReadLine() ?? "";

            if (option == "1")
                AddUser();
            else if (option == "2")
                ListUsers();
        }
    }

    static void AddUser()
    {
        Console.Write("Ingrese el nombre del usuario: ");
        string nombre = Console.ReadLine() ?? "";

        usuarios.Add(nombre);
        Console.WriteLine("Usuario agregado correctamente");
    }

    static void ListUsers()
    {
        Console.WriteLine("\nLISTA DE USUARIOS:");

        if (usuarios.Count == 0)
            Console.WriteLine("No hay usuarios registrados.");
        else
        {
            for (int i = 0; i < usuarios.Count; i++)
                Console.WriteLine($"{i + 1}. {usuarios[i]}");
        }
    }
}