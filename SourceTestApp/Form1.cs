using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SourceTestApp
{
    public partial class Form1 : Form
    {
        //define parts dictionary for User interface
        Dictionary<string, Source> PartDictionary = new Dictionary<string, Source>()
        {
            { "012112-003", new Source("K-2715-P", 0.005388, "2.0E+09", 0) },
            { "012112-004", new Source("K-1722-R", 0.005388, "200", 0)},
            { "012125-001", new Source("S-1349-T", 0.002063, "200", 1)},
            { "012139-001", new Source("HZ491", 0.022018, "200", 0) }
        };

        public Form1()
        {
            InitializeComponent();
            // add part no. into comboBox
            foreach (string key in PartDictionary.Keys)
                PartCombo.Items.Add(key);
            //PartCombo.Select();
        }

        private void PartCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Source source1 = PartDictionary[(string)PartCombo.SelectedItem] as Source;

            SerialNumberResult.Text = source1.SerialNo;
            DecayConstantResult.Text = source1.DecayConstant.ToString();
            HigMegResult.Text = source1.HigMeg;

        }

        private void IntensityButton_Click(object sender, EventArgs e)
        {

        }

        private void ReadingVoltage()
        {

        }
    }
}
