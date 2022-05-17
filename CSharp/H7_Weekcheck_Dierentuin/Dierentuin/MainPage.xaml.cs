using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.Storage.Pickers;
namespace Dierentuin
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void lvAnimals_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        private async void Button_Click(object sender, RoutedEventArgs e)
        {
           var animals = new List<Animal>();
            
            var picker = new FileOpenPicker();
            picker.SuggestedStartLocation = PickerLocationId.Downloads;
            picker.FileTypeFilter.Add(".quote");

            var file = await picker.PickSingleFileAsync();

            using (var fileAccess = await file.OpenReadAsync())
            {
                using (var stream = fileAccess.AsStreamForRead())
                {
                    using (var reader = new StreamReader(stream))
                    {
                         = reader.ReadLine();
                    }
                }
            }
        }
    }
}