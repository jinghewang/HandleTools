using System;

using System.Drawing;

using System.Collections;

using System.ComponentModel;

using System.Windows.Forms;

using System.Data;

using System.Runtime.InteropServices;

using System.Diagnostics;
using System.Collections.Generic;
using System.Xml;

namespace Show
{

    /// <summary>

    /// Form1 的摘要说明。

    /// </summary>

    public class Form1 : System.Windows.Forms.Form
    {

        #region 声名变量

        private System.ComponentModel.Container components = null;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;

        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.TextBox tbWindowName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button15;
        private Process p = new Process();
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button19;
        private GroupBox groupBox2;
        private Label labResult2;
        private Label labResult;
        private Button button20;
        private Button button21;
        private Button button22;
        private TextBox textBox8;
        private Button button23;
        private Label label6;
        private TextBox tbWindowHandle;
        private GroupBox groupBox3;
        private TabControl tabControl1;
        private TabPage tabHome;
        private TabPage tabConfig2;
        private TabPage tabBrowser;
        private Button button26;
        private Label label7;
        private Button button25;
        private Button button27;
        private Button button28;
        private Label label8;
        private TextBox tbButtonNo;
        private Button button29;
        private Label label9;
        private TextBox tbChildName;
        private Button button30;
        private TreeView treeView1;
        private TextBox tbFullIndex;
        private TextBox tbFullPath;
        private TextBox tbSelectedNode;
        private Button btnGetNodeByPath;
        private TabPage tabTest2;
        private GroupBox groupBox1;
        private Button button6;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private TextBox textBox1;
        private Button button7;
        private Button button8;
        private Button button9;
        private TextBox textBox2;
        private GroupBox groupBox4;
        private Label label10;
        private TabPage tabConfig;
        private GroupBox groupBox5;
        private Button button31;
        private Button button32;
        private Panel panel1;
        private Button btnLoadConfig;
        private Button btnSaveConfig;
        private Button button34;
        private GroupBox groupBox6;
        private TextBox tbNodeHandle;
        private Button button33;
        private TextBox tbDlgHandle;
        private Button button24;
        private TextBox tbSendText;
        private Label label4;
        private Button btnFlashWindow;
        private Button button35;
        private Label labResult3;
        private GroupBox groupBox7;
        private GroupBox groupBox8;
        private GroupBox groupBox9;
        private Button button36;
        public IntPtr myControl;
        #endregion

        //[DllImportAttribute ("user32.dll")] 
        //public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam,ref int lParam); 
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        public static extern int SendMessage(
            IntPtr hwnd,
            int wMsg,
            int wParam,
            string lParam
            );

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll", EntryPoint = "SendMessageW")]
        public static extern int SendMessageW2([System.Runtime.InteropServices.InAttribute()] System.IntPtr hWnd, uint Msg, uint wParam, IntPtr lParam);

        [DllImport("user32.dll", EntryPoint = "FindWindow")]
        public static extern IntPtr FindWindow(
            string lpClassName,
            string lpWindowName
            );
        [DllImport("user32.dll", EntryPoint = "GetDlgItem")]
        public static extern IntPtr GetDlgItem(
            IntPtr hDlg,
            int nIDDlgItem
            );
        [DllImport("user32.dll", EntryPoint = "ShowWindow")]
        public static extern int ShowWindow(
            IntPtr hwnd,
            int nCmdShow
            );

        public const int SW_HIDE = 0x0000;
        public const int SW_SHOWNORMAL = 0x0001;
        public const int WM_COMMAND = 0x111;
        public const int WM_SYSCOMMAND = 0x0112;
        public const int SC_MAXIMIZE = 0xF030;
        public const int WM_MOVE = 0x0003;
        public const int WM_SETTEXT = 0x000C;
        public const int WM_PASTE = 0x0302;
        public const int WM_CLOSE = 0x0010;
        public const int BN_CLICKED = 0;
        public const int MK_LBUTTON = 1;
        //鼠标按下
        public const int WM_LBUTTONDOWN = 0x201;
        //鼠标弹出
        public const int WM_LBUTTONUP = 0x202;

        //		public class WinAPI 
        //		{ 	
        //			
        //		} 
        public delegate bool CallBack(int hwnd, int lParam);

        [DllImport("user32")]
        public static extern int EnumWindows(CallBack x, int y);

        public delegate bool ChildCallBack(int hwnd, int lParam);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool EnumChildWindows(IntPtr hwndParent, ChildCallBack x, int lParam);

        [DllImport("user32.dll")]
        public static extern int GetWindowText(int hWnd, IntPtr lpString, int nMaxCount);


        #region 自动生成
        public Form1()
        {

            //

            // Windows 窗体设计器支持所必需的

            //

            InitializeComponent();



            //

            // TODO: 在 InitializeComponent 调用后添加任何构造函数代码

            //

        }



        /// <summary>

        /// 清理所有正在使用的资源。

        /// </summary>

        protected override void Dispose(bool disposing)
        {

            if (disposing)
            {

                if (components != null)
                {

                    components.Dispose();

                }

            }

            base.Dispose(disposing);

        }

        #endregion

        #region Windows Form Designer generated code

        /// <summary>

        /// 设计器支持所需的方法 - 不要使用代码编辑器修改

        /// 此方法的内容。

        /// </summary>

