using DrinkWater.Resources;
using System.Configuration;
using System.Diagnostics;

namespace DrinkWater {
    internal class Program {
        static void Main(string[] args) {
#pragma warning disable CS8604 // Possible null reference argument.
            double interval = double.Parse(ConfigurationManager.AppSettings.Get("Interval"));
            int limit = int.Parse(ConfigurationManager.AppSettings.Get("Limit"));
#pragma warning restore CS8604 // Possible null reference argument.

            int i;

            Process[] process = Process.GetProcessesByName("DrinkWater");
            if (process.Length > 1) {
                for (i = 0; i < process.Length - 1; i++) {
                    process[i].Kill();
                }
            }

            i = 0;
            while (i < limit || limit == 0) {
                string[] message = new Messages().GetMessage();

                Notification.SendNotification(message[0], message[1]);
                Thread.Sleep(TimeSpan.FromMinutes(interval));
                i++;
            }
        }
    }
}