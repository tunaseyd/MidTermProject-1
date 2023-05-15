using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.DATAS
{
    internal class MovieDatas
    {
        public virtual int Id { get; set; }
        public virtual string MName { get; set; }
        public virtual DateTime MDate { get; set; }
        public virtual string Icerik { get; set; }
        public virtual string OgretimGorevlisi { get; set; }
    }
}
