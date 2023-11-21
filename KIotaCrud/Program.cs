using KiotaCrud.Client.Models;
using System;
using System.Threading.Tasks;
using KiotaCrud.Client.Models;
using KiotaCrud.Client;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;
using System.Net.Cache;

class Program
{
    static async Task Main(string[] args)
    {
        var authProvider = new AnonymousAuthenticationProvider();
        // Create request adapter using the HttpClient-based implementation
        var adapter = new HttpClientRequestAdapter(authProvider);
        var client = new CrudClient(adapter); // Replace with the actual generated client class

        // Example: Get contacts
        var contacts = await client.Contact.GetAsync();
        foreach (var contact in contacts)
        {
            Console.WriteLine($"Contact ID: {contact.Id}, Name: {contact.FirstName} {contact.LastName}, Age: {contact.Age}");
        }
     



        // 
    }
}
