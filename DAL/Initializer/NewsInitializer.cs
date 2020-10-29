using DAL.Context;
using DAL.Entity;
using System.Collections.Generic;
using System.Data.Entity;

namespace DAL.Initializer
{
    public class NewsInitializer : DropCreateDatabaseAlways<EFContext>
    {
        protected override void Seed(EFContext _context)
        {
            var news = new List<tblNews>
            {
                new tblNews{ Title = "WARNING! WARNING!", Description = "If you know how to organize both your own work and cooperation with peers, are responsible for the work started, cultivate principles, initiative, organizational, communicative and moral qualities, are a student of 8-10 grades - we invite you to become a candidate for the position of Head of Student Government . Voting for the candidates for the Chairman of the Student Self-Government will take place at the reporting and election student conference, which will take place on September 15 at 2:45 p.m. in the assembly hall of the gymnasium. Applications from candidates should be submitted by September 11 to the office of the teacher-organizer.", DatePost = "07/09/2020", LinkImage = "http://rgg.rv.ua/images/joomgallery/details/zagalna_8/2017_26/foto_20200907_1929489264.jpg"},
                new tblNews{ Title = "Forward, to new accomplishments and knowledge!", Description = "After the summer holidays, on the first day of autumn, all schools in our country meet their students to start another school year. September 1 is a meeting with school, teachers, friends and of course the holiday of the 'First Bell'.", DatePost = "01/09/2020", LinkImage = "http://rgg.rv.ua/images/joomgallery/details/fotogalery_2/2020-2021_47/osin_48/foto_20200901_1171322660.jpg"},
                new tblNews{ Title = "WARNING! WARNING!", Description = "Dear high school family! There is one day left until the start of the new school year. Tomorrow, September 1, students across Ukraine will go to study in the new conditions, adhering to all anti-epidemic measures. So on the eve of the start of training, we offer you to watch a motivational video dedicated to the beginning of the new school year.", DatePost = "31/08/2020", LinkImage = "http://rgg.rv.ua/images/joomgallery/details/zagalna_8/2017_26/foto_20200831_1768936510.jpg"},
                new tblNews{ Title = "Implementation of the GSuite system", Description = "Шановні вчителі. В нашій гімназії проходить впровадження в навчальний процес системи GSuite. Протягом 27 серпня, перейдіть за посиланням та вкажіть ваше прізвище та ім'я англійською мовою, так як ви вважаєте є правильним. Дана інформація буде використовуватись під час реєстрації вашого корпоративного облікового запису GSuite.", DatePost = "26/08/2020", LinkImage = ""}
            };

            _context.Newss.AddRange(news);
            _context.SaveChanges();
            base.Seed(_context);
        }
    }
}
