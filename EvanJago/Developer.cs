using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvanJago
{
    public class Developer
    {
        private string nama;
        private string proyek;
        private string status;
        private string fitur;
        private string bug;
        public string Nama { get { return nama; } set { nama = value; } }
        public string Proyek { get { return proyek; } set { proyek = value; } }
        public string Status { get { return status; } set { status = value; } }
        public string Fitur { get { return fitur; } set { fitur = value; } }
        public string Bug { get { return bug; } set { bug = value; } }
            
    }
}
