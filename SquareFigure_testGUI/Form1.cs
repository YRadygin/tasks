using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SquareFigure;

namespace SquareFigure_testGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBoxA_KeyPress(object sender, KeyPressEventArgs e) //Запрещаем ввод любых символов кроме цифр
        {
            if (Char.IsNumber(e.KeyChar) |  e.KeyChar == '\b' ) return;
            else
                e.Handled = true;
            

        }
        //Выбираем фигуру из списка
        private void comboBoxFigureSelect_SelectedIndexChanged(object sender, EventArgs e) 
        {
            if (comboBoxFigureSelect.Text == "Круг")
            {
                labelA.Text = "Радиус(мм.)";
                labelB.Enabled = false;
                labelC.Enabled = false;
                textBoxB.Enabled = false;
                textBoxC.Enabled = false;
            }
            else {
                labelA.Text = "Длинна стороны А(мм.)";
                labelB.Enabled = true;
                labelC.Enabled = true;
                textBoxB.Enabled = true;
                textBoxC.Enabled = true;
            }

        }
        //Вычисляем площадь
        private void calcSq_Click(object sender, EventArgs e) 
        {
            Figure figureSelected = new Figure(); //Создаем переменну. которая наследует методы класса из dll
            if (comboBoxFigureSelect.Text == "Круг") 
            {
                sqRezult.Text = Math.Round(figureSelected.SquareCircle(Convert.ToInt32(textBoxA.Text)), 2).ToString(); //Вычисляем площадь круга
            }
            else
            { 
                //если не круг то вычисляем треугольник, метод возвращает площадь треугольника, признак того прямоугольный треугольник или нет, либо сообщение если треугольник не существует
                figureSelected.SquareTriangle(Convert.ToInt32(textBoxA.Text), Convert.ToInt32(textBoxB.Text), Convert.ToInt32(textBoxC.Text), out string typeTriangl, out double sqTriangle);
                sqRezult.Text = Math.Round(sqTriangle,2).ToString();
                labeltypeTriangle.Text = typeTriangl;
            }

        }
    }
}
