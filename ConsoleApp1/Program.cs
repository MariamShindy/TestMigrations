using ConsoleApp1.Services;

namespace ConsoleApp1
{
    internal class Program
	{
		static void Main(string[] args)
		{
			var connectionString = "Host=localhost;Port=5432;Database=TestDb;Username=postgres;Password=mariam";
			var serviceProvider = MigrationService.CreateServices(connectionString);
			MigrationService.UpdateDatabase(serviceProvider);
		}
	}
}
