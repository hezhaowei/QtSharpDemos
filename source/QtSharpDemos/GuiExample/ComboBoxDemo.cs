using QtGui;
using QtWidgets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QtSharpDemos.GuiExample
{
    public class ComboBoxDemo : QtWidgets.QWidget
    {
        QLabel label;

        public ComboBoxDemo()
        {
            WindowTitle = "ComboBox Demo";

            InitUI();

            Resize(250, 200);
            Move(100, 100);
            Show();
        }

        public void InitUI()
        {
            label = new QLabel("Ubuntu", this);

            var combo = new QComboBox(this);
            combo.AddItem("Ubuntu");
            combo.AddItem("Arch");
            combo.AddItem("Fedora");
            combo.AddItem("Red Hat");
            combo.AddItem("Gentoo");

            combo.Move(50, 30);
            label.Move(50, 100);

#if !DEBUG_X64
            combo.ActivatedText += OnActivated;
#else
            combo.ActivatedString += OnActivated;
#endif
        }

        public void OnActivated(string text)
        {
            label.Text = text;
            label.AdjustSize();
        }
    }
}
