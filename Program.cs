using DrinkWater.Resources;
using System.Configuration;

namespace DrinkWater {
    internal class Program {
        static void Main(string[] args) {
            #pragma warning disable CS8604 // Possible null reference argument.
                double interval = double.Parse(ConfigurationManager.AppSettings.Get("Interval"));
                int limit = int.Parse(ConfigurationManager.AppSettings.Get("Limit"));
            #pragma warning restore CS8604 // Possible null reference argument.

            int i = 0;
            while (i < limit || limit == 0) {
                string[] message = new Messages().GetMessage();

                Notification.SendNotification(message[0], message[1]);
                Thread.Sleep(TimeSpan.FromMinutes(interval));
                i++;
            }
        }
    }
}