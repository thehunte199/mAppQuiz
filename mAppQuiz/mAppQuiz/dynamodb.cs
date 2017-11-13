using Amazon;
using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.DataModel;
using Amazon.CognitoIdentity;

namespace mAppQuiz
{
    //cognito pool id: us-east-1_jU9es72YF
    class dynamodb
    {
        public dynamodb()
        {
            var loggingConfig = AWSConfigs.LoggingConfig;
            loggingConfig.LogMetrics = true;
            loggingConfig.LogResponses = ResponseLoggingOption.Always;
            loggingConfig.LogMetricsFormat = LogMetricsFormatOption.JSON;
            loggingConfig.LogTo = LoggingOptions.SystemDiagnostics;
            AWSConfigs.AWSRegion = "us-east-1";
            AWSConfigs.CorrectForClockSkew = true;
            var offset = AWSConfigs.ClockOffset;
            

        }

        static void Main(string[] args)
        {
           CognitoAWSCredentials credentials = new CognitoAWSCredentials(
                "us-east-1_jU9es72YF", // Your identity pool ID
                RegionEndpoint.USEast1 // Region
            );
            var client = new AmazonDynamoDBClient(credentials, RegionEndpoint.USEast1);
            DynamoDBContext context = new DynamoDBContext(client);

            UsersTable user = new UsersTable();
            user.username = "elijah";
            user.password = "hursey";

            var result = context.SaveAsync(user);

        }
    }
}
