namespace Modern_Flat_UI
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBuffer = new System.Windows.Forms.Button();
            this.btnY = new System.Windows.Forms.Button();
            this.btnX = new System.Windows.Forms.Button();
            this.btnModbus = new System.Windows.Forms.Button();
            this.btnPlc = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblMain = new System.Windows.Forms.Label();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panel1.Controls.Add(this.btnBuffer);
            this.panel1.Controls.Add(this.btnY);
            this.panel1.Controls.Add(this.btnX);
            this.panel1.Controls.Add(this.btnModbus);
            this.panel1.Controls.Add(this.btnPlc);
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 431);
            this.panel1.TabIndex = 0;
            // 
            // btnBuffer
            // 
            this.btnBuffer.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBuffer.FlatAppearance.BorderSize = 0;
            this.btnBuffer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuffer.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnBuffer.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnBuffer.Location = new System.Drawing.Point(0, 360);
            this.btnBuffer.Name = "btnBuffer";
            this.btnBuffer.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.btnBuffer.Size = new System.Drawing.Size(220, 70);
            this.btnBuffer.TabIndex = 6;
            this.btnBuffer.Text = "Buffer Memory";
            this.btnBuffer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuffer.UseVisualStyleBackColor = true;
            this.btnBuffer.Click += new System.EventHandler(this.btnBuffer_Click);
            // 
            // btnY
            // 
            this.btnY.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnY.FlatAppearance.BorderSize = 0;
            this.btnY.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnY.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnY.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnY.Location = new System.Drawing.Point(0, 290);
            this.btnY.Name = "btnY";
            this.btnY.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.btnY.Size = new System.Drawing.Size(220, 70);
            this.btnY.TabIndex = 5;
            this.btnY.Text = "Y Memory";
            this.btnY.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnY.UseVisualStyleBackColor = true;
            this.btnY.Click += new System.EventHandler(this.btnY_Click);
            // 
            // btnX
            // 
            this.btnX.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnX.FlatAppearance.BorderSize = 0;
            this.btnX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnX.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnX.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnX.Location = new System.Drawing.Point(0, 220);
            this.btnX.Name = "btnX";
            this.btnX.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.btnX.Size = new System.Drawing.Size(220, 70);
            this.btnX.TabIndex = 4;
            this.btnX.Text = "X Memory";
            this.btnX.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnX.UseVisualStyleBackColor = true;
            this.btnX.Click += new System.EventHandler(this.btnX_Click);
            // 
            // btnModbus
            // 
            this.btnModbus.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnModbus.FlatAppearance.BorderSize = 0;
            this.btnModbus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModbus.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnModbus.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnModbus.Location = new System.Drawing.Point(0, 150);
            this.btnModbus.Name = "btnModbus";
            this.btnModbus.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.btnModbus.Size = new System.Drawing.Size(220, 70);
            this.btnModbus.TabIndex = 3;
            this.btnModbus.Text = "Modbus";
            this.btnModbus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModbus.UseVisualStyleBackColor = true;
            this.btnModbus.Click += new System.EventHandler(this.btnModbus_Click);
            // 
            // btnPlc
            // 
            this.btnPlc.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPlc.FlatAppearance.BorderSize = 0;
            this.btnPlc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlc.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnPlc.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnPlc.Location = new System.Drawing.Point(0, 80);
            this.btnPlc.Name = "btnPlc";
            this.btnPlc.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.btnPlc.Size = new System.Drawing.Size(220, 70);
            this.btnPlc.TabIndex = 2;
            this.btnPlc.Text = "PLC";
            this.btnPlc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPlc.UseVisualStyleBackColor = true;
            this.btnPlc.Click += new System.EventHandler(this.btnPlc_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("나눔고딕", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnHome.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnHome.Location = new System.Drawing.Point(0, 0);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(220, 80);
            this.btnHome.TabIndex = 1;
            this.btnHome.Text = "깹TV";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.btnMinimize);
            this.panel3.Controls.Add(this.lblMain);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(220, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(664, 80);
            this.panel3.TabIndex = 1;
            // 
            // lblMain
            // 
            this.lblMain.AutoSize = true;
            this.lblMain.Font = new System.Drawing.Font("나눔고딕", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblMain.ForeColor = System.Drawing.Color.White;
            this.lblMain.Location = new System.Drawing.Point(302, 28);
            this.lblMain.Name = "lblMain";
            this.lblMain.Size = new System.Drawing.Size(74, 24);
            this.lblMain.TabIndex = 0;
            this.lblMain.Text = "HOME";
            // 
            // btnMinimize
            // 
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.Location = new System.Drawing.Point(595, 3);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(30, 30);
            this.btnMinimize.TabIndex = 1;
            this.btnMinimize.Text = "O";
            this.btnMinimize.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(631, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 30);
            this.button1.TabIndex = 2;
            this.button1.Text = "O";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 431);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(900, 470);
            this.MinimumSize = new System.Drawing.Size(900, 470);
            this.Name = "Form1";
            this.Text = "Modbus Server (for Conveyor)";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnX;
        private System.Windows.Forms.Button btnModbus;
        private System.Windows.Forms.Button btnPlc;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnY;
        private System.Windows.Forms.Button btnBuffer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Label lblMain;
    }
}

