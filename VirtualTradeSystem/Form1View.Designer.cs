
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
            this.positionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SetDealButton = new System.Windows.Forms.Button();
            this.DGVIndications = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.initialPremiumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dealTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strikeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isBuyDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.lotDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tradeDateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dealBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CalculatePVButton = new System.Windows.Forms.Button();
            this.tradeDatedataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.initialPremiumDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dealTypeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strikeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isBuyDataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.lotDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tradeDateDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endDateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DGVTrades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.positionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVIndications)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVTrades
            // 
            this.DGVTrades.AutoGenerateColumns = false;
            this.DGVTrades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVTrades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tradeDatedataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn9,
            this.initialPremiumDataGridViewTextBoxColumn1,
            this.iDDataGridViewTextBoxColumn1,
            this.statusDataGridViewTextBoxColumn1,
            this.dealTypeDataGridViewTextBoxColumn1,
            this.strikeDataGridViewTextBoxColumn1,
            this.isBuyDataGridViewCheckBoxColumn1,
            this.lotDataGridViewTextBoxColumn1,
            this.tradeDateDataGridViewTextBoxColumn2,
            this.startDateDataGridViewTextBoxColumn1,
            this.endDateDataGridViewTextBoxColumn1});
            this.DGVTrades.DataSource = this.positionBindingSource;
            this.DGVTrades.Location = new System.Drawing.Point(61, 80);
            this.DGVTrades.Name = "DGVTrades";
            this.DGVTrades.ReadOnly = true;
            this.DGVTrades.RowHeadersWidth = 62;
            this.DGVTrades.RowTemplate.Height = 21;
            this.DGVTrades.Size = new System.Drawing.Size(967, 197);
            this.DGVTrades.TabIndex = 0;
            // 
            // positionBindingSource
            // 
            this.positionBindingSource.DataSource = typeof(VirtualTradeSystem.DealModel);
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
            this.dataGridViewTextBoxColumn2,
            this.EndDate,
            this.initialPremiumDataGridViewTextBoxColumn,
            this.iDDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.dealTypeDataGridViewTextBoxColumn,
            this.strikeDataGridViewTextBoxColumn,
            this.isBuyDataGridViewCheckBoxColumn,
            this.lotDataGridViewTextBoxColumn,
            this.tradeDateDataGridViewTextBoxColumn1,
            this.startDateDataGridViewTextBoxColumn,
            this.endDateDataGridViewTextBoxColumn});
            this.DGVIndications.DataSource = this.dealBindingSource;
            this.DGVIndications.Location = new System.Drawing.Point(61, 335);
            this.DGVIndications.Name = "DGVIndications";
            this.DGVIndications.ReadOnly = true;
            this.DGVIndications.RowHeadersWidth = 62;
            this.DGVIndications.RowTemplate.Height = 21;
            this.DGVIndications.Size = new System.Drawing.Size(967, 197);
            this.DGVIndications.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TradeDate";
            this.dataGridViewTextBoxColumn2.HeaderText = "TradeDate";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // EndDate
            // 
            this.EndDate.DataPropertyName = "EndDate";
            this.EndDate.HeaderText = "EndDate";
            this.EndDate.MinimumWidth = 8;
            this.EndDate.Name = "EndDate";
            this.EndDate.ReadOnly = true;
            this.EndDate.Width = 150;
            // 
            // initialPremiumDataGridViewTextBoxColumn
            // 
            this.initialPremiumDataGridViewTextBoxColumn.DataPropertyName = "InitialPremium";
            this.initialPremiumDataGridViewTextBoxColumn.HeaderText = "InitialPremium";
            this.initialPremiumDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.initialPremiumDataGridViewTextBoxColumn.Name = "initialPremiumDataGridViewTextBoxColumn";
            this.initialPremiumDataGridViewTextBoxColumn.ReadOnly = true;
            this.initialPremiumDataGridViewTextBoxColumn.Width = 150;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Width = 150;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            this.statusDataGridViewTextBoxColumn.Width = 150;
            // 
            // dealTypeDataGridViewTextBoxColumn
            // 
            this.dealTypeDataGridViewTextBoxColumn.DataPropertyName = "DealType";
            this.dealTypeDataGridViewTextBoxColumn.HeaderText = "DealType";
            this.dealTypeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.dealTypeDataGridViewTextBoxColumn.Name = "dealTypeDataGridViewTextBoxColumn";
            this.dealTypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.dealTypeDataGridViewTextBoxColumn.Width = 150;
            // 
            // strikeDataGridViewTextBoxColumn
            // 
            this.strikeDataGridViewTextBoxColumn.DataPropertyName = "Strike";
            this.strikeDataGridViewTextBoxColumn.HeaderText = "Strike";
            this.strikeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.strikeDataGridViewTextBoxColumn.Name = "strikeDataGridViewTextBoxColumn";
            this.strikeDataGridViewTextBoxColumn.ReadOnly = true;
            this.strikeDataGridViewTextBoxColumn.Width = 150;
            // 
            // isBuyDataGridViewCheckBoxColumn
            // 
            this.isBuyDataGridViewCheckBoxColumn.DataPropertyName = "IsBuy";
            this.isBuyDataGridViewCheckBoxColumn.HeaderText = "IsBuy";
            this.isBuyDataGridViewCheckBoxColumn.MinimumWidth = 8;
            this.isBuyDataGridViewCheckBoxColumn.Name = "isBuyDataGridViewCheckBoxColumn";
            this.isBuyDataGridViewCheckBoxColumn.ReadOnly = true;
            this.isBuyDataGridViewCheckBoxColumn.Width = 150;
            // 
            // lotDataGridViewTextBoxColumn
            // 
            this.lotDataGridViewTextBoxColumn.DataPropertyName = "Lot";
            this.lotDataGridViewTextBoxColumn.HeaderText = "Lot";
            this.lotDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.lotDataGridViewTextBoxColumn.Name = "lotDataGridViewTextBoxColumn";
            this.lotDataGridViewTextBoxColumn.ReadOnly = true;
            this.lotDataGridViewTextBoxColumn.Width = 150;
            // 
            // tradeDateDataGridViewTextBoxColumn1
            // 
            this.tradeDateDataGridViewTextBoxColumn1.DataPropertyName = "TradeDate";
            this.tradeDateDataGridViewTextBoxColumn1.HeaderText = "TradeDate";
            this.tradeDateDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.tradeDateDataGridViewTextBoxColumn1.Name = "tradeDateDataGridViewTextBoxColumn1";
            this.tradeDateDataGridViewTextBoxColumn1.ReadOnly = true;
            this.tradeDateDataGridViewTextBoxColumn1.Width = 150;
            // 
            // startDateDataGridViewTextBoxColumn
            // 
            this.startDateDataGridViewTextBoxColumn.DataPropertyName = "StartDate";
            this.startDateDataGridViewTextBoxColumn.HeaderText = "StartDate";
            this.startDateDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.startDateDataGridViewTextBoxColumn.Name = "startDateDataGridViewTextBoxColumn";
            this.startDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.startDateDataGridViewTextBoxColumn.Width = 150;
            // 
            // endDateDataGridViewTextBoxColumn
            // 
            this.endDateDataGridViewTextBoxColumn.DataPropertyName = "EndDate";
            this.endDateDataGridViewTextBoxColumn.HeaderText = "EndDate";
            this.endDateDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.endDateDataGridViewTextBoxColumn.Name = "endDateDataGridViewTextBoxColumn";
            this.endDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.endDateDataGridViewTextBoxColumn.Width = 150;
            // 
            // dealBindingSource
            // 
            this.dealBindingSource.DataSource = typeof(VirtualTradeSystem.DealModel);
            // 
            // CalculatePVButton
            // 
            this.CalculatePVButton.Location = new System.Drawing.Point(747, 565);
            this.CalculatePVButton.Name = "CalculatePVButton";
            this.CalculatePVButton.Size = new System.Drawing.Size(93, 26);
            this.CalculatePVButton.TabIndex = 6;
            this.CalculatePVButton.Text = "Calculate PV";
            this.CalculatePVButton.UseVisualStyleBackColor = true;
            // 
            // tradeDatedataGridViewTextBoxColumn
            // 
            this.tradeDatedataGridViewTextBoxColumn.DataPropertyName = "TradeDate";
            this.tradeDatedataGridViewTextBoxColumn.HeaderText = "TradeDate";
            this.tradeDatedataGridViewTextBoxColumn.MinimumWidth = 8;
            this.tradeDatedataGridViewTextBoxColumn.Name = "tradeDatedataGridViewTextBoxColumn";
            this.tradeDatedataGridViewTextBoxColumn.ReadOnly = true;
            this.tradeDatedataGridViewTextBoxColumn.Width = 150;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "EndDate";
            this.dataGridViewTextBoxColumn9.HeaderText = "EndDate";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 150;
            // 
            // initialPremiumDataGridViewTextBoxColumn1
            // 
            this.initialPremiumDataGridViewTextBoxColumn1.DataPropertyName = "InitialPremium";
            this.initialPremiumDataGridViewTextBoxColumn1.HeaderText = "InitialPremium";
            this.initialPremiumDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.initialPremiumDataGridViewTextBoxColumn1.Name = "initialPremiumDataGridViewTextBoxColumn1";
            this.initialPremiumDataGridViewTextBoxColumn1.ReadOnly = true;
            this.initialPremiumDataGridViewTextBoxColumn1.Width = 150;
            // 
            // iDDataGridViewTextBoxColumn1
            // 
            this.iDDataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn1.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.iDDataGridViewTextBoxColumn1.Name = "iDDataGridViewTextBoxColumn1";
            this.iDDataGridViewTextBoxColumn1.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn1.Width = 150;
            // 
            // statusDataGridViewTextBoxColumn1
            // 
            this.statusDataGridViewTextBoxColumn1.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn1.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.statusDataGridViewTextBoxColumn1.Name = "statusDataGridViewTextBoxColumn1";
            this.statusDataGridViewTextBoxColumn1.ReadOnly = true;
            this.statusDataGridViewTextBoxColumn1.Width = 150;
            // 
            // dealTypeDataGridViewTextBoxColumn1
            // 
            this.dealTypeDataGridViewTextBoxColumn1.DataPropertyName = "DealType";
            this.dealTypeDataGridViewTextBoxColumn1.HeaderText = "DealType";
            this.dealTypeDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dealTypeDataGridViewTextBoxColumn1.Name = "dealTypeDataGridViewTextBoxColumn1";
            this.dealTypeDataGridViewTextBoxColumn1.ReadOnly = true;
            this.dealTypeDataGridViewTextBoxColumn1.Width = 150;
            // 
            // strikeDataGridViewTextBoxColumn1
            // 
            this.strikeDataGridViewTextBoxColumn1.DataPropertyName = "Strike";
            this.strikeDataGridViewTextBoxColumn1.HeaderText = "Strike";
            this.strikeDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.strikeDataGridViewTextBoxColumn1.Name = "strikeDataGridViewTextBoxColumn1";
            this.strikeDataGridViewTextBoxColumn1.ReadOnly = true;
            this.strikeDataGridViewTextBoxColumn1.Width = 150;
            // 
            // isBuyDataGridViewCheckBoxColumn1
            // 
            this.isBuyDataGridViewCheckBoxColumn1.DataPropertyName = "IsBuy";
            this.isBuyDataGridViewCheckBoxColumn1.HeaderText = "IsBuy";
            this.isBuyDataGridViewCheckBoxColumn1.MinimumWidth = 8;
            this.isBuyDataGridViewCheckBoxColumn1.Name = "isBuyDataGridViewCheckBoxColumn1";
            this.isBuyDataGridViewCheckBoxColumn1.ReadOnly = true;
            this.isBuyDataGridViewCheckBoxColumn1.Width = 150;
            // 
            // lotDataGridViewTextBoxColumn1
            // 
            this.lotDataGridViewTextBoxColumn1.DataPropertyName = "Lot";
            this.lotDataGridViewTextBoxColumn1.HeaderText = "Lot";
            this.lotDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.lotDataGridViewTextBoxColumn1.Name = "lotDataGridViewTextBoxColumn1";
            this.lotDataGridViewTextBoxColumn1.ReadOnly = true;
            this.lotDataGridViewTextBoxColumn1.Width = 150;
            // 
            // tradeDateDataGridViewTextBoxColumn2
            // 
            this.tradeDateDataGridViewTextBoxColumn2.DataPropertyName = "TradeDate";
            this.tradeDateDataGridViewTextBoxColumn2.HeaderText = "TradeDate";
            this.tradeDateDataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.tradeDateDataGridViewTextBoxColumn2.Name = "tradeDateDataGridViewTextBoxColumn2";
            this.tradeDateDataGridViewTextBoxColumn2.ReadOnly = true;
            this.tradeDateDataGridViewTextBoxColumn2.Width = 150;
            // 
            // startDateDataGridViewTextBoxColumn1
            // 
            this.startDateDataGridViewTextBoxColumn1.DataPropertyName = "StartDate";
            this.startDateDataGridViewTextBoxColumn1.HeaderText = "StartDate";
            this.startDateDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.startDateDataGridViewTextBoxColumn1.Name = "startDateDataGridViewTextBoxColumn1";
            this.startDateDataGridViewTextBoxColumn1.ReadOnly = true;
            this.startDateDataGridViewTextBoxColumn1.Width = 150;
            // 
            // endDateDataGridViewTextBoxColumn1
            // 
            this.endDateDataGridViewTextBoxColumn1.DataPropertyName = "EndDate";
            this.endDateDataGridViewTextBoxColumn1.HeaderText = "EndDate";
            this.endDateDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.endDateDataGridViewTextBoxColumn1.Name = "endDateDataGridViewTextBoxColumn1";
            this.endDateDataGridViewTextBoxColumn1.ReadOnly = true;
            this.endDateDataGridViewTextBoxColumn1.Width = 150;
            // 
            // Form1View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1159, 688);
            this.Controls.Add(this.CalculatePVButton);
            this.Controls.Add(this.DGVIndications);
            this.Controls.Add(this.SetDealButton);
            this.Controls.Add(this.DGVTrades);
            this.Name = "Form1View";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.DGVTrades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.positionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVIndications)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealBindingSource)).EndInit();
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
        private System.Windows.Forms.Button CalculatePVButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn initialPremiumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dealTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn strikeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isBuyDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lotDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tradeDateDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tradeDatedataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn initialPremiumDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dealTypeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn strikeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isBuyDataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn lotDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tradeDateDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDateDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn endDateDataGridViewTextBoxColumn1;
    }
}

