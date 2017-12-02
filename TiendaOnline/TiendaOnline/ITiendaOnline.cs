using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace TiendaOnline
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "ITiendaOnline" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface ITiendaOnline
    {
        [OperationContract]
        void DoWork();
    }
}
