using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using mvconlineotomasyon.Models.sınıflar;
namespace mvconlineotomasyon.Controllers
{
    public class kategoriController : Controller
    {
        // GET: kategori
        Contex c = new Contex();
        public ActionResult Index()
        {
            var degerler = c.Kategoris.ToList();
            return View(degerler);
        }
        [HttpGet]
        public ActionResult KategoriEkle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult KategoriEkle(kategori k)
        {
            //kategorilerin içine k dan gelen değerleri ekledik
            //view tarafında gönderdiğimiz parametreleri k nesnesi tutacak
          c.Kategoris.Add(k);
            //değişiklikleri kaydet
            c.SaveChanges();
            return RedirectToAction("Index");

        }
        public ActionResult KategoriSil(int id)
        {
            //kategori sınıfım içinde benim dışardan gönderdiğim id yi bul
            var ktg = c.Kategoris.Find(id);
            //ktg den gelen değeri kategorisden kaldır
            c.Kategoris.Remove(ktg);
            c.SaveChanges();
            return RedirectToAction("index");
        }
        public ActionResult KategoriGetir(int id)
        {
            //id ye göre kategoriyi bul
            var kategori = c.Kategoris.Find(id);
            //kategori isimli değişkenden gelen değerlerle beraber kategoriGetiri bana döndür
            return View("KategoriGetir", kategori);
        }
        public ActionResult KategoriGuncelle(kategori k)
        {
            //ktgr isminde değişken oluşturduk bu değişkenle ıd yi hafızaya aldık
            var ktgr = c.Kategoris.Find(k.KategoriID);
            ktgr.KategoriAd = k.KategoriAd;
            c.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}