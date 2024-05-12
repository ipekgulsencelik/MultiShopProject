namespace MultiShop.Services.Cargo.DataAccessLayer.Abstract
{
    public interface IGenericDAL<T> where T : class
    {
        void Insert(T entity);
        void Update(T entity);
        void Delete(int id);
        T GetByID(int id);
        List<T> GetAll();
    }
}