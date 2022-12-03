using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kyrs
{
    public partial class Form1 : Form
    {
        
        private double x, y,h;
        double[] min = new double[5];
        double[,] B = new double[2, 10];
        double[,] C = new double[4, 5];
        double[][] M = MatrixCreate(4, 5); // Исходная матрица
        
        public Form1()
        {
            InitializeComponent();
            pictureBox1.Visible = false;
        }
        static double[][] MatrixCreate(int rows, int cols)
        {
            // Создаем матрицу, полностью инициализированную
            // значениями 0.0. Проверка входных параметров опущена.
            double[][] result = new double[rows][];
            for (int i = 0; i < rows; ++i)
                result[i] = new double[cols]; // автоинициализация в 0.0
            return result;
        }


        private void построитьГрафикToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double a=0, b=0, c=0,d=0;
            min[0]=99999999999999;
            min[1]=99999999999999;
            min[2]=99999999999999;
            min[3]=99999999999999;
            min[4]=99999999999999;
            string path =@"C:\Users\atomv\RiderProjects\Kyrs\Kyrs\1.txt";
            switch (textBox.Text)
            {
                case "1":
                     path = @"C:\Users\atomv\RiderProjects\Kyrs\Kyrs\1.txt";
                    break;
                case "2":
                     path = @"C:\Users\atomv\RiderProjects\Kyrs\Kyrs\2.txt";
                    break;
                case "3":
                     path = @"C:\Users\atomv\RiderProjects\Kyrs\Kyrs\3.txt";
                    break;
            }

            //string path = @"C:\Users\atomv\RiderProjects\Kyrs\Kyrs\2.txt";
            //File.Create(path);
            //string[] readtext = File.ReadAllLines(path);
            
                
            /*
            File.WriteAllText(path,";jgf");
            using (StreamWriter steam = new StreamWriter(path,true))
                steam.WriteLine("11111");*/
            
            
            /*string s = "1.5,1.6,1.7,1.8,1.9,2,2.1,2.2,2.3,2.4," +                               // x
                       "3.9396,4.8609,6.12,7.5396,8.493,11.466,13.2066,16.952,21.094,23.571";   // y
                       */
            string s = File.ReadAllText(path);
            char[] separators = new char[] {','};
            string[] subs = s.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            int size = subs.Length/2;
            for (int j = 0; j < size; j++) 
            {
                B[0,j] = Convert.ToDouble(subs[j].Replace('.', ','));
                B[1,j] = Convert.ToDouble(subs[size+j].Replace('.', ','));
            }
            h = B[0, 1] - B[0, 0];
            if (checkBox_yx.Checked == false && checkBox_x.Checked == false && checkBox_x2.Checked == false && checkBox_x3.Checked == false && checkBox_e.Checked == false && checkBox_b.Checked == false)
            {
                MessageBox.Show("Выберите хотя бы один график!", "Внимание!");
                return;
            }
            /*

            if (textBox.Text =="" || textBox_b.Text == ""|| textBox_h.Text =="")
            {
                MessageBox.Show("Параметры по умолчанию!", "Внимание!");
                DefaultParams();
            }
            else
            {
                a = Convert.ToDouble(textBox.Text);
                b = Convert.ToDouble(textBox_b.Text);
                h = Convert.ToDouble(textBox_h.Text);
            }
            */
            if (checkBox1.Checked == true)
            {
                checkBox_e.Checked = true;
            }
            if (checkBox_yx.Checked )
            {
                this.chart.Series[0].Points.Clear();
                int i = 0;
                x = B[0,0] ;
                while (x<=B[0,9]+0.1)
                {
                    y = B[1,i];
                    this.chart.Series[0].Points.AddXY(x,y);
                    x += h;
                    i++;
                }
            }
            if (checkBox_x.Checked )
            {
                this.chart.Series[1].Points.Clear();
                int i= 0;
                x = B[0,0];
                min[0] = 0;
                size = 2;
                C=MakeSystem(B,size,0);
                for (i = 0; i < size; i++) {
                    for (int j = 0; j < size+1; j++) {
                        M[i][j] = C[i,j];
                    }
                }
                i = 0;
                double[] g = Gauss(M,size);
                while (x<=B[0,9]+0.1)
                {
                    //y = A[1, i];
                    y = g[0]+g[1]*x;
                    this.chart.Series[1].Points.AddXY(x,y);
                    x += h;
                    min[0] += Math.Pow(Math.Abs(y - B[1, i]),2);
                    i++;  
                }

                a = g[0];
                b = g[1];
            }
            if (checkBox_x2.Checked )
            {
                min[1] = 0;
                this.chart.Series[2].Points.Clear();
                int i ;
                size = 3;
                x = B[0,0];
                C=MakeSystem(B,size,0);
                for (i = 0; i < size; i++) {
                    for (int j = 0; j < size+1; j++) {
                        M[i][j] = C[i,j];
                    }
                }
                double[] g = Gauss(M,size);
                i = 0;
                while (x<=B[0,9]+0.1)
                {
                    
                    y = g[0]+g[1]*x+g[2]*Math.Pow(x,2);
                    this.chart.Series[2].Points.AddXY(x,y);
                    x += h;
                    min[1] += Math.Pow(Math.Abs(y - B[1, i]),2);
                    i++;
                }
                a = g[0];
                b = g[1];
                c = g[2];
            }
            if (checkBox_x3.Checked )
            {
                min[2] = 0;
                int i= 0;
                this.chart.Series[3].Points.Clear();
                size = 4;
                C=MakeSystem(B,size,0);
                for (i = 0; i < size; i++) {
                    for (int j = 0; j < size+1; j++) {
                        M[i][j] = C[i,j];
                    }
                }
                double[] g = Gauss(M,size);
                x = B[0,0];
                i = 0;
                while (x<=B[0,9]+0.1)
                {
                   //y = A[1, i];
                    y = g[0]+g[1]*x+g[2]*Math.Pow(x,2)+g[3]*Math.Pow(x,3);
                    this.chart.Series[3].Points.AddXY(x,y);
                    //y = -31.33+22.08*x;
                    //this.chart.Series[2].Points.AddXY(x,y);
                    min[2] += Math.Pow(Math.Abs(y - B[1, i]),2);
                    x += h;
                    i++;
                }
                a = g[0];
                b = g[1];
                c = g[2];
                d = g[3];
            }
            if (checkBox_e.Checked )
            {
                min[3] = 0;
                int i= 0;
                this.chart.Series[4].Points.Clear();
                size = 2;
                x = B[0,0];
                C=MakeSystem(B,2,1);
                for (i = 0; i < size; i++) {
                    for (int j = 0; j < size+1; j++) {
                        M[i][j] = C[i,j];
                    }
                }
                i = 0;
                double[] g = Gauss(M,size);
                g[0] = Math.Pow(Math.E, g[0]);
                while (x<=B[0,9]+0.1)
                {
                    //y = A[1, i];
                    y = g[0]*Math.Pow((Math.E),g[1]*x);
                    this.chart.Series[4].Points.AddXY(x,y);
                    x += h;
                    min[3] += Math.Pow(Math.Abs(y - B[1, i]),2);
                    i++;  
                }
                a = g[0];
                b = g[1];
            }
            if (checkBox_b.Checked )
            {
                min[4] = 0;
                int i= 0;
                this.chart.Series[5].Points.Clear();
                size = 2;
                x = B[0,0];
                //C=MakeSystem(B,2,2);
                C = MakeStepb(B);
                for (i = 0; i < size; i++) {
                    for (int j = 0; j < size+1; j++) {
                        M[i][j] = C[i,j];
                    }
                }
                i = 0;
                double[] g = Gauss(M,size);
                while (x<=B[0,9]+0.1)
                {
                    //y = A[1, i];
                    y = g[0]+g[1]/x;
                    this.chart.Series[5].Points.AddXY(x,y);
                    x += h;
                    min[4] += Math.Pow(Math.Abs(y - B[1, i]),2);
                    i++;  
                }
                a = g[0];
                b = g[1];
            }

            double Min = min[0];
            int minIndex = 0;
            for (int i = 0; i < min.Length; i++)
            {
                if (Min > min[i])
                {
                    Min = min[i];
                    minIndex = i;
                }
            }
            if ( checkBox_x.Checked == false && checkBox_x2.Checked == false &&
                checkBox_x3.Checked == false && checkBox_e.Checked == false && checkBox_b.Checked == false)
            {
                return;
            }

            //Point.Add(259, 163);
            switch (minIndex)
            {
                    
                case 0:
                    MessageBox.Show("Минимальная сумма квадратов отклонений =" +Math.Round(Min) +"\nПредпочтительнее выбрать график вида: g(x)="+a+"+"+b+"*x");
                    
                    pictureBox1.Location= new Point(190, 65);
                    pictureBox1.Visible = true;
                    break;
                case 1:
                    MessageBox.Show("Минимальная сумма квадратов отклонений =" + Math.Round(Min)+"\nПредпочтительнее выбрать график вида: g(x)="+a+"+"+b+"*x+"+c+"*x^2");
                    pictureBox1.Location= new Point(190, 100);
                    pictureBox1.Visible = true;
                    break;
                case 2:
                    MessageBox.Show("Минимальная сумма квадратов отклонений =" + Math.Round(Min)+"\nПредпочтительнее выбрать график вида: g(x)="+a+"+"+b+"*x+"+c+"*x^2+"+d+"*x^3");
                    pictureBox1.Location= new Point(190, 140);
                    pictureBox1.Visible = true;
                    break;
                case 3:
                    MessageBox.Show("Минимальная сумма квадратов отклонений =" + Math.Round(Min)+"\nПредпочтительнее выбрать график вида: g(x)="+a+"*e^("+b+")");
                    pictureBox1.Location= new Point(190, 175);
                    pictureBox1.Visible = true;
                    break;
                case 4:
                    MessageBox.Show("Минимальная сумма квадратов отклонений =" + Math.Round(Min)+"\nПредпочтительнее выбрать график вида: g(x)="+a+"*"+b+"/x");
                    pictureBox1.Location = new Point(190, 210);
                    pictureBox1.Visible = true;
                    break;
                    
            }

           
            //throw new System.NotImplementedException();
            
        }

        private void очиститьГрафикToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            if (checkBox_yx.Checked == false && checkBox_x.Checked == false && checkBox_x2.Checked == false && checkBox_x3.Checked == false && checkBox_e.Checked == false && checkBox_b.Checked == false)
            {
                MessageBox.Show("Выберите хотя бы один график!", "Внимание!");
                return;
            }
            if (checkBox_yx.Checked )
            {
                this.chart.Series[0].Points.Clear();
            }
            if (checkBox_x.Checked )
            {
                this.chart.Series[1].Points.Clear();
            }
            if (checkBox_x2.Checked )
            {
                this.chart.Series[2].Points.Clear();
            }
            if (checkBox_x3.Checked )
            {
                this.chart.Series[3].Points.Clear();
            }
            if (checkBox_e.Checked )
            {
                this.chart.Series[4].Points.Clear();
            }
            if (checkBox_b.Checked )
            {
                this.chart.Series[5].Points.Clear();
            }
            //throw new System.NotImplementedException();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Выйти?", "Внимание!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
            // throw new System.NotImplementedException();
        }
        private void DefaultParams()
        {
            /*a = 1.5;
            b = 2.4;
            h = 0.1;*/
        }
        private double[,] MakeSystem(double[,] xyTable, int basis,int flag)
        {
            /*
            xyTable[0, 0] = 0;xyTable[0, 1] = 0.1;xyTable[0, 2] = 0.2;xyTable[0, 3] = 0.3;xyTable[0, 4] = 0.4;
            xyTable[0, 5] = 0.5;xyTable[0, 6] = 0.6;xyTable[0, 7] = 0.7;xyTable[0, 8] = 0.8;xyTable[0, 9] = 0.9;
            xyTable[1, 0] = 3;xyTable[1, 1] = 3.664;xyTable[1, 2] = 4.475;xyTable[1, 3] = 5.467;xyTable[1, 4] = 6.677;
            xyTable[1, 5] = 8.155;xyTable[1, 6] = 9.96;xyTable[1, 7] = 12.166;xyTable[1, 8] = 14.859;xyTable[1, 9] = 18.149;*/
            double[,] matrix = new double[basis, basis + 1];
            for (int i = 0; i < basis; i++)
            {
                for (int j = 0; j < basis; j++)
                {
                    matrix[i, j] = 0;
                }
            }
            for (int i = 0; i < basis; i++)
            {
                for (int j = 0; j < basis; j++)
                {
                    double sumA = 0, sumB = 0;
                    for (int k = 0; k < xyTable.Length / 2; k++)
                    {
                        switch (flag)
                        {

                            case 0:
                                sumA += Math.Pow(xyTable[0, k], i) * Math.Pow(xyTable[0, k], j);
                                sumB += xyTable[1, k] * Math.Pow(xyTable[0, k], i);
                                break;
                            case 1:
                                sumA += Math.Pow(xyTable[0, k], i) * Math.Pow(xyTable[0, k], j);
                                sumB += Math.Log(xyTable[1, k],Math.E) * Math.Pow(xyTable[0, k], i);
                                break;
                            case 2:
                                sumA += Math.Pow(xyTable[0, k], -i) * Math.Pow(xyTable[0, k], -j);
                                sumB += xyTable[1, k] * Math.Pow(xyTable[0, k], -i);
                                break;
                               
                        }
                    }
                    matrix[i, j] = sumA;
                    matrix[i, basis] = sumB;
                }
            }
            return matrix;
        }
        private double[,] MakeStep(double[,] xyTable)
        {
            /*
            xyTable[0, 0] = 0;xyTable[0, 1] = 0.1;xyTable[0, 2] = 0.2;xyTable[0, 3] = 0.3;xyTable[0, 4] = 0.4;
            xyTable[0, 5] = 0.5;xyTable[0, 6] = 0.6;xyTable[0, 7] = 0.7;xyTable[0, 8] = 0.8;xyTable[0, 9] = 0.9;
            xyTable[1, 0] = 3;xyTable[1, 1] = 3.664;xyTable[1, 2] = 4.475;xyTable[1, 3] = 5.467;xyTable[1, 4] = 6.677;
            xyTable[1, 5] = 8.155;xyTable[1, 6] = 9.96;xyTable[1, 7] = 12.166;xyTable[1, 8] = 14.859;xyTable[1, 9] = 18.149;*/
            int basis =2;
            double[,] matrix = new double[basis, basis + 1];
            for (int i = 0; i < basis; i++)
            {
                for (int j = 0; j < basis; j++)
                {
                    matrix[i, j] = 0;
                }
            }
            for (int i = 0; i < basis; i++)
            {
                for (int j = 0; j < basis; j++)
                {
                    double sumA = 0, sumB = 0;
                    for (int k = 0; k < xyTable.Length / 2; k++)
                    {
                        sumA += Math.Pow(xyTable[0, k], i) * Math.Pow(xyTable[0, k], j);
                        sumB += Math.Log(xyTable[1, k],Math.E) * Math.Pow(xyTable[0, k], i);
                    }
                    matrix[i, j] = sumA;
                    matrix[i, basis] = sumB;
                }
            }
            return matrix;
        }
        private double[,] MakeStepb(double[,] xyTable)
        {
            /*
            xyTable[0, 0] = 0.1;xyTable[0, 1] = 0.1;xyTable[0, 2] = 0.2;xyTable[0, 3] = 0.3;xyTable[0, 4] = 0.4;
            xyTable[0, 5] = 0.5;xyTable[0, 6] = 0.6;xyTable[0, 7] = 0.7;xyTable[0, 8] = 0.8;xyTable[0, 9] = 0.9;
            xyTable[1, 0] = 3;xyTable[1, 1] = 3.664;xyTable[1, 2] = 4.475;xyTable[1, 3] = 5.467;xyTable[1, 4] = 6.677;
            xyTable[1, 5] = 8.155;xyTable[1, 6] = 9.96;xyTable[1, 7] = 12.166;xyTable[1, 8] = 14.859;xyTable[1, 9] = 18.149;*/
            int basis =2;
            double[,] matrix = new double[basis, basis + 1];
            for (int i = 0; i < basis; i++)
            {
                for (int j = 0; j < basis; j++)
                {
                    matrix[i, j] = 0;
                }
            }
            for (int i = 0; i < basis; i++)
            {
                for (int j = 0; j < basis; j++)
                {
                    double sumA = 0, sumB = 0;
                    for (int k = 0; k < xyTable.Length / 2; k++)
                    {
                        sumA += Math.Pow(xyTable[0, k], -i) * Math.Pow(xyTable[0, k], -j);
                        sumB += xyTable[1, k] * Math.Pow(xyTable[0, k], -i);
                    }
                    matrix[i, j] = sumA;
                    matrix[i, basis] = sumB;
                }
            }
            return matrix;
        }
        static double[] Gauss(double[][] A, int size) {

            // Создаем наш вектор решений
            double[] Result = new double[size];
          
            double[][] copyA = MatrixCreate(size, size);
       
            double[] copyVec = new double[size];
           
            for (int i = 0; i < size; i++) {
                for (int j = 0; j < size; j++) {
                      copyA[i][j] = A[i][j];
                }
                copyVec[i] = A[i][size];
                Result[i] = A[i][size];
            }

            //Решаем нашу матрицу
            for (int i = 0; i < size - 1; i++)
            {
                SortRow(copyA, copyVec, size, i);

                for (int j = i + 1; j < size; j++) {
                    if (copyA[i][i] != 0) {
                        double multi = copyA[j][i]  / copyA[i][i];
                        for (int k = i; k < size; k++) {
                            copyA[j][k] = copyA[j][k] - (copyA[i][k] * multi);
                        }
                        copyVec[j] = copyVec[j] - (copyVec[i] * multi);
                    }
                }
            }
            // Детерминант
            //double d = copyA[0][0]* copyA[1][1] * copyA[2][2] * copyA[3][3];
            //Console.WriteLine("\nДетерминант метод Гаусса: " + d);
            //ищем решение
            for (int i = size - 1; i >= 0; i--) {
                Result[i] = copyVec[i];
                for (int j = size - 1; j > i; j--) {
                    Result[i] = Result[i] - (copyA[i][j] * Result[j]);
                }
                if (copyA[i][i] == 0) {
                    if (Result[i] == 0) {
                        Console.WriteLine("имеет множество решений");
                    }
                    else
                    {
                        Console.WriteLine("нет решений");

                    }
                }
                 Result[i] = Result[i] / copyA[i][i];
            }
            // Детерминант
            //double d = determinant(A, size);
            //Console.WriteLine("\nДетерминант метод Гаусса: "+ d);

            // Оценка ошибки
            //double mistake = EstimateError(A, vec, Result);

            //Console.WriteLine("Погрешность для метода Гаусса: " + mistake * 100 + " в процентах");


            return Result;
        }
        static void SortRow(double[][] A, double[] vec,  int size, int sortIndex)
        {
            double maxElement = A[sortIndex][sortIndex];
            int maxElementIndex = sortIndex;

            for (int i = sortIndex + 1; i < size; i++) {
                if (A[i][sortIndex] > maxElement) {
                    maxElement = A[i][sortIndex];
                    maxElementIndex = i;
                }
            }
            //теперь найден максимальный элемент ставим его на верхнее место
            if (maxElementIndex > sortIndex) { // если это не первый элемент
                //TODO: заменить на swap()
                double temp = vec[maxElementIndex];
                vec[maxElementIndex]= vec[sortIndex];
                vec[sortIndex] = temp;


                for (int i = 0; i < size; i++) {
                    temp = A[maxElementIndex][i];
                    A[maxElementIndex][i] = A[sortIndex][i];
                    A[sortIndex][i] = temp;

                }
            }
        }


       
    }
}