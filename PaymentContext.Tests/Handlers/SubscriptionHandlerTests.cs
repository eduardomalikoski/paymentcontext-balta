using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContext.Domain.Commands;
using PaymentContext.Domain.Enums;
using PaymentContext.Domain.Handlers;
using PaymentContext.Tests.Mocks;

namespace PaymentContext.Tests.Handlers
{
    [TestClass]
    public class SubscriptionHandlerTests
    {
        [TestMethod]
        public void ShouldReturnErrorWhenDocumentExists()
        {
            var handler = new SubscriptionHandler(new FakeStudentRepository(), new FakeEmailService());
            var command = new CreateBoletoSubscriptionCommand();

            command.FirstName = "Bruce";
            command.LastName = "Wayne";
            command.Document = "99999999999";
            command.Email = "eduardo@gft.com";
            command.BarCode = "21312312321";
            command.BoletoNumber = "1231232131";
            command.PaymentNumber = "123123";
            command.PaidDate = DateTime.Now;
            command.ExpireDate = DateTime.Now.AddMonths(1);
            command.Total = 60;
            command.TotalPaid = 60;
            command.Payer = "Wayne Corp";
            command.PayerDocument = "12312321321";
            command.PayerDocumentType = EDocumentType.CPF;
            command.PayerEmail = "edu@gft.com";
            command.Street = "asds";
            command.Number = "qwrwq";
            command.Neighborhood = "asdasdas";
            command.City = "qwrqwr";
            command.State = "asddqw";
            command.Country = "asdadas";
            command.ZipCode = "98465121";

            handler.Handle(command);
            Assert.AreEqual(false, handler.Valid);
        }
    }
}