namespace Deanery
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
            this.buttonGroups = new System.Windows.Forms.Button();
            this.buttonStudents = new System.Windows.Forms.Button();
            this.buttonSubject = new System.Windows.Forms.Button();
            this.buttonPoint = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonGroups
            // 
            this.buttonGroups.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(214)))));
            this.buttonGroups.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonGroups.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonGroups.Location = new System.Drawing.Point(12, 179);
            this.buttonGroups.Name = "buttonGroups";
            this.buttonGroups.Size = new System.Drawing.Size(251, 48);
            this.buttonGroups.TabIndex = 1;
            this.buttonGroups.Text = "Группы";
            this.buttonGroups.UseVisualStyleBackColor = false;
            this.buttonGroups.Click += new System.EventHandler(this.buttonGroups_Click);
            // 
            // buttonStudents
            // 
            this.buttonStudents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(214)))));
            this.buttonStudents.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonStudents.Font = new System.Drawing.Font("Calibri", 14.25F);
            this.buttonStudents.Location = new System.Drawing.Point(12, 233);
            this.buttonStudents.Name = "buttonStudents";
            this.buttonStudents.Size = new System.Drawing.Size(251, 48);
            this.buttonStudents.TabIndex = 2;
            this.buttonStudents.Text = "Студенты";
            this.buttonStudents.UseVisualStyleBackColor = false;
            this.buttonStudents.Click += new System.EventHandler(this.buttonStudents_Click);
            // 
            // buttonSubject
            // 
            this.buttonSubject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(214)))));
            this.buttonSubject.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSubject.Font = new System.Drawing.Font("Calibri", 14.25F);
            this.buttonSubject.Location = new System.Drawing.Point(12, 287);
            this.buttonSubject.Name = "buttonSubject";
            this.buttonSubject.Size = new System.Drawing.Size(251, 48);
            this.buttonSubject.TabIndex = 3;
            this.buttonSubject.Text = "Дисциплины";
            this.buttonSubject.UseVisualStyleBackColor = false;
            this.buttonSubject.Click += new System.EventHandler(this.buttonSubject_Click);
            // 
            // buttonPoint
            // 
            this.buttonPoint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(214)))));
            this.buttonPoint.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonPoint.Font = new System.Drawing.Font("Calibri", 14.25F);
            this.buttonPoint.Location = new System.Drawing.Point(12, 341);
            this.buttonPoint.Name = "buttonPoint";
            this.buttonPoint.Size = new System.Drawing.Size(251, 48);
            this.buttonPoint.TabIndex = 4;
            this.buttonPoint.Text = "Баллы";
            this.buttonPoint.UseVisualStyleBackColor = false;
            this.buttonPoint.Click += new System.EventHandler(this.buttonPoint_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Deanery.Properties.Resources._28_281003_stafford_county_public_school_logo_stafford_county_public_schools;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(251, 149);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(213)))), ((int)(((byte)(202)))));
            this.ClientSize = new System.Drawing.Size(275, 411);
            this.Controls.Add(this.buttonPoint);
            this.Controls.Add(this.buttonSubject);
            this.Controls.Add(this.buttonStudents);
            this.Controls.Add(this.buttonGroups);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Меню";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonGroups;
        private System.Windows.Forms.Button buttonStudents;
        private System.Windows.Forms.Button buttonSubject;
        private System.Windows.Forms.Button buttonPoint;
    }
}

