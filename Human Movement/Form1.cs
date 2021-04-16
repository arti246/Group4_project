using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;

namespace Human_Movement
{
    public partial class Form1 : Form
    {
        public string code;
        public int ErrorValue;
        public int Row;//количесвто строк в группе
        public string NameMovies;

        public Form1()
        {
            InitializeComponent();

            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;

            this.WindowState = FormWindowState.Maximized;
            this.TopMost = true;

            ToolTip t = new ToolTip();
            t.SetToolTip(pictureBoxHand, "Рука");
            t.SetToolTip(pictureBox2, "Спина");
            t.SetToolTip(pictureBox3, "Нога");

        }

        public void CreateTable1()
        {
            int column = Convert.ToInt32(numericUpDown1.Value);
            int takts = Convert.ToInt32(numericUpDown3.Value);

            dataGridView1.RowCount = Row;
            dataGridView1.ColumnCount = column * takts;

            //заполнение название столбцов
            int count = 0;
            int count1 = 0;
            for (int i = 0; i < column; i++)
            {
                for (int j = 0; j < takts; j++)
                {
                    count++;
                    dataGridView1.Columns[count1].HeaderText = Convert.ToString(count) + "/" + Convert.ToString(numericUpDown2.Value);
                    count1++;
                }
                count = 0;
            }

            //заполнение название строк
            for (int i = 0; (i <= (dataGridView1.Rows.Count - 1)); i++)
                dataGridView1.Rows[i].HeaderCell.Value = string.Format((i + 1).ToString(), "0");

            //изменение ширины столбцов
            for (int i = 0; i < column * takts; i++)
                dataGridView1.Columns[i].Width = 45;

            //изменение высоты строк
            for (int i = 0; i < Row; i++)
                dataGridView1.Rows[i].Height = 27;

            //ширина столбца заголовков строк
            dataGridView1.RowHeadersWidth = 50;

            //заполнение название таблицы
            dataGridView1.TopLeftHeaderCell.Value = NameMovies;
        }

        public void CreateTable2()
        {
            int column = Convert.ToInt32(numericUpDown1.Value);
            int takts = Convert.ToInt32(numericUpDown3.Value);

            dataGridView2.RowCount = Row;
            dataGridView2.ColumnCount = column * takts;

            //заполнение название столбцов
            int count = 0;
            int count1 = 0;
            for (int i = 0; i < column; i++)
            {
                for (int j = 0; j < takts; j++)
                {
                    count++;
                    dataGridView2.Columns[count1].HeaderText = Convert.ToString(count) + "/" + Convert.ToString(numericUpDown2.Value);
                    count1++;
                }
                count = 0;
            }

            //заполнение название строк
            for (int i = 0; (i <= (dataGridView2.Rows.Count - 1)); i++)
                dataGridView2.Rows[i].HeaderCell.Value = string.Format((i + 1).ToString(), "0");

            //изменение ширины столбцов
            for (int i = 0; i < column * takts; i++)
                dataGridView2.Columns[i].Width = 45;

            //изменение высоты строк
            for (int i = 0; i < Row; i++)
                dataGridView2.Rows[i].Height = 27;

            //ширина столбца заголовков строк
            dataGridView2.RowHeadersWidth = 50;

            //заполнение название таблицы
            dataGridView2.TopLeftHeaderCell.Value = NameMovies;
        }

        public void CreateTable3()
        {
            int column = Convert.ToInt32(numericUpDown1.Value);
            int takts = Convert.ToInt32(numericUpDown3.Value);

            dataGridView3.RowCount = Row;
            dataGridView3.ColumnCount = column * takts;

            //заполнение название столбцов
            int count = 0;
            int count1 = 0;
            for (int i = 0; i < column; i++)
            {
                for (int j = 0; j < takts; j++)
                {
                    count++;
                    dataGridView3.Columns[count1].HeaderText = Convert.ToString(count) + "/" + Convert.ToString(numericUpDown2.Value);
                    count1++;
                }
                count = 0;
            }

            //заполнение название строк
            for (int i = 0; (i <= (dataGridView3.Rows.Count - 1)); i++)
                dataGridView3.Rows[i].HeaderCell.Value = string.Format((i + 1).ToString(), "0");

            //изменение ширины столбцов
            for (int i = 0; i < column * takts; i++)
                dataGridView3.Columns[i].Width = 45;

            //изменение высоты строк
            for (int i = 0; i < Row; i++)
                dataGridView3.Rows[i].Height = 27;

            //ширина столбца заголовков строк
            dataGridView3.RowHeadersWidth = 50;

            //заполнение название таблицы
            dataGridView3.TopLeftHeaderCell.Value = NameMovies;
        }

