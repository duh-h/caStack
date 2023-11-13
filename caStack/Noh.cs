using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caStack
{
    internal class Noh<T>
    {
        public T info { get; set; }
        public Noh<T> proximo { get; set; }

        public Noh<T> anterior { get; set; }

        public Noh(T info)
        {
            this.info = info;
            this.proximo = null;
            this.anterior = null;
        }


    }
}
