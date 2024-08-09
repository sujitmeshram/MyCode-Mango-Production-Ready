using Mango.Web.Models;

namespace Mango.Web.Service.IService
{
    //for sending the requests to APIs
    public interface IBaseService
    {
         Task<ResponseDto?>  SendAsync(RequestDto requestDto);   
    }
}
