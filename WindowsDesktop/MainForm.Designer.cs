namespace WindowsDesktop;

partial class MainForm
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    private Button _calculateButton;
    private Button _inputDataFromTableButton;
    private NumericUpDown _numberAInput;
    private NumericUpDown _numberBInput;
    private Label _numberALabel;
    private Label _numberBLabel;

    private void InitializeComponent()
    {
        _numberAInput = new NumericUpDown();
        _numberBInput = new NumericUpDown();
        _numberALabel = new Label();
        _numberBLabel = new Label();
        _calculateButton = new Button();
        _inputDataFromTableButton = new Button();
        ((System.ComponentModel.ISupportInitialize)(_numberAInput)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(_numberBInput)).BeginInit();
        SuspendLayout();
        //
        // _numberAInput
        //
        _numberAInput.Location = new System.Drawing.Point(39, 66);
        _numberAInput.Minimum = Decimal.One;
        _numberAInput.Maximum = 10000;
        _numberAInput.Name = "_numberAInput";
        _numberAInput.Size = new System.Drawing.Size(92, 22);
        _numberAInput.TabIndex = 0;
        //
        // _numberBInput
        //
        _numberBInput.Location = new System.Drawing.Point(205, 66);
        _numberBInput.Minimum = Decimal.One;
        _numberBInput.Maximum = 10000;
        _numberBInput.Name = "_numberBInput";
        _numberBInput.Size = new System.Drawing.Size(92, 22);
        _numberBInput.TabIndex = 1;
        //
        // _numberALabel
        //
        _numberALabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        _numberALabel.Location = new System.Drawing.Point(29, 36);
        _numberALabel.Margin = new Padding(0);
        _numberALabel.Name = "_numberALabel";
        _numberALabel.Size = new System.Drawing.Size(141, 27);
        _numberALabel.TabIndex = 2;
        _numberALabel.Text = "Первое число";
        //
        // _numberBLabel
        //
        _numberBLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        _numberBLabel.Location = new System.Drawing.Point(196, 36);
        _numberBLabel.Name = "_numberBLabel";
        _numberBLabel.Size = new System.Drawing.Size(141, 27);
        _numberBLabel.TabIndex = 3;
        _numberBLabel.Text = "Второе число";
        //
        // _calculateButton
        //
        _calculateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        _calculateButton.Location = new System.Drawing.Point(55, 123);
        _calculateButton.Name = "_calculateButton";
        _calculateButton.Size = new System.Drawing.Size(227, 33);
        _calculateButton.TabIndex = 4;
        _calculateButton.Text = "Вычислить НОД и НОК";
        _calculateButton.UseVisualStyleBackColor = true;
        //
        // _inputDataFromTableButton
        //
        _inputDataFromTableButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        _inputDataFromTableButton.Location = new System.Drawing.Point(55, 170);
        _inputDataFromTableButton.Name = "_inputDataFromTableButton";
        _inputDataFromTableButton.Size = new System.Drawing.Size(227, 33);
        _inputDataFromTableButton.TabIndex = 5;
        _inputDataFromTableButton.Text = "Ввести данные из таблицы";
        _inputDataFromTableButton.UseVisualStyleBackColor = true;
        //
        // MainForm
        //
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(349, 238);
        Controls.Add(_inputDataFromTableButton);
        Controls.Add(_calculateButton);
        Controls.Add(_numberBLabel);
        Controls.Add(_numberALabel);
        Controls.Add(_numberBInput);
        Controls.Add(_numberAInput);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "MainForm";
        SizeGripStyle = SizeGripStyle.Hide;
        Text = "GcdLcmCalculator";
        TopMost = true;
        ((System.ComponentModel.ISupportInitialize)(_numberAInput)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(_numberBInput)).EndInit();
        ResumeLayout(false);
    }
}