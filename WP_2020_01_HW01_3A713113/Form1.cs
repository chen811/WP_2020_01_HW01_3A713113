using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;


namespace WP_2020_01_HW01_3A713113
{
    public partial class Form1 : Form
    {
       // MD5 md5 = MD5.Create();//建立一個MD5
        

        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            string input_str = tex.Text;
            //轉換int 
            //int input_int = int.Parse(input_str);

            MD5 md5 = new MD5CryptoServiceProvider();

            byte[] source = Encoding.Default.GetBytes(tex.Text);//將字串轉為Byte[]
            byte[] crypto = md5.ComputeHash(source);//進行MD5加密
            string result = Convert.ToBase64String(crypto);//把加密後的字串從Byte[]轉為字串
            //Response.Write("MD5加密:  " + result);//輸出結果
            rtb1.Text= "輸出結果:  " + result;//輸出結果




        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
