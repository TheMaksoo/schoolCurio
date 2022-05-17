using System;
using System.Collections.Generic;
using System.IO;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace GuestHobbiesList
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            // Open een bestand-kiezer:
            var picker = new Windows.Storage.Pickers.FileOpenPicker();
            picker.FileTypeFilter.Add(".csv");

            // Laat de gebruiker de bestandskiezer zien:
            var file = await picker.PickSingleFileAsync();

            // Controleer of het NIET gelukt is om een file te kiezen,
            if (file == null)
            { 
                // Geef een foutmelding en eindig deze methode
                fileStatus.Text = "(geen geldig bestand gekozen)";
                return;
            }

            fileStatus.Text = file.Path;

            using (var fileAccess = await file.OpenReadAsync())
            {
                using (var stream = fileAccess.AsStreamForRead())
                {
                    using (var reader = new StreamReader(stream))
                    {
                        var guests = new List<Guest>();

                        // TODO: Definieer hier een List met bezoekers data
                        guests.Add(new Guest
                        {
                            Age = 19,
                            Hobby = "Gamen"
                        });
                        guests.Add(new Guest
                        {
                            Age = 23,
                            Hobby = "Tenissen"
                        });
                         
                    // Geef de bezoekersdata aan onze ListView
                    guestHobbyList.ItemsSource = guests;
                    /* TODO:
                     *  •	Lees een regel uit het bestand
                     *  •	Maak een Guest object
                     *  •	Pak wat voor de komma staat als de Age van dat object
                     *  •	Pak wat wat achter de komma staat als de Hobby van dat object
                     *  •	Plaats de guest in de allGuests List
                     *  •	Herhaal de bovenstaande stappen voor iedere regel in het bestand
                     */

                    // TODO: Geef de List met bezoekersdata aan onze ListView (guestHobbyList)
                }
                }
            }
        }
    }
}
