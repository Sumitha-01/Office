namespace WebPizzaStore.Interface
{
        public interface IRepo<K, T>
        {
        T Add(T item);
        T Delete(K key);
        T Update(T item);
        ICollection<T> GetAll();
        T Get(K key);
    }
    
}
