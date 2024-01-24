namespace ConsoleApp1.Entities;

public class Libro
{
    //Atributos de la clase, del tipo publicos
    public int Id { get; set; } = 0;

    public string? Title { get; set; }

    public string? Author { get; set; }

    public string? Category { get; set; }

    public bool IsAvailable { get; set; }


}

