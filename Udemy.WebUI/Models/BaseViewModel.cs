using Udemy.Business.Abstract;
using Udemy.Entity.Concrete;

namespace Udemy.WebUI.Models
{
    public class BaseViewModel
    {
        public List<Category> Categories { get; set; }
        public List<SubCategory> SubCategories { get; set; }
        public List<Topic> Topics { get; set; }
        public List<Course> Courses { get; set; }
        public List<Teacher> Teachers { get; set; }
        public List<ObjectiveAndOutcomes> ObjectiveAndOutcomes { get; set; }
        public List<Requirement> Requirements { get; set; }
        public List<Video> Videos { get; set; }

    }
}
