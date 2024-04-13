using System;
using System.Collections.Generic;
using System.Linq;
using Moq;
using NUnit.Framework;
using SchoolFoodStamps.Data.Common;
using SchoolFoodStamps.Data.Models;
using SchoolFoodStamps.Services.Data;
using SchoolFoodStamps.Services.Data.Interfaces;

namespace SchoolFoodStamps.Services.Tests
{
    [TestFixture]
    public class CateringCompanyServiceTests
    {
        [OneTimeSetUp]
        public void Setup()
        {
            // Additional setup code if needed
        }

        [Test]
        public void Test1()
        {
            IQueryable<CateringCompany> companies = new List<CateringCompany>
            {
                new CateringCompany
                {
                    Id = Guid.Parse("EFD31B6C-2A3C-4989-824F-2387C9951234"),
                    Name = "ET SAM-DPD",
                    Address = null,
                    IdentificationNumber = "121756888",
                    UserId = Guid.Parse("FEC4E958-BF56-4247-A6C8-51FAE40D852D")
                },
                new CateringCompany
                {
                    Id = Guid.Parse("8E91E660-535C-4F3A-B2FB-CC4E28682345"),
                    Name = "HealtyFoodForChildren",
                    Address = null,
                    IdentificationNumber = "121756889",
                    UserId = Guid.Parse("97C32DF3-7A02-49A9-871B-0B27C4C37CB5")
                }
            }.AsQueryable();

            var mockRepository = new Mock<IRepository>();
            mockRepository.Setup(x => x.AllReadOnly<CateringCompany>()).Returns(companies);

            ICateringCompanyService cateringCompanyService = new CateringCompanyService(null, mockRepository.Object);

            var result = cateringCompanyService.GetAllCateringCompaniesAsync().Result;

            Assert.That(result.Count(), Is.EqualTo(2));
        }
    }
}