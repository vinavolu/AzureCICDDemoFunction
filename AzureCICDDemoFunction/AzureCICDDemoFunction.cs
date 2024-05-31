using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace AzureCICDDemoFunction
{
    public class AzureCICDDemoFunction
    {
        [FunctionName("AzureCICDDemoFunction")]
        public void Run([ServiceBusTrigger("demoqueue", Connection = "AzureWebJobsServiceBus")]string myQueueItem, ILogger log)
        {
            log.LogInformation($"C# ServiceBus queue trigger function processed message: {myQueueItem}");
        }
    }
}
