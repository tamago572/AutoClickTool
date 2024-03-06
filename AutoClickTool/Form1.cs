using System.Diagnostics;
using System.Runtime.InteropServices;

namespace AutoClickTool
{
    public partial class Form1 : Form
    {
        bool isStartBarrange = false;
        bool isStartWhileClick = false;

        int interval = 0;

        // �A�Ŋ֌W�̕ϐ�
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
                // �u�b�v�e�L�X�g���ums�v�ɕύX
                label2.Text = "ms";
            }

            if (!checkBox1.Checked)
            {
                // �ums�v�e�L�X�g���u�b�v�ɕύX
                label2.Text = "�b";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // �A�ł��J�n/��~
            if (!isStartBarrange)
            {
                // �e�L�X�g�{�b�N�X����A�܂��͐����ł͂Ȃ��ꍇ�A�܂��͐��̐��ł͂Ȃ��ꍇ�G���[���o��
                if (textBox1.Text == "" || !int.TryParse(textBox1.Text, out int n) || int.Parse(textBox1.Text) <= 0)
                {
                    MessageBox.Show("���R������͂��Ă�������");
                    return;

                } else
                {
                    // �A�ł��J�n
                    barrangeStartBtn.Text = "��~";
                    isStartBarrange = true;
                    Debug.WriteLine("�A�ł��J�n");

                    // interval�Ƀe�L�X�g�{�b�N�X�̒l����
                    interval = int.Parse(textBox1.Text);

                    // �`�F�b�N�{�b�N�X���`�F�b�N����Ă���ꍇ (ms�ɂȂ�)
                    if (checkBox1.Checked)
                    {
                        // interval��1000���|����
                        interval *= 1000;
                    }

                } 
            } else
            {
                // �A�ł��~
                barrangeStartBtn.Text = "�J�n";
                isStartBarrange = false;
                Debug.WriteLine("�A�ł��~");
            }
        }
    }
}
