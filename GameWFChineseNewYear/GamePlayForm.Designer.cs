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
            this.pictureBoxFaceChinece = new System.Windows.Forms.PictureBox();
            this.buttonFeedChinece = new System.Windows.Forms.Label();
            this.buttonSleepChinece = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.stateChinece = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFaceChinece)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            // buttonFeedChinece
            // 
            this.buttonFeedChinece.AutoSize = true;
            this.buttonFeedChinece.BackColor = System.Drawing.Color.Transparent;
            this.buttonFeedChinece.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonFeedChinece.Location = new System.Drawing.Point(12, 284);
            this.buttonFeedChinece.Name = "buttonFeedChinece";
            this.buttonFeedChinece.Size = new System.Drawing.Size(276, 29);
            this.buttonFeedChinece.TabIndex = 1;
            this.buttonFeedChinece.Text = "Покормить китайца +3";
            this.buttonFeedChinece.Click += new System.EventHandler(this.buttonFeedChinece_Click);
            // 
            // buttonSleepChinece
            // 
            this.buttonSleepChinece.AutoSize = true;
            this.buttonSleepChinece.BackColor = System.Drawing.Color.Transparent;
            this.buttonSleepChinece.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSleepChinece.Location = new System.Drawing.Point(12, 242);
            this.buttonSleepChinece.Name = "buttonSleepChinece";
            this.buttonSleepChinece.Size = new System.Drawing.Size(352, 29);
            this.buttonSleepChinece.TabIndex = 2;
            this.buttonSleepChinece.Text = "Пустить китайца поспать +10";
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
            this.stateChinece.Location = new System.Drawing.Point(256, 100);
            this.stateChinece.Name = "stateChinece";
            this.stateChinece.Size = new System.Drawing.Size(134, 25);
            this.stateChinece.TabIndex = 4;
            this.stateChinece.Text = "Жив, не жив";
            // 
            // pictureBox1
            // 
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
            this.Controls.Add(this.buttonSleepChinece);
            this.Controls.Add(this.label);
            this.Controls.Add(this.buttonFeedChinece);
            this.Controls.Add(this.pictureBoxFaceChinece);
            this.Controls.Add(this.stateChinece);
            this.Controls.Add(this.pictureBox1);
            this.Name = "GamePlayForm";
            this.Text = "ChineceNewYers";
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
    }
}

