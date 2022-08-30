using System.Threading.Tasks;
using ProEventos.Domain;

namespace ProEventos.Persistence.Contratos
{
    public interface IEventoPersist
    {
        Task<Evento[]> GetAllEventosByTemaAsync(string tema, bool includePalestantes = false);
        Task<Evento[]> GetAllEventosAsync(bool includePalestantes = false);
        Task<Evento> GetEventoByIdAsync(int eventoId, bool includePalestantes = false);
    }
}