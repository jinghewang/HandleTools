using System;
using System.Collections.Generic;
using System.Text;

namespace Show
{
    class HandleInfo
    {

        private int index;

        public int Index
        {
            get { return index; }
            set { index = value; }
        }

        private int parent;

        public int Parent
        {
            get { return parent; }
            set { parent = value; }
        }

        private IntPtr handle;

        public IntPtr Handle
        {
            get { return handle; }
            set { handle = value; }
        }

        //private IntPtr handle;

        public string Handle2
        {
            get { return handle.ToString("X8"); }
           // set { handle = value; }
        }

        private string text;

        public string Text
        {
            get { return text; }
            set { text = value; }
        }

        private string value;

        public string Value
        {
            get { return this.value; }
            set { this.value = value; }
        }

        private string className;

        public string ClassName
        {
            get { return this.className; }
            set { this.className = value; }
        }

        public HandleInfo(IntPtr handle,string text)
        {
            //this.Index = index;
            this.Handle = handle;
            this.Text = text;
        }

        public HandleInfo(IntPtr handle, string text,string className)
        {
            //this.Index = index;
            this.Handle = handle;
            this.Text = text;
            this.ClassName = className;
        }

    }
}
