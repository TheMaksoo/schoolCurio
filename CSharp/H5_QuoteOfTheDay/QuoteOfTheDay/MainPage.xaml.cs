using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// Belangrijke using!
// System.IO is de namespace waar de klassen van de OpenReadAsync en AsStreamForRead methodes staan!
using System.IO;
// Belangrijk using!
// Windows.Storage.Pickers is de namespace waar FileOpenPicker en PickerLocationId in staan.
using Windows.Storage.Pickers; 

namespace QuoteOfTheDay
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            // Eerst de lay-out inladen
            this.InitializeComponent();
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            loadingIndicator.Visibility = Visibility.Visible;

            var picker = new FileOpenPicker();
            picker.SuggestedStartLocation = PickerLocationId.Downloads;
            picker.FileTypeFilter.Add(".quote");

            var file = await picker.PickSingleFileAsync();

            loadingIndicator.Visibility = Visibility.Collapsed;

            if (file == null)
            {
                quoteFile.Text = "Geen geldig bestand gekozen! Kies een .quote bestand.";
                return;
            }

            quoteFile.Text = file.Path;

            // Open het gekozen bestand en krijg toegang om te lezen (read)
            using (var fileAccess = await file.OpenReadAsync())
            {
                // Open een Stream (soort tunneltje) van het bestand naar de lezer
                using (var stream = fileAccess.AsStreamForRead())
                {
                    // Open een 'lezer' (reader) die via de stream het bestand gaat lezen
                    using (var reader = new StreamReader(stream))
                    {
                        // Lees eerste regel uit het bestand en laat dat zien
                        quoteText.Text = reader.ReadLine();

                        // Lees de tweede regel en laat dat zien
                        quoteAuthor.Text = reader.ReadLine();

                        // Lees de derde regel en laat dat zien
                        quoteLanguage.Text = $"({reader.ReadLine()})";

                        // Iedere keer dat reader.ReadLine() wordt aangeroepen gaat de
                        // lezer (reader) automatisch verder naar de volgende regel
                    }
                }
            }
        }
    }
}