using ConsoleApp1.Entities;

namespace ConsoleApp1.Servicios;

//Logica para agregar, modificar, obtener nuestros libros
public static class BookService
{
    //Creo una lista de libros y la instancio
    public static List<Libro> books = new();
    //Al instanciar la lista, ya no deja de ser null? Consultar

    //Agregar nuevo libro
    public static string AddBook()
    {
        //Primero debe ver si el libro con ese id se encuentra en la lista, hacer una verificacion

        try
        {
            //Pido los datos al usuario para agregar el nuevo libro
            Console.WriteLine("AddBook");
            Console.WriteLine("Ingrese el Id del libro");
            int id = Convert.ToInt32(Console.ReadLine());
            
            var ubicar = books.FirstOrDefault(x => x.Id == id);
            if (ubicar == null)
            {
                Console.WriteLine("Ingrese el titulo del libro");
                string title = Console.ReadLine();
                Console.WriteLine("Ingrese el autor del libro");
                string author = Console.ReadLine();
                Console.WriteLine("Ingrese la categoria del libro");
                string category = Console.ReadLine();

                //Creo un nuevo libro, instancia la clase
                var book = new Libro
                {
                    Id = id,
                    Title = title,
                    Author = author,
                    Category = category,
                    IsAvailable = true
                };

                //Agrego el libro a la lista
                books.Add(book);
                string message = $"El libro {book.Title} ha sigo agregado correctamente";
                return message;
            }
            return "Un libro con ese Id ya se encuentra en la lista. OJO!";
        }
        catch (Exception ex)
        {

            return ex.Message;
        }
        
        
    }

    //Modificar libro
    public static string UpdateBook()
    {
        //Verifico si hay libros en la biblioteca para actualizar
        if (books.Count == 0)
        {
            return "No hay libros todavia para editar";
        }
        else
        {
            try
            {
                Console.WriteLine("Actualizar Libro");
                //Pedimos los datos del libro a actualizar
                Console.WriteLine("Ingrese el Id del libro");
                int id = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("Ingrese el titulo del libro");
                string title = Console.ReadLine();
                Console.WriteLine("Ingrese el autor del libro");
                string author = Console.ReadLine();
                Console.WriteLine("Ingrese la categoria del libro");
                string category = Console.ReadLine();


                //Para ubicar el libro en la lista, que conincida con el id que acabo de ingresar
                var libro = books.FirstOrDefault(x => x.Id == id);
                //Sino existe devuelve null(tarea del metodo este en particular)
                if (libro == null)
                {
                    return $"El libro con Id {id} no existe";
                }

                libro.Title = title;
                libro.Author = author;
                libro.Category = category;

                return $"El libro con el Id {libro.Id} ha sigo actualizado correctamente";
            }
            catch (Exception ex)
            {

                return $"Error: {ex.Message}";
            }

            
        }
    }

    public static string Delete()
    {

        if (books.Count == 0)
        {
            return "No hay libros todavia para borrar";
        }
        else
        {
            try
            {
                Console.WriteLine("Borrar libro");
                Console.WriteLine("Ingrese el Id del libro");
                int id = Convert.ToInt16(Console.ReadLine());
                //Buscar el libro en la lista, a traves del id
                var libro = books.FirstOrDefault(x => x.Id == id);
                //Sino existe devuelve null(tarea del metodo este en particular)
                if (libro != null)
                {
                    books.Remove(libro);

                    return "El libro con Id ha sido eliminado correctamente";
                }
                return $"El libro con Id {id} no existe";
            }
            catch (Exception ex)
            {

                return $"Error: {ex.Message}";
            }
            
        }
    }


    public static string GetAll()
    {
        string message = string.Empty;
        Console.WriteLine("Listado de Libros");
        //Validacion para ver si hay o no libros en la lista
        if (books.Count == 0)
            message = "No hay libros disponibles";

        foreach (var book in books)
        {
            message += $"\nId: {book.Id} \nTitulo: {book.Title} \nAutor: {book.Author} \nCategoria: {book.Category} \nDisponible: {book.IsAvailable} \n----------------------------------------------------------";

        }
        return message;

    }


}

