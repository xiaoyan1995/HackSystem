﻿using System.Drawing;
using System.Windows.Forms;

using HackSystem.StartUpTemplate;

namespace Leon.RingsStartUp
{
    public class NestingRingClass : StartUpTemplateClass
    {
        public NestingRingClass()
        {
            this.Name = "嵌套";
            this.Description = "嵌套启动画面 - Leon";
            this.Preview = RingsStartUpResource.NestingRingPreview;
        }

        public override string FileName => System.Reflection.Assembly.GetExecutingAssembly().ManifestModule.ScopeName;

        protected override Form CreateStartUpForm()
        {
            return new CommonRingForm(RingsStartUpResource.NestingRing, Color.FromArgb(46, 46, 51)) { ParentStartUp = this, ForeColor = Color.FromArgb(255, 180, 180, 180) };
        }
    }
}
