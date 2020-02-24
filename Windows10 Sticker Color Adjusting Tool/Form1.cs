using IWshRuntimeLibrary;
using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Windows10_Sticker_Color_Adjusting_Tool
{
	public partial class Form1 : Form
	{
		string lnkPath;
		string tgtDir;
		string name;
		string colorCode;
		string bright="light";
		Color color;
		public Form1()
		{
			InitializeComponent();
		}

		private void FileChooseClick(object sender, EventArgs e)
		{
			lnkPath = "未选择文件";
			name = "未选择文件";		nameLbl.Text = name;
			colorCode = "未选择颜色";colorCodeLbl.Text = colorCode;
			OpenFileDialog dialog = new OpenFileDialog();
			dialog.InitialDirectory = "C:/Users/"+Environment.UserName+"/AppData/Roaming/Microsoft/Windows/Start Menu/Programs";
			dialog.Multiselect = false;
			dialog.Title = "选择快捷方式";
			dialog.Filter = "快捷方式(*.lnk)|*.lnk";
			if (dialog.ShowDialog() == DialogResult.OK) lnkPath = dialog.FileName;
			else
			{
				dialog.Dispose();
				return;
			}
			tgtDir = GetFilePath(lnkPath);
			Console.WriteLine(tgtDir);
			if (!System.IO.File.Exists(tgtDir))
			{
				MessageBox.Show("路径无法访问，快捷方式可能已失效", "错误");
				return;
			}
			name = tgtDir.Split('\\').Last();
			tgtDir = tgtDir.Replace(name,"");
			name = name.Split('.')[0];
			nameLbl.Text = name;
		}
		private void ColorChoose_Click(object sender, EventArgs e)
		{
			if (colorDialog1.ShowDialog() == DialogResult.OK) color = colorDialog1.Color;
			else return;
			colorCode="#"+Convert.ToString(color.R, 16).PadLeft(2,'0')+Convert.ToString(color.G, 16).PadLeft(2, '0') + Convert.ToString(color.B, 16).PadLeft(2, '0');
			colorCodeLbl.Text = colorCode;
		}
		private void StartBtn_Click(object sender, EventArgs e)
		{
			if (lnkPath == "未选择文件" || name == "未选择文件")
			{
				MessageBox.Show("未选择文件", "错误");
				return;
			}
			else if (colorCode == "未选择颜色")
			{
				MessageBox.Show("未选择颜色", "错误");
				return;
			}
			string xml = "<Application xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\">\n<VisualElements\nBackgroundColor=\"" + colorCode + "\"\nForegroundText=\"" + bright + "\"\nShowNameOnSquare150x150Logo=\"on\">\n</VisualElements>\n</Application>";
			Console.WriteLine(xml);
			string manifest = tgtDir+name+".VisualElementsManifest.xml";
			System.IO.File.WriteAllText(manifest, xml);
			FileInfo info = new FileInfo(lnkPath);
			info.LastWriteTime = DateTime.Now;
			MessageBox.Show("已生成文件", "完成");
		}

		string GetFilePath(string lnkPath)
		{
			WshShell shell = new WshShell();
			IWshShortcut lnk = (IWshShortcut)shell.CreateShortcut(lnkPath);
			return lnk.TargetPath;
		}

		private void LightBtn_CheckedChanged(object sender, EventArgs e)
		{
			if (lightBtn.Checked)
			{
				darkBtn.Checked = false;
				bright = "light";
			}
			else
			{
				darkBtn.Checked = true;
				bright = "dark";
			}
			
		}
		private void DarkBtn_CheckedChanged(object sender, EventArgs e)
		{
			if (darkBtn.Checked)
			{
				lightBtn.Checked = false;
				bright = "dark";
			}
			else
			{
				lightBtn.Checked = true;
				bright = "light";
			}

		}

		private void FileEnter(object sender, DragEventArgs e)
		{
			if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.All;
			else e.Effect = DragDropEffects.None;
		}

		private void FileDrop(object sender, DragEventArgs e)
		{
			string dropPath = ((Array)e.Data.GetData(DataFormats.FileDrop)).GetValue(0).ToString();
			Console.WriteLine(dropPath);
		}
	}
}
