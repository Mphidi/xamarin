using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace smscode
{
    public partial class homepage : ContentPage
    {
        public homepage()
        {
            InitializeComponent();
        }

        private async void navProjectFieldsDef(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new FieldsDef(entryProjectName.Text, pickerNumberOfFields.Items[pickerNumberOfFields.SelectedIndex], pickerSeparator.Items[pickerSeparator.SelectedIndex]));
            //await Navigation.PushAsync(new FieldsDef("tested well"));

        }
    }

}
