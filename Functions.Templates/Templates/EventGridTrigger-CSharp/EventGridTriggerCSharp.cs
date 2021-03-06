#if (portalTemplates)
#r "Microsoft.Azure.WebJobs.Extensions.EventGrid"
using Microsoft.Azure.WebJobs.Extensions.EventGrid;

public static void Run(EventGridEvent eventGridEvent, TraceWriter log)
#endif
#if (vsTemplates)
using Microsoft.Azure.WebJobs.Extensions.EventGrid;
namespace Company.Function
{
    public static class EventGridTriggerCSharp
    {
        [FunctionName("EventGridTriggerCSharp")]
        public static void Run([EventGridTrigger]EventGridEvent eventGridEvent, TraceWriter log)
#endif
        {
            log.Info(eventGridEvent.ToString());
        }
#if (vsTemplates)
    }
}
#endif