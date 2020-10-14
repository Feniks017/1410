using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace matrix
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void OnClearButton_Click(object sender, EventArgs e)//очищаем матрицу А
        {
            int collCount = matrixA.ColumnCount;
            int rowCount = matrixA.RowCount;

            for (int i = 0; i < collCount; i++)
                for (int j = 0; j < rowCount; j++)
                {
                    matrixA.Rows[j].Cells[i].Value = 0;
                }
        }

        private void plusButton_Click(object sender, EventArgs e)//сложение матриц
        {
            
                int colCount = resultMatrix.ColumnCount = matrixA.ColumnCount;
                int rowCount = resultMatrix.RowCount = matrixA.RowCount;
            try
            {
                for (int j = 0; j < colCount; j++)
                    for (int i = 0; i < rowCount; i++)
                    {
                        resultMatrix[j, i].Value = Convert.ToDouble(matrixA[j, i].Value) + Convert.ToDouble(matrixB[j, i].Value);
                    }
            }
            catch
            {
                colCount = resultMatrix.ColumnCount = 2;
                rowCount = resultMatrix.RowCount = 2;
                for (int j = 0; j < colCount; j++)
                    for (int i = 0; i < rowCount; i++)
                    {
                        resultMatrix[j, i].Value = 0;
                    }
                MessageBox.Show("неверный формат данных");
            }
        }

        private void minusButton_Click(object sender, EventArgs e)//вычитание матриц
        {
            
                int colCount = resultMatrix.ColumnCount = matrixA.ColumnCount;
                int rowCount = resultMatrix.RowCount = matrixA.RowCount;
            try
            {
                for (int j = 0; j < colCount; j++)
                    for (int i = 0; i < rowCount; i++)
                    {
                        resultMatrix[j, i].Value = Convert.ToDouble(matrixA[j, i].Value) - Convert.ToDouble(matrixB[j, i].Value);
                    }
            }
            catch
            {
                colCount = resultMatrix.ColumnCount = 2;
                rowCount = resultMatrix.RowCount = 2;
                for (int j = 0; j < colCount; j++)
                    for (int i = 0; i < rowCount; i++)
                    {
                        resultMatrix[j, i].Value = 0;
                    }
                MessageBox.Show("неверный формат данных");
            }
        }

        private void multButton_Click(object sender, EventArgs e)//умножение матриц
        {
            
                int colCount = resultMatrix.ColumnCount = matrixB.ColumnCount;
                int rowCount = resultMatrix.RowCount = matrixA.RowCount;
                int tempIter = matrixA.ColumnCount;
            try
            { 
                for (int i = 0; i < colCount; i++)
                    for(int j = 0; j < rowCount; j++)
                    {
                        double temp = 0;
                        for (int k = 0; k < tempIter; k++)
                            temp += Convert.ToDouble(matrixA[k,j].Value) * Convert.ToDouble(matrixB[i,k].Value);
                        resultMatrix[i, j].Value = temp;
                    }
            }
            catch
            {
                colCount = resultMatrix.ColumnCount = 2;
                rowCount = resultMatrix.RowCount = 2;
                for (int j = 0; j < colCount; j++)
                    for (int i = 0; i < rowCount; i++)
                    {
                        resultMatrix[j, i].Value = 0;
                    }
                MessageBox.Show("неверный формат данных");
            }
        }

        private void transButton_Click(object sender, EventArgs e)//транспонирование матрицы А
        {
            
            int colCount = resultMatrix.ColumnCount = matrixA.RowCount;
            int rowCount = resultMatrix.RowCount = matrixA.ColumnCount;
            try
            {
                for (int i = 0; i < colCount; i++)
                    for (int j = 0; j < rowCount; j++)
                    {
                        resultMatrix[i, j].Value = Convert.ToDouble(matrixA[j, i].Value);
                    }
            }
            catch
            {
                colCount = resultMatrix.ColumnCount = 2;
                rowCount = resultMatrix.RowCount = 2;
                for (int j = 0; j < colCount; j++)
                    for (int i = 0; i < rowCount; i++)
                    {
                        resultMatrix[j, i].Value = 0;
                    }
                MessageBox.Show("неверный формат данных");
            }
        }

        private void detButton_Click(object sender, EventArgs e)//определитель
        {
            try
            {
                int colCount = matrixA.ColumnCount;
                int rowCount = matrixA.RowCount;
                double[,] matrix = new double[colCount, rowCount];
                for (int i = 0; i < colCount; i++)
                    for (int j = 0; j < rowCount; j++)
                        matrix[i, j] = Convert.ToDouble(matrixA[i,j].Value);
                MessageBox.Show(Determinant(matrix).ToString(), "determinate", MessageBoxButtons.OK);
            }
            catch
            {
                MessageBox.Show("неверный формат данных");
            }
        }
  
        private void Form1_Load(object sender, EventArgs e)
        {
            matrixA.ColumnCount = matrixB.ColumnCount = resultMatrix.ColumnCount = 2;
            matrixA.RowCount = matrixB.RowCount = resultMatrix.RowCount = 2;
            colA.Value = colB.Value = 2;
            rowA.Value = rowB.Value = 2;

        }

        private void colRow_ValueChanged(object sender, EventArgs e)
        {
            matrixA.ColumnCount = (int)colA.Value;
            matrixA.RowCount = (int)rowA.Value;
            matrixB.ColumnCount = (int)colB.Value;
            matrixB.RowCount = (int)rowB.Value;

            if (matrixA.ColumnCount == matrixB.ColumnCount && matrixA.RowCount == matrixB.RowCount)//проверяем размерность матриц для сложения/вычитания
            {
                plusButton.Enabled = true;
                minusButton.Enabled = true;
            }
            else
            {
                plusButton.Enabled = false;
                minusButton.Enabled = false;
            }

            if (matrixA.ColumnCount == matrixB.RowCount)//проверяем размерность матриц для умножения
            {
                multButton.Enabled = true;
            }
            else
            {
                multButton.Enabled = false;
            }

            if (matrixA.ColumnCount == matrixA.RowCount)//проверяем является матрица А квадратной
            {
                detButton.Enabled = true;
                invButton.Enabled = true;
            }
            else
            {
                detButton.Enabled = false;
                invButton.Enabled = false;
            }
        }

        private void constValueBox_TextChanged(object sender, EventArgs e)//делаем умножение на константу доступным при заданой константе
        {
            if (constValueBox.Text == "")
            {
                constButton.Enabled = false;
            }
            else
            {
                constButton.Enabled = true;
            }
        }

        private void constValueBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8) && e.KeyChar != '-' && e.KeyChar != ',')
            {
                e.Handled = true;
            }
        }

        private void matrixA_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            TextBox tb = (TextBox)e.Control;
            tb.KeyPress += new KeyPressEventHandler(tb_KeyPress);
            
        }

        private void tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && (e.KeyChar != '-') && (e.KeyChar != ',') && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
        }

        private void matrixA_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)//запрещаем пользователю оставлять ячейку без значения
        {
            if (string.IsNullOrEmpty(e.FormattedValue.ToString()))
            {
                e.Cancel = true;
            }
            
        }

        private void button2_Click(object sender, EventArgs e)//очищаем матрицу В
        {
            int collCount = matrixB.ColumnCount;
            int rowCount = matrixB.RowCount;

            for (int i = 0; i < collCount; i++)
                for (int j = 0; j < rowCount; j++)
                {
                    matrixB.Rows[j].Cells[i].Value = 0;
                }
        }

        private void constButton_Click(object sender, EventArgs e)//умножение на константу
        {
                int colCount = resultMatrix.ColumnCount = matrixA.ColumnCount;
                int rowCount = resultMatrix.RowCount = matrixA.RowCount;
            try
            {
                double number = Convert.ToDouble(constValueBox.Text);
                for (int j = 0; j < colCount; j++)
                    for (int i = 0; i < rowCount; i++)
                    {
                        resultMatrix[j,i].Value = Convert.ToDouble(matrixA[j,i].Value) * number;
                    }
            }
            catch
            {
                colCount = resultMatrix.ColumnCount = 2;
                rowCount = resultMatrix.RowCount = 2;
                for (int j = 0; j < colCount; j++)
                    for (int i = 0; i < rowCount; i++)
                    {
                        resultMatrix[j, i].Value = 0;
                    }
                constValueBox.Clear();
                MessageBox.Show("неверный формат данных");
            }
        }

        public static double[,] Minor(double[,] matrix, int row, int col)//вычисление минора
        {
            int n = matrix.GetLength(0);
            double[,] minor = new double[n - 1, n - 1];
            int mi = 0;
            int mj = 0;
            for (int i = 0; i < n; i++)
            {
                if (i == row)
                    continue;
                mj = 0;
                for (int j = 0; j < n; j++)
                {
                    if (j == col)
                        continue;
                    
                    minor[mi, mj] = matrix[i, j];
                    mj++;
                }
                mi++;
            }
            return minor;
        }

        public static double Determinant(double[,] matrix)//вычисление определителя
        {
            double result = 0.0;
            int n = matrix.GetLength(0);
            if (n == 1)
                result = matrix[0, 0];
            else if (n == 2)
            {
                result = matrix[0, 0] * matrix[1, 1] - matrix[1, 0] * matrix[0, 1];
            }
            else
            {
                for (int i = 0; i < n; i++)
                {
                    result += Math.Pow(-1, i) * matrix[0, i] * Determinant(Minor(matrix, 0, i));
                }
            }
            return result;
        }
        
        private void inverseButton_Click(object sender, EventArgs e)//обратная матрица
        {
            
                int count = matrixA.ColumnCount;
                resultMatrix.ColumnCount = resultMatrix.RowCount = count;
            try{
                double[,] matrix = new double[count, count];
                for (int i = 0; i < count; i++)
                    for (int j = 0; j < count; j++)
                        matrix[i, j] = Convert.ToDouble(matrixA[j, i].Value);

                double det = Determinant(matrix);
            
                if (det == 0)
                { 
                    MessageBox.Show("Невозможно найти обратную матрицу");
                    return;
                }

                matrix = inverse(matrix);

                for (int i = 0; i < count; i++)
                    for (int j = 0; j < count; j++)
                        resultMatrix[i, j].Value = matrix[j, i];
            }
            catch
            {
                count = resultMatrix.ColumnCount = resultMatrix.RowCount = 2;

                for (int j = 0; j < count; j++)
                    for (int i = 0; i < count; i++)
                    {
                        resultMatrix[j, i].Value = 0;
                    }
                MessageBox.Show("неверный формат данных");
            }

        }

        public static double[,] inverse(double[,] matrix)
        {
            int n = matrix.GetLength(0);
            double det = Determinant(matrix);
            matrix = Adjoint(matrix);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] /= det;
                }
            }
            return matrix;
        } 
        public static double[,] Adjoint(double[,] matrix)
        {
            int n = matrix.GetLength(0);
            double[,] tempMatrix = new double[n, n];
           
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    tempMatrix[i, j] = Math.Pow(-1, i + j) * (Determinant(Minor(matrix, i, j)));
                }
            }


            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = tempMatrix[j, i];
                }

            return matrix;
        }
        
    }
}
