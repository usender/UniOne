[![NuGet](https://img.shields.io/nuget/v/Sender.UniOne.ApiClient)](https://www.nuget.org/packages/Sender.UniOne.ApiClient)
[![License](https://img.shields.io/github/license/usender/unione)](https://img.shields.io/github/license/usender/unione)

UniOne is an open source framework for automated transactional email system. Unione allows you to work with API from any .NET application

## UniOne <img src="https://docs.unione.io/assets/slate/img/logo-unione.svg" width="128"/>
## Official page
https://docs.unione.io

## Documentation
[Official UniOne Documentation](https://docs.unione.io/en/web-api-ref?http#web-api)

## How to get UniOne
- Download a release: https://github.com/usender/unione/releases

- Download the latest source code from GitHub project

- Download via NuGet:
> Install-Package Sender.UniOne.ApiClient
> 
or by visiting: https://www.nuget.org/packages/Sender.UniOne.ApiClient/

# How to use
## Send email in the basic version

```
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Sender.UniOne.ApiClient;
using Sender.UniOne.ApiClient.Common;
using Sender.UniOne.ApiClient.Email;

namespace Sender.UniOne.Test
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var settings = new UniOneSettings
            {
                ApiKey = "Your API key here",
                Endpoint = "Chose by region", // https://eu1.unione.io or https://us1.unione.io
                IsNeedValidatingRequestBeforeSending = false
            };

            var uniOneClient = new UniOneClient(settings);

            var emailMessage = new EmailMessage
            {
                Subject = "uni one client",
                FromName = "user company",
                FromEmail = "your from email",
                Recipients = new List<Recipient> { new Recipient("remote@email.com") },
                Body = new MessageBody("Example message for ...")
            };

            var response = await uniOneClient.EmailSendAsync(emailMessage);

            Console.WriteLine(response.IsSuccess ? response.JobId : response.Failure.Message);

            Console.ReadKey();
        }
    }
}
```
