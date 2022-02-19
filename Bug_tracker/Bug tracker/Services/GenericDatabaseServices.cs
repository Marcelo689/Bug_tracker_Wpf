using Bug_tracker.Conexao;
using Bug_tracker.Model;
using System;
using System.Collections.ObjectModel;
using System.Linq;

namespace Bug_tracker.Services
{
    public class GenericDatabaseServices<T> : IDataService<T> where T : Bug
    {
        public readonly Conexao.Conexao contextFactory;
        public GenericDatabaseServices(Conexao.Conexao contextFactory)
        {
            this.contextFactory = contextFactory;
        }
        public T Create(T entity)
        {
            using(DB context = contextFactory.CreateDbContext())
            { 
                var newEntity = context.Set<T>().Add(entity);
                context.SaveChanges();
                return newEntity.Entity;
            }
        }

        public bool Delete(int id)
        {
            using(DB context = contextFactory.CreateDbContext())
            {
                T entity = context.Set<T>().FirstOrDefault((e) => e.Id == id);
                context.Set<T>().Remove(entity);
                context.SaveChanges();

                return true;
            }
        }

        public T Get(int id)
        {
            using (DB context = contextFactory.CreateDbContext())
            {
                T entity = context.Set<T>().FirstOrDefault((e) => e.Id == id);
                return entity;
            }
        }

        public ObservableCollection<T> GetAll()
        {
            using(DB context = contextFactory.CreateDbContext())
            {
                ObservableCollection<T> entities= new ObservableCollection<T>();
                var list = context.Set<T>().ToList();
                entities = new ObservableCollection<T>(list);
                return entities;
            }
        }

        public T Update(int id, T entity)
        {
            using(DB context = contextFactory.CreateDbContext())
            {
                entity.Id = id;
                context.Set<T>().Update(entity);
                context.SaveChanges();
                return entity;

            }
        }
    }
}
