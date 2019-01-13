using RAPS.SMS.DLL.DLL.Models;
using System;
using System.Collections.Generic;
using System.Text;
using RAPS.SMS.DLL.DLL.Repositories;

namespace RAPS.SMS.BLL
{
    public interface IPeopleService
    {
        List<People> GetAllPeople();
    }
   public  class PeopleService :IPeopleService
    {
        private readonly IPeopleRepository _peopleRepository;

        public PeopleService(IPeopleRepository peopleRepository)
        {
            _peopleRepository = peopleRepository;
        }

        public List<People> GetAllPeople()
        {
            return _peopleRepository.GetAllPeople();
        }
    }
}
