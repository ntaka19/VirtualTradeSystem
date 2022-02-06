
namespace VirtualTradeSystem
{
    partial class Form1View
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.DGVTrades = new System.Windows.Forms.DataGridView();
            this.SetDealButton = new System.Windows.Forms.Button();
            this.DGVIndications = new System.Windows.Forms.DataGridView();
            this.dealBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.positionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tradeDatedataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dealTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isBuyDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.lotDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strikeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InitialPremium = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DGVTrades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVIndications)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.positionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVTrades
            // 
            this.DGVTrades.AutoGenerateColumns = false;
            this.DGVTrades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVTrades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.tradeDatedataGridViewTextBoxColumn,
            this.dealTypeDataGridViewTextBoxColumn,
            this.isBuyDataGridViewCheckBoxColumn,
            this.lotDataGridViewTextBoxColumn,
            this.startDateDataGridViewTextBoxColumn,
            this.strikeDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.InitialPremium});
            this.DGVTrades.DataSource = this.positionBindingSource;
            this.DGVTrades.Location = new System.Drawing.Point(61, 80);
            this.DGVTrades.Name = "DGVTrades";
            this.DGVTrades.RowHeadersWidth = 62;
            this.DGVTrades.RowTemplate.Height = 21;
            this.DGVTrades.Size = new System.Drawing.Size(967, 197);
            this.DGVTrades.TabIndex = 0;
            // 
            // SetDealButton
            // 
            this.SetDealButton.Location = new System.Drawing.Point(916, 565);
            this.SetDealButton.Name = "SetDealButton";
            this.SetDealButton.Size = new System.Drawing.Size(93, 26);
            this.SetDealButton.TabIndex = 4;
            this.SetDealButton.Text = "Set Deal";
            this.SetDealButton.UseVisualStyleBackColor = true;
            // 
            // DGVIndications
            // 
            this.DGVIndications.AutoGenerateColumns = false;
            this.DGVIndications.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVIndications.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.DGVIndications.DataSource = this.dealBindingSource;
            this.DGVIndications.Location = new System.Drawing.Point(61, 335);
            this.DGVIndications.Name = "DGVIndications";
            this.DGVIndications.RowHeadersWidth = 62;
            this.DGVIndications.RowTemplate.Height = 21;
            this.DGVIndications.Size = new System.Drawing.Size(967, 197);
            this.DGVIndications.TabIndex = 5;
            // 
            // dealBindingSource
            // 
            this.dealBindingSource.DataSource = typeof(VirtualTradeSystem.Deal);
            // 
            // positionBindingSource
            // 
            this.positionBindingSource.DataSource = typeof(VirtualTradeSystem.Deal);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.Width = 50;
            // 
            // tradeDatedataGridViewTextBoxColumn
            // 
            this.tradeDatedataGridViewTextBoxColumn.DataPropertyName = "TradeDate";
            this.tradeDatedataGridViewTextBoxColumn.HeaderText = "TradeDate";
            this.tradeDatedataGridViewTextBoxColumn.MinimumWidth = 8;
            this.tradeDatedataGridViewTextBoxColumn.Name = "tradeDatedataGridViewTextBoxColumn";
            // 
            // dealTypeDataGridViewTextBoxColumn
            // 
            this.dealTypeDataGridViewTextBoxColumn.DataPropertyName = "DealType";
            this.dealTypeDataGridViewTextBoxColumn.HeaderText = "DealType";
            this.dealTypeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.dealTypeDataGridViewTextBoxColumn.Name = "dealTypeDataGridViewTextBoxColumn";
            // 
            // isBuyDataGridViewCheckBoxColumn
            // 
            this.isBuyDataGridViewCheckBoxColumn.DataPropertyName = "IsBuy";
            this.isBuyDataGridViewCheckBoxColumn.HeaderText = "IsBuy";
            this.isBuyDataGridViewCheckBoxColumn.MinimumWidth = 8;
            this.isBuyDataGridViewCheckBoxColumn.Name = "isBuyDataGridViewCheckBoxColumn";
            this.isBuyDataGridViewCheckBoxColumn.Width = 50;
            // 
            // lotDataGridViewTextBoxColumn
            // 
            this.lotDataGridViewTextBoxColumn.DataPropertyName = "Lot";
            this.lotDataGridViewTextBoxColumn.HeaderText = "Lot";
            this.lotDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.lotDataGridViewTextBoxColumn.Name = "lotDataGridViewTextBoxColumn";
            this.lotDataGridViewTextBoxColumn.Width = 50;
            // 
            // startDateDataGridViewTextBoxColumn
            // 
            this.startDateDataGridViewTextBoxColumn.DataPropertyName = "StartDate";
            this.startDateDataGridViewTextBoxColumn.HeaderText = "StartDate";
            this.startDateDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.startDateDataGridViewTextBoxColumn.Name = "startDateDataGridViewTextBoxColumn";
            // 
            // strikeDataGridViewTextBoxColumn
            // 
            this.strikeDataGridViewTextBoxColumn.DataPropertyName = "Strike";
            this.strikeDataGridViewTextBoxColumn.HeaderText = "Strike";
            this.strikeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.strikeDataGridViewTextBoxColumn.Name = "strikeDataGridViewTextBoxColumn";
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            // 
            // InitialPremium
            // 
            this.InitialPremium.DataPropertyName = "InitialPremium";
            this.InitialPremium.HeaderText = "InitialPremium";
            this.InitialPremium.MinimumWidth = 8;
            this.InitialPremium.Name = "InitialPremium";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TradeDate";
            this.dataGridViewTextBoxColumn2.HeaderText = "TradeDate";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "DealType";
            this.dataGridViewTextBoxColumn3.HeaderText = "DealType";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "IsBuy";
            this.dataGridViewCheckBoxColumn1.HeaderText = "IsBuy";
            this.dataGridViewCheckBoxColumn1.MinimumWidth = 8;
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Lot";
            this.dataGridViewTextBoxColumn4.HeaderText = "Lot";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 50;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "StartDate";
            this.dataGridViewTextBoxColumn5.HeaderText = "StartDate";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Strike";
            this.dataGridViewTextBoxColumn6.HeaderText = "Strike";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Status";
            this.dataGridViewTextBoxColumn7.HeaderText = "Status";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "InitialPremium";
            this.dataGridViewTextBoxColumn8.HeaderText = "InitialPremium";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // Form1View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1159, 688);
            this.Controls.Add(this.DGVIndications);
            this.Controls.Add(this.SetDealButton);
            this.Controls.Add(this.DGVTrades);
            this.Name = "Form1View";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.DGVTrades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVIndications)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.positionBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView DGVTrades;
        private System.Windows.Forms.BindingSource positionBindingSource;
        private System.Windows.Forms.Button SetDealButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn maturityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn premiumDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource dealBindingSource;
        public System.Windows.Forms.DataGridView DGVIndications;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tradeDatedataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dealTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isBuyDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lotDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn strikeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn InitialPremium;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
    }
}

