namespace ExampleLocalMethod
{
    partial class FormExampleLocalMethods
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
            this.buttonGetNewValue = new System.Windows.Forms.Button();
            this.log = new System.Windows.Forms.RichTextBox();
            this.buttonGetNewValueFromClass = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonGetNewValue
            // 
            this.buttonGetNewValue.Location = new System.Drawing.Point(10, 10);
            this.buttonGetNewValue.Name = "buttonGetNewValue";
            this.buttonGetNewValue.Size = new System.Drawing.Size(200, 23);
            this.buttonGetNewValue.TabIndex = 0;
            this.buttonGetNewValue.Text = "Get new value from local method";
            this.buttonGetNewValue.UseVisualStyleBackColor = true;
            this.buttonGetNewValue.Click += new System.EventHandler(this.buttonGetNewValue_Click);
            // 
            // log
            // 
            this.log.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.log.BackColor = System.Drawing.SystemColors.Control;
            this.log.Location = new System.Drawing.Point(10, 39);
            this.log.Name = "log";
            this.log.ReadOnly = true;
            this.log.Size = new System.Drawing.Size(600, 390);
            this.log.TabIndex = 1;
            this.log.Text = "";
            // 
            // buttonGetNewValueFromClass
            // 
            this.buttonGetNewValueFromClass.Location = new System.Drawing.Point(216, 10);
            this.buttonGetNewValueFromClass.Name = "buttonGetNewValueFromClass";
            this.buttonGetNewValueFromClass.Size = new System.Drawing.Size(394, 23);
            this.buttonGetNewValueFromClass.TabIndex = 2;
            this.buttonGetNewValueFromClass.Text = "Get new value from class";
            this.buttonGetNewValueFromClass.UseVisualStyleBackColor = true;
            this.buttonGetNewValueFromClass.Click += new System.EventHandler(this.buttonGetNewValueFromClass_Click);
            // 
            // FormExampleLocalMethods
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 442);
            this.Controls.Add(this.buttonGetNewValueFromClass);
            this.Controls.Add(this.log);
            this.Controls.Add(this.buttonGetNewValue);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormExampleLocalMethods";
            this.Text = "Example local methods";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonGetNewValue;
        private System.Windows.Forms.RichTextBox log;
        private System.Windows.Forms.Button buttonGetNewValueFromClass;
    }
}

