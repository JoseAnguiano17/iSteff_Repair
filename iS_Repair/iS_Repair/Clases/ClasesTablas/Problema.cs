﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iS_Repair.Clases.ClasesTablas
{
    public class Problema
    {
        private Int16 _intId;

        public Int16 ID
        {
            get { return _intId; }
            set { _intId = value; }
        }

        private double _dblCosto;

        public double Costo
        {
            get { return _dblCosto; }
            set { _dblCosto = value; }
        }

        private string _strDescripcion;

        public string Descripcion
        {
            get { return _strDescripcion; }
            set { _strDescripcion = value; }
        }

        public Problema(Int16 intID, string strDescrip, double dblCosto)
        {
            ID = intID;
            Descripcion = strDescrip;
            Costo = dblCosto;
        }
    }
}
