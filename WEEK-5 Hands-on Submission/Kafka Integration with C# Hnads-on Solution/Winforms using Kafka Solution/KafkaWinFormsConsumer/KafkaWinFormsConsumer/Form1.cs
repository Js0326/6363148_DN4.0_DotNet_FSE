using Confluent.Kafka;
using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KafkaWinFormsConsumer
{
    public partial class Form1 : Form
    {
        private CancellationTokenSource cts;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnStartListening_Click(object sender, EventArgs e)
        {
            cts = new CancellationTokenSource();
            Task.Run(() => ListenForMessages(cts.Token));
        }

        private void ListenForMessages(CancellationToken token)
        {
            var config = new ConsumerConfig
            {
                BootstrapServers = "localhost:9092",
                GroupId = "winforms-group",
                AutoOffsetReset = AutoOffsetReset.Earliest
            };

            using var consumer = new ConsumerBuilder<Ignore, string>(config).Build();
            consumer.Subscribe("chat-topic");

            try
            {
                while (!token.IsCancellationRequested)
                {
                    var result = consumer.Consume(token);
                    Invoke(new Action(() => lstMessages.Items.Add("Received: " + result.Message.Value)));
                }
            }
            catch (OperationCanceledException)
            {
                consumer.Close();
            }
        }
    }
}
