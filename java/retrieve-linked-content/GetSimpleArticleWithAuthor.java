// DocSection: linked_content_get_article_with_author
// Tip: Find more about Java SDK at https://kontent.ai/learn/java
import kentico.kontent.delivery.*;

// Initializes a DeliveryClient
DeliveryClient client = new DeliveryClient("<YOUR_PROJECT_ID>");

// Create strongly typed models according to https://kontent.ai/learn/strongly-typed-models
// Registers the model class for simple articles
client.registerType(SimpleArticle.class);

CompletionStage<SimpleArticle> item = client.getItem(
	"the_origin_of_coffee",
	SimpleArticle.class,
	DeliveryParameterBuilder.params()
		.linkedItemsDepth(1)
		.build()
);
// To use the code for Android projects, see http://kontent.ai/learn/android
// EndDocSection