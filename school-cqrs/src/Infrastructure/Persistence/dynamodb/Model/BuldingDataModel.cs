using Amazon.DynamoDBv2.DataModel;

namespace Infrastructure.Persistence.dynamodb.Model
{
    [DynamoDBTable("aec-build")]
    public class BuldingDataModel
    {
        [DynamoDBHashKey("pk")]
        public string Id { get; private set; } = String.Empty;

        [DynamoDBRangeKey("sk")]
        public string Context { get; private set; } = String.Empty;

        [DynamoDBProperty("description")]
        public string Description { get; private set; } = String.Empty;

    }
}