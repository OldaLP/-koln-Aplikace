using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Školní_Aplikace
{

    public class Uzel
    {
        Dictionary<Uzel, float> Sousedi;
        public String jmeno;
        public Uzel()
        {
            Dictionary<Uzel, float> napojeni = new Dictionary<Uzel, float>();
            jmeno = "unknown";
        }
        public Uzel(string name)
        {
            Dictionary<Uzel, float> napojeni = new Dictionary<Uzel, float>();
            jmeno = name;
        }

        //pripojit jednoho souseda v dane vzdalenosti
        public void ConnectUzel(Uzel Connected_Uzel, float distance)
        {
            Sousedi.Add(Connected_Uzel, distance);

        }
    }


}
