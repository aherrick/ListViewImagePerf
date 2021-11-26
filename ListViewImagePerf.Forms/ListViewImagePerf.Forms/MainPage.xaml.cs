using System.Collections.Generic;
using Xamarin.Forms;

namespace ListViewImagePerf.Forms
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            var items = new List<ItemDto>();
            for (int i = 0; i < 500; i++)
            {
                items.Add(new ItemDto());
            }

            lstView.ItemsSource = items;
        }
    }
}