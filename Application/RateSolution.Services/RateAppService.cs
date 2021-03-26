using RateSolution.Domain.Entity;
using RateSolution.Domain.Interface.AppService;
using RateSolution.Domain.Interface.DomService;
using System.Threading.Tasks;

namespace RateSolution.Services
{
	public class RateAppService : IRateAppService
	{
		private readonly IRateDomService _domService;

		public RateAppService(IRateDomService domService)
		{
			_domService = domService;
		}
		public async Task<double> InterestRate()
		{
			var x = await _domService.InterestRate();
			return x;
		}
	}
}