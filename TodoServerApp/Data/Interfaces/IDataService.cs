namespace TodoServerApp.Data.Interfaces
{
    public interface IDataService
    {
        Task<IEnumerable<TaskItem>> GetAllAsync();
        Task SaveAsync(TaskItem task);
        Task<TaskItem> GetTaskAsync(int id);
        Task DeleteAsync(int id);

    }
}
