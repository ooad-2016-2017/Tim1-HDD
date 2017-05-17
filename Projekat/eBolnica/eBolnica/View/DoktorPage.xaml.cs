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

// The User Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234236

namespace eBolnica
{
    public sealed partial class DoktorPage : UserControl
    {
        public DoktorPage()
        {
            this.InitializeComponent();
            MyFrame2.Navigate(typeof(PageMain1));
        }
        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            MyFrame2.Navigate(typeof(PageMain1));
        }
        private void Profile_Clicked(object sender, RoutedEventArgs e)
        {
            MyFrame2.Navigate(typeof(PacijentDashboard));
        }
        private void Timetable_Clicked(object sender, RoutedEventArgs e)
        {
            MyFrame2.Navigate(typeof(PageDoktorTimetable2));
        }
        private void Doktor_Appointments_Clicked(object sender, RoutedEventArgs e)
        {
            MyFrame2.Navigate(typeof(PageDoktorAppointments));
        }
        private void Doktor_Patients_Clicked(object sender, RoutedEventArgs e)
        {
            MyFrame2.Navigate(typeof(PageDoktorPacijenti));
        }
        private void Button_Click_Pane(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            this.SplitView.IsPaneOpen = !this.SplitView.IsPaneOpen; //pane open or close
        }
        private void HamburgerButton_Click(object sender, RoutedEventArgs e)
        {
            if (!this.SplitView.IsPaneOpen)
            {
                this.SplitView.IsPaneOpen = true;
            }
            else
            {
                this.SplitView.IsPaneOpen = false;
            }
        }





      /*  private async void Page_Loaded(object sender, RoutedEventArgs e)
        {
            MyProgressRing.IsActive = true;
            MyProgressRing.Visibility = Visibility.Visible;
            /*
            while (MarvelCharacters.Count < 10)
            {
                Task t = MarvelFacade.PopulateMarvelCharactersAsync(MarvelCharacters);
                await t;
            }
            */
          /*  MyProgressRing.IsActive = false;
            MyProgressRing.Visibility = Visibility.Collapsed;
        }*/

     /*   private async void MasterListView_ItemClick(object sender, ItemClickEventArgs e)
        {
            MyProgressRing.IsActive = true;
            MyProgressRing.Visibility = Visibility.Visible;
        }*/
            /*
            ComicDetailNameTextBlock.Text = "";
            ComicDetailDescriptionTextBlock.Text = "";
            ComicDetailImage.Source = null;

            var selectedCharacter = (Character)e.ClickedItem;

            DetailNameTextBlock.Text = selectedCharacter.name;
            DetailDescriptionTextBlock.Text = selectedCharacter.description;

            var largeImage = new BitmapImage();
            Uri uri = new Uri(selectedCharacter.thumbnail.large, UriKind.Absolute);
            largeImage.UriSource = uri;
            DetailImage.Source = largeImage;

            MarvelComics.Clear();
            */

            /*
            while (MarvelComics.Count < 10)
            {
                Task t = MarvelFacade.PopulateMarvelComicsAsync(
                        selectedCharacter.id,
                        MarvelComics);
                await t;
            }
            */

           /* await MarvelFacade.PopulateMarvelComicsAsync(
                        selectedCharacter.id,
                        MarvelComics);

            MyProgressRing.IsActive = false;
            MyProgressRing.Visibility = Visibility.Collapsed;

        }*/

        private void ComicsGridView_ItemClick(object sender, ItemClickEventArgs e)
        {
            /*var selectedComic = (ComicBook)e.ClickedItem;

            ComicDetailNameTextBlock.Text = selectedComic.title;

            if (selectedComic.description != null)
                ComicDetailDescriptionTextBlock.Text = selectedComic.description;

            var largeImage = new BitmapImage();
            Uri uri = new Uri(selectedComic.thumbnail.large, UriKind.Absolute);
            largeImage.UriSource = uri;
            ComicDetailImage.Source = largeImage;*/

        }
    }
}
