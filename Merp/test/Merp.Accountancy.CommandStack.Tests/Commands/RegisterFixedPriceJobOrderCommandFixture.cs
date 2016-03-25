﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Merp.Accountancy.CommandStack.Commands;

namespace Merp.Accountancy.CommandStack.Tests.Commands
{
    [TestClass]
    public class RegisterFixedPriceJobOrderCommandFixture
    {
        [TestMethod]
        public void Ctor_should_set_properties_according_to_parameters()
        {
            DateTime dateOfStart = new DateTime(1990, 11, 11);
            DateTime dueDate = new DateTime(1990, 11, 12);
            decimal price = 143;
            string currency = "EUR";
            string jobOrderName = "fake";
            Guid customerId = Guid.NewGuid();
            Guid managerId = Guid.NewGuid();
            string purchaseOrderNumber = "42";
            string description = "xyz";
            var sut = new RegisterFixedPriceJobOrderCommand(
                customerId,
                managerId,
                price,
                currency,
                dateOfStart,
                dueDate,
                jobOrderName,
                purchaseOrderNumber,
                description
                );
            Assert.AreEqual<DateTime>(dateOfStart, sut.DateOfStart);
            Assert.AreEqual<DateTime>(dueDate, sut.DueDate);
            Assert.AreEqual<decimal>(price, sut.Price);
            Assert.AreEqual<string>(currency, sut.Currency);
            Assert.AreEqual<Guid>(customerId, sut.CustomerId);
            Assert.AreEqual<string>(jobOrderName, sut.JobOrderName);
            Assert.AreEqual<Guid>(customerId, sut.CustomerId);
            Assert.AreEqual<Guid>(managerId, sut.ManagerId);
            Assert.AreEqual<string>(purchaseOrderNumber, sut.PurchaseOrderNumber);
            Assert.AreEqual<string>(description, sut.Description);
        }
    }
}
