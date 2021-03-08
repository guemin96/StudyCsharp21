using System;
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
        Random random = new Random(37);

        public FrmMain()
        {
            InitializeComponent();
        }
        #region 이벤트 핸들러 영역
        private void FrmMain_Load(object sender, EventArgs e)//shift F7 누르면 form으로 이동
        {
            lsvDummy.View = View.Details;

            lsvDummy.Columns.Add("Name");
            lsvDummy.Columns.Add("Depth");

            var FontsList = FontFamily.Families;
            foreach (var font in FontsList)
            {
                CboFont.Items.Add(font.Name);

            }
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

        private void BtnModal_Click(object sender, EventArgs e)// 일반적인 팝업창 설정
        {
            Form frm = new Form();
            frm.Text = "Modal Form";
            frm.Width = 300;
            frm.Height = 200;
            frm.BackColor = Color.Coral;
            frm.ShowDialog();//모달창 띄우기


        }

        private void BtnModaless_Click(object sender, EventArgs e)
        {
            Form frm = new Form
            {
                Text = "Modaess Form",
                Width = 300,
                Height = 100,
                BackColor = Color.GreenYellow
            };
            frm.Show();//모달리스창 띄우기//show로 할 경우에는 팝업창을 띄운 후에도 다른 작업을 실행할 수 있다.

        }

        private void BtnMsgBox_Click(object sender, EventArgs e)
        {
            MessageBox.Show(TxtResult.Text, "타이틀", MessageBoxButtons.OK, MessageBoxIcon.Information);//모달창 메세지 박스


        }

        private void btnAddRoot_Click(object sender, EventArgs e)
        {
            trvDummy.Nodes.Add(random.Next().ToString());

            DisplayTreeToList();
        }

        private void btnAddChild_Click(object sender, EventArgs e)
        {
            if (trvDummy.SelectedNode == null)
            {
                MessageBox.Show("선택된 노드가 없습니다.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            trvDummy.SelectedNode.Nodes.Add(random.Next().ToString());
            trvDummy.SelectedNode.Expand();//treenode상에 바로 보이게 하는 기능

            DisplayTreeToList();
        }


        #endregion

        #region 사용자메서드 영역
        private void ChangeFont()
        {
            if (CboFont.SelectedIndex < 0) return;// 콤보박스에 아무것도 선택안했으면 (-1) 메서드 탈출

            FontStyle style = FontStyle.Regular;
            if (ChkBold.Checked) style |= FontStyle.Bold; //0000001
            if (ChkItalic.Checked) style |= FontStyle.Italic; //00000010
            //00000001|00000010 = 00000011 = Bold +Italic

            TxtResult.Font = new Font((string)CboFont.SelectedItem, 14, style);
        }
        /// <summary>
        /// 트리뷰 내용 리스트뷰에 표시
        /// </summary>
        private void DisplayTreeToList()//메소드 이름을 지정할 때 동사를 사용하는게 국룰임 ex> display, change
        {
            lsvDummy.Items.Clear();
            foreach (TreeNode node in trvDummy.Nodes)
            {
                DisplayTreeToList(node);

            }
            

        }

        private void DisplayTreeToList(TreeNode node)
        {
            lsvDummy.Items.Add(new ListViewItem(new string[] { node.Text, node.FullPath }));

            foreach (TreeNode item in node.Nodes)
            {
                DisplayTreeToList(item);
            }
        }

        #endregion






    }
}
