using Microsoft.Maui.Controls;

namespace ListViewImagePerf.Maui
{
    public partial class ListItemTmpl : ViewCell
    {
        public ListItemTmpl()
        {
            InitializeComponent();
        }

        protected override void OnBindingContextChanged()
        {
            if (BindingContext == null)
                return;

            if (!(BindingContext is ItemDto item))
                return;

            //img.Source = item.ImageUrl;

            base.OnBindingContextChanged();
        }
    }
}