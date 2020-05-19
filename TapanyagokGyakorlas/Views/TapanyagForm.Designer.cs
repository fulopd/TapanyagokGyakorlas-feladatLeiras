namespace TapanyagokGyakorlas.Views
{
    partial class TapanyagForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxNev = new System.Windows.Forms.TextBox();
            this.numericUpDownEnergia = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownFeherje = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownZsir = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownSzenhidrat = new System.Windows.Forms.NumericUpDown();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEnergia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFeherje)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownZsir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSzenhidrat)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Név";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Energia";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Fehérje";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Zsír";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 266);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Szénhidrát";
            // 
            // textBoxNev
            // 
            this.textBoxNev.Location = new System.Drawing.Point(115, 25);
            this.textBoxNev.Multiline = true;
            this.textBoxNev.Name = "textBoxNev";
            this.textBoxNev.Size = new System.Drawing.Size(243, 71);
            this.textBoxNev.TabIndex = 1;
            // 
            // numericUpDownEnergia
            // 
            this.numericUpDownEnergia.DecimalPlaces = 1;
            this.numericUpDownEnergia.Location = new System.Drawing.Point(115, 103);
            this.numericUpDownEnergia.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDownEnergia.Name = "numericUpDownEnergia";
            this.numericUpDownEnergia.Size = new System.Drawing.Size(243, 20);
            this.numericUpDownEnergia.TabIndex = 2;
            // 
            // numericUpDownFeherje
            // 
            this.numericUpDownFeherje.DecimalPlaces = 1;
            this.numericUpDownFeherje.Location = new System.Drawing.Point(115, 158);
            this.numericUpDownFeherje.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDownFeherje.Name = "numericUpDownFeherje";
            this.numericUpDownFeherje.Size = new System.Drawing.Size(243, 20);
            this.numericUpDownFeherje.TabIndex = 2;
            // 
            // numericUpDownZsir
            // 
            this.numericUpDownZsir.DecimalPlaces = 1;
            this.numericUpDownZsir.Location = new System.Drawing.Point(115, 208);
            this.numericUpDownZsir.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDownZsir.Name = "numericUpDownZsir";
            this.numericUpDownZsir.Size = new System.Drawing.Size(243, 20);
            this.numericUpDownZsir.TabIndex = 2;
            // 
            // numericUpDownSzenhidrat
            // 
            this.numericUpDownSzenhidrat.DecimalPlaces = 1;
            this.numericUpDownSzenhidrat.Location = new System.Drawing.Point(115, 264);
            this.numericUpDownSzenhidrat.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDownSzenhidrat.Name = "numericUpDownSzenhidrat";
            this.numericUpDownSzenhidrat.Size = new System.Drawing.Size(243, 20);
            this.numericUpDownSzenhidrat.TabIndex = 2;
            // 
            // buttonOk
            // 
            this.buttonOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOk.Location = new System.Drawing.Point(12, 310);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 3;
            this.buttonOk.Text = "Ok";
            this.buttonOk.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(313, 310);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 3;
            this.buttonCancel.Text = "Mégsem";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // TapanyagForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 345);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.numericUpDownSzenhidrat);
            this.Controls.Add(this.numericUpDownZsir);
            this.Controls.Add(this.numericUpDownFeherje);
            this.Controls.Add(this.numericUpDownEnergia);
            this.Controls.Add(this.textBoxNev);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TapanyagForm";
            this.Text = "TapanyagForm";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEnergia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFeherje)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownZsir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSzenhidrat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxNev;
        private System.Windows.Forms.NumericUpDown numericUpDownEnergia;
        private System.Windows.Forms.NumericUpDown numericUpDownFeherje;
        private System.Windows.Forms.NumericUpDown numericUpDownZsir;
        private System.Windows.Forms.NumericUpDown numericUpDownSzenhidrat;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonCancel;
    }
}