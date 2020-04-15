using System.Threading.Tasks;
using PetrVala.VatPayerReliabilityChecker.ServiceLibrary.Connected_Services.VatPayerReliabilityServiceReference;

namespace PetrVala.VatPayerReliabilityChecker.ServiceLibrary
{
    public class ServiceFullWrapper
    {
        public async Task<getSeznamNespolehlivyPlatceResponse> GetSeznamNespolehlivyPlatce(getSeznamNespolehlivyPlatceRequest request)
        {
            var client = new rozhraniCRPDPHClient();
            return await client.getSeznamNespolehlivyPlatceAsync(request);
        }

        public async Task<getStatusNespolehlivyPlatceResponse> GetStatusNespolehlivyPlatce(getStatusNespolehlivyPlatceRequest request)
        {
            var client = new rozhraniCRPDPHClient();
            return await client.getStatusNespolehlivyPlatceAsync(request);
        }

        public async Task<getStatusNespolehlivyPlatceRozsirenyResponse> GetStatusNespolehlivyPlatceRozsireny(getStatusNespolehlivyPlatceRequest1 request)
        {
            var client = new rozhraniCRPDPHClient();
            return await client.getStatusNespolehlivyPlatceRozsirenyAsync(request);
        }
    }
}