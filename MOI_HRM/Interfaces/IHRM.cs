using MOI_HRM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MOI_HRM.Interfaces
{
    interface IHRM
    {
        public Task<string> AddEmp(HRM IncomingHRM);
        public Task<bool> CkEmp(HRM ChkEmp);
        public Task<List<HRM>> allEmp();
        public Task<HRM>SearchByID(int ID);
        public Task<HRM> SearchByN(String CurrentValue);

    }
}
