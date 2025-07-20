using Confluent.Kafka;

class Program
{
    static void Main()
    {
        var config = new ConsumerConfig
        {
            BootstrapServers = "localhost:9092",
            GroupId = "chat-consumer-group",
            AutoOffsetReset = AutoOffsetReset.Earliest
        };

        using var consumer = new ConsumerBuilder<Ignore, string>(config).Build();
        consumer.Subscribe("chat-topic");

        Console.WriteLine("Chat Consumer started. Listening for messages...");

        while (true)
        {
            var cr = consumer.Consume();
            Console.WriteLine("Received: " + cr.Message.Value);
        }
    }
}
