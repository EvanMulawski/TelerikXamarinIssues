using System;
using System.Collections.Generic;
using Telerik.XamarinForms.Input;

namespace XFIssues.CalendarAllDayEventsBadLayoutOnRotate.ViewModels
{
    public sealed class CalendarViewModel
    {
        public CalendarViewModel()
        {
            var now = DateTime.Now;

            Appointments = new List<Appointment>
            {
                new Appointment
                {
                    Title = "Event 1",
                    IsAllDay = true,
                    StartDate = now.Date,
                    EndDate = now.Date.AddDays(1).AddMilliseconds(-1)
                }
            };
        }

        public List<Appointment> Appointments { get; }
    }
}