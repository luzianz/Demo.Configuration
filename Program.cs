using System;
using System.IO;
using Microsoft.Extensions.Configuration;

namespace Demo.Configuration {

	class Program {

		static void Main(string[] args) {
			var builder = new ConfigurationBuilder();
			builder.SetBasePath(Directory.GetCurrentDirectory());
			builder.AddJsonFile("appsettings.json");

			var configuration = builder.Build();
			Console.WriteLine(configuration["A:B:C"]);
		}
	}
}