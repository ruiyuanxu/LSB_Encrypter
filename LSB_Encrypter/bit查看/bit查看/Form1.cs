using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace bit查看
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			
		}

		private void button1_Click(object sender, EventArgs e)
		{
			OpenFileDialog fileDialog = new OpenFileDialog();
			fileDialog.Multiselect = false;
			fileDialog.Title = "请选择文件";
			fileDialog.Filter = "所有文件(*.*)|*.*";
			if (fileDialog.ShowDialog() == DialogResult.OK)
			{
				string name = fileDialog.FileName;

				MessageBox.Show("已选择文件:" + name, "选择文件提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
				label1.Text = name;
				byte[] fA = StreamToBytes(new FileStream(name, FileMode.Open, FileAccess.Read));
				char[] cstr = new char[3 * fA.Length];
				for (int i = 0; i < fA.Length; ++i)
				{
					char[] achar = new char[3];
					int val = fA[i];

					int temp0 = (val / 16 + 48);
					if (temp0 > 57) temp0 += 8;
					achar[0] = Convert.ToChar(temp0);

					temp0 = (val % 16 + 48);
					if (temp0 > 57) temp0 += 8;
					achar[1] = Convert.ToChar(temp0);

					achar[2] = ' ';
					for (int j = 3 * i;j < 3 * i + 3; ++j)
					{
						cstr[j] = achar[j % 3];
					}
				}


				textBox1.Text = new string(cstr);
			}
		}

		public byte[] StreamToBytes(Stream stream)

		{

			byte[] bytes = new byte[stream.Length];

			stream.Read(bytes, 0, bytes.Length);

			// 设置当前流的位置为流的开始 

			stream.Seek(0, SeekOrigin.Begin);

			return bytes;

		}

		private void button2_Click(object sender, EventArgs e)
		{
			OpenFileDialog fileDialog = new OpenFileDialog();
			fileDialog.Multiselect = false;
			fileDialog.Title = "请选择文件";
			fileDialog.Filter = "所有文件(*.*)|*.*";
			if (fileDialog.ShowDialog() == DialogResult.OK)
			{
				string name = fileDialog.FileName;

				MessageBox.Show("已选择文件:" + name, "选择文件提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
				label2.Text = name;
				byte[] fA = StreamToBytes(new FileStream(name, FileMode.Open, FileAccess.Read));
				char[] cstr = new char[3 * fA.Length];
				for (int i = 0; i < fA.Length; ++i)
				{
					char[] achar = new char[3];
					int val = fA[i];

					int temp0 = (val / 16 + 48);
					if (temp0 > 57)temp0 += 8;
					achar[0] = Convert.ToChar(temp0);

					temp0 = (val % 16 + 48);
					if (temp0 > 57) temp0 += 8;
					achar[1] = Convert.ToChar(temp0);

					achar[2] = ' ';
					for (int j = 3 * i; j < 3 * i + 3; ++j)
					{
						cstr[j] = achar[j % 3];
					}
				}


				textBox2.Text = new string(cstr);
			}
		}

		private void label2_Click(object sender, EventArgs e)
		{

		}
	}
}
