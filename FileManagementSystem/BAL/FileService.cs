using DAL.Entities;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL
{
    public class FileService : IFileService
    {
        private IFileRepository _service;

        public FileService()
        {
            _service = new FileRepository();
        }

        public IEnumerable<Files> GetAll()
        {
            return _service.GetAll();
        }

        public Files GetById(int? userID, int? id)
        {
            throw new NotImplementedException();
        }

        public void Update(Files file)
        {
            throw new NotImplementedException();
        }

        public void Upload(Files file)
        {
            throw new NotImplementedException();
        }
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

       

        public Files GetById(int? id)
        {
            throw new NotImplementedException();
        }
    }
}
