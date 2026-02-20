
namespace car
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
            this.label1 = new System.Windows.Forms.Label();
            this.textTank = new System.Windows.Forms.TextBox();
            this.textPetrol = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textCost = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textWay = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonRecord = new System.Windows.Forms.Button();
            this.buttonRefuelThisCar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.RecordsOfCars = new System.Windows.Forms.DataGridView();
            this.buttonOutput = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.infoAfterFillCarUp = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonRefuelSelectedCar = new System.Windows.Forms.Button();
            this.buttonDriveThis = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonDriveSelected = new System.Windows.Forms.Button();
            this.infoAfterWay = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RecordsOfCars)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите объем бака:";
            // 
            // textTank
            // 
            this.textTank.Location = new System.Drawing.Point(43, 65);
            this.textTank.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textTank.Name = "textTank";
            this.textTank.Size = new System.Drawing.Size(148, 26);
            this.textTank.TabIndex = 1;
            // 
            // textPetrol
            // 
            this.textPetrol.Location = new System.Drawing.Point(43, 142);
            this.textPetrol.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textPetrol.Name = "textPetrol";
            this.textPetrol.Size = new System.Drawing.Size(148, 26);
            this.textPetrol.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 117);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(291, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Введите количесвто бензина в баке:";
            // 
            // textCost
            // 
            this.textCost.Location = new System.Drawing.Point(43, 220);
            this.textCost.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textCost.Name = "textCost";
            this.textCost.Size = new System.Drawing.Size(148, 26);
            this.textCost.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 195);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(279, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Введите расход бензина на 100 км:";
            // 
            // textWay
            // 
            this.textWay.Location = new System.Drawing.Point(43, 300);
            this.textWay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textWay.Name = "textWay";
            this.textWay.Size = new System.Drawing.Size(148, 26);
            this.textWay.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 275);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(233, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Введите пробег автомобиля:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonRecord);
            this.groupBox1.Controls.Add(this.textWay);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textCost);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textPetrol);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textTank);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(379, 390);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Добавить запись об автомобиле";
            // 
            // buttonRecord
            // 
            this.buttonRecord.BackColor = System.Drawing.Color.Gold;
            this.buttonRecord.Location = new System.Drawing.Point(248, 346);
            this.buttonRecord.Name = "buttonRecord";
            this.buttonRecord.Size = new System.Drawing.Size(125, 38);
            this.buttonRecord.TabIndex = 8;
            this.buttonRecord.Text = "Записать!";
            this.buttonRecord.UseVisualStyleBackColor = false;
            this.buttonRecord.Click += new System.EventHandler(this.buttonRecord_Click);
            // 
            // buttonRefuelThisCar
            // 
            this.buttonRefuelThisCar.BackColor = System.Drawing.Color.Gold;
            this.buttonRefuelThisCar.Location = new System.Drawing.Point(170, 62);
            this.buttonRefuelThisCar.Name = "buttonRefuelThisCar";
            this.buttonRefuelThisCar.Size = new System.Drawing.Size(124, 78);
            this.buttonRefuelThisCar.TabIndex = 9;
            this.buttonRefuelThisCar.Text = "Пополнить бак текущей машины!";
            this.buttonRefuelThisCar.UseVisualStyleBackColor = false;
            this.buttonRefuelThisCar.Click += new System.EventHandler(this.buttonRefuelThisCar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(236, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Информация после заправки:";
            // 
            // RecordsOfCars
            // 
            this.RecordsOfCars.BackgroundColor = System.Drawing.Color.PaleTurquoise;
            this.RecordsOfCars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RecordsOfCars.Location = new System.Drawing.Point(485, 333);
            this.RecordsOfCars.Name = "RecordsOfCars";
            this.RecordsOfCars.RowHeadersWidth = 160;
            this.RecordsOfCars.Size = new System.Drawing.Size(565, 317);
            this.RecordsOfCars.TabIndex = 11;
            // 
            // buttonOutput
            // 
            this.buttonOutput.BackColor = System.Drawing.Color.Gold;
            this.buttonOutput.Location = new System.Drawing.Point(1056, 468);
            this.buttonOutput.Name = "buttonOutput";
            this.buttonOutput.Size = new System.Drawing.Size(132, 73);
            this.buttonOutput.TabIndex = 12;
            this.buttonOutput.Text = "Вывести инфармацию о машинах";
            this.buttonOutput.UseVisualStyleBackColor = false;
            this.buttonOutput.Click += new System.EventHandler(this.buttonOutput_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(347, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Введите количество бензина для заправки:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(21, 88);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 26);
            this.textBox1.TabIndex = 14;
            // 
            // infoAfterFillCarUp
            // 
            this.infoAfterFillCarUp.AutoSize = true;
            this.infoAfterFillCarUp.Location = new System.Drawing.Point(21, 191);
            this.infoAfterFillCarUp.Name = "infoAfterFillCarUp";
            this.infoAfterFillCarUp.Size = new System.Drawing.Size(0, 20);
            this.infoAfterFillCarUp.TabIndex = 15;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonRefuelSelectedCar);
            this.groupBox2.Controls.Add(this.infoAfterFillCarUp);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.buttonRefuelThisCar);
            this.groupBox2.Location = new System.Drawing.Point(12, 427);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(464, 253);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Заправить машину";
            // 
            // buttonRefuelSelectedCar
            // 
            this.buttonRefuelSelectedCar.BackColor = System.Drawing.Color.Gold;
            this.buttonRefuelSelectedCar.Location = new System.Drawing.Point(315, 63);
            this.buttonRefuelSelectedCar.Name = "buttonRefuelSelectedCar";
            this.buttonRefuelSelectedCar.Size = new System.Drawing.Size(131, 77);
            this.buttonRefuelSelectedCar.TabIndex = 16;
            this.buttonRefuelSelectedCar.Text = "Пополнить бак выбранной машины!";
            this.buttonRefuelSelectedCar.UseVisualStyleBackColor = false;
            this.buttonRefuelSelectedCar.Click += new System.EventHandler(this.buttonRefuelSelectedCar_Click);
            // 
            // buttonDriveThis
            // 
            this.buttonDriveThis.BackColor = System.Drawing.Color.Gold;
            this.buttonDriveThis.Location = new System.Drawing.Point(22, 120);
            this.buttonDriveThis.Name = "buttonDriveThis";
            this.buttonDriveThis.Size = new System.Drawing.Size(168, 57);
            this.buttonDriveThis.TabIndex = 17;
            this.buttonDriveThis.Text = "В дорогу с текущей машиной!";
            this.buttonDriveThis.UseVisualStyleBackColor = false;
            this.buttonDriveThis.Click += new System.EventHandler(this.buttonDriveThis_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonDriveSelected);
            this.groupBox3.Controls.Add(this.infoAfterWay);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.textBox2);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.buttonDriveThis);
            this.groupBox3.Location = new System.Drawing.Point(460, 34);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(590, 253);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ехать";
            // 
            // buttonDriveSelected
            // 
            this.buttonDriveSelected.BackColor = System.Drawing.Color.Gold;
            this.buttonDriveSelected.Location = new System.Drawing.Point(22, 190);
            this.buttonDriveSelected.Name = "buttonDriveSelected";
            this.buttonDriveSelected.Size = new System.Drawing.Size(168, 57);
            this.buttonDriveSelected.TabIndex = 22;
            this.buttonDriveSelected.Text = "В дорогу с выбраной машиной!";
            this.buttonDriveSelected.UseVisualStyleBackColor = false;
            this.buttonDriveSelected.Click += new System.EventHandler(this.buttonDriveSelected_Click);
            // 
            // infoAfterWay
            // 
            this.infoAfterWay.AutoSize = true;
            this.infoAfterWay.Location = new System.Drawing.Point(277, 65);
            this.infoAfterWay.Name = "infoAfterWay";
            this.infoAfterWay.Size = new System.Drawing.Size(0, 20);
            this.infoAfterWay.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(277, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(229, 20);
            this.label8.TabIndex = 20;
            this.label8.Text = "Информация после поездки:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(22, 74);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 26);
            this.textBox2.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(172, 20);
            this.label7.TabIndex = 18;
            this.label7.Text = "Введите расстояние:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.buttonOutput);
            this.Controls.Add(this.RecordsOfCars);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Автомобиль";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RecordsOfCars)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textTank;
        private System.Windows.Forms.TextBox textPetrol;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textCost;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textWay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonRecord;
        private System.Windows.Forms.Button buttonRefuelThisCar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView RecordsOfCars;
        private System.Windows.Forms.Button buttonOutput;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label infoAfterFillCarUp;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonDriveThis;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label infoAfterWay;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonRefuelSelectedCar;
        private System.Windows.Forms.Button buttonDriveSelected;
    }
}

