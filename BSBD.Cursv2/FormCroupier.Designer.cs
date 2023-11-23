namespace BSBD.Cursv2
{
    partial class FormCroupier
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
            System.Windows.Forms.Label iD_КрупьеLabel;
            System.Windows.Forms.Label фLabel;
            System.Windows.Forms.Label иLabel;
            System.Windows.Forms.Label оLabel;
            System.Windows.Forms.Label паспортные_данныеLabel;
            System.Windows.Forms.Label стаж_работыLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCroupier));
            this.diamondCasinoDataSet = new BSBD.Cursv2.DiamondCasinoDataSet();
            this.крупьеBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.крупьеTableAdapter = new BSBD.Cursv2.DiamondCasinoDataSetTableAdapters.КрупьеTableAdapter();
            this.tableAdapterManager = new BSBD.Cursv2.DiamondCasinoDataSetTableAdapters.TableAdapterManager();
            this.крупьеBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.крупьеBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.iD_КрупьеTextBox = new System.Windows.Forms.TextBox();
            this.фTextBox = new System.Windows.Forms.TextBox();
            this.иTextBox = new System.Windows.Forms.TextBox();
            this.оTextBox = new System.Windows.Forms.TextBox();
            this.паспортные_данныеTextBox = new System.Windows.Forms.TextBox();
            this.стаж_работыTextBox = new System.Windows.Forms.TextBox();
            iD_КрупьеLabel = new System.Windows.Forms.Label();
            фLabel = new System.Windows.Forms.Label();
            иLabel = new System.Windows.Forms.Label();
            оLabel = new System.Windows.Forms.Label();
            паспортные_данныеLabel = new System.Windows.Forms.Label();
            стаж_работыLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.diamondCasinoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.крупьеBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.крупьеBindingNavigator)).BeginInit();
            this.крупьеBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // iD_КрупьеLabel
            // 
            iD_КрупьеLabel.AutoSize = true;
            iD_КрупьеLabel.Location = new System.Drawing.Point(33, 68);
            iD_КрупьеLabel.Name = "iD_КрупьеLabel";
            iD_КрупьеLabel.Size = new System.Drawing.Size(73, 16);
            iD_КрупьеLabel.TabIndex = 1;
            iD_КрупьеLabel.Text = "ID Крупье:";
            // 
            // фLabel
            // 
            фLabel.AutoSize = true;
            фLabel.Location = new System.Drawing.Point(33, 96);
            фLabel.Name = "фLabel";
            фLabel.Size = new System.Drawing.Size(21, 16);
            фLabel.TabIndex = 3;
            фLabel.Text = "Ф:";
            // 
            // иLabel
            // 
            иLabel.AutoSize = true;
            иLabel.Location = new System.Drawing.Point(33, 124);
            иLabel.Name = "иLabel";
            иLabel.Size = new System.Drawing.Size(20, 16);
            иLabel.TabIndex = 5;
            иLabel.Text = "И:";
            // 
            // оLabel
            // 
            оLabel.AutoSize = true;
            оLabel.Location = new System.Drawing.Point(33, 152);
            оLabel.Name = "оLabel";
            оLabel.Size = new System.Drawing.Size(20, 16);
            оLabel.TabIndex = 7;
            оLabel.Text = "О:";
            // 
            // паспортные_данныеLabel
            // 
            паспортные_данныеLabel.AutoSize = true;
            паспортные_данныеLabel.Location = new System.Drawing.Point(33, 180);
            паспортные_данныеLabel.Name = "паспортные_данныеLabel";
            паспортные_данныеLabel.Size = new System.Drawing.Size(143, 16);
            паспортные_данныеLabel.TabIndex = 9;
            паспортные_данныеLabel.Text = "Паспортные данные:";
            // 
            // стаж_работыLabel
            // 
            стаж_работыLabel.AutoSize = true;
            стаж_работыLabel.Location = new System.Drawing.Point(33, 208);
            стаж_работыLabel.Name = "стаж_работыLabel";
            стаж_работыLabel.Size = new System.Drawing.Size(94, 16);
            стаж_работыLabel.TabIndex = 11;
            стаж_работыLabel.Text = "Стаж работы:";
            // 
            // diamondCasinoDataSet
            // 
            this.diamondCasinoDataSet.DataSetName = "DiamondCasinoDataSet";
            this.diamondCasinoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // крупьеBindingSource
            // 
            this.крупьеBindingSource.DataMember = "Крупье";
            this.крупьеBindingSource.DataSource = this.diamondCasinoDataSet;
            // 
            // крупьеTableAdapter
            // 
            this.крупьеTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.RoleTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = BSBD.Cursv2.DiamondCasinoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Запись_игрыTableAdapter = null;
            this.tableAdapterManager.ИграTableAdapter = null;
            this.tableAdapterManager.ИгрокTableAdapter = null;
            this.tableAdapterManager.КрупьеTableAdapter = this.крупьеTableAdapter;
            this.tableAdapterManager.СтавкаTableAdapter = null;
            // 
            // крупьеBindingNavigator
            // 
            this.крупьеBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.крупьеBindingNavigator.BindingSource = this.крупьеBindingSource;
            this.крупьеBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.крупьеBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.крупьеBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.крупьеBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.крупьеBindingNavigatorSaveItem});
            this.крупьеBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.крупьеBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.крупьеBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.крупьеBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.крупьеBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.крупьеBindingNavigator.Name = "крупьеBindingNavigator";
            this.крупьеBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.крупьеBindingNavigator.Size = new System.Drawing.Size(800, 31);
            this.крупьеBindingNavigator.TabIndex = 0;
            this.крупьеBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(55, 28);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 31);
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
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // крупьеBindingNavigatorSaveItem
            // 
            this.крупьеBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.крупьеBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("крупьеBindingNavigatorSaveItem.Image")));
            this.крупьеBindingNavigatorSaveItem.Name = "крупьеBindingNavigatorSaveItem";
            this.крупьеBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 28);
            this.крупьеBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.крупьеBindingNavigatorSaveItem.Click += new System.EventHandler(this.крупьеBindingNavigatorSaveItem_Click);
            // 
            // iD_КрупьеTextBox
            // 
            this.iD_КрупьеTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.крупьеBindingSource, "ID_Крупье", true));
            this.iD_КрупьеTextBox.Location = new System.Drawing.Point(182, 65);
            this.iD_КрупьеTextBox.Name = "iD_КрупьеTextBox";
            this.iD_КрупьеTextBox.Size = new System.Drawing.Size(100, 22);
            this.iD_КрупьеTextBox.TabIndex = 2;
            this.iD_КрупьеTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Stop);
            this.iD_КрупьеTextBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Stop);
            // 
            // фTextBox
            // 
            this.фTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.крупьеBindingSource, "Ф", true));
            this.фTextBox.Location = new System.Drawing.Point(182, 93);
            this.фTextBox.Name = "фTextBox";
            this.фTextBox.Size = new System.Drawing.Size(100, 22);
            this.фTextBox.TabIndex = 4;
            this.фTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Stop);
            this.фTextBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Stop);
            // 
            // иTextBox
            // 
            this.иTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.крупьеBindingSource, "И", true));
            this.иTextBox.Location = new System.Drawing.Point(182, 121);
            this.иTextBox.Name = "иTextBox";
            this.иTextBox.Size = new System.Drawing.Size(100, 22);
            this.иTextBox.TabIndex = 6;
            this.иTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Stop);
            this.иTextBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Stop);
            // 
            // оTextBox
            // 
            this.оTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.крупьеBindingSource, "О", true));
            this.оTextBox.Location = new System.Drawing.Point(182, 149);
            this.оTextBox.Name = "оTextBox";
            this.оTextBox.Size = new System.Drawing.Size(100, 22);
            this.оTextBox.TabIndex = 8;
            this.оTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Stop);
            this.оTextBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Stop);
            // 
            // паспортные_данныеTextBox
            // 
            this.паспортные_данныеTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.крупьеBindingSource, "Паспортные_данные", true));
            this.паспортные_данныеTextBox.Location = new System.Drawing.Point(182, 177);
            this.паспортные_данныеTextBox.Name = "паспортные_данныеTextBox";
            this.паспортные_данныеTextBox.Size = new System.Drawing.Size(100, 22);
            this.паспортные_данныеTextBox.TabIndex = 10;
            this.паспортные_данныеTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Stop);
            this.паспортные_данныеTextBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Stop);
            // 
            // стаж_работыTextBox
            // 
            this.стаж_работыTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.крупьеBindingSource, "Стаж_работы", true));
            this.стаж_работыTextBox.Location = new System.Drawing.Point(182, 205);
            this.стаж_работыTextBox.Name = "стаж_работыTextBox";
            this.стаж_работыTextBox.Size = new System.Drawing.Size(100, 22);
            this.стаж_работыTextBox.TabIndex = 12;
            this.стаж_работыTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Stop);
            this.стаж_работыTextBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Stop);
            // 
            // FormCroupier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(iD_КрупьеLabel);
            this.Controls.Add(this.iD_КрупьеTextBox);
            this.Controls.Add(фLabel);
            this.Controls.Add(this.фTextBox);
            this.Controls.Add(иLabel);
            this.Controls.Add(this.иTextBox);
            this.Controls.Add(оLabel);
            this.Controls.Add(this.оTextBox);
            this.Controls.Add(паспортные_данныеLabel);
            this.Controls.Add(this.паспортные_данныеTextBox);
            this.Controls.Add(стаж_работыLabel);
            this.Controls.Add(this.стаж_работыTextBox);
            this.Controls.Add(this.крупьеBindingNavigator);
            this.Name = "FormCroupier";
            this.Text = "Крупье";
            this.Load += new System.EventHandler(this.FormCroupier_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Stop);
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Stop);
            ((System.ComponentModel.ISupportInitialize)(this.diamondCasinoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.крупьеBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.крупьеBindingNavigator)).EndInit();
            this.крупьеBindingNavigator.ResumeLayout(false);
            this.крупьеBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DiamondCasinoDataSet diamondCasinoDataSet;
        private System.Windows.Forms.BindingSource крупьеBindingSource;
        private DiamondCasinoDataSetTableAdapters.КрупьеTableAdapter крупьеTableAdapter;
        private DiamondCasinoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator крупьеBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton крупьеBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox iD_КрупьеTextBox;
        private System.Windows.Forms.TextBox фTextBox;
        private System.Windows.Forms.TextBox иTextBox;
        private System.Windows.Forms.TextBox оTextBox;
        private System.Windows.Forms.TextBox паспортные_данныеTextBox;
        private System.Windows.Forms.TextBox стаж_работыTextBox;
    }
}