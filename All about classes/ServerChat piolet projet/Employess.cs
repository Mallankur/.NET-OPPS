namespace ServerChat_piolet_projet
{
    public class Employess
    {
        public string Role { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public float Rate { get; set; }
        
        public float Salary
        {
            get { return Rate * 8 * 5 * 4 * 12; }
        }

        public Employess(string role, string name ,int age,float rate)
        {
            this.Role = role;
            this.Name = name;
            this.Age = age;
            this.Rate= rate;
            

        }

    }


}
