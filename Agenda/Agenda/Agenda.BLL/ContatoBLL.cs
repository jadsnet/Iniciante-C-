﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Agenda.DAL;
using Agenda.DTO;

namespace Agenda.BLL
{
    public class ContatoBLL
    {
        public static void InserirContato(Contato objContato)
        {
            //if (objContato.Nome == "")

            ContatoDAL.InserirContato(objContato);
        }
    }
}
