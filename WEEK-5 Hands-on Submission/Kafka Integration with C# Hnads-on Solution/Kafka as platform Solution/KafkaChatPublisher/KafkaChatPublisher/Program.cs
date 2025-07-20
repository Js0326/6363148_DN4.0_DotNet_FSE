using Confluent.Kafka;

class Program
{
    static async Task Main()
    {
        var config = new ProducerConfig
        {
            BootstrapServers = "localhost:9092"
        };

        using var producer = new ProducerBuilder<Null, string>(config).Build();

        Console.WriteLine("Chat Publisher started. Type your message and press Enter. Type 'exit' to quit.");
        while (true)
        {
            var input = Console.ReadLine();
            if (input?.ToLower() == "exit") break;

            var message = new Message<Null, string> { Value = input };
            await producer.ProduceAsync("chat-topic", message);
            Console.WriteLine("Sent: " + input);
        }
    }
}
