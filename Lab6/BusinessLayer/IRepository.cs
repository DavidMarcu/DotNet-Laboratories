using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab6.Data;

namespace Lab6.BusinessLayer
{
    public interface IRepository
    {
        void Create(Poi poi);
        Poi GetByID(Guid id);
        List<Poi> GetAll();
        void Delete(Guid id);
        void Update(Poi poi);
    }
}
