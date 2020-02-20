using System.Drawing;

namespace GameWFChineseNewYear
{
    partial class GamePlayForm
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
            this.buttonFeedChinece = new System.Windows.Forms.Label();
            this.buttonSleepChinece = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.stateChinece = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelPercentageOfImmunity = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelVirusName = new System.Windows.Forms.Label();
            this.labelIsinFacted = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBoxFaceChinece = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFaceChinece)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonFeedChinece
            // 
            this.buttonFeedChinece.AutoSize = true;
            this.buttonFeedChinece.BackColor = System.Drawing.Color.Transparent;
            this.buttonFeedChinece.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonFeedChinece.Location = new System.Drawing.Point(12, 294);
            this.buttonFeedChinece.Name = "buttonFeedChinece";
            this.buttonFeedChinece.Size = new System.Drawing.Size(276, 29);
            this.buttonFeedChinece.TabIndex = 1;
            this.buttonFeedChinece.Text = "Покормить китайца +3";
            this.buttonFeedChinece.Click += new System.EventHandler(this.ButtonFeedChinece_Click);
            // 
            // buttonSleepChinece
            // 
            this.buttonSleepChinece.AutoSize = true;
            this.buttonSleepChinece.BackColor = System.Drawing.Color.Transparent;
            this.buttonSleepChinece.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.29204F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSleepChinece.Location = new System.Drawing.Point(12, 246);
            this.buttonSleepChinece.Name = "buttonSleepChinece";
            this.buttonSleepChinece.Size = new System.Drawing.Size(343, 29);
            this.buttonSleepChinece.TabIndex = 2;
            this.buttonSleepChinece.Text = "Пустить китайца поспать +8";
            this.buttonSleepChinece.Click += new System.EventHandler(this.ButtonSleepChinece_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.BackColor = System.Drawing.Color.Transparent;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label.Location = new System.Drawing.Point(217, 9);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(301, 37);
            this.label.TabIndex = 3;
            this.label.Text = "Состояние китайца:";
            // 
            // stateChinece
            // 
            this.stateChinece.AutoSize = true;
            this.stateChinece.BackColor = System.Drawing.Color.Transparent;
            this.stateChinece.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stateChinece.Location = new System.Drawing.Point(12, 556);
            this.stateChinece.Name = "stateChinece";
            this.stateChinece.Size = new System.Drawing.Size(134, 25);
            this.stateChinece.TabIndex = 4;
            this.stateChinece.Text = "Жив, не жив";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(217, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Процент иммунитета:";
            // 
            // labelPercentageOfImmunity
            // 
            this.labelPercentageOfImmunity.AutoSize = true;
            this.labelPercentageOfImmunity.Location = new System.Drawing.Point(221, 86);
            this.labelPercentageOfImmunity.Name = "labelPercentageOfImmunity";
            this.labelPercentageOfImmunity.Size = new System.Drawing.Size(32, 17);
            this.labelPercentageOfImmunity.TabIndex = 7;
            this.labelPercentageOfImmunity.Text = "100";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(218, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Состояние заражения:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(218, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Атакующий аирус:";
            // 
            // labelVirusName
            // 
            this.labelVirusName.AutoSize = true;
            this.labelVirusName.Location = new System.Drawing.Point(221, 194);
            this.labelVirusName.Name = "labelVirusName";
            this.labelVirusName.Size = new System.Drawing.Size(40, 17);
            this.labelVirusName.TabIndex = 10;
            this.labelVirusName.Text = "Virus";
            // 
            // labelIsinFacted
            // 
            this.labelIsinFacted.AutoSize = true;
            this.labelIsinFacted.Location = new System.Drawing.Point(221, 135);
            this.labelIsinFacted.Name = "labelIsinFacted";
            this.labelIsinFacted.Size = new System.Drawing.Size(90, 17);
            this.labelIsinFacted.TabIndex = 11;
            this.labelIsinFacted.Text = " Не заражен";
            // 
            // pictureBoxFaceChinece
            // 
            this.pictureBoxFaceChinece.Image = global::GameWFChineseNewYear.Properties.Resources.FaceChinece;
            this.pictureBoxFaceChinece.Location = new System.Drawing.Point(3, 9);
            this.pictureBoxFaceChinece.Name = "pictureBoxFaceChinece";
            this.pictureBoxFaceChinece.Size = new System.Drawing.Size(208, 216);
            this.pictureBoxFaceChinece.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxFaceChinece.TabIndex = 0;
            this.pictureBoxFaceChinece.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::GameWFChineseNewYear.Properties.Resources.clouds;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1193, 610);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // GamePlayForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1193, 610);
            this.Controls.Add(this.labelIsinFacted);
            this.Controls.Add(this.labelVirusName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelPercentageOfImmunity);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSleepChinece);
            this.Controls.Add(this.label);
            this.Controls.Add(this.buttonFeedChinece);
            this.Controls.Add(this.pictureBoxFaceChinece);
            this.Controls.Add(this.stateChinece);
            this.Controls.Add(this.pictureBox1);
            this.Name = "GamePlayForm";
            this.Text = "ChineceNewYers";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GamePlayForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFaceChinece)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBoxFaceChinece;
        private System.Windows.Forms.Label buttonFeedChinece;
        private System.Windows.Forms.Label buttonSleepChinece;
        private System.Windows.Forms.Label label;
        public System.Windows.Forms.Label stateChinece;
        public System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label labelPercentageOfImmunity;
        public System.Windows.Forms.Label labelVirusName;
        public System.Windows.Forms.Label labelIsinFacted;
        private System.Windows.Forms.Timer timer1;
    }
}

