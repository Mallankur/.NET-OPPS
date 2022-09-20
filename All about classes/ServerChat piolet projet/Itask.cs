using System.Collections.Generic;

namespace ServerChat_piolet_projet
{


   public  interface Itask
    {
        void Execute();
    }
    public interface IWorkflow
    {
        void Add(Itask task);
        void Remove(Itask task);
    }

    public class Workflow : IWorkflow
    {
        private readonly List<Itask> _tasks= new List<Itask>();

        
        public Workflow(List<Itask> tasks)
        {
            _tasks = tasks;
        }

        public void Add(Itask task)
        {
            
                _tasks.Add(task);
        }

        public void Remove(Itask task)
        {
            _tasks.Remove(task);
        }
    }
}
