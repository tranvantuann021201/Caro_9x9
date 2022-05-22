using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace co_Caro_9x9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BanCo_9x9();

        }
        int demTiso;
        Button[,] buttons = new Button[9, 9];

        private void BanCo_9x9()
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    //Khởi tạo ô, chỉnh thuộc tính của btn.
                    buttons[i, j] = new Button();
                    buttons[i, j].Size = new Size(50, 50);
                    buttons[i, j].Location = new Point(i * 50, j * 50);
                    buttons[i, j].FlatStyle = FlatStyle.Flat;
                    buttons[i, j].Font = new System.Drawing.Font(DefaultFont.FontFamily, 25, FontStyle.Bold);

                    //Bắt sự kiện click cho btn
                    buttons[i, j].Click += new EventHandler(button_Click);

                    //Thêm btn vào ma trận
                    panel1.Controls.Add(buttons[i, j]);
                }
            }
        }

        void button_Click(object sender, EventArgs e)
        {
            //Gán đối tượng đc click vào biến button
            Button button = sender as Button;

            //Kết thúc mọi hoạt động của đối đượng đã được đánh dấu
            if (button.Text != "")
            {
                return;
            }

            //Đánh dấu X/O cho đối tượng được click 
            button.Text = btn_LuotDi.Text;
            button.ForeColor = btn_LuotDi.ForeColor;
            LuotDi();
        }

        private void LuotDi()
        {
            DieuKien_KetThuc();

            if (btn_LuotDi.Text == "X")
            {
                btn_LuotDi.Text = "O";
                btn_LuotDi.ForeColor = Color.Lime;
            }
            else
            {
                btn_LuotDi.Text = "X";
                btn_LuotDi.ForeColor = Color.Red;

            }
        }

        List<Button> winnerButtons = new List<Button>();

        private void DieuKien_KetThuc()
        {
            //Hàng dọc
            for (int i = 0; i < 9; i++)
            {
                winnerButtons = new List<Button>();
                for (int j = 0; j < 9; j++)
                {
                    KiemTra_KetThuc(buttons[i, j]);
                }
            }

            //Hàng ngang
            for (int i = 0; i < 9; i++)
            {
                winnerButtons = new List<Button>();
                for (int j = 0; j < 9; j++)
                {
                    KiemTra_KetThuc(buttons[j, i]);
                }
            }
            //Game hòa
            foreach (var button in buttons)
            {
                if (button.Text == "")
                    return;
            }

            MessageBox.Show("Chơi lại đi thôi","Hòa rồi nha !!!",MessageBoxButtons.OK, MessageBoxIcon.Information);
            reset();
            lb_tinhDiemO.Text = "0";
            lb_tinhDiemX.Text = "0";
        }

        private void KiemTra_KetThuc(Button button)
        {
            if (button.Text != btn_LuotDi.Text)
            {
                winnerButtons.Clear();
            }
            else
            {
                winnerButtons.Add(button);
            }

            if (winnerButtons.Count == 5)
            {
                ShowWinner(winnerButtons);
                for (int i = 0; i < 9; i++)
                {
                    for (int j = 0; j < 9; j++)
                    {
                        buttons[i, j].Enabled = false;
                    }
                }
                return;
            }
        }

        private void ShowWinner(List<Button> winnerButtons)
        {
            foreach (var button in winnerButtons)
            {
                button.BackColor = Color.Yellow;
            }
            MessageBox.Show(btn_LuotDi.Text + " đã chiến thắng rồi", "Đến đây thôi nha !!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (btn_LuotDi.Text == "X")
            {
                demTiso = int.Parse(lb_tinhDiemX.Text) + 1;
                lb_tinhDiemX.Text = Convert.ToString(demTiso);
            }
            else
            {
                demTiso = int.Parse(lb_tinhDiemO.Text) + 1;
                lb_tinhDiemO.Text = Convert.ToString(demTiso);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            reset();
            lb_tinhDiemO.Text = "0";
            lb_tinhDiemX.Text = "0";
        }

        private void btn_choiLai_Click(object sender, EventArgs e)
        {
            reset();
        }
    
        private void reset()
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    buttons[i, j].Enabled = true;
                    buttons[i, j].Text = "";
                    buttons[i, j].ForeColor = Color.Black;
                    buttons[i, j].BackColor = Color.White;
                }
            }
        }

        private void lb_tinhDiemX_Click(object sender, EventArgs e)
        {

        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            DialogResult exit;
            exit = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (exit == DialogResult.Yes)
            {
                Application.Exit();
            }

        }
    }
}
