using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Collections;

namespace LSB_Encrypter
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}


		private FileStream bmpfs { get; set; }


		private int maxSize;

		public byte[] bytestobehidden { get; set; }


		private void Form1_Load(object sender, EventArgs e)
		{
			checkedListBox1.SelectedIndex = 0;
		}

		private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
		{
			if (e.CurrentValue == CheckState.Checked) return;//取消选中就不用进行以下操作  
			for (int i = 0; i < ((CheckedListBox)sender).Items.Count; i++)
			{
				((CheckedListBox)sender).SetItemChecked(i, false);//将所有选项设为不选中  
			}
			e.NewValue = CheckState.Checked;//刷新  
		}

		private void AnalysisBtn_Click(object sender, EventArgs e)
		{

		}

		private void ChooseBtn_Click(object sender, EventArgs e)
		{
			OpenFileDialog fileDialog = new OpenFileDialog();
			fileDialog.Multiselect = false;
			fileDialog.Title = "请选择文件";
			fileDialog.Filter = "bmp文件(*.bmp)|*.bmp";
			if (fileDialog.ShowDialog() == DialogResult.OK)
			{
				string name = fileDialog.FileName;
				MessageBox.Show("已选择文件:" + name, "选择文件提示", MessageBoxButtons.OK, MessageBoxIcon.Information);

				textBox1.Text = name;
				if (File.Exists(name + "copy.bmp"))
					File.Delete(name + "copy.bmp");
				File.Copy(name,name + "copy.bmp");
				bmpfs = new FileStream(name + "copy.bmp", FileMode.Open, FileAccess.ReadWrite);
				pictureBox.Image = Image.FromFile(name, false);
			}
		}

		public byte[] fileToEn { get; set; }

		private FileStream fs;

		private void inputBtn_Click(object sender, EventArgs e)
		{

			switch (checkedListBox1.SelectedIndex)
			{
				default:
				case 0:
					OpenFileDialog fileDialog = new OpenFileDialog();
					fileDialog.Multiselect = false;
					fileDialog.Title = "请选择文件";
					fileDialog.Filter = "所有文件(*.*)|*.*";
					if (fileDialog.ShowDialog() == DialogResult.OK)
					{
						string name = fileDialog.FileName;
						MessageBox.Show("已选择文件:" + name, "选择文件提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
						fs = File.OpenRead(name);
						world.infoo = false;
						bytestobehidden = getBytes();
					}
					else { }
					break;
				case 1:
					world.foo = Microsoft.VisualBasic.Interaction.InputBox("String to be encrypted", "InputBox", "");
					world.infoo = true;
					bytestobehidden = getBytes();
					break;
			}


		}

		private void EncryptButton_Click(object sender, EventArgs e)
		{
			
			byte[] BMPfile = StreamToBytes(bmpfs);
			maxSize = (BMPfile.Length - 54) / 8;
			if (bytestobehidden.Length < maxSize)
			{
				BitArray SrcHidBA = new BitArray(bytestobehidden);
				BitArray TgtBA = new BitArray(BMPfile);
				for (int i = 54 * 8 - 1, j = 0; j < SrcHidBA.Length; i += 8, ++j)
					TgtBA[i] = SrcHidBA[j];
				TgtBA.CopyTo(BMPfile, 0);
				bmpfs.Write(BMPfile, 0, BMPfile.Length);
				pictureBox.Image = Image.FromStream(bmpfs);
				
			}
			else
			{
				MessageBox.Show("Too long! MaxLenght:\n" + Convert.ToString(maxSize)+"bytes", "Error");
			}
		}

		public byte[] getBytes()

		{
			if (world.infoo)
			{
				byte[] byteArray1 = System.Text.Encoding.Default.GetBytes(world.foo);
				textBox2.Text = world.foo;
				return byteArray1;
			}
			else
			{

				byte[] bytes = new byte[fs.Length];

				fs.Read(bytes, 0, bytes.Length);

				// 设置当前流的位置为流的开始 

				fs.Seek(0, SeekOrigin.Begin);

				textBox2.Text = System.Text.Encoding.Default.GetString(bytes);

				return bytes;
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
	}
}
