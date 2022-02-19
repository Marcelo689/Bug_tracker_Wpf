using System.Collections.ObjectModel;

namespace Bug_tracker.Services
{
    public interface IDataService<T>
    {
        ObservableCollection<T> GetAll();
        T Get(int id);
        T Create(T entity);
        T Update(int id, T entity);
        bool Delete(int id);

    }
}
