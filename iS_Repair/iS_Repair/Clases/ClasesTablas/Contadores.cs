using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iS_Repair.Clases.ClasesTablas
{
    public class Contadores
    {
        public Contadores(int cliente,int telefono,int problema, int pendiente, int pedido)
        {
            _intIdCliente = cliente;
            _intIdTelefono = telefono;
            _intIdProblema = problema;
            _intIdPendiente = pendiente;
            _intIdPedido = pedido;
        }

        private int _intIdCliente;

        public string Id_Cliente {
            get { return (DateTime.Now.Year).ToString().Substring(2,2) + String.Format("{0:0000}", _intIdCliente); }
        }

        private int _intIdTelefono;

        public string Id_Telefono {
            get { return String.Format("{0:00000}", _intIdTelefono); }
        }

        private int _intIdProblema;

        public string Id_Problema {
            get { return String.Format("{0:000000}", _intIdProblema); }
        }

        private int _intIdPendiente;

        public string Id_Pendiente {
            get { return String.Format("{0:00000}", _intIdPendiente); }
        }

        private int _intIdPedido;

        public string Id_Pedido {
            get { return String.Format("{0:000000}", _intIdPedido); }
        }
    }
}
