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
using System.Net;
using System.IO;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Show
{

    /// <summary>

    /// Form1 的摘要说明。

    /// </summary>

    public class Form1 : System.Windows.Forms.Form
    {
        private IContainer components;

        #region 声名变量

        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;

        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.TextBox tbWindowName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.TextBox tbDlgId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button15;
        private Process p = new Process();
        private System.Windows.Forms.TextBox tbWindowText;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.TextBox tbWindowClass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button19;
        private GroupBox gbMain;
        private Label labResult2;
        private Label labResult;
        private Button button20;
        private Button button21;
        private Button button22;
        private TextBox textBox8;
        private Label label6;
        private TextBox tbWindowHandle;
        private GroupBox gbWindow;
        private TabControl tabControl1;
        private TabPage tabHome;
        private TabPage tabWindow;
        private TabPage tabBrowser;
        private Label label7;
        private Button button25;
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
        private Button btnTo16;
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
        private GroupBox gbBrowser;
        private Label label10;
        private TabPage tabConfig;
        private GroupBox gbConfig;
        private Button button32;
        private Button btnLoadConfig;
        private Button btnSaveConfig;
        private Button button34;
        private GroupBox gbChild;
        private TextBox tbNodeHandle;
        private Button button33;
        private TextBox tbSetHandle;
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
        private Button button37;
        private Button button38;
        private Button button39;
        private Button button40;
        private Button button41;
        private TextBox tbExclude;
        private Label label5;
        private Button btnFindNode;
        private TextBox tbFindNode;
        private Label label11;
        private CheckBox cbMultiLevel;
        private TextBox tbInclude;
        private Label label12;
        private Button button26;
        private Button button27;
        private Label label13;
        private TextBox tbParentHandle;
        private TextBox tbDlgHandle;
        private Button btnTo10;
        private TextBox tbText16;
        private TextBox tbText10;
        private Button button6;
        private TabPage tabInvoice;
        private GroupBox groupBox2;
        private Button button23;
        private GroupBox groupBox3;
        private Timer timer1;
        private DataGridView dataGridView1;
        private TextBox tbInvoiceUrl;
        private Label label14;
        private Button btnPrintInvoice;
        private Button button31;
        private Label label17;
        private Label label16;
        private Label label15;
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
            this.components = new System.ComponentModel.Container();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.tbWindowName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button14 = new System.Windows.Forms.Button();
            this.tbDlgId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button15 = new System.Windows.Forms.Button();
            this.tbWindowText = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.button16 = new System.Windows.Forms.Button();
            this.tbWindowClass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.gbMain = new System.Windows.Forms.GroupBox();
            this.button30 = new System.Windows.Forms.Button();
            this.button37 = new System.Windows.Forms.Button();
            this.button38 = new System.Windows.Forms.Button();
            this.button34 = new System.Windows.Forms.Button();
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
            this.labResult = new System.Windows.Forms.Label();
            this.tbInclude = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cbMultiLevel = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbExclude = new System.Windows.Forms.TextBox();
            this.button40 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.button22 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.labResult2 = new System.Windows.Forms.Label();
            this.gbWindow = new System.Windows.Forms.GroupBox();
            this.button27 = new System.Windows.Forms.Button();
            this.button26 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabHome = new System.Windows.Forms.TabPage();
            this.gbChild = new System.Windows.Forms.GroupBox();
            this.tbParentHandle = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tbDlgHandle = new System.Windows.Forms.TextBox();
            this.button41 = new System.Windows.Forms.Button();
            this.button39 = new System.Windows.Forms.Button();
            this.tbSetHandle = new System.Windows.Forms.TextBox();
            this.tabConfig = new System.Windows.Forms.TabPage();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.btnLoadConfig = new System.Windows.Forms.Button();
            this.btnSaveConfig = new System.Windows.Forms.Button();
            this.gbConfig = new System.Windows.Forms.GroupBox();
            this.tabWindow = new System.Windows.Forms.TabPage();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.tabBrowser = new System.Windows.Forms.TabPage();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.button36 = new System.Windows.Forms.Button();
            this.labResult3 = new System.Windows.Forms.Label();
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
            this.gbBrowser = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnFindNode = new System.Windows.Forms.Button();
            this.tbFindNode = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.tbFullPath = new System.Windows.Forms.TextBox();
            this.tabInvoice = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button23 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbInvoiceUrl = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabTest2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTo10 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tbText16 = new System.Windows.Forms.TextBox();
            this.btnTo16 = new System.Windows.Forms.Button();
            this.tbText10 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label14 = new System.Windows.Forms.Label();
            this.btnPrintInvoice = new System.Windows.Forms.Button();
            this.button31 = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.gbMain.SuspendLayout();
            this.gbWindow.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabHome.SuspendLayout();
            this.gbChild.SuspendLayout();
            this.tabConfig.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.tabWindow.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.tabBrowser.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.gbBrowser.SuspendLayout();
            this.tabInvoice.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabTest2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(373, 19);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(119, 23);
            this.button10.TabIndex = 11;
            this.button10.Text = "FindWindow";
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(217, 92);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(80, 24);
            this.button11.TabIndex = 12;
            this.button11.Text = "WM_SETTEXT";
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(303, 135);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(80, 24);
            this.button12.TabIndex = 13;
            this.button12.Text = "max";
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(392, 136);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(87, 24);
            this.button13.TabIndex = 14;
            this.button13.Text = "close";
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // tbWindowName
            // 
            this.tbWindowName.Location = new System.Drawing.Point(77, 20);
            this.tbWindowName.Name = "tbWindowName";
            this.tbWindowName.Size = new System.Drawing.Size(112, 21);
            this.tbWindowName.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 16;
            this.label1.Text = "Window：";
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(217, 60);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(80, 23);
            this.button14.TabIndex = 17;
            this.button14.Text = "GetDlgItem";
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // tbDlgId
            // 
            this.tbDlgId.Location = new System.Drawing.Point(77, 60);
            this.tbDlgId.Name = "tbDlgId";
            this.tbDlgId.Size = new System.Drawing.Size(111, 21);
            this.tbDlgId.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 19;
            this.label2.Text = "ID：";
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(217, 97);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(80, 24);
            this.button15.TabIndex = 20;
            this.button15.Text = "WM_SETTEXT";
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // tbWindowText
            // 
            this.tbWindowText.Location = new System.Drawing.Point(76, 92);
            this.tbWindowText.Name = "tbWindowText";
            this.tbWindowText.Size = new System.Drawing.Size(112, 21);
            this.tbWindowText.TabIndex = 21;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(77, 97);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(110, 21);
            this.textBox6.TabIndex = 22;
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(217, 135);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(80, 23);
            this.button16.TabIndex = 23;
            this.button16.Text = "Click";
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // tbWindowClass
            // 
            this.tbWindowClass.Location = new System.Drawing.Point(268, 21);
            this.tbWindowClass.Name = "tbWindowClass";
            this.tbWindowClass.Size = new System.Drawing.Size(99, 21);
            this.tbWindowClass.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(215, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 12);
            this.label3.TabIndex = 25;
            this.label3.Text = "Class：";
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(217, 26);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(80, 24);
            this.button17.TabIndex = 28;
            this.button17.Text = "SetCurrent";
            this.button17.Click += new System.EventHandler(this.button17_Click);
            // 
            // button18
            // 
            this.button18.Location = new System.Drawing.Point(303, 93);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(80, 23);
            this.button18.TabIndex = 29;
            this.button18.Text = "SW_HIDE";
            this.button18.Click += new System.EventHandler(this.button18_Click);
            // 
            // button19
            // 
            this.button19.Location = new System.Drawing.Point(392, 93);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(100, 23);
            this.button19.TabIndex = 30;
            this.button19.Text = "SW_SHOWNORMAL";
            this.button19.Click += new System.EventHandler(this.button19_Click);
            // 
            // gbMain
            // 
            this.gbMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gbMain.Controls.Add(this.button30);
            this.gbMain.Controls.Add(this.button37);
            this.gbMain.Controls.Add(this.button38);
            this.gbMain.Controls.Add(this.button34);
            this.gbMain.Controls.Add(this.label9);
            this.gbMain.Controls.Add(this.button25);
            this.gbMain.Controls.Add(this.button32);
            this.gbMain.Controls.Add(this.label7);
            this.gbMain.Controls.Add(this.label6);
            this.gbMain.Controls.Add(this.tbChildName);
            this.gbMain.Controls.Add(this.tbWindowHandle);
            this.gbMain.Controls.Add(this.button29);
            this.gbMain.Controls.Add(this.button28);
            this.gbMain.Controls.Add(this.tbButtonNo);
            this.gbMain.Controls.Add(this.label8);
            this.gbMain.Controls.Add(this.tbWindowName);
            this.gbMain.Controls.Add(this.button10);
            this.gbMain.Controls.Add(this.button19);
            this.gbMain.Controls.Add(this.button11);
            this.gbMain.Controls.Add(this.button18);
            this.gbMain.Controls.Add(this.label1);
            this.gbMain.Controls.Add(this.labResult);
            this.gbMain.Controls.Add(this.label3);
            this.gbMain.Controls.Add(this.tbWindowClass);
            this.gbMain.Controls.Add(this.tbWindowText);
            this.gbMain.Location = new System.Drawing.Point(6, 6);
            this.gbMain.Name = "gbMain";
            this.gbMain.Size = new System.Drawing.Size(700, 290);
            this.gbMain.TabIndex = 32;
            this.gbMain.TabStop = false;
            this.gbMain.Text = "Main";
            // 
            // button30
            // 
            this.button30.Location = new System.Drawing.Point(503, 19);
            this.button30.Name = "button30";
            this.button30.Size = new System.Drawing.Size(121, 23);
            this.button30.TabIndex = 36;
            this.button30.Text = "EnumChildWindows";
            this.button30.UseVisualStyleBackColor = true;
            this.button30.Click += new System.EventHandler(this.button30_Click);
            // 
            // button37
            // 
            this.button37.Location = new System.Drawing.Point(559, 240);
            this.button37.Name = "button37";
            this.button37.Size = new System.Drawing.Size(120, 23);
            this.button37.TabIndex = 61;
            this.button37.Text = "Save Config";
            this.button37.Click += new System.EventHandler(this.button37_Click);
            // 
            // button38
            // 
            this.button38.Location = new System.Drawing.Point(433, 240);
            this.button38.Name = "button38";
            this.button38.Size = new System.Drawing.Size(120, 23);
            this.button38.TabIndex = 62;
            this.button38.Text = "Load Config";
            this.button38.Visible = false;
            this.button38.Click += new System.EventHandler(this.button38_Click);
            // 
            // button34
            // 
            this.button34.Location = new System.Drawing.Point(343, 127);
            this.button34.Name = "button34";
            this.button34.Size = new System.Drawing.Size(120, 23);
            this.button34.TabIndex = 56;
            this.button34.Text = "Clear Data";
            this.button34.Click += new System.EventHandler(this.button34_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(218, 202);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 12);
            this.label9.TabIndex = 60;
            this.label9.Text = "child：";
            // 
            // button25
            // 
            this.button25.Location = new System.Drawing.Point(470, 164);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(120, 23);
            this.button25.TabIndex = 53;
            this.button25.Text = "Send Click";
            this.button25.Visible = false;
            this.button25.Click += new System.EventHandler(this.button25_Click);
            // 
            // button32
            // 
            this.button32.Location = new System.Drawing.Point(217, 127);
            this.button32.Name = "button32";
            this.button32.Size = new System.Drawing.Size(120, 23);
            this.button32.TabIndex = 52;
            this.button32.Text = "Send Data";
            this.button32.Click += new System.EventHandler(this.button32_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 52;
            this.label7.Text = "text：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 38;
            this.label6.Text = "handle：";
            // 
            // tbChildName
            // 
            this.tbChildName.Location = new System.Drawing.Point(267, 199);
            this.tbChildName.Name = "tbChildName";
            this.tbChildName.Size = new System.Drawing.Size(70, 21);
            this.tbChildName.TabIndex = 59;
            // 
            // tbWindowHandle
            // 
            this.tbWindowHandle.ForeColor = System.Drawing.Color.Red;
            this.tbWindowHandle.Location = new System.Drawing.Point(77, 55);
            this.tbWindowHandle.Name = "tbWindowHandle";
            this.tbWindowHandle.ReadOnly = true;
            this.tbWindowHandle.Size = new System.Drawing.Size(112, 21);
            this.tbWindowHandle.TabIndex = 37;
            // 
            // button29
            // 
            this.button29.Location = new System.Drawing.Point(343, 201);
            this.button29.Name = "button29";
            this.button29.Size = new System.Drawing.Size(120, 23);
            this.button29.TabIndex = 58;
            this.button29.Text = "Send Click";
            this.button29.Click += new System.EventHandler(this.button29_Click);
            // 
            // button28
            // 
            this.button28.Location = new System.Drawing.Point(343, 164);
            this.button28.Name = "button28";
            this.button28.Size = new System.Drawing.Size(120, 23);
            this.button28.TabIndex = 57;
            this.button28.Text = "Send Click";
            this.button28.Click += new System.EventHandler(this.button28_Click);
            // 
            // tbButtonNo
            // 
            this.tbButtonNo.Location = new System.Drawing.Point(267, 164);
            this.tbButtonNo.Name = "tbButtonNo";
            this.tbButtonNo.Size = new System.Drawing.Size(70, 21);
            this.tbButtonNo.TabIndex = 55;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(218, 164);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 12);
            this.label8.TabIndex = 56;
            this.label8.Text = "index：";
            // 
            // labResult
            // 
            this.labResult.AutoSize = true;
            this.labResult.Location = new System.Drawing.Point(218, 58);
            this.labResult.Name = "labResult";
            this.labResult.Size = new System.Drawing.Size(59, 12);
            this.labResult.TabIndex = 26;
            this.labResult.Text = "Result:　";
            // 
            // tbInclude
            // 
            this.tbInclude.Location = new System.Drawing.Point(145, 64);
            this.tbInclude.Name = "tbInclude";
            this.tbInclude.Size = new System.Drawing.Size(219, 21);
            this.tbInclude.TabIndex = 68;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(24, 67);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 12);
            this.label12.TabIndex = 67;
            this.label12.Text = "Include：";
            // 
            // cbMultiLevel
            // 
            this.cbMultiLevel.AutoSize = true;
            this.cbMultiLevel.Location = new System.Drawing.Point(26, 100);
            this.cbMultiLevel.Name = "cbMultiLevel";
            this.cbMultiLevel.Size = new System.Drawing.Size(72, 16);
            this.cbMultiLevel.TabIndex = 66;
            this.cbMultiLevel.Text = "children";
            this.cbMultiLevel.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 12);
            this.label5.TabIndex = 65;
            this.label5.Text = "Exclude Classes：";
            // 
            // tbExclude
            // 
            this.tbExclude.Location = new System.Drawing.Point(145, 31);
            this.tbExclude.Name = "tbExclude";
            this.tbExclude.Size = new System.Drawing.Size(219, 21);
            this.tbExclude.TabIndex = 64;
            // 
            // button40
            // 
            this.button40.Location = new System.Drawing.Point(11, 63);
            this.button40.Name = "button40";
            this.button40.Size = new System.Drawing.Size(160, 23);
            this.button40.TabIndex = 63;
            this.button40.Text = "EnumWindows2";
            this.button40.UseVisualStyleBackColor = true;
            this.button40.Visible = false;
            this.button40.Click += new System.EventHandler(this.button40_Click);
            // 
            // button20
            // 
            this.button20.Location = new System.Drawing.Point(11, 121);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(160, 23);
            this.button20.TabIndex = 31;
            this.button20.Text = "EnumAllWindows";
            this.button20.UseVisualStyleBackColor = true;
            this.button20.Visible = false;
            this.button20.Click += new System.EventHandler(this.button20_Click);
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(77, 135);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(110, 21);
            this.textBox8.TabIndex = 34;
            // 
            // button22
            // 
            this.button22.Location = new System.Drawing.Point(303, 98);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(80, 24);
            this.button22.TabIndex = 33;
            this.button22.Text = "WM_GETTEXT";
            this.button22.Click += new System.EventHandler(this.button22_Click);
            // 
            // button21
            // 
            this.button21.Location = new System.Drawing.Point(392, 99);
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
            this.labResult2.Location = new System.Drawing.Point(531, 104);
            this.labResult2.Name = "labResult2";
            this.labResult2.Size = new System.Drawing.Size(53, 12);
            this.labResult2.TabIndex = 27;
            this.labResult2.Text = "Result2:";
            // 
            // gbWindow
            // 
            this.gbWindow.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gbWindow.Controls.Add(this.cbMultiLevel);
            this.gbWindow.Controls.Add(this.tbInclude);
            this.gbWindow.Controls.Add(this.tbExclude);
            this.gbWindow.Controls.Add(this.label5);
            this.gbWindow.Controls.Add(this.label12);
            this.gbWindow.Location = new System.Drawing.Point(6, 6);
            this.gbWindow.Name = "gbWindow";
            this.gbWindow.Size = new System.Drawing.Size(512, 473);
            this.gbWindow.TabIndex = 49;
            this.gbWindow.TabStop = false;
            this.gbWindow.Text = "Window";
            // 
            // button27
            // 
            this.button27.Location = new System.Drawing.Point(11, 92);
            this.button27.Name = "button27";
            this.button27.Size = new System.Drawing.Size(160, 23);
            this.button27.TabIndex = 70;
            this.button27.Text = "EnumWindows3";
            this.button27.UseVisualStyleBackColor = true;
            this.button27.Visible = false;
            this.button27.Click += new System.EventHandler(this.button27_Click);
            // 
            // button26
            // 
            this.button26.Location = new System.Drawing.Point(11, 34);
            this.button26.Name = "button26";
            this.button26.Size = new System.Drawing.Size(160, 23);
            this.button26.TabIndex = 69;
            this.button26.Text = "EnumWindows";
            this.button26.UseVisualStyleBackColor = true;
            this.button26.Click += new System.EventHandler(this.button26_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabHome);
            this.tabControl1.Controls.Add(this.tabConfig);
            this.tabControl1.Controls.Add(this.tabWindow);
            this.tabControl1.Controls.Add(this.tabBrowser);
            this.tabControl1.Controls.Add(this.tabInvoice);
            this.tabControl1.Controls.Add(this.tabTest2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(720, 514);
            this.tabControl1.TabIndex = 50;
            // 
            // tabHome
            // 
            this.tabHome.Controls.Add(this.gbChild);
            this.tabHome.Controls.Add(this.gbMain);
            this.tabHome.Location = new System.Drawing.Point(4, 22);
            this.tabHome.Name = "tabHome";
            this.tabHome.Padding = new System.Windows.Forms.Padding(3);
            this.tabHome.Size = new System.Drawing.Size(712, 488);
            this.tabHome.TabIndex = 0;
            this.tabHome.Text = "Home";
            this.tabHome.UseVisualStyleBackColor = true;
            // 
            // gbChild
            // 
            this.gbChild.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gbChild.Controls.Add(this.tbParentHandle);
            this.gbChild.Controls.Add(this.label13);
            this.gbChild.Controls.Add(this.tbDlgHandle);
            this.gbChild.Controls.Add(this.button41);
            this.gbChild.Controls.Add(this.button39);
            this.gbChild.Controls.Add(this.button14);
            this.gbChild.Controls.Add(this.tbSetHandle);
            this.gbChild.Controls.Add(this.textBox6);
            this.gbChild.Controls.Add(this.button15);
            this.gbChild.Controls.Add(this.button16);
            this.gbChild.Controls.Add(this.label2);
            this.gbChild.Controls.Add(this.tbDlgId);
            this.gbChild.Controls.Add(this.labResult2);
            this.gbChild.Controls.Add(this.button13);
            this.gbChild.Controls.Add(this.button17);
            this.gbChild.Controls.Add(this.button12);
            this.gbChild.Controls.Add(this.button21);
            this.gbChild.Controls.Add(this.textBox8);
            this.gbChild.Controls.Add(this.button22);
            this.gbChild.Location = new System.Drawing.Point(6, 302);
            this.gbChild.Name = "gbChild";
            this.gbChild.Size = new System.Drawing.Size(700, 180);
            this.gbChild.TabIndex = 51;
            this.gbChild.TabStop = false;
            this.gbChild.Text = "Child";
            // 
            // tbParentHandle
            // 
            this.tbParentHandle.Location = new System.Drawing.Point(392, 29);
            this.tbParentHandle.Name = "tbParentHandle";
            this.tbParentHandle.ReadOnly = true;
            this.tbParentHandle.Size = new System.Drawing.Size(100, 21);
            this.tbParentHandle.TabIndex = 63;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(11, 29);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 12);
            this.label13.TabIndex = 64;
            this.label13.Text = "handle：";
            // 
            // tbDlgHandle
            // 
            this.tbDlgHandle.Location = new System.Drawing.Point(303, 62);
            this.tbDlgHandle.Name = "tbDlgHandle";
            this.tbDlgHandle.ReadOnly = true;
            this.tbDlgHandle.Size = new System.Drawing.Size(100, 21);
            this.tbDlgHandle.TabIndex = 65;
            // 
            // button41
            // 
            this.button41.Location = new System.Drawing.Point(303, 27);
            this.button41.Name = "button41";
            this.button41.Size = new System.Drawing.Size(80, 23);
            this.button41.TabIndex = 63;
            this.button41.Text = "GetParent";
            this.button41.Click += new System.EventHandler(this.button41_Click);
            // 
            // button39
            // 
            this.button39.Location = new System.Drawing.Point(559, 138);
            this.button39.Name = "button39";
            this.button39.Size = new System.Drawing.Size(120, 23);
            this.button39.TabIndex = 62;
            this.button39.Text = "Save Config";
            this.button39.Click += new System.EventHandler(this.button39_Click);
            // 
            // tbSetHandle
            // 
            this.tbSetHandle.Location = new System.Drawing.Point(76, 26);
            this.tbSetHandle.Name = "tbSetHandle";
            this.tbSetHandle.Size = new System.Drawing.Size(111, 21);
            this.tbSetHandle.TabIndex = 37;
            // 
            // tabConfig
            // 
            this.tabConfig.Controls.Add(this.groupBox7);
            this.tabConfig.Controls.Add(this.gbConfig);
            this.tabConfig.Location = new System.Drawing.Point(4, 22);
            this.tabConfig.Name = "tabConfig";
            this.tabConfig.Size = new System.Drawing.Size(712, 488);
            this.tabConfig.TabIndex = 4;
            this.tabConfig.Text = "Config";
            this.tabConfig.UseVisualStyleBackColor = true;
            // 
            // groupBox7
            // 
            this.groupBox7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox7.Controls.Add(this.btnLoadConfig);
            this.groupBox7.Controls.Add(this.btnSaveConfig);
            this.groupBox7.Location = new System.Drawing.Point(522, 6);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(182, 474);
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
            // gbConfig
            // 
            this.gbConfig.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gbConfig.Location = new System.Drawing.Point(6, 6);
            this.gbConfig.Name = "gbConfig";
            this.gbConfig.Size = new System.Drawing.Size(510, 474);
            this.gbConfig.TabIndex = 0;
            this.gbConfig.TabStop = false;
            this.gbConfig.Text = "Config";
            // 
            // tabWindow
            // 
            this.tabWindow.Controls.Add(this.groupBox9);
            this.tabWindow.Controls.Add(this.gbWindow);
            this.tabWindow.Location = new System.Drawing.Point(4, 22);
            this.tabWindow.Name = "tabWindow";
            this.tabWindow.Padding = new System.Windows.Forms.Padding(3);
            this.tabWindow.Size = new System.Drawing.Size(712, 488);
            this.tabWindow.TabIndex = 1;
            this.tabWindow.Text = "Window";
            this.tabWindow.UseVisualStyleBackColor = true;
            // 
            // groupBox9
            // 
            this.groupBox9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox9.Controls.Add(this.button6);
            this.groupBox9.Controls.Add(this.button27);
            this.groupBox9.Controls.Add(this.button26);
            this.groupBox9.Controls.Add(this.button40);
            this.groupBox9.Controls.Add(this.button20);
            this.groupBox9.Location = new System.Drawing.Point(524, 7);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(182, 472);
            this.groupBox9.TabIndex = 51;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Operation";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(11, 418);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(160, 23);
            this.button6.TabIndex = 71;
            this.button6.Text = "Save Config";
            this.button6.Click += new System.EventHandler(this.button6_Click_1);
            // 
            // tabBrowser
            // 
            this.tabBrowser.Controls.Add(this.groupBox8);
            this.tabBrowser.Controls.Add(this.gbBrowser);
            this.tabBrowser.Location = new System.Drawing.Point(4, 22);
            this.tabBrowser.Name = "tabBrowser";
            this.tabBrowser.Size = new System.Drawing.Size(712, 488);
            this.tabBrowser.TabIndex = 2;
            this.tabBrowser.Text = "Browser";
            this.tabBrowser.UseVisualStyleBackColor = true;
            // 
            // groupBox8
            // 
            this.groupBox8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox8.Controls.Add(this.label17);
            this.groupBox8.Controls.Add(this.label16);
            this.groupBox8.Controls.Add(this.label15);
            this.groupBox8.Controls.Add(this.button36);
            this.groupBox8.Controls.Add(this.labResult3);
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
            this.groupBox8.Location = new System.Drawing.Point(518, 6);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(185, 475);
            this.groupBox8.TabIndex = 51;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Operation";
            // 
            // button36
            // 
            this.button36.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button36.Location = new System.Drawing.Point(14, 376);
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
            this.labResult3.Location = new System.Drawing.Point(12, 413);
            this.labResult3.Name = "labResult3";
            this.labResult3.Size = new System.Drawing.Size(53, 12);
            this.labResult3.TabIndex = 65;
            this.labResult3.Text = "Result3:";
            // 
            // btnGetNodeByPath
            // 
            this.btnGetNodeByPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGetNodeByPath.Location = new System.Drawing.Point(14, 148);
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
            this.tbSendText.Location = new System.Drawing.Point(67, 271);
            this.tbSendText.Name = "tbSendText";
            this.tbSendText.Size = new System.Drawing.Size(107, 21);
            this.tbSendText.TabIndex = 62;
            this.tbSendText.Text = "hello";
            // 
            // button35
            // 
            this.button35.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button35.Location = new System.Drawing.Point(14, 347);
            this.button35.Name = "button35";
            this.button35.Size = new System.Drawing.Size(160, 23);
            this.button35.TabIndex = 58;
            this.button35.Text = "Send Click";
            this.button35.Click += new System.EventHandler(this.button35_Click);
            // 
            // btnFlashWindow
            // 
            this.btnFlashWindow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFlashWindow.Location = new System.Drawing.Point(14, 215);
            this.btnFlashWindow.Name = "btnFlashWindow";
            this.btnFlashWindow.Size = new System.Drawing.Size(160, 23);
            this.btnFlashWindow.TabIndex = 64;
            this.btnFlashWindow.Text = "FlashWindow";
            this.btnFlashWindow.Visible = false;
            this.btnFlashWindow.Click += new System.EventHandler(this.btnFlashWindow_Click);
            // 
            // tbSelectedNode
            // 
            this.tbSelectedNode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSelectedNode.Location = new System.Drawing.Point(67, 179);
            this.tbSelectedNode.Name = "tbSelectedNode";
            this.tbSelectedNode.Size = new System.Drawing.Size(107, 21);
            this.tbSelectedNode.TabIndex = 40;
            // 
            // button24
            // 
            this.button24.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button24.Location = new System.Drawing.Point(14, 298);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(160, 23);
            this.button24.TabIndex = 63;
            this.button24.Text = "Send Text";
            this.button24.Click += new System.EventHandler(this.button24_Click);
            // 
            // tbNodeHandle
            // 
            this.tbNodeHandle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbNodeHandle.Location = new System.Drawing.Point(67, 50);
            this.tbNodeHandle.Name = "tbNodeHandle";
            this.tbNodeHandle.Size = new System.Drawing.Size(107, 21);
            this.tbNodeHandle.TabIndex = 43;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 274);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 61;
            this.label4.Text = "text：";
            // 
            // tbFullIndex
            // 
            this.tbFullIndex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbFullIndex.Location = new System.Drawing.Point(67, 121);
            this.tbFullIndex.Name = "tbFullIndex";
            this.tbFullIndex.Size = new System.Drawing.Size(107, 21);
            this.tbFullIndex.TabIndex = 38;
            // 
            // button33
            // 
            this.button33.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button33.Location = new System.Drawing.Point(14, 81);
            this.button33.Name = "button33";
            this.button33.Size = new System.Drawing.Size(160, 23);
            this.button33.TabIndex = 42;
            this.button33.Text = "SetCurrentHandle";
            this.button33.UseVisualStyleBackColor = true;
            this.button33.Click += new System.EventHandler(this.button33_Click);
            // 
            // gbBrowser
            // 
            this.gbBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gbBrowser.Controls.Add(this.label11);
            this.gbBrowser.Controls.Add(this.btnFindNode);
            this.gbBrowser.Controls.Add(this.tbFindNode);
            this.gbBrowser.Controls.Add(this.label10);
            this.gbBrowser.Controls.Add(this.treeView1);
            this.gbBrowser.Controls.Add(this.tbFullPath);
            this.gbBrowser.Location = new System.Drawing.Point(6, 6);
            this.gbBrowser.Name = "gbBrowser";
            this.gbBrowser.Size = new System.Drawing.Size(504, 475);
            this.gbBrowser.TabIndex = 51;
            this.gbBrowser.TabStop = false;
            this.gbBrowser.Text = "Browser";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 23);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 12);
            this.label11.TabIndex = 44;
            this.label11.Text = "Search:";
            // 
            // btnFindNode
            // 
            this.btnFindNode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFindNode.Location = new System.Drawing.Point(338, 20);
            this.btnFindNode.Name = "btnFindNode";
            this.btnFindNode.Size = new System.Drawing.Size(160, 23);
            this.btnFindNode.TabIndex = 43;
            this.btnFindNode.Text = "FindNode";
            this.btnFindNode.UseVisualStyleBackColor = true;
            this.btnFindNode.Click += new System.EventHandler(this.btnFindNode_Click);
            // 
            // tbFindNode
            // 
            this.tbFindNode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbFindNode.Location = new System.Drawing.Point(71, 20);
            this.tbFindNode.Name = "tbFindNode";
            this.tbFindNode.Size = new System.Drawing.Size(261, 21);
            this.tbFindNode.TabIndex = 42;
            this.tbFindNode.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbFindNode_KeyUp);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 53);
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
            this.treeView1.Location = new System.Drawing.Point(6, 77);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(492, 390);
            this.treeView1.TabIndex = 32;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            this.treeView1.Click += new System.EventHandler(this.treeView1_Click);
            // 
            // tbFullPath
            // 
            this.tbFullPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbFullPath.Location = new System.Drawing.Point(71, 50);
            this.tbFullPath.Name = "tbFullPath";
            this.tbFullPath.Size = new System.Drawing.Size(427, 21);
            this.tbFullPath.TabIndex = 37;
            // 
            // tabInvoice
            // 
            this.tabInvoice.Controls.Add(this.groupBox2);
            this.tabInvoice.Controls.Add(this.groupBox3);
            this.tabInvoice.Location = new System.Drawing.Point(4, 22);
            this.tabInvoice.Name = "tabInvoice";
            this.tabInvoice.Size = new System.Drawing.Size(712, 488);
            this.tabInvoice.TabIndex = 5;
            this.tabInvoice.Text = "Invoice";
            this.tabInvoice.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.button31);
            this.groupBox2.Controls.Add(this.btnPrintInvoice);
            this.groupBox2.Controls.Add(this.button23);
            this.groupBox2.Location = new System.Drawing.Point(523, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(182, 474);
            this.groupBox2.TabIndex = 53;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Operation";
            // 
            // button23
            // 
            this.button23.Location = new System.Drawing.Point(11, 43);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(160, 23);
            this.button23.TabIndex = 54;
            this.button23.Text = "Load Invoice";
            this.button23.Click += new System.EventHandler(this.button23_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.tbInvoiceUrl);
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(7, 7);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(510, 474);
            this.groupBox3.TabIndex = 52;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Invoice";
            // 
            // tbInvoiceUrl
            // 
            this.tbInvoiceUrl.Location = new System.Drawing.Point(60, 20);
            this.tbInvoiceUrl.Name = "tbInvoiceUrl";
            this.tbInvoiceUrl.Size = new System.Drawing.Size(439, 21);
            this.tbInvoiceUrl.TabIndex = 1;
            this.tbInvoiceUrl.Text = "http://dev.hbdworld.com.cn/company_v2/invoice/getprint?shop_id=468";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 47);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(498, 421);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // tabTest2
            // 
            this.tabTest2.Controls.Add(this.groupBox1);
            this.tabTest2.Location = new System.Drawing.Point(4, 22);
            this.tabTest2.Name = "tabTest2";
            this.tabTest2.Size = new System.Drawing.Size(712, 488);
            this.tabTest2.TabIndex = 3;
            this.tabTest2.Text = "Test2";
            this.tabTest2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnTo10);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.tbText16);
            this.groupBox1.Controls.Add(this.btnTo16);
            this.groupBox1.Controls.Add(this.tbText10);
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
            this.groupBox1.Size = new System.Drawing.Size(698, 203);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "示例";
            // 
            // btnTo10
            // 
            this.btnTo10.Location = new System.Drawing.Point(264, 157);
            this.btnTo10.Name = "btnTo10";
            this.btnTo10.Size = new System.Drawing.Size(75, 23);
            this.btnTo10.TabIndex = 33;
            this.btnTo10.Text = " 10进制<<";
            this.btnTo10.Click += new System.EventHandler(this.btnTo10_Click);
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
            // tbText16
            // 
            this.tbText16.Location = new System.Drawing.Point(360, 142);
            this.tbText16.Name = "tbText16";
            this.tbText16.Size = new System.Drawing.Size(100, 21);
            this.tbText16.TabIndex = 32;
            this.tbText16.Text = "textBox4";
            // 
            // btnTo16
            // 
            this.btnTo16.Location = new System.Drawing.Point(264, 128);
            this.btnTo16.Name = "btnTo16";
            this.btnTo16.Size = new System.Drawing.Size(75, 23);
            this.btnTo16.TabIndex = 5;
            this.btnTo16.Text = ">> 16进制";
            this.btnTo16.Click += new System.EventHandler(this.btnTo16_Click);
            // 
            // tbText10
            // 
            this.tbText10.Location = new System.Drawing.Point(145, 140);
            this.tbText10.Name = "tbText10";
            this.tbText10.Size = new System.Drawing.Size(100, 21);
            this.tbText10.TabIndex = 11;
            this.tbText10.Text = "textBox3";
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
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(15, 23);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(29, 12);
            this.label14.TabIndex = 2;
            this.label14.Text = "Url:";
            // 
            // btnPrintInvoice
            // 
            this.btnPrintInvoice.Location = new System.Drawing.Point(11, 72);
            this.btnPrintInvoice.Name = "btnPrintInvoice";
            this.btnPrintInvoice.Size = new System.Drawing.Size(160, 23);
            this.btnPrintInvoice.TabIndex = 55;
            this.btnPrintInvoice.Text = "Print Invoice";
            this.btnPrintInvoice.Click += new System.EventHandler(this.btnPrintInvoice_Click);
            // 
            // button31
            // 
            this.button31.Location = new System.Drawing.Point(11, 101);
            this.button31.Name = "button31";
            this.button31.Size = new System.Drawing.Size(160, 23);
            this.button31.TabIndex = 56;
            this.button31.Text = "Set Print Result";
            this.button31.Visible = false;
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(12, 53);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(53, 12);
            this.label15.TabIndex = 67;
            this.label15.Text = "handle：";
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(12, 124);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(41, 12);
            this.label16.TabIndex = 68;
            this.label16.Text = "path：";
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(18, 182);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(41, 12);
            this.label17.TabIndex = 69;
            this.label17.Text = "node：";
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(720, 514);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "HandleTools";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbMain.ResumeLayout(false);
            this.gbMain.PerformLayout();
            this.gbWindow.ResumeLayout(false);
            this.gbWindow.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabHome.ResumeLayout(false);
            this.gbChild.ResumeLayout(false);
            this.gbChild.PerformLayout();
            this.tabConfig.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.tabWindow.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.tabBrowser.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.gbBrowser.ResumeLayout(false);
            this.gbBrowser.PerformLayout();
            this.tabInvoice.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
            //tbWindowName.Text = "TeamViewer";
            
            LoadConfig(gbMain, "main");
            LoadConfig(gbChild, "child");
            SaveConfig(gbWindow, "window");

            LoadConfigControls();
            LoadConfigConfig();
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
            string lpClassName = string.IsNullOrEmpty(tbWindowClass.Text) ? null : tbWindowClass.Text;
            string lpWindowName = string.IsNullOrEmpty(tbWindowName.Text) ? null : tbWindowName.Text;
            myhwnd = FindWindow(lpClassName, lpWindowName);

            setWindowHandle(myhwnd);
            //button30_Click(sender, e);
            showResult1(myhwnd.ToInt32(), ((Button)sender).Text);
        }

        private void button12_Click(object sender, System.EventArgs e)
        {
            SendMessage(myhwnd, WM_SYSCOMMAND, SC_MAXIMIZE, null);
            showResult2(myhwnd.ToInt32(), ((Button)sender).Text);
        }

        private void button11_Click(object sender, System.EventArgs e)
        {
            SendMessage(myhwnd, WM_SETTEXT, 0, tbWindowText.Text);
            showResult1(myhwnd.ToInt32(), ((Button)sender).Text);
        }

        private void button13_Click(object sender, System.EventArgs e)
        {
            SendMessage(myhwnd, WM_CLOSE, 0, null);
            showResult2(myhwnd.ToInt32(), ((Button)sender).Text);
        }

        private void button14_Click(object sender, System.EventArgs e)
        {
            if (myhwnd.ToInt32() != 0 && tbDlgId.Text != "")
            {
                myControl = GetDlgItem(myhwnd, int.Parse(tbDlgId.Text));
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

        private void showResult(Control lab, int result, string msg = null)
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

        private void showResult2(int result, string msg = "")
        {
            showResult(labResult2, result, msg);
        }

        private void showResult3(int result, string msg = "")
        {
            showResult(labResult3, result, msg);
        }

        private void button17_Click(object sender, System.EventArgs e)
        {
            myhwnd = new IntPtr(Convert.ToInt32(tbSetHandle.Text));
            showResult2(myhwnd.ToInt32(), ((Button)sender).Text);
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


        private ArrayList tlist = new ArrayList();
        private void button20_Click(object sender, EventArgs e)
        {
            Win32Service ws = new Win32Service();
            InitExclude(ws);

            ArrayList plist = GetTreeViewData(ws);
            tlist = plist;
            CreateTreeView(IntPtr.Zero, plist);
            showResult1(1, ((Button)sender).Text);
        }

        private ArrayList GetTreeViewData(Win32Service ws)
        {
            //Win32Service ws = new Win32Service();
            ArrayList plist = ws.getEnumWindows();
            for (int i = 0; i < plist.Count; i++)
            {
                HandleInfo hinfo = (HandleInfo)plist[i];
                if (cbMultiLevel.Checked)
                {
                    if (ws.include.Count > 0)
                    {
                        if (ws.include.Exists(item => hinfo.Text.Contains(item)))
                        {
                            ArrayList clist = ws.getEnumChildWindows(hinfo.Handle);
                            plist.AddRange(clist);
                        }
                    }
                    else
                    {
                        ArrayList clist = ws.getEnumChildWindows(hinfo.Handle);
                        plist.AddRange(clist);
                    }
                }
            }

            //Console.Clear();
            for (int i = 0; i < plist.Count; i++)
            {
                HandleInfo hinfo = plist[i] as HandleInfo;
                hinfo.Index = i;
                Console.WriteLine(HandleInfo.getNodeShow(hinfo));
            }
            return plist;
        }

        private void InitExclude(Win32Service ws)
        {
            //exclude
            ws.exclude.Clear();
            if (!string.IsNullOrEmpty(tbExclude.Text))
            {
                string[] xs = tbExclude.Text.Split(',');
                ws.exclude.AddRange(xs);
            }

            //include
            ws.include.Clear();
            if (!string.IsNullOrEmpty(tbInclude.Text))
            {
                string[] xs = tbInclude.Text.Split(',');
                ws.include.AddRange(xs);
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
            list.Add(new HandleInfo(new IntPtr(hwnd), text, className));

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
                Control[] cs = gbWindow.Controls.Find("tbNoRelation_" + i, true);
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
            ArrayList plist = service.getEnumChildWindows(myhwnd);
            tlist = plist;
            CreateTreeView(myhwnd, plist);

            showResult3(myhwnd.ToInt32(), ((Button)sender).Text);
        }

        private void CreateTreeView(IntPtr rhwnd, ArrayList data)
        {
            var service = new Win32Service();
            ArrayList list = service.getChildWindows(rhwnd, data);
            treeView1.Nodes.Clear();
            for (int i = 0; i < list.Count; i++)
            {
                HandleInfo hinfo = (HandleInfo)list[i];
                hinfo.Index = i;
                TreeNode pnode = new TreeNode();
                pnode.Text = HandleInfo.getNodeShow(hinfo);
                pnode.Tag = hinfo;
                pnode.Name = hinfo.Handle.ToString();
                //pnode.
                treeView1.Nodes.Add(pnode);
                AddChildnode(pnode, data);
            }
        }

   


        public void AddChildnode(TreeNode pnode,ArrayList data)
        {
            HandleInfo thieInfo = (HandleInfo)pnode.Tag;
            Win32Service service = new Win32Service();
            if (thieInfo.Handle.ToInt32() == 2557448)
            {
                string s = "";
            }
            ArrayList list = service.getChildWindows(thieInfo.Handle,data);
            for (int i = 0; i < list.Count; i++)
            {
                HandleInfo hinfo = (HandleInfo)list[i];
                hinfo.Index = i;
                TreeNode cnode = new TreeNode();
                cnode.Text = HandleInfo.getNodeShow(hinfo);
                cnode.Tag = hinfo;
                cnode.Name = hinfo.Handle.ToString();
                pnode.Nodes.Add(cnode);
                AddChildnode(cnode,data);
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode node = e.Node;
            HandleInfo hinfo = (HandleInfo)node.Tag;
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

        private IntPtr getHandleByFullIndex(string fullPath)
        {
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

        private void LoadConfigControls()
        {
            GroupBox gb = gbConfig;
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
        }

        private void button32_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < gbConfig.Controls.Count; i++)
            {
                Panel panel = (Panel)gbConfig.Controls[i];
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
            showResult1(1, ((Button)sender).Text);
        }

        private static Hashtable getCompanyInfo()
        {
            Hashtable ht = new Hashtable();

            ht["title_name"] = "红板凳科技股份有限公司";
            ht["title_type"] = "CORPORATION";
            ht["user_mobile"] = "010 - 88096629";
            ht["user_address"] = "北京市海淀区知春路49号七层";
            ht["tax_register_no"] = "91110108067282874H";
            ht["open_bank_name"] = "交通银行北京慧忠里支行";
            ht["open_bank_account"] = "110061538018010080784";
            return ht;
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

            for (int i = 0; i < gbConfig.Controls.Count; i++)
            {
                Panel panel = (Panel)gbConfig.Controls[i];
                //tbNoFullIndex_
                Control[] cs = panel.Controls.Find("tbNoFullIndex_" + i, true);
                string fullIndex = ((TextBox)cs[0]).Text;
                if (cs.Length == 0 || string.IsNullOrEmpty(fullIndex))
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
            LoadConfigConfig();
        }

        private void LoadConfigConfig()
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("config.xml");
            XmlElement invoice = (XmlElement)xmlDoc.SelectSingleNode("root/invoice");
            if (invoice == null)
            {
                return;
            }

            for (int i = 0; i < gbConfig.Controls.Count; i++)
            {
                XmlElement elem = (XmlElement)invoice.SelectSingleNode("elem[@no='" + i.ToString() + "']");
                Panel panel = (Panel)gbConfig.Controls[i];
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
                if (cs.Length > 0)
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
            for (int i = 0; i < gbConfig.Controls.Count; i++)
            {
                Panel panel = (Panel)gbConfig.Controls[i];
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

        private void button37_Click(object sender, EventArgs e)
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

            SaveConfig(gbMain, "main");
        }

        private static void SaveConfig(Control gb, string configNode)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("config.xml");
            XmlElement root = xmlDoc.DocumentElement;
            XmlElement saveNode = (XmlElement)xmlDoc.SelectSingleNode("root/" + configNode);
            if (saveNode == null)
            {
                saveNode = xmlDoc.CreateElement(configNode);
            }
            saveNode.RemoveAll();

            for (int i = 0; i < gb.Controls.Count; i++)
            {
                Control con = gb.Controls[i];
                if (con.GetType() == typeof(TextBox))
                {
                    XmlElement elem = xmlDoc.CreateElement("elem");
                    elem.SetAttribute("name", con.Name);
                    elem.SetAttribute("text", con.Text);
                    //elem.InnerText = con.Text;
                    saveNode.AppendChild(elem);
                }
            }
            root.AppendChild(saveNode);
            xmlDoc.Save("config.xml");
        }

        private static void LoadConfig(Control gb, string configNode)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("config.xml");
            XmlElement invoice = (XmlElement)xmlDoc.SelectSingleNode("root/" + configNode);
            if (invoice == null)
            {
                return;
            }

            for (int i = 0; i < gb.Controls.Count; i++)
            {
                Control con = gb.Controls[i];
                XmlElement elem = (XmlElement)invoice.SelectSingleNode("elem[@name='" + con.Name + "']");
                if (elem == null)
                {
                    continue;
                }

                if (con.GetType() == typeof(TextBox))
                {
                    con.Text = elem.GetAttribute("text");
                }
            }
        }

        private void button38_Click(object sender, EventArgs e)
        {
            LoadConfig(gbMain, "main");
        }

        private void button39_Click(object sender, EventArgs e)
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

            SaveConfig(gbChild, "child");
        }

        private void button40_Click(object sender, EventArgs e)
        {
            Win32Service ws = new Win32Service();
            InitExclude(ws);
            ArrayList plist = ws.getEnumWindows2(IntPtr.Zero);
            tlist = plist;
            CreateTreeView(IntPtr.Zero, plist);

            showResult1(list.Count, ((Button)sender).Text);
        }

        [DllImport("user32.dll", EntryPoint = "GetParent")]
        public static extern int GetParent(
            int hwnd
        );

        private void button41_Click(object sender, EventArgs e)
        {
            int parent = GetParent(Convert.ToInt32(tbSetHandle.Text));
            tbParentHandle.Text = parent + "-" + parent.ToString("X8");
        }

        private void btnFindNode_Click(object sender, EventArgs e)
        {
            CreateTreeView(myhwnd, tlist);
            if (!string.IsNullOrEmpty(tbFindNode.Text))
            {
                List<TreeNode> otree = new List<TreeNode>();
                TreeNodeCollection cs = treeView1.Nodes;
                foreach (TreeNode node in cs)
                {
                    otree.Add((TreeNode)node.Clone());
                }

                treeView1.Nodes.Clear();
                for (int i = 0; i < otree.Count; i++)
                {
                    TreeNode node = otree[i];
                    HandleInfo hinfo = node.Tag as HandleInfo;
                    if (hinfo.Text.Contains(tbFindNode.Text))
                    {
                        treeView1.Nodes.Add(node);
                    }
                }
                treeView1.ExpandAll();
            }
           
        }

        private void button26_Click(object sender, EventArgs e)
        {
            Win32Service ws = new Win32Service();
            //InitExclude(ws);
            ArrayList plist = ws.getEnumWindows();
            tlist = plist;
            CreateTreeView(IntPtr.Zero, plist);
            showResult1(1, ((Button)sender).Text);
        }

        private void button27_Click(object sender, EventArgs e)
        {
            Win32Service service = new Win32Service();
            ArrayList plist = service.getEnumChildWindows(IntPtr.Zero);
            tlist = plist;
            CreateTreeView(IntPtr.Zero, plist);
            showResult3(myhwnd.ToInt32(), ((Button)sender).Text);
        }

        private void btnTo16_Click(object sender, EventArgs e)
        {
            try {
                tbText16.Text = "";
                tbText16.Text = Convert.ToInt32(tbText10.Text).ToString("X8");
            }
            catch(Exception ex){
            }
            
        }

        private void btnTo10_Click(object sender, EventArgs e)
        {
            try
            {
                tbText10.Text = "";
                //int i= Convert.ToString(tbText16.Text,);
               // tbText10.Text = .ToString() ;
            }
            catch (Exception ex)
            {
            }
        }

        private void tbFindNode_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Control || e.KeyCode == Keys.Enter)
            {
                btnFindNode_Click(sender,e);
            }
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            MessageBoxButtons messButton = MessageBoxButtons.OKCancel;
            DialogResult dr = MessageBox.Show("确定要保存吗?", "操作", messButton);
            if (dr == DialogResult.OK)//如果点击“确定”按钮
            {
                SaveConfig(gbWindow, "window");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
 
        }

        private void button23_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            HttpWebRequest req = (HttpWebRequest)HttpWebRequest.Create(tbInvoiceUrl.Text);
            req.Method = "GET";
            using (WebResponse wr = req.GetResponse())
            {
                //在这里对接收到的页面内容进行处理
                string html = new StreamReader(wr.GetResponseStream(), Encoding.GetEncoding("gb2312")).ReadToEnd();
                Console.WriteLine(html);
                wr.Close();

                JObject json1 = (JObject)JsonConvert.DeserializeObject(html);
                string code  = (string)json1["code"];
                JArray data = (JArray)json1["data"];
                string message = (string)json1["message"];
                DataRow dr = null;
                foreach (JObject item in data)
                {
                    //column
                    if (dt.Columns.Count==0)
                    {
                        foreach (JProperty p in item.Properties())
                        {
                            dt.Columns.Add(p.Name);
                        }
                    }

                    //add row
                    dr = dt.NewRow();
                    foreach (JProperty p in item.Properties())
                    {
                        dr[p.Name] = p.Value;
                    }
                    dt.Rows.Add(dr);

                    //string id = (string)item.Property("id");
                }

                dataGridView1.DataSource = dt;
            }
           
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {

        }

        private void btnPrintInvoice_Click(object sender, EventArgs e)
        {
             DataGridViewRow row =  dataGridView1.SelectedRows[0];
             DataGridViewCellCollection cells = row.Cells;

             //Hashtable ht = new Hashtable();
             //ht["title_name"] = cells["title_name"];//"红板凳科技股份有限公司";
             //ht["title_type"] = cells["title_type"];// "CORPORATION";
             //ht["user_mobile"] = cells["user_mobile"];//"010 - 88096629";
             //ht["user_address"] = cells["user_address"];//"北京市海淀区知春路49号七层";
             //ht["tax_register_no"] = cells["tax_register_no"];//"91110108067282874H";
             //ht["open_bank_name"] = cells["open_bank_name"];//"交通银行北京慧忠里支行";
             //ht["open_bank_account"] = cells["open_bank_account"];//"110061538018010080784";

             for (int i = 0; i < gbConfig.Controls.Count; i++)
             {
                 Panel panel = (Panel)gbConfig.Controls[i];
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
                 Control[] cs2 = panel.Controls.Find("tbNoLabel_" + i, true);
                 string label = ((TextBox)cs2[0]).Text;

                 if (cells == null || cells[label] == null)
                 {
                     continue;
                 }

                 SendMessage(hinfo.Handle, WM_SETTEXT, 0, cells[label].Value.ToString());
             }
             showResult1(1, ((Button)sender).Text);


        }

      
    }
}
