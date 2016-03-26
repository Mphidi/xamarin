using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace smscode
{
    public partial class FieldsDef : ContentPage
    {
        private String nameOfProject;
        private int numberOfFields;
        private Entry[] entries;

        public FieldsDef(string nameOfProject, string noOfFields, string separator)
        {
            InitializeComponent();
            this.nameOfProject = nameOfProject;
            numberOfFields = Int32.Parse(noOfFields);

            Content = setview();

        }

        protected Layout setview()
        {

            var layout = new StackLayout() { Orientation = StackOrientation.Vertical };

            layout.Children.Add(
                new Grid
                {
                    Padding = new Thickness(30,30,30,30),
                    Children ={
                                new Label()
                                {
                                    Text = "Names of Fields",
                                    TextColor = Color.FromHex("#f35e20"),
                                    HorizontalOptions = LayoutOptions.CenterAndExpand
                                }
                              }
                });

            add_entries(ref layout);

            layout.Children.Add( new Button()
            {
                Text = "Submit",
                TextColor = Color.FromHex("#f35e20"),
                HorizontalOptions = LayoutOptions.FillAndExpand
            });

            layout.Children.Add( new Button()
            {
                Text = "Go back",
                TextColor = Color.FromHex("#f35e20"),
                HorizontalOptions = LayoutOptions.FillAndExpand

            });

            return layout;
        }

        protected void add_entries(ref StackLayout layout)
        {

            entries = new Entry[numberOfFields];
            for (int i = 0; i < numberOfFields; i++)
            {
                entries[i] = new Entry()
                {
                    Placeholder = "Field ",
                    TextColor = Color.FromHex("#f35e20"),
                    HorizontalOptions = LayoutOptions.FillAndExpand
                };

                layout.Children.Add(entries[i]);
            }
        }

        public void clicked_submit_button()
        {

        }

        public void clicked_goback_button()
        {

        }
    }
}
