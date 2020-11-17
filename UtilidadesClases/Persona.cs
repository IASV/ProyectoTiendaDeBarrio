﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UtilidadesClases
{
    public class Persona
    {
        public long Cedula
        {
            get;
            set;
        }

        public string Nombre
        {
            get;
            set;
        }

        public DateTime FechaNacimiento
        {
            get;
            set;
        }

        public Sexo Sexo
        {
            get;
            set;
        }

        public long Telefono
        {
            get;
            set;
        }

        public string Correo
        {
            get;
            set;
        }

        public string Direccion
        {
            get;
            set;
        }

        public EstadoCivil EstadoCivil
        {
            get;
            set;
        }
    }
}