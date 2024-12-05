namespace WinFormsAppIdeaProy
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
            label1 = new Label();
            comboBoxCategoriaModf = new ComboBox();
            label6 = new Label();
            label4 = new Label();
            textBoxStock = new TextBox();
            label3 = new Label();
            label2 = new Label();
            textBoxPrecioUn = new TextBox();
            textBoxNomProd = new TextBox();
            labelOption = new Label();
            buttonModf = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(125, 29);
            label1.Name = "label1";
            label1.Size = new Size(150, 15);
            label1.TabIndex = 0;
            label1.Text = "Form para modificar datos ";
            label1.Click += label1_Click;
            // 
            // comboBoxCategoriaModf
            // 
            comboBoxCategoriaModf.FormattingEnabled = true;
            comboBoxCategoriaModf.Location = new Point(225, 205);
            comboBoxCategoriaModf.Name = "comboBoxCategoriaModf";
            comboBoxCategoriaModf.Size = new Size(107, 23);
            comboBoxCategoriaModf.TabIndex = 38;
            comboBoxCategoriaModf.SelectedIndexChanged += comboBoxCategoria_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(97, 208);
            label6.Name = "label6";
            label6.Size = new Size(58, 15);
            label6.TabIndex = 37;
            label6.Text = "Categoria";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(97, 172);
            label4.Name = "label4";
            label4.Size = new Size(94, 15);
            label4.TabIndex = 36;
            label4.Text = "Stock disponible";
            // 
            // textBoxStock
            // 
            textBoxStock.Location = new Point(225, 169);
            textBoxStock.Name = "textBoxStock";
            textBoxStock.Size = new Size(107, 23);
            textBoxStock.TabIndex = 35;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(97, 132);
            label3.Name = "label3";
            label3.Size = new Size(84, 15);
            label3.TabIndex = 34;
            label3.Text = "Precio unitario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(97, 91);
            label2.Name = "label2";
            label2.Size = new Size(122, 15);
            label2.TabIndex = 33;
            label2.Text = "Nombre del producto";
            // 
            // textBoxPrecioUn
            // 
            textBoxPrecioUn.Location = new Point(225, 129);
            textBoxPrecioUn.Name = "textBoxPrecioUn";
            textBoxPrecioUn.Size = new Size(107, 23);
            textBoxPrecioUn.TabIndex = 32;
            // 
            // textBoxNomProd
            // 
            textBoxNomProd.Location = new Point(225, 88);
            textBoxNomProd.Name = "textBoxNomProd";
            textBoxNomProd.Size = new Size(107, 23);
            textBoxNomProd.TabIndex = 31;
            // 
            // labelOption
            // 
            labelOption.AutoSize = true;
            labelOption.Location = new Point(281, 29);
            labelOption.Name = "labelOption";
            labelOption.Size = new Size(37, 15);
            labelOption.TabIndex = 39;
            labelOption.Text = "          ";
            // 
            // buttonModf
            // 
            buttonModf.Location = new Point(154, 265);
            buttonModf.Name = "buttonModf";
            buttonModf.Size = new Size(110, 29);
            buttonModf.TabIndex = 40;
            buttonModf.Text = "Modificar";
            buttonModf.UseVisualStyleBackColor = true;
            buttonModf.Click += buttonModf_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(440, 350);
            Controls.Add(buttonModf);
            Controls.Add(labelOption);
            Controls.Add(comboBoxCategoriaModf);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(textBoxStock);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBoxPrecioUn);
            Controls.Add(textBoxNomProd);
            Controls.Add(label1);
            Name = "Form4";
            Text = "Form4";
            Load += Form4_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox comboBoxCategoriaModf;
        private Label label6;
        private Label label4;
        private TextBox textBoxStock;
        private Label label3;
        private Label label2;
        private TextBox textBoxPrecioUn;
        private TextBox textBoxNomProd;
        private Label labelOption;
        private Button buttonModf;
    }
}