using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace N13310005
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int[] numbers = new int[10];
                numbers[0]=1;
                numbers[2]=2;
                MessageBox.Show(numbers[10].ToString());
                int a = Int32.Parse(textBox1.Text);
                int B = Int32.Parse(textBox2.Text);
                int sum = a+B;
                label3.Text = (a + B).ToString();
            }
            catch (System.FormatException ex)

            {

                MessageBox.Show(ex.Message+" 輸入的不可以是標點符號,請輸入整數");

            }
            catch (IndexOutOfRangeException ex)
            {
                MessageBox.Show(ex.Message+"你宣告的陣列爆掉拉");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message+"你輸入的有問題 但我不知道錯在哪");
            }
        }
    }
}       

        
            
           
        


        
   

