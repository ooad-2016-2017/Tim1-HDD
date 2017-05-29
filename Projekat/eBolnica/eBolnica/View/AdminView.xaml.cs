﻿using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace eBolnica.View {
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class AdminView : Page
    {
        public AdminView()
        {
            this.InitializeComponent();
            AdminFrame.Navigate(typeof(Registracija));

        }



        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            // AdminFrame.Navigate(typeof(PageMain1));
        }
        private void Login_Clicked(object sender, RoutedEventArgs e)
        {
            //  AdminFrame.Navigate(typeof(PageMainLogin1));
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

    }
}
