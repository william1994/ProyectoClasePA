using ClasePA.Data;
using ClasePA.Models;
using ClasePA.Service;
using Microsoft.EntityFrameworkCore;

namespace ClasePA.Repository
{
    public class ErrollementsRepository : IEnrrollements
    {
        private AplicationDBContext _Bd;

        public ErrollementsRepository(AplicationDBContext bd) { 
        _Bd = bd;
        
        }

        public IEnumerable<Enrrollements> GetInnerJoin()
        {
            var Join = _Bd.Enrrollements
                .Include(e => e.Student)
                .Include(c => c.Course).
                ToList();

            return Join;
        }
    }
}
