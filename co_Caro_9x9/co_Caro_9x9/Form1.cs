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
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
        }

        //Bàn cơ 9x9 xuất hiện mỗi khi form được load lên
        private void Form1_Load(object sender, EventArgs e)
        {
            BanCo_9x9();
        }
        //Tạo 1 biến để tính tỉ số trận đấu
        int demTiso;

        //Khởi tạo mảng Button 2 chiều để vẽ bàn cờ
        Button[,] buttons = new Button[27, 27];

        //Vẽ bàn cờ
        private void BanCo_9x9()
        {
            for (int i = 0; i < 27; i++)
            {
                for (int j = 0; j < 27; j++)
                {
                    //Khởi tạo ô, chỉnh thuộc tính của btn.
                    buttons[i, j] = new Button();
                    buttons[i, j].Size = new Size(50, 50);
                    buttons[i, j].Location = new Point(i * 50, j * 50);
                    buttons[i, j].FlatStyle = FlatStyle.Flat;
                    buttons[i, j].Font = new System.Drawing.Font(DefaultFont.FontFamily, 25, FontStyle.Bold);

                    //Bắt sự kiện click cho Button
                    buttons[i, j].Click += new EventHandler(button_Click);

                    //Thêm btn vào ma trận
                    panel1.Controls.Add(buttons[i, j]);
                }
            }
        }

        //Tạo hàm để bắt sự kiện click cho Button
        private void button_Click(object sender, EventArgs e)
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

        //Hiển thị lượt đi tiếp theo là của X hay O lên Button thông báo lượt đi
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

        //Tạo ra một list Button để chứa những Button có kiệu X/O giống nhau
        List<Button> winnerButtons = new List<Button>();

        //Hàm điều kiện để kết thúc ván đấu(Thắng/Thua/Hòa)
        //5 trường hợp: Hàng ngang, hàng dọc, 2 Đường chéo và ván đấu hòa
        private void DieuKien_KetThuc()
        {
            //Hàng dọc
            for (int i = 0; i < 27; i++)
            {
                winnerButtons = new List<Button>();
                for (int j = 0; j < 9; j++)
                {
                    KiemTra_KetThuc(buttons[i, j]);
                }
            }

            //Hàng ngang
            for (int i = 0; i < 27; i++)
            {
                winnerButtons = new List<Button>();
                for (int j = 0; j < 9; j++)
                {
                    KiemTra_KetThuc(buttons[j, i]);
                }
            }

            //Đường chéo góc trên trái -> dưới phải "\"
            for (int k = 0; k < 27; k++)
            {
                //Mỗi vòng for con sẽ xét điều kiện kết thúc trên 1 nửa ma trận,
                //ngăn cách nhau bởi đường chéo chính 

                //Cần tạo mới list Button cho mỗi lần xét điều kiện.
                winnerButtons = new List<Button>();
                //Xét nửa trên của Bàn cờ theo đường chéo chính (Bao gồm đường chéo chính)
                for (int i = k, j = 0; i < 27; i++, j++)
                {
                    KiemTra_KetThuc(buttons[i, j]);
                }

                //Xét nửa dưới của Bàn cờ theo đường chéo chính
                winnerButtons = new List<Button>();
                for (int i = 0, j = k; j < 9; i++, j++)
                {
                    //Bỏ qua đường chéo chính
                    if(i == j)
                    {

                        continue;
                    }

                    KiemTra_KetThuc(buttons[i, j]);
                }
            }

            //Đường chéo góc trên phải -> dưới trái "\"
            for (int k = 0; k < 27; k ++)
            {
                //Nửa trên bên phải (Bao gồm đường chéo chính)
                winnerButtons = new List<Button>();
                for (int i = 26, j = k; j < 27; i--, j++)
                {
                    KiemTra_KetThuc(buttons[i, j]);
                }

                //Nửa dưới bên trái
                winnerButtons = new List<Button>();
                for (int i = k, j = 0; i >= 0; i--, j++)
                {
                    //Bỏ qua đường chéo chính
                    if(i == j)
                    {
                        continue;
                    }
                    KiemTra_KetThuc(buttons[i, j]);
                }
            }
            //Game hòa:
            //Vòng foreach xét từng vị trí của Bàn cờ
            foreach (var button in buttons)
            {
                //Nếu còn xuất hiện vị trí rỗng, nhánh không trả về giá trị
                if (button.Text == "")
                    return;
            }
            //Nếu không còn vị trí rỗng, thông báo Hòa trận đấu và reset lại trò chơi
            MessageBox.Show("Chơi lại đi thôi", "Hòa rồi nha !!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            reset();
        }

        //Hàm kiểm tra ván đấu đã đạt điều kiện kết thúc hay chưa?
        private void KiemTra_KetThuc(Button button)
        {
            //Xóa các Button có kí tự có trong List nếu chúng khác với kí tự mới được thêm vào
            if (button.Text != btn_LuotDi.Text)
            {
                winnerButtons.Clear();
            }

            //Thêm kí tự mới vào List
            else
            {
                winnerButtons.Add(button);
            }

            //Nếu trong List chứa đủ 5 Button đồng kí tự, thì Thông báo người thắng cuộc
            //và không cho phép người dùng tác động lên bàn cờ, chỉ có thể tác động lên các button chức năng
            if (winnerButtons.Count == 5)
            {
                ShowWinner(winnerButtons);
                DungMoiHoatDong();
                return;
            }
        }

        //Hàm thông báo và cộng tỉ số cho người chiến thắng
        private void ShowWinner(List<Button> winnerButtons)
        {
            //Đổ màu 5 Button liên tiếp chứa kí tự giống nhau trong List
            foreach (var button in winnerButtons)
            {
                button.BackColor = Color.Yellow;
            }

            //Thông báo người chiến thắng
            MessageBox.Show(btn_LuotDi.Text + " đã chiến thắng rồi", "Đến đây thôi nha !!!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //Cộng tỉ số cho người chiến thắng 
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

        //Bắt sự kiện click cho Button Chơi mới
        private void button1_Click(object sender, EventArgs e)
        {
            //Tạo bàn cờ mới
            reset();
            //Set lại tỉ số ván đấu
            lb_tinhDiemO.Text = "0";
            lb_tinhDiemX.Text = "0";
        }

        //Bắt sự kiện click cho Button Chơi lại
        private void btn_choiLai_Click(object sender, EventArgs e)
        {
            //Xóa trắng bàn cờ
            reset();
        }
    
        //Hàm tạo bàn cờ mới
        private void reset()
        {
            for (int i = 0; i < 27; i++)
            {
                for (int j = 0; j < 27; j++)
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

        //Bắt sự kiện click cho Button thoát
        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            //Khởi tạo biến thông báo YesNo
            DialogResult exit;
            exit = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
            //Đóng ứng dụng nếu người dụng chọn Yes
            if (exit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        //Hàm không cho phép người dùng tác động lên bàn cờ
        private void DungMoiHoatDong()
        {
            for (int i = 0; i < 27; i++)
            {
                for (int j = 0; j < 27; j++)
                {
                    buttons[i, j].Enabled = false;
                }
            }
        }

        //Giao diện
        //Sáng
        private void gd_Sang()
        {
            menuStrip1.BackColor = Color.WhiteSmoke;
            panel1.BackColor = Color.White;
            lb_LuotDi.BackColor = Color.White;
            //tableLayoutPanel1.BackColor = Color.Gray;
            this.BackColor = Color.White;
            lb_tinhDiemO.BackColor = Color.White;
            lb_tinhDiemX.BackColor = Color.White;
            label1.BackColor = Color.White;
            label2.BackColor = Color.White;
            label4.BackColor = Color.White;
            btn_LuotDi.BackColor = Color.Gainsboro;
            btn_choiLai.BackColor = Color.Gainsboro;
            btn_choiMoi.BackColor = Color.Gainsboro;
            btn_Thoat.BackColor = Color.Gainsboro;
        }

        //Tối
        private void gd_Toi()
        {
            menuStrip1.BackColor = Color.DimGray;
            panel1.BackColor = Color.DimGray;
            lb_LuotDi.BackColor = Color.DimGray;
            //tableLayoutPanel1.BackColor = Color.Gray;
            this.BackColor = Color.Gray;
            lb_tinhDiemO.BackColor = Color.DimGray;
            lb_tinhDiemX.BackColor = Color.DimGray;
            label1.BackColor = Color.DimGray;
            label2.BackColor = Color.DimGray;
            label4.BackColor = Color.DimGray;
            btn_LuotDi.BackColor= Color.DimGray;
            btn_choiLai.BackColor = Color.DimGray;
            btn_choiMoi.BackColor = Color.DimGray;
            btn_Thoat.BackColor = Color.DimGray;
        }

        private void giaoDiệnTốiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gd_Toi();
        }

        private void giaoDiệnSángToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gd_Sang();
        }
    }
}
