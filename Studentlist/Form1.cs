using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Studentlist
{
    public partial class Form1 : Form
    {
        int index = 0;
        string [,] student;
        public Form1()
        {
            InitializeComponent();
        }

        private void txtindex_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            int i = 1;

            if (student != null)
            {
                i = student.GetLength(0) + 1;
                string[,] tmp = new string[i, 3];

                Array.Copy(student, tmp, student.Length);

                student = tmp;

                // ✅ ADD NEW DATA (missing part)
                student[i - 1, 0] = txtid.Text;
                student[i - 1, 1] = txtname.Text;
                student[i - 1, 2] = txtphone.Text;
            }
            else
            {
                student = new string[1, 3];

                student[0, 0] = txtid.Text;
                student[0, 1] = txtname.Text;
                student[0, 2] = txtphone.Text;
            }

            index = i - 1;

            txtindex.Text = (index + 1).ToString() + " of " + student.GetLength(0).ToString();

            ClearText();

        }
        private void ClearText()
        {
            txtid.Clear();
            txtname.Clear();
            txtphone.Clear();
            txtid.Focus();
        }
        private void show(int indext)
        {
            txtid.Text = student[indext, 0];
            txtname.Text = student[indext, 1];
            txtphone.Text = student[indext, 2];
            txtindex.Text = (index + 1).ToString()+"of "+student.GetLength(0).ToString();
        }

        private void txtid_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtname_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtphone_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnfirst_Click(object sender, EventArgs e)
        {
            index = 0;
            if(student != null)
            {
                show(index);
            }
            else
            {
                ClearText();
            }
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            --index;
            if(index < 0)
            {
                index = 0;
            }
            if(student != null)
            {
                show(index);
            }
            else
            {
                ClearText();
            }
        }

        private void btnmn_Click(object sender, EventArgs e)
        {
            if (student == null) return;

            ++index;

            if (index >= student.GetLength(0))
            {
                index = student.GetLength(0) - 1;
            }

            show(index);
        }

        private void btnms_Click(object sender, EventArgs e)
        {
            index = student.GetLength(0) - 1;
            if(student != null)
            {
                show(index);
            }
            else
            {
                ClearText() ;
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (student == null || student.GetLength(0) == 0)
                return;

            if (student.GetLength(0) == 1)
            {
                student = null;
                ClearText();
                txtindex.Text = "";
                return;
            }

            string[,] tmp = new string[student.GetLength(0) - 1, 3];
            int j = 0;

            for (int i = 0; i < student.GetLength(0); i++)
            {
                if (i != index)
                {
                    tmp[j, 0] = student[i, 0];
                    tmp[j, 1] = student[i, 1];
                    tmp[j, 2] = student[i, 2];
                    j++;
                }
            }

            student = tmp;

            if (index >= student.GetLength(0))
            {
                index = student.GetLength(0) - 1;
            }

            show(index);
        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            ClearText();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}