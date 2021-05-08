using System;
using System.Collections.Generic;
using System.Text;

namespace MyDicrionary
{
    class MyDictionary<Tkey,Tvalue>
    {
        Tkey[] keys;
        Tvalue[] values;
        public MyDictionary()
        {
            keys = new Tkey[0];
            values = new Tvalue[0];
        }
        public void Add(Tkey key,Tvalue value) 
        {
            Tkey[] tempkey = keys;
            Tvalue[] tempvalue = values;
            keys = new Tkey[keys.Length + 1];
            values = new Tvalue[values.Length + 1];

            for (int i = 0; i < tempkey.Length; i++)
            {
                keys[i] = tempkey[i];
                values[i] = tempvalue[i];
            }
            keys[keys.Length - 1] = key;
            values[values.Length - 1] = value;
        }
        public void Show() 
        {
            for (int i = 0; i < keys.Length; i++)
            {
                Console.WriteLine(keys[i]+" , "+values[i]);
            } 
        }
    }
}
