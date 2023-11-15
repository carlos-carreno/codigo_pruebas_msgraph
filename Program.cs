﻿﻿using System;
using System.Linq;
using System.Threading.Tasks;
using Azure.Identity;
using Microsoft.Graph;
using Newtonsoft.Json;
using Microsoft.Kiota.Http.HttpClientLibrary;
using Microsoft.Kiota.Abstractions;


namespace new_project
{

    public class ResponseData 
    {
        public string deviceId{get; set;}
        public string policyName{get; set;}
        public string displayName{get; set;}

        public ResponseData(string deviceId, string policyName, string displayName) 
        {
            this.deviceId = deviceId;
            this.policyName = policyName;
            this.displayName = displayName;
        }
    }
    class Program
    {
        static async Task Main(string[] args)
        {
            //Toda esta seccion es la autenticacion a la aplicaicon cread en azure
            string[] scopes = {"https://graph.microsoft.com/.default"};
           // Credenciales de la aplicacion
           var clientId = "2e01c288-3ae0-4386-b3fe-543eaad5e8ad";
           var tenantId = "f47dcce4-02e7-4d88-a659-a2d0bbe170e7";
           var clientSecret = "kPI8Q~sqwjtA10jDL1G4WUbp6LbncNo.RgtfGa3X";
           // using Azure.Identity;
           var options = new ClientSecretCredentialOptions
           {
            AuthorityHost = AzureAuthorityHosts.AzurePublicCloud,
            };
            var clientSecretCredential = new ClientSecretCredential(
                tenantId, clientId, clientSecret, options);

            //var responseList = new List<ResponseData>();
                //consulta de microsoft graph
            var graphClient = new GraphServiceClient(clientSecretCredential, scopes);
            try
            {
                var devices = await graphClient.Devices.GetAsync((requestConfiguration) =>
                {
                    requestConfiguration.QueryParameters.Filter = "startswith(operatingSystem,'Win') and profileType eq 'RegisteredDevice' and isManaged eq true and accountEnabled eq true";
                });
                Console.WriteLine(devices.Value.Count);

            }
            catch (Exception  ex)
            {
                Console.WriteLine($"Processing failed:{ex.Message}");
            }
            
            
             
        }
    } 
} 
