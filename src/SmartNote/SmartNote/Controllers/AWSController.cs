/*
						 AWSController.cs
						   Zhi Qiu
						 06/12/2017
 All controller codes for AWS services
*/
using System;
using System.Collections.Generic;
using System.Text;
using Amazon;
using Amazon.CognitoIdentity;
using Amazon.RDS;
using Amazon.RDS.Model;
using Amazon.DynamoDBv2;

namespace SmartNote.Controllers
{
    class AWSController
    {
        private static readonly string AWSRegion = "us-east-1";
        private static readonly string IdentityPoolId = "us-east-1:16c3fb18-dfda-4407-b8f6-ef7233f70f60";
        private static readonly RegionEndpoint Region = RegionEndpoint.USEast1;
        private static readonly CognitoAWSCredentials credentials = new CognitoAWSCredentials(IdentityPoolId, Region);

        static AWSController()
        {
            var loggingConfig = AWSConfigs.LoggingConfig;
            loggingConfig.LogMetrics = true;
            loggingConfig.LogResponses = ResponseLoggingOption.Always;
            loggingConfig.LogMetricsFormat = LogMetricsFormatOption.JSON;
            loggingConfig.LogTo = LoggingOptions.SystemDiagnostics;
            AWSConfigs.AWSRegion = AWSRegion;
            AWSConfigs.CorrectForClockSkew = true;
        }
    }
}
