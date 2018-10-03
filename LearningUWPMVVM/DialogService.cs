using System;
using System.Threading.Tasks;
using ModelsP;
using Windows.UI.Xaml.Controls;

namespace LearningUWPMVVM
{
    public class DialogService : IDialogService
    {
        public async Task<int> ShowDialogAsync(string title, string caption, string button1, string button2)
        {
            var cd = new ContentDialog()
            {
                Title = title,
                Content = caption,
                PrimaryButtonText = button1 ?? "",
                SecondaryButtonText = button2 ?? ""
            };

            var result = await cd.ShowAsync().AsTask();
            if (result == ContentDialogResult.None)
            {
                return 0;
            }
            else if (result == ContentDialogResult.Primary)
            {
                return 1;
            }
            else
                return 2;
        }
    }
}
