namespace Client
{
    partial class MainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.SearchLabel1 = new System.Windows.Forms.Label();
            this.SearchTextBox1 = new System.Windows.Forms.TextBox();
            this.SearchButton1 = new System.Windows.Forms.Button();
            this.CreateLabel1 = new System.Windows.Forms.Label();
            this.CreateButton1 = new System.Windows.Forms.Button();
            this.MovementLabel1 = new System.Windows.Forms.Label();
            this.MovementButton1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SearchLabel1
            // 
            this.SearchLabel1.AutoSize = true;
            this.SearchLabel1.Location = new System.Drawing.Point(13, 23);
            this.SearchLabel1.Name = "SearchLabel1";
            this.SearchLabel1.Size = new System.Drawing.Size(169, 13);
            this.SearchLabel1.TabIndex = 0;
            this.SearchLabel1.Text = "Поиск по инвентарному номеру";
            // 
            // SearchTextBox1
            // 
            this.SearchTextBox1.Location = new System.Drawing.Point(16, 58);
            this.SearchTextBox1.Name = "SearchTextBox1";
            this.SearchTextBox1.Size = new System.Drawing.Size(166, 20);
            this.SearchTextBox1.TabIndex = 1;
            this.SearchTextBox1.Text = "7400_0000";
            this.SearchTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SearchButton1
            // 
            this.SearchButton1.Location = new System.Drawing.Point(16, 95);
            this.SearchButton1.Name = "SearchButton1";
            this.SearchButton1.Size = new System.Drawing.Size(166, 23);
            this.SearchButton1.TabIndex = 2;
            this.SearchButton1.Text = "Поиск";
            this.SearchButton1.UseVisualStyleBackColor = true;
            // 
            // CreateLabel1
            // 
            this.CreateLabel1.AutoSize = true;
            this.CreateLabel1.Location = new System.Drawing.Point(271, 23);
            this.CreateLabel1.Name = "CreateLabel1";
            this.CreateLabel1.Size = new System.Drawing.Size(182, 13);
            this.CreateLabel1.TabIndex = 3;
            this.CreateLabel1.Text = "Добавление нового оборудования";
            // 
            // CreateButton1
            // 
            this.CreateButton1.Location = new System.Drawing.Point(274, 58);
            this.CreateButton1.Name = "CreateButton1";
            this.CreateButton1.Size = new System.Drawing.Size(179, 23);
            this.CreateButton1.TabIndex = 4;
            this.CreateButton1.Text = "Создать";
            this.CreateButton1.UseVisualStyleBackColor = true;
            this.CreateButton1.Click += new System.EventHandler(this.CreateButton1_Click);
            // 
            // MovementLabel1
            // 
            this.MovementLabel1.Location = new System.Drawing.Point(539, 23);
            this.MovementLabel1.Name = "MovementLabel1";
            this.MovementLabel1.Size = new System.Drawing.Size(144, 13);
            this.MovementLabel1.TabIndex = 5;
            this.MovementLabel1.Text = "Перемещение";
            this.MovementLabel1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // MovementButton1
            // 
            this.MovementButton1.Location = new System.Drawing.Point(542, 58);
            this.MovementButton1.Name = "MovementButton1";
            this.MovementButton1.Size = new System.Drawing.Size(141, 23);
            this.MovementButton1.TabIndex = 6;
            this.MovementButton1.Text = "Переместить";
            this.MovementButton1.UseVisualStyleBackColor = true;
            this.MovementButton1.Click += new System.EventHandler(this.MovementButton1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 385);
            this.Controls.Add(this.MovementButton1);
            this.Controls.Add(this.MovementLabel1);
            this.Controls.Add(this.CreateButton1);
            this.Controls.Add(this.CreateLabel1);
            this.Controls.Add(this.SearchButton1);
            this.Controls.Add(this.SearchTextBox1);
            this.Controls.Add(this.SearchLabel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Инвентаризация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SearchLabel1;
        private System.Windows.Forms.TextBox SearchTextBox1;
        private System.Windows.Forms.Button SearchButton1;
        private System.Windows.Forms.Label CreateLabel1;
        private System.Windows.Forms.Button CreateButton1;
        private System.Windows.Forms.Label MovementLabel1;
        private System.Windows.Forms.Button MovementButton1;
    }
}

