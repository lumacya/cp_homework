using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace NumbersGame

{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static private int rand = new Random().Next(101);
   
        bool rights = false;

        private void button1_Click(object sender, EventArgs e)
        {
            
            
            if (string.IsNullOrWhiteSpace(write_number.Text) != null && !rights);
            {
                
                Int32.TryParse(write_number.Text,out int writer_num);

               if (rand == writer_num)
                {
                    Result.Text = "Vi ygadali";
                    rights = true;
                }
               else if (rand > writer_num)
                {
                    Result.Text = "Bolishe";
                    write_number.Text = null;
                }
                else if (rand < writer_num)
                {
                    Result.Text = "Menshe";
                    write_number.Text = null;
                }
            }
                
            
        }
    }
}
