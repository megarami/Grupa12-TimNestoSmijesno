﻿using System;
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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace LanacHotela
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class BlankPage1 : Page
    {
        public BlankPage1()
        {
            this.InitializeComponent();
        }

        private void korisnickoime_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void sifrabox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void dugmeNazad_Click(object sender, RoutedEventArgs e)
        {
            Page novi = new MainPage();
            this.Content = novi;
        }

        private void kreirajracun_Click(object sender, RoutedEventArgs e)
        {

        }

        private void dugmeDalje_Click(object sender, RoutedEventArgs e)
        {
            if (korisnikbox.Text == "mmahmutovic1" && sifrabox.Password == "nedimjelijep")
            {
                Page novi = new AdminForma();
                this.Content = novi;
            }
            else
            {
                GreskaDialog("Pogresna kombinacija korisnickog imena i sifre!");
            }
           
        }
        private async void GreskaDialog(string s)
        {
            ContentDialog greskaDialog = new ContentDialog()
            {
                Title = "Greska",
                Content = s,
                CloseButtonText = "Ok"
            };

            await greskaDialog.ShowAsync();
        }

    }
}
