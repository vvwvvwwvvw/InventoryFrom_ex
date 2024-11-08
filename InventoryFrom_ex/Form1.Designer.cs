using System.Windows.Forms;

namespace InventoryFrom_ex
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtDate = new System.Windows.Forms.DateTimePicker();
            this.btAdd = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.rbIn = new System.Windows.Forms.RadioButton();
            this.rbOut = new System.Windows.Forms.RadioButton();
            this.tbQty = new System.Windows.Forms.TextBox();
            this.cbItem = new System.Windows.Forms.ComboBox();
            this.lvInOutList = new System.Windows.Forms.ListView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "제품명 :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "수량 :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(450, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "입출고 날짜";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(472, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "입출고";
            // 
            // dtDate
            // 
            this.dtDate.Location = new System.Drawing.Point(554, 31);
            this.dtDate.Name = "dtDate";
            this.dtDate.Size = new System.Drawing.Size(200, 25);
            this.dtDate.TabIndex = 4;
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(26, 204);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(115, 41);
            this.btAdd.TabIndex = 5;
            this.btAdd.Text = "등록";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(189, 204);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(115, 41);
            this.btDelete.TabIndex = 6;
            this.btDelete.Text = "삭제";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // rbIn
            // 
            this.rbIn.AutoSize = true;
            this.rbIn.Location = new System.Drawing.Point(426, 123);
            this.rbIn.Name = "rbIn";
            this.rbIn.Size = new System.Drawing.Size(58, 19);
            this.rbIn.TabIndex = 7;
            this.rbIn.TabStop = true;
            this.rbIn.Text = "입고";
            this.rbIn.UseVisualStyleBackColor = true;
            // 
            // rbOut
            // 
            this.rbOut.AutoSize = true;
            this.rbOut.Location = new System.Drawing.Point(554, 123);
            this.rbOut.Name = "rbOut";
            this.rbOut.Size = new System.Drawing.Size(58, 19);
            this.rbOut.TabIndex = 8;
            this.rbOut.TabStop = true;
            this.rbOut.Text = "출고";
            this.rbOut.UseVisualStyleBackColor = true;
            // 
            // tbQty
            // 
            this.tbQty.Location = new System.Drawing.Point(89, 82);
            this.tbQty.Name = "tbQty";
            this.tbQty.Size = new System.Drawing.Size(215, 25);
            this.tbQty.TabIndex = 9;
            // 
            // cbItem
            // 
            this.cbItem.FormattingEnabled = true;
            this.cbItem.Items.AddRange(new object[] {
            "캠코더",
            "모니터",
            "컴퓨터",
            "책장",
            "의자"});
            this.cbItem.Location = new System.Drawing.Point(89, 35);
            this.cbItem.Name = "cbItem";
            this.cbItem.Size = new System.Drawing.Size(215, 23);
            this.cbItem.TabIndex = 10;
            // 
            // lvInOutList
            // 
            this.lvInOutList.HideSelection = false;
            this.lvInOutList.Location = new System.Drawing.Point(12, 251);
            this.lvInOutList.Name = "lvInOutList";
            this.lvInOutList.Size = new System.Drawing.Size(776, 196);
            this.lvInOutList.TabIndex = 11;
            this.lvInOutList.UseCompatibleStateImageBehavior = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(426, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(350, 115);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lvInOutList);
            this.Controls.Add(this.cbItem);
            this.Controls.Add(this.tbQty);
            this.Controls.Add(this.rbOut);
            this.Controls.Add(this.rbIn);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.dtDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "창고 관리";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtDate;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.RadioButton rbIn;
        private System.Windows.Forms.RadioButton rbOut;
        private System.Windows.Forms.TextBox tbQty;
        private System.Windows.Forms.ComboBox cbItem;
        private ListView lvInOutList;
        private GroupBox groupBox1;
    }
}

