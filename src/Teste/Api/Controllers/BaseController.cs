using Microsoft.AspNetCore.Mvc;
using Domain.Interface.Notification;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseController : ControllerBase
    {
        private readonly INotification _iNotification;


        public BaseController(INotification iNotification)
        {
            _iNotification = iNotification;
        }

        public bool isValided()
        {
            return _iNotification.HaveNotifier();
        }
    }
}
