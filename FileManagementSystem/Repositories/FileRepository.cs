using DAL;
using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class FileRepository : IFileRepository
    {
        FileDbContext _context;
        public FileRepository()
        {
            _context = new FileDbContext();
        }
        public IEnumerable<Files> GetAll()
        {

            return _context.Files.ToList();

        }

            public Files GetById(int? useId, int? id)
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
            public void Delete(int? id)
            {
                throw new NotImplementedException();
            }
        }
    }

