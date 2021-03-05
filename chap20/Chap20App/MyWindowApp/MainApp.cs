using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyWindowApp
{
    class MainApp : Form
    {
        public MainApp(string title)
        {
            this.Text = title;
            this.MouseClick += MainApp_MouseClick;
        }

        private void MainApp_MouseClick(object sender, MouseEventArgs e) //mouseEventArgs 상위 단계 메소드
        {
            //throw new NotImplementedException();
            var result = $"sender : {sender} \r\n" + // 마우스 클릭을 보낸 사람
                         $"e : {e}\r\n" + // 
                         $"e.X : {e.X}, e.Y : {e.Y} " + // click한 가로 세로 위치
                         $"Button : {e.Button}, Click : {e.Clicks}"; // click을 오른쪽 or  왼쪽으로 했는지 , 클릭 횟수 
            MessageBox.Show(result);
        }

        static void Main(string[] args)
        {
            Application.Run(new MainApp("Mouse Event App"));
        }
    }
}
