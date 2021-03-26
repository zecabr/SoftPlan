using Moq;
using NUnit.Framework;
using RateSolution.API.Controllers;
using RateSolution.Domain.Interface.AppService;
using RateSolution.Domain.Service;
using System.Threading.Tasks;

namespace RateSolution.UnitTest
{
	public class Tests
	{

		[SetUp]
		public void Setup()
		{

		}

		[Test]
		public void TestRate()
		{
			var domService = new RateDomService();
			var result = Task.FromResult(domService.InterestRate()).Result.Result;
			Assert.True(result == 0.01);
		}
	}
}