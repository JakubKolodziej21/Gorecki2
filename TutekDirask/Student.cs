using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TutekDirask
{
    class Student : Person, IEquatable<Student>
    {
        protected string group;
        public string Group { get => group; }

        protected List<Task> tasks = new List<Task>();

        public Student(string name, int age, string group) : base(name, age)
        {
            this.group = group;
        }

        public Student(string name, int age, string group, List<Task> tasks) : base(name, age)
        {
            this.group = group;
            this.tasks = tasks;
        }

        public void AddTask(string taskName, TaskStatus taskStatus)
        {
            Task newTask = new Task(taskName, taskStatus);
            this.tasks.Add(newTask);
        }

        public void UpdateTask(int index, TaskStatus taskStatus)
        {
            this.tasks[index].Status = taskStatus;
        }

        public void RemoveTask(int index)
        {
            this.tasks.RemoveAt(index);
        }

        public string RenderTasks(string prefix = "\t")
        {
            string result = "";
            for(int i=0;i<tasks.Count;i++)
            {
                result += prefix + (i+1) + ". " + tasks[i].ToString() + "\n";
            }
            foreach(Task t in tasks)
            {
                
            }
            return result;
        }

        public override string ToString()
        {
            return "Student: " + base.ToString() + "\nGroup: " + this.Group + "\nTasks: \n" + this.RenderTasks();
        }

        public bool Equals(Student other)
        {
            return base.Equals(other) && this.Group == other.Group && SequenceEquals(this.tasks, other.tasks);
        }

        private bool SequenceEquals(List<Task> a, List<Task> b)
        {
            if (a.Count != b.Count) return false;

            for(int i=0;i<a.Count;i++)
            {
                if(a[i].Equals(b[i]) == false)
                {
                    return false;
                }
            }
            return true;
        }

    }
}
