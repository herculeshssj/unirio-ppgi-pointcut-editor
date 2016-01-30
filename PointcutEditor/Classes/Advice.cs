using System.Collections.Generic;

namespace PointcutEditor
{
    class Advice
    {
        private string _name;
        private string _process;
        private string _goal;

        private List<Pointcut> _pointcuts = new List<Pointcut>();

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                this._name = value;
            }
        }

        public string Process
        {
            get
            {
                return _process;
            }
            set
            {
                this._process = value;
            }
        }

        public string Goal
        {
            get
            {
                return _goal;
            }
            set
            {
                this._goal = value;
            }
        }


        public List<Pointcut> Pointcuts
        {
            get
            {
                return _pointcuts;
            }
            set
            {
                this._pointcuts = value;
            }
        }

        public Advice()
        {
        }

        public Advice(string name, string process, string goal)
        {
            this.Name = name;
            this.Process = process;
            this.Goal = goal;
        }

        public void addPointcut(Pointcut pointcut)
        {
            _pointcuts.Add(pointcut);
        }

        public void removePointcut(Pointcut pointcut)
        {
            _pointcuts.Remove(pointcut);
        }
    }
}
