using RateSolution.Domain.Entity;
using RateSolution.Domain.Interface.DomService;
using System.Threading.Tasks;

namespace RateSolution.Domain.Service
{
	public class RateDomService : IRateDomService
	{
		public async Task<double> InterestRate()
		{
			return await Task.FromResult(0.01);
		}
	}
}