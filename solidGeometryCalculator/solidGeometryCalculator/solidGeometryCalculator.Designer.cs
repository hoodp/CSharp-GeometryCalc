namespace solidGeometryCalculator
{
    //    Paul Hood
    //    L2 Homework - Simple Geometric Calculator
    //    Geometric calculator calculates volume & surface area for cone or cylinder
    //    2/6/2013

    partial class solidGeometryCalculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(solidGeometryCalculator));
            this.label1 = new System.Windows.Forms.Label();
            this.picCone = new System.Windows.Forms.PictureBox();
            this.picCylinder = new System.Windows.Forms.PictureBox();
            this.lblHeight = new System.Windows.Forms.Label();
            this.lblRadius = new System.Windows.Forms.Label();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.txtRadius = new System.Windows.Forms.TextBox();
            this.butExit = new System.Windows.Forms.Button();
            this.butClear = new System.Windows.Forms.Button();
            this.butCalculate = new System.Windows.Forms.Button();
            this.radCone = new System.Windows.Forms.RadioButton();
            this.radCylinder = new System.Windows.Forms.RadioButton();
            this.lblVolumeCylinder = new System.Windows.Forms.Label();
            this.lblSurfaceAreaCylinder = new System.Windows.Forms.Label();
            this.txtCylinderSurfaceArea = new System.Windows.Forms.TextBox();
            this.txtCylinderVolume = new System.Windows.Forms.TextBox();
            this.txtConeSurfaceArea = new System.Windows.Forms.TextBox();
            this.txtConeVolume = new System.Windows.Forms.TextBox();
            this.lblVolumeCone = new System.Windows.Forms.Label();
            this.lblSurfaceAreaCone = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picCone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCylinder)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(155, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Geometric Calculator";
            // 
            // picCone
            // 
            this.picCone.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picCone.BackgroundImage")));
            this.picCone.Location = new System.Drawing.Point(23, 51);
            this.picCone.Name = "picCone";
            this.picCone.Size = new System.Drawing.Size(139, 170);
            this.picCone.TabIndex = 2;
            this.picCone.TabStop = false;
            this.picCone.Click += new System.EventHandler(this.picCone_Click);
            // 
            // picCylinder
            // 
            this.picCylinder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picCylinder.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picCylinder.BackgroundImage")));
            this.picCylinder.Location = new System.Drawing.Point(353, 51);
            this.picCylinder.Name = "picCylinder";
            this.picCylinder.Size = new System.Drawing.Size(139, 170);
            this.picCylinder.TabIndex = 3;
            this.picCylinder.TabStop = false;
            this.picCylinder.Click += new System.EventHandler(this.picCylinder_Click);
            // 
            // lblHeight
            // 
            this.lblHeight.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(185, 166);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(41, 13);
            this.lblHeight.TabIndex = 4;
            this.lblHeight.Text = "Height:";
            // 
            // lblRadius
            // 
            this.lblRadius.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRadius.AutoSize = true;
            this.lblRadius.Location = new System.Drawing.Point(183, 141);
            this.lblRadius.Name = "lblRadius";
            this.lblRadius.Size = new System.Drawing.Size(43, 13);
            this.lblRadius.TabIndex = 5;
            this.lblRadius.Text = "Radius:";
            // 
            // txtHeight
            // 
            this.txtHeight.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtHeight.Location = new System.Drawing.Point(223, 162);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(100, 20);
            this.txtHeight.TabIndex = 1;
            this.toolTip1.SetToolTip(this.txtHeight, "10 Digits Allowed");
            // 
            // txtRadius
            // 
            this.txtRadius.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtRadius.Location = new System.Drawing.Point(223, 137);
            this.txtRadius.Name = "txtRadius";
            this.txtRadius.Size = new System.Drawing.Size(100, 20);
            this.txtRadius.TabIndex = 0;
            this.toolTip1.SetToolTip(this.txtRadius, "10 Digits Allowed");
            this.txtRadius.TextChanged += new System.EventHandler(this.txtRadius_TextChanged);
            // 
            // butExit
            // 
            this.butExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.butExit.Location = new System.Drawing.Point(401, 360);
            this.butExit.Name = "butExit";
            this.butExit.Size = new System.Drawing.Size(91, 32);
            this.butExit.TabIndex = 4;
            this.butExit.Text = "&Exit";
            this.butExit.UseVisualStyleBackColor = true;
            this.butExit.Click += new System.EventHandler(this.butExit_Click);
            // 
            // butClear
            // 
            this.butClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.butClear.Location = new System.Drawing.Point(304, 360);
            this.butClear.Name = "butClear";
            this.butClear.Size = new System.Drawing.Size(91, 32);
            this.butClear.TabIndex = 3;
            this.butClear.Text = "C&lear";
            this.butClear.UseVisualStyleBackColor = true;
            this.butClear.Click += new System.EventHandler(this.butClear_Click);
            // 
            // butCalculate
            // 
            this.butCalculate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.butCalculate.Location = new System.Drawing.Point(223, 187);
            this.butCalculate.Name = "butCalculate";
            this.butCalculate.Size = new System.Drawing.Size(91, 32);
            this.butCalculate.TabIndex = 2;
            this.butCalculate.Text = "&Calculate";
            this.butCalculate.UseVisualStyleBackColor = true;
            this.butCalculate.Click += new System.EventHandler(this.butCalculate_Click);
            // 
            // radCone
            // 
            this.radCone.AutoSize = true;
            this.radCone.Location = new System.Drawing.Point(67, 227);
            this.radCone.Name = "radCone";
            this.radCone.Size = new System.Drawing.Size(50, 17);
            this.radCone.TabIndex = 5;
            this.radCone.Text = "C&one";
            this.radCone.UseVisualStyleBackColor = true;
            // 
            // radCylinder
            // 
            this.radCylinder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radCylinder.AutoSize = true;
            this.radCylinder.Location = new System.Drawing.Point(391, 227);
            this.radCylinder.Name = "radCylinder";
            this.radCylinder.Size = new System.Drawing.Size(62, 17);
            this.radCylinder.TabIndex = 3;
            this.radCylinder.Text = "Cylin&der";
            this.radCylinder.UseVisualStyleBackColor = true;
            // 
            // lblVolumeCylinder
            // 
            this.lblVolumeCylinder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVolumeCylinder.AutoSize = true;
            this.lblVolumeCylinder.Location = new System.Drawing.Point(353, 262);
            this.lblVolumeCylinder.Name = "lblVolumeCylinder";
            this.lblVolumeCylinder.Size = new System.Drawing.Size(45, 13);
            this.lblVolumeCylinder.TabIndex = 18;
            this.lblVolumeCylinder.Text = "Volume:";
            // 
            // lblSurfaceAreaCylinder
            // 
            this.lblSurfaceAreaCylinder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSurfaceAreaCylinder.AutoSize = true;
            this.lblSurfaceAreaCylinder.Location = new System.Drawing.Point(353, 301);
            this.lblSurfaceAreaCylinder.Name = "lblSurfaceAreaCylinder";
            this.lblSurfaceAreaCylinder.Size = new System.Drawing.Size(72, 13);
            this.lblSurfaceAreaCylinder.TabIndex = 17;
            this.lblSurfaceAreaCylinder.Text = "Surface Area:";
            // 
            // txtCylinderSurfaceArea
            // 
            this.txtCylinderSurfaceArea.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCylinderSurfaceArea.Location = new System.Drawing.Point(353, 317);
            this.txtCylinderSurfaceArea.Name = "txtCylinderSurfaceArea";
            this.txtCylinderSurfaceArea.ReadOnly = true;
            this.txtCylinderSurfaceArea.Size = new System.Drawing.Size(139, 20);
            this.txtCylinderSurfaceArea.TabIndex = 22;
            this.txtCylinderSurfaceArea.TabStop = false;
            // 
            // txtCylinderVolume
            // 
            this.txtCylinderVolume.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCylinderVolume.Location = new System.Drawing.Point(353, 278);
            this.txtCylinderVolume.Name = "txtCylinderVolume";
            this.txtCylinderVolume.ReadOnly = true;
            this.txtCylinderVolume.Size = new System.Drawing.Size(139, 20);
            this.txtCylinderVolume.TabIndex = 21;
            this.txtCylinderVolume.TabStop = false;
            // 
            // txtConeSurfaceArea
            // 
            this.txtConeSurfaceArea.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtConeSurfaceArea.Location = new System.Drawing.Point(20, 317);
            this.txtConeSurfaceArea.Name = "txtConeSurfaceArea";
            this.txtConeSurfaceArea.ReadOnly = true;
            this.txtConeSurfaceArea.Size = new System.Drawing.Size(139, 20);
            this.txtConeSurfaceArea.TabIndex = 24;
            this.txtConeSurfaceArea.TabStop = false;
            // 
            // txtConeVolume
            // 
            this.txtConeVolume.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtConeVolume.Location = new System.Drawing.Point(20, 278);
            this.txtConeVolume.Name = "txtConeVolume";
            this.txtConeVolume.ReadOnly = true;
            this.txtConeVolume.Size = new System.Drawing.Size(139, 20);
            this.txtConeVolume.TabIndex = 23;
            this.txtConeVolume.TabStop = false;
            // 
            // lblVolumeCone
            // 
            this.lblVolumeCone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblVolumeCone.AutoSize = true;
            this.lblVolumeCone.Location = new System.Drawing.Point(20, 262);
            this.lblVolumeCone.Name = "lblVolumeCone";
            this.lblVolumeCone.Size = new System.Drawing.Size(45, 13);
            this.lblVolumeCone.TabIndex = 27;
            this.lblVolumeCone.Text = "Volume:";
            // 
            // lblSurfaceAreaCone
            // 
            this.lblSurfaceAreaCone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblSurfaceAreaCone.AutoSize = true;
            this.lblSurfaceAreaCone.Location = new System.Drawing.Point(20, 301);
            this.lblSurfaceAreaCone.Name = "lblSurfaceAreaCone";
            this.lblSurfaceAreaCone.Size = new System.Drawing.Size(72, 13);
            this.lblSurfaceAreaCone.TabIndex = 26;
            this.lblSurfaceAreaCone.Text = "Surface Area:";
            // 
            // solidGeometryCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(514, 404);
            this.Controls.Add(this.lblVolumeCone);
            this.Controls.Add(this.lblSurfaceAreaCone);
            this.Controls.Add(this.txtConeSurfaceArea);
            this.Controls.Add(this.txtConeVolume);
            this.Controls.Add(this.txtCylinderSurfaceArea);
            this.Controls.Add(this.txtCylinderVolume);
            this.Controls.Add(this.lblVolumeCylinder);
            this.Controls.Add(this.lblSurfaceAreaCylinder);
            this.Controls.Add(this.radCylinder);
            this.Controls.Add(this.radCone);
            this.Controls.Add(this.butCalculate);
            this.Controls.Add(this.butClear);
            this.Controls.Add(this.butExit);
            this.Controls.Add(this.txtRadius);
            this.Controls.Add(this.txtHeight);
            this.Controls.Add(this.lblRadius);
            this.Controls.Add(this.lblHeight);
            this.Controls.Add(this.picCylinder);
            this.Controls.Add(this.picCone);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(529, 441);
            this.Name = "solidGeometryCalculator";
            this.Text = "Geometric Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.picCone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCylinder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picCone;
        private System.Windows.Forms.PictureBox picCylinder;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.Label lblRadius;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.TextBox txtRadius;
        private System.Windows.Forms.Button butExit;
        private System.Windows.Forms.Button butClear;
        private System.Windows.Forms.Button butCalculate;
        private System.Windows.Forms.RadioButton radCone;
        private System.Windows.Forms.RadioButton radCylinder;
        private System.Windows.Forms.Label lblVolumeCylinder;
        private System.Windows.Forms.Label lblSurfaceAreaCylinder;
        private System.Windows.Forms.TextBox txtCylinderSurfaceArea;
        private System.Windows.Forms.TextBox txtCylinderVolume;
        private System.Windows.Forms.TextBox txtConeSurfaceArea;
        private System.Windows.Forms.TextBox txtConeVolume;
        private System.Windows.Forms.Label lblVolumeCone;
        private System.Windows.Forms.Label lblSurfaceAreaCone;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

