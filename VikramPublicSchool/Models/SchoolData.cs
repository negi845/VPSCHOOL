namespace VikramPublicSchool.Models
{
    // Central static data source for the whole website. No database is used.
    public static class SchoolData
    {
        public static string SchoolName => "Vikram Public School";
        public static string Tagline => "Empowering Young Minds for a Brighter Tomorrow";
        public static string Address => "L-II, 905/20, Main Shani Bazar Road, Sangam Vihar, New Delhi - 110062";
        // Note: No verified public phone/email could be confirmed from directory listings (Justdial gates
        // this behind their site). Replace these with the school's real contact details before going live.
        public static string Phone1 => "+91 9971309515";
        public static string Phone2 => "+91 9818547612";
        public static string Email => "info@vikrampublicschool.edu.in";
        public static string AdmissionEmail => "admissions@vikrampublicschool.edu.in";
        public static string EstablishedYear => "2007";
        public static string StudentTeacherRatio => "29:1";
        public static string TotalStudents => "147+";
        public static string TotalTeachers => "5";
        public static string LibraryBookCount => "56+";

        public static List<Highlight> Highlights => new()
        {
            new Highlight { Icon = "fa-solid fa-chalkboard-user", Title = "Experienced Teachers", Description = "Qualified and dedicated faculty with years of teaching experience." },
            new Highlight { Icon = "fa-solid fa-display", Title = "Smart Classrooms", Description = "Digital, interactive classrooms designed for modern learning." },
            new Highlight { Icon = "fa-solid fa-computer", Title = "Computer Lab", Description = "Well-equipped computer labs to build strong digital skills." },
            new Highlight { Icon = "fa-solid fa-book-open", Title = "Library", Description = "A vast collection of books, journals and reference material." },
            new Highlight { Icon = "fa-solid fa-futbol", Title = "Sports", Description = "Dedicated sports ground and coaching for physical development." },
            new Highlight { Icon = "fa-solid fa-shield-halved", Title = "Safe Campus", Description = "CCTV-monitored, secure campus with trained support staff." },
        };

        public static List<ReasonItem> WhyChooseUs => new()
        {
            new ReasonItem { Icon = "fa-solid fa-graduation-cap", Title = "Holistic Education", Description = "Focus on academics, sports, arts and moral values together." },
            new ReasonItem { Icon = "fa-solid fa-user-shield", Title = "Safety First", Description = "Secure transport, CCTV surveillance and trained staff on campus." },
            new ReasonItem { Icon = "fa-solid fa-chart-line", Title = "Consistent Results", Description = "Excellent academic track record year after year." },
            new ReasonItem { Icon = "fa-solid fa-people-group", Title = "Low Student-Teacher Ratio", Description = "Personal attention to every child in every classroom." },
            new ReasonItem { Icon = "fa-solid fa-hand-holding-heart", Title = "Value-Based Learning", Description = "Building character, discipline and confidence in students." },
            new ReasonItem { Icon = "fa-solid fa-bus", Title = "Transport Facility", Description = "Safe and reliable school bus service across Sangam Vihar & nearby areas." },
        };

        public static List<Testimonial> Testimonials => new()
        {
            new Testimonial { Name = "Sunita Sharma", Role = "Parent of Class 5 Student", Message = "Vikram Public School has truly shaped my daughter's confidence. The teachers are caring and always approachable.", ImageUrl = "/images/gallery-preview1.svg", Rating = 5 },
            new Testimonial { Name = "Rajesh Kumar", Role = "Parent of Class 8 Student", Message = "The smart classrooms and regular parent-teacher meetings keep us well informed about our son's progress.", ImageUrl = "/images/gallery-preview2.svg", Rating = 5 },
            new Testimonial { Name = "Anjali Verma", Role = "Alumna, Batch of 2019", Message = "I owe my discipline and love for learning to this school. The teachers still guide me even after graduating.", ImageUrl = "/images/gallery-preview3.svg", Rating = 4 },
            new Testimonial { Name = "Deepak Yadav", Role = "Parent of Class 2 Student", Message = "A genuinely safe and nurturing environment for young children. Highly recommended for primary admissions.", ImageUrl = "/images/gallery-preview4.svg", Rating = 5 },
        };

        public static List<NewsItem> LatestNews => new()
        {
            new NewsItem { Title = "Admissions Open for Session 2026-27", Date = "20 July 2026", Description = "Admissions are now open for Nursery to Class 5. Limited seats available.", Icon = "fa-solid fa-bullhorn" },
            new NewsItem { Title = "Annual Sports Day Celebrated", Date = "12 July 2026", Description = "Students participated with great enthusiasm in track and field events.", Icon = "fa-solid fa-medal" },
            new NewsItem { Title = "Independence Day Celebrations", Date = "15 August 2025", Description = "Flag hoisting ceremony followed by cultural performances by students.", Icon = "fa-solid fa-flag" },
            new NewsItem { Title = "Annual Function 'Utsav 2025'", Date = "20 December 2025", Description = "A vibrant evening of dance, drama and music performed by our students.", Icon = "fa-solid fa-star" },
        };

        public static List<GalleryImage> GalleryImages => new()
        {
            new GalleryImage { ImageUrl = "/images/gallery-building.jpg", Title = "School Building", Category = "Campus" },
            new GalleryImage { ImageUrl = "/images/gallery-classroom.jpg", Title = "Smart Classroom", Category = "Academics" },
            new GalleryImage { ImageUrl = "/images/gallery-library.jpg", Title = "Library", Category = "Academics" },
            new GalleryImage { ImageUrl = "/images/gallery-computerlab.jpg", Title = "Computer Lab", Category = "Academics" },
            new GalleryImage { ImageUrl = "/images/gallery-sciencelab.jpg", Title = "Science Lab", Category = "Academics" },
            new GalleryImage { ImageUrl = "/images/gallery-sports.jpg", Title = "Sports Ground", Category = "Sports" },
            new GalleryImage { ImageUrl = "/images/gallery-annualfunction.jpg", Title = "Annual Function", Category = "Events" },
            new GalleryImage { ImageUrl = "/images/gallery-independenceday.jpg", Title = "Independence Day", Category = "Events" },
            new GalleryImage { ImageUrl = "/images/gallery-republicday.jpg", Title = "Republic Day", Category = "Events" },
        };

        public static List<FacilityItem> Facilities => new()
        {
            new FacilityItem { Icon = "fa-solid fa-chalkboard", Title = "Smart Classrooms", Description = "Interactive boards and digital content in every classroom." },
            new FacilityItem { Icon = "fa-solid fa-flask", Title = "Science Laboratories", Description = "Separate labs for Physics, Chemistry and Biology." },
            new FacilityItem { Icon = "fa-solid fa-computer", Title = "Computer Lab", Description = "Modern systems with high-speed internet access." },
            new FacilityItem { Icon = "fa-solid fa-book", Title = "Library", Description = "Over 5,000 books, magazines and reference material." },
            new FacilityItem { Icon = "fa-solid fa-futbol", Title = "Sports Ground", Description = "Space for athletics, cricket, football and yoga." },
            new FacilityItem { Icon = "fa-solid fa-bus", Title = "Transport", Description = "GPS-enabled school buses covering nearby localities." },
            new FacilityItem { Icon = "fa-solid fa-briefcase-medical", Title = "Medical Room", Description = "First-aid facility with a visiting doctor on campus." },
            new FacilityItem { Icon = "fa-solid fa-utensils", Title = "Canteen", Description = "Hygienic canteen offering healthy meals and snacks." },
        };

        public static List<AchievementItem> Achievements => new()
        {
            new AchievementItem { Title = "100% Promotion Result Every Year", Description = "Consistent, strong academic performance across Nursery to Class 5.", Year = "2025" },
            new AchievementItem { Title = "Zonal Level Sports Meet - Runners Up", Description = "Students represented the school in inter-school athletics events.", Year = "2025" },
            new AchievementItem { Title = "Appreciated for Co-Curricular Excellence", Description = "Recognized within Sangam Vihar for annual function and cultural performances.", Year = "2024" },
            new AchievementItem { Title = "Inter-School Drawing & Craft Competition Winners", Description = "Primary students won prizes for creativity at a local-level competition.", Year = "2023" },
        };

        public static List<TimingItem> SchoolTimings => new()
        {
            new TimingItem { Day = "Monday - Friday", Time = "8:00 AM - 2:30 PM" },
            new TimingItem { Day = "Saturday", Time = "8:00 AM - 12:30 PM" },
            new TimingItem { Day = "Sunday", Time = "Closed" },
            new TimingItem { Day = "Office Hours", Time = "9:00 AM - 4:00 PM (Mon - Sat)" },
        };

        public static List<AdmissionStep> AdmissionSteps => new()
        {
            new AdmissionStep { StepNumber = 1, Title = "Enquiry", Description = "Visit the school office or call us to raise an admission enquiry.", Icon = "fa-solid fa-magnifying-glass" },
            new AdmissionStep { StepNumber = 2, Title = "Form Submission", Description = "Collect and submit the duly filled admission form with documents.", Icon = "fa-solid fa-file-lines" },
            new AdmissionStep { StepNumber = 3, Title = "Interaction", Description = "A short, friendly interaction with the child and parents.", Icon = "fa-solid fa-comments" },
            new AdmissionStep { StepNumber = 4, Title = "Confirmation", Description = "Seat confirmation on payment of admission fee.", Icon = "fa-solid fa-circle-check" },
        };

        public static List<ClassInfo> ClassesOffered => new()
        {
            new ClassInfo { ClassName = "Nursery - UKG", AgeGroup = "3 - 5 Years", Seats = "Limited Seats" },
            new ClassInfo { ClassName = "Class 1 - 2", AgeGroup = "6 - 7 Years", Seats = "Limited Seats" },
            new ClassInfo { ClassName = "Class 3 - 4", AgeGroup = "8 - 9 Years", Seats = "Few Seats Available" },
            new ClassInfo { ClassName = "Class 5", AgeGroup = "10 Years", Seats = "Few Seats Available" },
        };
    }
}
