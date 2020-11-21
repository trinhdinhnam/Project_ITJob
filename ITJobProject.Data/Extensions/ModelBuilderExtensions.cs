using ITJobProject.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using ITJobProject.Data.Enums;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;

namespace ITJobProject.Data.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            //Data seeding 
            //1.Admins
            var hasherAdmin = new PasswordHasher<Admin>();
            modelBuilder.Entity<Admin>().HasData(
            new Admin() {AdminId = Guid.NewGuid(), AdminName = "Trịnh Đình Nam", Email = "trinhdinhnam16898@gmail.com", Phone = "03095699933", Password = hasherAdmin.HashPassword(null, "123456"), CreatedDate = DateTime.Now, CreatedBy = "TDNAM" }
            );
            //2.Languages
            modelBuilder.Entity<Language>().HasData(
            new Language() {LanguageId= Guid.NewGuid(), LanguageName="C#/.NET", Description="Ngôn ngữ lập trình .NET core" ,CreatedDate = DateTime.Now, CreatedBy = "TDNAM"},
            new Language() { LanguageId = Guid.NewGuid(), LanguageName = "JAVA", Description = "Ngôn ngữ lập trình Java web", CreatedDate = DateTime.Now, CreatedBy = "TDNAM"},
            new Language() { LanguageId = Guid.NewGuid(), LanguageName = "PHP", Description = "Ngôn ngữ lập trình Php", CreatedDate = DateTime.Now, CreatedBy = "TDNAM"},
            new Language() { LanguageId = Guid.NewGuid(), LanguageName = "C/C++", Description = "Ngôn ngữ lập trình C/C++", CreatedDate = DateTime.Now, CreatedBy = "TDNAM"},
            new Language() { LanguageId = Guid.NewGuid(), LanguageName = "Android", Description = "Ngôn ngữ lập trình Adroid", CreatedDate = DateTime.Now, CreatedBy = "TDNAM"},
            new Language() { LanguageId = Guid.NewGuid(), LanguageName = "Python", Description = "Ngôn ngữ lập trình Python", CreatedDate = DateTime.Now, CreatedBy = "TDNAM"},
            new Language() { LanguageId = Guid.NewGuid(), LanguageName = "Angular", Description = "Ngôn ngữ lập trình front-end Angular", CreatedDate = DateTime.Now, CreatedBy = "TDNAM"}
            );
            //3.Recruiter Level
            modelBuilder.Entity<RecruiterLevel>().HasData(
                new RecruiterLevel() { RecruiterLevelId = Guid.NewGuid(), RecruiterLevelName ="Vip 1", Price=4500000, PostNumber=100,CreatedDate= DateTime.Now, CreatedBy="TDNAM"},
                new RecruiterLevel() { RecruiterLevelId = Guid.NewGuid(), RecruiterLevelName = "Vip 2", Price = 3600000, PostNumber = 80, CreatedDate = DateTime.Now, CreatedBy = "TDNAM" },
                new RecruiterLevel() { RecruiterLevelId = Guid.NewGuid(), RecruiterLevelName = "Vip 3", Price = 2700000, PostNumber = 60, CreatedDate = DateTime.Now, CreatedBy = "TDNAM" },
                new RecruiterLevel() { RecruiterLevelId = Guid.NewGuid(), RecruiterLevelName = "Normal", Price = 1200000, PostNumber = 30, CreatedDate = DateTime.Now, CreatedBy = "TDNAM" }
            );
            //4.Seeker
            var hasherSeeker = new PasswordHasher<Seeker>();

            modelBuilder.Entity<Seeker>().HasData(
                new Seeker() {SeekerId=Guid.NewGuid(), SeekerName = "Phạm Minh Sang", Email = "sang123@gmail.com", Phone = "03949394932", DateOfBirth = new DateTime(1998, 03, 14, 0, 0, 0), Gender = Gender.Male, Address="Thường Tín, Hà Nội", Password= hasherSeeker.HashPassword(null, "162661"), CreatedDate= DateTime.Now, CreatedBy="TDNAM"  },
                new Seeker() { SeekerId = Guid.NewGuid(), SeekerName = "Hoàng Phi Hùng", Email = "hunghp@gmail.com", Phone = "09493848844", DateOfBirth = new DateTime(1998, 09, 17, 0, 0, 0), Gender = Gender.Male, Address = "Yên Hòa, Cầu Giấy, Hà Nội", Password = hasherSeeker.HashPassword(null, "174777"), CreatedDate = DateTime.Now, CreatedBy = "TDNAM" },
                new Seeker() { SeekerId = Guid.NewGuid(), SeekerName = "Lê Thị Thùy Trang", Email = "trang123@gmail.com", Phone = "07483884835", DateOfBirth = new DateTime(1997, 05, 21, 0, 0, 0), Gender = Gender.FeMale, Address = "Tạ Quang Bửu, Hai Bà Trưng, Hà Nội", Password = hasherSeeker.HashPassword(null, "838834"), CreatedDate = DateTime.Now, CreatedBy = "TDNAM" }
            );
            //5.Company
            modelBuilder.Entity<Company>().HasData(
                new Company() {CompanyId  = Guid.NewGuid(), CompanyName="Công ty cổ phần MISA", Address="15 Phố Duy Tân, Cầu Giấy, Hà Nội", Introduction="Công ty cổ phần MISA là công ty phần mềm Product tạo ra những phần mềm có ứng dụng cao cho các ngành nghề", Image="",WorkingDay="Thứ 2 - Thứ 6", CompanySize=3000, TypeBusiness = TypeBusiness.product, CreatedDate= DateTime.Now, CreatedBy="TDNAM"},
                new Company() { CompanyId = Guid.NewGuid(), CompanyName = "Tập toàn viễn thông quân đội Viettel", Address = "Tòa Landmark 72, đường Phạm Hùng, Hà Nội", Introduction = "Tập đoàn lớn nhất khu vực về mạng viễn thông", Image = "", WorkingDay = "Thứ 2 - Thứ 6", CompanySize = 25000, TypeBusiness = TypeBusiness.product, CreatedDate = DateTime.Now, CreatedBy = "TDNAM" },
                new Company() { CompanyId = Guid.NewGuid(), CompanyName = "Công ty SamSung", Address = "Số 1, Phạm Văn Bạch, Cầu Giấy, Hà Nội", Introduction = "Công ty SamSung là công ty hàng đầu trong lĩnh vực mạng 4G", Image = "", WorkingDay = "Thứ 2 - Thứ 6", CompanySize = 3000, TypeBusiness = TypeBusiness.outsource, CreatedDate = DateTime.Now, CreatedBy = "TDNAM" }

                );
            //6.Recruiter
            var hasherRecruiter = new PasswordHasher<Recruiter>();

            modelBuilder.Entity<Recruiter>().HasData(
            new Recruiter() { RecruiterId = Guid.NewGuid(), RecruiterName = "Hoàng Văn Tuấn", Email = "tuan123@gmail.com", Phone = "04984842444", DateOfBirth = new DateTime(1997, 05, 21, 0, 0, 0), Gender = Gender.Male, Address = "Số 3 Nguyễn Khang, Cầu Giấy", Password = hasherRecruiter.HashPassword(null, "123445"), RecruiterLevelId= Guid.NewGuid(), CreatedDate = DateTime.Now, CreatedBy = "TDNAM" },
                new Recruiter() { RecruiterId = Guid.NewGuid(), RecruiterName = "Lưu Văn Hoàng", Email = "hoang123@gmail.com", Phone = "03828484844", DateOfBirth = new DateTime(1998, 11, 14, 0, 0, 0), Gender = Gender.Male, Address = "ngõ 67, Yên Hòa, Cầu Giấy", Password = hasherRecruiter.HashPassword(null, "123123"), RecruiterLevelId = Guid.NewGuid(), CreatedDate = DateTime.Now, CreatedBy = "TDNAM" },
                new Recruiter() { RecruiterId = Guid.NewGuid(), RecruiterName = "Lê Thị Trang", Email = "trang3323@gmail.com", Phone = "094838848353", DateOfBirth = new DateTime(1996, 07, 29, 0, 0, 0), Gender = Gender.FeMale, Address = "số 37, Trương Định, Hai Bà Trưng, Hà Nội", Password = hasherRecruiter.HashPassword(null, "323442"), RecruiterLevelId = Guid.NewGuid(), CreatedDate = DateTime.Now, CreatedBy = "TDNAM" }
                );

            //7.Job
            modelBuilder.Entity<Job>().HasData(
                new Job() { JobId = Guid.NewGuid(), JobName = "Thực tập sinh PHP/Laravel", Possition = "Thực tập sinh", LanguageId= Guid.NewGuid(), Require="Yêu cầu thí sinh nắm chắc kiến thức về HTML/CSS, và biết một số framework như Laravel, Magnento càng tốt", Description="Bạn sẽ được đào tạo trong 3 tháng và đánh giá để lên nhân viên chính thức, join vào các dự án thực tế", Salary=5000000, Address="Hà Nội", StartDateApply = new DateTime(2020, 10, 21, 0, 0, 0), EndDateApply= new DateTime(2020, 11, 21, 0, 0, 0), CompanyId=Guid.NewGuid(), AdminId=Guid.NewGuid(), RecruiterId = Guid.NewGuid(), CreatedDate=DateTime.Now,CreatedBy="TDNAM"  },
                new Job() { JobId = Guid.NewGuid(), JobName = "Nhân viên lập trình front-end Angular", Possition = "Nhân viên", LanguageId = Guid.NewGuid(), Require = "Yêu cầu chắc kiến thức về HTML/CSS, nắm rõ kiến thức cơ bản về Angular", Description = "Bạn sẽ được thử việc vào dự án trong 2 tháng và được đánh giá lên nhân viên chính thức", Salary = 12000000, Address = "Hà Nội", StartDateApply = new DateTime(2020, 11, 15, 0, 0, 0), EndDateApply = new DateTime(2020, 12, 10, 0, 0, 0), CompanyId = Guid.NewGuid(), AdminId = Guid.NewGuid(), RecruiterId = Guid.NewGuid(), CreatedDate = DateTime.Now, CreatedBy = "TDNAM" },
                new Job() { JobId = Guid.NewGuid(), JobName = "Senior Manager dự án quản trị doanh nghiệp", Possition = "Senior Manager", LanguageId = Guid.NewGuid(), Require = "Yêu cầu có kinh nghiệm làm việc 2 năm, có khả năng lãnh đạo và tổ chức làm việc teamwork, nhanh nhẹn không ngại vất vả", Description = "Bạn sẽ giao làm việc trong dự án quản trị doanh nghiệp với một đội nhân viên theo sự chỉ đạo của bạn", Salary = 27500000, Address = "Đà Nẵng", StartDateApply = new DateTime(2020, 10, 11, 0, 0, 0), EndDateApply = new DateTime(2020, 12, 21, 0, 0, 0), CompanyId = Guid.NewGuid(), AdminId = Guid.NewGuid(), RecruiterId = Guid.NewGuid(), CreatedDate = DateTime.Now, CreatedBy = "TDNAM" },
                new Job() { JobId = Guid.NewGuid(), JobName = "Junior Software Engineer ", Possition = "Junior", LanguageId = Guid.NewGuid(), Require = "Yêu cầu đã làm qua các dự án về Java, và có khả năng làm việc nhóm", 
                    Description = "Bạn sẽ làm việc trong một nhóm Java nhỏ, nhanh nhẹn cùng với các chuyên gia Java khác và cùng chúng tôi xây dựng kiến ​​trúc microservices. Phát triển và phát triển tài năng thông qua các chiến lược cố vấn, huấn luyện và giữ chân nhân tài quan trọng trong môi trường kinh tế tăng trưởng nhanh,cạnh tranh cao.", 
                    Salary = 25000000, Address = "TP Hồ Chí Minh", StartDateApply = new DateTime(2020, 11, 10, 0, 0, 0), EndDateApply = new DateTime(2020, 12, 21, 0, 0, 0), CompanyId = Guid.NewGuid(), AdminId = Guid.NewGuid(), RecruiterId = Guid.NewGuid(), CreatedDate = DateTime.Now, CreatedBy = "TDNAM" }

                );
            //8. SeekerJob
            modelBuilder.Entity<SeekerJob>().HasData(
                new SeekerJob() { SeekerId = Guid.NewGuid(), JobId=Guid.NewGuid(), ApplyDate=new DateTime(2020, 11, 15, 0, 0, 0), Status= Status.Pending, CreatedDate =DateTime.Now,CreatedBy="TDNAM" },
                new SeekerJob() { SeekerId = Guid.NewGuid(), JobId = Guid.NewGuid(), ApplyDate = new DateTime(2020, 10, 29, 0, 0, 0), Status = Status.Approved, CreatedDate = DateTime.Now, CreatedBy = "TDNAM" },
                new SeekerJob() { SeekerId = Guid.NewGuid(), JobId = Guid.NewGuid(), ApplyDate = new DateTime(2020, 11, 03, 0, 0, 0), Status = Status.Pending, CreatedDate = DateTime.Now, CreatedBy = "TDNAM" },
                new SeekerJob() { SeekerId = Guid.NewGuid(), JobId = Guid.NewGuid(), ApplyDate = new DateTime(2020, 11, 07, 0, 0, 0), Status = Status.Pending, CreatedDate = DateTime.Now, CreatedBy = "TDNAM" },
                new SeekerJob() { SeekerId = Guid.NewGuid(), JobId = Guid.NewGuid(), ApplyDate = new DateTime(2020, 11, 11, 0, 0, 0), Status = Status.Pending, CreatedDate = DateTime.Now, CreatedBy = "TDNAM" }

                 );


        }
    }
}
