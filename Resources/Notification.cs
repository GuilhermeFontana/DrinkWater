using Microsoft.Toolkit.Uwp.Notifications;

namespace DrinkWater {
    internal static class Notification {
        public static void SendNotification(string title, string mesage) {
            new ToastContentBuilder()
                .AddText(title)
                .AddText(mesage)
                .Show();
        }
    }
}
