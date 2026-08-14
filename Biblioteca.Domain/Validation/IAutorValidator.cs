using Biblioteca.Domain.Entities;

namespace Biblioteca.Domain.Validation
{
    
    public interface IAutorValidator
    {
        public int Id{get;set;}

        string? Validar (Autor autor);
    }

}