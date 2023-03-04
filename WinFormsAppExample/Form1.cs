using System.Diagnostics;
using System.Windows.Forms;

namespace WinFormsAppExample;

public partial class Form1 : Form
{
    public Form1()
    {
        MouseMove += (sender, args) =>
        {
            Debug.WriteLine(args.Location);
        };

        //MouseWheel += (sender, args) =>
        //{
        //    Debug.WriteLine(args.Location);
        //};

        InitializeComponent();
    }
}
