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
      this.Btn_Attack = new System.Windows.Forms.Button();
      this.speed = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.gear = new System.Windows.Forms.Label();
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
      // Btn_Attack
      // 
      this.Btn_Attack.Location = new System.Drawing.Point(303, 12);
      this.Btn_Attack.Name = "Btn_Attack";
      this.Btn_Attack.Size = new System.Drawing.Size(285, 426);
      this.Btn_Attack.TabIndex = 1;
      this.Btn_Attack.Text = "ATTACK";
      this.Btn_Attack.UseVisualStyleBackColor = true;
      this.Btn_Attack.Click += new System.EventHandler(this.BtnAttack_Click);
      // 
      // speed
      // 
      this.speed.AutoSize = true;
      this.speed.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.speed.Location = new System.Drawing.Point(632, 65);
      this.speed.Name = "speed";
      this.speed.Size = new System.Drawing.Size(78, 55);
      this.speed.TabIndex = 2;
      this.speed.Text = "00";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(594, 65);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(29, 12);
      this.label1.TabIndex = 3;
      this.label1.Text = "속도";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(728, 107);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(24, 12);
      this.label2.TabIndex = 4;
      this.label2.Text = "Km";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(594, 202);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(29, 12);
      this.label3.TabIndex = 5;
      this.label3.Text = "기어";
      // 
      // gear
      // 
      this.gear.AutoSize = true;
      this.gear.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.gear.Location = new System.Drawing.Point(642, 216);
      this.gear.Name = "gear";
      this.gear.Size = new System.Drawing.Size(51, 55);
      this.gear.TabIndex = 6;
      this.gear.Text = "0";
      // 
      // KISAForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.gear);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.speed);
      this.Controls.Add(this.Btn_Attack);
      this.Controls.Add(this.BtnReset);
      this.Name = "KISAForm";
      this.Text = "KISA Form";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.KISAForm_FormClosing);
      this.Load += new System.EventHandler(this.Form1_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button BtnReset;
    private System.Windows.Forms.Button Btn_Attack;
    private System.Windows.Forms.Label speed;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label gear;
  }
}

