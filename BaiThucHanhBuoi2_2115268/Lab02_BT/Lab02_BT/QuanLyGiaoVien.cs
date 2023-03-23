using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02_BT
{
    public delegate int SoSanh(object a, object b);
    class QuanLyGiaoVien
    {
        public List<GiaoVien> dsGiaoVien;
        public GiaoVien this[int index]
        {
            get { return dsGiaoVien[index]; }
            set { dsGiaoVien[index] = value; }
        }
        public QuanLyGiaoVien()
        {
            dsGiaoVien = new List<GiaoVien>();
        }
    
        public void Them( GiaoVien gv)
        {
            this.dsGiaoVien.Add(gv);
        }
        public GiaoVien Tim( object temp, SoSanh ss)
        {
            GiaoVien svresult = null;
            foreach( GiaoVien gv in dsGiaoVien)
                if ( ss(temp, gv)==0)
                {
                    svresult = gv;
                    break;
                }
            return svresult;
        }
        public void Xoa(object temp, SoSanh ss)
        {
            int i = dsGiaoVien.Count - 1;
            for (; i >= 0; i--)
                if (ss(temp, this[i]) == 0)
                    this.dsGiaoVien.RemoveAt(i);
        }
    }

    internal class dsGiaoVien
    {
    }
}
