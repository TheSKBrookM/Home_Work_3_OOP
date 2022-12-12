using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work_3_3
{
    class DocumentWorker
    {

        public void OpenDocument()
        {
            Console.WriteLine("Документ вiдкритий");
        }
        public virtual void EditDocument()
        {
            Console.WriteLine("Редагування документа є у версiї Про");
        }
        public virtual void SaveDocument()
        {
            Console.WriteLine("Збереження документа є у версiї Про");
        }
    }
}
