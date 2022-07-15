using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TutekDirask
{
    enum TaskStatus
    {
        Waiting,
        Progress,
        Done,
        Rejected
    }

    class Task : IEquatable<Task>
    {
        private string name;
        private TaskStatus status;
        public string Name { get => name; }
        public TaskStatus Status 
        { 
            get => status;
            set => this.status = value;
        }

        public Task(string name, TaskStatus status)
        {
            this.name = name;
            this.status = status;
        }

        public override string ToString()
        {
            return this.Name + " [" + this.Status.ToString() + "]";
        }

        public bool Equals(Task other)
        {
            return this.Name == other.Name && this.Status == other.Status;
        }
    }
}
