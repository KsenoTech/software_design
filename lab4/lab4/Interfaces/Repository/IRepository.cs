﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Repository
{
    // Generic репозитоорий CRUD
    public interface IRepository<T> where T : class
    {
        /// <summary>
        /// получение всех объектов
        /// </summary>
        /// <returns></returns>
        List<T> GetList();

        /// <summary>
        /// получение одного объекта по id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        T GetItem(int id);

        void Create(T item); // создание объекта
        void Update(T item); // обновление объекта
        void Delete(int id); // удаление объекта по id
    }

}
