using DAL.Context;
using DAL.Entity;
using System.Collections.Generic;
using System.Data.Entity;

namespace DAL.Initializer
{
    public class GallaryInitializer : DropCreateDatabaseAlways<EFContext>
    {
        protected override void Seed(EFContext _context)
        {
            var gallary = new List<tblGallary>
            {
                new tblGallary{ Description = "Our way in choosing professions", ImageLink = "http://rgg.rv.ua/menu-gimnasium/menu-foto/m-2019-2020/vesna-2019-2020/image?view=image&format=raw&type=img&id=1996"},
                new tblGallary{ Description = "Spring battles", ImageLink = "http://rgg.rv.ua/images/joomgallery/thumbnails/fotogalery_2/2019-2020_42/vesna_45/foto_20200311_1368832781.jpeg"},
                new tblGallary{ Description = "Adolescent nutrition: useful, tasty, affordable", ImageLink = "http://rgg.rv.ua/menu-gimnasium/menu-foto/m-2019-2020/vesna-2019-2020"},
                new tblGallary{ Description = "Holly winter", ImageLink = "http://rgg.rv.ua/menu-gimnasium/menu-foto/m-2019-2020/m-zuma-2019-2020/image?view=image&format=raw&type=img&id=1982"},
                new tblGallary{ Description = "The future of Ukraine is for healthy youth!", ImageLink = "http://rgg.rv.ua/menu-gimnasium/menu-foto/m-2019-2020/m-zuma-2019-2020/image?view=image&format=raw&type=img&id=1960"},
                new tblGallary{ Description = "Sports and intellectual relay 'Healthy to be fashionable and modern'", ImageLink = "http://rgg.rv.ua/menu-gimnasium/menu-foto/m-2019-2020/m-zuma-2019-2020/image?view=image&format=raw&type=img&id=1956"}
            };

            _context.Gallaries.AddRange(gallary);
            _context.SaveChanges();
            base.Seed(_context);
        }
    }
}
