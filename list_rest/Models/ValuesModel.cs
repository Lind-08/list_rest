using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class ValuesModel
    {
        static ValuesModel instance;
        List<string> values;

        ValuesModel()
        {
            values = new List<string>();
        }

        public static ValuesModel GetModel()
        {
            if (instance == null)
                instance = new ValuesModel();
            return instance;
        }

        public string[] GetValues()
        {
            return values.ToArray();
        }

        public string GetValue(int id)
        {
            return values.ElementAtOrDefault(id);
        }

        public void AddValue(string value)
        {
            values.Add(value);
        }

        public void AddValue(int id, string value)
        {
            values.Insert(id, value);
        }

        public void DeleteValue(int id)
        {
            values.RemoveAt(id);
        }
    }
}
