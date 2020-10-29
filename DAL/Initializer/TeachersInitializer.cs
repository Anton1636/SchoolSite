using DAL.Context;
using DAL.Entity;
using System.Collections.Generic;
using System.Data.Entity;

namespace DAL.Initializer
{
    public class TeachersInitializer : DropCreateDatabaseAlways<EFContext>
    {
        protected override void Seed(EFContext _context)
        {
            var teachers = new List<tblTeachers>
            {
                new tblTeachers { FullName = "Alexander Olegovich Kostilov", Description = "WePlay! Clutch Island; IEM Katowice 2020; BLAST Premier Spring Series 2020; ESL Pro League Season 10. Европа; StarSeries & i-League CS:GO Season 7; BLAST Pro Series — Copenhagen 2018; ESL One Cologne 2018; CS:GO Asia Championships 2018; StarSeries i-League Season 5; DreamHack Winter 2017; WESG 2017 Europe Finals; ESL One New York 2016; CIS Championship; Кубок Воронежа;", ImageLink = "https://www.bestsettings.com/wp-content/uploads/2019/08/s1mple.jpg"},
                new tblTeachers { FullName = "Kirill Mikhailov", Description = "M.Game League #2; ESL Pro League Season 10. Европа; ", ImageLink = "https://svirtus.cdnvideo.ru/nB1GYWdNb0aly6UtRRtZowvCe8o=/0x0:4023x4025/200x200/filters:quality(100)/https://hb.bizmrg.com/esports-core-media/69/69d241fc44727867be55f294ca6c136a.jpeg?m=d1f01bf22a9ac754da9a88511c9b6fd7"},
                new tblTeachers { FullName = "Danilo Igorovich Teslenko", Description = "BLAST Pro Series — Copenhagen 2018; ESL One Cologne 2018; CS:GO Asia Championships 2018; StarSeries i-League Season 5;", ImageLink = "https://svirtus.cdnvideo.ru/TO6LLhKrYD5TF1EEtKwSR0l1QOw=/0x0:400x417/800x0/filters:quality(100)/https://hb.bizmrg.com/cybersportru-media/c8/c8f09618501bae37467478f081f7a5b7.png?m=cde4fa8968828595b175329eb3c0c8ff"},
                new tblTeachers { FullName = "John 'Edward' Sukharev", Description = "WESG 2017 Europe Finals; ESL One New York 2016; SLTV StarSeries IX;", ImageLink = "https://svirtus.cdnvideo.ru/T35Gk59v_4RVGdT1xdm4m7LzIEg=/0x0:226x245/200x200/filters:quality(100)/https://hb.bizmrg.com/esports-core-media/27/27a0bbd1b2cda0164a1da43593d38055.jpg?m=946fc4d57657c9bca49fb18ac9b78875"},
            };

            _context.Teachers.AddRange(teachers);
            _context.SaveChanges();
            base.Seed(_context);
        }
    }
}
