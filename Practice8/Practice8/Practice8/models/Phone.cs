using System;
using System.Collections.Generic;
using System.Text;

namespace Practice8.models
{
    abstract class Phone
    {
        
        public long Number { get; set; }

        public abstract void Call();
        public abstract void AcceptCall();

        public abstract void Characteristics();
      
    }
}
