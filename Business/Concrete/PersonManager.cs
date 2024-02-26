using Business.Abstract;
using Entities.Concrete;
using KpsServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete;

public class PersonManager : IApplicantService
{
    public void ApplyForMask(Person person)
    {

    }

    public List<Person> GetList()
    {
        return null;
    }

    public  bool CheckPerson(Person person)
    {
        KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
        var response= client.TCKimlikNoDogrulaAsync(person.NationalIdentity, person.FirstName.ToUpper(), person.LastName.ToUpper(), person.DateOfBirtYear);
        return response.Result.Body.TCKimlikNoDogrulaResult;
    }

}
