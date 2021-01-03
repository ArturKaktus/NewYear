using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewYear
{
    public partial class Form1 : Form
    {
        /*В году (365): 31 536 000 сек
         *       (366): 31 622 000 сек
         */
        public Form1()
        {           
            InitializeComponent();
            // Название программы
            int year = DateTime.Now.Year;
            this.Text = ("New " + (year+1) + " year!!!");           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Процент
            double proc; //процент
            double sec = ((DateTime.Now.DayOfYear - 1) * 24 * 60 * 60) +
                (DateTime.Now.Hour * 60 * 60) +
                (DateTime.Now.Minute * 60) +
                DateTime.Now.Second;
            //проверка на високосность
            if (DateTime.Now.Year % 4 == 0)
            {
                proc = sec / (31622000 / 100);
            }
            else
            {
                proc = sec / (31536000 / 100);
            }
            label1.Text = (proc.ToString("##.#####") + "%");

            //ProgresBar
            progressBar1.Value = Convert.ToInt32(proc);

            //Осталось в секундах
            if (DateTime.Now.Year % 4 == 0)
            {
                label3.Text = ((31622000 - sec) + " сек");
            }
            else
            {
                label3.Text = ((31536000 - sec) + " сек");
            }
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
