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
    public class KategoriViewModel : Temel<int>
    {
        [Required]
        [StringLength(50)]

        [Display(Name = "Kategori Adı")]
        public string KategoriAdi { get; set; }
        [Display(Name = "Açıklama")]
        //[Display(ResourceType =)] // Farklı diller için...
        public string Aciklama { get; set; }
        [Display(Name = "Üst Kategori")]
        public int? UstKategoriId { get; set; }
        public string KategoriFotoUrl { get; set; }
        public HttpPostedFileBase Dosya { get; set; } //

    }
}
