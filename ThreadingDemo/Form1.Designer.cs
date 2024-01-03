namespace ThreadingDemo
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
            this.btnAsyncProcess = new System.Windows.Forms.Button();
            this.labelYumurtaKir = new System.Windows.Forms.Label();
            this.labelYumurtaCirp = new System.Windows.Forms.Label();
            this.labelTuzEkle = new System.Windows.Forms.Label();
            this.labelOcagiAc = new System.Windows.Forms.Label();
            this.labelTavayiIsit = new System.Windows.Forms.Label();
            this.labelYagiDok = new System.Windows.Forms.Label();
            this.labelYumurtaEkle = new System.Windows.Forms.Label();
            this.labelPisir = new System.Windows.Forms.Label();
            this.labelServisEt = new System.Windows.Forms.Label();
            this.listProcces = new System.Windows.Forms.ListBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.labelTimer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAsyncProcess
            // 
            this.btnAsyncProcess.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAsyncProcess.Location = new System.Drawing.Point(141, 90);
            this.btnAsyncProcess.Name = "btnAsyncProcess";
            this.btnAsyncProcess.Size = new System.Drawing.Size(254, 60);
            this.btnAsyncProcess.TabIndex = 1;
            this.btnAsyncProcess.Text = "Async İşlem Başlat";
            this.btnAsyncProcess.UseVisualStyleBackColor = true;
            this.btnAsyncProcess.Click += new System.EventHandler(this.btnAsyncProcess_Click);
            // 
            // labelYumurtaKir
            // 
            this.labelYumurtaKir.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelYumurtaKir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelYumurtaKir.Location = new System.Drawing.Point(588, 90);
            this.labelYumurtaKir.Name = "labelYumurtaKir";
            this.labelYumurtaKir.Size = new System.Drawing.Size(200, 25);
            this.labelYumurtaKir.TabIndex = 2;
            this.labelYumurtaKir.Text = "Yumurtaları Kır";
            this.labelYumurtaKir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelYumurtaCirp
            // 
            this.labelYumurtaCirp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelYumurtaCirp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelYumurtaCirp.Location = new System.Drawing.Point(588, 115);
            this.labelYumurtaCirp.Name = "labelYumurtaCirp";
            this.labelYumurtaCirp.Size = new System.Drawing.Size(200, 25);
            this.labelYumurtaCirp.TabIndex = 3;
            this.labelYumurtaCirp.Text = "Yumurtaları Çırp";
            this.labelYumurtaCirp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTuzEkle
            // 
            this.labelTuzEkle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelTuzEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelTuzEkle.Location = new System.Drawing.Point(588, 140);
            this.labelTuzEkle.Name = "labelTuzEkle";
            this.labelTuzEkle.Size = new System.Drawing.Size(200, 25);
            this.labelTuzEkle.TabIndex = 4;
            this.labelTuzEkle.Text = "Tuz Ekle";
            this.labelTuzEkle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelOcagiAc
            // 
            this.labelOcagiAc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelOcagiAc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelOcagiAc.Location = new System.Drawing.Point(588, 165);
            this.labelOcagiAc.Name = "labelOcagiAc";
            this.labelOcagiAc.Size = new System.Drawing.Size(200, 25);
            this.labelOcagiAc.TabIndex = 5;
            this.labelOcagiAc.Text = "Ocağı Aç";
            this.labelOcagiAc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTavayiIsit
            // 
            this.labelTavayiIsit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelTavayiIsit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelTavayiIsit.Location = new System.Drawing.Point(588, 215);
            this.labelTavayiIsit.Name = "labelTavayiIsit";
            this.labelTavayiIsit.Size = new System.Drawing.Size(200, 25);
            this.labelTavayiIsit.TabIndex = 6;
            this.labelTavayiIsit.Text = "Tavayı Isıt";
            this.labelTavayiIsit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelYagiDok
            // 
            this.labelYagiDok.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelYagiDok.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelYagiDok.Location = new System.Drawing.Point(588, 190);
            this.labelYagiDok.Name = "labelYagiDok";
            this.labelYagiDok.Size = new System.Drawing.Size(200, 25);
            this.labelYagiDok.TabIndex = 7;
            this.labelYagiDok.Text = "Yağı Dök";
            this.labelYagiDok.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelYumurtaEkle
            // 
            this.labelYumurtaEkle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelYumurtaEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelYumurtaEkle.Location = new System.Drawing.Point(588, 240);
            this.labelYumurtaEkle.Name = "labelYumurtaEkle";
            this.labelYumurtaEkle.Size = new System.Drawing.Size(200, 25);
            this.labelYumurtaEkle.TabIndex = 8;
            this.labelYumurtaEkle.Text = "Yumurta Ekle";
            this.labelYumurtaEkle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPisir
            // 
            this.labelPisir.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelPisir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelPisir.Location = new System.Drawing.Point(588, 265);
            this.labelPisir.Name = "labelPisir";
            this.labelPisir.Size = new System.Drawing.Size(200, 25);
            this.labelPisir.TabIndex = 9;
            this.labelPisir.Text = "Pişir";
            this.labelPisir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelServisEt
            // 
            this.labelServisEt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelServisEt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelServisEt.Location = new System.Drawing.Point(588, 290);
            this.labelServisEt.Name = "labelServisEt";
            this.labelServisEt.Size = new System.Drawing.Size(200, 25);
            this.labelServisEt.TabIndex = 10;
            this.labelServisEt.Text = "Servis Et";
            this.labelServisEt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listProcces
            // 
            this.listProcces.FormattingEnabled = true;
            this.listProcces.Location = new System.Drawing.Point(85, 265);
            this.listProcces.Name = "listProcces";
            this.listProcces.Size = new System.Drawing.Size(369, 173);
            this.listProcces.TabIndex = 11;
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(585, 343);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Geçen Süre : ";
            // 
            // labelTimer
            // 
            this.labelTimer.AutoSize = true;
            this.labelTimer.Location = new System.Drawing.Point(680, 343);
            this.labelTimer.Name = "labelTimer";
            this.labelTimer.Size = new System.Drawing.Size(0, 13);
            this.labelTimer.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelTimer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listProcces);
            this.Controls.Add(this.labelServisEt);
            this.Controls.Add(this.labelPisir);
            this.Controls.Add(this.labelYumurtaEkle);
            this.Controls.Add(this.labelYagiDok);
            this.Controls.Add(this.labelTavayiIsit);
            this.Controls.Add(this.labelOcagiAc);
            this.Controls.Add(this.labelTuzEkle);
            this.Controls.Add(this.labelYumurtaCirp);
            this.Controls.Add(this.labelYumurtaKir);
            this.Controls.Add(this.btnAsyncProcess);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAsyncProcess;
        private System.Windows.Forms.Label labelYumurtaKir;
        private System.Windows.Forms.Label labelYumurtaCirp;
        private System.Windows.Forms.Label labelTuzEkle;
        private System.Windows.Forms.Label labelOcagiAc;
        private System.Windows.Forms.Label labelTavayiIsit;
        private System.Windows.Forms.Label labelYagiDok;
        private System.Windows.Forms.Label labelYumurtaEkle;
        private System.Windows.Forms.Label labelPisir;
        private System.Windows.Forms.Label labelServisEt;
        private System.Windows.Forms.ListBox listProcces;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelTimer;
    }
}

