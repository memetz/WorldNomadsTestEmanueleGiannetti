﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 11.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace CodedUITestProject
{
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Text.RegularExpressions;
    using System.Windows.Input;
    using Microsoft.VisualStudio.TestTools.UITest.Extension;
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
    using Mouse = Microsoft.VisualStudio.TestTools.UITesting.Mouse;
    using MouseButtons = System.Windows.Forms.MouseButtons;
    
    
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public partial class UIMap
    {
        
        /// <summary>
        /// RecordedMethod1 - Use 'RecordedMethod1Params' to pass parameters into this method.
        /// </summary>
        public void RecordedMethod1()
        {
            #region Variable Declarations
            WinClient uIChromeLegacyWindowClient = this.UIHomePageMyASPNETApplWindow.UIChromeLegacyWindowWindow.UIChromeLegacyWindowClient;
            WinControl uIChromeLegacyWindowDocument = this.UIHomePageMyASPNETApplWindow.UIChromeLegacyWindowWindow.UIChromeLegacyWindowDocument;
            WinControl uISequencesMyASPNETAppDocument = this.UIHomePageMyASPNETApplWindow.UIChromeLegacyWindowWindow.UISequencesMyASPNETAppDocument;
            #endregion

            // Click 'Chrome Legacy Window' client
            Mouse.Click(uIChromeLegacyWindowClient, new Point(523, 22));

            // Click 'Chrome Legacy Window' document
            Mouse.Click(uIChromeLegacyWindowDocument, new Point(432, 151));

            // Click 'Chrome Legacy Window' document
            Mouse.Click(uIChromeLegacyWindowDocument, new Point(642, 128));

            // Type '-1' in 'Sequences - My ASP.NET Application - Google Chrome' document
            Keyboard.SendKeys(uISequencesMyASPNETAppDocument, this.RecordedMethod1Params.UISequencesMyASPNETAppDocumentSendKeys, ModifierKeys.None);

            // Click 'Chrome Legacy Window' document
            Mouse.Click(uIChromeLegacyWindowDocument, new Point(412, 154));

            // Move 'Chrome Legacy Window' document
            Mouse.StartDragging(uIChromeLegacyWindowDocument, new Point(629, 126));
            Mouse.StopDragging(uIChromeLegacyWindowDocument, -84, -8);

            // Type 'ads' in 'Sequences - My ASP.NET Application - Google Chrome' document
            Keyboard.SendKeys(uISequencesMyASPNETAppDocument, this.RecordedMethod1Params.UISequencesMyASPNETAppDocumentSendKeys1, ModifierKeys.None);

            // Click 'Chrome Legacy Window' document
            Mouse.Click(uIChromeLegacyWindowDocument, new Point(425, 154));

            // Move 'Chrome Legacy Window' document
            Mouse.StartDragging(uIChromeLegacyWindowDocument, new Point(652, 124));
            Mouse.StopDragging(uIChromeLegacyWindowDocument, -138, -20);

            // Type '6' in 'Sequences - My ASP.NET Application - Google Chrome' document
            Keyboard.SendKeys(uISequencesMyASPNETAppDocument, this.RecordedMethod1Params.UISequencesMyASPNETAppDocumentSendKeys2, ModifierKeys.None);

            // Click 'Chrome Legacy Window' document
            Mouse.Click(uIChromeLegacyWindowDocument, new Point(415, 153));
        }
        
        #region Properties
        public virtual RecordedMethod1Params RecordedMethod1Params
        {
            get
            {
                if ((this.mRecordedMethod1Params == null))
                {
                    this.mRecordedMethod1Params = new RecordedMethod1Params();
                }
                return this.mRecordedMethod1Params;
            }
        }
        
        public UIHomePageMyASPNETApplWindow UIHomePageMyASPNETApplWindow
        {
            get
            {
                if ((this.mUIHomePageMyASPNETApplWindow == null))
                {
                    this.mUIHomePageMyASPNETApplWindow = new UIHomePageMyASPNETApplWindow();
                }
                return this.mUIHomePageMyASPNETApplWindow;
            }
        }
        #endregion
        
        #region Fields
        private RecordedMethod1Params mRecordedMethod1Params;
        
        private UIHomePageMyASPNETApplWindow mUIHomePageMyASPNETApplWindow;
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'RecordedMethod1'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class RecordedMethod1Params
    {
        
        #region Fields
        /// <summary>
        /// Type '-1' in 'Sequences - My ASP.NET Application - Google Chrome' document
        /// </summary>
        public string UISequencesMyASPNETAppDocumentSendKeys = "-1";
        
        /// <summary>
        /// Type 'ads' in 'Sequences - My ASP.NET Application - Google Chrome' document
        /// </summary>
        public string UISequencesMyASPNETAppDocumentSendKeys1 = "ads";
        
        /// <summary>
        /// Type '6' in 'Sequences - My ASP.NET Application - Google Chrome' document
        /// </summary>
        public string UISequencesMyASPNETAppDocumentSendKeys2 = "6";
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIHomePageMyASPNETApplWindow : WinWindow
    {
        
        public UIHomePageMyASPNETApplWindow()
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.Name] = "Home Page - My ASP.NET Application - Google Chrome";
            this.SearchProperties[WinWindow.PropertyNames.ClassName] = "Chrome_WidgetWin_1";
            this.WindowTitles.Add("Home Page - My ASP.NET Application - Google Chrome");
            this.WindowTitles.Add("Sequences - My ASP.NET Application - Google Chrome");
            this.WindowTitles.Add("Results - My ASP.NET Application - Google Chrome");
            #endregion
        }
        
        #region Properties
        public UIChromeLegacyWindowWindow UIChromeLegacyWindowWindow
        {
            get
            {
                if ((this.mUIChromeLegacyWindowWindow == null))
                {
                    this.mUIChromeLegacyWindowWindow = new UIChromeLegacyWindowWindow(this);
                }
                return this.mUIChromeLegacyWindowWindow;
            }
        }
        #endregion
        
        #region Fields
        private UIChromeLegacyWindowWindow mUIChromeLegacyWindowWindow;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIChromeLegacyWindowWindow : WinWindow
    {
        
        public UIChromeLegacyWindowWindow(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlId] = "497890896";
            this.WindowTitles.Add("Home Page - My ASP.NET Application - Google Chrome");
            this.WindowTitles.Add("Sequences - My ASP.NET Application - Google Chrome");
            this.WindowTitles.Add("Results - My ASP.NET Application - Google Chrome");
            #endregion
        }
        
        #region Properties
        public WinClient UIChromeLegacyWindowClient
        {
            get
            {
                if ((this.mUIChromeLegacyWindowClient == null))
                {
                    this.mUIChromeLegacyWindowClient = new WinClient(this);
                    #region Search Criteria
                    this.mUIChromeLegacyWindowClient.SearchProperties[WinControl.PropertyNames.Name] = "Chrome Legacy Window";
                    this.mUIChromeLegacyWindowClient.WindowTitles.Add("Home Page - My ASP.NET Application - Google Chrome");
                    #endregion
                }
                return this.mUIChromeLegacyWindowClient;
            }
        }
        
        public WinControl UIChromeLegacyWindowDocument
        {
            get
            {
                if ((this.mUIChromeLegacyWindowDocument == null))
                {
                    this.mUIChromeLegacyWindowDocument = new WinControl(this);
                    #region Search Criteria
                    this.mUIChromeLegacyWindowDocument.SearchProperties[UITestControl.PropertyNames.ControlType] = "Document";
                    this.mUIChromeLegacyWindowDocument.WindowTitles.Add("Sequences - My ASP.NET Application - Google Chrome");
                    #endregion
                }
                return this.mUIChromeLegacyWindowDocument;
            }
        }
        
        public WinControl UISequencesMyASPNETAppDocument
        {
            get
            {
                if ((this.mUISequencesMyASPNETAppDocument == null))
                {
                    this.mUISequencesMyASPNETAppDocument = new WinControl(this);
                    #region Search Criteria
                    this.mUISequencesMyASPNETAppDocument.SearchProperties[UITestControl.PropertyNames.ControlType] = "Document";
                    this.mUISequencesMyASPNETAppDocument.WindowTitles.Add("Sequences - My ASP.NET Application - Google Chrome");
                    this.mUISequencesMyASPNETAppDocument.WindowTitles.Add("Results - My ASP.NET Application - Google Chrome");
                    #endregion
                }
                return this.mUISequencesMyASPNETAppDocument;
            }
        }
        #endregion
        
        #region Fields
        private WinClient mUIChromeLegacyWindowClient;
        
        private WinControl mUIChromeLegacyWindowDocument;
        
        private WinControl mUISequencesMyASPNETAppDocument;
        #endregion
    }
}
