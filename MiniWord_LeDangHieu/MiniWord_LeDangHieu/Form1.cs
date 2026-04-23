using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace MiniWord_LeDangHieu
{
    public partial class Form1 : Form
    {
        private string duongDanHienTai = "";
        private bool daThayDoi = false;

        private readonly string thuMucIcon = @"C:\Users\LENOVO\Downloads\classic_toolbar_icons";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CaiDatBanDau();
            TaoBangEmoji();
            GanIconChoMenuVaToolBar();
            CapNhatTieuDe();
            CapNhatTrangThai();
            CapNhatTrangThaiDinhDang();
            CanGiuaTrangGiay();
        }

        private void CaiDatBanDau()
        {
            cboFont.Items.Clear();
            foreach (FontFamily font in FontFamily.Families)
            {
                cboFont.Items.Add(font.Name);
            }

            cboSize.Items.Clear();
            for (int i = 8; i <= 72; i += 2)
            {
                cboSize.Items.Add(i.ToString());
            }

            cboFont.Text = "Times New Roman";
            cboSize.Text = "12";

            rtbNoiDung.Font = new Font("Times New Roman", 12);
            rtbNoiDung.ForeColor = Color.Black;
            rtbNoiDung.BackColor = Color.White;
            rtbNoiDung.ZoomFactor = 1.0f;
            rtbNoiDung.BorderStyle = BorderStyle.None;

            pnlEmoji.Visible = false;

            this.BackColor = Color.FromArgb(240, 242, 245);
            menuStrip1.BackColor = Color.WhiteSmoke;
            toolStrip1.BackColor = Color.White;
            statusStrip1.BackColor = Color.WhiteSmoke;
            pnlWorkspace.BackColor = Color.FromArgb(230, 230, 230);
            pnlPage.BackColor = Color.White;

            lblTrangThaiFile.Text = "Tài liệu mới";
            lblZoom.Text = "Zoom: 100%";
        }

        private Image TaiIcon(string tenFile)
        {
            try
            {
                string duongDan = Path.Combine(thuMucIcon, tenFile);
                if (File.Exists(duongDan))
                {
                    using (Image imgGoc = Image.FromFile(duongDan))
                    {
                        return new Bitmap(imgGoc);
                    }
                }
            }
            catch
            {
            }

            return null;
        }

        private void GanIconChoMenuVaToolBar()
        {
            Dictionary<string, Image> dsIcon = new Dictionary<string, Image>();

            dsIcon["new"] = TaiIcon("new.png");
            dsIcon["open"] = TaiIcon("open.png");
            dsIcon["save"] = TaiIcon("save.png");
            dsIcon["undo"] = TaiIcon("undo.png");
            dsIcon["redo"] = TaiIcon("redo.png");
            dsIcon["cut"] = TaiIcon("cut.png");
            dsIcon["copy"] = TaiIcon("copy.png");
            dsIcon["paste"] = TaiIcon("paste.png");
            dsIcon["bold"] = TaiIcon("bold.png");
            dsIcon["italic"] = TaiIcon("italic.png");
            dsIcon["underline"] = TaiIcon("underline.png");
            dsIcon["text_color"] = TaiIcon("text_color.png");
            dsIcon["back_color"] = TaiIcon("back_color.png");
            dsIcon["image"] = TaiIcon("image.png");
            dsIcon["emoji"] = TaiIcon("emoji.png");
            dsIcon["zoom_in"] = TaiIcon("zoom_in.png");
            dsIcon["zoom_out"] = TaiIcon("zoom_out.png");

            mnuNew.Image = dsIcon["new"];
            mnuOpen.Image = dsIcon["open"];
            mnuSave.Image = dsIcon["save"];
            mnuSaveAs.Image = dsIcon["save"];
            mnuClose.Image = dsIcon["save"];
            mnuExit.Image = dsIcon["save"];

            mnuUndo.Image = dsIcon["undo"];
            mnuRedo.Image = dsIcon["redo"];
            mnuCut.Image = dsIcon["cut"];
            mnuCopy.Image = dsIcon["copy"];
            mnuPaste.Image = dsIcon["paste"];

            mnuInsertImage.Image = dsIcon["image"];
            mnuEmojiPanel.Image = dsIcon["emoji"];

            mnuBold.Image = dsIcon["bold"];
            mnuItalic.Image = dsIcon["italic"];
            mnuUnderline.Image = dsIcon["underline"];
            mnuFontColor.Image = dsIcon["text_color"];
            mnuBackColor.Image = dsIcon["back_color"];

            mnuZoomIn.Image = dsIcon["zoom_in"];
            mnuZoomOut.Image = dsIcon["zoom_out"];

            mnuFind.Image = dsIcon["open"];
            mnuReplace.Image = dsIcon["paste"];

            ctxUndo.Image = dsIcon["undo"];
            ctxRedo.Image = dsIcon["redo"];
            ctxCut.Image = dsIcon["cut"];
            ctxCopy.Image = dsIcon["copy"];
            ctxPaste.Image = dsIcon["paste"];

            btnNew.Image = dsIcon["new"];
            btnOpen.Image = dsIcon["open"];
            btnSave.Image = dsIcon["save"];
            btnUndo.Image = dsIcon["undo"];
            btnRedo.Image = dsIcon["redo"];
            btnCut.Image = dsIcon["cut"];
            btnCopy.Image = dsIcon["copy"];
            btnPaste.Image = dsIcon["paste"];
            btnFontColor.Image = dsIcon["text_color"];
            btnBackColor.Image = dsIcon["back_color"];
            btnInsertImage.Image = dsIcon["image"];
            btnEmoji.Image = dsIcon["emoji"];
            btnZoomIn.Image = dsIcon["zoom_in"];
            btnZoomOut.Image = dsIcon["zoom_out"];
            btnFind.Image = dsIcon["open"];
            btnReplace.Image = dsIcon["paste"];

            btnNew.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnOpen.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnSave.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnUndo.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnRedo.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnCut.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnCopy.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnPaste.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnFontColor.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnBackColor.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnInsertImage.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnEmoji.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnZoomIn.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnZoomOut.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnFind.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnReplace.DisplayStyle = ToolStripItemDisplayStyle.Image;
        }

        private void TaoBangEmoji()
        {
            flpEmoji.Controls.Clear();

            string[] dsEmoji =
            {
                "😀","😁","😂","🤣","😊","😍","😘","😎","😢","😭",
                "😡","👍","👎","👏","🙏","❤️","💖","🔥","⭐","🌟",
                "🎉","🎁","✅","❌","⚠️","📌","📎","💡","📚","📝"
            };

            foreach (string emoji in dsEmoji)
            {
                Button btn = new Button();
                btn.Width = 48;
                btn.Height = 48;
                btn.Text = emoji;
                btn.Font = new Font("Segoe UI Emoji", 16, FontStyle.Regular);
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderColor = Color.Gainsboro;
                btn.BackColor = Color.White;
                btn.Margin = new Padding(6);
                btn.Cursor = Cursors.Hand;
                btn.Click += EmojiButton_Click;
                flpEmoji.Controls.Add(btn);
            }
        }

        private void EmojiButton_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null)
            {
                rtbNoiDung.SelectedText = btn.Text;
                rtbNoiDung.Focus();
                DanhDauDaThayDoi();
            }
        }

        private void CapNhatTieuDe()
        {
            string tenFile = string.IsNullOrEmpty(duongDanHienTai) ? "Tài liệu mới" : Path.GetFileName(duongDanHienTai);
            string dauSao = daThayDoi ? " *" : "";
            this.Text = tenFile + dauSao + " - MiniWord";
        }

        private void CapNhatTrangThai()
        {
            int dong = rtbNoiDung.GetLineFromCharIndex(rtbNoiDung.SelectionStart) + 1;
            int cot = rtbNoiDung.SelectionStart - rtbNoiDung.GetFirstCharIndexOfCurrentLine() + 1;

            lblViTriConTro.Text = "Dòng: " + dong + " | Cột: " + cot;
            lblSoKyTu.Text = "Số ký tự: " + rtbNoiDung.TextLength;
            lblZoom.Text = "Zoom: " + (int)(rtbNoiDung.ZoomFactor * 100) + "%";
        }

        private void CapNhatTrangThaiDinhDang()
        {
            Font fontHienTai = rtbNoiDung.SelectionFont ?? rtbNoiDung.Font;

            btnBold.Checked = fontHienTai.Bold;
            btnItalic.Checked = fontHienTai.Italic;
            btnUnderline.Checked = fontHienTai.Underline;

            cboFont.Text = fontHienTai.FontFamily.Name;
            cboSize.Text = ((int)fontHienTai.Size).ToString();

            lblDinhDang.Text =
                "B: " + (fontHienTai.Bold ? "On" : "Off") +
                " | I: " + (fontHienTai.Italic ? "On" : "Off") +
                " | U: " + (fontHienTai.Underline ? "On" : "Off");
        }

        private void DanhDauDaThayDoi()
        {
            daThayDoi = true;
            CapNhatTieuDe();
            CapNhatTrangThai();
        }

        private bool KiemTraLuuTruocKhiTiepTuc()
        {
            if (!daThayDoi)
            {
                return true;
            }

            DialogResult ketQua = MessageBox.Show(
                "Nội dung đã thay đổi. Bạn có muốn lưu không?",
                "Xác nhận",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Question);

            if (ketQua == DialogResult.Yes)
            {
                return LuuFile();
            }

            if (ketQua == DialogResult.No)
            {
                return true;
            }

            return false;
        }

        private void TaoMoi()
        {
            if (!KiemTraLuuTruocKhiTiepTuc())
            {
                return;
            }

            rtbNoiDung.Clear();
            rtbNoiDung.Font = new Font("Times New Roman", 12);
            rtbNoiDung.ForeColor = Color.Black;
            rtbNoiDung.BackColor = Color.White;
            rtbNoiDung.ZoomFactor = 1.0f;

            duongDanHienTai = "";
            daThayDoi = false;

            lblTrangThaiFile.Text = "Tài liệu mới";
            CapNhatTieuDe();
            CapNhatTrangThai();
            CapNhatTrangThaiDinhDang();
        }

        private void MoFile()
        {
            if (!KiemTraLuuTruocKhiTiepTuc())
            {
                return;
            }

            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Rich Text Format (*.rtf)|*.rtf|Text File (*.txt)|*.txt|All files (*.*)|*.*";
                ofd.Title = "Mở tệp";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    string ext = Path.GetExtension(ofd.FileName).ToLower();

                    if (ext == ".rtf")
                    {
                        rtbNoiDung.LoadFile(ofd.FileName, RichTextBoxStreamType.RichText);
                    }
                    else
                    {
                        rtbNoiDung.LoadFile(ofd.FileName, RichTextBoxStreamType.PlainText);
                    }

                    duongDanHienTai = ofd.FileName;
                    daThayDoi = false;
                    lblTrangThaiFile.Text = "Đang mở: " + Path.GetFileName(duongDanHienTai);

                    CapNhatTieuDe();
                    CapNhatTrangThai();
                    CapNhatTrangThaiDinhDang();
                }
            }
        }

        private bool LuuFile()
        {
            if (string.IsNullOrEmpty(duongDanHienTai))
            {
                return LuuFileThanh();
            }

            string ext = Path.GetExtension(duongDanHienTai).ToLower();

            if (ext == ".rtf")
            {
                rtbNoiDung.SaveFile(duongDanHienTai, RichTextBoxStreamType.RichText);
            }
            else
            {
                rtbNoiDung.SaveFile(duongDanHienTai, RichTextBoxStreamType.PlainText);
            }

            daThayDoi = false;
            lblTrangThaiFile.Text = "Đã lưu: " + Path.GetFileName(duongDanHienTai);
            CapNhatTieuDe();
            CapNhatTrangThai();

            return true;
        }

        private bool LuuFileThanh()
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Rich Text Format (*.rtf)|*.rtf|Text File (*.txt)|*.txt";
                sfd.Title = "Lưu tệp";
                sfd.FileName = "TaiLieu1";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    duongDanHienTai = sfd.FileName;
                    return LuuFile();
                }
            }

            return false;
        }

        private void DongTaiLieu()
        {
            if (!KiemTraLuuTruocKhiTiepTuc())
            {
                return;
            }

            rtbNoiDung.Clear();
            duongDanHienTai = "";
            daThayDoi = false;

            lblTrangThaiFile.Text = "Đã đóng tài liệu";
            CapNhatTieuDe();
            CapNhatTrangThai();
            CapNhatTrangThaiDinhDang();
        }

        private void Thoat()
        {
            if (!KiemTraLuuTruocKhiTiepTuc())
            {
                return;
            }

            this.Close();
        }

        private void DinhDangKieuChu(FontStyle kieu)
        {
            Font fontHienTai = rtbNoiDung.SelectionFont ?? rtbNoiDung.Font;

            FontStyle styleMoi;
            if ((fontHienTai.Style & kieu) == kieu)
            {
                styleMoi = fontHienTai.Style & ~kieu;
            }
            else
            {
                styleMoi = fontHienTai.Style | kieu;
            }

            rtbNoiDung.SelectionFont = new Font(fontHienTai.FontFamily, fontHienTai.Size, styleMoi);

            DanhDauDaThayDoi();
            CapNhatTrangThaiDinhDang();
            rtbNoiDung.Focus();
        }

        private void DoiFont()
        {
            if (string.IsNullOrWhiteSpace(cboFont.Text))
            {
                return;
            }

            Font fontHienTai = rtbNoiDung.SelectionFont ?? rtbNoiDung.Font;
            rtbNoiDung.SelectionFont = new Font(cboFont.Text, fontHienTai.Size, fontHienTai.Style);

            DanhDauDaThayDoi();
            CapNhatTrangThaiDinhDang();
            rtbNoiDung.Focus();
        }

        private void DoiSize()
        {
            float sizeMoi;
            if (!float.TryParse(cboSize.Text, out sizeMoi))
            {
                return;
            }

            Font fontHienTai = rtbNoiDung.SelectionFont ?? rtbNoiDung.Font;
            rtbNoiDung.SelectionFont = new Font(fontHienTai.FontFamily, sizeMoi, fontHienTai.Style);

            DanhDauDaThayDoi();
            CapNhatTrangThaiDinhDang();
            rtbNoiDung.Focus();
        }

        private void DoiMauChu()
        {
            using (ColorDialog cd = new ColorDialog())
            {
                if (cd.ShowDialog() == DialogResult.OK)
                {
                    rtbNoiDung.SelectionColor = cd.Color;
                    DanhDauDaThayDoi();
                    rtbNoiDung.Focus();
                }
            }
        }

        private void DoiMauNen()
        {
            using (ColorDialog cd = new ColorDialog())
            {
                if (cd.ShowDialog() == DialogResult.OK)
                {
                    rtbNoiDung.SelectionBackColor = cd.Color;
                    DanhDauDaThayDoi();
                    rtbNoiDung.Focus();
                }
            }
        }

        private void ZoomIn()
        {
            if (rtbNoiDung.ZoomFactor < 5.0f)
            {
                rtbNoiDung.ZoomFactor += 0.1f;
                CapNhatTrangThai();
            }
        }

        private void ZoomOut()
        {
            if (rtbNoiDung.ZoomFactor > 0.5f)
            {
                rtbNoiDung.ZoomFactor -= 0.1f;
                CapNhatTrangThai();
            }
        }

        private void TimKiem()
        {
            string tuKhoa = PromptNhap("Nhập nội dung cần tìm:", "Tìm kiếm");
            if (string.IsNullOrEmpty(tuKhoa))
            {
                return;
            }

            int viTriBatDau = rtbNoiDung.SelectionStart + rtbNoiDung.SelectionLength;
            int viTri = rtbNoiDung.Find(tuKhoa, viTriBatDau, RichTextBoxFinds.None);

            if (viTri < 0)
            {
                viTri = rtbNoiDung.Find(tuKhoa, 0, RichTextBoxFinds.None);
            }

            if (viTri >= 0)
            {
                rtbNoiDung.Select(viTri, tuKhoa.Length);
                rtbNoiDung.ScrollToCaret();
                rtbNoiDung.Focus();
            }
            else
            {
                MessageBox.Show("Không tìm thấy nội dung cần tìm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ThayThe()
        {
            string tuCu = PromptNhap("Nhập nội dung cần thay:", "Thay thế - Bước 1");
            if (string.IsNullOrEmpty(tuCu))
            {
                return;
            }

            string tuMoi = PromptNhap("Nhập nội dung thay thế:", "Thay thế - Bước 2");

            int soLan = 0;
            int viTri = 0;

            while ((viTri = rtbNoiDung.Find(tuCu, viTri, RichTextBoxFinds.None)) != -1)
            {
                rtbNoiDung.Select(viTri, tuCu.Length);
                rtbNoiDung.SelectedText = tuMoi;
                viTri += tuMoi.Length;
                soLan++;
            }

            if (soLan > 0)
            {
                DanhDauDaThayDoi();
                MessageBox.Show("Đã thay " + soLan + " vị trí.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Không tìm thấy nội dung để thay.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ChenHinhAnh()
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "Chọn hình ảnh";
                ofd.Filter = "Image Files|*.bmp;*.jpg;*.jpeg;*.png;*.gif";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (Image img = Image.FromFile(ofd.FileName))
                        {
                            Clipboard.SetImage(new Bitmap(img));
                            rtbNoiDung.ReadOnly = false;
                            rtbNoiDung.Focus();
                            rtbNoiDung.Paste();
                        }

                        DanhDauDaThayDoi();
                    }
                    catch
                    {
                        MessageBox.Show("Không thể chèn hình ảnh này.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void BatTatBangEmoji()
        {
            pnlEmoji.Visible = !pnlEmoji.Visible;
            if (pnlEmoji.Visible)
            {
                pnlEmoji.BringToFront();
            }
        }

        private string PromptNhap(string noiDung, string tieuDe)
        {
            Form form = new Form();
            Label lbl = new Label();
            TextBox txt = new TextBox();
            Button btnOK = new Button();
            Button btnCancel = new Button();

            form.Text = tieuDe;
            form.StartPosition = FormStartPosition.CenterParent;
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.ClientSize = new Size(360, 140);
            form.BackColor = Color.White;

            lbl.Text = noiDung;
            lbl.AutoSize = true;
            lbl.Location = new Point(15, 15);

            txt.Location = new Point(15, 45);
            txt.Width = 320;

            btnOK.Text = "OK";
            btnOK.Location = new Point(170, 85);
            btnOK.DialogResult = DialogResult.OK;

            btnCancel.Text = "Hủy";
            btnCancel.Location = new Point(260, 85);
            btnCancel.DialogResult = DialogResult.Cancel;

            form.Controls.Add(lbl);
            form.Controls.Add(txt);
            form.Controls.Add(btnOK);
            form.Controls.Add(btnCancel);

            form.AcceptButton = btnOK;
            form.CancelButton = btnCancel;

            return form.ShowDialog() == DialogResult.OK ? txt.Text : "";
        }

        private void CanGiuaTrangGiay()
        {
            int chieuRongTrang = 900;
            pnlPage.Width = chieuRongTrang;

            int x = (pnlWorkspace.ClientSize.Width - pnlPage.Width) / 2;
            if (x < 20)
            {
                x = 20;
            }

            pnlPage.Left = x;
            pnlPage.Top = 20;
        }

        private void rtbNoiDung_TextChanged(object sender, EventArgs e)
        {
            daThayDoi = true;
            CapNhatTieuDe();
            CapNhatTrangThai();
        }

        private void rtbNoiDung_SelectionChanged(object sender, EventArgs e)
        {
            CapNhatTrangThai();
            CapNhatTrangThaiDinhDang();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!KiemTraLuuTruocKhiTiepTuc())
            {
                e.Cancel = true;
            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            CanGiuaTrangGiay();
        }

        private void mnuNew_Click(object sender, EventArgs e)
        {
            TaoMoi();
        }

        private void mnuOpen_Click(object sender, EventArgs e)
        {
            MoFile();
        }

        private void mnuSave_Click(object sender, EventArgs e)
        {
            LuuFile();
        }

        private void mnuSaveAs_Click(object sender, EventArgs e)
        {
            LuuFileThanh();
        }

        private void mnuClose_Click(object sender, EventArgs e)
        {
            DongTaiLieu();
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            Thoat();
        }

        private void mnuUndo_Click(object sender, EventArgs e)
        {
            if (rtbNoiDung.CanUndo)
            {
                rtbNoiDung.Undo();
            }
        }

        private void mnuRedo_Click(object sender, EventArgs e)
        {
            if (rtbNoiDung.CanRedo)
            {
                rtbNoiDung.Redo();
            }
        }

        private void mnuCut_Click(object sender, EventArgs e)
        {
            rtbNoiDung.Cut();
        }

        private void mnuCopy_Click(object sender, EventArgs e)
        {
            rtbNoiDung.Copy();
        }

        private void mnuPaste_Click(object sender, EventArgs e)
        {
            rtbNoiDung.Paste();
        }

        private void mnuInsertImage_Click(object sender, EventArgs e)
        {
            ChenHinhAnh();
        }

        private void mnuEmojiPanel_Click(object sender, EventArgs e)
        {
            BatTatBangEmoji();
        }

        private void mnuFontColor_Click(object sender, EventArgs e)
        {
            DoiMauChu();
        }

        private void mnuBackColor_Click(object sender, EventArgs e)
        {
            DoiMauNen();
        }

        private void mnuZoomIn_Click(object sender, EventArgs e)
        {
            ZoomIn();
        }

        private void mnuZoomOut_Click(object sender, EventArgs e)
        {
            ZoomOut();
        }

        private void mnuBold_Click(object sender, EventArgs e)
        {
            DinhDangKieuChu(FontStyle.Bold);
        }

        private void mnuItalic_Click(object sender, EventArgs e)
        {
            DinhDangKieuChu(FontStyle.Italic);
        }

        private void mnuUnderline_Click(object sender, EventArgs e)
        {
            DinhDangKieuChu(FontStyle.Underline);
        }

        private void mnuFind_Click(object sender, EventArgs e)
        {
            TimKiem();
        }

        private void mnuReplace_Click(object sender, EventArgs e)
        {
            ThayThe();
        }

        private void cboFont_SelectedIndexChanged(object sender, EventArgs e)
        {
            DoiFont();
        }

        private void cboSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            DoiSize();
        }

        private void btnBold_Click(object sender, EventArgs e)
        {
            DinhDangKieuChu(FontStyle.Bold);
        }

        private void btnItalic_Click(object sender, EventArgs e)
        {
            DinhDangKieuChu(FontStyle.Italic);
        }

        private void btnUnderline_Click(object sender, EventArgs e)
        {
            DinhDangKieuChu(FontStyle.Underline);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            TaoMoi();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            MoFile();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            LuuFile();
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            if (rtbNoiDung.CanUndo)
            {
                rtbNoiDung.Undo();
            }
        }

        private void btnRedo_Click(object sender, EventArgs e)
        {
            if (rtbNoiDung.CanRedo)
            {
                rtbNoiDung.Redo();
            }
        }

        private void btnCut_Click(object sender, EventArgs e)
        {
            rtbNoiDung.Cut();
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            rtbNoiDung.Copy();
        }

        private void btnPaste_Click(object sender, EventArgs e)
        {
            rtbNoiDung.Paste();
        }

        private void btnInsertImage_Click(object sender, EventArgs e)
        {
            ChenHinhAnh();
        }

        private void btnEmoji_Click(object sender, EventArgs e)
        {
            BatTatBangEmoji();
        }

        private void btnFontColor_Click(object sender, EventArgs e)
        {
            DoiMauChu();
        }

        private void btnBackColor_Click(object sender, EventArgs e)
        {
            DoiMauNen();
        }

        private void btnZoomIn_Click(object sender, EventArgs e)
        {
            ZoomIn();
        }

        private void btnZoomOut_Click(object sender, EventArgs e)
        {
            ZoomOut();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            TimKiem();
        }

        private void btnReplace_Click(object sender, EventArgs e)
        {
            ThayThe();
        }

        private void ctxUndo_Click(object sender, EventArgs e)
        {
            if (rtbNoiDung.CanUndo)
            {
                rtbNoiDung.Undo();
            }
        }

        private void ctxRedo_Click(object sender, EventArgs e)
        {
            if (rtbNoiDung.CanRedo)
            {
                rtbNoiDung.Redo();
            }
        }

        private void ctxCut_Click(object sender, EventArgs e)
        {
            rtbNoiDung.Cut();
        }

        private void ctxCopy_Click(object sender, EventArgs e)
        {
            rtbNoiDung.Copy();
        }

        private void ctxPaste_Click(object sender, EventArgs e)
        {
            rtbNoiDung.Paste();
        }
    }
}