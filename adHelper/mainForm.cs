using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace adHelper {
    struct CssSize {
        public string Width;
        public string Height;
    }
    struct GCtrl {
        public string MergeClassName;
    }
    public partial class mainForm : Form {
        //全局设置
        GCtrl gCtrl = new GCtrl();
        public mainForm() {
            InitializeComponent();
            //初始化设置
            cboxUnit.SelectedIndex = 0;
            //全局设置
            gCtrl.MergeClassName = "_mergeExample_";
        }

        private void txtGetImgCss_KeyDown(object sender, KeyEventArgs e) {
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.A) {
                ((TextBox)sender).SelectAll();
            }
        }

        private void txtGetImgCss_DragDrop(object sender, DragEventArgs e) {
            Array dragData = (System.Array)e.Data.GetData(DataFormats.FileDrop);
            System.Text.StringBuilder strCss = new System.Text.StringBuilder(),
                strHtml = new System.Text.StringBuilder();
            for (var i = 0; i < dragData.Length; i++) {
                strCss.AppendLine(getCss(dragData.GetValue(i).ToString()));
                strHtml.AppendLine(getHtml(dragData.GetValue(i).ToString()));
            }
            if (cbxIsMerge.Checked && dragData.Length > 1) {
                strCss.AppendLine(getMergeCss(dragData));
                strHtml.Insert(0, "<div class=\"" + gCtrl.MergeClassName + "\">\r\n");
                strHtml.Insert(0, "<!-- " + gCtrl.MergeClassName + " -->\r\n");
                strHtml.AppendLine("</div>");
            }
            txtGetImgCss.Text = strCss.ToString();
            txtGetImgHtml.Text = strHtml.ToString();
            txtGetImgCss.SelectAll();
        }

        private void txtGetImgCss_DragEnter(object sender, DragEventArgs e) {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) {
                e.Effect = DragDropEffects.Link;
            } else {
                e.Effect = DragDropEffects.None;
            }
        }

        private void cboxUnit_SelectedIndexChanged(object sender, EventArgs e) {
            switch (cboxUnit.Text) {
                case "rem":
                    txtRemMultiple.Enabled = true;
                    lab2.Enabled = true;
                    break;
                default:
                    txtRemMultiple.Enabled = false;
                    lab2.Enabled = false;
                    break;
            }
        }

        //生成cimg css
        private string getCss(string url) {
            Image imgPto = Image.FromFile(url);
            CssSize csPto = getPtoSizeInCss(imgPto.Size);
            System.Text.StringBuilder strCss = new System.Text.StringBuilder();
            string strTab = "    ";
            imgPto.Dispose();
            strCss.AppendLine("/* " + txtGlobalClass.Text + ">" + System.IO.Path.GetFileNameWithoutExtension(url) + " */");
            strCss.AppendLine("." + txtGlobalClass.Text + "." + System.IO.Path.GetFileNameWithoutExtension(url) + " {");
            strCss.AppendLine(strTab + "background-image: url(\"../images/" + System.IO.Path.GetFileName(url) + "\");");
            strCss.AppendLine(strTab + "width: " + csPto.Width + ";");
            strCss.AppendLine(strTab + "height: " + csPto.Height + ";");
            strCss.AppendLine("}");
            return strCss.ToString();
        }

        //生成组合css
        private string getMergeCss(Array urls) {
            System.Text.StringBuilder strCss = new System.Text.StringBuilder();
            int intMaxWidth = 0,
                intMaxHeight = 0;
            string strTab = "    ";
            string[] strNames = new string[urls.Length];
            Image _tmpImg;
            CssSize _tmpCSize = new CssSize();
            for (int i = 0; i < urls.Length; i++) {
                _tmpImg = Image.FromFile(urls.GetValue(i).ToString());
                if (_tmpImg.Width > intMaxWidth) {
                    intMaxWidth = _tmpImg.Width;
                }
                if (_tmpImg.Height > intMaxHeight) {
                    intMaxHeight = _tmpImg.Height;
                }
                _tmpImg.Dispose();
                strNames[i] = System.IO.Path.GetFileNameWithoutExtension(urls.GetValue(i).ToString());
            }
            _tmpCSize = getPtoSizeInCss(new Size(intMaxWidth, intMaxHeight));
            strCss.AppendLine("/* merge>" + gCtrl.MergeClassName + " */");
            strCss.AppendLine("." + gCtrl.MergeClassName + " {");
            strCss.AppendLine(strTab + "width: " + _tmpCSize.Width + ";");
            strCss.AppendLine(strTab + "height: " + _tmpCSize.Height + ";");
            strCss.AppendLine(strTab + "position: relative;");
            strCss.AppendLine("}");
            for (int i = 0; i < strNames.Length; i++) {
                strCss.Append("." + gCtrl.MergeClassName + " ." + strNames[i]);
                if (i < strNames.Length - 1) {
                    strCss.AppendLine(",");
                } else {
                    strCss.AppendLine("{");
                }
            }
            strCss.AppendLine(strTab + "position: absolute;");
            strCss.AppendLine("}");
            strCss.AppendLine();
            for (int i = 0; i < strNames.Length; i++) {
                strCss.AppendLine("." + gCtrl.MergeClassName + " ." + strNames[i] + "{");
                strCss.AppendLine(strTab + "left: 0;");
                strCss.AppendLine(strTab + "top: 0;");
                strCss.AppendLine("}");
                strCss.AppendLine();
            }
            return strCss.ToString();
        }

        //获取文件名字集合
        private string[] getNamesByUrls(string[] urls) {
            string[] strNames = new string[urls.Length];
            for (int i = 0; i < urls.Length; i++) {
                strNames[i] = System.IO.Path.GetFileNameWithoutExtension(urls[i]);
            }
            return strNames;
        }

        //获取尺寸
        private CssSize getPtoSizeInCss(Size sizeImg) {
            CssSize sizePto = new CssSize();
            switch (cboxUnit.Text) {
                case "rem":
                    sizePto.Width = ((double)sizeImg.Width / Convert.ToDouble(txtRemMultiple.Text)).ToString();
                    sizePto.Height = ((double)sizeImg.Height / Convert.ToDouble(txtRemMultiple.Text)).ToString();
                    break;
                case "px":
                    sizePto.Width = sizeImg.Width.ToString();
                    sizePto.Height = sizeImg.Height.ToString();
                    break;
                case "em":
                    sizePto.Width = sizeImg.Width.ToString();
                    sizePto.Height = sizeImg.Height.ToString();
                    break;
                case "%":
                    sizePto.Width = sizeImg.Width.ToString();
                    sizePto.Height = sizeImg.Height.ToString();
                    break;
                default:
                    sizePto.Width = sizeImg.Width.ToString();
                    sizePto.Height = sizeImg.Height.ToString();
                    break;
            }
            sizePto.Width += cboxUnit.Text;
            sizePto.Height += cboxUnit.Text;
            return sizePto;
        }

        //生成html
        private string getHtml(string url) {
            System.Text.StringBuilder strHtml = new System.Text.StringBuilder();
            strHtml.AppendLine("<!-- " + System.IO.Path.GetFileNameWithoutExtension(url) + " -->");
            strHtml.Append("<span class=\"cimg " + System.IO.Path.GetFileNameWithoutExtension(url) + "\"></span>");
            return strHtml.ToString();
        }
    }
}
