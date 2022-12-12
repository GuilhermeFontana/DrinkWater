using Microsoft.Toolkit.Uwp.Notifications;

namespace DrinkWater {
    internal static class Notification {
        public static void SendNotification(string title, string mesage) {
            new ToastContentBuilder()
                .AddArgument("action", "viewConversation")
                .AddArgument("conversationId", 9813)
                .AddText(title)
                .AddText(mesage)
                .Show();
        }
    }
}
