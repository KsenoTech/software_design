using DTO;
using System.Collections.Generic;

namespace Interfaces.Services
{
    public interface IMotoService
    {
        List<MotoDto> GetAllMotos();
        MotoDto GetMoto(int motoId);
        void CreateMoto(MotoDto p);
        void UpdateMoto(MotoDto p);
        void DeleteMoto(int id);

        List<TypeDto> GetTypes();
    }
}
