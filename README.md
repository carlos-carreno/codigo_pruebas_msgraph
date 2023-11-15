# Microsoft Graph API Example

This is a sample C# program that demonstrates how to authenticate and use the Microsoft Graph API to retrieve device compliance policy states for devices. 

## Prerequisites

Before running this code, you need to have the following:

- An Azure application registered with the required permissions to access Microsoft Graph.
- .NET Core SDK installed.
- Azure SDK for .NET installed.
- Visual Studio or another C# development environment.

## Setup

1. Clone or download this repository to your local machine.
2. Open the project in your C# development environment.
3. Replace the following placeholders in the code with your own values:
    - `clientId`: Your Azure AD application's client ID.
    - `tenantId`: Your Azure AD tenant ID.
    - `clientSecret`: Your Azure AD application's client secret.
4. Build and run the application.

## How the Code Works

- The code uses the Azure Identity library to authenticate with Azure AD.
- It uses the Microsoft.Graph library to interact with the Microsoft Graph API.
- It retrieves a list of devices and their compliance policy states.
- For each device, it creates a JSON object with the device ID and policy name and prints it to the console.

## Error Handling

The code includes error handling to capture and display any exceptions that occur during the process.

## License

This project is licensed under the MIT License - see the [LICENSE.md](LICENSE.md) file for details.

## Acknowledgments

- [Azure Identity library](https://github.com/Azure/azure-sdk-for-net/tree/main/sdk/identity/Azure.Identity)
- [Microsoft Graph SDK for .NET](https://github.com/microsoftgraph/msgraph-sdk-dotnet)

## Author

[Your Name]

## Contact

For any questions or feedback, feel free to contact me at [Your Email Address].
