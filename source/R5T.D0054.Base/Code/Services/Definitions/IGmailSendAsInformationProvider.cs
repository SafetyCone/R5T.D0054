using System;
using System.Threading.Tasks;

using R5T.T0014;


namespace R5T.D0054
{
    public interface IGmailSendAsInformationProvider
    {
        Task<ISendAsInformation> GetGmailSendAsInformation();
    }
}
