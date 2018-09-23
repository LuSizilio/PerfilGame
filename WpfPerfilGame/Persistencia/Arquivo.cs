using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Persistencia
{
    public class Arquivo<T> where T : new()
    {
        private string arquivo;
        public Arquivo(string arquivo)
        {
            this.arquivo = arquivo;
        }
        public void Salvar(T obj)
        {
            XmlSerializer xml = new XmlSerializer(typeof(T));
            using (StreamWriter f = new StreamWriter(arquivo, false, Encoding.Default))
                xml.Serialize(f, obj);
        }
        public T Abrir()
        {
            T obj;
            try
            {
                XmlSerializer xml = new XmlSerializer(typeof(T));
                using (StreamReader f = new StreamReader(arquivo, Encoding.Default))
                    obj = (T)xml.Deserialize(f);
            }
            catch
            {
                obj = new T();
            }
            return obj;
        }
    }
}
