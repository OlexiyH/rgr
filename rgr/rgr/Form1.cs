using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rgr
{
    public partial class Form1 : Form
    {
        private Vector3D vector1;
        private Vector3D vector2;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double x = Convert.ToDouble(textBox1.Text);
                double y = Convert.ToDouble(textBox2.Text);
                double z = Convert.ToDouble(textBox3.Text);

                vector1 = new Vector3D(x, y, z);

                x = Convert.ToDouble(textBox4.Text);
                y = Convert.ToDouble(textBox5.Text);
                z = Convert.ToDouble(textBox6.Text);

                vector2 = new Vector3D(x, y, z);

                Vector3D sum = vector1 + vector2;
                label7.Text = $"Сума векторів: ({sum.X}, {sum.Y}, {sum.Z})";
            }
            catch
            {
                label7.Text = "Введіть значення в усі поля";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                double x = Convert.ToDouble(textBox1.Text);
                double y = Convert.ToDouble(textBox2.Text);
                double z = Convert.ToDouble(textBox3.Text);

                vector1 = new Vector3D(x, y, z);

                x = Convert.ToDouble(textBox4.Text);
                y = Convert.ToDouble(textBox5.Text);
                z = Convert.ToDouble(textBox6.Text);

                vector2 = new Vector3D(x, y, z);

                Vector3D difference = vector1 - vector2;
                label8.Text = $"Різниця векторів: ({difference.X}, {difference.Y}, {difference.Z})";
            }
            catch
            {
                label8.Text = "Введіть значення в усі поля";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                double x = Convert.ToDouble(textBox1.Text);
                double y = Convert.ToDouble(textBox2.Text);
                double z = Convert.ToDouble(textBox3.Text);

                vector1 = new Vector3D(x, y, z);

                x = Convert.ToDouble(textBox4.Text);
                y = Convert.ToDouble(textBox5.Text);
                z = Convert.ToDouble(textBox6.Text);

                vector2 = new Vector3D(x, y, z);

                double dotProduct = vector1 * vector2;
                label9.Text = $"Добуток векторів: {dotProduct}";
            }
            catch 
            {
                label9.Text = "Введіть значення в усі поля";
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                double x = Convert.ToDouble(textBox1.Text);
                double y = Convert.ToDouble(textBox2.Text);
                double z = Convert.ToDouble(textBox3.Text);

                vector1 = new Vector3D(x, y, z);

                double length = vector1.Length();
                label11.Text = $"Довжина вектору №1: {length}";
            }
            catch
            {
                label11.Text = "Введіть значення в усі поля";
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                double x = Convert.ToDouble(textBox1.Text);
                double y = Convert.ToDouble(textBox2.Text);
                double z = Convert.ToDouble(textBox3.Text);

                vector1 = new Vector3D(x, y, z);

                x = Convert.ToDouble(textBox4.Text);
                y = Convert.ToDouble(textBox5.Text);
                z = Convert.ToDouble(textBox6.Text);

                vector2 = new Vector3D(x, y, z);

                double cosine = vector1.CosineAngle(vector2);
                label10.Text = $"Косинус кута між векторами: {cosine}";
            }
            catch
            {
                label10.Text = "Введіть значення в усі поля";
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                // цифра
                return;
            }
            if (e.KeyChar == '.')
            {
                // крапку замінемо комою
                e.KeyChar = ',';
            }
            if (e.KeyChar == ',')
            {
                if (textBox1.Text.IndexOf(',') != -1)
                {
                    // кома вже є в полі редагування
                    e.Handled = true;
                }
                return;
            }
            if (e.KeyChar == '-')
            {
                if (textBox1.Text.IndexOf('-') != -1)
                {
                    // мінус вже є в полі редагування
                    e.Handled = true;
                }
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {
                // <Enter>, <Backspace>, <Esc>
                if (e.KeyChar == (char)Keys.Enter)
                    // натиснута клавіша <Enter>
                    // встановити курсор на кнопку OK
                    button1.Focus();
                return;
            }
            // інші символи заборонені
            e.Handled = true;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                // цифра
                return;
            }
            if (e.KeyChar == '.')
            {
                // крапку замінемо комою
                e.KeyChar = ',';
            }
            if (e.KeyChar == ',')
            {
                if (textBox2.Text.IndexOf(',') != -1)
                {
                    // кома вже є в полі редагування
                    e.Handled = true;
                }
                return;
            }
            if (e.KeyChar == '-')
            {
                if (textBox2.Text.IndexOf('-') != -1)
                {
                    // мінус вже є в полі редагування
                    e.Handled = true;
                }
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {
                // <Enter>, <Backspace>, <Esc>
                if (e.KeyChar == (char)Keys.Enter)
                    // натиснута клавіша <Enter>
                    // встановити курсор на кнопку OK
                    button1.Focus();
                return;
            }
            // інші символи заборонені
            e.Handled = true;
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                // цифра
                return;
            }
            if (e.KeyChar == '.')
            {
                // крапку замінемо комою
                e.KeyChar = ',';
            }
            if (e.KeyChar == ',')
            {
                if (textBox3.Text.IndexOf(',') != -1)
                {
                    // кома вже є в полі редагування
                    e.Handled = true;
                }
                return;
            }
            if (e.KeyChar == '-')
            {
                if (textBox3.Text.IndexOf('-') != -1)
                {
                    // мінус вже є в полі редагування
                    e.Handled = true;
                }
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {
                // <Enter>, <Backspace>, <Esc>
                if (e.KeyChar == (char)Keys.Enter)
                    // натиснута клавіша <Enter>
                    // встановити курсор на кнопку OK
                    button1.Focus();
                return;
            }
            // інші символи заборонені
            e.Handled = true;
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                // цифра
                return;
            }
            if (e.KeyChar == '.')
            {
                // крапку замінемо комою
                e.KeyChar = ',';
            }
            if (e.KeyChar == ',')
            {
                if (textBox4.Text.IndexOf(',') != -1)
                {
                    // кома вже є в полі редагування
                    e.Handled = true;
                }
                return;
            }
            if (e.KeyChar == '-')
            {
                if (textBox4.Text.IndexOf('-') != -1)
                {
                    // мінус вже є в полі редагування
                    e.Handled = true;
                }
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {
                // <Enter>, <Backspace>, <Esc>
                if (e.KeyChar == (char)Keys.Enter)
                    // натиснута клавіша <Enter>
                    // встановити курсор на кнопку OK
                    button1.Focus();
                return;
            }
            // інші символи заборонені
            e.Handled = true;
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                // цифра
                return;
            }
            if (e.KeyChar == '.')
            {
                // крапку замінемо комою
                e.KeyChar = ',';
            }
            if (e.KeyChar == ',')
            {
                if (textBox5.Text.IndexOf(',') != -1)
                {
                    // кома вже є в полі редагування
                    e.Handled = true;
                }
                return;
            }
            if (e.KeyChar == '-')
            {
                if (textBox5.Text.IndexOf('-') != -1)
                {
                    // мінус вже є в полі редагування
                    e.Handled = true;
                }
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {
                // <Enter>, <Backspace>, <Esc>
                if (e.KeyChar == (char)Keys.Enter)
                    // натиснута клавіша <Enter>
                    // встановити курсор на кнопку OK
                    button1.Focus();
                return;
            }
            // інші символи заборонені
            e.Handled = true;
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                // цифра
                return;
            }
            if (e.KeyChar == '.')
            {
                // крапку замінемо комою
                e.KeyChar = ',';
            }
            if (e.KeyChar == ',')
            {
                if (textBox6.Text.IndexOf(',') != -1)
                {
                    // кома вже є в полі редагування
                    e.Handled = true;
                }
                return;
            }
            if (e.KeyChar == '-')
            {
                if (textBox6.Text.IndexOf('-') != -1)
                {
                    // мінус вже є в полі редагування
                    e.Handled = true;
                }
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {
                // <Enter>, <Backspace>, <Esc>
                if (e.KeyChar == (char)Keys.Enter)
                    // натиснута клавіша <Enter>
                    // встановити курсор на кнопку OK
                    button1.Focus();
                return;
            }
            // інші символи заборонені
            e.Handled = true;
        }
    }
    public class Vector3D
    {
        private double x;
        private double y;
        private double z;

        public double X
        {
            get { return x; }
            set { x = value; }
        }

        public double Y
        {
            get { return y; }
            set { y = value; }
        }

        public double Z
        {
            get { return z; }
            set { z = value; }
        }

        public Vector3D(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public static Vector3D operator +(Vector3D v1, Vector3D v2)
        {
            double newX = v1.x + v2.x;
            double newY = v1.y + v2.y;
            double newZ = v1.z + v2.z;
            return new Vector3D(newX, newY, newZ);
        }

        public static Vector3D operator -(Vector3D v1, Vector3D v2)
        {
            double newX = v1.x - v2.x;
            double newY = v1.y - v2.y;
            double newZ = v1.z - v2.z;
            return new Vector3D(newX, newY, newZ);
        }

        public static double operator *(Vector3D v1, Vector3D v2)
        {
            double dotProduct = v1.x * v2.x + v1.y * v2.y + v1.z * v2.z;
            return dotProduct;
        }

        public double Length()
        {
            double length = Math.Sqrt(x * x + y * y + z * z);
            return length;
        }

        public double CosineAngle(Vector3D other)
        {
            double dotProduct = this * other;
            double lengthProduct = this.Length() * other.Length();
            double cosine = dotProduct / lengthProduct;
            return cosine;
        }
    }

    
}
