namespace ConsoleApp1
{
    internal partial class Program
    {
        public class point
        {
           public  int x;
            public int y;
            public point(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
            public void Move(int x , int y)
            {
                this.x=x;
                this.y=y;
            }
            public void Move(point newLoaction)
            {
                this.x=newLoaction.x;
                this.y=newLoaction.y;   
            }
        }
    }
}
