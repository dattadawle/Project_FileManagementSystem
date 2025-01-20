using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL
{
    public interface IFileService
    {
        IEnumerable<Files> GetAll();
        Files GetById(int? id);
        void Upload(Files file);

        void Update(Files file);
        void Delete(int id);
        
    }
}
