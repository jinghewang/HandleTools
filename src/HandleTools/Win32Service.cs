using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using System.Collections;

namespace Show
{
    class Win32Service
    {

        public delegate bool CallBack(int hwnd, int lParam);

        [DllImport("user32")]
        public static extern int EnumWindows(CallBack x, int y);

        public delegate bool ChildCallBack(int hwnd, int lParam);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool EnumChildWindows(IntPtr hwndParent, ChildCallBack x, int lParam);

        [DllImport("user32.dll")]
        public static extern int GetWindowText(int hWnd, IntPtr lpString, int nMaxCount);


        [DllImport("user32.dll", EntryPoint = "GetClassName")]
        public static extern int GetClassName(
            int hwnd,
            IntPtr lpClassName,
            int nMaxCount
        );

        public ArrayList getChildWindows(IntPtr myhwnd)
        {
            list = new ArrayList();
            ArrayList list2 = new ArrayList();
            ChildCallBack myCallBack = new ChildCallBack(ChildReport);
            EnumChildWindows(myhwnd, myCallBack, 0);
            for (int i = 0; i < list.Count; i++)
            {
                HandleInfo hinfo = (HandleInfo)list[i];
                if (hinfo.Parent ==myhwnd.ToInt32() )
                {
                    list2.Add(hinfo);
                }
            }
            return list2;
        }

        private ArrayList list = null;

        [DllImport("user32.dll", EntryPoint = "GetParent")]
        public static extern int GetParent(
            int hwnd
        );

        public bool ChildReport(int hwnd, int lParam)//static
        {
            Console.Write("child handle is :");
            Console.WriteLine(hwnd);

            IntPtr lpString = Marshal.AllocHGlobal(200);
            GetWindowText(hwnd, lpString, 200);
            var text = Marshal.PtrToStringAnsi(lpString);

            IntPtr lpString2 = Marshal.AllocHGlobal(200);
            GetClassName(hwnd, lpString2, 200);
            var className =  Marshal.PtrToStringAnsi(lpString2);

            int parent = GetParent(hwnd);

            HandleInfo hinfo = new HandleInfo(new IntPtr(hwnd), text, className);
            hinfo.Parent = parent;

            Console.WriteLine("********" + text + "********" + className);

            Console.WriteLine("--hwnd:" + hwnd + " parent:" + parent);

            if (parent == hwnd)
            {
                
            }
            list.Add(hinfo);
            return true;
        }
        

     }
}
