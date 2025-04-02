using DTO;
using System.Collections.Generic;

namespace Interfaces.Services
{
    public interface IPhoneService

    {
        List<PhoneDto> GetAllPhones();
        PhoneDto GetPhone(int phoneId);
        void CreatePhone(PhoneDto p);
        void UpdatePhone(PhoneDto p);
        void DeletePhone(int id);

        List<ManufacturerDto> GetManufacturers();
    }
}