        private void закрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileToJson();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void ConvertToJsonTable1()//доделать
        {
            int column = Convert.ToInt32(numericUpDown1.Value);
            int takts = Convert.ToInt32(numericUpDown3.Value);
            int countcolumns = 0;

            code = "{\n";
            for (int i = 0; i < column * takts; i++)
            {
                code += "  \"" + countcolumns + "\":\n";
                code += "  {\n    \"";
                code += dataGridView1.Columns[i].HeaderText;
                code += "\":\n    {\n      ";
                for (int j = 0; j < Row; j++)
                {
                    if (dataGridView1.Rows[j].Cells[i].Style.ForeColor == Color.Red)
                        code += "\"Правое плечо вперед\"";
                    if (dataGridView1.Rows[j].Cells[i].Style.ForeColor == Color.Aqua)
                        code += "\"Правое плечо вверх\"";
                    if (dataGridView1.Rows[j].Cells[i].Style.ForeColor == Color.Blue)
                        code += "\"Правое плечо вниз\"";
                    if (dataGridView1.Rows[j].Cells[i].Style.ForeColor == Color.Brown)
                        code += "\"Правое плечо назад\"";
                    if (dataGridView1.Rows[j].Cells[i].Style.ForeColor == Color.Chartreuse)
                        code += "\"Правое плечо влево\"";
                    if (dataGridView1.Rows[j].Cells[i].Style.ForeColor == Color.Coral)
                        code += "\"Правый локоть вбок\"";
                    if (dataGridView1.Rows[j].Cells[i].Style.ForeColor == Color.DarkGreen)
                        code += "\"Правый локоть вверх\"";
                    if (dataGridView1.Rows[j].Cells[i].Style.ForeColor == Color.Orange)
                        code += "\"Правый локоть вниз\"";
                    if (dataGridView1.Rows[j].Cells[i].Style.ForeColor == Color.ForestGreen)
                        code += "\"Правый локоть влево\"";
                    if (dataGridView1.Rows[j].Cells[i].Style.ForeColor == Color.Fuchsia)
                        code += "\"Правый локоть согнуть до конца\"";
                    if (dataGridView1.Rows[j].Cells[i].Style.ForeColor == Color.Gold)
                        code += "\"Левое плечо вперед\"";
                    if (dataGridView1.Rows[j].Cells[i].Style.ForeColor == Color.Gray)
                        code += "\"Левое плечо вверх\"";
                    if (dataGridView1.Rows[j].Cells[i].Style.ForeColor == Color.Green)
                        code += "\"Левое плечо вниз\"";
                    if (dataGridView1.Rows[j].Cells[i].Style.ForeColor == Color.GreenYellow)
                        code += "\"Левое плечо назад\"";
                    if (dataGridView1.Rows[j].Cells[i].Style.ForeColor == Color.Indigo)
                        code += "\"Левое плечо вправо\"";
                    if (dataGridView1.Rows[j].Cells[i].Style.ForeColor == Color.Silver)
                        code += "\"Левый локоть вбок\"";
                    if (dataGridView1.Rows[j].Cells[i].Style.ForeColor == Color.MediumVioletRed)
                        code += "\"Левый локоть вверх\"";
                    if (dataGridView1.Rows[j].Cells[i].Style.ForeColor == Color.Purple)
                        code += "\"Левый локоть вниз\"";
                    if (dataGridView1.Rows[j].Cells[i].Style.ForeColor == Color.SpringGreen)
                        code += "\"Левый локоть влево\"";
                    if (dataGridView1.Rows[j].Cells[i].Style.ForeColor == Color.ForestGreen)
                        code += "\"Левый локоть согнуть до конца\"";

                    code += ":\"";
                    code += dataGridView1.Rows[j].Cells[i].Value;
                    code += "\"";

                    if (j == Row - 1 && i == column * takts - 1)// если последняя ячейка в последнем столбце
                    {
                        code += "\n    }\n}";
                        break;
                    }

                    if (j == Row - 1)//если последняя ячейка в строке
                        code += "\n    },\n";
                    else
                        code += ",\n     ";
                }
            }
        }

