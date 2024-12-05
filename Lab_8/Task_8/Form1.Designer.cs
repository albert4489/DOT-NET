namespace Task_8
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.червонийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.зеленийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.жовтийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.помаранчевийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ContextMenuStrip = this.contextMenuStrip1;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(564, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 21);
            this.label3.TabIndex = 8;
            this.label3.Text = "Text3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ContextMenuStrip = this.contextMenuStrip1;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(352, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "Text2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ContextMenuStrip = this.contextMenuStrip1;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(145, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "Text1";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.червонийToolStripMenuItem,
            this.зеленийToolStripMenuItem,
            this.жовтийToolStripMenuItem,
            this.помаранчевийToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(159, 92);
            // 
            // червонийToolStripMenuItem
            // 
            this.червонийToolStripMenuItem.Name = "червонийToolStripMenuItem";
            this.червонийToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.червонийToolStripMenuItem.Text = "Червоний";
            // 
            // зеленийToolStripMenuItem
            // 
            this.зеленийToolStripMenuItem.Name = "зеленийToolStripMenuItem";
            this.зеленийToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.зеленийToolStripMenuItem.Text = "Зелений";
            // 
            // жовтийToolStripMenuItem
            // 
            this.жовтийToolStripMenuItem.Name = "жовтийToolStripMenuItem";
            this.жовтийToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.жовтийToolStripMenuItem.Text = "Жовтий";
            // 
            // помаранчевийToolStripMenuItem
            // 
            this.помаранчевийToolStripMenuItem.Name = "помаранчевийToolStripMenuItem";
            this.помаранчевийToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.помаранчевийToolStripMenuItem.Text = "Помаранчевий";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem червонийToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem зеленийToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem жовтийToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem помаранчевийToolStripMenuItem;
    }
}

