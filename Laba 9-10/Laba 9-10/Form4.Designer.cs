namespace Laba_9_10
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            System.Windows.Forms.Label publ_nameLabel;
            System.Windows.Forms.Label publ_cityLabel;
            this.label1 = new System.Windows.Forms.Label();
            this.booksDataSet = new Laba_9_10.booksDataSet();
            this.publishingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.publishingTableAdapter = new Laba_9_10.booksDataSetTableAdapters.publishingTableAdapter();
            this.tableAdapterManager = new Laba_9_10.booksDataSetTableAdapters.TableAdapterManager();
            this.publishingBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.publishingBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.publ_nameTextBox = new System.Windows.Forms.TextBox();
            this.publ_cityTextBox = new System.Windows.Forms.TextBox();
            publ_nameLabel = new System.Windows.Forms.Label();
            publ_cityLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.booksDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.publishingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.publishingBindingNavigator)).BeginInit();
            this.publishingBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(25, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(339, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Таблица \"Издательства\"";
            // 
            // booksDataSet
            // 
            this.booksDataSet.DataSetName = "booksDataSet";
            this.booksDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // publishingBindingSource
            // 
            this.publishingBindingSource.DataMember = "publishing";
            this.publishingBindingSource.DataSource = this.booksDataSet;
            // 
            // publishingTableAdapter
            // 
            this.publishingTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.authorsTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.booksTableAdapter = null;
            this.tableAdapterManager.firmTableAdapter = null;
            this.tableAdapterManager.orderlistTableAdapter = null;
            this.tableAdapterManager.ordersTableAdapter = null;
            this.tableAdapterManager.publishingTableAdapter = this.publishingTableAdapter;
            this.tableAdapterManager.UpdateOrder = Laba_9_10.booksDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // publishingBindingNavigator
            // 
            this.publishingBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.publishingBindingNavigator.BindingSource = this.publishingBindingSource;
            this.publishingBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.publishingBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.publishingBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.publishingBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.publishingBindingNavigatorSaveItem});
            this.publishingBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.publishingBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.publishingBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.publishingBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.publishingBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.publishingBindingNavigator.Name = "publishingBindingNavigator";
            this.publishingBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.publishingBindingNavigator.Size = new System.Drawing.Size(398, 38);
            this.publishingBindingNavigator.TabIndex = 3;
            this.publishingBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(34, 20);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(34, 20);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 31);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(65, 25);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(34, 33);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // publishingBindingNavigatorSaveItem
            // 
            this.publishingBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.publishingBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("publishingBindingNavigatorSaveItem.Image")));
            this.publishingBindingNavigatorSaveItem.Name = "publishingBindingNavigatorSaveItem";
            this.publishingBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.publishingBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.publishingBindingNavigatorSaveItem.Click += new System.EventHandler(this.publishingBindingNavigatorSaveItem_Click);
            // 
            // publ_nameLabel
            // 
            publ_nameLabel.AutoSize = true;
            publ_nameLabel.Location = new System.Drawing.Point(32, 104);
            publ_nameLabel.Name = "publ_nameLabel";
            publ_nameLabel.Size = new System.Drawing.Size(87, 20);
            publ_nameLabel.TabIndex = 3;
            publ_nameLabel.Text = "publ name:";
            // 
            // publ_nameTextBox
            // 
            this.publ_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.publishingBindingSource, "publ_name", true));
            this.publ_nameTextBox.Location = new System.Drawing.Point(125, 101);
            this.publ_nameTextBox.Name = "publ_nameTextBox";
            this.publ_nameTextBox.Size = new System.Drawing.Size(239, 26);
            this.publ_nameTextBox.TabIndex = 4;
            // 
            // publ_cityLabel
            // 
            publ_cityLabel.AutoSize = true;
            publ_cityLabel.Location = new System.Drawing.Point(32, 140);
            publ_cityLabel.Name = "publ_cityLabel";
            publ_cityLabel.Size = new System.Drawing.Size(70, 20);
            publ_cityLabel.TabIndex = 4;
            publ_cityLabel.Text = "publ city:";
            // 
            // publ_cityTextBox
            // 
            this.publ_cityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.publishingBindingSource, "publ_city", true));
            this.publ_cityTextBox.Location = new System.Drawing.Point(108, 137);
            this.publ_cityTextBox.Name = "publ_cityTextBox";
            this.publ_cityTextBox.Size = new System.Drawing.Size(256, 26);
            this.publ_cityTextBox.TabIndex = 5;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 254);
            this.Controls.Add(publ_cityLabel);
            this.Controls.Add(this.publ_cityTextBox);
            this.Controls.Add(publ_nameLabel);
            this.Controls.Add(this.publ_nameTextBox);
            this.Controls.Add(this.publishingBindingNavigator);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.Text = "Таблица \"Издательства\"";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.booksDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.publishingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.publishingBindingNavigator)).EndInit();
            this.publishingBindingNavigator.ResumeLayout(false);
            this.publishingBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private booksDataSet booksDataSet;
        private System.Windows.Forms.BindingSource publishingBindingSource;
        private booksDataSetTableAdapters.publishingTableAdapter publishingTableAdapter;
        private booksDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator publishingBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton publishingBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox publ_nameTextBox;
        private System.Windows.Forms.TextBox publ_cityTextBox;
    }
}