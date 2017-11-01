using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        Stack<int> kernel1 = new Stack<int>();  //стек выступает в роли стержня
        Stack<int> kernel2 = new Stack<int>();  //2
        Stack<int> kernel3 = new Stack<int>();  //3
        int b=3;                                //количество колец на первом стержне

        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Sort();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ShowResult();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Fill();
        }
        private void Fill()                     //наполнение первого стержня
        {

            b = Convert.ToInt16(textBox1.Text);
            
            for (int i = b; i >= 1; i--)
            {
                kernel1.Push(i);
            }
        }                  
        private void Sort()                     //перенос колец на другой стержень
        {
            while (kernel1.Count!=0||(kernel2.Count != 0 && kernel3.Count != 0))    //условие выхода из сортировки
                if (kernel1.Count != 0)                                             // далее и до конца метода идет логика сортировки. это первая его часть,  
                {                                                                   //которая выполняется когда на первом стержне есть хотябы одно кольцо

                    if (kernel1.Peek() % 2 != 0)
                    if (kernel2.Count == 0)
                    {
                        kernel2.Push(kernel1.Pop());
                    }
                    else
                        if (kernel3.Count == 0)
                        {
                        kernel2.Push(kernel1.Pop());
                        }
                        else
                           if (kernel2.Peek() < kernel3.Peek() && kernel3.Peek() % 2 == 0)
                           {
                                kernel3.Push(kernel2.Pop());
                           }
                           else
                                if (kernel3.Peek() < kernel2.Peek() && kernel3.Peek() % 2 == 0)
                                {
                                    kernel2.Push(kernel3.Pop());
                                }
                                else
                                    if (kernel2.Peek() % 2 == 0 && kernel2.Peek() < kernel1.Peek())
                                    {
                                        kernel1.Push(kernel2.Pop());
                                    }
                                    else
                                    {
                                        kernel2.Push(kernel1.Pop());
                                    }
                else
                    if (kernel3.Count == 0)
                    {
                        kernel3.Push(kernel1.Pop());
                    }
                    else
                       if (kernel3.Peek() < kernel1.Peek())
                       {
                           kernel1.Push(kernel3.Pop());
                       }
                       else
                       {
                            kernel3.Push(kernel1.Pop());
                       }
            }
            else
            {
                
                if (b % 2 == 0)                                                    //Вторая чать, выаолняется, если на первом стержне не осталось колец            
                    if (kernel2.Count == 0)
                    {
                        kernel2.Push(kernel1.Pop());
                    }
                    else
                        if (kernel3.Count == 0)
                        {
                            kernel2.Push(kernel1.Pop());
                        }
                        else
                            if (kernel2.Peek() < kernel3.Peek() && kernel3.Peek() % 2 == 0)
                            {
                                kernel3.Push(kernel2.Pop());
                            }
                            else
                                if (kernel3.Peek() < kernel2.Peek() && kernel3.Peek() % 2 == 0)
                                {
                                    kernel2.Push(kernel3.Pop());
                                }
                                else
                                    if (kernel2.Peek() % 2 == 0 && kernel2.Peek() < b + 1)
                                    {
                                        kernel1.Push(kernel2.Pop());
                                    }
                    else
                    {
                        kernel2.Push(kernel1.Pop());
                    }
                else
                    if (kernel3.Count == 0)
                    {
                        kernel3.Push(kernel1.Pop());
                    }
                    else
                        if (kernel3.Peek() < b) 
                        {
                            kernel1.Push(kernel3.Pop());
                        }
                        else
                        {
                            kernel3.Push(kernel1.Pop());
                        }
            }

           


        }                   
        private void ShowResult()               //вывод результата
        {
            textBox2.Text = "";
            textBox3.Text = "";
            for (int i = b; i >= 1; i--)
            {
                if (kernel2.Count != 0)
                    textBox2.Text += kernel2.Pop();
                else
                    textBox3.Text += kernel3.Pop();
            }
        }
    }
}
