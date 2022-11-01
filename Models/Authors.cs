namespace Tuns_Bianca_Lab2.Models
{
    public class Authors
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string FullName
        {

            get
            {
                return FirstName + " " + LastName;
            }
        }
        public ICollection<Book>? Book { get; set; }
    }
}
