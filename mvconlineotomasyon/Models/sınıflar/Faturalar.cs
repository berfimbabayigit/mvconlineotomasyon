using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace mvconlineotomasyon.Models.sınıflar
{
    public class Faturalar
    {
        [Key]
        public int Faturaid { get; set; }
        [Column(TypeName = "char")]
        [StringLength(1)]
        public char FaturaSeriNo { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(6)]
        public string FaturaSıraNo { get; set; }
        public DateTime Tarih { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(60)]
        public string VergiDairesi { get; set; }
        public DateTime Saat { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(30)]
        public string TeslimEden { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(30)]
        public string TeslimAlan { get; set; }
        public ICollection<FaturaKalem> FaturaKalems { get; set; }
    }
}