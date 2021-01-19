using System;

namespace Event
{
    class Program
    {
        static void Main(string[] args)
        {
            Nofication nf = new Nofication();
            Calender cd = new Calender();
            nf.notify += cd.Reminder;
            nf.NotifyEvent(DateTime.Now);
        }

        public class Calender
        {
            public void Reminder(object sender, ProcessNotify er)
            {
                Console.WriteLine($"Event at{er.eventDate}");
            }
        }

        public class Nofication
        {
            public event EventHandler<ProcessNotify> notify;

            public void NotifyEvent(DateTime dt)
            {
                if (notify != null)
                    notify(this, new ProcessNotify(dt));
            }
        }

        public class ProcessNotify : EventArgs
        {
            public DateTime eventDate { get; set; }

            public ProcessNotify(DateTime dt)
            {
                eventDate = dt;
            }


        }
    }
}
