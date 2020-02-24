namespace Windows10_Sticker_Color_Adjusting_Tool
{
	partial class Form1
	{
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清理所有正在使用的资源。
		/// </summary>
		/// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows 窗体设计器生成的代码

		/// <summary>
		/// 设计器支持所需的方法 - 不要修改
		/// 使用代码编辑器修改此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.fileChoose = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.nameLbl = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.colorChoose = new System.Windows.Forms.Button();
			this.colorDialog1 = new System.Windows.Forms.ColorDialog();
			this.colorCodeLbl = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.darkBtn = new System.Windows.Forms.RadioButton();
			this.lightBtn = new System.Windows.Forms.RadioButton();
			this.startBtn = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// fileChoose
			// 
			this.fileChoose.AllowDrop = true;
			this.fileChoose.BackColor = System.Drawing.Color.WhiteSmoke;
			this.fileChoose.Cursor = System.Windows.Forms.Cursors.Hand;
			this.fileChoose.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
			this.fileChoose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.fileChoose.Font = new System.Drawing.Font("等线", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.fileChoose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(115)))), ((int)(((byte)(232)))));
			this.fileChoose.Location = new System.Drawing.Point(0, 53);
			this.fileChoose.Name = "fileChoose";
			this.fileChoose.Size = new System.Drawing.Size(381, 43);
			this.fileChoose.TabIndex = 0;
			this.fileChoose.Text = "点击以选择快捷方式";
			this.fileChoose.UseVisualStyleBackColor = true;
			this.fileChoose.Click += new System.EventHandler(this.FileChooseClick);
			this.fileChoose.DragDrop += new System.Windows.Forms.DragEventHandler(this.FileDrop);
			this.fileChoose.DragEnter += new System.Windows.Forms.DragEventHandler(this.FileEnter);
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
			this.groupBox1.Controls.Add(this.fileChoose);
			this.groupBox1.Controls.Add(this.nameLbl);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(381, 97);
			this.groupBox1.TabIndex = 3;
			this.groupBox1.TabStop = false;
			// 
			// nameLbl
			// 
			this.nameLbl.AllowDrop = true;
			this.nameLbl.AutoSize = true;
			this.nameLbl.Font = new System.Drawing.Font("等线 Light", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.nameLbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.nameLbl.Location = new System.Drawing.Point(75, 22);
			this.nameLbl.Name = "nameLbl";
			this.nameLbl.Size = new System.Drawing.Size(77, 14);
			this.nameLbl.TabIndex = 4;
			this.nameLbl.Text = "未选择文件";
			this.nameLbl.DragDrop += new System.Windows.Forms.DragEventHandler(this.FileDrop);
			this.nameLbl.DragEnter += new System.Windows.Forms.DragEventHandler(this.FileEnter);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("等线", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label5.Location = new System.Drawing.Point(12, 22);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(66, 14);
			this.label5.TabIndex = 3;
			this.label5.Text = "目标文件:";
			// 
			// colorChoose
			// 
			this.colorChoose.BackColor = System.Drawing.Color.WhiteSmoke;
			this.colorChoose.Cursor = System.Windows.Forms.Cursors.Hand;
			this.colorChoose.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
			this.colorChoose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.colorChoose.Font = new System.Drawing.Font("等线", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.colorChoose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(115)))), ((int)(((byte)(232)))));
			this.colorChoose.Location = new System.Drawing.Point(0, 76);
			this.colorChoose.Name = "colorChoose";
			this.colorChoose.Size = new System.Drawing.Size(381, 44);
			this.colorChoose.TabIndex = 3;
			this.colorChoose.Text = "选择颜色";
			this.colorChoose.UseVisualStyleBackColor = false;
			this.colorChoose.Click += new System.EventHandler(this.ColorChoose_Click);
			// 
			// colorDialog1
			// 
			this.colorDialog1.AnyColor = true;
			// 
			// colorCodeLbl
			// 
			this.colorCodeLbl.AutoSize = true;
			this.colorCodeLbl.Font = new System.Drawing.Font("等线 Light", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.colorCodeLbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.colorCodeLbl.Location = new System.Drawing.Point(75, 25);
			this.colorCodeLbl.Name = "colorCodeLbl";
			this.colorCodeLbl.Size = new System.Drawing.Size(77, 14);
			this.colorCodeLbl.TabIndex = 4;
			this.colorCodeLbl.Text = "未选择颜色";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("等线", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label3.Location = new System.Drawing.Point(12, 25);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(66, 14);
			this.label3.TabIndex = 3;
			this.label3.Text = "背景颜色:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("等线", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label2.Location = new System.Drawing.Point(206, 27);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(66, 14);
			this.label2.TabIndex = 7;
			this.label2.Text = "字体颜色:";
			// 
			// groupBox2
			// 
			this.groupBox2.BackColor = System.Drawing.Color.WhiteSmoke;
			this.groupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.groupBox2.Controls.Add(this.darkBtn);
			this.groupBox2.Controls.Add(this.lightBtn);
			this.groupBox2.Controls.Add(this.colorChoose);
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Controls.Add(this.colorCodeLbl);
			this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.groupBox2.Location = new System.Drawing.Point(12, 131);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(381, 122);
			this.groupBox2.TabIndex = 8;
			this.groupBox2.TabStop = false;
			// 
			// darkBtn
			// 
			this.darkBtn.AutoSize = true;
			this.darkBtn.Font = new System.Drawing.Font("等线", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.darkBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
			this.darkBtn.Location = new System.Drawing.Point(324, 25);
			this.darkBtn.Name = "darkBtn";
			this.darkBtn.Size = new System.Drawing.Size(39, 18);
			this.darkBtn.TabIndex = 9;
			this.darkBtn.TabStop = true;
			this.darkBtn.Text = "暗";
			this.darkBtn.UseVisualStyleBackColor = true;
			this.darkBtn.CheckedChanged += new System.EventHandler(this.DarkBtn_CheckedChanged);
			// 
			// lightBtn
			// 
			this.lightBtn.AutoSize = true;
			this.lightBtn.Checked = true;
			this.lightBtn.Font = new System.Drawing.Font("等线", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.lightBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
			this.lightBtn.Location = new System.Drawing.Point(281, 25);
			this.lightBtn.Name = "lightBtn";
			this.lightBtn.Size = new System.Drawing.Size(39, 18);
			this.lightBtn.TabIndex = 8;
			this.lightBtn.TabStop = true;
			this.lightBtn.Text = "亮";
			this.lightBtn.UseVisualStyleBackColor = true;
			this.lightBtn.CheckedChanged += new System.EventHandler(this.LightBtn_CheckedChanged);
			// 
			// startBtn
			// 
			this.startBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(236)))), ((int)(((byte)(249)))));
			this.startBtn.Cursor = System.Windows.Forms.Cursors.Hand;
			this.startBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(215)))), ((int)(((byte)(255)))));
			this.startBtn.FlatAppearance.BorderSize = 2;
			this.startBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.startBtn.Font = new System.Drawing.Font("等线", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.startBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(115)))), ((int)(((byte)(232)))));
			this.startBtn.Location = new System.Drawing.Point(12, 293);
			this.startBtn.Name = "startBtn";
			this.startBtn.Size = new System.Drawing.Size(381, 40);
			this.startBtn.TabIndex = 10;
			this.startBtn.Text = "生成修改";
			this.startBtn.UseVisualStyleBackColor = false;
			this.startBtn.Click += new System.EventHandler(this.StartBtn_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(405, 357);
			this.Controls.Add(this.startBtn);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Font = new System.Drawing.Font("等线", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.ForeColor = System.Drawing.Color.Navy;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "磁贴颜色修改";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button fileChoose;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button colorChoose;
		private System.Windows.Forms.ColorDialog colorDialog1;
		private System.Windows.Forms.Label colorCodeLbl;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label nameLbl;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.RadioButton lightBtn;
		private System.Windows.Forms.RadioButton darkBtn;
		private System.Windows.Forms.Button startBtn;
	}
}

