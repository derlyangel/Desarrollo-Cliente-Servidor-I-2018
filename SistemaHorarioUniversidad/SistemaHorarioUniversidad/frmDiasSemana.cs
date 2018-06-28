using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SistemaHorarioUniversidad
{
    public partial class frmDiasSemana : DevComponents.DotNetBar.Office2007Form
    {
        public frmDiasSemana()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void frmDiasSemana_Load(object sender, EventArgs e)
        {
            int[] rango = new int[] {0 , 1, 2, 3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35 };
            cboDias.DataSource = rango.ToArray();

           
        }
       
        private void cboDias_SelectedIndexChanged(object sender, EventArgs e)
        {
            //int i = 1;

            //switch (cboDias)
            //{
            //    case 1:
            //        txt1.Enabled = true;
            //    case 2:
            //        txt1.Enabled = true;
            //        txt2.Enabled = true;
            //    case 3:
            //    case 4:
            //    case 5:
            //    case 6:
            //    case 7:
            //    case 8:
            //    case 9:
            //    case 10:
            //    case 11:
            //    case 12:
            //    case 13:
            //    case 14:
            //    case 15:
            //    case 16:
            //    case 17:
            //    case 18:
            //    case 19:
            //    case 20:
            //    case 21:
            //    case 22:
            //    case 23:
            //    case 24:
            //    case 25:
            //    case 26:
            //    case 27:
            //    case 28:
            //    case 29:
            //    case 30:
            //    case 31:
            //    case 32:
            //    case 33:
            //    case 34:
            //    case 35:


            //}
            //habilitacion de dias apartir del 1
            if (cboDias.SelectedIndex.Equals(1))
            {
                txt1.Enabled = true;
            }
            else
            {
                txt1.Enabled = false;
                txt2.Enabled = false;
            }

            if (cboDias.SelectedIndex.Equals(2))
            {
                txt1.Enabled = true;
                txt2.Enabled = true;
            }
            else
            {
                txt2.Enabled = false;
            }

            if (cboDias.SelectedIndex.Equals(3))
            {
                txt1.Enabled = true;
                txt2.Enabled = true;
                txt3.Enabled = true;
            }
            else
            {
                txt3.Enabled = false;
            }

            if (cboDias.SelectedIndex.Equals(4))
            {
                txt1.Enabled = true;
                txt2.Enabled = true;
                txt3.Enabled = true;
                txt4.Enabled = true;
            }
            else
            {
                txt4.Enabled = false;
            }

            if (cboDias.SelectedIndex.Equals(5))
            {
                txt1.Enabled = true;
                txt2.Enabled = true;
                txt3.Enabled = true;
                txt4.Enabled = true;
                txt5.Enabled = true;
            }
            else
            {
                txt5.Enabled = false;
            }

            if (cboDias.SelectedIndex.Equals(6))
            {
                txt1.Enabled = true;
                txt2.Enabled = true;
                txt3.Enabled = true;
                txt4.Enabled = true;
                txt5.Enabled = true;
                txt6.Enabled = true;
            }
            else
            {
                txt6.Enabled = false;
            }

            if (cboDias.SelectedIndex.Equals(7))
            {
                txt1.Enabled = true;
                txt2.Enabled = true;
                txt3.Enabled = true;
                txt4.Enabled = true;
                txt5.Enabled = true;
                txt6.Enabled = true;
                txt7.Enabled = true;
                
            }
            else
            {
                txt7.Enabled = false;
            }

            if (cboDias.SelectedIndex.Equals(8))
            {
                txt1.Enabled = true;
                txt2.Enabled = true;
                txt3.Enabled = true;
                txt4.Enabled = true;
                txt5.Enabled = true;
                txt6.Enabled = true;
                txt7.Enabled = true;
                txt8.Enabled = true;
            }
            else
            {
                txt8.Enabled = false;
            }

            if (cboDias.SelectedIndex.Equals(9))
            {
                txt1.Enabled = true;
                txt2.Enabled = true;
                txt3.Enabled = true;
                txt4.Enabled = true;
                txt5.Enabled = true;
                txt6.Enabled = true;
                txt7.Enabled = true;
                txt8.Enabled = true;
                txt9.Enabled = true;
            }
            else
            {
                txt9.Enabled = false;
            }

            if (cboDias.SelectedIndex.Equals(10))
            {
                txt1.Enabled = true;
                txt2.Enabled = true;
                txt3.Enabled = true;
                txt4.Enabled = true;
                txt5.Enabled = true;
                txt6.Enabled = true;
                txt7.Enabled = true;
                txt8.Enabled = true;
                txt9.Enabled = true;
                txt10.Enabled = true;
            }
            else
            {
                txt10.Enabled = false;
            }


            if (cboDias.SelectedIndex.Equals(11))
            {
                txt1.Enabled = true;
                txt2.Enabled = true;
                txt3.Enabled = true;
                txt4.Enabled = true;
                txt5.Enabled = true;
                txt6.Enabled = true;
                txt7.Enabled = true;
                txt8.Enabled = true;
                txt9.Enabled = true;
                txt10.Enabled = true;
                txt11.Enabled = true;
            }
            else
            {
                txt11.Enabled = false;
            }

            if (cboDias.SelectedIndex.Equals(12))
            {
                txt1.Enabled = true;
                txt2.Enabled = true;
                txt3.Enabled = true;
                txt4.Enabled = true;
                txt5.Enabled = true;
                txt6.Enabled = true;
                txt7.Enabled = true;
                txt8.Enabled = true;
                txt9.Enabled = true;
                txt10.Enabled = true;
                txt11.Enabled = true;
                txt12.Enabled = true;
            }
            else
            {
                txt12.Enabled = false;
            }

            if (cboDias.SelectedIndex.Equals(13))
            {
                txt1.Enabled = true;
                txt2.Enabled = true;
                txt3.Enabled = true;
                txt4.Enabled = true;
                txt5.Enabled = true;
                txt6.Enabled = true;
                txt7.Enabled = true;
                txt8.Enabled = true;
                txt9.Enabled = true;
                txt10.Enabled = true;
                txt11.Enabled = true;
                txt12.Enabled = true;
                txt13.Enabled = true;
            }
            else
            {
                txt13.Enabled = false;
            }

            if (cboDias.SelectedIndex.Equals(14))
            {
                txt1.Enabled = true;
                txt2.Enabled = true;
                txt3.Enabled = true;
                txt4.Enabled = true;
                txt5.Enabled = true;
                txt6.Enabled = true;
                txt7.Enabled = true;
                txt8.Enabled = true;
                txt9.Enabled = true;
                txt10.Enabled = true;
                txt11.Enabled = true;
                txt12.Enabled = true;
                txt13.Enabled = true;
                txt14.Enabled = true;
            }
            else
            {
                txt14.Enabled = false;
            }

            if (cboDias.SelectedIndex.Equals(15))
            {
                txt1.Enabled = true;
                txt2.Enabled = true;
                txt3.Enabled = true;
                txt4.Enabled = true;
                txt5.Enabled = true;
                txt6.Enabled = true;
                txt7.Enabled = true;
                txt8.Enabled = true;
                txt9.Enabled = true;
                txt10.Enabled = true;
                txt11.Enabled = true;
                txt12.Enabled = true;
                txt13.Enabled = true;
                txt14.Enabled = true;
                txt15.Enabled = true;
            }
            else
            {
                txt15.Enabled = false;
            }

            if (cboDias.SelectedIndex.Equals(16))
            {
                txt1.Enabled = true;
                txt2.Enabled = true;
                txt3.Enabled = true;
                txt4.Enabled = true;
                txt5.Enabled = true;
                txt6.Enabled = true;
                txt7.Enabled = true;
                txt8.Enabled = true;
                txt9.Enabled = true;
                txt10.Enabled = true;
                txt11.Enabled = true;
                txt12.Enabled = true;
                txt13.Enabled = true;
                txt14.Enabled = true;
                txt15.Enabled = true;
                txt16.Enabled = true;
            }
            else
            {
                txt16.Enabled = false;
            }

            if (cboDias.SelectedIndex.Equals(17))
            {
                txt1.Enabled = true;
                txt2.Enabled = true;
                txt3.Enabled = true;
                txt4.Enabled = true;
                txt5.Enabled = true;
                txt6.Enabled = true;
                txt7.Enabled = true;
                txt8.Enabled = true;
                txt9.Enabled = true;
                txt10.Enabled = true;
                txt11.Enabled = true;
                txt12.Enabled = true;
                txt13.Enabled = true;
                txt14.Enabled = true;
                txt15.Enabled = true;
                txt16.Enabled = true;
                txt17.Enabled = true;
            }
            else
            {
                txt17.Enabled = false;
            }

            if (cboDias.SelectedIndex.Equals(18))
            {
                txt1.Enabled = true;
                txt2.Enabled = true;
                txt3.Enabled = true;
                txt4.Enabled = true;
                txt5.Enabled = true;
                txt6.Enabled = true;
                txt7.Enabled = true;
                txt8.Enabled = true;
                txt9.Enabled = true;
                txt10.Enabled = true;
                txt11.Enabled = true;
                txt12.Enabled = true;
                txt13.Enabled = true;
                txt14.Enabled = true;
                txt15.Enabled = true;
                txt16.Enabled = true;
                txt17.Enabled = true;
                txt18.Enabled = true;
            }
            else
            {
                txt18.Enabled = false;
            }

            if (cboDias.SelectedIndex.Equals(19))
            {
                txt1.Enabled = true;
                txt2.Enabled = true;
                txt3.Enabled = true;
                txt4.Enabled = true;
                txt5.Enabled = true;
                txt6.Enabled = true;
                txt7.Enabled = true;
                txt8.Enabled = true;
                txt9.Enabled = true;
                txt10.Enabled = true;
                txt11.Enabled = true;
                txt12.Enabled = true;
                txt13.Enabled = true;
                txt14.Enabled = true;
                txt15.Enabled = true;
                txt16.Enabled = true;
                txt17.Enabled = true;
                txt18.Enabled = true;
                txt19.Enabled = true;
            }
            else
            {
                txt19.Enabled = false;
            }

            if (cboDias.SelectedIndex.Equals(20))
            {
                txt1.Enabled = true;
                txt2.Enabled = true;
                txt3.Enabled = true;
                txt4.Enabled = true;
                txt5.Enabled = true;
                txt6.Enabled = true;
                txt7.Enabled = true;
                txt8.Enabled = true;
                txt9.Enabled = true;
                txt10.Enabled = true;
                txt11.Enabled = true;
                txt12.Enabled = true;
                txt13.Enabled = true;
                txt14.Enabled = true;
                txt15.Enabled = true;
                txt16.Enabled = true;
                txt17.Enabled = true;
                txt18.Enabled = true;
                txt19.Enabled = true;
                txt20.Enabled = true;
            }
            else
            {
                txt20.Enabled = false;
            }

            if (cboDias.SelectedIndex.Equals(21))
            {
                txt1.Enabled = true;
                txt2.Enabled = true;
                txt3.Enabled = true;
                txt4.Enabled = true;
                txt5.Enabled = true;
                txt6.Enabled = true;
                txt7.Enabled = true;
                txt8.Enabled = true;
                txt9.Enabled = true;
                txt10.Enabled = true;
                txt11.Enabled = true;
                txt12.Enabled = true;
                txt13.Enabled = true;
                txt14.Enabled = true;
                txt15.Enabled = true;
                txt16.Enabled = true;
                txt17.Enabled = true;
                txt18.Enabled = true;
                txt19.Enabled = true;
                txt20.Enabled = true;
                txt21.Enabled = true;
            }
            else
            {
                txt21.Enabled = false;
            }

            if (cboDias.SelectedIndex.Equals(22))
            {
                txt1.Enabled = true;
                txt2.Enabled = true;
                txt3.Enabled = true;
                txt4.Enabled = true;
                txt5.Enabled = true;
                txt6.Enabled = true;
                txt7.Enabled = true;
                txt8.Enabled = true;
                txt9.Enabled = true;
                txt10.Enabled = true;
                txt11.Enabled = true;
                txt12.Enabled = true;
                txt13.Enabled = true;
                txt14.Enabled = true;
                txt15.Enabled = true;
                txt16.Enabled = true;
                txt17.Enabled = true;
                txt18.Enabled = true;
                txt19.Enabled = true;
                txt20.Enabled = true;
                txt21.Enabled = true;
                txt22.Enabled = true;
            }
            else
            {
                txt22.Enabled = false;
            }

            if (cboDias.SelectedIndex.Equals(23))
            {
                txt1.Enabled = true;
                txt2.Enabled = true;
                txt3.Enabled = true;
                txt4.Enabled = true;
                txt5.Enabled = true;
                txt6.Enabled = true;
                txt7.Enabled = true;
                txt8.Enabled = true;
                txt9.Enabled = true;
                txt10.Enabled = true;
                txt11.Enabled = true;
                txt12.Enabled = true;
                txt13.Enabled = true;
                txt14.Enabled = true;
                txt15.Enabled = true;
                txt16.Enabled = true;
                txt17.Enabled = true;
                txt18.Enabled = true;
                txt19.Enabled = true;
                txt20.Enabled = true;
                txt21.Enabled = true;
                txt22.Enabled = true;
                txt23.Enabled = true;
            }
            else
            {
                txt23.Enabled = false;
            }

            if (cboDias.SelectedIndex.Equals(24))
            {
                txt1.Enabled = true;
                txt2.Enabled = true;
                txt3.Enabled = true;
                txt4.Enabled = true;
                txt5.Enabled = true;
                txt6.Enabled = true;
                txt7.Enabled = true;
                txt8.Enabled = true;
                txt9.Enabled = true;
                txt10.Enabled = true;
                txt11.Enabled = true;
                txt12.Enabled = true;
                txt13.Enabled = true;
                txt14.Enabled = true;
                txt15.Enabled = true;
                txt16.Enabled = true;
                txt17.Enabled = true;
                txt18.Enabled = true;
                txt19.Enabled = true;
                txt20.Enabled = true;
                txt21.Enabled = true;
                txt22.Enabled = true;
                txt23.Enabled = true;
                txt24.Enabled = true;
            }
            else
            {
                txt24.Enabled = false;
            }

            if (cboDias.SelectedIndex.Equals(25))
            {
                txt1.Enabled = true;
                txt2.Enabled = true;
                txt3.Enabled = true;
                txt4.Enabled = true;
                txt5.Enabled = true;
                txt6.Enabled = true;
                txt7.Enabled = true;
                txt8.Enabled = true;
                txt9.Enabled = true;
                txt10.Enabled = true;
                txt11.Enabled = true;
                txt12.Enabled = true;
                txt13.Enabled = true;
                txt14.Enabled = true;
                txt15.Enabled = true;
                txt16.Enabled = true;
                txt17.Enabled = true;
                txt18.Enabled = true;
                txt19.Enabled = true;
                txt20.Enabled = true;
                txt21.Enabled = true;
                txt22.Enabled = true;
                txt23.Enabled = true;
                txt24.Enabled = true;
                txt25.Enabled = true;
            }
            else
            {
                txt25.Enabled = false;
            }

            if (cboDias.SelectedIndex.Equals(26))
            {
                txt1.Enabled = true;
                txt2.Enabled = true;
                txt3.Enabled = true;
                txt4.Enabled = true;
                txt5.Enabled = true;
                txt6.Enabled = true;
                txt7.Enabled = true;
                txt8.Enabled = true;
                txt9.Enabled = true;
                txt10.Enabled = true;
                txt11.Enabled = true;
                txt12.Enabled = true;
                txt13.Enabled = true;
                txt14.Enabled = true;
                txt15.Enabled = true;
                txt16.Enabled = true;
                txt17.Enabled = true;
                txt18.Enabled = true;
                txt19.Enabled = true;
                txt20.Enabled = true;
                txt21.Enabled = true;
                txt22.Enabled = true;
                txt23.Enabled = true;
                txt24.Enabled = true;
                txt25.Enabled = true;
                txt26.Enabled = true;
            }
            else
            {
                txt26.Enabled = false;
            }

            if (cboDias.SelectedIndex.Equals(27))
            {
                txt1.Enabled = true;
                txt2.Enabled = true;
                txt3.Enabled = true;
                txt4.Enabled = true;
                txt5.Enabled = true;
                txt6.Enabled = true;
                txt7.Enabled = true;
                txt8.Enabled = true;
                txt9.Enabled = true;
                txt10.Enabled = true;
                txt11.Enabled = true;
                txt12.Enabled = true;
                txt13.Enabled = true;
                txt14.Enabled = true;
                txt15.Enabled = true;
                txt16.Enabled = true;
                txt17.Enabled = true;
                txt18.Enabled = true;
                txt19.Enabled = true;
                txt20.Enabled = true;
                txt21.Enabled = true;
                txt22.Enabled = true;
                txt23.Enabled = true;
                txt24.Enabled = true;
                txt25.Enabled = true;
                txt26.Enabled = true;
                txt27.Enabled = true;
            }
            else
            {
                txt27.Enabled = false;
            }

            if (cboDias.SelectedIndex.Equals(28))
            {
                txt1.Enabled = true;
                txt2.Enabled = true;
                txt3.Enabled = true;
                txt4.Enabled = true;
                txt5.Enabled = true;
                txt6.Enabled = true;
                txt7.Enabled = true;
                txt8.Enabled = true;
                txt9.Enabled = true;
                txt10.Enabled = true;
                txt11.Enabled = true;
                txt12.Enabled = true;
                txt13.Enabled = true;
                txt14.Enabled = true;
                txt15.Enabled = true;
                txt16.Enabled = true;
                txt17.Enabled = true;
                txt18.Enabled = true;
                txt19.Enabled = true;
                txt20.Enabled = true;
                txt21.Enabled = true;
                txt22.Enabled = true;
                txt23.Enabled = true;
                txt24.Enabled = true;
                txt25.Enabled = true;
                txt26.Enabled = true;
                txt27.Enabled = true;
                txt28.Enabled = true;
            }
            else
            {
                txt28.Enabled = false;
            }

            if (cboDias.SelectedIndex.Equals(29))
            {
                txt1.Enabled = true;
                txt2.Enabled = true;
                txt3.Enabled = true;
                txt4.Enabled = true;
                txt5.Enabled = true;
                txt6.Enabled = true;
                txt7.Enabled = true;
                txt8.Enabled = true;
                txt9.Enabled = true;
                txt10.Enabled = true;
                txt11.Enabled = true;
                txt12.Enabled = true;
                txt13.Enabled = true;
                txt14.Enabled = true;
                txt15.Enabled = true;
                txt16.Enabled = true;
                txt17.Enabled = true;
                txt18.Enabled = true;
                txt19.Enabled = true;
                txt20.Enabled = true;
                txt21.Enabled = true;
                txt22.Enabled = true;
                txt23.Enabled = true;
                txt24.Enabled = true;
                txt25.Enabled = true;
                txt26.Enabled = true;
                txt27.Enabled = true;
                txt28.Enabled = true;
                txt29.Enabled = true;
            }
            else
            {
                txt29.Enabled = false;
            }

            if (cboDias.SelectedIndex.Equals(30))
            {
                txt1.Enabled = true;
                txt2.Enabled = true;
                txt3.Enabled = true;
                txt4.Enabled = true;
                txt5.Enabled = true;
                txt6.Enabled = true;
                txt7.Enabled = true;
                txt8.Enabled = true;
                txt9.Enabled = true;
                txt10.Enabled = true;
                txt11.Enabled = true;
                txt12.Enabled = true;
                txt13.Enabled = true;
                txt14.Enabled = true;
                txt15.Enabled = true;
                txt16.Enabled = true;
                txt17.Enabled = true;
                txt18.Enabled = true;
                txt19.Enabled = true;
                txt20.Enabled = true;
                txt21.Enabled = true;
                txt22.Enabled = true;
                txt23.Enabled = true;
                txt24.Enabled = true;
                txt25.Enabled = true;
                txt26.Enabled = true;
                txt27.Enabled = true;
                txt28.Enabled = true;
                txt29.Enabled = true;
                txt30.Enabled = true;
            }
            else
            {
                txt30.Enabled = false;
            }

            if (cboDias.SelectedIndex.Equals(31))
            {
                txt1.Enabled = true;
                txt2.Enabled = true;
                txt3.Enabled = true;
                txt4.Enabled = true;
                txt5.Enabled = true;
                txt6.Enabled = true;
                txt7.Enabled = true;
                txt8.Enabled = true;
                txt9.Enabled = true;
                txt10.Enabled = true;
                txt11.Enabled = true;
                txt12.Enabled = true;
                txt13.Enabled = true;
                txt14.Enabled = true;
                txt15.Enabled = true;
                txt16.Enabled = true;
                txt17.Enabled = true;
                txt18.Enabled = true;
                txt19.Enabled = true;
                txt20.Enabled = true;
                txt21.Enabled = true;
                txt22.Enabled = true;
                txt23.Enabled = true;
                txt24.Enabled = true;
                txt25.Enabled = true;
                txt26.Enabled = true;
                txt27.Enabled = true;
                txt28.Enabled = true;
                txt29.Enabled = true;
                txt30.Enabled = true;
                txt31.Enabled = true;
            }
            else
            {
                txt31.Enabled = false;
            }

            if (cboDias.SelectedIndex.Equals(32))
            {
                txt1.Enabled = true;
                txt2.Enabled = true;
                txt3.Enabled = true;
                txt4.Enabled = true;
                txt5.Enabled = true;
                txt6.Enabled = true;
                txt7.Enabled = true;
                txt8.Enabled = true;
                txt9.Enabled = true;
                txt10.Enabled = true;
                txt11.Enabled = true;
                txt12.Enabled = true;
                txt13.Enabled = true;
                txt14.Enabled = true;
                txt15.Enabled = true;
                txt16.Enabled = true;
                txt17.Enabled = true;
                txt18.Enabled = true;
                txt19.Enabled = true;
                txt20.Enabled = true;
                txt21.Enabled = true;
                txt22.Enabled = true;
                txt23.Enabled = true;
                txt24.Enabled = true;
                txt25.Enabled = true;
                txt26.Enabled = true;
                txt27.Enabled = true;
                txt28.Enabled = true;
                txt29.Enabled = true;
                txt30.Enabled = true;
                txt31.Enabled = true;
                txt32.Enabled = true;
            }
            else
            {
                txt32.Enabled = false;
            }

            if (cboDias.SelectedIndex.Equals(33))
            {
                txt1.Enabled = true;
                txt2.Enabled = true;
                txt3.Enabled = true;
                txt4.Enabled = true;
                txt5.Enabled = true;
                txt6.Enabled = true;
                txt7.Enabled = true;
                txt8.Enabled = true;
                txt9.Enabled = true;
                txt10.Enabled = true;
                txt11.Enabled = true;
                txt12.Enabled = true;
                txt13.Enabled = true;
                txt14.Enabled = true;
                txt15.Enabled = true;
                txt16.Enabled = true;
                txt17.Enabled = true;
                txt18.Enabled = true;
                txt19.Enabled = true;
                txt20.Enabled = true;
                txt21.Enabled = true;
                txt22.Enabled = true;
                txt23.Enabled = true;
                txt24.Enabled = true;
                txt25.Enabled = true;
                txt26.Enabled = true;
                txt27.Enabled = true;
                txt28.Enabled = true;
                txt29.Enabled = true;
                txt30.Enabled = true;
                txt31.Enabled = true;
                txt32.Enabled = true;
                txt33.Enabled = true;
            }
            else
            {
                txt33.Enabled = false;
            }

            if (cboDias.SelectedIndex.Equals(34))
            {
                txt1.Enabled = true;
                txt2.Enabled = true;
                txt3.Enabled = true;
                txt4.Enabled = true;
                txt5.Enabled = true;
                txt6.Enabled = true;
                txt7.Enabled = true;
                txt8.Enabled = true;
                txt9.Enabled = true;
                txt10.Enabled = true;
                txt11.Enabled = true;
                txt12.Enabled = true;
                txt13.Enabled = true;
                txt14.Enabled = true;
                txt15.Enabled = true;
                txt16.Enabled = true;
                txt17.Enabled = true;
                txt18.Enabled = true;
                txt19.Enabled = true;
                txt20.Enabled = true;
                txt21.Enabled = true;
                txt22.Enabled = true;
                txt23.Enabled = true;
                txt24.Enabled = true;
                txt25.Enabled = true;
                txt26.Enabled = true;
                txt27.Enabled = true;
                txt28.Enabled = true;
                txt29.Enabled = true;
                txt30.Enabled = true;
                txt31.Enabled = true;
                txt32.Enabled = true;
                txt33.Enabled = true;
                txt34.Enabled = true;
            }
            else
            {
                txt34.Enabled = false;
            }

            if (cboDias.SelectedIndex.Equals(35))
            {
                txt1.Enabled = true;
                txt2.Enabled = true;
                txt3.Enabled = true;
                txt4.Enabled = true;
                txt5.Enabled = true;
                txt6.Enabled = true;
                txt7.Enabled = true;
                txt8.Enabled = true;
                txt9.Enabled = true;
                txt10.Enabled = true;
                txt11.Enabled = true;
                txt12.Enabled = true;
                txt13.Enabled = true;
                txt14.Enabled = true;
                txt15.Enabled = true;
                txt16.Enabled = true;
                txt17.Enabled = true;
                txt18.Enabled = true;
                txt19.Enabled = true;
                txt20.Enabled = true;
                txt21.Enabled = true;
                txt22.Enabled = true;
                txt23.Enabled = true;
                txt24.Enabled = true;
                txt25.Enabled = true;
                txt26.Enabled = true;
                txt27.Enabled = true;
                txt28.Enabled = true;
                txt29.Enabled = true;
                txt30.Enabled = true;
                txt31.Enabled = true;
                txt32.Enabled = true;
                txt33.Enabled = true;
                txt34.Enabled = true;
                txt35.Enabled = true;
            }
            else
            {
                txt35.Enabled = false;
            }
        }
    }
}
