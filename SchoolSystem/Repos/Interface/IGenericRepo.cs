namespace SchoolSystem.Repos.Interface
{
    public interface IGenericRepo<T> where T : class
    {
        Task<List<T>> GetAll();
        Task<T> GetById(int id);
        void Add(T item);
        void Update(T item);
        void Delete(T item);

    }
}
