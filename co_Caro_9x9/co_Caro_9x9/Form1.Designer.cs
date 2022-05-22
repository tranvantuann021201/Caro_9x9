namespace co_Caro_9x9
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_LuotDi = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tinhDiemX = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_tinhDiemX = new System.Windows.Forms.Label();
            this.lb_tinhDiemO = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_choiLai = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(454, 452);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btn_Thoat, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.button1, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btn_LuotDi, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btn_choiLai, 0, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(469, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.69231F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 72.30769F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 81F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(226, 484);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Thoat.Location = new System.Drawing.Point(3, 389);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(220, 44);
            this.btn_Thoat.TabIndex = 6;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(3, 336);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(220, 47);
            this.button1.TabIndex = 5;
            this.button1.Text = "Chơi mới";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 167);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(220, 31);
            this.panel3.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tỉ số:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_LuotDi
            // 
            this.btn_LuotDi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_LuotDi.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LuotDi.ForeColor = System.Drawing.Color.Red;
            this.btn_LuotDi.Location = new System.Drawing.Point(3, 48);
            this.btn_LuotDi.Name = "btn_LuotDi";
            this.btn_LuotDi.Size = new System.Drawing.Size(220, 113);
            this.btn_LuotDi.TabIndex = 0;
            this.btn_LuotDi.Text = "X";
            this.btn_LuotDi.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tinhDiemX);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(220, 39);
            this.panel2.TabIndex = 1;
            // 
            // tinhDiemX
            // 
            this.tinhDiemX.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tinhDiemX.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tinhDiemX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tinhDiemX.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tinhDiemX.Location = new System.Drawing.Point(0, 0);
            this.tinhDiemX.Name = "tinhDiemX";
            this.tinhDiemX.Size = new System.Drawing.Size(220, 39);
            this.tinhDiemX.TabIndex = 4;
            this.tinhDiemX.Text = "Lượt đi";
            this.tinhDiemX.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.63636F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.36364F));
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lb_tinhDiemX, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.lb_tinhDiemO, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 204);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(220, 57);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 28);
            this.label2.TabIndex = 5;
            this.label2.Text = "Người chơi X:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_tinhDiemX
            // 
            this.lb_tinhDiemX.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lb_tinhDiemX.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lb_tinhDiemX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_tinhDiemX.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tinhDiemX.Location = new System.Drawing.Point(142, 0);
            this.lb_tinhDiemX.Name = "lb_tinhDiemX";
            this.lb_tinhDiemX.Size = new System.Drawing.Size(75, 28);
            this.lb_tinhDiemX.TabIndex = 5;
            this.lb_tinhDiemX.Text = "0";
            this.lb_tinhDiemX.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb_tinhDiemX.Click += new System.EventHandler(this.lb_tinhDiemX_Click);
            // 
            // lb_tinhDiemO
            // 
            this.lb_tinhDiemO.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lb_tinhDiemO.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lb_tinhDiemO.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_tinhDiemO.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tinhDiemO.Location = new System.Drawing.Point(142, 28);
            this.lb_tinhDiemO.Name = "lb_tinhDiemO";
            this.lb_tinhDiemO.Size = new System.Drawing.Size(75, 29);
            this.lb_tinhDiemO.TabIndex = 5;
            this.lb_tinhDiemO.Text = "0";
            this.lb_tinhDiemO.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 29);
            this.label4.TabIndex = 7;
            this.label4.Text = "Người chơi O:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_choiLai
            // 
            this.btn_choiLai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_choiLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_choiLai.Location = new System.Drawing.Point(3, 285);
            this.btn_choiLai.Name = "btn_choiLai";
            this.btn_choiLai.Size = new System.Drawing.Size(220, 45);
            this.btn_choiLai.TabIndex = 4;
            this.btn_choiLai.Text = "Chơi lại";
            this.btn_choiLai.UseVisualStyleBackColor = true;
            this.btn_choiLai.Click += new System.EventHandler(this.btn_choiLai_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(22F, 42F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(695, 484);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(12, 10, 12, 10);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_LuotDi;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label tinhDiemX;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_tinhDiemX;
        private System.Windows.Forms.Label lb_tinhDiemO;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_choiLai;
    }
}

