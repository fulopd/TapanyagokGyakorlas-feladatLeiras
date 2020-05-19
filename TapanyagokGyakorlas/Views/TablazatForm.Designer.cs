namespace TapanyagokGyakorlas.Views
{
    partial class TablazatForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TablazatForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonMentes = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonUj = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonTorles = new System.Windows.Forms.ToolStripButton();
            this.toolStripTextBoxKereses = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripButtonKereses = new System.Windows.Forms.ToolStripButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.szerkesztesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.torlesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonFirst = new System.Windows.Forms.Button();
            this.buttonPrev = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonLast = new System.Windows.Forms.Button();
            this.labelPageInfo = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonMentes,
            this.toolStripButtonUj,
            this.toolStripButtonTorles,
            this.toolStripTextBoxKereses,
            this.toolStripButtonKereses});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonMentes
            // 
            this.toolStripButtonMentes.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonMentes.Image")));
            this.toolStripButtonMentes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonMentes.Name = "toolStripButtonMentes";
            this.toolStripButtonMentes.Size = new System.Drawing.Size(66, 22);
            this.toolStripButtonMentes.Text = "Mentés";
            this.toolStripButtonMentes.Click += new System.EventHandler(this.toolStripButtonMentes_Click);
            // 
            // toolStripButtonUj
            // 
            this.toolStripButtonUj.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonUj.Image")));
            this.toolStripButtonUj.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonUj.Name = "toolStripButtonUj";
            this.toolStripButtonUj.Size = new System.Drawing.Size(38, 22);
            this.toolStripButtonUj.Text = "Új";
            this.toolStripButtonUj.Click += new System.EventHandler(this.toolStripButtonUj_Click);
            // 
            // toolStripButtonTorles
            // 
            this.toolStripButtonTorles.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonTorles.Image")));
            this.toolStripButtonTorles.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonTorles.Name = "toolStripButtonTorles";
            this.toolStripButtonTorles.Size = new System.Drawing.Size(57, 22);
            this.toolStripButtonTorles.Text = "Törlés";
            this.toolStripButtonTorles.Click += new System.EventHandler(this.toolStripButtonTorles_Click);
            // 
            // toolStripTextBoxKereses
            // 
            this.toolStripTextBoxKereses.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBoxKereses.Name = "toolStripTextBoxKereses";
            this.toolStripTextBoxKereses.Size = new System.Drawing.Size(150, 25);
            // 
            // toolStripButtonKereses
            // 
            this.toolStripButtonKereses.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonKereses.Image")));
            this.toolStripButtonKereses.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonKereses.Name = "toolStripButtonKereses";
            this.toolStripButtonKereses.Size = new System.Drawing.Size(66, 22);
            this.toolStripButtonKereses.Text = "Keresés";
            this.toolStripButtonKereses.Click += new System.EventHandler(this.toolStripButtonKereses_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 386);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_ColumnHeaderMouseClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.szerkesztesToolStripMenuItem,
            this.torlesToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 70);
            // 
            // szerkesztesToolStripMenuItem
            // 
            this.szerkesztesToolStripMenuItem.Name = "szerkesztesToolStripMenuItem";
            this.szerkesztesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.szerkesztesToolStripMenuItem.Text = "Szerkesztes";
            this.szerkesztesToolStripMenuItem.Click += new System.EventHandler(this.szerkesztesToolStripMenuItem_Click);
            // 
            // torlesToolStripMenuItem
            // 
            this.torlesToolStripMenuItem.Name = "torlesToolStripMenuItem";
            this.torlesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.torlesToolStripMenuItem.Text = "Torles";
            this.torlesToolStripMenuItem.Click += new System.EventHandler(this.torlesToolStripMenuItem_Click);
            // 
            // buttonFirst
            // 
            this.buttonFirst.Location = new System.Drawing.Point(203, 420);
            this.buttonFirst.Name = "buttonFirst";
            this.buttonFirst.Size = new System.Drawing.Size(75, 23);
            this.buttonFirst.TabIndex = 2;
            this.buttonFirst.Text = "<<";
            this.buttonFirst.UseVisualStyleBackColor = true;
            this.buttonFirst.Click += new System.EventHandler(this.buttonFirst_Click);
            // 
            // buttonPrev
            // 
            this.buttonPrev.Location = new System.Drawing.Point(284, 420);
            this.buttonPrev.Name = "buttonPrev";
            this.buttonPrev.Size = new System.Drawing.Size(75, 23);
            this.buttonPrev.TabIndex = 2;
            this.buttonPrev.Text = "<";
            this.buttonPrev.UseVisualStyleBackColor = true;
            this.buttonPrev.Click += new System.EventHandler(this.buttonPrev_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(449, 420);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(75, 23);
            this.buttonNext.TabIndex = 2;
            this.buttonNext.Text = ">";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonLast
            // 
            this.buttonLast.Location = new System.Drawing.Point(530, 420);
            this.buttonLast.Name = "buttonLast";
            this.buttonLast.Size = new System.Drawing.Size(75, 23);
            this.buttonLast.TabIndex = 2;
            this.buttonLast.Text = ">>";
            this.buttonLast.UseVisualStyleBackColor = true;
            this.buttonLast.Click += new System.EventHandler(this.buttonLast_Click);
            // 
            // labelPageInfo
            // 
            this.labelPageInfo.AutoSize = true;
            this.labelPageInfo.Location = new System.Drawing.Point(383, 426);
            this.labelPageInfo.Name = "labelPageInfo";
            this.labelPageInfo.Size = new System.Drawing.Size(30, 13);
            this.labelPageInfo.TabIndex = 3;
            this.labelPageInfo.Text = "0 / 0";
            // 
            // TablazatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelPageInfo);
            this.Controls.Add(this.buttonLast);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonPrev);
            this.Controls.Add(this.buttonFirst);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "TablazatForm";
            this.Text = "TablazatForm";
            this.Load += new System.EventHandler(this.TablazatForm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonMentes;
        private System.Windows.Forms.ToolStripButton toolStripButtonUj;
        private System.Windows.Forms.ToolStripButton toolStripButtonTorles;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxKereses;
        private System.Windows.Forms.ToolStripButton toolStripButtonKereses;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem szerkesztesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem torlesToolStripMenuItem;
        private System.Windows.Forms.Button buttonFirst;
        private System.Windows.Forms.Button buttonPrev;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonLast;
        private System.Windows.Forms.Label labelPageInfo;
    }
}