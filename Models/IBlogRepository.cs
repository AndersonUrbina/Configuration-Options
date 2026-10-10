using Configuration_Options.Models;

namespace Configuration_Options.Models
{
    public interface IBlogRepository
    {
        IEnumerable<Post> GetAll();
        Post GetById(int id);
        void Add(Post post);
        void Save();
    }
}
