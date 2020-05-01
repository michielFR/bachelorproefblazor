namespace BachelorproefBlazor.Models
{
    public class Picture
    {
        public int Id { get; set; }

        public Camera Camera { get; set; }

        public string Img_src { get; set; }

        public string Earth_date { get; set; }

        public Rover Rover { get; set; }
    }
}
