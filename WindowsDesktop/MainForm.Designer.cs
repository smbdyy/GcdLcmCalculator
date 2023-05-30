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
    private Label _resultLabel;
    private Button _showSolutionButton;
    private Button _loadDataFromTableButton;
    private Label _numberBLabel;
    private NumericUpDown _numberAInput;
    private NumericUpDown _numberBInput;
    private Label _numberALabel;

    private void InitializeComponent()
    {
        _numberAInput = new NumericUpDown();
        _numberBInput = new NumericUpDown();
        _numberALabel = new Label();
        _numberBLabel = new Label();
        _showSolutionButton = new Button();
        _loadDataFromTableButton = new Button();
        _resultLabel = new Label();
        _calculateButton = new Button();
        ((System.ComponentModel.ISupportInitialize)(_numberAInput)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(_numberBInput)).BeginInit();
        SuspendLayout();
        //
        // _numberAInput
        //
        _numberAInput.Location = new System.Drawing.Point(39, 66);
        _numberAInput.Minimum = Decimal.One;
        _numberAInput.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
        _numberAInput.DecimalPlaces = 0;
        _numberAInput.Name = "_numberAInput";
        _numberAInput.Size = new System.Drawing.Size(92, 22);
        _numberAInput.TabIndex = 0;
        _numberAInput.KeyPress += new KeyPressEventHandler(NumericUpDown_KeyPress);
        //
        // _numberBInput
        //
        _numberBInput.Location = new System.Drawing.Point(205, 66);
        _numberBInput.Minimum = Decimal.One;
        _numberBInput.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
        _numberBInput.DecimalPlaces = 0;
        _numberBInput.Name = "_numberBInput";
        _numberBInput.Size = new System.Drawing.Size(92, 22);
        _numberBInput.TabIndex = 1;
        _numberBInput.KeyPress += new KeyPressEventHandler(NumericUpDown_KeyPress);
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
        // _showSolutionButton
        //
        _showSolutionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        _showSolutionButton.Location = new System.Drawing.Point(55, 181);
        _showSolutionButton.Name = "_showSolutionButton";
        _showSolutionButton.Size = new System.Drawing.Size(227, 33);
        _showSolutionButton.TabIndex = 4;
        _showSolutionButton.Text = "Показать решение";
        _showSolutionButton.UseVisualStyleBackColor = true;
        _showSolutionButton.Click += new EventHandler(ShowSolutionButton_Clicked);
        //
        // _loadDataFromTableButton
        //
        _loadDataFromTableButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        _loadDataFromTableButton.Location = new System.Drawing.Point(55, 241);
        _loadDataFromTableButton.Name = "_loadDataFromTableButton";
        _loadDataFromTableButton.Size = new System.Drawing.Size(227, 33);
        _loadDataFromTableButton.TabIndex = 5;
        _loadDataFromTableButton.Text = "Ввести данные из таблицы";
        _loadDataFromTableButton.UseVisualStyleBackColor = true;
        _loadDataFromTableButton.Click += new EventHandler(LoadDataFromTableButton_Clicked);
        //
        // _resultLabel
        //
        _resultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        _resultLabel.Location = new System.Drawing.Point(29, 301);
        _resultLabel.Name = "_resultLabel";
        _resultLabel.Size = new System.Drawing.Size(281, 30);
        _resultLabel.TabIndex = 6;
        _resultLabel.Text = string.Empty;
        _resultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        //
        // _calculateButton
        //
        _calculateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        _calculateButton.Location = new System.Drawing.Point(55, 121);
        _calculateButton.Name = "_calculateButton";
        _calculateButton.Size = new System.Drawing.Size(227, 33);
        _calculateButton.TabIndex = 7;
        _calculateButton.Text = "Вычислить НОД и НОК";
        _calculateButton.UseVisualStyleBackColor = true;
        _calculateButton.Click += new EventHandler(CalculateButton_Clicked);
        //
        // MainForm
        //
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(349, 355);
        Controls.Add(_calculateButton);
        Controls.Add(_resultLabel);
        Controls.Add(_loadDataFromTableButton);
        Controls.Add(_showSolutionButton);
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