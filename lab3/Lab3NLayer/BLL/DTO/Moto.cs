using DAL;
using DAL.NewFolder1;

namespace BLL.DTO
{
    public class MotoDto //модели бизнес-логики
    {
        public string Brand_name { get; set; }

        public string Model_name { get; set; }

        public string Color { get; set; }

        public int Id { get; set; }

        public int Cost { get; set; }

        public int? id_Type_FK { get; set; }

        public MotoDto() { }
        public MotoDto(Motorcycle p)
        {
            Id = p.Id;
            Brand_name = p.Brand_name;
            Cost = p.Cost;
            Model_name = p.Model_name;
            id_Type_FK = p.id_Type_FK;
            Color = p.Color;
        }
    }
}
