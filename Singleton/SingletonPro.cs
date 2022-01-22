using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    class SingletonPro
      {
        private static SingletonPro instancia;

        private SingletonPro() { }

        public static SingletonPro ObtenerInstancia()
        {
            if (instancia == null)
                instancia = new SingletonPro();

            return instancia;
        }
    }
}
