using System.ComponentModel;

namespace WindowsDesktop;

partial class CalculationResultsDialog
{
    private IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        _messageBox = new Label();
        _saveResultsButton = new Button();
        SuspendLayout();
        //
        // _messageBox
        //
        _messageBox.Location = new System.Drawing.Point(50, 30);
        _messageBox.MaximumSize = new System.Drawing.Size(250, 0);
        _messageBox.Name = "_messageBox";
        _messageBox.AutoSize = true;
        _messageBox.TabIndex = 0;
        //
        // _saveResultsButton
        //
        _saveResultsButton.Location = new System.Drawing.Point(75, 120);
        _saveResultsButton.Name = "_saveResultsButton";
        _saveResultsButton.Size = new System.Drawing.Size(200, 30);
        _saveResultsButton.TabIndex = 1;
        _saveResultsButton.Text = "Сохранить результаты";
        _saveResultsButton.UseVisualStyleBackColor = true;
        //
        // CalculationResultsDialog
        //
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
        AutoScaleMode = AutoScaleMode.Font;
        AutoSize = true;
        ClientSize = new System.Drawing.Size(344, 100);
        Controls.Add(_saveResultsButton);
        Controls.Add(_messageBox);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "CalculationResultsDialog";
        Text = "Результаты";
        ResumeLayout(false);
    }

    private Button _saveResultsButton;
    private Label _messageBox;
}