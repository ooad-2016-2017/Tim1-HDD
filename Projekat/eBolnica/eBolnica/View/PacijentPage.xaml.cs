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
using System.Collections.ObjectModel;

// The User Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234236



namespace eBolnica
{
    
    public sealed partial class MyUserControl1 : UserControl
    {
        public MyUserControl1()
        {
            this.InitializeComponent();
            MyFrame.Navigate(typeof(PageMain1));


        }
           private void Button1_Click(object sender, RoutedEventArgs e)
        {
            MyFrame.Navigate(typeof(PageMain1));
        }
        private void Profile_Clicked(object sender, RoutedEventArgs e)
        {
            MyFrame.Navigate(typeof(PacijentDashboard));
        }
        private void Appointments_Pacijent_Clicked(object sender, RoutedEventArgs e)
        {
            MyFrame.Navigate(typeof(PageDoktorAppointments));
        }
        private void Perscriptions_Pacijent_Clicked(object sender, RoutedEventArgs e)
        {
            MyFrame.Navigate(typeof(PacijentPerscriptions));
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
