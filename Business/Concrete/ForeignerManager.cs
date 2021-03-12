using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ForeignerManager : IApplicantService
    {
        // sonarqube yazılım kalitesini ölçen site
        // interface belli metdo imzalarını barındırır. birbirlerinin alternatifi olan sistemlerin farklı implemetasyon yapmaları sağlar. 
        public void ApplyForMask(Person person)
        {
            throw new NotImplementedException();
        }

        public bool CheckPerson(Person person)
        {
            throw new NotImplementedException();
        }

        public List<Person> GetList()
        {
            throw new NotImplementedException();
        }
    }

}
