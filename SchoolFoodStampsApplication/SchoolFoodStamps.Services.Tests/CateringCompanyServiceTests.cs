using Microsoft.AspNetCore.Identity;
using Moq;
using SchoolFoodStamps.Data.Common;
using SchoolFoodStamps.Data.Models;

namespace SchoolFoodStamps.Services.Tests
{
    public class CateringCompanyServiceTests
    {

        [OneTimeSetUp]
        public void Setup()
        {
            
        }

        [Test]
        public void Test1()
        {
            //var companies = new List<CateringCompany>
            //{
            //    new CateringCompany { Id = Guid.NewGuid(), Name = "Company B" },
            //    new CateringCompany { Id = Guid.NewGuid(), Name = "Company A" }
            //}.AsQueryable();

            //var mockRepository = new Mock<IRepository>();
            //mockRepository.Setup(x => x.AllReadOnly<CateringCompany>()).Returns(companies);

            //var cateringCompanyService = new CateringCompanyService(null, mockRepository.Object);
            //Assert.Pass();
        }
    }
}