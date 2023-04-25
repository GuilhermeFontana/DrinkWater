namespace DrinkWater.Resources {

    internal class Messages {

        private List<string[]> messagesList = new List<string[]>();

        public Messages() {
            this.LoadMessages();
        }

        private void LoadMessages() {
            this.messagesList.Clear();

            string[] message = new string[2] { "Beba água", "Esta na hora de você tomar um pouco de água" };
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
            message = new string[2] { "Hidrate-se", "Lembre-se de beber água regularmente ao longo do dia para manter seu corpo saudável e hidratado." };
            this.messagesList.Add(message);
            message = new string[2] { "Já bebeu água hoje?", "Um lembrete para beber um copo de água agora." };
            this.messagesList.Add(message);
            message = new string[2] { "Hora de hidratar!", "Beba um copo de água agora e sinta a diferença." };
            this.messagesList.Add(message);
            message = new string[2] { "Surprise motherfucker", "Não deixe a sede te pegar de surpresa. Beba água agora para manter seu corpo hidratado." };
            this.messagesList.Add(message);
            message = new string[2] { "⌚", "Lembre-se de beber água em intervalos regulares ao longo do dia para manter seu corpo hidratado e energizado." };
            this.messagesList.Add(message);
        }

        public string[] GetMessage() {
            return this.messagesList[new Random().Next(0, this.messagesList.Count)];
        }
    }
}
