// DocSection: import_linked_upsert_variant
// Tip: Find more about .NET SDKs at https://kontent.ai/learn/net
using Kentico.Kontent.Management;

var client = new ManagementClient(new ManagementOptions
{
    ApiKey = "<YOUR_API_KEY>",
    ProjectId = "<YOUR_PROJECT_ID>"
});

var identifier = new LanguageVariantIdentifier(Reference.ByExternalId("123"), Reference.ByCodename("en-US"));

var response = await client.UpsertLanguageVariantAsync(identifier, new LanguageVariantUpsertModel
{
    Elements = new dynamic[]
    {
        new TextElement
        {
            Element = Reference.ByCodename("title"),
            Value = "On Roasts"
        }.ToDynamic(),
        new LinkedItemsElement
        {
            Element = Reference.ByCodename("related_articles"),
            Value = new []
            {
                Reference.ByExternalId("456"),
            }
        }.ToDynamic()
    }
});
// EndDocSection