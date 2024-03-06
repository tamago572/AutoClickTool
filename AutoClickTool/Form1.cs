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

        private async void button1_Click(object sender, EventArgs e)
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
                    Debug.WriteLine("interval: " + interval);

                    // �`�F�b�N�{�b�N�X���`�F�b�N����Ă��Ȃ��ꍇ (�b��ms�ɂ���K�v������)
                    if (!checkBox1.Checked)
                    {
                        // interval��1000���|����
                        interval *= 1000;
                        Debug.WriteLine("ms�ɕϊ�");
                    }

                    while (isStartBarrange)
                    {
                        // �A�ł����s
                        Debug.WriteLine("�ҋ@��");

                        Debug.WriteLine("�v���O���X�o�[���������s");
                        Task nowait = ProgressBarCounterAsync();
                        Debug.WriteLine("�v���O���X�o�[����������");

                        Debug.WriteLine("�ҋ@");
                        await Task.Delay(interval);
                        if (!isStartBarrange)
                        {
                            break;
                        }
                        
                        Debug.WriteLine("�N���b�N���O");
                        OneClick();
                        Debug.WriteLine("�N���b�N");
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

        private void OneClick()
        {
            // �N���b�N�����s
            int x = System.Windows.Forms.Cursor.Position.X;
            int y = System.Windows.Forms.Cursor.Position.Y;

            SetCursorPos(x, y);
            mouse_event(MOUSEEVENTF_LEFTDOWN, 0 ,0 ,0 ,0);
            mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
        }

        private async Task ProgressBarCounterAsync()
        {
            Debug.WriteLine(interval / 200);
            if (interval/200 > 3)
            {
                Debug.WriteLine($"�v���O���X�o�[��i�߂܂�{interval / 200} > 200�Ȃ̂�");
                // �v���O���X�o�[��i�߂�
                progressBar1.Value = 0;
                progressBar1.Maximum = interval/200;
                progressBar1.Minimum = 0;

                for (int i = 0; i < interval/200; i++)
                {
                    progressBar1.Value = i;
                    await Task.Delay(200);
                    if (!isStartBarrange)
                    {
                        break;
                    }
                }
                progressBar1.Value = progressBar1.Maximum;

            }

        }
    }
}
