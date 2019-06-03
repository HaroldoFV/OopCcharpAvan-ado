using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Reflexao
{
    class Program
    {
        static void Main(string[] args)
        {
            Type t = typeof(Carro);
            GetParametros(t);
            Console.ReadLine();
        }

        private static void GetParametros(Type t)
        {
            Console.WriteLine("Parâmetros:");
            MethodInfo[] mi = t.GetMethods();
            foreach (var m in mi)
            {
                string resultado = m.ReturnType.FullName;
                StringBuilder str = new StringBuilder();
                foreach (ParameterInfo pi in m.GetParameters())
                {
                    str.AppendLine(string.Format("{0} {1}", pi.ParameterType, pi.Name));
                }
                Console.WriteLine("{0} {1} {2}", resultado, m.Name, str);
            }
        }

        private static void Exemplo7()
        {
            Type t = typeof(Carro);
            GetInterfaces(t);
            Console.ReadLine();
        }

        private static void GetInterfaces(Type t)
        {
            Console.WriteLine("interfaces:");
            Type[] interfaces = t.GetInterfaces();
            foreach (var i in interfaces)
                Console.WriteLine(i.Name);
        }

        private static void Exemplo6()
        {
            Type t = typeof(Carro);
            GetCampos(t);
            GetPropriedades(t);
            Console.ReadLine();
        }

        private static void GetPropriedades(Type t)
        {
            Console.WriteLine("Campos:");
            FieldInfo[] fi = t.GetFields();
            foreach (var f in fi)
                Console.WriteLine(f.Name);
        }

        private static void GetCampos(Type t)
        {
            Console.WriteLine("Propriedades:");
            PropertyInfo[] pi = t.GetProperties();
            foreach (var p in pi)
                Console.WriteLine(p.Name);
        }


        private static void Exemplo5()
        {
            Type t = typeof(Carro);
            GetMetodo(t);
            GetMetodos(t);
            Console.ReadLine();
        }

        private static void GetMetodos(Type t)
        {
            Console.WriteLine("Métodos:");
            MethodInfo[] mi = t.GetMethods(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public);
            foreach (var m in mi)
                Console.WriteLine("Método: " + m.Name);
        }

        private static void GetMetodo(Type t)
        {
            MethodInfo mi = t.GetMethod("estaMovendo");
            Console.WriteLine(mi.Name);
        }

        private static void Exemplo4()
        {
            Type t = typeof(Carro);
            getPropriedades(t);
            Console.ReadLine();
        }

        private static void getPropriedades(Type t)
        {
            StringBuilder str = new StringBuilder();
            str.AppendLine("Informações do tipo: " + t.Name);
            str.AppendLine("Nome Completo: " + t.FullName);
            str.AppendLine("Namespace: " + t.Name);
            Type tBase = t.BaseType;
            if (tBase != null)
            {
                str.AppendLine("Tipo base: " + t.BaseType.Name);
            }
            MemberInfo[] membros = t.GetMembers();
            foreach (var m in membros)
            {
                str.AppendLine(m.MemberType + " " + m.Name);
            }
            Console.WriteLine(str);
        }

        private static void Exemplo3()
        {
            Type t = typeof(Carro);
            Console.WriteLine(t.FullName);
            Console.ReadLine();
        }

        private static void Exemplo2()
        {
            Type t = Type.GetType("Reflexao.Carro", false, true);
            Console.WriteLine(t.FullName);
            Console.ReadLine();
        }

        private static void Exempo1()
        {
            Carro c = new Carro();
            Type t = c.GetType();
            Console.WriteLine(t.FullName);
            Console.ReadLine();
        }
    }
}
