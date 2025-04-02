using DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Type = DomainModel.Type;

namespace DAL.DbContexts
{
    public static class InitialData
    {
        public static IList<Type> TypeList => new List<Type>
        {
                new Type() { Id=1, Name = "Спортивный" },
                new Type() { Id=2, Name = "Горный" },
                new Type() { Id=3, Name = "Трассовый" },

        };
    }
}
