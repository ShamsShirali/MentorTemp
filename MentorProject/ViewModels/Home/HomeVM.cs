using MentorProject.Models;

namespace MentorProject.ViewModels.Home
{
    public class HomeVM
    {
        public IEnumerable<Trainer> Trainers { get; set; }
        public IEnumerable<Course> Courses { get; set; }
    }
}
