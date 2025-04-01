using WebApi8.Models;

namespace WebApi8.Services.Autor
{
    public class IAutorInterfaceBase
    {
        Task<ResponseModel<AutorModel>> BuscarAutorPorId(int idAutor);
        Task<ResponseModel<AutorModel>> BuscarAutorPorId(int idLivro);
    }
}