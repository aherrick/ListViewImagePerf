﻿using Microsoft.Maui.Controls;
using System.Collections.Generic;

namespace ListViewImagePerf.Maui
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            var items = new List<ItemDto>();
            for (int i = 0; i < 10; i++)
            {
                items.Add(new ItemDto());
            }

            lstView.ItemsSource = items;
        }
    }
}