using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace DAL.Entities
{
    public class Files
    {
        [Column(Order = 1)]
        [Key]
        public int FileId { get; set; }

        [Column(Order = 2)]
        public string FileName { get; set; }

        [Column(Order = 3)]
        public string FileType { get; set; }

        [Column(Order = 4)]
        public string FilePath { get; set; }

        // [ForeignKey("User")]
        [Column(Order = 5)]
        public int? UploadedBy { get; set; }

        [Column(Order = 6)]
        public DateTime UploadedDate { get; set; }

        // [ForeignKey("User")]
        [Column(Order = 7)]
        public int? UpdatedBy { get; set; }

        [Column(Order = 8)]
        public DateTime UpdatedDate { get; set; }

        [Column(Order = 9)]
        public bool IsActive { get; set; }

        [Column(Order = 10)]
        public string EntryIP { get; set; }

        [Column(Order = 11)]
        public string UpdateIP { get; set; }

        [ForeignKey("UploadedBy")]
        public User User { get; set; }
    }
}