        private void InitializeComponent()
        {
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.tbWindowName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button14 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button15 = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.button16 = new System.Windows.Forms.Button();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button34 = new System.Windows.Forms.Button();
            this.button31 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.button25 = new System.Windows.Forms.Button();
            this.button32 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbChildName = new System.Windows.Forms.TextBox();
            this.tbWindowHandle = new System.Windows.Forms.TextBox();
            this.button29 = new System.Windows.Forms.Button();
            this.button28 = new System.Windows.Forms.Button();
            this.tbButtonNo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button20 = new System.Windows.Forms.Button();
            this.labResult = new System.Windows.Forms.Label();
            this.button27 = new System.Windows.Forms.Button();
            this.button26 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.button22 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.labResult2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabHome = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.tbDlgHandle = new System.Windows.Forms.TextBox();
            this.tabConfig = new System.Windows.Forms.TabPage();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.btnLoadConfig = new System.Windows.Forms.Button();
            this.btnSaveConfig = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabBrowser = new System.Windows.Forms.TabPage();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.button36 = new System.Windows.Forms.Button();
            this.labResult3 = new System.Windows.Forms.Label();
            this.button30 = new System.Windows.Forms.Button();
            this.btnGetNodeByPath = new System.Windows.Forms.Button();
            this.tbSendText = new System.Windows.Forms.TextBox();
            this.button35 = new System.Windows.Forms.Button();
            this.btnFlashWindow = new System.Windows.Forms.Button();
            this.tbSelectedNode = new System.Windows.Forms.TextBox();
            this.button24 = new System.Windows.Forms.Button();
            this.tbNodeHandle = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbFullIndex = new System.Windows.Forms.TextBox();
            this.button33 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.tbFullPath = new System.Windows.Forms.TextBox();
            this.tabConfig2 = new System.Windows.Forms.TabPage();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.tabTest2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabHome.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.tabConfig.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.tabBrowser.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tabConfig2.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.tabTest2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(367, 24);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(119, 23);
            this.button10.TabIndex = 11;
            this.button10.Text = "FindWindow";
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(212, 91);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(80, 24);
            this.button11.TabIndex = 12;
            this.button11.Text = "WM_SETTEXT";
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(298, 106);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(80, 24);
            this.button12.TabIndex = 13;
            this.button12.Text = "max";
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(384, 108);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(87, 24);
            this.button13.TabIndex = 14;
            this.button13.Text = "close";
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // tbWindowName
            // 
            this.tbWindowName.Location = new System.Drawing.Point(78, 22);
            this.tbWindowName.Name = "tbWindowName";
            this.tbWindowName.Size = new System.Drawing.Size(112, 21);
            this.tbWindowName.TabIndex = 15;
            this.tbWindowName.Text = "Form1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 16;
            this.label1.Text = "Window：";
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(212, 31);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(80, 23);
            this.button14.TabIndex = 17;
            this.button14.Text = "GetDlgItem";
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(77, 31);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 21);
            this.textBox4.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 12);
            this.label2.TabIndex = 19;
            this.label2.Text = "ID:";
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(212, 68);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(80, 24);
            this.button15.TabIndex = 20;
            this.button15.Text = "WM_SETTEXT";
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(77, 94);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(112, 21);
            this.textBox5.TabIndex = 21;
            this.textBox5.Text = "hello";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(77, 68);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 21);
            this.textBox6.TabIndex = 22;
            this.textBox6.Text = "123456";
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(212, 106);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(80, 23);
            this.button16.TabIndex = 23;
            this.button16.Text = "Click";
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(262, 24);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(99, 21);
            this.textBox7.TabIndex = 24;
            this.textBox7.Text = "null";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(210, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 12);
            this.label3.TabIndex = 25;
            this.label3.Text = "Class：";
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(386, 33);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(85, 24);
            this.button17.TabIndex = 28;
            this.button17.Text = "SetCurrent";
            this.button17.Click += new System.EventHandler(this.button17_Click);
            // 
            // button18
            // 
            this.button18.Location = new System.Drawing.Point(298, 92);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(80, 23);
            this.button18.TabIndex = 29;
            this.button18.Text = "SW_HIDE";
            this.button18.Click += new System.EventHandler(this.button18_Click);
            // 
            // button19
            // 
            this.button19.Location = new System.Drawing.Point(387, 92);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(100, 23);
            this.button19.TabIndex = 30;
            this.button19.Text = "SW_SHOWNORMAL";
            this.button19.Click += new System.EventHandler(this.button19_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.button34);
            this.groupBox2.Controls.Add(this.button31);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.button25);
            this.groupBox2.Controls.Add(this.button32);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.tbChildName);
            this.groupBox2.Controls.Add(this.tbWindowHandle);
            this.groupBox2.Controls.Add(this.button29);
            this.groupBox2.Controls.Add(this.button28);
            this.groupBox2.Controls.Add(this.tbButtonNo);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.button20);
            this.groupBox2.Controls.Add(this.tbWindowName);
            this.groupBox2.Controls.Add(this.button10);
            this.groupBox2.Controls.Add(this.button19);
            this.groupBox2.Controls.Add(this.button11);
            this.groupBox2.Controls.Add(this.button18);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.labResult);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.textBox7);
            this.groupBox2.Controls.Add(this.textBox5);
            this.groupBox2.Location = new System.Drawing.Point(6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(695, 288);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Main";
            // 
            // button34
            // 
            this.button34.Location = new System.Drawing.Point(464, 126);
            this.button34.Name = "button34";
            this.button34.Size = new System.Drawing.Size(120, 23);
            this.button34.TabIndex = 56;
            this.button34.Text = "Clear Data";
            this.button34.Click += new System.EventHandler(this.button34_Click);
            // 
            // button31
            // 
            this.button31.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button31.Location = new System.Drawing.Point(212, 126);
            this.button31.Name = "button31";
            this.button31.Size = new System.Drawing.Size(120, 23);
            this.button31.TabIndex = 36;
            this.button31.Text = "EnumChildWindows";
            this.button31.UseVisualStyleBackColor = true;
            this.button31.Click += new System.EventHandler(this.button31_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(213, 206);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 12);
            this.label9.TabIndex = 60;
            this.label9.Text = "child：";
            // 
            // button25
            // 
            this.button25.Location = new System.Drawing.Point(465, 168);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(120, 23);
            this.button25.TabIndex = 53;
            this.button25.Text = "Send Click";
            this.button25.Visible = false;
            this.button25.Click += new System.EventHandler(this.button25_Click);
            // 
            // button32
            // 
            this.button32.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button32.Location = new System.Drawing.Point(338, 126);
            this.button32.Name = "button32";
            this.button32.Size = new System.Drawing.Size(120, 23);
            this.button32.TabIndex = 52;
            this.button32.Text = "Send Data";
            this.button32.Click += new System.EventHandler(this.button32_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 52;
            this.label7.Text = "text：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 38;
            this.label6.Text = "handle：";
            // 
            // tbChildName
            // 
            this.tbChildName.Location = new System.Drawing.Point(262, 203);
            this.tbChildName.Name = "tbChildName";
            this.tbChildName.Size = new System.Drawing.Size(70, 21);
            this.tbChildName.TabIndex = 59;
            this.tbChildName.Text = "kp";
            // 
            // tbWindowHandle
            // 
            this.tbWindowHandle.ForeColor = System.Drawing.Color.Red;
            this.tbWindowHandle.Location = new System.Drawing.Point(78, 57);
            this.tbWindowHandle.Name = "tbWindowHandle";
            this.tbWindowHandle.ReadOnly = true;
            this.tbWindowHandle.Size = new System.Drawing.Size(112, 21);
            this.tbWindowHandle.TabIndex = 37;
            // 
            // button29
            // 
            this.button29.Location = new System.Drawing.Point(338, 205);
            this.button29.Name = "button29";
            this.button29.Size = new System.Drawing.Size(120, 23);
            this.button29.TabIndex = 58;
            this.button29.Text = "Send Click";
            this.button29.Click += new System.EventHandler(this.button29_Click);
            // 
            // button28
            // 
            this.button28.Location = new System.Drawing.Point(338, 168);
            this.button28.Name = "button28";
            this.button28.Size = new System.Drawing.Size(120, 23);
            this.button28.TabIndex = 57;
            this.button28.Text = "Send Click";
            this.button28.Click += new System.EventHandler(this.button28_Click);
            // 
            // tbButtonNo
            // 
            this.tbButtonNo.Location = new System.Drawing.Point(262, 168);
            this.tbButtonNo.Name = "tbButtonNo";
            this.tbButtonNo.Size = new System.Drawing.Size(70, 21);
            this.tbButtonNo.TabIndex = 55;
            this.tbButtonNo.Text = "7";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(213, 168);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 12);
            this.label8.TabIndex = 56;
            this.label8.Text = "index：";
            // 
            // button20
            // 
            this.button20.Location = new System.Drawing.Point(492, 24);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(120, 23);
            this.button20.TabIndex = 31;
            this.button20.Text = "EnumWindows";
            this.button20.UseVisualStyleBackColor = true;
            this.button20.Click += new System.EventHandler(this.button20_Click);
            // 
            // labResult
            // 
            this.labResult.AutoSize = true;
            this.labResult.Location = new System.Drawing.Point(210, 60);
            this.labResult.Name = "labResult";
            this.labResult.Size = new System.Drawing.Size(59, 12);
            this.labResult.TabIndex = 26;
            this.labResult.Text = "Result:　";
            // 
            // button27
            // 
            this.button27.Location = new System.Drawing.Point(12, 107);
            this.button27.Name = "button27";
            this.button27.Size = new System.Drawing.Size(160, 23);
            this.button27.TabIndex = 54;
            this.button27.Text = "Clear Data";
            this.button27.Click += new System.EventHandler(this.button27_Click);
            // 
            // button26
            // 
            this.button26.Location = new System.Drawing.Point(12, 66);
            this.button26.Name = "button26";
            this.button26.Size = new System.Drawing.Size(160, 23);
            this.button26.TabIndex = 51;
            this.button26.Text = "Send Data";
            this.button26.Click += new System.EventHandler(this.button26_Click);
            // 
            // button23
            // 
            this.button23.Location = new System.Drawing.Point(12, 29);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(160, 23);
            this.button23.TabIndex = 35;
            this.button23.Text = "EnumChildWindows";
            this.button23.UseVisualStyleBackColor = true;
            this.button23.Click += new System.EventHandler(this.button23_Click);
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(77, 108);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(100, 21);
            this.textBox8.TabIndex = 34;
            // 
            // button22
            // 
            this.button22.Location = new System.Drawing.Point(298, 69);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(80, 24);
            this.button22.TabIndex = 33;
            this.button22.Text = "WM_GETTEXT";
            this.button22.Click += new System.EventHandler(this.button22_Click);
            // 
            // button21
            // 
            this.button21.Location = new System.Drawing.Point(384, 70);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(118, 23);
            this.button21.TabIndex = 32;
            this.button21.Text = "WM_GETTEXTLENGTH";
            this.button21.UseVisualStyleBackColor = true;
            this.button21.Click += new System.EventHandler(this.button21_Click);
            // 
            // labResult2
            // 
            this.labResult2.AutoSize = true;
            this.labResult2.Location = new System.Drawing.Point(506, 40);
            this.labResult2.Name = "labResult2";
            this.labResult2.Size = new System.Drawing.Size(53, 12);
            this.labResult2.TabIndex = 27;
            this.labResult2.Text = "Result2:";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Location = new System.Drawing.Point(6, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(507, 441);
            this.groupBox3.TabIndex = 49;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Config";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabHome);
            this.tabControl1.Controls.Add(this.tabConfig);
            this.tabControl1.Controls.Add(this.tabBrowser);
            this.tabControl1.Controls.Add(this.tabConfig2);
            this.tabControl1.Controls.Add(this.tabTest2);
            this.tabControl1.Location = new System.Drawing.Point(5, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(715, 482);
            this.tabControl1.TabIndex = 50;
            // 
            // tabHome
            // 
            this.tabHome.Controls.Add(this.groupBox6);
            this.tabHome.Controls.Add(this.groupBox2);
            this.tabHome.Location = new System.Drawing.Point(4, 22);
            this.tabHome.Name = "tabHome";
            this.tabHome.Padding = new System.Windows.Forms.Padding(3);
            this.tabHome.Size = new System.Drawing.Size(707, 456);
            this.tabHome.TabIndex = 0;
            this.tabHome.Text = "Home";
            this.tabHome.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox6.Controls.Add(this.tbDlgHandle);
            this.groupBox6.Controls.Add(this.button14);
            this.groupBox6.Controls.Add(this.textBox6);
            this.groupBox6.Controls.Add(this.button15);
            this.groupBox6.Controls.Add(this.button16);
            this.groupBox6.Controls.Add(this.label2);
            this.groupBox6.Controls.Add(this.textBox4);
            this.groupBox6.Controls.Add(this.labResult2);
            this.groupBox6.Controls.Add(this.button13);
            this.groupBox6.Controls.Add(this.button17);
            this.groupBox6.Controls.Add(this.button12);
            this.groupBox6.Controls.Add(this.button21);
            this.groupBox6.Controls.Add(this.textBox8);
            this.groupBox6.Controls.Add(this.button22);
            this.groupBox6.Location = new System.Drawing.Point(6, 300);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(695, 150);
            this.groupBox6.TabIndex = 51;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Child";
            // 
            // tbDlgHandle
            // 
            this.tbDlgHandle.Location = new System.Drawing.Point(298, 33);
            this.tbDlgHandle.Name = "tbDlgHandle";
            this.tbDlgHandle.Size = new System.Drawing.Size(80, 21);
            this.tbDlgHandle.TabIndex = 37;
            // 
            // tabConfig
            // 
            this.tabConfig.Controls.Add(this.groupBox7);
            this.tabConfig.Controls.Add(this.groupBox5);
            this.tabConfig.Location = new System.Drawing.Point(4, 22);
            this.tabConfig.Name = "tabConfig";
            this.tabConfig.Size = new System.Drawing.Size(707, 456);
            this.tabConfig.TabIndex = 4;
            this.tabConfig.Text = "Config";
            this.tabConfig.UseVisualStyleBackColor = true;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.btnLoadConfig);
            this.groupBox7.Controls.Add(this.btnSaveConfig);
            this.groupBox7.Location = new System.Drawing.Point(517, 6);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(182, 442);
            this.groupBox7.TabIndex = 51;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Operation";
            // 
            // btnLoadConfig
            // 
            this.btnLoadConfig.Location = new System.Drawing.Point(14, 34);
            this.btnLoadConfig.Name = "btnLoadConfig";
            this.btnLoadConfig.Size = new System.Drawing.Size(160, 23);
            this.btnLoadConfig.TabIndex = 54;
            this.btnLoadConfig.Text = "Load Config";
            this.btnLoadConfig.Click += new System.EventHandler(this.btnLoadConfig_Click);
            // 
            // btnSaveConfig
            // 
            this.btnSaveConfig.Location = new System.Drawing.Point(14, 63);
            this.btnSaveConfig.Name = "btnSaveConfig";
            this.btnSaveConfig.Size = new System.Drawing.Size(160, 23);
            this.btnSaveConfig.TabIndex = 53;
            this.btnSaveConfig.Text = "Save Config";
            this.btnSaveConfig.Click += new System.EventHandler(this.btnSaveConfig_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Controls.Add(this.panel1);
            this.groupBox5.Location = new System.Drawing.Point(6, 6);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(505, 442);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Config";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Location = new System.Drawing.Point(-5, 336);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 38);
            this.panel1.TabIndex = 0;
            // 
            // tabBrowser
            // 
            this.tabBrowser.Controls.Add(this.groupBox8);
            this.tabBrowser.Controls.Add(this.groupBox4);
            this.tabBrowser.Location = new System.Drawing.Point(4, 22);
            this.tabBrowser.Name = "tabBrowser";
            this.tabBrowser.Size = new System.Drawing.Size(707, 456);
            this.tabBrowser.TabIndex = 2;
            this.tabBrowser.Text = "Browser";
            this.tabBrowser.UseVisualStyleBackColor = true;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.button36);
            this.groupBox8.Controls.Add(this.labResult3);
            this.groupBox8.Controls.Add(this.button30);
            this.groupBox8.Controls.Add(this.btnGetNodeByPath);
            this.groupBox8.Controls.Add(this.tbSendText);
            this.groupBox8.Controls.Add(this.button35);
            this.groupBox8.Controls.Add(this.btnFlashWindow);
            this.groupBox8.Controls.Add(this.tbSelectedNode);
            this.groupBox8.Controls.Add(this.button24);
            this.groupBox8.Controls.Add(this.tbNodeHandle);
            this.groupBox8.Controls.Add(this.label4);
            this.groupBox8.Controls.Add(this.tbFullIndex);
            this.groupBox8.Controls.Add(this.button33);
            this.groupBox8.Location = new System.Drawing.Point(513, 6);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(185, 448);
            this.groupBox8.TabIndex = 51;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Operation";
            // 
            // button36
            // 
            this.button36.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button36.Location = new System.Drawing.Point(14, 352);
            this.button36.Name = "button36";
            this.button36.Size = new System.Drawing.Size(160, 23);
            this.button36.TabIndex = 66;
            this.button36.Text = "Send Click2";
            this.button36.Click += new System.EventHandler(this.button36_Click);
            // 
            // labResult3
            // 
            this.labResult3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labResult3.AutoSize = true;
            this.labResult3.Location = new System.Drawing.Point(12, 394);
            this.labResult3.Name = "labResult3";
            this.labResult3.Size = new System.Drawing.Size(53, 12);
            this.labResult3.TabIndex = 65;
            this.labResult3.Text = "Result3:";
            // 
            // button30
            // 
            this.button30.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button30.Location = new System.Drawing.Point(14, 27);
            this.button30.Name = "button30";
            this.button30.Size = new System.Drawing.Size(160, 23);
            this.button30.TabIndex = 36;
            this.button30.Text = "EnumChildWindows";
            this.button30.UseVisualStyleBackColor = true;
            this.button30.Click += new System.EventHandler(this.button30_Click);
            // 
            // btnGetNodeByPath
            // 
            this.btnGetNodeByPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGetNodeByPath.Location = new System.Drawing.Point(14, 139);
            this.btnGetNodeByPath.Name = "btnGetNodeByPath";
            this.btnGetNodeByPath.Size = new System.Drawing.Size(160, 23);
            this.btnGetNodeByPath.TabIndex = 39;
            this.btnGetNodeByPath.Text = "GetNodeByPath";
            this.btnGetNodeByPath.UseVisualStyleBackColor = true;
            this.btnGetNodeByPath.Click += new System.EventHandler(this.btnGetNodeByPath_Click);
            // 
            // tbSendText
            // 
            this.tbSendText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSendText.Location = new System.Drawing.Point(67, 246);
            this.tbSendText.Name = "tbSendText";
            this.tbSendText.Size = new System.Drawing.Size(107, 21);
            this.tbSendText.TabIndex = 62;
            this.tbSendText.Text = "hello";
            // 
            // button35
            // 
            this.button35.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button35.Location = new System.Drawing.Point(14, 323);
            this.button35.Name = "button35";
            this.button35.Size = new System.Drawing.Size(160, 23);
            this.button35.TabIndex = 58;
            this.button35.Text = "Send Click";
            this.button35.Click += new System.EventHandler(this.button35_Click);
            // 
            // btnFlashWindow
            // 
            this.btnFlashWindow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFlashWindow.Location = new System.Drawing.Point(14, 195);
            this.btnFlashWindow.Name = "btnFlashWindow";
            this.btnFlashWindow.Size = new System.Drawing.Size(160, 23);
            this.btnFlashWindow.TabIndex = 64;
            this.btnFlashWindow.Text = "FlashWindow";
            this.btnFlashWindow.Click += new System.EventHandler(this.btnFlashWindow_Click);
            // 
            // tbSelectedNode
            // 
            this.tbSelectedNode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSelectedNode.Location = new System.Drawing.Point(14, 168);
            this.tbSelectedNode.Name = "tbSelectedNode";
            this.tbSelectedNode.Size = new System.Drawing.Size(160, 21);
            this.tbSelectedNode.TabIndex = 40;
            // 
            // button24
            // 
            this.button24.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button24.Location = new System.Drawing.Point(14, 273);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(160, 23);
            this.button24.TabIndex = 63;
            this.button24.Text = "Send Text";
            this.button24.Click += new System.EventHandler(this.button24_Click);
            // 
            // tbNodeHandle
            // 
            this.tbNodeHandle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbNodeHandle.Location = new System.Drawing.Point(14, 56);
            this.tbNodeHandle.Name = "tbNodeHandle";
            this.tbNodeHandle.Size = new System.Drawing.Size(160, 21);
            this.tbNodeHandle.TabIndex = 43;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 61;
            this.label4.Text = "text：";
            // 
            // tbFullIndex
            // 
            this.tbFullIndex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbFullIndex.Location = new System.Drawing.Point(14, 112);
            this.tbFullIndex.Name = "tbFullIndex";
            this.tbFullIndex.Size = new System.Drawing.Size(160, 21);
            this.tbFullIndex.TabIndex = 38;
            // 
            // button33
            // 
            this.button33.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button33.Location = new System.Drawing.Point(14, 83);
            this.button33.Name = "button33";
            this.button33.Size = new System.Drawing.Size(160, 23);
            this.button33.TabIndex = 42;
            this.button33.Text = "SetCurrentHandle";
            this.button33.UseVisualStyleBackColor = true;
            this.button33.Click += new System.EventHandler(this.button33_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.treeView1);
            this.groupBox4.Controls.Add(this.tbFullPath);
            this.groupBox4.Location = new System.Drawing.Point(6, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(499, 447);
            this.groupBox4.TabIndex = 51;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Browser";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 31);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 12);
            this.label10.TabIndex = 41;
            this.label10.Text = "FullPath:";
            // 
            // treeView1
            // 
            this.treeView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.treeView1.Location = new System.Drawing.Point(6, 55);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(487, 384);
            this.treeView1.TabIndex = 32;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            this.treeView1.Click += new System.EventHandler(this.treeView1_Click);
            // 
            // tbFullPath
            // 
            this.tbFullPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbFullPath.Location = new System.Drawing.Point(71, 28);
            this.tbFullPath.Name = "tbFullPath";
            this.tbFullPath.Size = new System.Drawing.Size(422, 21);
            this.tbFullPath.TabIndex = 37;
            // 
            // tabConfig2
            // 
            this.tabConfig2.Controls.Add(this.groupBox9);
            this.tabConfig2.Controls.Add(this.groupBox3);
            this.tabConfig2.Location = new System.Drawing.Point(4, 22);
            this.tabConfig2.Name = "tabConfig2";
            this.tabConfig2.Padding = new System.Windows.Forms.Padding(3);
            this.tabConfig2.Size = new System.Drawing.Size(707, 456);
            this.tabConfig2.TabIndex = 1;
            this.tabConfig2.Text = "Config2";
            this.tabConfig2.UseVisualStyleBackColor = true;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.button23);
            this.groupBox9.Controls.Add(this.button27);
            this.groupBox9.Controls.Add(this.button26);
            this.groupBox9.Location = new System.Drawing.Point(519, 7);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(182, 440);
            this.groupBox9.TabIndex = 51;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Operation";
            // 
            // tabTest2
            // 
            this.tabTest2.Controls.Add(this.groupBox1);
            this.tabTest2.Location = new System.Drawing.Point(4, 22);
            this.tabTest2.Name = "tabTest2";
            this.tabTest2.Size = new System.Drawing.Size(707, 456);
            this.tabTest2.TabIndex = 3;
            this.tabTest2.Text = "Test2";
            this.tabTest2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.button7);
            this.groupBox1.Controls.Add(this.button8);
            this.groupBox1.Controls.Add(this.button9);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(693, 122);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "示例";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(155, 72);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 5;
            this.button6.Text = "set";
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(24, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 24);
            this.button1.TabIndex = 0;
            this.button1.Text = "open";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(77, 24);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(56, 24);
            this.button2.TabIndex = 1;
            this.button2.Text = "max";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(334, 24);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(56, 24);
            this.button3.TabIndex = 2;
            this.button3.Text = "min";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(124, 24);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(56, 24);
            this.button4.TabIndex = 3;
            this.button4.Text = "close";
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(388, 24);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(56, 24);
            this.button5.TabIndex = 4;
            this.button5.Text = "move";
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(419, 72);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(74, 21);
            this.textBox1.TabIndex = 6;
            this.textBox1.Text = "textBox1";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(315, 72);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 7;
            this.button7.Text = "set";
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(235, 72);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 8;
            this.button8.Text = "plast";
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(515, 72);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(58, 23);
            this.button9.TabIndex = 9;
            this.button9.Text = "clear";
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(24, 72);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 21);
            this.textBox2.TabIndex = 10;
            this.textBox2.Text = "textBox2";
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(720, 487);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "HandleTools";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabHome.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.tabConfig.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.tabBrowser.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tabConfig2.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.tabTest2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion



        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.Run(new Form1());
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
            tbWindowName.Text = "TeamViewer";
            button31_Click(sender, e);
            btnLoadConfig_Click(sender,e);
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            p.StartInfo.FileName = "notepad.exe";
            p.Start();
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            SendMessage(p.MainWindowHandle, WM_SYSCOMMAND, SC_MAXIMIZE, "0");
        }

        private void button5_Click(object sender, System.EventArgs e)
        {
            SendMessage(p.MainWindowHandle, WM_SYSCOMMAND, WM_MOVE, "0");
        }

        private void button6_Click(object sender, System.EventArgs e)
        {
            SendMessage(textBox1.Handle, WM_SETTEXT, 0, textBox2.Text);
        }

        private void button4_Click(object sender, System.EventArgs e)
        {
            p.Kill();
        }

        private void button7_Click(object sender, System.EventArgs e)
        {
            SendMessage(p.MainWindowHandle, WM_SETTEXT, 0, textBox2.Text);
        }

        private void button8_Click(object sender, System.EventArgs e)
        {
            SendMessage(textBox1.Handle, WM_PASTE, 0, "0");
        }

        private void button9_Click(object sender, System.EventArgs e)
        {
            SendMessage(textBox1.Handle, 0x0303, 0, "0");
        }

        private static IntPtr myhwnd = new IntPtr();
        private static string windowName = null;

        private void button10_Click(object sender, System.EventArgs e)
        {
            if (textBox7.Text == "null")
            {
                myhwnd = FindWindow(null, tbWindowName.Text);
            }
            else
            {
                myhwnd = FindWindow(textBox7.Text, tbWindowName.Text);
            }

            setWindowHandle(myhwnd);
            button30_Click(sender, e);
            showResult1(myhwnd.ToInt32(), ((Button)sender).Text);
        }

        private void button12_Click(object sender, System.EventArgs e)
        {
            SendMessage(myhwnd, WM_SYSCOMMAND, SC_MAXIMIZE, null);
            showResult2(myhwnd.ToInt32(), ((Button)sender).Text);
        }

        private void button11_Click(object sender, System.EventArgs e)
        {
            SendMessage(myhwnd, WM_SETTEXT, 0, textBox5.Text);
            showResult1(myhwnd.ToInt32(), ((Button)sender).Text);
        }

        private void button13_Click(object sender, System.EventArgs e)
        {
            SendMessage(myhwnd, WM_CLOSE, 0, null);
            showResult2(myhwnd.ToInt32(), ((Button)sender).Text);
        }

        private void button14_Click(object sender, System.EventArgs e)
        {
            if (myhwnd.ToInt32() != 0 && textBox4.Text != "")
            {
                myControl = GetDlgItem(myhwnd, int.Parse(textBox4.Text));
                tbDlgHandle.Text = myControl.ToString();
            }
            else
            {
                MessageBox.Show("输入有误！", "错误信息");
            }

            showResult2(myControl.ToInt32(), "取得窗口元素");
        }

        private void button15_Click(object sender, System.EventArgs e)
        {
            SendMessage(myControl, WM_SETTEXT, 0, textBox6.Text);
            showResult2(myControl.ToInt32(), ((Button)sender).Text);
        }


       

        private void button16_Click(object sender, System.EventArgs e)
        {
            int lw = SendMessage(myControl, WM_LBUTTONDOWN, 0, null);
            int ww = SendMessage(myControl, WM_LBUTTONUP, 0, null);
            showResult2(myControl.ToInt32(), ((Button)sender).Text);
        }

        private void showResult(Control lab,  int result, string msg = null)
        {
            string title = "";
            if (!String.IsNullOrEmpty(msg))
            {
                title += "[" + msg + "]";
            }

            if (result > 0)
            {
                lab.ForeColor = Color.Green;
            }
            else
            {
                lab.ForeColor = Color.Red;
            }

            title += (result > 0) ? "操作成功" : "操作失败";
            lab.Text = title;
        }

        private void showResult1(int result, string msg = null)
        {
            showResult(labResult, result, msg);
        }

        private void showResult2(int result,string msg="") {
            showResult(labResult2, result, msg);
        }

        private void showResult3(int result, string msg = "")
        {
            showResult(labResult3, result, msg);
        }

        private void button17_Click(object sender, System.EventArgs e)
        {
            myhwnd = new IntPtr(Convert.ToInt32(tbDlgHandle.Text));
            showResult2(myhwnd.ToInt32(),((Button)sender).Text);
        }

        private void button18_Click(object sender, System.EventArgs e)
        {
            ShowWindow(myhwnd, SW_HIDE);
            showResult1(myhwnd.ToInt32(), ((Button)sender).Text);
        }

        private void button19_Click(object sender, System.EventArgs e)
        {
            ShowWindow(myhwnd, SW_SHOWNORMAL);
            showResult1(myhwnd.ToInt32(), ((Button)sender).Text);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            windowName = tbWindowName.Text;
            CallBack myCallBack = new CallBack(Report);
            EnumWindows(myCallBack, 0);

            showResult1(1, ((Button)sender).Text);
        }

        private void button23_Click(object sender, EventArgs e)
        {
            ChildCallBack myCallBack = new ChildCallBack(ChildReport);
            EnumChildWindows(myhwnd, myCallBack, 0);

            groupBox3.Controls.Clear();

            TextBox tb = null;
            int left = 20;
            int top = 80;
            int stopStart = 40;
            for (int i = 0; i < list.Count; i++)
            {

                top = stopStart + i * 30;
                HandleInfo hinfo = (HandleInfo)list[i];

                #region 设置
                tb = new TextBox();
                tb.Name = "tbNo_" + i.ToString();
                tb.Text = i.ToString();
                tb.Left = left;
                tb.Top = top;
                tb.Width = 40;
                groupBox3.Controls.Add(tb);

                tb = new TextBox();
                tb.Name = "tbNoHandle_" + i.ToString();
                tb.Text = hinfo.Handle.ToString();
                tb.Left = left + 60;
                tb.Top = top;
                tb.Width = 60;
                tb.ReadOnly = true;
                groupBox3.Controls.Add(tb);

                tb = new TextBox();
                tb.Name = "tbNoValue_" + i.ToString();
                tb.Text = hinfo.Text;
                tb.Left = left + 140;
                tb.Top = top;
                tb.Width = 140;
                groupBox3.Controls.Add(tb);

                tb = new TextBox();
                tb.Name = "tbNoClassName_" + i.ToString();
                tb.Text = hinfo.ClassName;
                tb.Left = left + 300;
                tb.Top = top;
                tb.Width = 200;
                groupBox3.Controls.Add(tb);

                tb = new TextBox();
                tb.Name = "tbNoRelation_" + i.ToString();
                //tb.Text = "tbNoRelation_" + i.ToString();
                tb.Left = left + 520;
                tb.Top = top;
                tb.Width = 140;


                switch (i)
                {
                    case 0:
                        tb.Text = "open_bank_account";
                        break;

                    case 2:
                        tb.Text = "open_bank_name";
                        break;

                    case 8:
                        tb.Text = "tax_register_no";
                        break;

                    case 9:
                        tb.Text = "user_address";
                        break;

                    case 5:
                        tb.Text = "user_mobile";
                        break;

                    case 14:
                        tb.Text = "title_type";
                        break;

                    case 15:
                        tb.Text = "title_name";
                        break;

                    case 7:
                        //tb.Text = "click";
                        break;

                    default:
                        break;
                }
                #endregion

                groupBox3.Controls.Add(tb);
            }

        }

        public bool Report(int hwnd, int lParam)//static
        {
            Console.Write("Window handle is :");
            Console.WriteLine(hwnd);

            IntPtr lpString = Marshal.AllocHGlobal(200);
            GetWindowText(hwnd, lpString, 200);
            var text = Marshal.PtrToStringAnsi(lpString);

            if (text.EndsWith(windowName))
            {
                Console.WriteLine("----------" + text + "--------------");
                setWindowHandle(new IntPtr(hwnd));

                return false;
            }
            return true;
        }

        private void setWindowHandle(IntPtr hwnd)
        {
            myhwnd = hwnd;// new IntPtr(hwnd);
            tbWindowHandle.Text = myhwnd.ToString();
        }

        static ArrayList list = new ArrayList();

        public bool ChildReport(int hwnd, int lParam)//static
        {
            Console.Write("child handle is :");
            Console.WriteLine(hwnd);

            IntPtr lpString = Marshal.AllocHGlobal(200);
            GetWindowText(hwnd, lpString, 200);
            var text = Marshal.PtrToStringAnsi(lpString);


            IntPtr lpString2 = Marshal.AllocHGlobal(200);
            GetClassName(hwnd, lpString2, 200);
            var className = Marshal.PtrToStringAnsi(lpString2);

            Console.WriteLine("********" + text + "********" + className);
            list.Add(new HandleInfo(new IntPtr(hwnd), text,className));

            return true;
        }

        const int WM_GETTEXT = 0x000D;
        //应用程序发送此消息来复制对应窗口的文本到缓冲区

        const int WM_GETTEXTLENGTH = 0x000E;
        //得到与一个窗口有关的文本的长度（不包含空字符）

        private void button21_Click(object sender, EventArgs e)
        {
            SendMessage(myhwnd, WM_GETTEXTLENGTH, 0, "0");
            showResult2(myhwnd.ToInt32(), ((Button)sender).Text);
        }

        private void button22_Click(object sender, EventArgs e)
        {
            IntPtr lpString2 = Marshal.AllocHGlobal(200);
            SendMessageW2(myControl, WM_GETTEXT, 200, lpString2);
            textBox8.Text = Marshal.PtrToStringAnsi(lpString2);

            showResult2(myControl.ToInt32(), ((Button)sender).Text);
        }


        private ArrayList list2 = new ArrayList();

        private void button26_Click(object sender, EventArgs e)
        {

            Hashtable ht = new Hashtable();

            ht["title_name"] = "红板凳科技股份有限公司";
            ht["title_type"] = "CORPORATION";
            ht["user_mobile"] = "010 - 88096629";
            ht["user_address"] = "北京市海淀区知春路49号七层";
            ht["tax_register_no"] = "91110108067282874H";
            ht["open_bank_name"] = "交通银行北京慧忠里支行";
            ht["open_bank_account"] = "110061538018010080784";

            for (int i = 0; i < list.Count; i++)
            {
                HandleInfo hinfo = (HandleInfo)list[i];
                Control[] cs = groupBox3.Controls.Find("tbNoRelation_" + i, true);
                string relation = ((TextBox)cs[0]).Text;
                if (string.IsNullOrEmpty(relation))
                {
                    continue;
                }

                Control[] cs2 = groupBox3.Controls.Find("tbNoValue_" + i, true);
                TextBox text2 = (TextBox)cs2[0];
                string text = ht[relation].ToString();
                text2.Text = text;

                SendMessage(hinfo.Handle, WM_SETTEXT, 0, text);

            }
        }

        [DllImport("user32.dll")]
        static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint dwData, UIntPtr dwExtraInfo);

        [DllImport("user32.dll")]
        public static extern bool GetCursorPos(out POINT lpPoint);

        [StructLayout(LayoutKind.Sequential)]
        public struct POINT
        {
            public int X;
            public int Y;
            public POINT(int x, int y)
            {
                this.X = x;
                this.Y = y;
            }
        }

        const int WM_CLICK = 0x00F5;//鼠标点击消息，各种消息的数值，可以参考MSDN  
        const int BM_CLICK = 0xF5;

        [DllImport("user32.dll", EntryPoint = "SetForegroundWindow", SetLastError = true)]
        private static extern void SetForegroundWindow(IntPtr hwnd);


        [DllImport("user32.dll", EntryPoint = "GetClassName")]
        public static extern int GetClassName(
            int hwnd,
            IntPtr lpClassName,
            int nMaxCount
        );

        [DllImport("user32.dll", EntryPoint = "FindWindowEx")]
        private static extern IntPtr FindWindowEx(IntPtr hwndParent, IntPtr hwndChildAfter, string lpszClass, string lpszWindow);

        private void button25_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < list.Count; i++)
            {
                HandleInfo hinfo = (HandleInfo)list[i];
                Control[] cs = groupBox3.Controls.Find("tbNoRelation_" + i, true);
                string relation = ((TextBox)cs[0]).Text;
                if (relation.Equals("click"))
                {
                    //int lw = SendMessage(hinfo.Handle, WM_LBUTTONDOWN, 0, null);
                    //int ww = SendMessage(hinfo.Handle, WM_LBUTTONUP, 0, null);

                    SetForegroundWindow(myhwnd);//使主窗体获得焦点  
                    SendMessage(hinfo.Handle, WM_CLICK, 0, "0");//给主窗体上button发送鼠标点击消息，
                    //SendMessage(hinfo.Handle, BM_CLICK, 0, 0);     //发送点击按钮的消息  
                }
            }
            showResult1(myhwnd.ToInt32(), ((Button)sender).Text);

        }

        private void button27_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < list.Count; i++)
            {
                HandleInfo hinfo = (HandleInfo)list[i];
                Control[] cs = groupBox3.Controls.Find("tbNoRelation_" + i, true);
                string relation = ((TextBox)cs[0]).Text;
                if (string.IsNullOrEmpty(relation))
                {
                    continue;
                }
                SendMessage(hinfo.Handle, WM_SETTEXT, 0, "");
            }
        }

        [DllImport("kernel32.dll")]
        static extern uint GetLastError();

        private void button28_Click(object sender, EventArgs e)
        {
            TreeNode node = getNodeByFullIndex(tbButtonNo.Text);
            HandleInfo hinfo = (HandleInfo)node.Tag;
            SetForegroundWindow(myhwnd);//使主窗体获得焦点  
            SendMessage(hinfo.Handle, WM_CLICK, 0, "0");//给主窗体上button发送鼠标点击消息，
            //SendMessage(hinfo.Handle, BM_CLICK, 0, 0);     //发送点击按钮的消息 
            showResult1(1, ((Button)sender).Text);
        }

        private void button29_Click(object sender, EventArgs e)
        {

            IntPtr childHwnd = FindWindowEx(myhwnd, IntPtr.Zero, null, tbChildName.Text);   //获得按钮的句柄  
            //SendMessage(childHwnd, BM_CLICK, 0, "0");     //发送点击按钮的消息 
            SendMessage(childHwnd, BM_CLICK, 0, "0");     //发送点击按钮的消息  
 
            int er1 = (int)GetLastError();
            Console.WriteLine(er1);

            int er = Marshal.GetLastWin32Error();
            Console.WriteLine(er);
            showResult1(childHwnd.ToInt32(), ((Button)sender).Text);
        }

        private void button30_Click(object sender, EventArgs e)
        {
      
            Win32Service service = new Win32Service();
            ArrayList list = service.getChildWindows(myhwnd);
            treeView1.Nodes.Clear();
            //treeView1.Nodes[
            //treeView1.
            for (int i = 0; i < list.Count; i++)
            {
                HandleInfo hinfo = (HandleInfo)list[i];
                TreeNode pnode = new TreeNode();
                pnode.Text ="("+i.ToString()+ ")["+ hinfo.Handle +"][" +  hinfo.Handle.ToString("X8") + "]~" + hinfo.Text + "~" + hinfo.ClassName;
                pnode.Tag = hinfo;
                pnode.Name = hinfo.Handle.ToString();
                //pnode.
                treeView1.Nodes.Add(pnode);
                AddChildnode( pnode);
            }

            showResult3(myhwnd.ToInt32(), ((Button)sender).Text);
        }


        public void AddChildnode(TreeNode pnode)
        {
            HandleInfo thieInfo = (HandleInfo)pnode.Tag;
            Win32Service service = new Win32Service();
            ArrayList list = service.getChildWindows(thieInfo.Handle);
            for (int i = 0; i < list.Count; i++)
            {
                HandleInfo hinfo = (HandleInfo)list[i];
                    TreeNode cnode = new TreeNode();
                    cnode.Text = "("+i.ToString()+ ")[" + hinfo.Handle + "][" + hinfo.Handle.ToString("X8") + "]~" + hinfo.Text + "~" + hinfo.ClassName;
                    cnode.Tag = hinfo;
                    cnode.Name = hinfo.Handle.ToString();
                    pnode.Nodes.Add(cnode);
                    AddChildnode( cnode);
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode node =  e.Node;
            HandleInfo hinfo= (HandleInfo)node.Tag;
            Console.WriteLine(node.FullPath);

            tbFullPath.Text = node.FullPath;
            tbFullIndex.Text = getFullIndex(node);
            tbNodeHandle.Text = hinfo.Handle.ToString();
        }

        private void treeView1_Click(object sender, EventArgs e)
        {

        }


        private string getFullIndex(TreeNode node)
        {
            ArrayList list = new ArrayList();
            string str = "";
            list.Add(node.Index);
            while (node.Parent != null)
            {
                list.Add(node.Parent.Index);
                node = node.Parent;
            }
            list.Reverse();

            for (int i = 0; i < list.Count; i++)
            {
                str = str + ((i == 0) ? "" : ",") + list[i].ToString();
            }
            return str;
        }


        private void btnGetNodeByPath_Click(object sender, EventArgs e)
        {
            TreeNode node = getNodeByFullIndex(tbFullIndex.Text);
            tbSelectedNode.Text = node.FullPath;

            showResult3(myhwnd.ToInt32(), ((Button)sender).Text);
        }


        [DllImport("user32.dll", EntryPoint = "FlashWindow")]
        public static extern int FlashWindow(
            IntPtr hwnd,
            int bInvert
        );

        [DllImport("user32.dll", EntryPoint = "AnimateWindow")]
        public static extern bool AnimateWindow(IntPtr handle, int dwTime, int dwFlags);

        public const Int32 AW_HOR_POSITIVE = 0x00000001;    //自左向右显示窗口。该标志可以在滚动动画和滑动动画中使用。当使用AW_CENTER标志时，该标志将被忽略。
        public const Int32 AW_HOR_NEGATIVE = 0x00000002;    //自右向左显示窗口。该标志可以在滚动动画和滑动动画中使用。当使用AW_CENTER标志时，该标志将被忽略。
        public const Int32 AW_VER_POSITIVE = 0x00000004;    //自顶向下显示窗口。该标志可以在滚动动画和滑动动画中使用。当使用AW_CENTER标志时，该标志将被忽略。
        public const Int32 AW_VER_NEGATIVE = 0x00000008;    //自下向上显示窗口。该标志可以在滚动动画和滑动动画中使用。当使用AW_CENTER标志时，该标志将被忽略。
        public const Int32 AW_CENTER = 0x00000010;          //若使用了AW_HIDE标志，则使窗口向内重叠，即收缩窗口；否则使窗口向外扩展，即展开窗口
        public const Int32 AW_HIDE = 0x00010000;            //隐藏窗口，缺省则显示窗口
        public const Int32 AW_ACTIVATE = 0x00020000;        //激活窗口。在使用了AW_HIDE标志后不要使用这个标志。
        public const Int32 AW_SLIDE = 0x00040000;           //使用滑动类型。缺省则为滚动动画类型。当使用AW_CENTER标志时，这个标志就被忽略。
        public const Int32 AW_BLEND = 0x00080000;           //使用淡出效果。只有当hWnd为顶层窗口的时候才可以使用此标志。

        private IntPtr getHandleByFullIndex(string fullPath) {
            TreeNode node = getNodeByFullIndex(fullPath);
            HandleInfo hinfo = (HandleInfo)node.Tag;
            return hinfo.Handle;
        }

        private TreeNode getNodeByFullIndex(string fullPath)
        {
            string[] nIndexs = fullPath.Split(',');
            int i = 0;
            TreeNodeCollection nodes = treeView1.Nodes;//5.3.1
            TreeNode node = null;
            while (i < nIndexs.Length && nodes != null)
            {
                int il = Convert.ToInt32(nIndexs[i]);
                node = nodes[il];
                if (node.Nodes.Count == 0)
                {
                    break;
                }
                nodes = node.Nodes;
                i++;
            }
            return node;
        }

        private void button31_Click(object sender, EventArgs e)
        {
            GroupBox gb = groupBox5;
            gb.Controls.Clear();

            list = new ArrayList();
            for (int i = 0; i < 10; i++)
            {
                HandleInfo hinfo = new HandleInfo(IntPtr.Zero, i.ToString(), i.ToString());
                list.Add(hinfo);
            }

            TextBox tb = null;
            int left = 20;
            int top = 80;
            int ptop = 5;
            int stopStart = 40;
            for (int i = 0; i < list.Count; i++)
            {
                #region 加载数据
                top = stopStart + i * 40;
                HandleInfo hinfo = (HandleInfo)list[i];

                Panel panel = new Panel();
                panel.Top = top;
                panel.Left = 20;
                panel.Width = 480;
                panel.Height = 34;
                panel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
               
                panel.BorderStyle = BorderStyle.FixedSingle;

                tb = new TextBox();
                tb.Name = "tbNo_" + i.ToString();
                tb.Text = i.ToString();
                tb.Left = left;
                tb.Top = ptop;
                tb.Width = 40;
                tb.ReadOnly = true;
                panel.Controls.Add(tb);

                tb = new TextBox();
                tb.Name = "tbNoHandle_" + i.ToString();
                tb.Text = hinfo.Handle.ToString();
                tb.Left = left + 60;
                tb.Top = ptop;
                tb.Width = 60;
                tb.ReadOnly = true;
                panel.Controls.Add(tb);

                tb = new TextBox();
                tb.Name = "tbNoFullIndex_" + i.ToString();
                //tb.Text = "tbNoRelation_" + i.ToString();
                tb.Left = left + 150;
                tb.Top = ptop;
                tb.Width = 90;
                panel.Controls.Add(tb);

                tb = new TextBox();
                tb.Name = "tbNoLabel_" + i.ToString();
                tb.Text = null;
                tb.Left = left + 250;
                tb.Top = ptop;
                tb.Width = 90;
                panel.Controls.Add(tb);

                tb = new TextBox();
                tb.Name = "tbNoValue_" + i.ToString();
                tb.Text = null;
                tb.Left = left + 350;
                tb.Top = ptop;
                tb.Width = 90;
                panel.Controls.Add(tb);

                #endregion

                gb.Controls.Add(panel);
            }

            showResult1(1, "加载配置");

        }

        private void button32_Click(object sender, EventArgs e)
        {

            Hashtable ht = new Hashtable();

            ht["title_name"] = "红板凳科技股份有限公司";
            ht["title_type"] = "CORPORATION";
            ht["user_mobile"] = "010 - 88096629";
            ht["user_address"] = "北京市海淀区知春路49号七层";
            ht["tax_register_no"] = "91110108067282874H";
            ht["open_bank_name"] = "交通银行北京慧忠里支行";
            ht["open_bank_account"] = "110061538018010080784";

            for (int i = 0; i < groupBox5.Controls.Count; i++)
            {
                Panel panel = (Panel)groupBox5.Controls[i];
                //tbNoFullIndex_
                Control[] cs = panel.Controls.Find("tbNoFullIndex_" + i, true);
                string fullIndex = ((TextBox)cs[0]).Text;
                if (string.IsNullOrEmpty(fullIndex))
                {
                    continue;
                }
                TreeNode node = getNodeByFullIndex(fullIndex);
                HandleInfo hinfo = (HandleInfo)node.Tag;

                //tbNoValue_
                Control[] cs2 = panel.Controls.Find("tbNoValue_" + i, true);
                string text = ((TextBox)cs2[0]).Text;

                SendMessage(hinfo.Handle, WM_SETTEXT, 0, text);
            }
            showResult1(myhwnd.ToInt32(), ((Button)sender).Text);
        }

        private void btnSaveConfig_Click(object sender, EventArgs e)
        {
            MessageBoxButtons messButton = MessageBoxButtons.OKCancel;
            DialogResult dr = MessageBox.Show("确定要保存吗?", "操作", messButton);
            if (dr == DialogResult.OK)//如果点击“确定”按钮
            {

            }
            else//如果点击“取消”按钮
            {
                return;
            }

            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("config.xml");
            XmlElement root = xmlDoc.DocumentElement;

            XmlElement invoice = (XmlElement)xmlDoc.SelectSingleNode("root/invoice");
            if (invoice == null)
            {
                invoice = xmlDoc.CreateElement("invoice");
            }
            invoice.RemoveAll();

            for (int i = 0; i < groupBox5.Controls.Count; i++)
            {
                Panel panel = (Panel)groupBox5.Controls[i];
                //tbNoFullIndex_
                Control[] cs = panel.Controls.Find("tbNoFullIndex_" + i, true);
                string fullIndex = ((TextBox)cs[0]).Text;
                if (cs.Length==0 || string.IsNullOrEmpty(fullIndex))
                {
                    continue;
                }

                //tbNoValue_
                Control[] cs2 = panel.Controls.Find("tbNoValue_" + i, true);
                string text = null;
                if (cs2.Length > 0)
                {
                    text = ((TextBox)cs2[0]).Text;
                }

                Control[] cs3 = panel.Controls.Find("tbNoLabel_" + i, true);
                string label = null;
                if (cs3.Length > 0)
                {
                    label = ((TextBox)cs3[0]).Text;
                }

                XmlElement elem = xmlDoc.CreateElement("elem");
                elem.SetAttribute("no", i.ToString());
                elem.SetAttribute("fullIndex", fullIndex);
                elem.SetAttribute("label", label);
                //elem.SetAttribute("value", text);
                elem.InnerText = text;
                invoice.AppendChild(elem);

            }

            root.AppendChild(invoice);

            xmlDoc.Save("config.xml");
            
        }

        private void btnLoadConfig_Click(object sender, EventArgs e)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("config.xml");
            XmlElement invoice = (XmlElement)xmlDoc.SelectSingleNode("root/invoice");
            if (invoice == null)
            {
                return;
            }

            for (int i = 0; i < groupBox5.Controls.Count; i++)
            {
                XmlElement elem = (XmlElement)invoice.SelectSingleNode("elem[@no=" + i.ToString() + "]");
                Panel panel = (Panel)groupBox5.Controls[i];
                if (elem == null)
                {
                    continue;
                }
                Control[] cs = panel.Controls.Find("tbNo_" + i, true);
                if (cs.Length > 0)
                {
                    cs[0].Text = elem.GetAttribute("no");
                }

                cs = panel.Controls.Find("tbNoFullIndex_" + i, true);
                if (cs.Length > 0)
                {
                    cs[0].Text = elem.GetAttribute("fullIndex");
                }

                cs = panel.Controls.Find("tbNoLabel_" + i, true);
                if (cs.Length>0)
                {
                    cs[0].Text = elem.GetAttribute("label");
                }

                cs = panel.Controls.Find("tbNoValue_" + i, true);
                if (cs.Length > 0)
                {
                    cs[0].Text = elem.InnerText;
                }
            }
        }

        private void button34_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < groupBox5.Controls.Count; i++)
            {
                Panel panel = (Panel)groupBox5.Controls[i];
                //tbNoFullIndex_
                Control[] cs = panel.Controls.Find("tbNoFullIndex_" + i, true);
                string fullIndex = ((TextBox)cs[0]).Text;
                if (string.IsNullOrEmpty(fullIndex))
                {
                    continue;
                }
                TreeNode node = getNodeByFullIndex(fullIndex);
                HandleInfo hinfo = (HandleInfo)node.Tag;

                //tbNoValue_
                Control[] cs2 = panel.Controls.Find("tbNoValue_" + i, true);
                string text = null;// ((TextBox)cs2[0]).Text;

                SendMessage(hinfo.Handle, WM_SETTEXT, 0, text);
            }

            showResult1(myhwnd.ToInt32(), ((Button)sender).Text);
        }

        private void button33_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbNodeHandle.Text))
            {
                myhwnd = new IntPtr(Convert.ToInt32(tbNodeHandle.Text));
            }
            showResult3(myhwnd.ToInt32(), ((Button)sender).Text);
        }

        private void button24_Click(object sender, EventArgs e)
        {
            TreeNode node = (TreeNode)getNodeByFullIndex(tbFullIndex.Text);
            HandleInfo hinfo = (HandleInfo)node.Tag;
            SendMessage(hinfo.Handle, WM_SETTEXT, 0, tbSendText.Text);
            showResult3(hinfo.Handle.ToInt32(), ((Button)sender).Text);
        }

        private void btnFlashWindow_Click(object sender, EventArgs e)
        {
            IntPtr handle = getHandleByFullIndex(tbFullIndex.Text);
            FlashWindow(handle, 1);
            AnimateWindow(handle, 2000, AW_CENTER);
            showResult3(handle.ToInt32(), ((Button)sender).Text);
        }

        private void button35_Click(object sender, EventArgs e)
        {
            IntPtr hwnd = getHandleByFullIndex(tbFullIndex.Text);
            SetForegroundWindow(myhwnd);//使主窗体获得焦点  
            SendMessage(hwnd, WM_CLICK, 0, "0");//给主窗体上button发送鼠标点击消息，
            showResult3(hwnd.ToInt32(), ((Button)sender).Text);
        }

        private void button36_Click(object sender, EventArgs e)
        {
            IntPtr hwnd = getHandleByFullIndex(tbFullIndex.Text);
            SetForegroundWindow(myhwnd);//使主窗体获得焦点  
            //SendMessage(hwnd, WM_CLICK, 0, "0");//给主窗体上button发送鼠标点击消息，
            SendMessage(hwnd, BM_CLICK, 0, "0");     //发送点击按钮的消息
            showResult3(hwnd.ToInt32(), ((Button)sender).Text);
        }

    }
}
