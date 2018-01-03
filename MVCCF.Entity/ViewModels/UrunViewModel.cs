using MVCCF.Entity.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace MVCCF.Entity.ViewModels
{
    public class UrunViewModel : Temel<long>
    {
        [Required]
        [StringLength(100)]
        [Display(Name = "Ürün Adı")]
        public string UrunAdi { get; set; }
        public decimal Fiyat { get; set; } = 0;
        [Display(Name = "Eski Fiyat")]
        public decimal? EskiFiyat { get; set; }
        public int KategoriId { get; set; }
        public List<string> FotoUrlList { get; set; } = new List<string>();
        public List<HttpPostedFileBase> DosyaList { get; set; } = new List<HttpPostedFileBase>();
    }
}
