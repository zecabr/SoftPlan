using RateSolution.Domain.Entity;
using System.Threading.Tasks;

namespace RateSolution.Domain.Interface.AppService
{
	public interface IRateAppService
	{
		Task<double> InterestRate();
	}
}