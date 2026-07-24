namespace VikramPublicSchool.Models
{
    // Represents a highlight / feature card shown on the Home page
    public class Highlight
    {
        public string Icon { get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
    }

    // Represents a parent / student testimonial
    public class Testimonial
    {
        public string Name { get; set; } = string.Empty;
        public string Role { get; set; } = string.Empty;
        public string Message { get; set; } = string.Empty;
        public string ImageUrl { get; set; } = string.Empty;
        public int Rating { get; set; }
    }

    // Represents a news / announcement item
    public class NewsItem
    {
        public string Title { get; set; } = string.Empty;
        public string Date { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Icon { get; set; } = string.Empty;
    }

    // Represents a single gallery image
    public class GalleryImage
    {
        public string ImageUrl { get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;
        public string Category { get; set; } = string.Empty;
    }

    // Represents a facility item shown on the About page
    public class FacilityItem
    {
        public string Icon { get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
    }

    // Represents a school achievement / milestone
    public class AchievementItem
    {
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Year { get; set; } = string.Empty;
    }

    // Represents a row in the school timing table
    public class TimingItem
    {
        public string Day { get; set; } = string.Empty;
        public string Time { get; set; } = string.Empty;
    }

    // Represents a "Why Choose Us" reason
    public class ReasonItem
    {
        public string Icon { get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
    }

    // UI-only model bound to the Contact page form (no backend persistence)
    public class ContactFormModel
    {
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public string? Message { get; set; }
    }

    // Represents an admission step shown on the Admission page
    public class AdmissionStep
    {
        public int StepNumber { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Icon { get; set; } = string.Empty;
    }

    // Represents a fee / class row shown on the Admission page
    public class ClassInfo
    {
        public string ClassName { get; set; } = string.Empty;
        public string AgeGroup { get; set; } = string.Empty;
        public string Seats { get; set; } = string.Empty;
    }
}
