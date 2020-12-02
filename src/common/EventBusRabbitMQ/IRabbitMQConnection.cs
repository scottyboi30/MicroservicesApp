using RabbitMQ.Client;

namespace EventBusRabbitMQ
{
    public interface IRabbitMQConnection
    {
        bool IsConnected { get; }
        bool TryConnect();
        IModel CreateModel();
        void Dispose();
    }
}