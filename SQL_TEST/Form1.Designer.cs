namespace SQL_TEST
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.线圈DataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.输入状态DataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.保持寄存器DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.输入寄存器DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modbusbuffsqlBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.modbus_sqlDataSet = new SQL_TEST.modbus_sqlDataSet();
            this.modbus_buff_sqlTableAdapter = new SQL_TEST.modbus_sqlDataSetTableAdapters.modbus_buff_sqlTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modbusbuffsqlBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modbus_sqlDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(621, 81);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "连接SQL";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.线圈DataGridViewCheckBoxColumn,
            this.输入状态DataGridViewCheckBoxColumn,
            this.保持寄存器DataGridViewTextBoxColumn,
            this.输入寄存器DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.modbusbuffsqlBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(12, 110);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(684, 479);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValidated);
            this.dataGridView1.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dataGridView1_CellValidating);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 线圈DataGridViewCheckBoxColumn
            // 
            this.线圈DataGridViewCheckBoxColumn.DataPropertyName = "线圈";
            this.线圈DataGridViewCheckBoxColumn.HeaderText = "线圈";
            this.线圈DataGridViewCheckBoxColumn.Name = "线圈DataGridViewCheckBoxColumn";
            // 
            // 输入状态DataGridViewCheckBoxColumn
            // 
            this.输入状态DataGridViewCheckBoxColumn.DataPropertyName = "输入状态";
            this.输入状态DataGridViewCheckBoxColumn.HeaderText = "输入状态";
            this.输入状态DataGridViewCheckBoxColumn.Name = "输入状态DataGridViewCheckBoxColumn";
            // 
            // 保持寄存器DataGridViewTextBoxColumn
            // 
            this.保持寄存器DataGridViewTextBoxColumn.DataPropertyName = "保持寄存器";
            this.保持寄存器DataGridViewTextBoxColumn.HeaderText = "保持寄存器";
            this.保持寄存器DataGridViewTextBoxColumn.Name = "保持寄存器DataGridViewTextBoxColumn";
            // 
            // 输入寄存器DataGridViewTextBoxColumn
            // 
            this.输入寄存器DataGridViewTextBoxColumn.DataPropertyName = "输入寄存器";
            this.输入寄存器DataGridViewTextBoxColumn.HeaderText = "输入寄存器";
            this.输入寄存器DataGridViewTextBoxColumn.Name = "输入寄存器DataGridViewTextBoxColumn";
            // 
            // modbusbuffsqlBindingSource
            // 
            this.modbusbuffsqlBindingSource.DataMember = "modbus_buff_sql";
            this.modbusbuffsqlBindingSource.DataSource = this.modbus_sqlDataSet;
            // 
            // modbus_sqlDataSet
            // 
            this.modbus_sqlDataSet.DataSetName = "modbus_sqlDataSet";
            this.modbus_sqlDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // modbus_buff_sqlTableAdapter
            // 
            this.modbus_buff_sqlTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 671);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "Form1";
            this.Text = "SQL_TEST";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modbusbuffsqlBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modbus_sqlDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private modbus_sqlDataSet modbus_sqlDataSet;
        private System.Windows.Forms.BindingSource modbusbuffsqlBindingSource;
        private modbus_sqlDataSetTableAdapters.modbus_buff_sqlTableAdapter modbus_buff_sqlTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn 线圈DataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn 输入状态DataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 保持寄存器DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 输入寄存器DataGridViewTextBoxColumn;
    }
}

