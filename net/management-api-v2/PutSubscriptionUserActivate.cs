// DocSection: cm_api_v2_put_subscription_user_activate
// Tip: Find more about .NET SDKs at https://kontent.ai/learn/net
using Kentico.Kontent.Management;

var client = new ManagementClient(new ManagementOptions
{
    ApiKey = "<YOUR_API_KEY>",
    ProjectId = "<YOUR_PROJECT_ID>"
});

var identifier = UserIdentifier.ByEmail("user@kentico.com");
//var identifier = UserIdentifier.ById("d94bc87a-c066-48a1-a910-4f991ccc1fb5");

await client.ActivateSubscriptionUserAsync(identifier);
// EndDocSection