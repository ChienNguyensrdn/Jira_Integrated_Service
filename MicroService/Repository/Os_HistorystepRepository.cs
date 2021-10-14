using Contracts;
using Entities;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class Os_HistorystepRepository: RepositoryBase<Os_Historystep>, IOs_HistorystepRepository
    {
        public Os_HistorystepRepository(RepositoryContext repositoryContext)
         : base(repositoryContext)
        {
        }
    }
}
