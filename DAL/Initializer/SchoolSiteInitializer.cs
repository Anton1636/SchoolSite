using DAL.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Initializer
{
    class SchoolSiteInitializer : DropCreateDatabaseAlways<ApplicationContext>
    {
        protected override void Seed(ApplicationContext _context)
        {
            var careers = new List<tblCareer>
            {
                new tblCareer{ Name = "Head Teacher", Salary = 20, Description = "Responsibilities: planning and organization of the educational process (drawing up curricula, timetables, load distribution)quality control of the educational processtraining, adaptation, assessment and organization of teachers' workorganization and control of student progress and attendance."},
                new tblCareer{ Name = "School cook", Salary = 250, Description = "Responsibilities: to be a team player, part of our team.Great desire to develop in this direction.Preparation of dishes and preparations according to the calculation, production technology and time standards in the Eurasia network.Maintaining cleanliness and order in the workplace in accordance with approved standards."},
                new tblCareer{ Name = "Watcher", Salary = 150, Description = "Responsibilities: checkpoint mode, ability to communicate, react quickly, think positively :) age is not an obstacle to the desire to work"},
                new tblCareer{ Name = "Scrubwoman", Salary = 175, Description = "Responsibilities: tidy up and clean up and clean it up in a proper sanitary camp, anchored in the back room - one room, wipe it down for a day (the robot is not folding, it’s clean in the back room, the school is okay, it’s good enough for the client company)" }
            };

            var gallary = new List<tblGallary>
            {
                new tblGallary{ Description = "Our way in choosing professions", ImageLink = "http://rgg.rv.ua/menu-gimnasium/menu-foto/m-2019-2020/vesna-2019-2020/image?view=image&format=raw&type=img&id=1996"},
                new tblGallary{ Description = "Spring battles", ImageLink = "http://rgg.rv.ua/images/joomgallery/thumbnails/fotogalery_2/2019-2020_42/vesna_45/foto_20200311_1368832781.jpeg"},
                new tblGallary{ Description = "Adolescent nutrition: useful, tasty, affordable", ImageLink = "http://rgg.rv.ua/menu-gimnasium/menu-foto/m-2019-2020/vesna-2019-2020"},
                new tblGallary{ Description = "Holly winter", ImageLink = "http://rgg.rv.ua/menu-gimnasium/menu-foto/m-2019-2020/m-zuma-2019-2020/image?view=image&format=raw&type=img&id=1982"},
                new tblGallary{ Description = "The future of Ukraine is for healthy youth!", ImageLink = "http://rgg.rv.ua/menu-gimnasium/menu-foto/m-2019-2020/m-zuma-2019-2020/image?view=image&format=raw&type=img&id=1960"},
                new tblGallary{ Description = "Sports and intellectual relay 'Healthy to be fashionable and modern'", ImageLink = "http://rgg.rv.ua/menu-gimnasium/menu-foto/m-2019-2020/m-zuma-2019-2020/image?view=image&format=raw&type=img&id=1956"}
            };

            var news = new List<tblNews>
            {
                new tblNews{ Title = "WARNING! WARNING!", Description = "If you know how to organize both your own work and cooperation with peers, are responsible for the work started, cultivate principles, initiative, organizational, communicative and moral qualities, are a student of 8-10 grades - we invite you to become a candidate for the position of Head of Student Government . Voting for the candidates for the Chairman of the Student Self-Government will take place at the reporting and election student conference, which will take place on September 15 at 2:45 p.m. in the assembly hall of the gymnasium. Applications from candidates should be submitted by September 11 to the office of the teacher-organizer.", DatePost = "07/09/2020", LinkImage = "http://rgg.rv.ua/images/joomgallery/details/zagalna_8/2017_26/foto_20200907_1929489264.jpg"},
                new tblNews{ Title = "Forward, to new accomplishments and knowledge!", Description = "After the summer holidays, on the first day of autumn, all schools in our country meet their students to start another school year. September 1 is a meeting with school, teachers, friends and of course the holiday of the 'First Bell'.", DatePost = "01/09/2020", LinkImage = "http://rgg.rv.ua/images/joomgallery/details/fotogalery_2/2020-2021_47/osin_48/foto_20200901_1171322660.jpg"},
                new tblNews{ Title = "WARNING! WARNING!", Description = "Dear high school family! There is one day left until the start of the new school year. Tomorrow, September 1, students across Ukraine will go to study in the new conditions, adhering to all anti-epidemic measures. So on the eve of the start of training, we offer you to watch a motivational video dedicated to the beginning of the new school year.", DatePost = "31/08/2020", LinkImage = "http://rgg.rv.ua/images/joomgallery/details/zagalna_8/2017_26/foto_20200831_1768936510.jpg"},
                new tblNews{ Title = "Implementation of the GSuite system", Description = "Шановні вчителі. В нашій гімназії проходить впровадження в навчальний процес системи GSuite. Протягом 27 серпня, перейдіть за посиланням та вкажіть ваше прізвище та ім'я англійською мовою, так як ви вважаєте є правильним. Дана інформація буде використовуватись під час реєстрації вашого корпоративного облікового запису GSuite.", DatePost = "26/08/2020", LinkImage = ""}
            };

            var schedule = new List<tblSchedule>
            {
                new tblSchedule{ SubjectName = "Maths", TeacherName = "Makarchuk Zoya Vladimirovna", DayWeek = "Moday", StartTime = "11:00", EndTime = "11:40"},
                new tblSchedule{ SubjectName = "World Literature", TeacherName = "Ordynska Vira Hryhorivna", DayWeek = "Moday", StartTime = "12:00", EndTime = "12:40"},
                new tblSchedule{ SubjectName = "Labor training and technology", TeacherName = "Yaremchuk Irina Petrovna", DayWeek = "Moday", StartTime = "13:00", EndTime = "13:40"},
                new tblSchedule{ SubjectName = "German language", TeacherName = "Dubych Iryna Mykhailivna", DayWeek = "Moday", StartTime = "14:00", EndTime = "14:40"},
                new tblSchedule{ SubjectName = "Musical art", TeacherName = "Yatsenya Alla Vladimirovna", DayWeek = "Moday", StartTime = "15:00", EndTime = "15:40"},
                new tblSchedule{ SubjectName = "Physical education and swimming", TeacherName = "Kovaleva Tatiana Nikolaevna", DayWeek = "Friday", StartTime = "11:00", EndTime = "11:40"},
                new tblSchedule{ SubjectName = "Ukrainian language", TeacherName = "Basyrova Nina Stepanovna", DayWeek = "Friday", StartTime = "12:00", EndTime = "12:40"},
                new tblSchedule{ SubjectName = "English language", TeacherName = "Malyarchuk Maria Andreevna", DayWeek = "Friday", StartTime = "13:00", EndTime = "13:40"},
                new tblSchedule{ SubjectName = "Computer science", TeacherName = "Smulka Victor Vasilyevich", DayWeek = "Friday", StartTime = "14:00", EndTime = "14:40"},
                new tblSchedule{ SubjectName = "Biology", TeacherName = "Pashko Halyna Ulyanivna", DayWeek = "Friday", StartTime = "15:00", EndTime = "15:40"}
            };

            var schoolParty = new List<tblSchoolParty>
            {
                new tblSchoolParty{ Description = "Week «Мade in Ukraine»", FullDate = "17/06/2020", ImageLink = "http://rgg.rv.ua/images/joomgallery/details/systemna_7/proektu_23/p70130-124457_20170617_1319682922.jpg"},
                new tblSchoolParty{ Description = "We gnaw the granite of science. We exchange good grades for sweets.", FullDate = "13/04/20219", ImageLink = "http://rgg.rv.ua/images/joomgallery/details/systemna_7/proektu_23/p1010011_20170617_1564683012.jpg"},
                new tblSchoolParty{ Description = "Ukrainian embroidered shirt", FullDate = "15/02/2020", ImageLink = "http://rgg.rv.ua/images/joomgallery/details/systemna_7/proektu_23/foto_20200105_1370932733.jpg"},
                new tblSchoolParty{ Description = "Let's say to the pollution: 'No!'", FullDate = "05/02/2020", ImageLink = "http://rgg.rv.ua/images/joomgallery/details/systemna_7/proektu_23/foto_20200105_1047291689.jpg"}
            };

            var teachers = new List<tblTeachers>
            {
                new tblTeachers { FullName = "Alexander Olegovich Kostilov", Description = "WePlay! Clutch Island; IEM Katowice 2020; BLAST Premier Spring Series 2020; ESL Pro League Season 10. Европа; StarSeries & i-League CS:GO Season 7; BLAST Pro Series — Copenhagen 2018; ESL One Cologne 2018; CS:GO Asia Championships 2018; StarSeries i-League Season 5; DreamHack Winter 2017; WESG 2017 Europe Finals; ESL One New York 2016; CIS Championship; Кубок Воронежа;", ImageLink = "https://www.bestsettings.com/wp-content/uploads/2019/08/s1mple.jpg"},
                new tblTeachers { FullName = "Kirill Mikhailov", Description = "M.Game League #2; ESL Pro League Season 10. Европа; ", ImageLink = "https://svirtus.cdnvideo.ru/nB1GYWdNb0aly6UtRRtZowvCe8o=/0x0:4023x4025/200x200/filters:quality(100)/https://hb.bizmrg.com/esports-core-media/69/69d241fc44727867be55f294ca6c136a.jpeg?m=d1f01bf22a9ac754da9a88511c9b6fd7"},
                new tblTeachers { FullName = "Danilo Igorovich Teslenko", Description = "BLAST Pro Series — Copenhagen 2018; ESL One Cologne 2018; CS:GO Asia Championships 2018; StarSeries i-League Season 5;", ImageLink = "https://svirtus.cdnvideo.ru/TO6LLhKrYD5TF1EEtKwSR0l1QOw=/0x0:400x417/800x0/filters:quality(100)/https://hb.bizmrg.com/cybersportru-media/c8/c8f09618501bae37467478f081f7a5b7.png?m=cde4fa8968828595b175329eb3c0c8ff"},
                new tblTeachers { FullName = "John 'Edward' Sukharev", Description = "WESG 2017 Europe Finals; ESL One New York 2016; SLTV StarSeries IX;", ImageLink = "https://svirtus.cdnvideo.ru/T35Gk59v_4RVGdT1xdm4m7LzIEg=/0x0:226x245/200x200/filters:quality(100)/https://hb.bizmrg.com/esports-core-media/27/27a0bbd1b2cda0164a1da43593d38055.jpg?m=946fc4d57657c9bca49fb18ac9b78875"},
            };

            _context.Teachers.AddRange(teachers);
            _context.SchoolParty.AddRange(schoolParty);
            _context.Schedule.AddRange(schedule);
            _context.News.AddRange(news);
            _context.Gallary.AddRange(gallary);
            _context.Career.AddRange(careers);
            _context.SaveChanges();
            base.Seed(_context);
        }
    }
}
