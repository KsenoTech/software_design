using Interfaces.Services;
using DomainModel;
using DTO;
using Interfaces.Repository;
using System.Collections.Generic;
using System.Linq;

namespace BLL.Services
{
    public class MotoService : IMotoService//бизнес-логика над данными (ф-ция и crud)
    {
        private IDbRepos db;
        public MotoService(IDbRepos repos)
        {
            db = repos;
        }

        public List<MotoDto> GetAllMotos()
        {
            return db.Motos.GetList().Select(i => new MotoDto(i)).ToList();
        }


        public MotoDto GetMoto(int Id)
        {
            return new MotoDto(db.Motos.GetItem(Id));
        }

        public void CreateMoto(MotoDto p)
        {//id y мото
            db.Motos.Create(new Motorcycle() { Cost = p.Cost,
                Brand_name = p.Brand_name, Color = p.Color,
                Model_name = p.Model_name, id_Type_FK = p.id_Type_FK});
            Save();
            //db.Motorcycles.Attach(new Motorcycle()
            //{
            //    Cost = p.Cost,
            //    id_Motorcycle = 1,
            //    Brand_name = p.Brand_name,
            //    Color = p.Color,
            //    Model = p.Model
            //});
        }

        public void UpdateMoto(MotoDto p)
        {
            Motorcycle ph = db.Motos.GetItem(p.Id);
            ph.Brand_name = p.Brand_name;
            ph.Cost = p.Cost;
            ph.Color = p.Color;
            ph.Model_name = p.Model_name;
            ph.id_Type_FK = p.id_Type_FK;
            Save();
        }

        public void DeleteMoto(int id)
        {
            Motorcycle p = db.Motos.GetItem(id);
            if (p != null)
            {
                db.Motos.Delete(p.Id);
                Save();
            }
        }


        public bool Save()
        {
            if (db.Save() > 0) return true;
            return false;
        }

        public List<TypeDto> GetTypes()
        {
            return db.Types.GetList().Select(i => new TypeDto(i)).ToList();
        }
    }
}
