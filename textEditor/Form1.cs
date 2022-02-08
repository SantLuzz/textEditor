using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


/*Falta criar as rotinas de texto, refazer, desfazer e configurações de impressão*/
namespace textEditor
{
    public partial class Form1 : Form
    {
        StringReader reader = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void close()
        {
            this.Close();
        }

        private void newFile()
        {
            callNewFile();
            rtb_main.Clear();
            rtb_main.Focus();
        }

        private void callNewFile()
        {
            if (!string.IsNullOrEmpty(rtb_main.Text))
            {
                if(MessageBox.Show("Deseja Salvar o arquivo?","Salvar Arquivo", MessageBoxButtons.YesNo, MessageBoxIcon.Question,MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    saveFile();
                }
            }
        }

        private void saveFile()
        {
            try
            {
                if (this.saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    FileStream file = new FileStream(saveFileDialog1.FileName, FileMode.OpenOrCreate, FileAccess.Write);
                    StreamWriter file_streamWriter = new StreamWriter(file); 
                    file_streamWriter.Flush();
                    file_streamWriter.BaseStream.Seek(0, SeekOrigin.Begin);
                    file_streamWriter.Write(rtb_main);
                    file_streamWriter.Flush();
                    file_streamWriter.Close(); 
                }
            }catch(Exception ex)
            {
                MessageBox.Show("Erro ao salvar: " + ex.Message, "Erro ao Salvar o Arquivo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void openFile()
        {
            try
            {
                this.openFileDialog1.Title = "Abrir Arquivo";
                openFileDialog1.InitialDirectory = @"D:\Code\C#\Aulas\Paticas\textEditor";
                openFileDialog1.Filter = "(*.lfs)|*.lfs";
                DialogResult open = this.openFileDialog1.ShowDialog();
                if (open == System.Windows.Forms.DialogResult.OK)
                {
                    FileStream file = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read);
                    StreamReader file_streamReader = new StreamReader(file);
                    file_streamReader.BaseStream.Seek(0, SeekOrigin.Begin);
                    this.rtb_main.Text = "";
                    string row = file_streamReader.ReadLine();
                    while(row != null)
                    {
                        this.rtb_main.Text += row + "\n";
                        row = file_streamReader.ReadLine();
                    }
                    file_streamReader.Close();
                }
            }catch(Exception ex)
            {
                MessageBox.Show("Erro ao Abrir: " + ex.Message, "Erro ao Abrir o Arquivo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void copy()
        {
            if(rtb_main.SelectionLength > 0)
            {
                rtb_main.Copy();
            }
        }

        private void cut()
        {
            if(rtb_main.SelectionLength > 0)
            {
                rtb_main.Cut();
            }
        }

        private void paste()
        {
            rtb_main.Paste();
        }

        private void printFile()
        {
            printDialog1.Document = printDocument1;
            string text = this.rtb_main.Text;
            reader = new StringReader(text);
            if(printDialog1.ShowDialog() == DialogResult.OK)
            {
                this.printDocument1.Print();
            }
        }

        private void printPreview()
        {
            //verificar por que está com problema de margem na direita
            try
            {
                string text = this.rtb_main.Text;
                reader = new StringReader(text);
                PrintPreviewDialog printPreviewDialog1 = new PrintPreviewDialog();
                var ppd = printPreviewDialog1;
                ppd.Document = this.printDocument1;
                ppd.Text = "Vizualizando a impressão";
                ppd.WindowState = FormWindowState.Maximized;
                ppd.PrintPreviewControl.Zoom = 1;
                ppd.FormBorderStyle = FormBorderStyle.Fixed3D;
                ppd.ShowDialog();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro ao vizualizar a impressão: " + ex.Message, "Erro ao Vizualizar a Impressão", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //verificar por que está sem margem na direita
            float rowPage = 0;
            float posY = 0;
            int count = 0;
            float marginLeft = e.MarginBounds.Left - 50;
            float marginTop = e.MarginBounds.Top - 50;
            string row = null;

            if (marginLeft < 5)
            {
                marginLeft = 20;
            }
            if (marginTop < 5)
            {
                marginTop = 20;
            }

            Font font = this.rtb_main.Font;
            SolidBrush brush = new SolidBrush(Color.Black);
            rowPage = e.MarginBounds.Height / font.GetHeight(e.Graphics);
            row = reader.ReadLine();
            while (count < rowPage)
            {
                posY = (marginTop + (count * font.GetHeight(e.Graphics)));
                e.Graphics.DrawString(row, font, brush, marginTop, posY, new StringFormat());
                count += 1;
                row = reader.ReadLine();
            }
            if (row != null)
            {
                e.HasMorePages = true;
            }
            else
            {
                e.HasMorePages = false;
            }
            brush.Dispose();
        }

        private void alignmentLeft()
        {
            rtb_main.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void alignmentCenter()
        {
            rtb_main.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void alignmentRight()
        {
            rtb_main.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void btn_newFile_Click(object sender, EventArgs e)
        {
            newFile();
        }

        private void salvarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newFile();
        }

        private void btn_saveFile_Click(object sender, EventArgs e)
        {
            saveFile();
        }

        private void salvarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            saveFile();
        }

        private void btn_openFile_Click(object sender, EventArgs e)
        {
            openFile();
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFile();
        }

        private void btn_copy_Click(object sender, EventArgs e)
        {
            copy();
        }

        private void btn_cut_Click(object sender, EventArgs e)
        {
            cut();
        }

        private void btn_paste_Click(object sender, EventArgs e)
        {
            paste();
        }

        private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            copy();
        }

        private void colarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            paste();
        }

        private void recortarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cut();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            close();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            close();
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            printFile();
        }

        private void imprimirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printFile();
        }

        private void vizualizarImpressãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printPreview();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            printPreview();
        }

        private void btn_algLeft_Click(object sender, EventArgs e)
        {
            alignmentLeft();
        }

        private void btn_algCenter_Click(object sender, EventArgs e)
        {
            alignmentCenter();
        }

        private void btn_algRight_Click(object sender, EventArgs e)
        {
            alignmentRight();
        }

        private void alinharAEsquerdaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            alignmentLeft();
        }

        private void alinharDireitaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            alignmentRight();
        }

        private void centralizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            alignmentCenter();
        }
    }
}
