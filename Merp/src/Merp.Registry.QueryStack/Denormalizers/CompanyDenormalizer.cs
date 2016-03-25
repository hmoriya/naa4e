﻿using Memento;
using Merp.Registry.CommandStack.Events;
using Merp.Registry.QueryStack.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Memento.Messaging.Postie;

namespace Merp.Registry.QueryStack.Denormalizers
{
    public class CompanyDenormalizer : IHandleMessages<CompanyRegisteredEvent>
    {
        public void Handle(CompanyRegisteredEvent message)
        {
            var p = new Company()
            {
                CompanyName = message.CompanyName,
                VatIndex = message.VatIndex,
                OriginalId = message.CompanyId,
                DisplayName = message.CompanyName
            };
            using(var context = new RegistryDbContext())
            {
                context.Parties.Add(p);
                context.SaveChanges();
            }
        }
    }
}
