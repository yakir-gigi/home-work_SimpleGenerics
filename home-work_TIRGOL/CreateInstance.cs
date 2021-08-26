using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace home_work_TIRGOL
{
    class CreateInstance<T> where T : new()
    {
        public T Instance { get; set; }

        public CreateInstance()
        {
            Instance = new T();
        
        
        }
    }
}
