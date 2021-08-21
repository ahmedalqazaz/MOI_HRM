using Microsoft.EntityFrameworkCore;
using MOI_HRM.Data;
using MOI_HRM.Interfaces;
using MOI_HRM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MOI_HRM.Repositories
{

    public class IHRMRepository : IHRM
    {
        public ApplicationDbContext _db { get; set; }
        public IHRMRepository(ApplicationDbContext DB)
        {
            _db = DB;

        }



        public async Task<string> AddEmp(HRM IncomingHRM)
        {
            _db.HRMTable.Add(IncomingHRM);
            await _db.SaveChangesAsync();
            return "Employee has ben Added";
        }

        public async Task<bool> CkEmp(HRM ChkEmp)
        {
            var Chk =await _db.HRMTable.SingleOrDefaultAsync(A => A.FName == ChkEmp.FName);
            if(Chk==null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
