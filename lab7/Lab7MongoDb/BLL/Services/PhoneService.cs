using DomainModel;
using DTO;
using Interfaces.Repository;
using Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class PhoneService: IPhoneService
    {
        private IDbRepos db;
        public PhoneService(IDbRepos repos)
        {
            db = repos;
        }

        public List<PhoneDto> GetAllPhones()
        {
            return db.Phones.GetList().Select(i=>new PhoneDto(i)).ToList();
        }


        public PhoneDto GetPhone(int Id)
        {
            return new PhoneDto(db.Phones.GetItem(Id));
        }

       public void CreatePhone(PhoneDto p)
        {
            db.Phones.Create(new Phone() {Cost=p.Cost,ManufacturerId=p.ManufacturerId, Name=p.Name, Description=p.Description });
            Save();
            //db.Phones.Attach(p);
        }

        public void UpdatePhone(PhoneDto p)
        {
            Phone ph = db.Phones.GetItem(p.Id);
            ph.Name = p.Name;
            ph.Cost = p.Cost;
            ph.Description = p.Description;
            ph.ManufacturerId = p.ManufacturerId;
            db.Phones.Update(ph);
            Save();
        }

        public void DeletePhone(int id)
        {
            Phone p = db.Phones.GetItem(id);
            if (p != null)
            {
                db.Phones.Delete(p.Id);
                Save();
            }
        }

 
        public bool Save()
        {
            if (db.Save() > 0) return true;
            return false;
        }

        public List<ManufacturerDto> GetManufacturers()
        {
            return db.Manufacturers.GetList().Select(i=>new ManufacturerDto(i)).ToList();
        }

    }
}
