using System.Collections.Generic;

namespace PointcutEditor
{
    class Aspect
    {
        private string _name;

        private List<Advice> _advices = new List<Advice>();

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

        public List<Advice> Advices
        {
            get
            {
                return _advices;
            }
            set
            {
                this._advices = value;
            }
        }

        public Aspect()
        {
        }

        public Aspect(string name)
        {
            this.Name = name;
        }

        public void addAdvice(Advice advice)
        {
            _advices.Add(advice);
        }

        public void removeAdvice(Advice advice)
        {
            _advices.Remove(advice);
        }
    }
}
