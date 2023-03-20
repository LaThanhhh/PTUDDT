using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02
{
    public delegate int SoSanh(object a, object b);
    public class QuanLyGiaoVien
    {
        List<GiaoVien> dsGiaoVien;
        public QuanLyGiaoVien()
        { 
            
        }
        // them
        public void Them( GiaoVien gv)
        {
            this.dsGiaoVien.Add(gv);
        }
        public GiaoVien this[int index]
        {
            get { return dsGiaoVien[index] as GiaoVien; }
            set { dsGiaoVien[index] = value; }
        }
        //Tim
        public GiaoVien Tim(object obj, SoSanh ss)
        {
            GiaoVien svresult = null;
            foreach(GiaoVien gv in dsGiaoVien)
                if (ss(obj, gv)==0)
                {
                    svresult = gv;
                    break;
                }
            return svresult;
        }

        //xoa
        public void Xoa(object temp, SoSanh ss)
        {
            int i = dsGiaoVien.Count - 1;
            for (; i >= 0; i--)
                if (ss(temp, this[i]) == 0)
                    this.dsGiaoVien.RemoveAt(i);
        }
       
     
    }
}
