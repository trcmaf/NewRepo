namespace app
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
      this.button1 = new System.Windows.Forms.Button();
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      this.SuspendLayout();
      // 
      // button1
      // 
      this.button1.Font = new System.Drawing.Font("Segoe Script", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.button1.ForeColor = System.Drawing.Color.Red;
      this.button1.Location = new System.Drawing.Point(265, 404);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(113, 75);
      this.button1.TabIndex = 0;
      this.button1.Text = "button";
      this.button1.UseVisualStyleBackColor = true;
      // 
      // pictureBox1
      // 
      this.pictureBox1.Location = new System.Drawing.Point(75, 48);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(486, 283);
      this.pictureBox1.TabIndex = 1;
      this.pictureBox1.TabStop = false;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
      this.ClientSize = new System.Drawing.Size(675, 559);
      this.Controls.Add(this.pictureBox1);
      this.Controls.Add(this.button1);
      this.Name = "Form1";
      this.Text = "Form1";
      this.TransparencyKey = System.Drawing.Color.White;
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.PictureBox pictureBox1;

    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem выйтиToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem загрузитьToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem загрузитьИзображениеToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem вФорматеJPGToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem вФорматеPNGToolStripMenuItem;
    private System.Windows.Forms.ToolStrip toolStrip1;
    private System.Windows.Forms.ToolStripButton toolStripButton1;
    private System.Windows.Forms.ToolStripButton toolStripButton2;
    private System.Windows.Forms.ToolStripButton toolStripButton3;
    private System.Windows.Forms.OpenFileDialog openFileDialog1;
  }
}

