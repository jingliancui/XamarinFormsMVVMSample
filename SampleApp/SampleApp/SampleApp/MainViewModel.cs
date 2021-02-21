using System.ComponentModel;
using System.Runtime.CompilerServices;
using Xamarin.Forms;

namespace SampleApp
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private bool SetProperty<T>(ref T field, T newValue, [CallerMemberName] string propertyName = null)
        {
            if (!(object.Equals(field, newValue)))
            {
                field = (newValue);
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
                return true;
            }

            return false;
        }

        public MainViewModel()
        {
            BtnColor = Color.Blue;
        }

        private Color btnColor;
        public Color BtnColor
        {
            get { return btnColor; }
            set
            { 
                SetProperty(ref btnColor,value); 
            }
        }

        public Command BusinessCmd=>new Command(()=>
        {
            if (BtnColor==Color.Blue)
            {
                BtnColor = Color.Red;
                return;
            }
            if (BtnColor == Color.Red)
            {
                BtnColor = Color.Blue;
                return;
            }
        });        
    }
}