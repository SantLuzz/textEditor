namespace textEditor
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_newFile = new System.Windows.Forms.ToolStripButton();
            this.btn_saveFile = new System.Windows.Forms.ToolStripButton();
            this.btn_openFile = new System.Windows.Forms.ToolStripButton();
            this.btn_print = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_font = new System.Windows.Forms.ToolStripButton();
            this.btn_fontBold = new System.Windows.Forms.ToolStripButton();
            this.btn_fontItalic = new System.Windows.Forms.ToolStripButton();
            this.btn_fontUnderline = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_algLeft = new System.Windows.Forms.ToolStripButton();
            this.btn_algCenter = new System.Windows.Forms.ToolStripButton();
            this.btn_algRight = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_copy = new System.Windows.Forms.ToolStripButton();
            this.btn_cut = new System.Windows.Forms.ToolStripButton();
            this.btn_paste = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_close = new System.Windows.Forms.ToolStripButton();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.rtb_main = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.imprimirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copiarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recortarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refazerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.desfazerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formatarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fonteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.definirFonteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.negritoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itálicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sublinhadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alinhamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alinharAEsquerdaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alinharDireitaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.centralizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.btn_printPreview = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_newFile,
            this.btn_saveFile,
            this.btn_openFile,
            this.btn_printPreview,
            this.btn_print,
            this.toolStripSeparator1,
            this.btn_font,
            this.btn_fontBold,
            this.btn_fontItalic,
            this.btn_fontUnderline,
            this.toolStripSeparator2,
            this.btn_algLeft,
            this.btn_algCenter,
            this.btn_algRight,
            this.toolStripSeparator3,
            this.btn_copy,
            this.btn_cut,
            this.btn_paste,
            this.toolStripSeparator4,
            this.btn_close});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // btn_newFile
            // 
            this.btn_newFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_newFile.Image = global::textEditor.Properties.Resources.new2;
            this.btn_newFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_newFile.Name = "btn_newFile";
            this.btn_newFile.Size = new System.Drawing.Size(23, 22);
            this.btn_newFile.Text = "Novo";
            this.btn_newFile.Click += new System.EventHandler(this.btn_newFile_Click);
            // 
            // btn_saveFile
            // 
            this.btn_saveFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_saveFile.Image = global::textEditor.Properties.Resources.save;
            this.btn_saveFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_saveFile.Name = "btn_saveFile";
            this.btn_saveFile.Size = new System.Drawing.Size(23, 22);
            this.btn_saveFile.Text = "Salvar";
            this.btn_saveFile.Click += new System.EventHandler(this.btn_saveFile_Click);
            // 
            // btn_openFile
            // 
            this.btn_openFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_openFile.Image = global::textEditor.Properties.Resources.open;
            this.btn_openFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_openFile.Name = "btn_openFile";
            this.btn_openFile.Size = new System.Drawing.Size(23, 22);
            this.btn_openFile.Text = "Abrir";
            this.btn_openFile.Click += new System.EventHandler(this.btn_openFile_Click);
            // 
            // btn_print
            // 
            this.btn_print.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_print.Image = global::textEditor.Properties.Resources.printer;
            this.btn_print.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(23, 22);
            this.btn_print.Text = "Imprimir";
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.BackColor = System.Drawing.SystemColors.ControlText;
            this.toolStripSeparator1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btn_font
            // 
            this.btn_font.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_font.Image = global::textEditor.Properties.Resources.font;
            this.btn_font.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_font.Name = "btn_font";
            this.btn_font.Size = new System.Drawing.Size(23, 22);
            this.btn_font.Text = "Fonte";
            this.btn_font.Click += new System.EventHandler(this.btn_font_Click);
            // 
            // btn_fontBold
            // 
            this.btn_fontBold.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_fontBold.Image = global::textEditor.Properties.Resources.bold;
            this.btn_fontBold.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_fontBold.Name = "btn_fontBold";
            this.btn_fontBold.Size = new System.Drawing.Size(23, 22);
            this.btn_fontBold.Text = "Negrito";
            this.btn_fontBold.Click += new System.EventHandler(this.btn_fontBold_Click);
            // 
            // btn_fontItalic
            // 
            this.btn_fontItalic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_fontItalic.Image = global::textEditor.Properties.Resources.italic;
            this.btn_fontItalic.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_fontItalic.Name = "btn_fontItalic";
            this.btn_fontItalic.Size = new System.Drawing.Size(23, 22);
            this.btn_fontItalic.Text = "Itálico";
            this.btn_fontItalic.Click += new System.EventHandler(this.btn_fontItalic_Click);
            // 
            // btn_fontUnderline
            // 
            this.btn_fontUnderline.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_fontUnderline.Image = global::textEditor.Properties.Resources.underline;
            this.btn_fontUnderline.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_fontUnderline.Name = "btn_fontUnderline";
            this.btn_fontUnderline.Size = new System.Drawing.Size(23, 22);
            this.btn_fontUnderline.Text = "Sublinhado";
            this.btn_fontUnderline.Click += new System.EventHandler(this.btn_fontUnderline_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btn_algLeft
            // 
            this.btn_algLeft.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_algLeft.Image = global::textEditor.Properties.Resources.alignmentLeft;
            this.btn_algLeft.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_algLeft.Name = "btn_algLeft";
            this.btn_algLeft.Size = new System.Drawing.Size(23, 22);
            this.btn_algLeft.Text = "Alinhar à Esquerda";
            this.btn_algLeft.Click += new System.EventHandler(this.btn_algLeft_Click);
            // 
            // btn_algCenter
            // 
            this.btn_algCenter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_algCenter.Image = global::textEditor.Properties.Resources.alignmentCenter;
            this.btn_algCenter.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_algCenter.Name = "btn_algCenter";
            this.btn_algCenter.Size = new System.Drawing.Size(23, 22);
            this.btn_algCenter.Text = "Centralizar";
            this.btn_algCenter.Click += new System.EventHandler(this.btn_algCenter_Click);
            // 
            // btn_algRight
            // 
            this.btn_algRight.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_algRight.Image = global::textEditor.Properties.Resources.alignmentrRight;
            this.btn_algRight.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_algRight.Name = "btn_algRight";
            this.btn_algRight.Size = new System.Drawing.Size(23, 22);
            this.btn_algRight.Text = "Alinhar à Direita";
            this.btn_algRight.Click += new System.EventHandler(this.btn_algRight_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // btn_copy
            // 
            this.btn_copy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_copy.Image = global::textEditor.Properties.Resources.copy;
            this.btn_copy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_copy.Name = "btn_copy";
            this.btn_copy.Size = new System.Drawing.Size(23, 22);
            this.btn_copy.Text = "Copiar";
            this.btn_copy.Click += new System.EventHandler(this.btn_copy_Click);
            // 
            // btn_cut
            // 
            this.btn_cut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_cut.Image = global::textEditor.Properties.Resources.cut;
            this.btn_cut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_cut.Name = "btn_cut";
            this.btn_cut.Size = new System.Drawing.Size(23, 22);
            this.btn_cut.Text = "Recortar";
            this.btn_cut.Click += new System.EventHandler(this.btn_cut_Click);
            // 
            // btn_paste
            // 
            this.btn_paste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_paste.Image = global::textEditor.Properties.Resources.paste;
            this.btn_paste.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_paste.Name = "btn_paste";
            this.btn_paste.Size = new System.Drawing.Size(23, 22);
            this.btn_paste.Text = "Colar";
            this.btn_paste.Click += new System.EventHandler(this.btn_paste_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // btn_close
            // 
            this.btn_close.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_close.Image = global::textEditor.Properties.Resources.close;
            this.btn_close.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(23, 22);
            this.btn_close.Text = "Fechar";
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // rtb_main
            // 
            this.rtb_main.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtb_main.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtb_main.Location = new System.Drawing.Point(12, 52);
            this.rtb_main.Margin = new System.Windows.Forms.Padding(3, 3, 50, 3);
            this.rtb_main.Name = "rtb_main";
            this.rtb_main.Size = new System.Drawing.Size(776, 549);
            this.rtb_main.TabIndex = 1;
            this.rtb_main.Text = "";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.editarToolStripMenuItem,
            this.formatarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salvarToolStripMenuItem,
            this.abrirToolStripMenuItem,
            this.salvarToolStripMenuItem1,
            this.imprimirToolStripMenuItem,
            this.toolStripMenuItem1,
            this.sairToolStripMenuItem});
            this.arquivoToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // salvarToolStripMenuItem
            // 
            this.salvarToolStripMenuItem.Name = "salvarToolStripMenuItem";
            this.salvarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salvarToolStripMenuItem.Text = "Novo";
            this.salvarToolStripMenuItem.Click += new System.EventHandler(this.salvarToolStripMenuItem_Click);
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.abrirToolStripMenuItem.Text = "Abrir";
            this.abrirToolStripMenuItem.Click += new System.EventHandler(this.abrirToolStripMenuItem_Click);
            // 
            // salvarToolStripMenuItem1
            // 
            this.salvarToolStripMenuItem1.Name = "salvarToolStripMenuItem1";
            this.salvarToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.salvarToolStripMenuItem1.Text = "Salvar";
            this.salvarToolStripMenuItem1.Click += new System.EventHandler(this.salvarToolStripMenuItem1_Click);
            // 
            // imprimirToolStripMenuItem
            // 
            this.imprimirToolStripMenuItem.Name = "imprimirToolStripMenuItem";
            this.imprimirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.imprimirToolStripMenuItem.Text = "Imprimir";
            this.imprimirToolStripMenuItem.Click += new System.EventHandler(this.imprimirToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(177, 6);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copiarToolStripMenuItem,
            this.colarToolStripMenuItem,
            this.recortarToolStripMenuItem,
            this.refazerToolStripMenuItem,
            this.desfazerToolStripMenuItem});
            this.editarToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.editarToolStripMenuItem.Text = "Editar";
            // 
            // copiarToolStripMenuItem
            // 
            this.copiarToolStripMenuItem.Name = "copiarToolStripMenuItem";
            this.copiarToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.copiarToolStripMenuItem.Text = "Copiar";
            this.copiarToolStripMenuItem.Click += new System.EventHandler(this.copiarToolStripMenuItem_Click);
            // 
            // colarToolStripMenuItem
            // 
            this.colarToolStripMenuItem.Name = "colarToolStripMenuItem";
            this.colarToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.colarToolStripMenuItem.Text = "Colar";
            this.colarToolStripMenuItem.Click += new System.EventHandler(this.colarToolStripMenuItem_Click);
            // 
            // recortarToolStripMenuItem
            // 
            this.recortarToolStripMenuItem.Name = "recortarToolStripMenuItem";
            this.recortarToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.recortarToolStripMenuItem.Text = "Recortar";
            this.recortarToolStripMenuItem.Click += new System.EventHandler(this.recortarToolStripMenuItem_Click);
            // 
            // refazerToolStripMenuItem
            // 
            this.refazerToolStripMenuItem.Name = "refazerToolStripMenuItem";
            this.refazerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.refazerToolStripMenuItem.Text = "Refazer";
            this.refazerToolStripMenuItem.Click += new System.EventHandler(this.refazerToolStripMenuItem_Click);
            // 
            // desfazerToolStripMenuItem
            // 
            this.desfazerToolStripMenuItem.Name = "desfazerToolStripMenuItem";
            this.desfazerToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.desfazerToolStripMenuItem.Text = "Desfazer";
            // 
            // formatarToolStripMenuItem
            // 
            this.formatarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fonteToolStripMenuItem,
            this.alinhamentoToolStripMenuItem});
            this.formatarToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.formatarToolStripMenuItem.Name = "formatarToolStripMenuItem";
            this.formatarToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.formatarToolStripMenuItem.Text = "Formatar";
            // 
            // fonteToolStripMenuItem
            // 
            this.fonteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.definirFonteToolStripMenuItem,
            this.negritoToolStripMenuItem,
            this.itálicoToolStripMenuItem,
            this.sublinhadoToolStripMenuItem});
            this.fonteToolStripMenuItem.Name = "fonteToolStripMenuItem";
            this.fonteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.fonteToolStripMenuItem.Text = "Fonte";
            // 
            // definirFonteToolStripMenuItem
            // 
            this.definirFonteToolStripMenuItem.Name = "definirFonteToolStripMenuItem";
            this.definirFonteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.definirFonteToolStripMenuItem.Text = "Definir Fonte";
            this.definirFonteToolStripMenuItem.Click += new System.EventHandler(this.definirFonteToolStripMenuItem_Click);
            // 
            // negritoToolStripMenuItem
            // 
            this.negritoToolStripMenuItem.Name = "negritoToolStripMenuItem";
            this.negritoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.negritoToolStripMenuItem.Text = "Negrito";
            this.negritoToolStripMenuItem.Click += new System.EventHandler(this.negritoToolStripMenuItem_Click);
            // 
            // itálicoToolStripMenuItem
            // 
            this.itálicoToolStripMenuItem.Name = "itálicoToolStripMenuItem";
            this.itálicoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.itálicoToolStripMenuItem.Text = "Itálico";
            this.itálicoToolStripMenuItem.Click += new System.EventHandler(this.itálicoToolStripMenuItem_Click);
            // 
            // sublinhadoToolStripMenuItem
            // 
            this.sublinhadoToolStripMenuItem.Name = "sublinhadoToolStripMenuItem";
            this.sublinhadoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sublinhadoToolStripMenuItem.Text = "Sublinhado";
            this.sublinhadoToolStripMenuItem.Click += new System.EventHandler(this.sublinhadoToolStripMenuItem_Click);
            // 
            // alinhamentoToolStripMenuItem
            // 
            this.alinhamentoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alinharAEsquerdaToolStripMenuItem,
            this.alinharDireitaToolStripMenuItem,
            this.centralizarToolStripMenuItem});
            this.alinhamentoToolStripMenuItem.Name = "alinhamentoToolStripMenuItem";
            this.alinhamentoToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.alinhamentoToolStripMenuItem.Text = "Alinhamento";
            // 
            // alinharAEsquerdaToolStripMenuItem
            // 
            this.alinharAEsquerdaToolStripMenuItem.Name = "alinharAEsquerdaToolStripMenuItem";
            this.alinharAEsquerdaToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.alinharAEsquerdaToolStripMenuItem.Text = "Alinhar à Esquerda";
            this.alinharAEsquerdaToolStripMenuItem.Click += new System.EventHandler(this.alinharAEsquerdaToolStripMenuItem_Click);
            // 
            // alinharDireitaToolStripMenuItem
            // 
            this.alinharDireitaToolStripMenuItem.Name = "alinharDireitaToolStripMenuItem";
            this.alinharDireitaToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.alinharDireitaToolStripMenuItem.Text = "Alinhar à Direita";
            this.alinharDireitaToolStripMenuItem.Click += new System.EventHandler(this.alinharDireitaToolStripMenuItem_Click);
            // 
            // centralizarToolStripMenuItem
            // 
            this.centralizarToolStripMenuItem.Name = "centralizarToolStripMenuItem";
            this.centralizarToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.centralizarToolStripMenuItem.Text = "Centralizar";
            this.centralizarToolStripMenuItem.Click += new System.EventHandler(this.centralizarToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "lfs";
            this.saveFileDialog1.Filter = "(*.lfs) | *,lfs";
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // btn_printPreview
            // 
            this.btn_printPreview.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_printPreview.Image = global::textEditor.Properties.Resources.printPreview;
            this.btn_printPreview.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_printPreview.Name = "btn_printPreview";
            this.btn_printPreview.Size = new System.Drawing.Size(23, 22);
            this.btn_printPreview.Text = "Vizualizar Impressão";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 604);
            this.Controls.Add(this.rtb_main);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editor";
            this.TransparencyKey = System.Drawing.SystemColors.Control;
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.RichTextBox rtb_main;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formatarToolStripMenuItem;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem salvarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem imprimirToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copiarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recortarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refazerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem desfazerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fonteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem definirFonteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem negritoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itálicoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sublinhadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alinhamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton btn_newFile;
        private System.Windows.Forms.ToolStripButton btn_saveFile;
        private System.Windows.Forms.ToolStripButton btn_openFile;
        private System.Windows.Forms.ToolStripMenuItem alinharAEsquerdaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alinharDireitaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem centralizarToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton btn_print;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btn_font;
        private System.Windows.Forms.ToolStripButton btn_fontBold;
        private System.Windows.Forms.ToolStripButton btn_fontItalic;
        private System.Windows.Forms.ToolStripButton btn_fontUnderline;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btn_algLeft;
        private System.Windows.Forms.ToolStripButton btn_algCenter;
        private System.Windows.Forms.ToolStripButton btn_algRight;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btn_copy;
        private System.Windows.Forms.ToolStripButton btn_cut;
        private System.Windows.Forms.ToolStripButton btn_paste;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton btn_close;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.ToolStripButton btn_printPreview;
    }
}

