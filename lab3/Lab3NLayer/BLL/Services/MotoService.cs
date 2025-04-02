using BLL.DTO;
using DAL.NewFolder1;
using System.Collections.Generic;
using System.Linq;

namespace BLL.Services
{
    public class MotoService //бизнес-логика над данными (ф-ция и crud)
    {
        private shop db;
        public MotoService()
        {
            db = new shop();
        }

        public List<MotoDto> GetAllMotos()
        {
            return db.Motorcycles.ToList().Select(i => new MotoDto(i)).ToList();
        }

        public MotoDto GetMoto(int Id)
        {
            return new MotoDto(db.Motorcycles.Find(Id));
        }

        public void CreateMoto(MotoDto p)
        {
            db.Motorcycles.Add(new Motorcycle() { 
                Cost = p.Cost, 
                Id = 1,
                Brand_name = p.Brand_name, 
                Color = p.Color,
                Model_name = p.Model_name
            });
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
            Motorcycle ph = db.Motorcycles.Find(p.Id);
            ph.Brand_name = p.Brand_name;
            ph.Cost = p.Cost;
            ph.Model_name = p.Model_name;
            ph.id_Type_FK = p.id_Type_FK;
            Save();
        }

        public void DeleteMoto(int id)
        {
            Motorcycle p = db.Motorcycles.Find(id);
            if (p != null)
            {
                db.Motorcycles.Remove(p);
                Save();
            }
        }


        public bool Save()
        {
            if (db.SaveChanges() > 0) return true;
            return false;
        }

        public List<TypeDto> GetTypes()
        {
            return db.Types.ToList().Select(i => new TypeDto(i)).ToList();
        }
    }
}
