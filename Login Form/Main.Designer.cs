
namespace Login_Form
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Bunifu.UI.WinForms.BunifuAnimatorNS.Animation animation1 = new Bunifu.UI.WinForms.BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Image = new System.Windows.Forms.PictureBox();
            this.ContentPanel = new System.Windows.Forms.Panel();
            this.ContentPanelTransition = new Bunifu.UI.WinForms.BunifuTransition(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Image)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 70;
            this.bunifuElipse1.TargetControl = this;
            // 
            // Image
            // 
            this.ContentPanelTransition.SetDecoration(this.Image, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.Image.Dock = System.Windows.Forms.DockStyle.Left;
            this.Image.Image = global::Login_Form.Properties.Resources.Main_Image;
            this.Image.Location = new System.Drawing.Point(0, 0);
            this.Image.Name = "Image";
            this.Image.Size = new System.Drawing.Size(580, 610);
            this.Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Image.TabIndex = 4;
            this.Image.TabStop = false;
            // 
            // ContentPanel
            // 
            this.ContentPanelTransition.SetDecoration(this.ContentPanel, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.ContentPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.ContentPanel.Location = new System.Drawing.Point(580, 0);
            this.ContentPanel.Name = "ContentPanel";
            this.ContentPanel.Size = new System.Drawing.Size(440, 610);
            this.ContentPanel.TabIndex = 5;
            // 
            // ContentPanelTransition
            // 
            this.ContentPanelTransition.AnimationType = Bunifu.UI.WinForms.BunifuAnimatorNS.AnimationType.Transparent;
            this.ContentPanelTransition.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 1F;
            this.ContentPanelTransition.DefaultAnimation = animation1;
            this.ContentPanelTransition.MaxAnimationTime = 2000;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1020, 610);
            this.Controls.Add(this.ContentPanel);
            this.Controls.Add(this.Image);
            this.ContentPanelTransition.SetDecoration(this, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Main_Load);
            this.Shown += new System.EventHandler(this.Main_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.Image)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.PictureBox Image;
        private System.Windows.Forms.Panel ContentPanel;
        private Bunifu.UI.WinForms.BunifuTransition ContentPanelTransition;
    }
}

