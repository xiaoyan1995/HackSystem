﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using HackSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace HackSystem.Tests
{
    [TestClass()]
    public class Base64ControllerTests
    {
        [TestMethod()]
        public void Base64ToImageTest()
        {
            Image TestImage = null;
            TestImage = Base64Controller.Base64ToImage(@"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");
            if (TestImage == null || TestImage.Size.Width != 80 || TestImage.Size.Height != 80)
                Assert.Fail();

            if (Base64Controller.ImageToBase64(TestImage) == string.Empty) Assert.Fail();
        }
    }
}