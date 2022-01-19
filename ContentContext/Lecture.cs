using Balta.ContentContext.Enums;

namespace Balta.ContentContext
{
    public class Lecture
    {
        public Lecture(string title)
        {
            Title = title;
        }
        public int Ordem { get; set; }
        public string Title { get; set; }
        public int DurationInMinutes { get; set; }
        public EContentLevel Level { get; set; }
    }
}
