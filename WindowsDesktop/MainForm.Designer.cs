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


    private Label _resultLabel;
    private Button _calculateGcdButton;
    private Button _calculateLcmButton;
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
        _calculateGcdButton = new Button();
        _calculateLcmButton = new Button();
        _resultLabel = new Label();
        ((System.ComponentModel.ISupportInitialize)(_numberAInput)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(_numberBInput)).BeginInit();
        SuspendLayout();
        //
        // _numberAInput
        //
        _numberAInput.Location = new System.Drawing.Point(48, 66);
        _numberAInput.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
        _numberAInput.Name = "_numberAInput";
        _numberAInput.Size = new System.Drawing.Size(92, 22);
        _numberAInput.TabIndex = 0;
        //
        // _numberBInput
        //
        _numberBInput.Location = new System.Drawing.Point(48, 131);
        _numberBInput.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
        _numberBInput.Name = "_numberBInput";
        _numberBInput.Size = new System.Drawing.Size(92, 22);
        _numberBInput.TabIndex = 1;
        //
        // _numberALabel
        //
        _numberALabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        _numberALabel.Location = new System.Drawing.Point(39, 36);
        _numberALabel.Margin = new System.Windows.Forms.Padding(0);
        _numberALabel.Name = "_numberALabel";
        _numberALabel.Size = new System.Drawing.Size(239, 27);
        _numberALabel.TabIndex = 2;
        _numberALabel.Text = "Первое число";
        //
        // _numberBLabel
        //
        _numberBLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        _numberBLabel.Location = new System.Drawing.Point(39, 101);
        _numberBLabel.Name = "_numberBLabel";
        _numberBLabel.Size = new System.Drawing.Size(239, 27);
        _numberBLabel.TabIndex = 3;
        _numberBLabel.Text = "Второе число";
        //
        // _calculateGcdButton
        //
        _calculateGcdButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        _calculateGcdButton.Location = new System.Drawing.Point(39, 181);
        _calculateGcdButton.Name = "_calculateGcdButton";
        _calculateGcdButton.Size = new System.Drawing.Size(172, 32);
        _calculateGcdButton.TabIndex = 4;
        _calculateGcdButton.Text = "Вычислить НОД";
        _calculateGcdButton.UseVisualStyleBackColor = true;
        //
        // _calculateLcmButton
        //
        _calculateLcmButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        _calculateLcmButton.Location = new System.Drawing.Point(39, 219);
        _calculateLcmButton.Name = "_calculateLcmButton";
        _calculateLcmButton.Size = new System.Drawing.Size(172, 32);
        _calculateLcmButton.TabIndex = 5;
        _calculateLcmButton.Text = "Вычислить НОК";
        _calculateLcmButton.UseVisualStyleBackColor = true;
        //
        // _resultLabel
        //
        _resultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        _resultLabel.Location = new System.Drawing.Point(39, 270);
        _resultLabel.Name = "_resultLabel";
        _resultLabel.Size = new System.Drawing.Size(219, 35);
        _resultLabel.TabIndex = 6;
        _resultLabel.Text = "";
        //
        // MainForm
        //
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(287, 323);
        Controls.Add(_resultLabel);
        Controls.Add(_calculateLcmButton);
        Controls.Add(_calculateGcdButton);
        Controls.Add(_numberBLabel);
        Controls.Add(_numberALabel);
        Controls.Add(_numberBInput);
        Controls.Add(_numberAInput);
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "MainForm";
        SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
        Text = "GcdLcmCalculator";
        TopMost = true;
        FormBorderStyle = FormBorderStyle.FixedSingle;
        ((System.ComponentModel.ISupportInitialize)(_numberAInput)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(_numberBInput)).EndInit();
        ResumeLayout(false);
    }
}