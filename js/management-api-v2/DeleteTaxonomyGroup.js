// DocSection: cm_api_v2_delete_taxonomy_group
// Tip: Find more about JS/TS SDKs at https://kontent.ai/learn/javascript
// Using ES6 syntax
import { ManagementClient } from '@kentico/kontent-management';

const client = new ManagementClient({
  projectId: '<YOUR_PROJECT_ID>',
  apiKey: '<YOUR_API_KEY>'
});

const response = await client.deleteTaxonomy()
  .byTaxonomyId("dbff8416-c4c7-45d2-b497-a4a71a5cbe30")
  // .byTaxonomyCodename("personas_222")
  // .byTaxonomyExternalId("Tax-Group-124")
  .toPromise();
// EndDocSection