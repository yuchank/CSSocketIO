namespace CSSocketIO
{
  partial class KISAForm
  {
    /// <summary>
    /// 필수 디자이너 변수입니다.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// 사용 중인 모든 리소스를 정리합니다.
    /// </summary>
    /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form 디자이너에서 생성한 코드

    /// <summary>
    /// 디자이너 지원에 필요한 메서드입니다. 
    /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
    /// </summary>
    private void InitializeComponent()
    {
      this.BtnApp = new System.Windows.Forms.Button();
      this.BtnOBD = new System.Windows.Forms.Button();
      this.BtnAuto = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // BtnApp
      // 
      this.BtnApp.Location = new System.Drawing.Point(12, 12);
      this.BtnApp.Name = "BtnApp";
      this.BtnApp.Size = new System.Drawing.Size(285, 426);
      this.BtnApp.TabIndex = 0;
      this.BtnApp.Text = "App 공격";
      this.BtnApp.UseVisualStyleBackColor = true;
      this.BtnApp.Click += new System.EventHandler(this.BtnApp_Click);
      // 
      // BtnOBD
      // 
      this.BtnOBD.Location = new System.Drawing.Point(303, 12);
      this.BtnOBD.Name = "BtnOBD";
      this.BtnOBD.Size = new System.Drawing.Size(285, 426);
      this.BtnOBD.TabIndex = 1;
      this.BtnOBD.Text = "ODB 공격";
      this.BtnOBD.UseVisualStyleBackColor = true;
      this.BtnOBD.Click += new System.EventHandler(this.BtnOBD_Click);
      // 
      // BtnAuto
      // 
      this.BtnAuto.Location = new System.Drawing.Point(594, 12);
      this.BtnAuto.Name = "BtnAuto";
      this.BtnAuto.Size = new System.Drawing.Size(285, 426);
      this.BtnAuto.TabIndex = 1;
      this.BtnAuto.Text = "자율주행 공격";
      this.BtnAuto.UseVisualStyleBackColor = true;
      this.BtnAuto.Click += new System.EventHandler(this.BtnAuto_Click);
      // 
      // KISAForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(890, 450);
      this.Controls.Add(this.BtnAuto);
      this.Controls.Add(this.BtnOBD);
      this.Controls.Add(this.BtnApp);
      this.Name = "KISAForm";
      this.Text = "KISA Form";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.KISAForm_FormClosing);
      this.Load += new System.EventHandler(this.Form1_Load);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button BtnApp;
    private System.Windows.Forms.Button BtnOBD;
    private System.Windows.Forms.Button BtnAuto;
  }
}

