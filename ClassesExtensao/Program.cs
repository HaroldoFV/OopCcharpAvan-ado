using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ClassesExtensao
{
    public static class DataSetExtension
    {
        public static void WriteJSON(this DataSet ds, string fileName)
        {
            //ds
        }

        // Injetando método  "ToUrl" na classe string
        public static string ToUrl(this string str)
        {
            return str = "http://" + str;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //DataSet ds = new DataSet();
            //ds.WriteXml("dados.xml");
            //ds.WriteJSON("dados.js");
            //ds.WriteXml("dados.xml");

            string url = "guintherpauli.blogspot.com";
            Console.WriteLine(url.ToUrl());
            Console.ReadLine();
        }
    }
}
