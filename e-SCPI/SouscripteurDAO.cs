﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using model;
namespace dao
{
    public interface SouscripteurDAO
    {
         void Add(Souscripteur e);
        List<Souscripteur> GetAllSouscripteur();
        void AddPart(Part p, int id);
        Souscripteur getSouscripteurByID(int id);
    }
}