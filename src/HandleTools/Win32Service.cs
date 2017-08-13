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

        ArrayList toplist = null;
        public ArrayList getAllTopWindows(int y=0)
        {
            toplist = new ArrayList();
            CallBack myCallBack = new CallBack(TopReport);
            EnumWindows(myCallBack, y);
            return toplist;
        }

        public ArrayList getEnumChildWindows(IntPtr myhwnd)
        {
            list = new ArrayList();
            ChildCallBack myCallBack = new ChildCallBack(ChildReport);
            EnumChildWindows(myhwnd, myCallBack, 0);
            return list;
        }

        public ArrayList getChildWindows(IntPtr myhwnd,ArrayList data)
        {
            ArrayList list2 = new ArrayList();
            for (int i = 0; i < data.Count; i++)
            {
                HandleInfo hinfo = (HandleInfo)data[i];
                if (hinfo.Parent == myhwnd.ToInt32())
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


        public bool TopReport(int hwnd, int lParam)//static
        {
            //Console.Write("child handle is :");
            //Console.WriteLine(hwnd);

            IntPtr lpString2 = Marshal.AllocHGlobal(200);
            GetClassName(hwnd, lpString2, 200);
            var className = Marshal.PtrToStringAnsi(lpString2);
            if (exclude.Count > 0 && exclude.Contains(className))
                return true;

            IntPtr lpString = Marshal.AllocHGlobal(200);
            GetWindowText(hwnd, lpString, 200);
            var text = Marshal.PtrToStringAnsi(lpString);

            int parent = GetParent(hwnd);

            HandleInfo hinfo = new HandleInfo(new IntPtr(hwnd), text, className);
            hinfo.Parent = parent;

            Console.WriteLine("--hwnd:" + hinfo.Handle + " handle2:" + hinfo.Handle2 + " parent:" + hinfo.Parent + " parent2:" + hinfo.Parent2 + " text:" + text + " class:" + className);

            toplist.Add(hinfo);
            return true;
        }

        public List<String> exclude = new List<string>();

        public List<String> include = new List<string>();

        public bool children = false;

        public bool ChildReport(int hwnd, int lParam)//static
        {
            //Console.Write("child handle is :");
            //Console.WriteLine(hwnd);
            IntPtr lpString2 = Marshal.AllocHGlobal(200);
            GetClassName(hwnd, lpString2, 200);
            var className = Marshal.PtrToStringAnsi(lpString2);
            if (exclude.Count > 0 && exclude.Contains(className))
                return true;

            IntPtr lpString = Marshal.AllocHGlobal(200);
            GetWindowText(hwnd, lpString, 200);
            var text = Marshal.PtrToStringAnsi(lpString);

            int parent = GetParent(hwnd);

            HandleInfo hinfo = new HandleInfo(new IntPtr(hwnd), text, className);
            hinfo.Parent = parent;

            Console.WriteLine("--hwnd:" + hinfo.Handle + " handle2:" + hinfo.Handle2 + " parent:" + hinfo.Parent + " parent2:" + hinfo.Parent2 + " text:" + text + " class:" + className);

            list.Add(hinfo);
            return true;
        }

        [DllImport("user32.dll", EntryPoint = "FindWindowEx")]
        private static extern IntPtr FindWindowEx(IntPtr hwndParent, IntPtr hwndChildAfter, string lpszClass, string lpszWindow);

        public ArrayList getChildrenWindows(IntPtr ParentHandle)
        {
            Win32Service ws = new Win32Service();
            ArrayList list = new ArrayList();
            IntPtr ChildHandle = IntPtr.Zero;
            ChildHandle = FindWindowEx(ParentHandle, ChildHandle, null, null);

            int i = 0;
            while (ChildHandle.ToInt32() > 0)
            {
                IntPtr lpString2 = Marshal.AllocHGlobal(200);
                GetClassName(ChildHandle.ToInt32(), lpString2, 200);
                var className = Marshal.PtrToStringAnsi(lpString2);
                if (exclude.Count > 0 && exclude.Contains(className)) {
                    ChildHandle = FindWindowEx(ParentHandle, ChildHandle, null, null);
                    continue;
                }

                IntPtr lpString = Marshal.AllocHGlobal(200);
                GetWindowText(ChildHandle.ToInt32(), lpString, 200);
                var text = Marshal.PtrToStringAnsi(lpString);

                if (ws.children && (ws.include.Count > 0 && ws.include.Exists(item => text.Contains(item))))
                { 
                }

                HandleInfo hinfo = new HandleInfo(ChildHandle, text);
                hinfo.ClassName = className;
                list.Add(hinfo);

                Console.WriteLine("i:" + i.ToString() + " handle:" + hinfo.Handle.ToString() + " handle2:" + hinfo.Handle2 + " text: " + hinfo.Text + " class:" + hinfo.ClassName);
                i++;
                ChildHandle = FindWindowEx(ParentHandle, ChildHandle, null, null);
            }

            //int i2 = list.Count;
            return list;
        }
        

     }



}
