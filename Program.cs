using System.Configuration;

namespace DrinkWater {
    internal class Program {
        static void Main(string[] args) {
            #pragma warning disable CS8604 // Possible null reference argument.
                double interval = double.Parse(ConfigurationManager.AppSettings.Get("Interval"));
                int limit = int.Parse(ConfigurationManager.AppSettings.Get("Limit"));
            #pragma warning restore CS8604 // Possible null reference argument.

            int i = 0;
            while (i < limit) {
                Notification.SendNotification("Beba água", "Esta na hora de você tomar um pouco de água");
                Thread.Sleep(TimeSpan.FromMinutes(interval));
                i++;
            }
        }
    }
}