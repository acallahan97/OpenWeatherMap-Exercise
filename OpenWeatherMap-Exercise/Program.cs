using Newtonsoft.Json.Linq;
using System;
using System.Net.Http;

namespace OpenWeatherMap_Exercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            // TODO: Create an instance of the HttpClient Class called client
            var client = new HttpClient();
            // TODO: Ask for the users API Key and store that in a variable called "api_Key"
            Console.WriteLine("Please enter your API key:");
            var api_Key = Console.ReadLine();
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("Please enter the city name:");
                var city_name = Console.ReadLine();
                var weatherURL = $"http://api.openweathermap.org/data/2.5/weather?q={city_name}&units=imperial&appid={api_Key}";

                var response = client.GetStringAsync(weatherURL).Result;
                var formattedResponse = JObject.Parse(response).GetValue("main").ToString();
                Console.WriteLine(formattedResponse);
                Console.WriteLine();
                Console.WriteLine("Would you like to choose another city?");
                var userInput = Console.ReadLine();
                Console.WriteLine();
                if (userInput.ToLower() == "no")
                {
                    break;
                }
            }
            // TODO: Ask the user for their city name and store that in a variable called "city_name"

            // TODO: Create a variable to store the URL (use String Interpolation for the {city_name} and {api_Key}  HINT: Make sure to use the "imperial" measurement endpoint

            // TODO: Create a variable to store the response from your GET request to that URL from above  HINT: Don't forget to call .Result 

            // TODO: Create a variable to store the formattedResponse after you JObject.Parse() the response from above

            // TODO: Write out the current temperature in degrees Fahrenheit
        }
    }
}
