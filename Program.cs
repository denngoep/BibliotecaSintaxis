namespace Biblioteca;

class Program
{
    static List<string> libros = new List<string>();
    static List<string> usuarios = new List<string>();
    static List<string> prestamos = new List<string>();

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
            else if (option == "3")
                ShowLoansMenu();
            else if (option == "4")
                ShowSearchMenu();
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

    // ================= PRÉSTAMOS =================
    static void ShowLoansMenu()
    {
        string option = "";

        while (option != "3")
        {
            Console.WriteLine("\n=== MENÚ PRÉSTAMOS ===");
            Console.WriteLine("1. Registrar préstamo");
            Console.WriteLine("2. Listar préstamos");
            Console.WriteLine("3. Volver");

            option = Console.ReadLine() ?? "";

            if (option == "1")
                AddLoan();
            else if (option == "2")
                ListLoans();
        }
    }

    static void AddLoan()
    {
        if (libros.Count == 0 || usuarios.Count == 0)
        {
            Console.WriteLine("Debe haber al menos un libro y un usuario.");
            return;
        }

        Console.WriteLine("\nSeleccione un usuario:");
        for (int i = 0; i < usuarios.Count; i++)
            Console.WriteLine($"{i + 1}. {usuarios[i]}");

        int userIndex = int.Parse(Console.ReadLine() ?? "0") - 1;

        Console.WriteLine("\nSeleccione un libro:");
        for (int i = 0; i < libros.Count; i++)
            Console.WriteLine($"{i + 1}. {libros[i]}");

        int bookIndex = int.Parse(Console.ReadLine() ?? "0") - 1;

        if (userIndex >= 0 && userIndex < usuarios.Count &&
            bookIndex >= 0 && bookIndex < libros.Count)
        {
            string prestamo = $"{usuarios[userIndex]} - {libros[bookIndex]}";
            prestamos.Add(prestamo);

            Console.WriteLine("Préstamo registrado correctamente");
        }
        else
        {
            Console.WriteLine("Selección inválida");
        }
    }

    static void ListLoans()
    {
        Console.WriteLine("\nLISTA DE PRÉSTAMOS:");

        if (prestamos.Count == 0)
            Console.WriteLine("No hay préstamos registrados.");
        else
        {
            for (int i = 0; i < prestamos.Count; i++)
                Console.WriteLine($"{i + 1}. {prestamos[i]}");
        }
    }

    // ================= BÚSQUEDAS =================
    static void ShowSearchMenu()
    {
        string option = "";

        while (option != "4")
        {
            Console.WriteLine("\n=== BÚSQUEDAS Y REPORTES ===");
            Console.WriteLine("1. Buscar libro");
            Console.WriteLine("2. Buscar usuario");
            Console.WriteLine("3. Ver reporte general");
            Console.WriteLine("4. Volver");

            option = Console.ReadLine() ?? "";

            if (option == "1")
                SearchBook();
            else if (option == "2")
                SearchUser();
            else if (option == "3")
                ShowReport();
        }
    }

    static void SearchBook()
    {
        Console.Write("Ingrese nombre del libro: ");
        string search = Console.ReadLine() ?? "";

        foreach (var libro in libros)
        {
            if (libro.ToLower().Contains(search.ToLower()))
                Console.WriteLine(libro);
        }
    }

    static void SearchUser()
    {
        Console.Write("Ingrese nombre del usuario: ");
        string search = Console.ReadLine() ?? "";

        foreach (var usuario in usuarios)
        {
            if (usuario.ToLower().Contains(search.ToLower()))
                Console.WriteLine(usuario);
        }
    }

    static void ShowReport()
    {
        Console.WriteLine("\nREPORTE GENERAL:");
        Console.WriteLine($"Total libros: {libros.Count}");
        Console.WriteLine($"Total usuarios: {usuarios.Count}");
        Console.WriteLine($"Total préstamos: {prestamos.Count}");
    }
}