using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Školní_Aplikace
{

    public class Uzel
    {
        Dictionary<Pointer, float> napojeni = new Dictionary<Pointer, float>();
        public Uzel()
        {
        }
        public void Connection(Pointer Connected_Uzel, float distance)
        {
            napojeni.Add(Connected_Uzel, distance);

        }


    }
}
