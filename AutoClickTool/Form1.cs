using System.Diagnostics;
using System.Runtime.InteropServices;

namespace AutoClickTool
{
    public partial class Form1 : Form
    {
        bool isStartBarrange = false;
        bool isStartWhileClick = false;

        int interval = 0;

        // 連打関係の変数
        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall)]
        static extern void SetCursorPos(int x, int y);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall)]
        static extern void mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);

        private const int MOUSEEVENTF_LEFTDOWN = 0x2;
        private const int MOUSEEVENTF_LEFTUP = 0x4;

        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                // 「秒」テキストを「ms」に変更
                label2.Text = "ms";
            }

            if (!checkBox1.Checked)
            {
                // 「ms」テキストを「秒」に変更
                label2.Text = "秒";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 連打を開始/停止
            if (!isStartBarrange)
            {
                // テキストボックスが空、または数字ではない場合、または正の数ではない場合エラーを出す
                if (textBox1.Text == "" || !int.TryParse(textBox1.Text, out int n) || int.Parse(textBox1.Text) <= 0)
                {
                    MessageBox.Show("自然数を入力してください");
                    return;

                } else
                {
                    // 連打を開始
                    barrangeStartBtn.Text = "停止";
                    isStartBarrange = true;
                    Debug.WriteLine("連打を開始");

                    // intervalにテキストボックスの値を代入
                    interval = int.Parse(textBox1.Text);

                    // チェックボックスがチェックされている場合 (msになる)
                    if (checkBox1.Checked)
                    {
                        // intervalに1000を掛ける
                        interval *= 1000;
                    }

                } 
            } else
            {
                // 連打を停止
                barrangeStartBtn.Text = "開始";
                isStartBarrange = false;
                Debug.WriteLine("連打を停止");
            }
        }
    }
}
