using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestFulWeb.MODELS
{
    public class CommonParameters<T>
    {
        public string ValidateData
        {
            get;
            set;
        }
        public T Paras
        {
            get;
            set;
        }
    }
}
