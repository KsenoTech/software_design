using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Services
{
    public interface IOrderService
    {
        //Создает или изменяет существующий заказ
        OrderDto MakeOrder(OrderDto orderDto);
        List<OrderDto> GetAllOrders();
        OrderDto GetOrder(int Id);
        void DeleteOrder(int id);
    }
}
