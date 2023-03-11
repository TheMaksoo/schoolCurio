using System;
using System.Collections.Generic;
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

namespace EntreeBerekenaar
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            border.Opacity = 0;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            border.Opacity = 0;
            int aantalKinderen;
            if (int.TryParse(tbAantalKinderen.Text, out aantalKinderen) == false)
            {
                tbBedrag.Text = "(aantal kinderen is ongeldig)";
                border.Opacity = 100;
                return;
            }


            //	Doe hier ook de andere checks of de invoer juist is
            int aantalVolwassenen;
            if (int.TryParse(tbAantalVolwassenen.Text, out aantalVolwassenen) == false)
            {
                tbBedrag.Text = "(aantal Volwassenen is ongeldig)";
                border.Opacity = 100;
                return;
            }

            int arrangement = cbarrangement.SelectedIndex;
            if (arrangement == -1)
            {
                tbBedrag.Text = "(Selecteer een arragement)";
                border.Opacity = 100;
                return;
            }

            int parkeerkaart = 0;
            if (cbParkeerkaart.IsChecked == true)
            {
                parkeerkaart = 5;
            }

            int aantalKortingsPercentage;
            if (int.TryParse(tbAantalKortingPercentage.Text, out aantalKortingsPercentage) == false)
            {
                tbBedrag.Text = "(Korting Percentage moet een getal zijn.)";
                border.Opacity = 100;
                return;
               
            }
            if (aantalKortingsPercentage > 100 || aantalKortingsPercentage < 0)
            {
                tbBedrag.Text = "(aantal Korting percetage moet tussesen de 0 en 100 liggen.)";
                border.Opacity = 100;
                return;
            }
            if (arrangement == 0)
            {
                double childPrice = aantalKinderen * 7.5;
                double adultPrice = aantalVolwassenen * 12.5;
                double subtotaal = aantalKortingsPercentage * (childPrice + adultPrice + parkeerkaart) / 100;
                double eindBedrag = (childPrice + adultPrice + parkeerkaart) - subtotaal;
                tbBedrag.Text = eindBedrag.ToString();
            }
            else if (arrangement == 1)
            {
                double childPrice = aantalKinderen * 10.5;
                double adultPrice = aantalVolwassenen * 15.5;
                double subtotaal = aantalKortingsPercentage * (childPrice + adultPrice + parkeerkaart) / 100;
                double eindBedrag = (childPrice + adultPrice + parkeerkaart) - subtotaal;
                tbBedrag.Text = eindBedrag.ToString();
            }
            
            
            // Hier komt de berekening van het eindbedrag

            

        }
    }
}
