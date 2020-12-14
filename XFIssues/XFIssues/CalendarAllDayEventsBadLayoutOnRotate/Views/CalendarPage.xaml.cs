using System;
using Xamarin.Forms;
using XFIssues.CalendarAllDayEventsBadLayoutOnRotate.ViewModels;

namespace XFIssues.CalendarAllDayEventsBadLayoutOnRotate.Views
{
    public partial class CalendarPage : ContentPage, IXFIssueMarker
    {
        CalendarViewModel _viewModel;

        public CalendarPage()
        {
            InitializeComponent();

            BindingContext = _viewModel = new CalendarViewModel();

            Calendar.DisplayDate = DateTime.Today;
        }
    }
}