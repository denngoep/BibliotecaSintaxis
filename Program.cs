using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

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
            else if (option == "5")
                ShowPersistenceMenu();
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
        {
            Console.WriteLine("No hay usuarios registrados.");
        }
        else
        {
            for (int i = 0; i < usuarios.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {usuarios[i]}");
            }
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
        Console.Write("Ingrese el préstamo: ");
        string prestamo = Console.ReadLine() ?? "";

        prestamos.Add(prestamo);

        Console.WriteLine("Préstamo registrado correctamente");
    }

    static void ListLoans()
    {
        Console.WriteLine("\nLISTA DE PRÉSTAMOS:");

        if (prestamos.Count == 0)
        {
            Console.WriteLine("No hay préstamos registrados.");
        }
        else
        {
            for (int i = 0; i < prestamos.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {prestamos[i]}");
            }
        }
    }

    // ================= BÚSQUEDAS =================

    static void ShowSearchMenu()
    {
        Console.WriteLine("\n=== BÚSQUEDAS Y REPORTES ===");
        Console.WriteLine("Funcionalidad en construcción...");
    }

    // ================= PERSISTENCIA =================

    static void ShowPersistenceMenu()
    {
        string option = "";

        while (option != "3")
        {
            Console.WriteLine("\n=== GUARDAR / CARGAR DATOS ===");
            Console.WriteLine("1. Guardar datos");
            Console.WriteLine("2. Cargar datos");
            Console.WriteLine("3. Volver");

            option = Console.ReadLine() ?? "";

            if (option == "1")
                SaveData();
            else if (option == "2")
                LoadData();
        }
    }

    static void SaveData()
    {
        File.WriteAllLines("libros.txt", libros);
        File.WriteAllLines("usuarios.txt", usuarios);
        File.WriteAllLines("prestamos.txt", prestamos);

        Console.WriteLine("Datos guardados correctamente");
    }

    static void LoadData()
    {
        if (File.Exists("libros.txt"))
            libros = File.ReadAllLines("libros.txt").ToList();

        if (File.Exists("usuarios.txt"))
            usuarios = File.ReadAllLines("usuarios.txt").ToList();

        if (File.Exists("prestamos.txt"))
            prestamos = File.ReadAllLines("prestamos.txt").ToList();

        Console.WriteLine("Datos cargados correctamente");
    }
}