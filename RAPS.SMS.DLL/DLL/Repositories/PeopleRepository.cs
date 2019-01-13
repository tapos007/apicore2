using System.Collections.Generic;
using System.Linq;
using RAPS.SMS.DLL.DLL.Models;

namespace RAPS.SMS.DLL.DLL.Repositories
{

    public interface IPeopleRepository
    {
        List<People> GetAllPeople();
    }
    public class PeopleRepository : IPeopleRepository
    {

        private Raps_SMEContext _context ;

        public PeopleRepository(Raps_SMEContext context)
        {
            _context = context;
        }

        public List<People> GetAllPeople()
        {
            return _context.People.ToList();
        }
    }
}
