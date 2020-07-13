using System.Threading.Tasks;

namespace ModuleDefinitions
{
    public interface IFormNotifier
    {
        Task NotifyFormSubmitAsync(string notifyText);
    }
}
