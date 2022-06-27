using Grpc.Net.Client;
using GrpcGreeterClient;

// using var channel = GrpcChannel.ForAddress("https://localhost:7082");
using var channel = GrpcChannel.ForAddress("https://localhost:8585");
// using var channel = GrpcChannel.ForAddress($"https://grpcprocesstuneeastus2.azurewebsites.net");

var client = new Greeter.GreeterClient(channel);

// Metadata headers = new()
// {
//     { "Alt-Svc", "h3=\":8585\"" }
// };

// var reply = await client.SayHelloAsync(new HelloRequest { Name = "GreeterClient" });

var reply = await client.SayHelloAsync(new HelloRequest { Name = "GreeterClient" },headers);

Console.WriteLine("Greeting: " + reply.Message);
Console.WriteLine("Press any key to exit...");
Console.ReadKey();

