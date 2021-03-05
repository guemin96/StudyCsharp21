﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UsingControlsApp
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)//shift F7 누르면 form으로 이동
        {
            var FontsList = FontFamily.Families;
            foreach (var font in FontsList)
            {
                CboFont.Items.Add(font.Name);

            }
        }

        private void ChangeFont()
        {
            if (CboFont.SelectedIndex < 0) return;// 콤보박스에 아무것도 선택안했으면 (-1) 메서드 탈출

            FontStyle style = FontStyle.Regular;
            if (ChkBold.Checked) style |= FontStyle.Bold; //0000001
            if (ChkItalic.Checked) style |= FontStyle.Italic; //00000010
            //00000001|00000010 = 00000011 = Bold +Italic

            TxtResult.Font = new Font((string)CboFont.SelectedItem, 14, style);
        }

        private void CboFont_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeFont();
        }

        private void ChkItalic_CheckedChanged(object sender, EventArgs e)
        {
            ChangeFont();
        }

        private void ChkBold_CheckedChanged(object sender, EventArgs e)
        {
            ChangeFont();
        }

        private void TrbHandle_Scroll(object sender, EventArgs e)
        {
            PrbDisplay.Value = TrbHandle.Value;
        }
    }
}
