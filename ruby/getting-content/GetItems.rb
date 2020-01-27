# DocSection: getting_content_get_items
# Tip: Find more about Ruby SDKs at https://docs.kontent.ai/ruby
require 'delivery-sdk-ruby'

delivery_client = Kentico::Kontent::Delivery::DeliveryClient.new project_id: '8d20758c-d74c-4f59-ae04-ee928c0816b'
delivery_client.items.execute do |response|
  items = response.items
  items.each { |item| puts item.system.codename }
end
# EndDocSection