using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class PttManager : ISupplierService
    {
        //depencies injection yazılım modeli
        private IApplicantService _applicantService;

        public PttManager(IApplicantService applicantService) //constractor(oluşturucu) new yapıldığında çalışır.
        {
            //classlarda filedların altçizgiyle başlamasının nedeni constroctor dan set etmek içindir.
            _applicantService = applicantService;
        }

        public void GiveMask(Person person)
        {

            //PersonManager personManager = new PersonManager();//eğer bir sınıfı new deyip kullanıyorsan o sınıfa bağımlısın demektir. Ancak bu yanlış bir yöntem bunun yerine interface oluşturarak yapmak öenmlidir.


            if (_applicantService.CheckPerson(person))
            {
                Console.WriteLine(person.FisrtName + " için maske verildi");
            }
            else
            {
                Console.WriteLine(person.FisrtName + " için maske VERİLEMEDİ");
            }
        }

    }
}
