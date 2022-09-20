namespace ServerChat_piolet_projet
{
    class student
    {
        public int id { get; set; }
        public string name { get; set; }
        public int GPA { get; set; }




        public student(int Id, string name,  int gPA)
        {
            this.id = id;
            this.name = name;
           
            GPA = gPA;
        }
    }


}
