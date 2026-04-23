namespace MiniWord_LeDangHieu
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            menuStrip1 = new MenuStrip();
            mnuFile = new ToolStripMenuItem();
            mnuNew = new ToolStripMenuItem();
            mnuOpen = new ToolStripMenuItem();
            mnuSave = new ToolStripMenuItem();
            mnuSaveAs = new ToolStripMenuItem();
            mnuClose = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            mnuExit = new ToolStripMenuItem();
            mnuEdit = new ToolStripMenuItem();
            mnuUndo = new ToolStripMenuItem();
            mnuRedo = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripSeparator();
            mnuCut = new ToolStripMenuItem();
            mnuCopy = new ToolStripMenuItem();
            mnuPaste = new ToolStripMenuItem();
            mnuInsert = new ToolStripMenuItem();
            mnuInsertImage = new ToolStripMenuItem();
            mnuEmojiPanel = new ToolStripMenuItem();
            mnuFormat = new ToolStripMenuItem();
            mnuBold = new ToolStripMenuItem();
            mnuItalic = new ToolStripMenuItem();
            mnuUnderline = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripSeparator();
            mnuFontColor = new ToolStripMenuItem();
            mnuBackColor = new ToolStripMenuItem();
            mnuView = new ToolStripMenuItem();
            mnuZoomIn = new ToolStripMenuItem();
            mnuZoomOut = new ToolStripMenuItem();
            mnuSearch = new ToolStripMenuItem();
            mnuFind = new ToolStripMenuItem();
            mnuReplace = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            btnNew = new ToolStripButton();
            btnOpen = new ToolStripButton();
            btnSave = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            btnUndo = new ToolStripButton();
            btnRedo = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            btnCut = new ToolStripButton();
            btnCopy = new ToolStripButton();
            btnPaste = new ToolStripButton();
            toolStripSeparator3 = new ToolStripSeparator();
            cboFont = new ToolStripComboBox();
            cboSize = new ToolStripComboBox();
            btnBold = new ToolStripButton();
            btnItalic = new ToolStripButton();
            btnUnderline = new ToolStripButton();
            toolStripSeparator4 = new ToolStripSeparator();
            btnFontColor = new ToolStripButton();
            btnBackColor = new ToolStripButton();
            toolStripSeparator5 = new ToolStripSeparator();
            btnInsertImage = new ToolStripButton();
            btnEmoji = new ToolStripButton();
            toolStripSeparator6 = new ToolStripSeparator();
            btnZoomIn = new ToolStripButton();
            btnZoomOut = new ToolStripButton();
            toolStripSeparator7 = new ToolStripSeparator();
            btnFind = new ToolStripButton();
            btnReplace = new ToolStripButton();
            contextMenuStrip1 = new ContextMenuStrip(components);
            ctxUndo = new ToolStripMenuItem();
            ctxRedo = new ToolStripMenuItem();
            toolStripMenuItem4 = new ToolStripSeparator();
            ctxCut = new ToolStripMenuItem();
            ctxCopy = new ToolStripMenuItem();
            ctxPaste = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            lblTrangThaiFile = new ToolStripStatusLabel();
            lblViTriConTro = new ToolStripStatusLabel();
            lblSoKyTu = new ToolStripStatusLabel();
            lblZoom = new ToolStripStatusLabel();
            lblDinhDang = new ToolStripStatusLabel();
            pnlWorkspace = new Panel();
            pnlEmoji = new Panel();
            flpEmoji = new FlowLayoutPanel();
            lblEmojiTitle = new Label();
            pnlPage = new Panel();
            rtbNoiDung = new RichTextBox();
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            pnlWorkspace.SuspendLayout();
            pnlEmoji.SuspendLayout();
            pnlPage.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Segoe UI", 9.5F);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { mnuFile, mnuEdit, mnuInsert, mnuFormat, mnuView, mnuSearch });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(10, 3, 0, 3);
            menuStrip1.Size = new Size(1852, 35);
            menuStrip1.TabIndex = 0;
            // 
            // mnuFile
            // 
            mnuFile.DropDownItems.AddRange(new ToolStripItem[] { mnuNew, mnuOpen, mnuSave, mnuSaveAs, mnuClose, toolStripMenuItem1, mnuExit });
            mnuFile.Name = "mnuFile";
            mnuFile.Size = new Size(59, 29);
            mnuFile.Text = "&Tệp";
            // 
            // mnuNew
            // 
            mnuNew.Name = "mnuNew";
            mnuNew.ShortcutKeys = Keys.Control | Keys.N;
            mnuNew.Size = new Size(294, 34);
            mnuNew.Text = "New";
            mnuNew.Click += mnuNew_Click;
            // 
            // mnuOpen
            // 
            mnuOpen.Name = "mnuOpen";
            mnuOpen.ShortcutKeys = Keys.Control | Keys.O;
            mnuOpen.Size = new Size(294, 34);
            mnuOpen.Text = "Open";
            mnuOpen.Click += mnuOpen_Click;
            // 
            // mnuSave
            // 
            mnuSave.Name = "mnuSave";
            mnuSave.ShortcutKeys = Keys.Control | Keys.S;
            mnuSave.Size = new Size(294, 34);
            mnuSave.Text = "Save";
            mnuSave.Click += mnuSave_Click;
            // 
            // mnuSaveAs
            // 
            mnuSaveAs.Name = "mnuSaveAs";
            mnuSaveAs.ShortcutKeys = Keys.Control | Keys.Shift | Keys.S;
            mnuSaveAs.Size = new Size(294, 34);
            mnuSaveAs.Text = "Save As";
            mnuSaveAs.Click += mnuSaveAs_Click;
            // 
            // mnuClose
            // 
            mnuClose.Name = "mnuClose";
            mnuClose.ShortcutKeys = Keys.Control | Keys.W;
            mnuClose.Size = new Size(294, 34);
            mnuClose.Text = "Close";
            mnuClose.Click += mnuClose_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(291, 6);
            // 
            // mnuExit
            // 
            mnuExit.Name = "mnuExit";
            mnuExit.ShortcutKeys = Keys.Alt | Keys.F4;
            mnuExit.Size = new Size(294, 34);
            mnuExit.Text = "Exit";
            mnuExit.Click += mnuExit_Click;
            // 
            // mnuEdit
            // 
            mnuEdit.DropDownItems.AddRange(new ToolStripItem[] { mnuUndo, mnuRedo, toolStripMenuItem2, mnuCut, mnuCopy, mnuPaste });
            mnuEdit.Name = "mnuEdit";
            mnuEdit.Size = new Size(59, 29);
            mnuEdit.Text = "&Sửa";
            // 
            // mnuUndo
            // 
            mnuUndo.Name = "mnuUndo";
            mnuUndo.ShortcutKeys = Keys.Control | Keys.Z;
            mnuUndo.Size = new Size(226, 34);
            mnuUndo.Text = "Undo";
            mnuUndo.Click += mnuUndo_Click;
            // 
            // mnuRedo
            // 
            mnuRedo.Name = "mnuRedo";
            mnuRedo.ShortcutKeys = Keys.Control | Keys.Y;
            mnuRedo.Size = new Size(226, 34);
            mnuRedo.Text = "Redo";
            mnuRedo.Click += mnuRedo_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(223, 6);
            // 
            // mnuCut
            // 
            mnuCut.Name = "mnuCut";
            mnuCut.ShortcutKeys = Keys.Control | Keys.X;
            mnuCut.Size = new Size(226, 34);
            mnuCut.Text = "Cut";
            mnuCut.Click += mnuCut_Click;
            // 
            // mnuCopy
            // 
            mnuCopy.Name = "mnuCopy";
            mnuCopy.ShortcutKeys = Keys.Control | Keys.C;
            mnuCopy.Size = new Size(226, 34);
            mnuCopy.Text = "Copy";
            mnuCopy.Click += mnuCopy_Click;
            // 
            // mnuPaste
            // 
            mnuPaste.Name = "mnuPaste";
            mnuPaste.ShortcutKeys = Keys.Control | Keys.V;
            mnuPaste.Size = new Size(226, 34);
            mnuPaste.Text = "Paste";
            mnuPaste.Click += mnuPaste_Click;
            // 
            // mnuInsert
            // 
            mnuInsert.DropDownItems.AddRange(new ToolStripItem[] { mnuInsertImage, mnuEmojiPanel });
            mnuInsert.Name = "mnuInsert";
            mnuInsert.Size = new Size(72, 29);
            mnuInsert.Text = "&Chèn";
            // 
            // mnuInsertImage
            // 
            mnuInsertImage.Name = "mnuInsertImage";
            mnuInsertImage.ShortcutKeys = Keys.Control | Keys.I;
            mnuInsertImage.Size = new Size(298, 34);
            mnuInsertImage.Text = "Chèn hình ảnh";
            mnuInsertImage.Click += mnuInsertImage_Click;
            // 
            // mnuEmojiPanel
            // 
            mnuEmojiPanel.Name = "mnuEmojiPanel";
            mnuEmojiPanel.ShortcutKeys = Keys.Control | Keys.E;
            mnuEmojiPanel.Size = new Size(298, 34);
            mnuEmojiPanel.Text = "Bảng emoji";
            mnuEmojiPanel.Click += mnuEmojiPanel_Click;
            // 
            // mnuFormat
            // 
            mnuFormat.DropDownItems.AddRange(new ToolStripItem[] { mnuBold, mnuItalic, mnuUnderline, toolStripMenuItem3, mnuFontColor, mnuBackColor });
            mnuFormat.Name = "mnuFormat";
            mnuFormat.Size = new Size(116, 29);
            mnuFormat.Text = "Định &dạng";
            // 
            // mnuBold
            // 
            mnuBold.Name = "mnuBold";
            mnuBold.ShortcutKeys = Keys.Control | Keys.B;
            mnuBold.Size = new Size(265, 34);
            mnuBold.Text = "Bold";
            mnuBold.Click += mnuBold_Click;
            // 
            // mnuItalic
            // 
            mnuItalic.Name = "mnuItalic";
            mnuItalic.ShortcutKeys = Keys.Control | Keys.T;
            mnuItalic.Size = new Size(265, 34);
            mnuItalic.Text = "Italic";
            mnuItalic.Click += mnuItalic_Click;
            // 
            // mnuUnderline
            // 
            mnuUnderline.Name = "mnuUnderline";
            mnuUnderline.ShortcutKeys = Keys.Control | Keys.U;
            mnuUnderline.Size = new Size(265, 34);
            mnuUnderline.Text = "Underline";
            mnuUnderline.Click += mnuUnderline_Click;
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(262, 6);
            // 
            // mnuFontColor
            // 
            mnuFontColor.Name = "mnuFontColor";
            mnuFontColor.Size = new Size(265, 34);
            mnuFontColor.Text = "Màu chữ";
            mnuFontColor.Click += mnuFontColor_Click;
            // 
            // mnuBackColor
            // 
            mnuBackColor.Name = "mnuBackColor";
            mnuBackColor.Size = new Size(265, 34);
            mnuBackColor.Text = "Màu nền";
            mnuBackColor.Click += mnuBackColor_Click;
            // 
            // mnuView
            // 
            mnuView.DropDownItems.AddRange(new ToolStripItem[] { mnuZoomIn, mnuZoomOut });
            mnuView.Name = "mnuView";
            mnuView.Size = new Size(65, 29);
            mnuView.Text = "&Xem";
            // 
            // mnuZoomIn
            // 
            mnuZoomIn.Name = "mnuZoomIn";
            mnuZoomIn.ShortcutKeys = Keys.Control | Keys.Oemplus;
            mnuZoomIn.Size = new Size(346, 34);
            mnuZoomIn.Text = "Zoom In";
            mnuZoomIn.Click += mnuZoomIn_Click;
            // 
            // mnuZoomOut
            // 
            mnuZoomOut.Name = "mnuZoomOut";
            mnuZoomOut.ShortcutKeys = Keys.Control | Keys.OemMinus;
            mnuZoomOut.Size = new Size(346, 34);
            mnuZoomOut.Text = "Zoom Out";
            mnuZoomOut.Click += mnuZoomOut_Click;
            // 
            // mnuSearch
            // 
            mnuSearch.DropDownItems.AddRange(new ToolStripItem[] { mnuFind, mnuReplace });
            mnuSearch.Name = "mnuSearch";
            mnuSearch.Size = new Size(104, 29);
            mnuSearch.Text = "&Tìm kiếm";
            // 
            // mnuFind
            // 
            mnuFind.Name = "mnuFind";
            mnuFind.ShortcutKeys = Keys.Control | Keys.F;
            mnuFind.Size = new Size(247, 34);
            mnuFind.Text = "Find";
            mnuFind.Click += mnuFind_Click;
            // 
            // mnuReplace
            // 
            mnuReplace.Name = "mnuReplace";
            mnuReplace.ShortcutKeys = Keys.Control | Keys.H;
            mnuReplace.Size = new Size(247, 34);
            mnuReplace.Text = "Replace";
            mnuReplace.Click += mnuReplace_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.Font = new Font("Segoe UI", 9F);
            toolStrip1.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnNew, btnOpen, btnSave, toolStripSeparator1, btnUndo, btnRedo, toolStripSeparator2, btnCut, btnCopy, btnPaste, toolStripSeparator3, cboFont, cboSize, btnBold, btnItalic, btnUnderline, toolStripSeparator4, btnFontColor, btnBackColor, toolStripSeparator5, btnInsertImage, btnEmoji, toolStripSeparator6, btnZoomIn, btnZoomOut, toolStripSeparator7, btnFind, btnReplace });
            toolStrip1.Location = new Point(0, 35);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Padding = new Padding(10, 9, 10, 9);
            toolStrip1.Size = new Size(1852, 55);
            toolStrip1.TabIndex = 1;
            // 
            // btnNew
            // 
            btnNew.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnNew.Image = Properties.Resources.new1;
            btnNew.ImageTransparentColor = Color.Magenta;
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(34, 32);
            btnNew.Text = "New";
            btnNew.Click += btnNew_Click;
            // 
            // btnOpen
            // 
            btnOpen.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnOpen.Image = Properties.Resources.open;
            btnOpen.ImageTransparentColor = Color.Magenta;
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(34, 32);
            btnOpen.Text = "Open";
            btnOpen.Click += btnOpen_Click;
            // 
            // btnSave
            // 
            btnSave.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnSave.Image = Properties.Resources.save;
            btnSave.ImageTransparentColor = Color.Magenta;
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(34, 32);
            btnSave.Text = "Save";
            btnSave.Click += btnSave_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 37);
            // 
            // btnUndo
            // 
            btnUndo.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnUndo.Image = Properties.Resources.undo;
            btnUndo.ImageTransparentColor = Color.Magenta;
            btnUndo.Name = "btnUndo";
            btnUndo.Size = new Size(34, 32);
            btnUndo.Text = "Undo";
            btnUndo.Click += btnUndo_Click;
            // 
            // btnRedo
            // 
            btnRedo.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnRedo.Image = Properties.Resources.redo;
            btnRedo.ImageTransparentColor = Color.Magenta;
            btnRedo.Name = "btnRedo";
            btnRedo.Size = new Size(34, 32);
            btnRedo.Text = "Redo";
            btnRedo.Click += btnRedo_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 37);
            // 
            // btnCut
            // 
            btnCut.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnCut.Image = Properties.Resources.cut;
            btnCut.ImageTransparentColor = Color.Magenta;
            btnCut.Name = "btnCut";
            btnCut.Size = new Size(34, 32);
            btnCut.Text = "Cut";
            btnCut.Click += btnCut_Click;
            // 
            // btnCopy
            // 
            btnCopy.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnCopy.Image = Properties.Resources.copy;
            btnCopy.ImageTransparentColor = Color.Magenta;
            btnCopy.Name = "btnCopy";
            btnCopy.Size = new Size(34, 32);
            btnCopy.Text = "Copy";
            btnCopy.Click += btnCopy_Click;
            // 
            // btnPaste
            // 
            btnPaste.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnPaste.Image = Properties.Resources.paste;
            btnPaste.ImageTransparentColor = Color.Magenta;
            btnPaste.Name = "btnPaste";
            btnPaste.Size = new Size(34, 32);
            btnPaste.Text = "Paste";
            btnPaste.Click += btnPaste_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 37);
            // 
            // cboFont
            // 
            cboFont.AutoSize = false;
            cboFont.DropDownStyle = ComboBoxStyle.DropDownList;
            cboFont.Font = new Font("Segoe UI", 9.5F);
            cboFont.Name = "cboFont";
            cboFont.Size = new Size(224, 33);
            cboFont.SelectedIndexChanged += cboFont_SelectedIndexChanged;
            // 
            // cboSize
            // 
            cboSize.AutoSize = false;
            cboSize.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSize.Font = new Font("Segoe UI", 9.5F);
            cboSize.Name = "cboSize";
            cboSize.Size = new Size(86, 33);
            cboSize.SelectedIndexChanged += cboSize_SelectedIndexChanged;
            // 
            // btnBold
            // 
            btnBold.CheckOnClick = true;
            btnBold.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnBold.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnBold.Image = Properties.Resources.bold;
            btnBold.ImageTransparentColor = Color.Magenta;
            btnBold.Name = "btnBold";
            btnBold.Size = new Size(34, 32);
            btnBold.Text = "B";
            btnBold.Click += btnBold_Click;
            // 
            // btnItalic
            // 
            btnItalic.CheckOnClick = true;
            btnItalic.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnItalic.Font = new Font("Segoe UI", 10F, FontStyle.Italic);
            btnItalic.Image = Properties.Resources.italic;
            btnItalic.ImageTransparentColor = Color.Magenta;
            btnItalic.Name = "btnItalic";
            btnItalic.Size = new Size(34, 32);
            btnItalic.Text = "I";
            btnItalic.Click += btnItalic_Click;
            // 
            // btnUnderline
            // 
            btnUnderline.CheckOnClick = true;
            btnUnderline.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnUnderline.Font = new Font("Segoe UI", 10F, FontStyle.Underline);
            btnUnderline.Image = Properties.Resources.underline;
            btnUnderline.ImageTransparentColor = Color.Magenta;
            btnUnderline.Name = "btnUnderline";
            btnUnderline.Size = new Size(34, 32);
            btnUnderline.Text = "U";
            btnUnderline.Click += btnUnderline_Click;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(6, 37);
            // 
            // btnFontColor
            // 
            btnFontColor.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnFontColor.Image = Properties.Resources.text_color;
            btnFontColor.ImageTransparentColor = Color.Magenta;
            btnFontColor.Name = "btnFontColor";
            btnFontColor.Size = new Size(34, 32);
            btnFontColor.Text = "Màu chữ";
            btnFontColor.Click += btnFontColor_Click;
            // 
            // btnBackColor
            // 
            btnBackColor.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnBackColor.Image = Properties.Resources.back_color;
            btnBackColor.ImageTransparentColor = Color.Magenta;
            btnBackColor.Name = "btnBackColor";
            btnBackColor.Size = new Size(34, 32);
            btnBackColor.Text = "Màu nền";
            btnBackColor.Click += btnBackColor_Click;
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new Size(6, 37);
            // 
            // btnInsertImage
            // 
            btnInsertImage.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnInsertImage.Image = Properties.Resources.image;
            btnInsertImage.ImageTransparentColor = Color.Magenta;
            btnInsertImage.Name = "btnInsertImage";
            btnInsertImage.Size = new Size(34, 32);
            btnInsertImage.Text = "Chèn hình";
            btnInsertImage.Click += btnInsertImage_Click;
            // 
            // btnEmoji
            // 
            btnEmoji.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnEmoji.Image = Properties.Resources.emoji;
            btnEmoji.ImageTransparentColor = Color.Magenta;
            btnEmoji.Name = "btnEmoji";
            btnEmoji.Size = new Size(34, 32);
            btnEmoji.Text = "Emoji";
            btnEmoji.Click += btnEmoji_Click;
            // 
            // toolStripSeparator6
            // 
            toolStripSeparator6.Name = "toolStripSeparator6";
            toolStripSeparator6.Size = new Size(6, 37);
            // 
            // btnZoomIn
            // 
            btnZoomIn.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnZoomIn.Image = Properties.Resources.zoom_in;
            btnZoomIn.ImageTransparentColor = Color.Magenta;
            btnZoomIn.Name = "btnZoomIn";
            btnZoomIn.Size = new Size(34, 32);
            btnZoomIn.Text = "Zoom In";
            btnZoomIn.Click += btnZoomIn_Click;
            // 
            // btnZoomOut
            // 
            btnZoomOut.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnZoomOut.Image = Properties.Resources.zoom_out;
            btnZoomOut.ImageTransparentColor = Color.Magenta;
            btnZoomOut.Name = "btnZoomOut";
            btnZoomOut.Size = new Size(34, 32);
            btnZoomOut.Text = "Zoom Out";
            btnZoomOut.Click += btnZoomOut_Click;
            // 
            // toolStripSeparator7
            // 
            toolStripSeparator7.Name = "toolStripSeparator7";
            toolStripSeparator7.Size = new Size(6, 37);
            // 
            // btnFind
            // 
            btnFind.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnFind.Image = Properties.Resources.open1;
            btnFind.ImageTransparentColor = Color.Magenta;
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(34, 32);
            btnFind.Text = "Find";
            btnFind.Click += btnFind_Click;
            // 
            // btnReplace
            // 
            btnReplace.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnReplace.ImageTransparentColor = Color.Magenta;
            btnReplace.Name = "btnReplace";
            btnReplace.Size = new Size(34, 32);
            btnReplace.Text = "Replace";
            btnReplace.Click += btnReplace_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { ctxUndo, ctxRedo, toolStripMenuItem4, ctxCut, ctxCopy, ctxPaste });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(129, 170);
            // 
            // ctxUndo
            // 
            ctxUndo.Name = "ctxUndo";
            ctxUndo.Size = new Size(128, 32);
            ctxUndo.Text = "Undo";
            ctxUndo.Click += ctxUndo_Click;
            // 
            // ctxRedo
            // 
            ctxRedo.Name = "ctxRedo";
            ctxRedo.Size = new Size(128, 32);
            ctxRedo.Text = "Redo";
            ctxRedo.Click += ctxRedo_Click;
            // 
            // toolStripMenuItem4
            // 
            toolStripMenuItem4.Name = "toolStripMenuItem4";
            toolStripMenuItem4.Size = new Size(125, 6);
            // 
            // ctxCut
            // 
            ctxCut.Name = "ctxCut";
            ctxCut.Size = new Size(128, 32);
            ctxCut.Text = "Cut";
            ctxCut.Click += ctxCut_Click;
            // 
            // ctxCopy
            // 
            ctxCopy.Name = "ctxCopy";
            ctxCopy.Size = new Size(128, 32);
            ctxCopy.Text = "Copy";
            ctxCopy.Click += ctxCopy_Click;
            // 
            // ctxPaste
            // 
            ctxPaste.Name = "ctxPaste";
            ctxPaste.Size = new Size(128, 32);
            ctxPaste.Text = "Paste";
            ctxPaste.Click += ctxPaste_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.Font = new Font("Segoe UI", 9F);
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblTrangThaiFile, lblViTriConTro, lblSoKyTu, lblZoom, lblDinhDang });
            statusStrip1.Location = new Point(0, 1331);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new Padding(1, 0, 24, 0);
            statusStrip1.Size = new Size(1852, 36);
            statusStrip1.TabIndex = 3;
            // 
            // lblTrangThaiFile
            // 
            lblTrangThaiFile.BorderSides = ToolStripStatusLabelBorderSides.Right;
            lblTrangThaiFile.Name = "lblTrangThaiFile";
            lblTrangThaiFile.Size = new Size(104, 29);
            lblTrangThaiFile.Text = "Tài liệu mới";
            // 
            // lblViTriConTro
            // 
            lblViTriConTro.BorderSides = ToolStripStatusLabelBorderSides.Right;
            lblViTriConTro.Name = "lblViTriConTro";
            lblViTriConTro.Size = new Size(141, 29);
            lblViTriConTro.Text = "Dòng: 1 | Cột: 1";
            // 
            // lblSoKyTu
            // 
            lblSoKyTu.BorderSides = ToolStripStatusLabelBorderSides.Right;
            lblSoKyTu.Name = "lblSoKyTu";
            lblSoKyTu.Size = new Size(101, 29);
            lblSoKyTu.Text = "Số ký tự: 0";
            // 
            // lblZoom
            // 
            lblZoom.BorderSides = ToolStripStatusLabelBorderSides.Right;
            lblZoom.Name = "lblZoom";
            lblZoom.Size = new Size(118, 29);
            lblZoom.Text = "Zoom: 100%";
            // 
            // lblDinhDang
            // 
            lblDinhDang.Name = "lblDinhDang";
            lblDinhDang.Size = new Size(172, 29);
            lblDinhDang.Text = "B: Off | I: Off | U: Off";
            // 
            // pnlWorkspace
            // 
            pnlWorkspace.AutoScroll = true;
            pnlWorkspace.Controls.Add(pnlEmoji);
            pnlWorkspace.Controls.Add(pnlPage);
            pnlWorkspace.Dock = DockStyle.Fill;
            pnlWorkspace.Location = new Point(0, 90);
            pnlWorkspace.Margin = new Padding(4, 5, 4, 5);
            pnlWorkspace.Name = "pnlWorkspace";
            pnlWorkspace.Size = new Size(1852, 1241);
            pnlWorkspace.TabIndex = 2;
            // 
            // pnlEmoji
            // 
            pnlEmoji.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pnlEmoji.BackColor = Color.White;
            pnlEmoji.BorderStyle = BorderStyle.FixedSingle;
            pnlEmoji.Controls.Add(flpEmoji);
            pnlEmoji.Controls.Add(lblEmojiTitle);
            pnlEmoji.Location = new Point(1372, 31);
            pnlEmoji.Margin = new Padding(4, 5, 4, 5);
            pnlEmoji.Name = "pnlEmoji";
            pnlEmoji.Size = new Size(362, 640);
            pnlEmoji.TabIndex = 1;
            // 
            // flpEmoji
            // 
            flpEmoji.AutoScroll = true;
            flpEmoji.Dock = DockStyle.Fill;
            flpEmoji.Location = new Point(0, 84);
            flpEmoji.Margin = new Padding(4, 5, 4, 5);
            flpEmoji.Name = "flpEmoji";
            flpEmoji.Padding = new Padding(10, 12, 10, 12);
            flpEmoji.Size = new Size(360, 554);
            flpEmoji.TabIndex = 1;
            // 
            // lblEmojiTitle
            // 
            lblEmojiTitle.Dock = DockStyle.Top;
            lblEmojiTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblEmojiTitle.Location = new Point(0, 0);
            lblEmojiTitle.Margin = new Padding(4, 0, 4, 0);
            lblEmojiTitle.Name = "lblEmojiTitle";
            lblEmojiTitle.Padding = new Padding(12, 16, 0, 0);
            lblEmojiTitle.Size = new Size(360, 84);
            lblEmojiTitle.TabIndex = 0;
            lblEmojiTitle.Text = "Bảng Emoji";
            // 
            // pnlPage
            // 
            pnlPage.BackColor = Color.White;
            pnlPage.BorderStyle = BorderStyle.FixedSingle;
            pnlPage.Controls.Add(rtbNoiDung);
            pnlPage.Location = new Point(350, 31);
            pnlPage.Margin = new Padding(4, 5, 4, 5);
            pnlPage.Name = "pnlPage";
            pnlPage.Size = new Size(1124, 1874);
            pnlPage.TabIndex = 0;
            // 
            // rtbNoiDung
            // 
            rtbNoiDung.ContextMenuStrip = contextMenuStrip1;
            rtbNoiDung.Dock = DockStyle.Fill;
            rtbNoiDung.Font = new Font("Times New Roman", 12F);
            rtbNoiDung.Location = new Point(0, 0);
            rtbNoiDung.Margin = new Padding(4, 5, 4, 5);
            rtbNoiDung.Name = "rtbNoiDung";
            rtbNoiDung.Size = new Size(1122, 1872);
            rtbNoiDung.TabIndex = 0;
            rtbNoiDung.Text = "";
            rtbNoiDung.SelectionChanged += rtbNoiDung_SelectionChanged;
            rtbNoiDung.TextChanged += rtbNoiDung_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1852, 1367);
            Controls.Add(pnlWorkspace);
            Controls.Add(statusStrip1);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4, 5, 4, 5);
            MinimumSize = new Size(1494, 1218);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MiniWord";
            WindowState = FormWindowState.Maximized;
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            Resize += Form1_Resize;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            contextMenuStrip1.ResumeLayout(false);
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            pnlWorkspace.ResumeLayout(false);
            pnlEmoji.ResumeLayout(false);
            pnlPage.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuNew;
        private System.Windows.Forms.ToolStripMenuItem mnuOpen;
        private System.Windows.Forms.ToolStripMenuItem mnuSave;
        private System.Windows.Forms.ToolStripMenuItem mnuSaveAs;
        private System.Windows.Forms.ToolStripMenuItem mnuClose;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem mnuEdit;
        private System.Windows.Forms.ToolStripMenuItem mnuUndo;
        private System.Windows.Forms.ToolStripMenuItem mnuRedo;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem mnuCut;
        private System.Windows.Forms.ToolStripMenuItem mnuCopy;
        private System.Windows.Forms.ToolStripMenuItem mnuPaste;
        private System.Windows.Forms.ToolStripMenuItem mnuInsert;
        private System.Windows.Forms.ToolStripMenuItem mnuInsertImage;
        private System.Windows.Forms.ToolStripMenuItem mnuEmojiPanel;
        private System.Windows.Forms.ToolStripMenuItem mnuFormat;
        private System.Windows.Forms.ToolStripMenuItem mnuBold;
        private System.Windows.Forms.ToolStripMenuItem mnuItalic;
        private System.Windows.Forms.ToolStripMenuItem mnuUnderline;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem mnuFontColor;
        private System.Windows.Forms.ToolStripMenuItem mnuBackColor;
        private System.Windows.Forms.ToolStripMenuItem mnuView;
        private System.Windows.Forms.ToolStripMenuItem mnuZoomIn;
        private System.Windows.Forms.ToolStripMenuItem mnuZoomOut;
        private System.Windows.Forms.ToolStripMenuItem mnuSearch;
        private System.Windows.Forms.ToolStripMenuItem mnuFind;
        private System.Windows.Forms.ToolStripMenuItem mnuReplace;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnNew;
        private System.Windows.Forms.ToolStripButton btnOpen;
        private System.Windows.Forms.ToolStripButton btnSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnUndo;
        private System.Windows.Forms.ToolStripButton btnRedo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnCut;
        private System.Windows.Forms.ToolStripButton btnCopy;
        private System.Windows.Forms.ToolStripButton btnPaste;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripComboBox cboFont;
        private System.Windows.Forms.ToolStripComboBox cboSize;
        private System.Windows.Forms.ToolStripButton btnBold;
        private System.Windows.Forms.ToolStripButton btnItalic;
        private System.Windows.Forms.ToolStripButton btnUnderline;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton btnFontColor;
        private System.Windows.Forms.ToolStripButton btnBackColor;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton btnInsertImage;
        private System.Windows.Forms.ToolStripButton btnEmoji;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton btnZoomIn;
        private System.Windows.Forms.ToolStripButton btnZoomOut;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripButton btnFind;
        private System.Windows.Forms.ToolStripButton btnReplace;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ctxUndo;
        private System.Windows.Forms.ToolStripMenuItem ctxRedo;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem ctxCut;
        private System.Windows.Forms.ToolStripMenuItem ctxCopy;
        private System.Windows.Forms.ToolStripMenuItem ctxPaste;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblTrangThaiFile;
        private System.Windows.Forms.ToolStripStatusLabel lblViTriConTro;
        private System.Windows.Forms.ToolStripStatusLabel lblSoKyTu;
        private System.Windows.Forms.ToolStripStatusLabel lblZoom;
        private System.Windows.Forms.ToolStripStatusLabel lblDinhDang;
        private System.Windows.Forms.Panel pnlWorkspace;
        private System.Windows.Forms.Panel pnlPage;
        private System.Windows.Forms.RichTextBox rtbNoiDung;
        private System.Windows.Forms.Panel pnlEmoji;
        private System.Windows.Forms.Label lblEmojiTitle;
        private System.Windows.Forms.FlowLayoutPanel flpEmoji;
    }
}