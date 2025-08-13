namespace SignalR
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddSignalR();
            var app = builder.Build();

            app.MapHub<ChatHub>("/chathub");

            app.Run();
        }
    }
}
