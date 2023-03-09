using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_QL_KTX
{
    public class TaiKhoan
    {
       //private string typeAccount;
       //public string TypeAccount 
       //{ 
       //    get => typeAccount; 
       //    set => typeAccount = value;
       //}

        private string userName;
        public string UserName 
        { 
            get => userName;
            set => userName = value;
        }
        
        private string passWord;
        public string PassWord 
        { 
            get => passWord; 
            set => passWord = value; 
        }
        

        public TaiKhoan(string user_name, string pass_word)
        {
            this.userName = user_name;
            this.PassWord = pass_word;
        }

    }
}
