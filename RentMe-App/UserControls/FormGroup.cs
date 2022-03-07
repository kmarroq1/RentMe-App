using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace RentMe_App.UserControls
{
    public class FormGroup : TableLayoutPanel
    {
        public Label FormGroupLabel { get; }
        public TextBox FormGroupTextBox { get; }

        public FormGroup(string field) : base()
        {
            ColumnCount = 2;
            ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
            ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
            
            Name = $"{field}FormGroup";
            
            RowCount = 1;
            RowStyles.Add(new RowStyle(SizeType.AutoSize));
            
            Size = new Size(196, 26);

            FormGroupLabel = CreateLabel(field);
            Controls.Add(FormGroupLabel, 0, 0);

            FormGroupTextBox = CreateTextBox(field);
            Controls.Add(FormGroupTextBox, 1, 0);
        }

        private Label CreateLabel(string field)
        {
            Label formGroupLabel = new Label
            {
                Anchor = AnchorStyles.Right,
                Name = $"{Regex.Replace(field, @"\s+", "")}Label",
                Text = field,
            };

            return formGroupLabel;
        }

        private TextBox CreateTextBox(string field)
        {
            TextBox formGroupTextBox = new TextBox
            {
                Name = $"{Regex.Replace(field, @"\s+", "")}TextBox",
                Size = new Size(92, 20),
            };

            return formGroupTextBox;
        }
    }
}
