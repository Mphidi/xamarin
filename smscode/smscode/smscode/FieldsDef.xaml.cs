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
        private int numberOfFields;

        public FieldsDef(string nameOfProject, string noOfFields, string separator)
        {
            InitializeComponent();

            numberOfFields = Int32.Parse(noOfFields);
            var table = new TableView();
            table.Intent = TableIntent.Settings;

            var fields = new StackLayout() { Orientation = StackOrientation.Vertical };

            fields.Children.Add(new Label()
            {
                Text = "Fields",
                TextColor = Color.FromHex("#f35e20"),
                HorizontalOptions = LayoutOptions.FillAndExpand
            });

            if (numberOfFields-- > 0)
            {
                fields.Children.Add(new Entry()
                {
                    Text = "Field1",
                    TextColor = Color.FromHex("#f35e20"),
                    HorizontalOptions = LayoutOptions.FillAndExpand
                });    
            }

            if (numberOfFields-- > 0)
            {
                fields.Children.Add(new Entry()
                {
                    Text = "Field2",
                    TextColor = Color.FromHex("#f35e20"),
                    HorizontalOptions = LayoutOptions.FillAndExpand
                });
            }

            if (numberOfFields-- > 0)
            {

                fields.Children.Add(new Entry()
                {
                    Text = "Field3",
                    TextColor = Color.FromHex("#f35e20"),
                    HorizontalOptions = LayoutOptions.FillAndExpand
                });
            }

            if (numberOfFields-- > 0)
            {
                fields.Children.Add(new Entry()
                {
                    Text = "Field4",
                    TextColor = Color.FromHex("#f35e20"),
                    HorizontalOptions = LayoutOptions.FillAndExpand
                });
            }

            if (numberOfFields-- > 0)
            {
                fields.Children.Add(new Entry()
                {
                    Text = "Field5",
                    TextColor = Color.FromHex("#f35e20"),
                    HorizontalOptions = LayoutOptions.FillAndExpand
                });
            }

            if (numberOfFields-- > 0)
            {
                fields.Children.Add(new Entry()
                {
                    Text = "Field6",
                    TextColor = Color.FromHex("#f35e20"),
                    HorizontalOptions = LayoutOptions.FillAndExpand
                });
            }

            if (numberOfFields-- > 0)
            {
                fields.Children.Add(new Entry()
                {
                    Text = "Field7",
                    TextColor = Color.FromHex("#f35e20"),
                    HorizontalOptions = LayoutOptions.FillAndExpand
                });
            }

            if (numberOfFields-- > 0)
            {
                fields.Children.Add(new Entry()
                {
                    Text = "Field8",
                    TextColor = Color.FromHex("#f35e20"),
                    HorizontalOptions = LayoutOptions.FillAndExpand
                });
            }

            if (numberOfFields-- > 0)
            {
                fields.Children.Add(new Entry()
                {
                    Text = "Field9",
                    TextColor = Color.FromHex("#f35e20"),
                    HorizontalOptions = LayoutOptions.FillAndExpand
                });
            }

            Content = fields;
        }
    }
}
