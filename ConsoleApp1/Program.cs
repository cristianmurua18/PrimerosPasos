using ConsoleApp1.Servicios;
using ConsoleApp1.Utils;


while (true)
{
    //Para borrar la pantalla en cada vuelva del bucle
    Console.Clear();


    //Creo un metodo que se llama cada vez que necesito una opcion
    //Como el metodo devuelve un numero, lo guardo en la varible 
    var opcion = Options();

    //Convierto la opcion en un OptionEnum a traves de un casteo(lo trata como si fuera ese tipo de dato)
    var optionEnum = (OptionEnum)opcion;
    //Evuluo si me ingresa un 5 para salir del bucle
    if (opcion == 5)
        return;

    //Volver a revisar
    //Varible que guarda un mensaje
    string message = optionEnum switch
    {
        //Cada metodo devuelve un string
        OptionEnum.Add => BookService.AddBook(),
        OptionEnum.Update => BookService.UpdateBook(),
        OptionEnum.Delete => BookService.Delete(),
        OptionEnum.Get => BookService.GetAll(),
        OptionEnum.Exit => "Salir",
        _ => "Opcion no valida"

    };
    //Para imprimir por consola la informacion(el mensaje)
    Console.WriteLine(message);
    Console.ReadLine();

}


//Metodo static que devuelve un numero(por el int)
static int Options()
{
    //Para tratar de controlar la exepcion
    try
    {
        Console.WriteLine("Bienvenido a La Biblioteca");
        Console.WriteLine("1. Crear Libro");
        Console.WriteLine("2. Editar un Libro");
        Console.WriteLine("3. Eliminar un Libro");
        Console.WriteLine("4. Obtener Listado de Libros");
        Console.WriteLine("5. Salir");

        Console.Write("Ingrese opcion: ");
        var opcion = Convert.ToInt16(Console.ReadLine());

        return opcion;
    }
    catch (Exception)
    {
        Console.WriteLine("Formato incorrecto de numero. Intente de nuevo");
        return 0;
    }





}

//Ver string.append()

//En Id hace Books.Count + 1
//Para hacerlo tipo autoincremental

//Metodo tryparse