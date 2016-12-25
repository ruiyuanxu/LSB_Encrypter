namespace LSB_Encrypter
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
			this.pictureBox = new System.Windows.Forms.PictureBox();
			this.EncryptButton = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.ChooseFileBtn = new System.Windows.Forms.Button();
			this.TextToEncyLabel = new System.Windows.Forms.Label();
			this.sign = new System.Windows.Forms.Label();
			this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
			this.inputBtn = new System.Windows.Forms.Button();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.AnaBtn = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox
			// 
			this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBox.Location = new System.Drawing.Point(351, 34);
			this.pictureBox.Name = "pictureBox";
			this.pictureBox.Size = new System.Drawing.Size(292, 377);
			this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox.TabIndex = 0;
			this.pictureBox.TabStop = false;
			// 
			// EncryptButton
			// 
			this.EncryptButton.Font = new System.Drawing.Font("Consolas", 9F);
			this.EncryptButton.Location = new System.Drawing.Point(61, 446);
			this.EncryptButton.Name = "EncryptButton";
			this.EncryptButton.Size = new System.Drawing.Size(198, 27);
			this.EncryptButton.TabIndex = 2;
			this.EncryptButton.Text = "Encrypt";
			this.EncryptButton.UseVisualStyleBackColor = true;
			this.EncryptButton.Click += new System.EventHandler(this.EncryptButton_Click);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(14, 65);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(257, 22);
			this.textBox1.TabIndex = 3;
			// 
			// ChooseFileBtn
			// 
			this.ChooseFileBtn.Font = new System.Drawing.Font("Consolas", 7F);
			this.ChooseFileBtn.Location = new System.Drawing.Point(269, 64);
			this.ChooseFileBtn.Name = "ChooseFileBtn";
			this.ChooseFileBtn.Size = new System.Drawing.Size(75, 27);
			this.ChooseFileBtn.TabIndex = 4;
			this.ChooseFileBtn.Text = "ChooseFile";
			this.ChooseFileBtn.UseVisualStyleBackColor = true;
			this.ChooseFileBtn.Click += new System.EventHandler(this.ChooseBtn_Click);
			// 
			// TextToEncyLabel
			// 
			this.TextToEncyLabel.AutoSize = true;
			this.TextToEncyLabel.Font = new System.Drawing.Font("Consolas", 9F);
			this.TextToEncyLabel.Location = new System.Drawing.Point(17, 119);
			this.TextToEncyLabel.Name = "TextToEncyLabel";
			this.TextToEncyLabel.Size = new System.Drawing.Size(196, 14);
			this.TextToEncyLabel.TabIndex = 5;
			this.TextToEncyLabel.Text = "Choose a file or raw-input.";
			// 
			// sign
			// 
			this.sign.AutoSize = true;
			this.sign.Font = new System.Drawing.Font("Consolas", 9F);
			this.sign.Location = new System.Drawing.Point(17, 45);
			this.sign.Name = "sign";
			this.sign.Size = new System.Drawing.Size(154, 14);
			this.sign.TabIndex = 6;
			this.sign.Text = "BMP Picture File Path";
			// 
			// checkedListBox1
			// 
			this.checkedListBox1.BackColor = System.Drawing.Color.WhiteSmoke;
			this.checkedListBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.checkedListBox1.CheckOnClick = true;
			this.checkedListBox1.Font = new System.Drawing.Font("Consolas", 9F);
			this.checkedListBox1.FormattingEnabled = true;
			this.checkedListBox1.Items.AddRange(new object[] {
            "Encrypt data from an existing file",
            "Encrypt data from an input box"});
			this.checkedListBox1.Location = new System.Drawing.Point(31, 138);
			this.checkedListBox1.Name = "checkedListBox1";
			this.checkedListBox1.Size = new System.Drawing.Size(313, 34);
			this.checkedListBox1.Sorted = true;
			this.checkedListBox1.TabIndex = 7;
			this.checkedListBox1.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBox1_ItemCheck);
			// 
			// inputBtn
			// 
			this.inputBtn.Location = new System.Drawing.Point(133, 184);
			this.inputBtn.Name = "inputBtn";
			this.inputBtn.Size = new System.Drawing.Size(87, 27);
			this.inputBtn.TabIndex = 8;
			this.inputBtn.Text = "input data";
			this.inputBtn.UseVisualStyleBackColor = true;
			this.inputBtn.Click += new System.EventHandler(this.inputBtn_Click);
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(34, 254);
			this.textBox2.Multiline = true;
			this.textBox2.Name = "textBox2";
			this.textBox2.ReadOnly = true;
			this.textBox2.Size = new System.Drawing.Size(271, 184);
			this.textBox2.TabIndex = 9;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(19, 237);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(56, 14);
			this.label1.TabIndex = 10;
			this.label1.Text = "preview";
			// 
			// AnaBtn
			// 
			this.AnaBtn.Font = new System.Drawing.Font("Consolas", 9F);
			this.AnaBtn.Location = new System.Drawing.Point(454, 429);
			this.AnaBtn.Name = "AnaBtn";
			this.AnaBtn.Size = new System.Drawing.Size(87, 27);
			this.AnaBtn.TabIndex = 11;
			this.AnaBtn.Text = "Analyse";
			this.AnaBtn.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.ClientSize = new System.Drawing.Size(657, 482);
			this.Controls.Add(this.AnaBtn);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.inputBtn);
			this.Controls.Add(this.checkedListBox1);
			this.Controls.Add(this.sign);
			this.Controls.Add(this.TextToEncyLabel);
			this.Controls.Add(this.ChooseFileBtn);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.EncryptButton);
			this.Controls.Add(this.pictureBox);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Consolas", 9F);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.Text = "Mizumoto-BMP-Encrypter";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox;
		private System.Windows.Forms.Button EncryptButton;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button ChooseFileBtn;
		private System.Windows.Forms.Label TextToEncyLabel;
		private System.Windows.Forms.Label sign;
		private System.Windows.Forms.CheckedListBox checkedListBox1;
		private System.Windows.Forms.Button inputBtn;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button AnaBtn;
	}
}

