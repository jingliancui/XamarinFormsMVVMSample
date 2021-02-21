using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.CommunityToolkit.ObjectModel;
using Xamarin.Forms;

namespace SampleApp
{
    public class XCTViewModel:ObservableObject
    {
        public XCTViewModel()
        {
            BtnColor = Color.Blue;
        }

        private Color btnColor;
        public Color BtnColor
        {
            get { return btnColor; }
            set
            {
                btnColor = value;
                OnPropertyChanged();
            }
        }

        public Command BusinessCmd => new Command(() =>
        {
            if (BtnColor == Color.Blue)
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
