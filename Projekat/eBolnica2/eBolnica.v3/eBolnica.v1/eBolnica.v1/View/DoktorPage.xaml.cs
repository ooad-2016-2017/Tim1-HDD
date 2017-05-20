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

namespace eBolnica.v1.View
{
    public sealed partial class DoktorPage : UserControl
    {
        public DoktorPage()
        {
            this.InitializeComponent();
            DoktorFrame.Navigate(typeof(PageMain1));
        }
        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            DoktorFrame.Navigate(typeof(PageMain1));
        }
        private void Doktor_Profile_Clicked(object sender, RoutedEventArgs e)
        {
            DoktorFrame.Navigate(typeof(PacijentDashboard));
        }
        private void Doktor_Timetable_Clicked(object sender, RoutedEventArgs e)
        {
            DoktorFrame.Navigate(typeof(PageDoktorTimetable3));
        }
        private void Doktor_Appointments_Clicked(object sender, RoutedEventArgs e)
        {
            DoktorFrame.Navigate(typeof(PageDoktorAppointments));
        }
        private void Doktor_Patients_Clicked(object sender, RoutedEventArgs e)
        {
            DoktorFrame.Navigate(typeof(PageDoktorPacijenti));
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




        private void ComicsGridView_ItemClick(object sender, ItemClickEventArgs e)
        {


        }
    }
}
