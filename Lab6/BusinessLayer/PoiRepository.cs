using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Lab6.Data;
using Microsoft.EntityFrameworkCore;

namespace Lab6.BusinessLayer
{
    public class PoiRepository:IRepository
    {
        private readonly PoiContext _context;
        private DbSet<Poi> dbSet;

        public PoiRepository(PoiContext context)
        {
            _context = context;
            dbSet = context.Set<Poi>();
        }

        public void Create(Poi poi)
        {
            dbSet.Add(poi);
            _context.SaveChanges();
        }

        public Poi GetByID(Guid id)
        {
            return dbSet.Find(id);
        }

        public List<Poi> GetAll()
        {
            return _context.pois.ToList();
        }

        public void Delete(Guid id)
        {
            Poi poi = dbSet.Find(id);
            Delete(poi);
        }

        public void Delete(Poi poi)
        {
            if (_context.Entry(poi).State == EntityState.Detached)
            {
                dbSet.Attach(poi);
            }
            dbSet.Remove(poi);
            _context.SaveChanges();
        }

        public void Update(Poi poi)
        {
            dbSet.Attach(poi);
            _context.Entry(poi).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}

