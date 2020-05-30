using System;
using System.Collections.Generic;
using System.Text;

namespace School
{
    public class Laboratory
    {
        private String name;
        private bool working;

        public Laboratory(String name)
        {
            this.name = name;
            working = true;
        }

        public void FinishWork()
        {
            working = false;
        }

        public void StartWork()
        {
            working = true;
        }
        public bool IsWorking()
        {
            return working;
        }
        public String Name()
        {
            return name;
        }
        public void Name(String name)
        {
            this.name = name;
        }
    }
}
