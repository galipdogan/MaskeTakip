using Business.Abstract;
using Entities.Concrete;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
     //çıplak class kalmasın
    public class PersonManager : IApplicantService
    {

        public void ApplyForMask(Person person)
        {

        }

        public List<Person> GetList()

        {
            return null;
        }

        public bool CheckPerson(Person person)
        {
            //mernis kontrol alanı
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);

            return client.TCKimlikNoDogrulaAsync
                (new TCKimlikNoDogrulaRequest(new TCKimlikNoDogrulaRequestBody(person.NationalIdentity,person.FisrtName,person.LastName,person.DateOfBirthYear))).Result.Body.TCKimlikNoDogrulaResult;
        }
    }
}
