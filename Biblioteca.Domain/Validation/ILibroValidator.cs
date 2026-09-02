using Biblioteca.Domain.Entities;

namespace Biblioteca.Domain.Validation
{
    
    public interface ILibroValidator
    {
       // public int Id{get;set;}

        string? Validar (Libro libro);
    }

}