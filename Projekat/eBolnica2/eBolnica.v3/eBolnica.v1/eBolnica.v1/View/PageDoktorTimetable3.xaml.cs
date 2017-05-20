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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace eBolnica.v1
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class PageDoktorTimetable3 : Page
    {
        public PageDoktorTimetable3()
        {
            this.InitializeComponent();
            TimetablePivot1.Navigate(typeof(PageDoktorTimetable2));
            TimetablePivot2.Navigate(typeof(PageDoktorTimetable2));
            TimetablePivot3.Navigate(typeof(PageDoktorTimetable2));
            TimetablePivot4.Navigate(typeof(PageDoktorTimetable2));
            TimetablePivot5.Navigate(typeof(PageDoktorTimetable2));
        }
    }
}

