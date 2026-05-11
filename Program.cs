using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace KeepAwakeApp
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new TrayApplicationContext());
        }
    }

    public class TrayApplicationContext : ApplicationContext
    {
        [FlagsAttribute]
        public enum EXECUTION_STATE : uint
        {
            ES_CONTINUOUS = 0x80000000,
            ES_DISPLAY_REQUIRED = 0x00000002,
            ES_SYSTEM_REQUIRED = 0x00000001
        }

        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        static extern EXECUTION_STATE SetThreadExecutionState(EXECUTION_STATE esFlags);

        private NotifyIcon trayIcon;
        private bool isAwake = false;
        private ContextMenuStrip contextMenu;
        private ToolStripMenuItem toggleMenuItem;
        
        // Khai báo biến chứa 2 icon tự vẽ
        private Icon iconOff;
        private Icon iconOn;

        public TrayApplicationContext()
        {
            // Tự động tạo 2 icon bằng code (Xám = Tắt, Xanh = Bật)
            iconOff = CreateCircleIcon(Color.Gray);
            iconOn = CreateCircleIcon(Color.LimeGreen);

            contextMenu = new ContextMenuStrip();
            toggleMenuItem = new ToolStripMenuItem("Bật giữ sáng màn hình", null, ToggleAwake);
            contextMenu.Items.Add(toggleMenuItem);
            contextMenu.Items.Add(new ToolStripSeparator());
            contextMenu.Items.Add(new ToolStripMenuItem("Thoát", null, Exit));

            trayIcon = new NotifyIcon()
            {
                Icon = iconOff, // Bắt đầu với màu Xám
                ContextMenuStrip = contextMenu,
                Visible = true,
                Text = "Keep Awake: Đang TẮT"
            };

            trayIcon.DoubleClick += ToggleAwake;
        }

        // Hàm dùng đồ họa 2D để tự vẽ một icon hình tròn
        private Icon CreateCircleIcon(Color color)
        {
            Bitmap bitmap = new Bitmap(32, 32);
            using (Graphics g = Graphics.FromImage(bitmap))
            {
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                g.Clear(Color.Transparent);
                
                // Vẽ một chấm tròn có màu
                using (Brush brush = new SolidBrush(color))
                {
                    g.FillEllipse(brush, 4, 4, 24, 24);
                }
                // Thêm viền xám đen cho chấm tròn thêm nổi bật
                using (Pen pen = new Pen(Color.FromArgb(64, 64, 64), 2))
                {
                    g.DrawEllipse(pen, 4, 4, 24, 24);
                }
            }
            
            // Chuyển hình ảnh vừa vẽ thành định dạng Icon của Windows
            IntPtr hIcon = bitmap.GetHicon();
            return Icon.FromHandle(hIcon);
        }

        void ToggleAwake(object sender, EventArgs e)
        {
            isAwake = !isAwake;
            if (isAwake)
            {
                SetThreadExecutionState(EXECUTION_STATE.ES_CONTINUOUS | 
                                        EXECUTION_STATE.ES_DISPLAY_REQUIRED | 
                                        EXECUTION_STATE.ES_SYSTEM_REQUIRED);
                trayIcon.Text = "Keep Awake: Đang BẬT";
                trayIcon.Icon = iconOn; // Chuyển chấm tròn sang Xanh lá
                toggleMenuItem.Text = "Tắt giữ sáng màn hình";
            }
            else
            {
                SetThreadExecutionState(EXECUTION_STATE.ES_CONTINUOUS);
                trayIcon.Text = "Keep Awake: Đang TẮT";
                trayIcon.Icon = iconOff; // Trở lại màu Xám
                toggleMenuItem.Text = "Bật giữ sáng màn hình";
            }
        }

        void Exit(object sender, EventArgs e)
        {
            SetThreadExecutionState(EXECUTION_STATE.ES_CONTINUOUS);
            trayIcon.Visible = false;
            Application.Exit();
        }
    }
}