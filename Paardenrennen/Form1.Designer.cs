namespace Paardenrennen
{
    partial class frmpaardrennen
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPaarden = new System.Windows.Forms.TabPage();
            this.lblsaldo = new System.Windows.Forms.Label();
            this.txtsaldo = new System.Windows.Forms.TextBox();
            this.pctrbxpaard3 = new System.Windows.Forms.PictureBox();
            this.pctrbxpaard2 = new System.Windows.Forms.PictureBox();
            this.pctrbxpaard1 = new System.Windows.Forms.PictureBox();
            this.pctrbxfinish = new System.Windows.Forms.PictureBox();
            this.pctrbxstart = new System.Windows.Forms.PictureBox();
            this.btnstart = new System.Windows.Forms.Button();
            this.tabKlanten = new System.Windows.Forms.TabPage();
            this.tmrpaard1 = new System.Windows.Forms.Timer(this.components);
            this.tmrpaard2 = new System.Windows.Forms.Timer(this.components);
            this.tmrpaard3 = new System.Windows.Forms.Timer(this.components);
            this.btnP1 = new System.Windows.Forms.Button();
            this.btnP2 = new System.Windows.Forms.Button();
            this.btnP3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSetSaldo = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tabPaarden.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctrbxpaard3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrbxpaard2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrbxpaard1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrbxfinish)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrbxstart)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPaarden);
            this.tabControl.Controls.Add(this.tabKlanten);
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(802, 450);
            this.tabControl.TabIndex = 0;
            // 
            // tabPaarden
            // 
            this.tabPaarden.Controls.Add(this.btnSetSaldo);
            this.tabPaarden.Controls.Add(this.label1);
            this.tabPaarden.Controls.Add(this.btnP3);
            this.tabPaarden.Controls.Add(this.btnP2);
            this.tabPaarden.Controls.Add(this.btnP1);
            this.tabPaarden.Controls.Add(this.lblsaldo);
            this.tabPaarden.Controls.Add(this.txtsaldo);
            this.tabPaarden.Controls.Add(this.pctrbxpaard3);
            this.tabPaarden.Controls.Add(this.pctrbxpaard2);
            this.tabPaarden.Controls.Add(this.pctrbxpaard1);
            this.tabPaarden.Controls.Add(this.pctrbxfinish);
            this.tabPaarden.Controls.Add(this.pctrbxstart);
            this.tabPaarden.Controls.Add(this.btnstart);
            this.tabPaarden.Location = new System.Drawing.Point(4, 22);
            this.tabPaarden.Name = "tabPaarden";
            this.tabPaarden.Padding = new System.Windows.Forms.Padding(3);
            this.tabPaarden.Size = new System.Drawing.Size(794, 424);
            this.tabPaarden.TabIndex = 0;
            this.tabPaarden.Text = "Paarden";
            this.tabPaarden.UseVisualStyleBackColor = true;
            // 
            // lblsaldo
            // 
            this.lblsaldo.AutoSize = true;
            this.lblsaldo.Location = new System.Drawing.Point(622, 391);
            this.lblsaldo.Name = "lblsaldo";
            this.lblsaldo.Size = new System.Drawing.Size(35, 13);
            this.lblsaldo.TabIndex = 6;
            this.lblsaldo.Text = "saldo:";
            // 
            // txtsaldo
            // 
            this.txtsaldo.Location = new System.Drawing.Point(663, 388);
            this.txtsaldo.Name = "txtsaldo";
            this.txtsaldo.ReadOnly = true;
            this.txtsaldo.Size = new System.Drawing.Size(104, 20);
            this.txtsaldo.TabIndex = 1;
            this.txtsaldo.TextChanged += new System.EventHandler(this.Txtsaldo_TextChanged);
            // 
            // pctrbxpaard3
            // 
            this.pctrbxpaard3.Image = global::Paardenrennen.Properties.Resources.paard3;
            this.pctrbxpaard3.Location = new System.Drawing.Point(6, 243);
            this.pctrbxpaard3.Name = "pctrbxpaard3";
            this.pctrbxpaard3.Size = new System.Drawing.Size(124, 100);
            this.pctrbxpaard3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctrbxpaard3.TabIndex = 5;
            this.pctrbxpaard3.TabStop = false;
            // 
            // pctrbxpaard2
            // 
            this.pctrbxpaard2.Image = global::Paardenrennen.Properties.Resources.paard2;
            this.pctrbxpaard2.Location = new System.Drawing.Point(6, 137);
            this.pctrbxpaard2.Name = "pctrbxpaard2";
            this.pctrbxpaard2.Size = new System.Drawing.Size(124, 100);
            this.pctrbxpaard2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctrbxpaard2.TabIndex = 4;
            this.pctrbxpaard2.TabStop = false;
            // 
            // pctrbxpaard1
            // 
            this.pctrbxpaard1.Image = global::Paardenrennen.Properties.Resources.paard1;
            this.pctrbxpaard1.Location = new System.Drawing.Point(6, 31);
            this.pctrbxpaard1.Name = "pctrbxpaard1";
            this.pctrbxpaard1.Size = new System.Drawing.Size(124, 100);
            this.pctrbxpaard1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctrbxpaard1.TabIndex = 3;
            this.pctrbxpaard1.TabStop = false;
            // 
            // pctrbxfinish
            // 
            this.pctrbxfinish.Image = global::Paardenrennen.Properties.Resources.finish;
            this.pctrbxfinish.Location = new System.Drawing.Point(692, 6);
            this.pctrbxfinish.Name = "pctrbxfinish";
            this.pctrbxfinish.Size = new System.Drawing.Size(75, 367);
            this.pctrbxfinish.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctrbxfinish.TabIndex = 2;
            this.pctrbxfinish.TabStop = false;
            // 
            // pctrbxstart
            // 
            this.pctrbxstart.Image = global::Paardenrennen.Properties.Resources.start;
            this.pctrbxstart.Location = new System.Drawing.Point(33, 6);
            this.pctrbxstart.Name = "pctrbxstart";
            this.pctrbxstart.Size = new System.Drawing.Size(75, 367);
            this.pctrbxstart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctrbxstart.TabIndex = 1;
            this.pctrbxstart.TabStop = false;
            // 
            // btnstart
            // 
            this.btnstart.Location = new System.Drawing.Point(68, 379);
            this.btnstart.Name = "btnstart";
            this.btnstart.Size = new System.Drawing.Size(98, 37);
            this.btnstart.TabIndex = 0;
            this.btnstart.Text = "Start";
            this.btnstart.UseVisualStyleBackColor = true;
            this.btnstart.Click += new System.EventHandler(this.Btnstart_Click);
            // 
            // tabKlanten
            // 
            this.tabKlanten.Location = new System.Drawing.Point(4, 22);
            this.tabKlanten.Name = "tabKlanten";
            this.tabKlanten.Padding = new System.Windows.Forms.Padding(3);
            this.tabKlanten.Size = new System.Drawing.Size(794, 424);
            this.tabKlanten.TabIndex = 1;
            this.tabKlanten.Text = "Klantendienst";
            this.tabKlanten.UseVisualStyleBackColor = true;
            // 
            // tmrpaard1
            // 
            this.tmrpaard1.Interval = 10;
            this.tmrpaard1.Tick += new System.EventHandler(this.Tmrpaarden_Tick);
            // 
            // tmrpaard2
            // 
            this.tmrpaard2.Interval = 10;
            this.tmrpaard2.Tick += new System.EventHandler(this.Tmrpaard2_Tick);
            // 
            // tmrpaard3
            // 
            this.tmrpaard3.Interval = 10;
            this.tmrpaard3.Tick += new System.EventHandler(this.Tmrpaard3_Tick);
            // 
            // btnP1
            // 
            this.btnP1.Location = new System.Drawing.Point(247, 386);
            this.btnP1.Name = "btnP1";
            this.btnP1.Size = new System.Drawing.Size(75, 23);
            this.btnP1.TabIndex = 7;
            this.btnP1.Text = "paard 1";
            this.btnP1.UseVisualStyleBackColor = true;
            this.btnP1.Click += new System.EventHandler(this.BtnP1_Click);
            // 
            // btnP2
            // 
            this.btnP2.Location = new System.Drawing.Point(328, 386);
            this.btnP2.Name = "btnP2";
            this.btnP2.Size = new System.Drawing.Size(75, 23);
            this.btnP2.TabIndex = 8;
            this.btnP2.Text = "paard 2";
            this.btnP2.UseVisualStyleBackColor = true;
            this.btnP2.Click += new System.EventHandler(this.BtnP2_Click);
            // 
            // btnP3
            // 
            this.btnP3.Location = new System.Drawing.Point(409, 386);
            this.btnP3.Name = "btnP3";
            this.btnP3.Size = new System.Drawing.Size(75, 23);
            this.btnP3.TabIndex = 9;
            this.btnP3.Text = "paard 3";
            this.btnP3.UseVisualStyleBackColor = true;
            this.btnP3.Click += new System.EventHandler(this.BtnP3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(194, 391);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Inzetten:";
            // 
            // btnSetSaldo
            // 
            this.btnSetSaldo.Location = new System.Drawing.Point(541, 388);
            this.btnSetSaldo.Name = "btnSetSaldo";
            this.btnSetSaldo.Size = new System.Drawing.Size(75, 23);
            this.btnSetSaldo.TabIndex = 11;
            this.btnSetSaldo.Text = "set saldo";
            this.btnSetSaldo.UseVisualStyleBackColor = true;
            this.btnSetSaldo.Click += new System.EventHandler(this.BtnSetSaldo_Click);
            // 
            // frmpaardrennen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl);
            this.Name = "frmpaardrennen";
            this.Text = "Paardenrennen";
            this.tabControl.ResumeLayout(false);
            this.tabPaarden.ResumeLayout(false);
            this.tabPaarden.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctrbxpaard3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrbxpaard2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrbxpaard1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrbxfinish)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrbxstart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPaarden;
        private System.Windows.Forms.PictureBox pctrbxstart;
        private System.Windows.Forms.Button btnstart;
        private System.Windows.Forms.TabPage tabKlanten;
        private System.Windows.Forms.PictureBox pctrbxpaard3;
        private System.Windows.Forms.PictureBox pctrbxpaard2;
        private System.Windows.Forms.PictureBox pctrbxpaard1;
        private System.Windows.Forms.PictureBox pctrbxfinish;
        private System.Windows.Forms.Timer tmrpaard1;
        private System.Windows.Forms.Timer tmrpaard2;
        private System.Windows.Forms.Timer tmrpaard3;
        private System.Windows.Forms.Label lblsaldo;
        private System.Windows.Forms.TextBox txtsaldo;
        private System.Windows.Forms.Button btnP3;
        private System.Windows.Forms.Button btnP2;
        private System.Windows.Forms.Button btnP1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSetSaldo;
    }
}

