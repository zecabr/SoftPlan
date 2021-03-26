using Microsoft.AspNetCore.Mvc;
using RateSolution.Domain.Entity;
using RateSolution.Domain.Interface.AppService;
using System.Threading.Tasks;

namespace RateSolution.API.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	public class InterestRateController : ControllerBase
	{
		private readonly IRateAppService _rateAppService;

		public InterestRateController(IRateAppService rateAppService)
		{
			_rateAppService = rateAppService;
		}

		[HttpGet("GetRate")]
		public async Task<double> Get()
		{
			return await _rateAppService.InterestRate();
		}
	}
}