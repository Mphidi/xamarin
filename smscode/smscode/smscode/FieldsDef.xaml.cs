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

            var field01 = new StackLayout() { Orientation = StackOrientation.Horizontal };
            var field02 = new StackLayout() { Orientation = StackOrientation.Horizontal };
            var field03 = new StackLayout() { Orientation = StackOrientation.Horizontal };
            var field04 = new StackLayout() { Orientation = StackOrientation.Horizontal };
            var field05 = new StackLayout() { Orientation = StackOrientation.Horizontal };
            var field06 = new StackLayout() { Orientation = StackOrientation.Horizontal };
            var field07 = new StackLayout() { Orientation = StackOrientation.Horizontal };
            var field08 = new StackLayout() { Orientation = StackOrientation.Horizontal };
            var field09 = new StackLayout() { Orientation = StackOrientation.Horizontal };

            if (numberOfFields-- > 0)
            {
                field01.Children.Add(new Entry()
                {
                    Text = "Field1",
                    TextColor = Color.FromHex("#f35e20"),
                    HorizontalOptions = LayoutOptions.EndAndExpand
                });    //VerticalOptions = LayoutOptions.Center
            }

            if (numberOfFields-- > 0)
            {
                field02.Children.Add(new Entry()
                {
                    Text = "Field2",
                    TextColor = Color.FromHex("#f35e20"),
                    HorizontalOptions = LayoutOptions.EndAndExpand
                    //VerticalOptions = LayoutOptions.Center
                });
            }

            if (numberOfFields-- > 0)
            {

                field03.Children.Add(new Entry()
                {
                    Text = "Field3",
                    TextColor = Color.FromHex("#f35e20"),
                    HorizontalOptions = LayoutOptions.EndAndExpand
                });
            }

            if (numberOfFields-- > 0)
            {
                field04.Children.Add(new Entry()
                {
                    Text = "Field4",
                    TextColor = Color.FromHex("#f35e20"),
                    HorizontalOptions = LayoutOptions.EndAndExpand
                });
            }

            if (numberOfFields-- > 0)
            {
                field05.Children.Add(new Entry()
                {
                    Text = "Field5",
                    TextColor = Color.FromHex("#f35e20"),
                    HorizontalOptions = LayoutOptions.EndAndExpand
                });
            }

            if (numberOfFields-- > 0)
            {
                field06.Children.Add(new Entry()
                {
                    Text = "Field6",
                    TextColor = Color.FromHex("#f35e20"),
                    HorizontalOptions = LayoutOptions.EndAndExpand
                });
            }

            if (numberOfFields-- > 0)
            {
                field07.Children.Add(new Entry()
                {
                    Text = "Field7",
                    TextColor = Color.FromHex("#f35e20"),
                    HorizontalOptions = LayoutOptions.EndAndExpand
                });
            }

            if (numberOfFields-- > 0)
            {
                field08.Children.Add(new Entry()
                {
                    Text = "Field8",
                    TextColor = Color.FromHex("#f35e20"),
                    HorizontalOptions = LayoutOptions.EndAndExpand
                });
            }

            if (numberOfFields-- > 0)
            {
                field09.Children.Add(new Entry()
                {
                    Text = "Field9",
                    TextColor = Color.FromHex("#f35e20"),
                    HorizontalOptions = LayoutOptions.EndAndExpand
                });
            }

            table.Root = new TableRoot()
                    {
                        new TableSection("Fields")
                        {
                            new ViewCell() {View = field01},
                            new ViewCell() {View = field02},
                            new ViewCell() {View = field03},
                            new ViewCell() {View = field04},
                            new ViewCell() {View = field05},
                            new ViewCell() {View = field06},
                            new ViewCell() {View = field07},
                            new ViewCell() {View = field08},
                            new ViewCell() {View = field09}


                        }

                      };
            Content = table;
        }
    }
}
