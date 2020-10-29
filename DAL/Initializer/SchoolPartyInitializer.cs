using DAL.Context;
using DAL.Entity;
using System.Collections.Generic;
using System.Data.Entity;

namespace DAL.Initializer
{
    public class SchoolPartyInitializer : DropCreateDatabaseAlways<EFContext>
    {
        protected override void Seed(EFContext _context)
        {
            var schoolParty = new List<tblSchoolParty>
            {
                new tblSchoolParty{ Description = "Week «Мade in Ukraine»", FullDate = "17/06/2020", ImageLink = "http://rgg.rv.ua/images/joomgallery/details/systemna_7/proektu_23/p70130-124457_20170617_1319682922.jpg"},
                new tblSchoolParty{ Description = "We gnaw the granite of science. We exchange good grades for sweets.", FullDate = "13/04/20219", ImageLink = "http://rgg.rv.ua/images/joomgallery/details/systemna_7/proektu_23/p1010011_20170617_1564683012.jpg"},
                new tblSchoolParty{ Description = "Ukrainian embroidered shirt", FullDate = "15/02/2020", ImageLink = "http://rgg.rv.ua/images/joomgallery/details/systemna_7/proektu_23/foto_20200105_1370932733.jpg"},
                new tblSchoolParty{ Description = "Let's say to the pollution: 'No!'", FullDate = "05/02/2020", ImageLink = "http://rgg.rv.ua/images/joomgallery/details/systemna_7/proektu_23/foto_20200105_1047291689.jpg"}
            };

            _context.SchoolParties.AddRange(schoolParty);
            _context.SaveChanges();
            base.Seed(_context);
        }
    }
}
