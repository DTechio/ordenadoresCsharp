namespace Ordenadores
{
    partial class Ordenadores
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ordenadores));
            this.Gerar = new System.Windows.Forms.Button();
            this.Ordenar = new System.Windows.Forms.Button();
            this.Limpar = new System.Windows.Forms.Button();
            this.Insertion = new System.Windows.Forms.RadioButton();
            this.Selection = new System.Windows.Forms.RadioButton();
            this.Heap = new System.Windows.Forms.RadioButton();
            this.Bubble = new System.Windows.Forms.RadioButton();
            this.Quick = new System.Windows.Forms.RadioButton();
            this.txtQntd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.labelTempo = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Gerar
            // 
            this.Gerar.Location = new System.Drawing.Point(650, 258);
            this.Gerar.Name = "Gerar";
            this.Gerar.Size = new System.Drawing.Size(75, 23);
            this.Gerar.TabIndex = 1;
            this.Gerar.Text = "Gerar";
            this.Gerar.UseVisualStyleBackColor = true;
            this.Gerar.Click += new System.EventHandler(this.Gerar_Click);
            // 
            // Ordenar
            // 
            this.Ordenar.Location = new System.Drawing.Point(650, 304);
            this.Ordenar.Name = "Ordenar";
            this.Ordenar.Size = new System.Drawing.Size(75, 23);
            this.Ordenar.TabIndex = 2;
            this.Ordenar.Text = "Ordenar";
            this.Ordenar.UseVisualStyleBackColor = true;
            this.Ordenar.Click += new System.EventHandler(this.Ordenar_Click);
            // 
            // Limpar
            // 
            this.Limpar.Location = new System.Drawing.Point(650, 350);
            this.Limpar.Name = "Limpar";
            this.Limpar.Size = new System.Drawing.Size(75, 23);
            this.Limpar.TabIndex = 3;
            this.Limpar.Text = "Limpar";
            this.Limpar.UseVisualStyleBackColor = true;
            this.Limpar.Click += new System.EventHandler(this.Limpar_Click);
            // 
            // Insertion
            // 
            this.Insertion.AutoSize = true;
            this.Insertion.Location = new System.Drawing.Point(80, 350);
            this.Insertion.Name = "Insertion";
            this.Insertion.Size = new System.Drawing.Size(87, 17);
            this.Insertion.TabIndex = 4;
            this.Insertion.TabStop = true;
            this.Insertion.Text = "Insertion Sort";
            this.Insertion.UseVisualStyleBackColor = true;
            // 
            // Selection
            // 
            this.Selection.AutoSize = true;
            this.Selection.Location = new System.Drawing.Point(80, 327);
            this.Selection.Name = "Selection";
            this.Selection.Size = new System.Drawing.Size(91, 17);
            this.Selection.TabIndex = 5;
            this.Selection.TabStop = true;
            this.Selection.Text = "Selection Sort";
            this.Selection.UseVisualStyleBackColor = true;
            // 
            // Heap
            // 
            this.Heap.AutoSize = true;
            this.Heap.Location = new System.Drawing.Point(80, 304);
            this.Heap.Name = "Heap";
            this.Heap.Size = new System.Drawing.Size(73, 17);
            this.Heap.TabIndex = 6;
            this.Heap.TabStop = true;
            this.Heap.Text = "Heap Sort";
            this.Heap.UseVisualStyleBackColor = true;
            // 
            // Bubble
            // 
            this.Bubble.AutoSize = true;
            this.Bubble.Location = new System.Drawing.Point(80, 281);
            this.Bubble.Name = "Bubble";
            this.Bubble.Size = new System.Drawing.Size(80, 17);
            this.Bubble.TabIndex = 7;
            this.Bubble.TabStop = true;
            this.Bubble.Text = "Bubble Sort";
            this.Bubble.UseVisualStyleBackColor = true;
            // 
            // Quick
            // 
            this.Quick.AutoSize = true;
            this.Quick.Location = new System.Drawing.Point(80, 258);
            this.Quick.Name = "Quick";
            this.Quick.Size = new System.Drawing.Size(75, 17);
            this.Quick.TabIndex = 8;
            this.Quick.TabStop = true;
            this.Quick.Text = "Quick Sort";
            this.Quick.UseVisualStyleBackColor = true;
            // 
            // txtQntd
            // 
            this.txtQntd.Location = new System.Drawing.Point(344, 191);
            this.txtQntd.Name = "txtQntd";
            this.txtQntd.Size = new System.Drawing.Size(100, 20);
            this.txtQntd.TabIndex = 9;
            this.txtQntd.TextChanged += new System.EventHandler(this.txtQntd_TextChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(303, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Gerar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(450, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "números.";
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(80, 12);
            this.txtNum.Multiline = true;
            this.txtNum.Name = "txtNum";
            this.txtNum.ReadOnly = true;
            this.txtNum.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtNum.Size = new System.Drawing.Size(645, 173);
            this.txtNum.TabIndex = 12;
            // 
            // labelTempo
            // 
            this.labelTempo.AutoSize = true;
            this.labelTempo.Location = new System.Drawing.Point(341, 227);
            this.labelTempo.Name = "labelTempo";
            this.labelTempo.Size = new System.Drawing.Size(0, 13);
            this.labelTempo.TabIndex = 13;
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Location = new System.Drawing.Point(386, 227);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(0, 13);
            this.labelTime.TabIndex = 14;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(300, 281);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // Ordenadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 449);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.labelTempo);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtQntd);
            this.Controls.Add(this.Quick);
            this.Controls.Add(this.Bubble);
            this.Controls.Add(this.Heap);
            this.Controls.Add(this.Selection);
            this.Controls.Add(this.Insertion);
            this.Controls.Add(this.Limpar);
            this.Controls.Add(this.Ordenar);
            this.Controls.Add(this.Gerar);
            this.Name = "Ordenadores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ordenadores";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Gerar;
        private System.Windows.Forms.Button Ordenar;
        private System.Windows.Forms.Button Limpar;
        private System.Windows.Forms.RadioButton Insertion;
        private System.Windows.Forms.RadioButton Selection;
        private System.Windows.Forms.RadioButton Heap;
        private System.Windows.Forms.RadioButton Bubble;
        private System.Windows.Forms.RadioButton Quick;
        private System.Windows.Forms.TextBox txtQntd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNum;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label labelTempo;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

