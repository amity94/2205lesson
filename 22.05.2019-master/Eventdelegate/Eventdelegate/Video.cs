namespace Eventdelegate
{
    public class Video
    {
        public string Title { get; set; }

        public Video(string title)
        {
            Title = title;
        }

        public override string ToString()
        {
            return this.Title;
        }
    }
}