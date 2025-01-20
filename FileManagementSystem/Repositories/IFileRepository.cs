using DAL.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface IFileRepository
    {
        IEnumerable<Files> GetAll();

        Files GetById(int? useId,int? id);

        void Upload(Files file);
        void Update(Files file);
        void Delete(int? id);

    }
}
