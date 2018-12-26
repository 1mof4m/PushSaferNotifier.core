using Microsoft.AspNetCore.Mvc;
using PushSaferNotifier.engine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PushSaferNotifier.web.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class NotificationController : ControllerBase
	{
		// GET api/notification
		[HttpGet]
		public ActionResult<IEnumerable<string>> Get()
		{
			string[] v = PushSaferNotifierEngine.Notify();
			return v;
		}
	}
}
