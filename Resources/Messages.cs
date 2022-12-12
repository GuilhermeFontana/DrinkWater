namespace DrinkWater.Resources {

    internal class Messages {

        private List<string[]> messagesList = new List<string[]>();

        public Messages() {
            this.LoadMessages();
        }
        
        private void LoadMessages() {
            this.messagesList.Clear();

            string[] message = new string[2] { "Beba Água", "Esta na hora de você tomar um pouco de água" };
            this.messagesList.Add(message);
            message = new string[2] { "100% Hidratado", "Beba um pouco de água para manter-se 100% hidratado" };
            this.messagesList.Add(message);
            message = new string[2] { "Aja de acordo", "Seu corpo é 70% água, então aja de acordo e tome um pouco de água" };
            this.messagesList.Add(message);
            message = new string[2] { "🌵 Cacto", "Você não é um cacto, beba água" };
            this.messagesList.Add(message);
            message = new string[2] { "Lembrete diário", "Beba um pouco de água" };
            this.messagesList.Add(message);
            message = new string[2] { "⛰", "Melhor uma pedra no caminho, do que duas nos rins. Tome água" };
            this.messagesList.Add(message);
        }

        public string[] GetMessage() {
            Random random = new Random();

            int messageIndex = random.Next(0, this.messagesList.Count - 1);

            return this.messagesList[messageIndex];
        }
    }
}
