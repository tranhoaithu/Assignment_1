using System;
using System.Collections.Generic;
using System.Text;

namespace BigAssignment1.Controller
{
    class GenericController<T> : BaseController
    {
        public T GetById(string id, List<T> lst)
        {
            foreach (T ob in lst)
            {
                if (ob.ToString() == id) return ob;
            }
            return default(T);
        }
    }
}
