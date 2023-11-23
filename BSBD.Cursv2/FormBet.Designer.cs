namespace BSBD.Cursv2
{
    partial class FormBet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBet));
            this.diamondCasinoDataSet = new BSBD.Cursv2.DiamondCasinoDataSet();
            this.ставкаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ставкаTableAdapter = new BSBD.Cursv2.DiamondCasinoDataSetTableAdapters.СтавкаTableAdapter();
            this.tableAdapterManager = new BSBD.Cursv2.DiamondCasinoDataSetTableAdapters.TableAdapterManager();
            this.ставкаBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ставкаBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.ставкаDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.diamondCasinoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ставкаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ставкаBindingNavigator)).BeginInit();
            this.ставкаBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ставкаDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // diamondCasinoDataSet
            // 
            this.diamondCasinoDataSet.DataSetName = "DiamondCasinoDataSet";
            this.diamondCasinoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ставкаBindingSource
            // 
            this.ставкаBindingSource.DataMember = "Ставка";
            this.ставкаBindingSource.DataSource = this.diamondCasinoDataSet;
            // 
            // ставкаTableAdapter
            // 
            this.ставкаTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.RoleTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = BSBD.Cursv2.DiamondCasinoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Запись_игрыTableAdapter = null;
            this.tableAdapterManager.ИграTableAdapter = null;
            this.tableAdapterManager.ИгрокTableAdapter = null;
            this.tableAdapterManager.КрупьеTableAdapter = null;
            this.tableAdapterManager.СтавкаTableAdapter = this.ставкаTableAdapter;
            // 
            // ставкаBindingNavigator
            // 
            this.ставкаBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.ставкаBindingNavigator.BindingSource = this.ставкаBindingSource;
            this.ставкаBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.ставкаBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.ставкаBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ставкаBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.ставкаBindingNavigatorSaveItem});
            this.ставкаBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.ставкаBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.ставкаBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.ставкаBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.ставкаBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.ставкаBindingNavigator.Name = "ставкаBindingNavigator";
            this.ставкаBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.ставкаBindingNavigator.Size = new System.Drawing.Size(820, 27);
            this.ставкаBindingNavigator.TabIndex = 0;
            this.ставкаBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(55, 24);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // ставкаBindingNavigatorSaveItem
            // 
            this.ставкаBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ставкаBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("ставкаBindingNavigatorSaveItem.Image")));
            this.ставкаBindingNavigatorSaveItem.Name = "ставкаBindingNavigatorSaveItem";
            this.ставкаBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.ставкаBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.ставкаBindingNavigatorSaveItem.Click += new System.EventHandler(this.ставкаBindingNavigatorSaveItem_Click);
            // 
            // ставкаDataGridView
            // 
            this.ставкаDataGridView.AutoGenerateColumns = false;
            this.ставкаDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ставкаDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.ставкаDataGridView.DataSource = this.ставкаBindingSource;
            this.ставкаDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ставкаDataGridView.Location = new System.Drawing.Point(0, 27);
            this.ставкаDataGridView.Name = "ставкаDataGridView";
            this.ставкаDataGridView.RowHeadersWidth = 51;
            this.ставкаDataGridView.RowTemplate.Height = 24;
            this.ставкаDataGridView.Size = new System.Drawing.Size(820, 476);
            this.ставкаDataGridView.TabIndex = 1;
            this.ставкаDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Stop);
            this.ставкаDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Stop);
            this.ставкаDataGridView.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Stop);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_Ставки";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID_Ставки";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Сумма_ставки";
            this.dataGridViewTextBoxColumn2.HeaderText = "Сумма_ставки";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ID_ИгрокаВИгре";
            this.dataGridViewTextBoxColumn3.HeaderText = "ID_ИгрокаВИгре";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // FormBet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 503);
            this.Controls.Add(this.ставкаDataGridView);
            this.Controls.Add(this.ставкаBindingNavigator);
            this.Name = "FormBet";
            this.Text = "Ставка";
            this.Load += new System.EventHandler(this.FormBet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.diamondCasinoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ставкаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ставкаBindingNavigator)).EndInit();
            this.ставкаBindingNavigator.ResumeLayout(false);
            this.ставкаBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ставкаDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DiamondCasinoDataSet diamondCasinoDataSet;
        private System.Windows.Forms.BindingSource ставкаBindingSource;
        private DiamondCasinoDataSetTableAdapters.СтавкаTableAdapter ставкаTableAdapter;
        private DiamondCasinoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator ставкаBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton ставкаBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView ставкаDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}