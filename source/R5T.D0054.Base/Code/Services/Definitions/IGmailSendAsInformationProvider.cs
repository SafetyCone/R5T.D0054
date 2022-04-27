using System;
using System.Threading.Tasks;

using R5T.T0014;
using R5T.T0064;


namespace R5T.D0054
{
    [ServiceDefinitionMarker]
    public interface IGmailSendAsInformationProvider : IServiceDefinition
    {
        Task<ISendAsInformation> GetGmailSendAsInformation();
    }
}
