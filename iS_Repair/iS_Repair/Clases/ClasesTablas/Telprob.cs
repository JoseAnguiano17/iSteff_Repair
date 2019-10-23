using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iS_Repair.Clases.ClasesTablas
{
    public class Telprob
    {
        private int _intId;

        public int ID
        {
            get { return _intId; }
            set { _intId = value; }
        }

        private Int16 _intIdProblema;

        public Int16 IDProblema
        {
            get { return _intIdProblema; }
            set { _intIdProblema = value; }
        }

        private DateTime _dtmFechaSolucion;

        public DateTime FechaSolucion
        {
            get { return _dtmFechaSolucion; }
            set { _dtmFechaSolucion = value; }
        }

        public Telprob(int intID, Int16 intIDP, DateTime dtmFechaS)
        {
            ID = intID;
            IDProblema = intIDP;
            FechaSolucion = dtmFechaS;
        }
    }
}
