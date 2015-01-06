using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Text;
using System.Drawing;
using System.ComponentModel;
using System.Drawing.Imaging;

namespace CRD.WinUI.Misc
{
    [DefaultEvent("Click")]
    public class CommandButton : System.Windows.Forms.UserControl
    {
        private Image _mouseMoveImage = null;
        private Image _mouseDownImage = null;
        private Image _normalImage = null;
        private ToolTip toolTip;
        private System.ComponentModel.IContainer components;
        private string _toolTip;
        private Color imageTransparentColor;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // CommandButton
            // 
            this.Name = "CommandButton";
            this.Size = new System.Drawing.Size(150, 45);
            this.ResumeLayout(false);

        }

        public CommandButton()
        {
            //this.SetStyle(ControlStyles.DoubleBuffer | ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.DoubleBuffer, true);
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            InitializeComponent();
        }

        public Image MouseMoveImage
        {
            get 
            { 
               
                //this.BackgroundImage = _mouseMoveImage;
                return _mouseMoveImage;
            }
            set
            {
                _mouseMoveImage = value;
                // this.BackgroundImage = _mouseMoveImage;
            }
        }

        public Image MouseDownImage
        {
            get 
            { 
               
                //this.BackgroundImage = _mouseDownImage;
                return _mouseDownImage;
            }
            set
            {
                _mouseDownImage = value;
                // this.BackgroundImage = _mouseDownImage;
            }
        }

        public Image NormalImage
        {
            get 
            {
                //this.BackgroundImage = _normalImage;
                return _normalImage;
            }
            set
            {
                _normalImage = value;
                this.BackgroundImage = _normalImage;
            }
        }

        public Color ImageTransparentColor
        {
            get
            {
                return this.imageTransparentColor;
            }
            set
            {
                this.imageTransparentColor = value;

                Bitmap image = this.BackgroundImage as Bitmap;

                if (((image != null) && (value != Color.Empty)) && !ImageAnimator.CanAnimate(image))
                {
                    try
                    {
                        image.MakeTransparent(this.imageTransparentColor);
                    }
                    catch
                    { }
                }
            }
        }

        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            if (this.NormalImage != null)
            {
                this.BackgroundImage = NormalImage;
            }
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);

            if (this.MouseMoveImage != null)
            {
                this.BackgroundImage = MouseMoveImage;
            }
            this.Invalidate();
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);

            if (this.NormalImage != null)
            {
                this.BackgroundImage = NormalImage;
            }
            this.Invalidate();
        }

        protected override void OnMouseDown(System.Windows.Forms.MouseEventArgs e)
        {
            base.OnMouseDown(e);

            if (this.MouseDownImage != null)
            {
                this.BackgroundImage = this.MouseDownImage;
            }
        }

        protected override void OnMouseUp(System.Windows.Forms.MouseEventArgs e)
        {
            base.OnMouseUp(e);

            if (this.NormalImage != null)
            {
                this.BackgroundImage = NormalImage;
            }
        }

        protected override void OnBackgroundImageChanged(EventArgs e)
        {
            base.OnBackgroundImageChanged(e);

            this.ImageTransparentColor = Color.FromArgb(255, 0, 255);
        }

        public string ToolTip
        {
            get { return _toolTip; }
            set
            {
                _toolTip = value;
                this.toolTip.SetToolTip(this, _toolTip);
            }
        }
    }
}
