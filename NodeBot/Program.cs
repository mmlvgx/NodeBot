using NetCord;
using NetCord.Gateway;

DotNetEnv.Env.TraversePath().Load(); // Load Dotenv
String token = DotNetEnv.Env.GetString("token"); // Get Token String

GatewayClient client = new(new Token(TokenType.Bot, token), new GatewayClientConfiguration()
{
    Intents = GatewayIntents.GuildMessages | GatewayIntents.DirectMessages | GatewayIntents.MessageContent,
});

client.Log += message =>
{
    Console.WriteLine(message);
    return default;
};
await client.StartAsync();
await Task.Delay(-1);
