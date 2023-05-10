namespace Grimoire.Models.Domain
{
    public class MyGrimoire
    {
        public  Guid Id { get; set; }
        public string Heading{ get; set; }
        public string shortdescription { get; set; }
        public string Content { get; set; }
        public string ImgUrl { get; set; }
        public string Urlhandle { get; set; }
        public DateTime Released { get; set; }
        public bool Visible { get; set; }
    }
}
