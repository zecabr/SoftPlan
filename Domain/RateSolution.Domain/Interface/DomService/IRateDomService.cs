using RateSolution.Domain.Entity;
using System.Threading.Tasks;

namespace RateSolution.Domain.Interface.DomService
{
	public interface IRateDomService
	{
		Task<double> InterestRate();
	}
}