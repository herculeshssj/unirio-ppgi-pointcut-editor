namespace PointcutEditor
{
    class Pointcut
    {
        private string _process;
        private string _task;
        private string _condition;

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

        public string Task
        {
            get
            {
                return _task;
            }
            set
            {
                this._task = value;
            }
        }

        public string Condition
        {
            get
            {
                return _condition;
            }
            set
            {
                this._condition = value;
            }
        }

        public Pointcut()
        {
        }

        public Pointcut(string process, string task, string condition)
        {
            this.Process = process;
            this.Task = task;
            this.Condition = condition;
        }
    }
}
