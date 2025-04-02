using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Lab5AspnetMVC.Models
{
    public class PhoneModel
    {
        public int Id { get; set; }

        [DisplayName("Название")]
        [Required]
        public string Name { get; set; }

        [DisplayName("Цена, руб")]
        [Range(typeof(decimal),"100", "100000",ErrorMessage ="Диапазон стоимости от 100 до 100000")]
        public decimal Cost { get; set; }

        public int ManufacturerId { get; set; }

        [DisplayName("Производитель")]
        public string ManufacturerName { get; set; }

        public List<ManufacturerDto> Manufs { get; set; }

        public PhoneModel() { }

        public PhoneModel(List<ManufacturerDto> Manufs)
        {
            this.Manufs = Manufs;
        }
        public PhoneModel(PhoneDto p, List<ManufacturerDto> Manufs)
        {
            Id = p.Id;
            Name = p.Name;
            Cost = p.Cost;
            ManufacturerId = p.ManufacturerId;
            ManufacturerName = Manufs.Where(i=>i.Id==p.ManufacturerId).FirstOrDefault().Name;
            this.Manufs = Manufs;
        }
    }
}