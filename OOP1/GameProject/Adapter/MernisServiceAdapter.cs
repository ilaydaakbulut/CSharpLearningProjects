using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using MernisServiceReference;

namespace GameProject.Adapter
{
    class MernisServiceAdapter : IMemberCheckService
    {
        public bool CheckIfRealPerson(Member member)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap12);
            return client.TCKimlikNoDogrulaAsync(Convert.ToInt64(member.NationalityId), member.FirstName.ToUpper(), member.LastName.ToUpper(), member.DateOfBirth.Year).Result.Body.TCKimlikNoDogrulaResult;
        }
    }
}
