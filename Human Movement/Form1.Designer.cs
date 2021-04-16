namespace Human_Movement
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.закрытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label_tacts = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label_TypeMovements = new System.Windows.Forms.Label();
            this.panel_TypeMovements = new System.Windows.Forms.Panel();
            this.button_Move20 = new System.Windows.Forms.Button();
            this.button_Move19 = new System.Windows.Forms.Button();
            this.button_Move18 = new System.Windows.Forms.Button();
            this.button_Move17 = new System.Windows.Forms.Button();
            this.button_Move16 = new System.Windows.Forms.Button();
            this.button_Move15 = new System.Windows.Forms.Button();
            this.button_Move14 = new System.Windows.Forms.Button();
            this.button_Move13 = new System.Windows.Forms.Button();
            this.button_Move12 = new System.Windows.Forms.Button();
            this.button_Move11 = new System.Windows.Forms.Button();
            this.button_Move10 = new System.Windows.Forms.Button();
            this.button_Move9 = new System.Windows.Forms.Button();
            this.button_Move8 = new System.Windows.Forms.Button();
            this.button_Move7 = new System.Windows.Forms.Button();
            this.button_Move6 = new System.Windows.Forms.Button();
            this.button_Move5 = new System.Windows.Forms.Button();
            this.button_Move4 = new System.Windows.Forms.Button();
            this.button_Move3 = new System.Windows.Forms.Button();
            this.button_Move2 = new System.Windows.Forms.Button();
            this.button_Move1 = new System.Windows.Forms.Button();
            this.button_Save = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxHand = new System.Windows.Forms.PictureBox();
            this.pictureBoxTypes = new System.Windows.Forms.PictureBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.panel_TypeMovements.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTypes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1133, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.закрытьToolStripMenuItem,
            this.сохранитьToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // закрытьToolStripMenuItem
            // 
            this.закрытьToolStripMenuItem.Name = "закрытьToolStripMenuItem";
            this.закрытьToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.закрытьToolStripMenuItem.Text = "Закрыть";
            this.закрытьToolStripMenuItem.Click += new System.EventHandler(this.закрытьToolStripMenuItem_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown3.Location = new System.Drawing.Point(894, 33);
            this.numericUpDown3.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numericUpDown3.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(34, 20);
            this.numericUpDown3.TabIndex = 19;
            this.numericUpDown3.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(836, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Такты:";
            // 
            // label_tacts
            // 
            this.label_tacts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_tacts.AutoSize = true;
            this.label_tacts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_tacts.Location = new System.Drawing.Point(966, 31);
            this.label_tacts.Name = "label_tacts";
            this.label_tacts.Size = new System.Drawing.Size(69, 20);
            this.label_tacts.TabIndex = 15;
            this.label_tacts.Text = "Размер:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(329, 61);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 47;
            this.dataGridView1.Size = new System.Drawing.Size(792, 272);
            this.dataGridView1.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(1074, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 22);
            this.label1.TabIndex = 7;
            this.label1.Text = "/";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown2.Enabled = false;
            this.numericUpDown2.Location = new System.Drawing.Point(1087, 32);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numericUpDown2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(34, 20);
            this.numericUpDown2.TabIndex = 8;
            this.numericUpDown2.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown1.Location = new System.Drawing.Point(1039, 32);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(34, 20);
            this.numericUpDown1.TabIndex = 12;
            this.numericUpDown1.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label_TypeMovements
            // 
            this.label_TypeMovements.AutoSize = true;
            this.label_TypeMovements.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_TypeMovements.Location = new System.Drawing.Point(54, 28);
            this.label_TypeMovements.Name = "label_TypeMovements";
            this.label_TypeMovements.Size = new System.Drawing.Size(124, 20);
            this.label_TypeMovements.TabIndex = 4;
            this.label_TypeMovements.Text = "Вид движения:";
            // 
            // panel_TypeMovements
            // 
            this.panel_TypeMovements.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel_TypeMovements.AutoScroll = true;
            this.panel_TypeMovements.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_TypeMovements.Controls.Add(this.button_Move20);
            this.panel_TypeMovements.Controls.Add(this.button_Move19);
            this.panel_TypeMovements.Controls.Add(this.button_Move18);
            this.panel_TypeMovements.Controls.Add(this.button_Move17);
            this.panel_TypeMovements.Controls.Add(this.button_Move16);
            this.panel_TypeMovements.Controls.Add(this.button_Move15);
            this.panel_TypeMovements.Controls.Add(this.button_Move14);
            this.panel_TypeMovements.Controls.Add(this.button_Move13);
            this.panel_TypeMovements.Controls.Add(this.button_Move12);
            this.panel_TypeMovements.Controls.Add(this.button_Move11);
            this.panel_TypeMovements.Controls.Add(this.button_Move10);
            this.panel_TypeMovements.Controls.Add(this.button_Move9);
            this.panel_TypeMovements.Controls.Add(this.button_Move8);
            this.panel_TypeMovements.Controls.Add(this.button_Move7);
            this.panel_TypeMovements.Controls.Add(this.button_Move6);
            this.panel_TypeMovements.Controls.Add(this.button_Move5);
            this.panel_TypeMovements.Controls.Add(this.button_Move4);
            this.panel_TypeMovements.Controls.Add(this.button_Move3);
            this.panel_TypeMovements.Controls.Add(this.button_Move2);
            this.panel_TypeMovements.Controls.Add(this.button_Move1);
            this.panel_TypeMovements.Location = new System.Drawing.Point(45, 61);
            this.panel_TypeMovements.Name = "panel_TypeMovements";
            this.panel_TypeMovements.Size = new System.Drawing.Size(278, 272);
            this.panel_TypeMovements.TabIndex = 2;
            // 
            // button_Move20
            // 
            this.button_Move20.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Move20.FlatAppearance.BorderColor = System.Drawing.Color.ForestGreen;
            this.button_Move20.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Move20.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Move20.Location = new System.Drawing.Point(14, 612);
            this.button_Move20.Name = "button_Move20";
            this.button_Move20.Size = new System.Drawing.Size(231, 26);
            this.button_Move20.TabIndex = 22;
            this.button_Move20.Text = "Движение";
            this.button_Move20.UseVisualStyleBackColor = true;
            this.button_Move20.Visible = false;
            this.button_Move20.Click += new System.EventHandler(this.button_Move20_Click);
            // 
            // button_Move19
            // 
            this.button_Move19.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Move19.FlatAppearance.BorderColor = System.Drawing.Color.SpringGreen;
            this.button_Move19.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Move19.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Move19.Location = new System.Drawing.Point(14, 580);
            this.button_Move19.Name = "button_Move19";
            this.button_Move19.Size = new System.Drawing.Size(231, 26);
            this.button_Move19.TabIndex = 21;
            this.button_Move19.Text = "Движение";
            this.button_Move19.UseVisualStyleBackColor = true;
            this.button_Move19.Visible = false;
            this.button_Move19.Click += new System.EventHandler(this.button_Move19_Click);
            // 
            // button_Move18
            // 
            this.button_Move18.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Move18.FlatAppearance.BorderColor = System.Drawing.Color.Purple;
            this.button_Move18.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Move18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Move18.Location = new System.Drawing.Point(14, 548);
            this.button_Move18.Name = "button_Move18";
            this.button_Move18.Size = new System.Drawing.Size(231, 26);
            this.button_Move18.TabIndex = 20;
            this.button_Move18.Text = "Движение";
            this.button_Move18.UseVisualStyleBackColor = true;
            this.button_Move18.Visible = false;
            this.button_Move18.Click += new System.EventHandler(this.button_Move18_Click);
            // 
            // button_Move17
            // 
            this.button_Move17.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Move17.FlatAppearance.BorderColor = System.Drawing.Color.MediumVioletRed;
            this.button_Move17.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Move17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Move17.Location = new System.Drawing.Point(14, 516);
            this.button_Move17.Name = "button_Move17";
            this.button_Move17.Size = new System.Drawing.Size(231, 26);
            this.button_Move17.TabIndex = 19;
            this.button_Move17.Text = "Движение";
            this.button_Move17.UseVisualStyleBackColor = true;
            this.button_Move17.Visible = false;
            this.button_Move17.Click += new System.EventHandler(this.button_Move17_Click);
            // 
            // button_Move16
            // 
            this.button_Move16.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Move16.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.button_Move16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Move16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Move16.Location = new System.Drawing.Point(14, 484);
            this.button_Move16.Name = "button_Move16";
            this.button_Move16.Size = new System.Drawing.Size(231, 26);
            this.button_Move16.TabIndex = 18;
            this.button_Move16.Text = "Движение";
            this.button_Move16.UseVisualStyleBackColor = true;
            this.button_Move16.Visible = false;
            this.button_Move16.Click += new System.EventHandler(this.button_Move16_Click);
            // 
            // button_Move15
            // 
            this.button_Move15.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Move15.FlatAppearance.BorderColor = System.Drawing.Color.Indigo;
            this.button_Move15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Move15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Move15.Location = new System.Drawing.Point(14, 452);
            this.button_Move15.Name = "button_Move15";
            this.button_Move15.Size = new System.Drawing.Size(231, 26);
            this.button_Move15.TabIndex = 17;
            this.button_Move15.Text = "Движение";
            this.button_Move15.UseVisualStyleBackColor = true;
            this.button_Move15.Visible = false;
            this.button_Move15.Click += new System.EventHandler(this.button_Move15_Click);
            // 
            // button_Move14
            // 
            this.button_Move14.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Move14.FlatAppearance.BorderColor = System.Drawing.Color.GreenYellow;
            this.button_Move14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Move14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Move14.Location = new System.Drawing.Point(14, 422);
            this.button_Move14.Name = "button_Move14";
            this.button_Move14.Size = new System.Drawing.Size(231, 26);
            this.button_Move14.TabIndex = 16;
            this.button_Move14.Text = "Движение";
            this.button_Move14.UseVisualStyleBackColor = true;
            this.button_Move14.Visible = false;
            this.button_Move14.Click += new System.EventHandler(this.button_Move14_Click);
            // 
            // button_Move13
            // 
            this.button_Move13.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Move13.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.button_Move13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Move13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Move13.Location = new System.Drawing.Point(14, 390);
            this.button_Move13.Name = "button_Move13";
            this.button_Move13.Size = new System.Drawing.Size(231, 26);
            this.button_Move13.TabIndex = 15;
            this.button_Move13.Text = "Движение";
            this.button_Move13.UseVisualStyleBackColor = true;
            this.button_Move13.Visible = false;
            this.button_Move13.Click += new System.EventHandler(this.button_Move13_Click);
            // 
            // button_Move12
            // 
            this.button_Move12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Move12.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button_Move12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Move12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Move12.Location = new System.Drawing.Point(14, 358);
            this.button_Move12.Name = "button_Move12";
            this.button_Move12.Size = new System.Drawing.Size(231, 26);
            this.button_Move12.TabIndex = 14;
            this.button_Move12.Text = "Движение";
            this.button_Move12.UseVisualStyleBackColor = true;
            this.button_Move12.Visible = false;
            this.button_Move12.Click += new System.EventHandler(this.button_Move12_Click);
            // 
            // button_Move11
            // 
            this.button_Move11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Move11.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
            this.button_Move11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Move11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Move11.Location = new System.Drawing.Point(14, 326);
            this.button_Move11.Name = "button_Move11";
            this.button_Move11.Size = new System.Drawing.Size(231, 26);
            this.button_Move11.TabIndex = 13;
            this.button_Move11.Text = "Движение";
            this.button_Move11.UseVisualStyleBackColor = true;
            this.button_Move11.Visible = false;
            this.button_Move11.Click += new System.EventHandler(this.button_Move11_Click);
            // 
            // button_Move10
            // 
            this.button_Move10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Move10.FlatAppearance.BorderColor = System.Drawing.Color.Fuchsia;
            this.button_Move10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Move10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Move10.Location = new System.Drawing.Point(14, 294);
            this.button_Move10.Name = "button_Move10";
            this.button_Move10.Size = new System.Drawing.Size(231, 26);
            this.button_Move10.TabIndex = 12;
            this.button_Move10.Text = "Движение";
            this.button_Move10.UseVisualStyleBackColor = true;
            this.button_Move10.Visible = false;
            this.button_Move10.Click += new System.EventHandler(this.button_Move10_Click);
            // 
            // button_Move9
            // 
            this.button_Move9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Move9.FlatAppearance.BorderColor = System.Drawing.Color.ForestGreen;
            this.button_Move9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Move9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Move9.Location = new System.Drawing.Point(14, 262);
            this.button_Move9.Name = "button_Move9";
            this.button_Move9.Size = new System.Drawing.Size(231, 26);
            this.button_Move9.TabIndex = 11;
            this.button_Move9.Text = "Движение";
            this.button_Move9.UseVisualStyleBackColor = true;
            this.button_Move9.Visible = false;
            this.button_Move9.Click += new System.EventHandler(this.button_Move9_Click);
            // 
            // button_Move8
            // 
            this.button_Move8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Move8.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
            this.button_Move8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Move8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Move8.Location = new System.Drawing.Point(14, 230);
            this.button_Move8.Name = "button_Move8";
            this.button_Move8.Size = new System.Drawing.Size(231, 26);
            this.button_Move8.TabIndex = 10;
            this.button_Move8.Text = "Движение";
            this.button_Move8.UseVisualStyleBackColor = true;
            this.button_Move8.Visible = false;
            this.button_Move8.Click += new System.EventHandler(this.button_Move8_Click);
            // 
            // button_Move7
            // 
            this.button_Move7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Move7.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen;
            this.button_Move7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Move7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Move7.Location = new System.Drawing.Point(14, 198);
            this.button_Move7.Name = "button_Move7";
            this.button_Move7.Size = new System.Drawing.Size(231, 26);
            this.button_Move7.TabIndex = 9;
            this.button_Move7.Text = "Движение";
            this.button_Move7.UseVisualStyleBackColor = true;
            this.button_Move7.Visible = false;
            this.button_Move7.Click += new System.EventHandler(this.button_Move7_Click);
            // 
            // button_Move6
            // 
            this.button_Move6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Move6.FlatAppearance.BorderColor = System.Drawing.Color.Coral;
            this.button_Move6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Move6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Move6.Location = new System.Drawing.Point(14, 166);
            this.button_Move6.Name = "button_Move6";
            this.button_Move6.Size = new System.Drawing.Size(231, 26);
            this.button_Move6.TabIndex = 8;
            this.button_Move6.Text = "Движение";
            this.button_Move6.UseVisualStyleBackColor = true;
            this.button_Move6.Visible = false;
            this.button_Move6.Click += new System.EventHandler(this.button_Move6_Click);
            // 
            // button_Move5
            // 
            this.button_Move5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Move5.FlatAppearance.BorderColor = System.Drawing.Color.Chartreuse;
            this.button_Move5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Move5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Move5.Location = new System.Drawing.Point(14, 134);
            this.button_Move5.Name = "button_Move5";
            this.button_Move5.Size = new System.Drawing.Size(231, 26);
            this.button_Move5.TabIndex = 7;
            this.button_Move5.Text = "Движение";
            this.button_Move5.UseVisualStyleBackColor = true;
            this.button_Move5.Visible = false;
            this.button_Move5.Click += new System.EventHandler(this.button_Move5_Click);
            // 
            // button_Move4
            // 
            this.button_Move4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Move4.FlatAppearance.BorderColor = System.Drawing.Color.Brown;
            this.button_Move4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Move4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Move4.Location = new System.Drawing.Point(14, 102);
            this.button_Move4.Name = "button_Move4";
            this.button_Move4.Size = new System.Drawing.Size(231, 26);
            this.button_Move4.TabIndex = 6;
            this.button_Move4.Text = "Движение";
            this.button_Move4.UseVisualStyleBackColor = true;
            this.button_Move4.Visible = false;
            this.button_Move4.Click += new System.EventHandler(this.button_Move4_Click);
            // 
            // button_Move3
            // 
            this.button_Move3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Move3.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.button_Move3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Move3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Move3.Location = new System.Drawing.Point(14, 68);
            this.button_Move3.Name = "button_Move3";
            this.button_Move3.Size = new System.Drawing.Size(231, 26);
            this.button_Move3.TabIndex = 5;
            this.button_Move3.Text = "Движение";
            this.button_Move3.UseVisualStyleBackColor = true;
            this.button_Move3.Visible = false;
            this.button_Move3.Click += new System.EventHandler(this.button_Move3_Click);
            // 
            // button_Move2
            // 
            this.button_Move2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Move2.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.button_Move2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Move2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Move2.Location = new System.Drawing.Point(14, 36);
            this.button_Move2.Name = "button_Move2";
            this.button_Move2.Size = new System.Drawing.Size(231, 26);
            this.button_Move2.TabIndex = 4;
            this.button_Move2.Text = "Движение";
            this.button_Move2.UseVisualStyleBackColor = true;
            this.button_Move2.Visible = false;
            this.button_Move2.Click += new System.EventHandler(this.button_Move2_Click);
            // 
            // button_Move1
            // 
            this.button_Move1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Move1.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.button_Move1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Move1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Move1.Location = new System.Drawing.Point(14, 4);
            this.button_Move1.Name = "button_Move1";
            this.button_Move1.Size = new System.Drawing.Size(231, 26);
            this.button_Move1.TabIndex = 3;
            this.button_Move1.Text = "Движение";
            this.button_Move1.UseVisualStyleBackColor = true;
            this.button_Move1.Visible = false;
            this.button_Move1.Click += new System.EventHandler(this.button_Move1_Click);
            // 
            // button_Save
            // 
            this.button_Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Save.Location = new System.Drawing.Point(727, 24);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(91, 38);
            this.button_Save.TabIndex = 11;
            this.button_Save.Text = "Сохранить";
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.CreatePrompt = true;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(4, 143);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(35, 35);
            this.pictureBox3.TabIndex = 22;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::Human_Movement.Properties.Resources.Позвоночник;
            this.pictureBox2.Location = new System.Drawing.Point(4, 102);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(35, 35);
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBoxHand
            // 
            this.pictureBoxHand.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxHand.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxHand.Image")));
            this.pictureBoxHand.Location = new System.Drawing.Point(4, 61);
            this.pictureBoxHand.Name = "pictureBoxHand";
            this.pictureBoxHand.Size = new System.Drawing.Size(35, 35);
            this.pictureBoxHand.TabIndex = 20;
            this.pictureBoxHand.TabStop = false;
            this.pictureBoxHand.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBoxTypes
            // 
            this.pictureBoxTypes.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBoxTypes.Location = new System.Drawing.Point(178, 20);
            this.pictureBoxTypes.Name = "pictureBoxTypes";
            this.pictureBoxTypes.Size = new System.Drawing.Size(35, 35);
            this.pictureBoxTypes.TabIndex = 23;
            this.pictureBoxTypes.TabStop = false;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Рука.ico");
            this.imageList1.Images.SetKeyName(1, "Позвоночник.ico");
            this.imageList1.Images.SetKeyName(2, "Нога.ico");
            // 
            // dataGridView2
            // 
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(329, 61);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 47;
            this.dataGridView2.Size = new System.Drawing.Size(792, 272);
            this.dataGridView2.TabIndex = 24;
            // 
            // dataGridView3
            // 
            this.dataGridView3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(329, 61);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 47;
            this.dataGridView3.Size = new System.Drawing.Size(792, 272);
            this.dataGridView3.TabIndex = 25;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.Location = new System.Drawing.Point(45, 339);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(1076, 129);
            this.richTextBox1.TabIndex = 26;
            this.richTextBox1.Text = "Вывод:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 474);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.pictureBoxTypes);
            this.Controls.Add(this.label_TypeMovements);
            this.Controls.Add(this.panel_TypeMovements);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.numericUpDown3);
            this.Controls.Add(this.button_Save);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBoxHand);
            this.Controls.Add(this.label_tacts);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.MinimumSize = new System.Drawing.Size(1150, 400);
            this.Name = "Form1";
            this.Text = "Математическая модель движения человека";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.panel_TypeMovements.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTypes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem закрытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.Panel panel_TypeMovements;
        private System.Windows.Forms.Button button_Move1;
        private System.Windows.Forms.Label label_TypeMovements;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Move8;
        private System.Windows.Forms.Button button_Move7;
        private System.Windows.Forms.Button button_Move6;
        private System.Windows.Forms.Button button_Move5;
        private System.Windows.Forms.Button button_Move4;
        private System.Windows.Forms.Button button_Move3;
        private System.Windows.Forms.Button button_Move2;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.Label label_tacts;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBoxHand;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button_Move20;
        private System.Windows.Forms.Button button_Move19;
        private System.Windows.Forms.Button button_Move18;
        private System.Windows.Forms.Button button_Move17;
        private System.Windows.Forms.Button button_Move16;
        private System.Windows.Forms.Button button_Move15;
        private System.Windows.Forms.Button button_Move14;
        private System.Windows.Forms.Button button_Move13;
        private System.Windows.Forms.Button button_Move12;
        private System.Windows.Forms.Button button_Move11;
        private System.Windows.Forms.Button button_Move10;
        private System.Windows.Forms.Button button_Move9;
        private System.Windows.Forms.PictureBox pictureBoxTypes;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolTip toolTip1;
        public System.Windows.Forms.DataGridView dataGridView2;
        public System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

