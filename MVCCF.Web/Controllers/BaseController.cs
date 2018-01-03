using MVCCF.BLL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;

namespace MVCCF.Web.Controllers
{
    public class BaseController : Controller
    {
        [NonAction] //Bu Action'u action gini kullanamasın! Yani dışardan çağıramasın diye yazılır.
        public void ResimBoyutlandir(int en, int boy, string yol)
        {
            WebImage img = new WebImage(yol);
            img.Resize(en, boy, false);
            img.AddTextWatermark("W11.com", fontColor: "Purple", fontSize: 15, fontFamily: "Century Gothic");
            img.Save(yol);
        }
        [NonAction]
        public async Task<List<SelectListItem>> KategoriSelectList()
        {
            var kategoriList = await new KategoriRepo().GetAll();
            var kategoriler = new List<SelectListItem>();
            kategoriler.Add(new SelectListItem()
            {
                Text = "Üst Kategorisi Yok",
                Value = "0"
            });
            kategoriList.ForEach(x =>
            kategoriler.Add(new SelectListItem
            {
                Text = x.KategoriAdi,
                Value = x.Id.ToString()
            })
            );
            return kategoriler;
        }
    }
}