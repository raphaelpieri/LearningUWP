using System.Threading.Tasks;

namespace ModelsP
{
    public interface IDialogService
    {
        Task<int> ShowDialogAsync(string title, string caption, string button1, string button2);
    }
}
