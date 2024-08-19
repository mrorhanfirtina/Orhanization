namespace Orhanization.Core.Application.Events;

public static class TransactionScopeEvents
{
    public static event Func<Task> OnTransactionCompleted;

    public static async Task RaiseTransactionCompletedEvent()
    {
        if (OnTransactionCompleted != null)
        {
            await OnTransactionCompleted.Invoke();
        }
    }
}
