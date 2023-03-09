using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_QL_KTX
{
    public class DanhSachTaiKhoan
    {
        private static DanhSachTaiKhoan instance;

        public static DanhSachTaiKhoan Instance 
        {
            get
            {
                if( instance==null)
                        instance = new DanhSachTaiKhoan();
                return instance;
            }
                
            set => instance = value;
        }

        List<TaiKhoan> listTaiKhoan;

        public List<TaiKhoan> ListTaiKhoan
        { 
            get => listTaiKhoan;
            set => listTaiKhoan = value;
        }
       

        DanhSachTaiKhoan()
        {
            listTaiKhoan = new List<TaiKhoan>();
            listTaiKhoan.Add(new TaiKhoan("Pham Van A", "123456"));
            listTaiKhoan.Add(new TaiKhoan("Nguyen Van B", "654321"));
            listTaiKhoan.Add(new TaiKhoan("Tran Ngoc C", "111111"));
        }
    }
}
