namespace HighlightСolor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Apply = new System.Windows.Forms.Button();
            this.OriginalColors = new System.Windows.Forms.Button();
            this.colorValues = new System.Windows.Forms.TextBox();
            this.hotTreckingValues = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.hint = new System.Windows.Forms.Label();
            this.Selection = new System.Windows.Forms.Button();
            this.colorPanel = new System.Windows.Forms.Panel();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.hotTreckingPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // Apply
            // 
            this.Apply.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Apply.Location = new System.Drawing.Point(17, 199);
            this.Apply.Name = "Apply";
            this.Apply.Size = new System.Drawing.Size(99, 33);
            this.Apply.TabIndex = 0;
            this.Apply.Text = "Ок";
            this.Apply.UseVisualStyleBackColor = true;
            this.Apply.Click += new System.EventHandler(this.Apply_Click);
            // 
            // OriginalColors
            // 
            this.OriginalColors.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OriginalColors.Location = new System.Drawing.Point(223, 199);
            this.OriginalColors.Name = "OriginalColors";
            this.OriginalColors.Size = new System.Drawing.Size(95, 33);
            this.OriginalColors.TabIndex = 1;
            this.OriginalColors.Text = "Исходный";
            this.OriginalColors.UseVisualStyleBackColor = true;
            this.OriginalColors.Click += new System.EventHandler(this.OriginalColors_Click);
            // 
            // colorValues
            // 
            this.colorValues.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colorValues.Location = new System.Drawing.Point(17, 42);
            this.colorValues.Name = "colorValues";
            this.colorValues.Size = new System.Drawing.Size(200, 35);
            this.colorValues.TabIndex = 2;
            this.colorValues.TextChanged += new System.EventHandler(this.colorValues_TextChanged);
            this.colorValues.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.colorValues_KeyPress);
            // 
            // hotTreckingValues
            // 
            this.hotTreckingValues.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hotTreckingValues.Location = new System.Drawing.Point(17, 113);
            this.hotTreckingValues.Name = "hotTreckingValues";
            this.hotTreckingValues.Size = new System.Drawing.Size(200, 35);
            this.hotTreckingValues.TabIndex = 3;
            this.hotTreckingValues.TextChanged += new System.EventHandler(this.hotTreckingValues_TextChanged);
            this.hotTreckingValues.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.hotTreckingValues_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 30);
            this.label1.TabIndex = 4;
            this.label1.Text = "Цвет рамки";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 30);
            this.label2.TabIndex = 5;
            this.label2.Text = "Основной цвет";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(183, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "R,G,B";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(183, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "R,G,B";
            // 
            // hint
            // 
            this.hint.AutoSize = true;
            this.hint.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hint.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.hint.Location = new System.Drawing.Point(298, 7);
            this.hint.Name = "hint";
            this.hint.Size = new System.Drawing.Size(25, 32);
            this.hint.TabIndex = 8;
            this.hint.Text = "?";
            this.hint.MouseClick += new System.Windows.Forms.MouseEventHandler(this.hint_MouseClick);
            // 
            // Selection
            // 
            this.Selection.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Selection.Location = new System.Drawing.Point(122, 199);
            this.Selection.Name = "Selection";
            this.Selection.Size = new System.Drawing.Size(95, 33);
            this.Selection.TabIndex = 9;
            this.Selection.Text = "Подбор";
            this.Selection.UseVisualStyleBackColor = true;
            this.Selection.Click += new System.EventHandler(this.Selection_Click);
            // 
            // colorPanel
            // 
            this.colorPanel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.colorPanel.Location = new System.Drawing.Point(225, 42);
            this.colorPanel.Name = "colorPanel";
            this.colorPanel.Size = new System.Drawing.Size(35, 35);
            this.colorPanel.TabIndex = 10;
            this.colorPanel.Click += new System.EventHandler(this.colorPanel_Click);
            // 
            // colorDialog1
            // 
            this.colorDialog1.FullOpen = true;
            // 
            // hotTreckingPanel
            // 
            this.hotTreckingPanel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.hotTreckingPanel.Location = new System.Drawing.Point(225, 113);
            this.hotTreckingPanel.Name = "hotTreckingPanel";
            this.hotTreckingPanel.Size = new System.Drawing.Size(35, 35);
            this.hotTreckingPanel.TabIndex = 11;
            this.hotTreckingPanel.Click += new System.EventHandler(this.hotTreckingPanel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 250);
            this.Controls.Add(this.hotTreckingPanel);
            this.Controls.Add(this.colorPanel);
            this.Controls.Add(this.Selection);
            this.Controls.Add(this.hint);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hotTreckingValues);
            this.Controls.Add(this.colorValues);
            this.Controls.Add(this.OriginalColors);
            this.Controls.Add(this.Apply);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HighlightСolor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Apply;
        private System.Windows.Forms.Button OriginalColors;
        private System.Windows.Forms.TextBox colorValues;
        private System.Windows.Forms.TextBox hotTreckingValues;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label hint;
        private System.Windows.Forms.Button Selection;
        private System.Windows.Forms.Panel colorPanel;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Panel hotTreckingPanel;
    }
}

