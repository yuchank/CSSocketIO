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
      this.BtnReset = new System.Windows.Forms.Button();
      this.ATTACK = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // BtnReset
      // 
      this.BtnReset.Location = new System.Drawing.Point(12, 12);
      this.BtnReset.Name = "BtnReset";
      this.BtnReset.Size = new System.Drawing.Size(285, 426);
      this.BtnReset.TabIndex = 0;
      this.BtnReset.Text = "RESET";
      this.BtnReset.UseVisualStyleBackColor = true;
      this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
      // 
      // ATTACK
      // 
      this.ATTACK.Location = new System.Drawing.Point(303, 12);
      this.ATTACK.Name = "ATTACK";
      this.ATTACK.Size = new System.Drawing.Size(285, 426);
      this.ATTACK.TabIndex = 1;
      this.ATTACK.Text = "ATTACK";
      this.ATTACK.UseVisualStyleBackColor = true;
      this.ATTACK.Click += new System.EventHandler(this.ATTACK_Click);
      // 
      // KISAForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.ATTACK);
      this.Controls.Add(this.BtnReset);
      this.Name = "KISAForm";
      this.Text = "KISA Form";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.KISAForm_FormClosing);
      this.Load += new System.EventHandler(this.Form1_Load);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button BtnReset;
    private System.Windows.Forms.Button ATTACK;
  }
}

