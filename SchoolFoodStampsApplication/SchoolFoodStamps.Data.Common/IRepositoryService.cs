namespace SchoolFoodStamps.Data.Common
{
    public interface IRepositoryService
    {
        IQueryable<T> All<T>() where T : class;

        IQueryable<T> AllReadOnly<T>() where T : class;
    }
}
