using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace LearningUWP2
{
    public class NotificationBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void NotififyPropertyChanged([CallerMemberName] string name = null)
        {
            if(PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }
    }
}