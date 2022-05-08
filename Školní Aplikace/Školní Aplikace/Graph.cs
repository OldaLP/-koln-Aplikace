using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Školní_Aplikace
{

    public class Uzel
    {
        List<Connector> napojeni;
        public Uzel()
        {
            napojeni = new List<Connector>();
        }
        public void Connection(Pointer Connected_Uzel, float distance)
        {
            Connector conection = new Connector(Connected_Uzel,distance);
            napojeni.Add(conection);

        }
    }

    public class Connector
    {
        public Connector(Pointer Connection, float distance)
        {
            Pointer pointer = Connection;
            float distanceX = distance;


        }
    }



}
