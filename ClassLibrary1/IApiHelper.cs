using System.Net.Http;

namespace Capgemini.Helper
{
    public interface IApiHelper
    {
        HttpClient Initial();
    }
}