using System;
using System.Collections.Generic;
using System.Text;

namespace Dictionary
{
    class MyDictionary <_key, _value> : Dictionary<_key, _value>
    {
        _key[] keys;
        _value[] values;

        // Constructor
        public MyDictionary()
        {
            keys = new _key[0];
            values = new _value[0];
        }

        
        public void Add(_key key, _value value)
        {
            _key[] tempKey = keys;
            _value[] tempValue = values;

            keys = new _key[keys.Length + 1];
            values = new _value[values.Length + 1];

            for (int i = 0; i < tempKey.Length; i++)
            {
                keys[i] = tempKey[i];
            }

            for (int i = 0; i < tempValue.Length; i++)
            {
                values[i] = tempValue[i];
            }

            keys[keys.Length - 1] = key;
            values[values.Length - 1] = value;
        }

        public _key[] Keys
        {
            get { return keys;  }
        }

        public _value[] Values
        {
            get { return values; }
        }
    }
}
