// DocSection: cm_api_v2_get_subscription_projects
// Tip: Find more about .NET SDKs at https://kontent.ai/learn/net
using Kentico.Kontent.Management;

var client = new ManagementClient(new ManagementOptions
{
    ApiKey = "<YOUR_API_KEY>",
    ProjectId = "<YOUR_PROJECT_ID>"
});

var client = _fileSystemFixture.CreateMockClientWithResponse("SubscriptionUsers.json");

var response = await client.ListSubscriptionUsersAsync();
// EndDocSection