        public void CheckErrorStrAndValue()
        {
            int row = Convert.ToInt32(numericUpDown1.Value);
            int column = Convert.ToInt32(numericUpDown2.Value);

            int counti;
            int countj;

            int check;

            ErrorValue = 0;
            string p = "";
            for (int i = 0; i < column; i++)
            {
                for (int j = 0; j < row; j++)
                {
                    p += dataGridView1.Rows[j].Cells[i].Value;
                    countj = j + 1;
                    counti = i + 1;

                    if (!int.TryParse(p, out check))//Проверка, если введено не число
                    {
                        MessageBox.Show("Значение ячейки [" + counti + "," + countj + "] должно быть числом!", "Ошибка!",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                        ErrorValue++;
                    }
                    else
                    {
                        if (dataGridView1.Rows[j].Cells[i].Style.ForeColor == Color.Red)
                        {

                            if (int.Parse(p) < 0 || int.Parse(p) > 90)//Проверка на диапазон
                            {
                                MessageBox.Show("Значение ячейки [" + counti + "," + countj + "] выходит за границы [0;90]", "Ошибка!",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                                countj = 0;
                                counti = 0;
                                ErrorValue++;
                            }
                        }
                    }

                    p = "";
                }
            }
        }

        public void SaveFileToJson()
        {/*
            int error = 0;

            //Если таблица созданна
            if (dataGridView1.Rows.Count != 0)
            {
                int row = Convert.ToInt32(numericUpDown1.Value);
                int column = Convert.ToInt32(numericUpDown2.Value);

                int countjp;
                int counti;
                int countj;

                //Проверка на одинаковые ячейки в каждом столбце
                for (int i = 0; i < column; i++)
                {
                    for (int j = 0; j < row; j++)
                    {
                        if (j != row - 1)
                        {
                            if (dataGridView1.Rows[j].Cells[i].Style.ForeColor == dataGridView1.Rows[j + 1].Cells[i].Style.ForeColor)
                            {
                                countjp = j + 2;
                                countj = j + 1;
                                counti = i + 1;
                                MessageBox.Show("Ячейки [" + counti + "," + countj + "] и [" + counti + "," + countjp + "] отвечают за одинаковые движения!", 
                                    "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                countjp = 0;
                                countj = 0;
                                counti = 0;
                                error++;
                            }
                        }
                    }
                }
                if (error == 0)//Если ошибок нет
                {
                    //Проверка на правильные значения
                    CheckErrorStrAndValue();
                    if (ErrorValue == 0)
                    {
                        //Коверация данных в формат json
                        ConvertToJson();
            */
                        //Сохранение 
                        ConvertToJsonTable1();
                        SaveFileDialog svf = new SaveFileDialog();
                        svf.ShowDialog();
                        string put = svf.FileName;
                        if (svf.FileName != "")
                        {
                            File.WriteAllText(put, code);
                            MessageBox.Show("Файл сохранен", "Отлично!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }/*
                    }
                    else
                    {
                        MessageBox.Show("Найдено ошибок " + ErrorValue + ". Если вы сохраните данные в файл, то он будет работать некорректно", 
                            "Вы точно хотите сохранить?", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                } 
            }
            //Если таблица не созданна
            else
            {
                ErrorTableNot();
            }
                        */
        }

        public void ErrorTableNot()
        {
            MessageBox.Show("Заполните таблицу перед тем, как сохранить файл", "Таблица пустая!"
                , MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ButtonColor()//метод для покраски активной строки в цвет
        {
            int column = Convert.ToInt32(numericUpDown1.Value);
            int takts = Convert.ToInt32(numericUpDown3.Value);

            for (int i = 0; i < Row; i++)
            {
                for (int j = 0; j < column * takts; j++)
                {
                    if (takts == numericUpDown3.Value && column == numericUpDown1.Value)//выдаёт ошибку при изменении параметров таблицы
                    {
                        if (NameMovies == "Рука" && dataGridView1.CurrentCell.RowIndex == i)
                            dataGridView1.Rows[i].Cells[j].Style.ForeColor = dataGridView1.CurrentCell.Style.ForeColor;
                        if (NameMovies == "Спина" && dataGridView2.CurrentCell.RowIndex == i)
                            dataGridView2.Rows[i].Cells[j].Style.ForeColor = dataGridView2.CurrentCell.Style.ForeColor;
                        if (NameMovies == "Нога" && dataGridView3.CurrentCell.RowIndex == i)
                            dataGridView3.Rows[i].Cells[j].Style.ForeColor = dataGridView3.CurrentCell.Style.ForeColor;
                    }
                    else
                    {
                        MessageBox.Show("Найдено ошибок " + ErrorValue + ". Если вы сохраните данные в файл, то он будет работать некорректно",
                            "Вы точно хотите сохранить?", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            SaveFileToJson();
        }

        private void button_Move1_Click(object sender, EventArgs e)
        {
            if (NameMovies == "Рука")
                dataGridView1.CurrentCell.Style.ForeColor = Color.Red;
            if (NameMovies == "Спина")
                dataGridView2.CurrentCell.Style.ForeColor = Color.Red;
            if (NameMovies == "Нога")
                dataGridView3.CurrentCell.Style.ForeColor = Color.Red;
            ButtonColor();
        }

        private void button_Move2_Click(object sender, EventArgs e)
        {
            if (NameMovies == "Рука")
                dataGridView1.CurrentCell.Style.ForeColor = Color.Aqua;
            if (NameMovies == "Спина")
                dataGridView2.CurrentCell.Style.ForeColor = Color.Aqua;
            if (NameMovies == "Нога")
                dataGridView3.CurrentCell.Style.ForeColor = Color.Aqua;
            ButtonColor();
        }

        private void button_Move3_Click(object sender, EventArgs e)
        {
            if (NameMovies == "Рука")
                dataGridView1.CurrentCell.Style.ForeColor = Color.Blue;
            if (NameMovies == "Спина")
                dataGridView2.CurrentCell.Style.ForeColor = Color.Blue;
            if (NameMovies == "Нога")
                dataGridView3.CurrentCell.Style.ForeColor = Color.Blue;
            ButtonColor();
        }

        private void button_Move4_Click(object sender, EventArgs e)
        {
            if (NameMovies == "Рука")
                dataGridView1.CurrentCell.Style.ForeColor = Color.Brown;
            if (NameMovies == "Спина")
                dataGridView2.CurrentCell.Style.ForeColor = Color.Brown;
            if (NameMovies == "Нога")
                dataGridView3.CurrentCell.Style.ForeColor = Color.Brown;
            ButtonColor();
        }

        private void button_Move5_Click(object sender, EventArgs e)
        {
            if (NameMovies == "Рука")
                dataGridView1.CurrentCell.Style.ForeColor = Color.Chartreuse;
            if (NameMovies == "Спина")
                dataGridView2.CurrentCell.Style.ForeColor = Color.Chartreuse;
            if (NameMovies == "Нога")
                dataGridView3.CurrentCell.Style.ForeColor = Color.Chartreuse;
            ButtonColor();
        }

        private void button_Move6_Click(object sender, EventArgs e)
        {
            if (NameMovies == "Рука")
                dataGridView1.CurrentCell.Style.ForeColor = Color.Coral;
            if (NameMovies == "Спина")
                dataGridView2.CurrentCell.Style.ForeColor = Color.Coral;
            if (NameMovies == "Нога")
                dataGridView3.CurrentCell.Style.ForeColor = Color.Coral;
            ButtonColor();
        }

        private void button_Move7_Click(object sender, EventArgs e)
        {
            if (NameMovies == "Рука")
                dataGridView1.CurrentCell.Style.ForeColor = Color.DarkGreen;
            if (NameMovies == "Спина")
                dataGridView2.CurrentCell.Style.ForeColor = Color.DarkGreen;
            if (NameMovies == "Нога")
                dataGridView3.CurrentCell.Style.ForeColor = Color.DarkGreen;
            ButtonColor();
        }

        private void button_Move8_Click(object sender, EventArgs e)
        {
            if (NameMovies == "Рука")
                dataGridView1.CurrentCell.Style.ForeColor = Color.Orange;
            if (NameMovies == "Спина")
                dataGridView2.CurrentCell.Style.ForeColor = Color.Orange;
            if (NameMovies == "Нога")
                dataGridView3.CurrentCell.Style.ForeColor = Color.Orange;
            ButtonColor();
        }

        private void button_Move9_Click(object sender, EventArgs e)
        {
            if (NameMovies == "Рука")
                dataGridView1.CurrentCell.Style.ForeColor = Color.ForestGreen;
            if (NameMovies == "Спина")
                dataGridView2.CurrentCell.Style.ForeColor = Color.ForestGreen;
            if (NameMovies == "Нога")
                dataGridView3.CurrentCell.Style.ForeColor = Color.ForestGreen;
            ButtonColor();
        }

        private void button_Move10_Click(object sender, EventArgs e)
        {
            if (NameMovies == "Рука")
                dataGridView1.CurrentCell.Style.ForeColor = Color.Fuchsia;
            if (NameMovies == "Спина")
                dataGridView2.CurrentCell.Style.ForeColor = Color.Fuchsia;
            if (NameMovies == "Нога")
                dataGridView3.CurrentCell.Style.ForeColor = Color.Fuchsia;
            ButtonColor();
        }

        private void button_Move11_Click(object sender, EventArgs e)
        {
            if (NameMovies == "Рука")
                dataGridView1.CurrentCell.Style.ForeColor = Color.Gold;
            if (NameMovies == "Спина")
                dataGridView2.CurrentCell.Style.ForeColor = Color.Gold;
            if (NameMovies == "Нога")
                dataGridView3.CurrentCell.Style.ForeColor = Color.Gold;
            ButtonColor();
        }

        private void button_Move12_Click(object sender, EventArgs e)
        {
            if (NameMovies == "Рука")
                dataGridView1.CurrentCell.Style.ForeColor = Color.Gray;
            if (NameMovies == "Спина")
                dataGridView2.CurrentCell.Style.ForeColor = Color.Gray;
            if (NameMovies == "Нога")
                dataGridView3.CurrentCell.Style.ForeColor = Color.Gray;
            ButtonColor();
        }

        private void button_Move13_Click(object sender, EventArgs e)
        {
            if (NameMovies == "Рука")
                dataGridView1.CurrentCell.Style.ForeColor = Color.Green;
            if (NameMovies == "Спина")
                dataGridView2.CurrentCell.Style.ForeColor = Color.Green;
            if (NameMovies == "Нога")
                dataGridView3.CurrentCell.Style.ForeColor = Color.Green;
            ButtonColor();
        }

        private void button_Move14_Click(object sender, EventArgs e)
        {
            if (NameMovies == "Рука")
                dataGridView1.CurrentCell.Style.ForeColor = Color.GreenYellow;
            if (NameMovies == "Спина")
                dataGridView2.CurrentCell.Style.ForeColor = Color.GreenYellow;
            if (NameMovies == "Нога")
                dataGridView3.CurrentCell.Style.ForeColor = Color.GreenYellow;
            ButtonColor();
        }

        private void button_Move15_Click(object sender, EventArgs e)
        {
            if (NameMovies == "Рука")
                dataGridView1.CurrentCell.Style.ForeColor = Color.Indigo;
            if (NameMovies == "Спина")
                dataGridView2.CurrentCell.Style.ForeColor = Color.Indigo;
            if (NameMovies == "Нога")
                dataGridView3.CurrentCell.Style.ForeColor = Color.Indigo;
            ButtonColor();
        }

        private void button_Move16_Click(object sender, EventArgs e)
        {
            if (NameMovies == "Рука")
                dataGridView1.CurrentCell.Style.ForeColor = Color.Silver; ;
            if (NameMovies == "Спина")
                dataGridView2.CurrentCell.Style.ForeColor = Color.Silver; ;
            if (NameMovies == "Нога")
                dataGridView3.CurrentCell.Style.ForeColor = Color.Silver; ;
            ButtonColor();
        }

        private void button_Move17_Click(object sender, EventArgs e)
        {
            if (NameMovies == "Рука")
                dataGridView1.CurrentCell.Style.ForeColor = Color.MediumVioletRed;
            if (NameMovies == "Спина")
                dataGridView2.CurrentCell.Style.ForeColor = Color.MediumVioletRed;
            if (NameMovies == "Нога")
                dataGridView3.CurrentCell.Style.ForeColor = Color.MediumVioletRed;
            ButtonColor();
        }

        private void button_Move18_Click(object sender, EventArgs e)
        {
            if (NameMovies == "Рука")
                dataGridView1.CurrentCell.Style.ForeColor = Color.Purple;
            if (NameMovies == "Спина")
                dataGridView2.CurrentCell.Style.ForeColor = Color.Purple;
            if (NameMovies == "Нога")
                dataGridView3.CurrentCell.Style.ForeColor = Color.Purple;
            ButtonColor();
        }

        private void button_Move19_Click(object sender, EventArgs e)
        {
            dataGridView1.CurrentCell.Style.ForeColor = Color.SpringGreen;
            if (NameMovies == "Рука")
                dataGridView1.CurrentCell.Style.ForeColor = Color.SpringGreen;
            if (NameMovies == "Спина")
                dataGridView2.CurrentCell.Style.ForeColor = Color.SpringGreen;
            if (NameMovies == "Нога")
                dataGridView3.CurrentCell.Style.ForeColor = Color.SpringGreen;
            ButtonColor();
        }

        private void button_Move20_Click(object sender, EventArgs e)
        {
            if (NameMovies == "Рука")
                dataGridView1.CurrentCell.Style.ForeColor = Color.ForestGreen;
            if (NameMovies == "Спина")
                dataGridView2.CurrentCell.Style.ForeColor = Color.ForestGreen;
            if (NameMovies == "Нога")
                dataGridView3.CurrentCell.Style.ForeColor = Color.ForestGreen;
            ButtonColor();
        }

        private void pictureBox1_Click(object sender, EventArgs e)//рука
        {
            dataGridView1.Visible = true;
            dataGridView2.Visible = false;
            dataGridView3.Visible = false;
            Row = 2;
            button_Move1.Visible = true;
            button_Move2.Visible = true;
            button_Move3.Visible = true;
            button_Move4.Visible = true;
            button_Move5.Visible = true;
            button_Move6.Visible = true;
            button_Move7.Visible = true;
            button_Move8.Visible = true;
            button_Move9.Visible = true;
            button_Move10.Visible = true;
            button_Move11.Visible = true;
            button_Move12.Visible = true;
            button_Move13.Visible = true;
            button_Move14.Visible = true;
            button_Move15.Visible = true;
            button_Move16.Visible = true;
            button_Move17.Visible = true;
            button_Move18.Visible = true;
            button_Move19.Visible = true;
            button_Move20.Visible = true;
            button_Move1.Text = "Правое плечо: вперед";
            button_Move2.Text = "Правое плечо: вверх";
            button_Move3.Text = "Правое плечо: вниз";
            button_Move4.Text = "Правое плечо: назад";
            button_Move5.Text = "Правый локоть: влево";
            button_Move6.Text = "Правый локоть: вбок";
            button_Move7.Text = "Правый локоть: вверх";
            button_Move8.Text = "Правый локоть: вниз";
            button_Move9.Text = "Правый локоть: влево";
            button_Move10.Text = "Правый локоть: согнуть до конца";
            button_Move11.Text = "Левое плечо: вперед";
            button_Move12.Text = "Левое плечо: вверх";
            button_Move13.Text = "Левое плечо: вниз";
            button_Move14.Text = "Левое плечо: назад";
            button_Move15.Text = "Левое плечо: вправо";
            button_Move16.Text = "Левый локоть: вбок";
            button_Move17.Text = "Левый локоть: вверх";
            button_Move18.Text = "Левый локоть: вниз";
            button_Move19.Text = "Наклон влево";
            button_Move20.Text = "Левый локоть: согнуть до конца";
            CreateTable1();
            NameMovies= "Рука";
            pictureBoxTypes.Image = imageList1.Images[0];
        }

        private void pictureBox2_Click(object sender, EventArgs e)//Спина
        {
            dataGridView1.Visible = false;
            dataGridView2.Visible = true;
            dataGridView3.Visible = false;
            Row = 10;
            button_Move1.Visible = true;
            button_Move2.Visible = true;
            button_Move3.Visible = true;
            button_Move4.Visible = true;
            button_Move5.Visible = true;
            button_Move6.Visible = true;
            button_Move7.Visible = true;
            button_Move8.Visible = true;
            button_Move9.Visible = true;
            button_Move10.Visible = true;
            button_Move1.Text = "Голова: вперед";
            button_Move2.Text = "Голова: назад";
            button_Move3.Text = "Голова: влево";
            button_Move4.Text = "Голова: вправо";
            button_Move5.Text = "Талия: наклон вперед";
            button_Move6.Text = "Талия: наклон назад ";
            button_Move7.Text = "Наклон вправо";
            button_Move8.Text = "Наклон влево";
            button_Move9.Text = "Наклон вперед";
            button_Move10.Text = "Наклон назад";
            button_Move11.Visible = false;
            button_Move12.Visible = false;
            button_Move13.Visible = false;
            button_Move14.Visible = false;
            button_Move15.Visible = false;
            button_Move16.Visible = false;
            button_Move17.Visible = false;
            button_Move18.Visible = false;
            button_Move19.Visible = false;
            button_Move20.Visible = false;
            CreateTable2();
            NameMovies = "Спина";
            pictureBoxTypes.Image = imageList1.Images[1];
        }

        private void pictureBox3_Click(object sender, EventArgs e)//нога
        {
            dataGridView1.Visible = false;
            dataGridView2.Visible = false;
            dataGridView3.Visible = true;
            Row = 10;
            button_Move1.Visible = true;
            button_Move2.Visible = true;
            button_Move3.Visible = true;
            button_Move4.Visible = true;
            button_Move5.Visible = true;
            button_Move6.Visible = true;
            button_Move7.Visible = true;
            button_Move8.Visible = true;
            button_Move9.Visible = true;
            button_Move10.Visible = true;
            button_Move1.Text = "Тазовый сустав правый: вперед";
            button_Move2.Text = "Тазовый сустав правый: назад";
            button_Move3.Text = "Тазовый сустав правый: вправо";
            button_Move4.Text = "Тазовый сустав правый: влево";
            button_Move5.Text = "Тазовый сустав левый: вперед";
            button_Move6.Text = "Тазовый сустав левый: назад";
            button_Move7.Text = "Тазовый сустав левый: вправо";
            button_Move8.Text = "Тазовый сустав левый: влево ";
            button_Move9.Text = "Правое колено: согнуть";
            button_Move10.Text = "Левое колено: согнуть";
            button_Move11.Visible = false;
            button_Move12.Visible = false;
            button_Move13.Visible = false;
            button_Move14.Visible = false;
            button_Move15.Visible = false;
            button_Move16.Visible = false;
            button_Move17.Visible = false;
            button_Move18.Visible = false;
            button_Move19.Visible = false;
            button_Move20.Visible = false;
            CreateTable3();
            NameMovies = "Нога";
            pictureBoxTypes.Image = imageList1.Images[2];
        }
    }
}