﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreateTest
{
    public partial class CustomListBox : ListBox
    {

        #region Constants
        private static readonly object _eventEmptyTextChanged = new object();
        private const int WM_ERASEBKGND = 20;
        private const int WM_PAINT = 15;
        #endregion

        #region Fields

        private string _emptyText;

        #endregion

        #region Constructors

        public CustomListBox()
        {
            _emptyText = string.Empty;
        }

        #endregion

        #region Events

        /// <summary>
        /// Occurs when the EmptyText property value changes
        /// </summary>
        [Category("Property Changed")]
        public event EventHandler EmptyTextChanged
        {
          add { this.Events.AddHandler(_eventEmptyTextChanged, value); }
          remove { this.Events.RemoveHandler(_eventEmptyTextChanged, value); }
        }

        #endregion

        #region Properties

        [Category("Appearance")]
        [DefaultValue("")]
        [Editor("System.ComponentModel.Design.MultilineStringEditor, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
        public string EmptyText
        {
            get { return _emptyText; }
            set
            {
                if (_emptyText != value)
                {
                    _emptyText = value;
                    this.OnEmptyTextChanged(EventArgs.Empty);
                }
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// Raises the <see cref="EmptyTextChanged" /> event.
        /// </summary>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        protected virtual void OnEmptyTextChanged(EventArgs e)
        {
          EventHandler handler;

          this.Invalidate();

          handler = (EventHandler)this.Events[_eventEmptyTextChanged];

          if (handler != null)
              handler.Invoke(this, e);
        }

        protected virtual void OnWmPaint(ref Message m)
        {
            this.DrawText();
        }

        //[DebuggerStepThrough]
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            // ReSharper disable once ConvertIfStatementToSwitchStatement
            if (m.Msg == WM_PAINT)
            {
                this.OnWmPaint(ref m);
            }
            else if (m.Msg == WM_ERASEBKGND && this.ShouldDrawEmptyText())
            {
                this.ClearBackground();
            }
        }

        private void ClearBackground()
        {
            using (Graphics g = this.CreateGraphics())
            {
                g.Clear(this.BackColor);
            }
        }

        private void DrawText()
        {
            if (this.ShouldDrawEmptyText())
            {
                TextFormatFlags flags;
                flags = TextFormatFlags.ExpandTabs | TextFormatFlags.HorizontalCenter | TextFormatFlags.NoPrefix | TextFormatFlags.WordBreak | TextFormatFlags.WordEllipsis | TextFormatFlags.VerticalCenter;

                using (Graphics g = this.CreateGraphics())
                {
                    TextRenderer.DrawText(g, _emptyText, this.Font, this.ClientRectangle, this.ForeColor, this.BackColor, flags);
                }
            }
        }

        private bool ShouldDrawEmptyText()
        {
            return this.Items.Count == 0 && !string.IsNullOrEmpty(_emptyText) && !this.DesignMode;
        }
        #endregion
    }
}
