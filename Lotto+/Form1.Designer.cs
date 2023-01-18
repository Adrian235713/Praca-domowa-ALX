namespace Lotto_
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.losowaniaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sprawdzWynikiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.textDrawResults = new System.Windows.Forms.TextBox();
            this.butDraw = new System.Windows.Forms.Button();
            this.butCheck = new System.Windows.Forms.Button();
            this.butReset = new System.Windows.Forms.Button();
            this.textLotPlas = new System.Windows.Forms.TextBox();
            this.textResultsLotto = new System.Windows.Forms.TextBox();
            this.textResultsLootoPlus = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textInpLotto = new System.Windows.Forms.TextBox();
            this.textInpLootPlus = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.x = new System.Windows.Forms.Label();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.menuStrip1.Location = new System.Drawing.Point(0, 38);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1026, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip2
            // 
            this.menuStrip2.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.losowaniaToolStripMenuItem,
            this.sprawdzWynikiToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1026, 38);
            this.menuStrip2.TabIndex = 2;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // losowaniaToolStripMenuItem
            // 
            this.losowaniaToolStripMenuItem.Name = "losowaniaToolStripMenuItem";
            this.losowaniaToolStripMenuItem.Size = new System.Drawing.Size(128, 34);
            this.losowaniaToolStripMenuItem.Text = "Losowania";
            // 
            // sprawdzWynikiToolStripMenuItem
            // 
            this.sprawdzWynikiToolStripMenuItem.Name = "sprawdzWynikiToolStripMenuItem";
            this.sprawdzWynikiToolStripMenuItem.Size = new System.Drawing.Size(172, 34);
            this.sprawdzWynikiToolStripMenuItem.Text = "Sprawdz wyniki";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Wyniki:";
            // 
            // textDrawResults
            // 
            this.textDrawResults.Location = new System.Drawing.Point(208, 147);
            this.textDrawResults.Name = "textDrawResults";
            this.textDrawResults.Size = new System.Drawing.Size(651, 29);
            this.textDrawResults.TabIndex = 4;
            // 
            // butDraw
            // 
            this.butDraw.Location = new System.Drawing.Point(208, 81);
            this.butDraw.Name = "butDraw";
            this.butDraw.Size = new System.Drawing.Size(651, 47);
            this.butDraw.TabIndex = 5;
            this.butDraw.Text = "Losowanie";
            this.butDraw.UseVisualStyleBackColor = true;
            this.butDraw.Click += new System.EventHandler(this.butDraw_Click);
            // 
            // butCheck
            // 
            this.butCheck.Location = new System.Drawing.Point(208, 433);
            this.butCheck.Name = "butCheck";
            this.butCheck.Size = new System.Drawing.Size(651, 49);
            this.butCheck.TabIndex = 6;
            this.butCheck.Text = "Sprawdz Wyniki";
            this.butCheck.UseVisualStyleBackColor = true;
            this.butCheck.Click += new System.EventHandler(this.butCheck_Click);
            // 
            // butReset
            // 
            this.butReset.Location = new System.Drawing.Point(208, 636);
            this.butReset.Name = "butReset";
            this.butReset.Size = new System.Drawing.Size(651, 48);
            this.butReset.TabIndex = 7;
            this.butReset.Text = "Reset";
            this.butReset.UseVisualStyleBackColor = true;
            // 
            // textLotPlas
            // 
            this.textLotPlas.Location = new System.Drawing.Point(208, 216);
            this.textLotPlas.Name = "textLotPlas";
            this.textLotPlas.Size = new System.Drawing.Size(651, 29);
            this.textLotPlas.TabIndex = 8;
            // 
            // textResultsLotto
            // 
            this.textResultsLotto.Location = new System.Drawing.Point(208, 519);
            this.textResultsLotto.Name = "textResultsLotto";
            this.textResultsLotto.Size = new System.Drawing.Size(651, 29);
            this.textResultsLotto.TabIndex = 9;
            // 
            // textResultsLootoPlus
            // 
            this.textResultsLootoPlus.Location = new System.Drawing.Point(208, 576);
            this.textResultsLootoPlus.Name = "textResultsLootoPlus";
            this.textResultsLootoPlus.Size = new System.Drawing.Size(651, 29);
            this.textResultsLootoPlus.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(158, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "+";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 523);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "Trafienia Lotto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(77, 576);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 25);
            this.label4.TabIndex = 13;
            this.label4.Text = "Trafienia +";
            // 
            // textInpLotto
            // 
            this.textInpLotto.Location = new System.Drawing.Point(208, 326);
            this.textInpLotto.Name = "textInpLotto";
            this.textInpLotto.Size = new System.Drawing.Size(651, 29);
            this.textInpLotto.TabIndex = 14;
            // 
            // textInpLootPlus
            // 
            this.textInpLootPlus.Location = new System.Drawing.Point(208, 376);
            this.textInpLootPlus.Name = "textInpLootPlus";
            this.textInpLootPlus.Size = new System.Drawing.Size(651, 29);
            this.textInpLootPlus.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(105, 379);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 25);
            this.label6.TabIndex = 17;
            this.label6.Text = "Twoje +";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(86, 330);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 25);
            this.label5.TabIndex = 18;
            this.label5.Text = "Twoje Nr:";
            // 
            // x
            // 
            this.x.AutoSize = true;
            this.x.Location = new System.Drawing.Point(456, 298);
            this.x.Name = "x";
            this.x.Size = new System.Drawing.Size(150, 25);
            this.x.TabIndex = 19;
            this.x.Text = "Oddziel liczby - ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 768);
            this.Controls.Add(this.x);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textInpLootPlus);
            this.Controls.Add(this.textInpLotto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textResultsLootoPlus);
            this.Controls.Add(this.textResultsLotto);
            this.Controls.Add(this.textLotPlas);
            this.Controls.Add(this.butReset);
            this.Controls.Add(this.butCheck);
            this.Controls.Add(this.butDraw);
            this.Controls.Add(this.textDrawResults);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem losowaniaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sprawdzWynikiToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textDrawResults;
        private System.Windows.Forms.Button butDraw;
        private System.Windows.Forms.Button butCheck;
        private System.Windows.Forms.Button butReset;
        private System.Windows.Forms.TextBox textLotPlas;
        private System.Windows.Forms.TextBox textResultsLotto;
        private System.Windows.Forms.TextBox textResultsLootoPlus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textInpLotto;
        private System.Windows.Forms.TextBox textInpLootPlus;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label x;
    }
}

