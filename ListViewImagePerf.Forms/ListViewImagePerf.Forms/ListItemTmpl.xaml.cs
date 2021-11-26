using FFImageLoading.Transformations;
using FFImageLoading.Work;
using System.Collections.Generic;
using Xamarin.Forms;

namespace ListViewImagePerf.Forms
{
    public partial class ListItemTmpl : ViewCell
    {
        public ListItemTmpl()
        {
            InitializeComponent();

            img.Transformations = new List<ITransformation>()
                {
                    new CircleTransformation(14, "#547799")
                };

            img.LoadingPriority = LoadingPriority.Highest;
        }

        protected override void OnBindingContextChanged()
        {
            if (BindingContext == null)
                return;

            if (!(BindingContext is ItemDto item))
                return;

            img.Source = item.ImageUrl;

            base.OnBindingContextChanged();
        }
    }
}