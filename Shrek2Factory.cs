using System.Diagnostics;
using System.Reflection;
using System.Windows.Forms;
using System.Xml;
using LiveSplit.UI;
using LiveSplit.UI.Components;
using System;
using LiveSplit.Model;

namespace LiveSplit.Shrek2
{
    public class Shrek2Factory : IComponentFactory
    {
        public string ComponentName
        {
            get { return "Shrek 2"; }
        }

        public string Description
        {
            get { return "Autosplitter for Shrek 2"; }
        }

        public ComponentCategory Category
        {
            get { return ComponentCategory.Control; }
        }

        public IComponent Create(LiveSplitState state)
        {
            return (new Shrek2Component(state));
        }

        public string UpdateName
        {
            get { return this.ComponentName; }
        }

        public string UpdateURL
        {
            get { return "https://raw.githubusercontent.com/Dalet/LiveSplit.Shrek2/master/"; }
        }

        public Version Version
        {
            get { return Assembly.GetExecutingAssembly().GetName().Version; }
        }

        public string XMLURL
        {
            get { return this.UpdateURL + "Components/update.LiveSplit.Shrek2.xml"; }
        }
    }
}
