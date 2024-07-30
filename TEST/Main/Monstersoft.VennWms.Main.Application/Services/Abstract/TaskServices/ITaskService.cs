using Monstersoft.VennWms.Main.Domain.Entities.TaskEntities;

namespace Monstersoft.VennWms.Main.Application.Services.Abstract.TaskServices;

public interface ITaskService
{
    public Task AssignTaskByTask(Guid[] taskIds, int userId, Guid depositorCompanyId, Guid? depositorId = null); //Kullanıcıya görev idleri ile görev atamak.
    public Task AssignTaskByTaskList(Guid[] taskListIds, int userId, Guid depositorCompanyId, Guid? depositorId = null); //Kullanıcıya görev liste idleri ile görev atamak.
    public Task CancelTaskList(Guid[] taskListIds, int userId, Guid depositorCompanyId, Guid? depositorId = null); //Görev listesini iptal etmek için.
    public Task CancelTask(Guid[] taskIds, int userId, Guid depositorCompanyId, Guid? depositorId = null); //Görevi iptal etmek için.
    public Task ChangeFinalLocation(Guid taskId, Guid finalLocationId, int userId, Guid depositorCompanyId, Guid? depositorId = null); //Görevin hedef lokasyonunu değiştirmek için.
    public Task ExecuteTask(Guid[] taskIds, int userId, Guid depositorCompanyId, Guid? depositorId = null); //Görevi bitirmek için.
    public Task ExecuteTaskList(Guid[] taskListIds, int userId, Guid depositorCompanyId, Guid? depositorId = null); //Görev listesini bitirmek için.
    public Task DeleteTask(Guid taskId, int userId, Guid depositorCompanyId, Guid? depositorId = null); //Görevi silmek için.
    public Task DeleteTaskList(Guid taskListId, int userId, Guid depositorCompanyId, Guid? depositorId = null); //Görev listesini silmek için.
    public Task<TaskList> MergeTaskList(Guid[] taskListIds, int userId, Guid depositorCompanyId, Guid? depositorId = null); //Görev listelerini birleştirmek için.
    public Task PrepackTaskList(Guid[] taskListId, int userId, Guid depositorCompanyId, Guid? depositorId = null); //Görev listesini ön paketlemek için.
    public Task PrepackTask(Guid[] taskIds, int userId, Guid depositorCompanyId, Guid? depositorId = null); //Görevleri ön paketlemek için.
    public Task ReleaseTask(Guid[] taskIds, int userId, Guid depositorCompanyId, Guid? depositorId = null); //Görevi serbest bırakmak için.
    public Task ChangeTaskStock(Guid taskId, Guid stockId, int userId, Guid depositorCompanyId, Guid? depositorId = null); //Görevin stokunu değiştirmek için.
    public Task SplitTask(Guid taskId, decimal quantity, int userId, Guid depositorCompanyId, Guid? depositorId = null); //Görevi bölme işlemi için.
}
