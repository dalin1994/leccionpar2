using System;
using System.Collections.Generic;
using System.Text;

namespace leccionparcial2
{
    interface IComponente
    {
        //usaremos esta interfas para la decoracion "diseño"
        double Costo();
        string Funciona();
    }
}
