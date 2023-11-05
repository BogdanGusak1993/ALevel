using HW8.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW8.Repositories.Abstractions
{
    public interface ICandyRepository
    {
        public List <CandysEntity> CraftCandys ();

        public void SortCandysRepo(List<CandysEntity> list);
    }
}
