namespace WinApplicationLearn
{
    public partial class MainForm : Form
    {

        internal ICalculationPreset[] calculationPreset = new ICalculationPreset[]
        {
            new WarcraftCalculationPreset(),
            new DotaCalculatorPreset(),
        };

        ICalculationPreset selectedPreset;

        List<string> getPresetsName()
        {
            var list = new List<string>();
            foreach (var str in from calc in calculationPreset
                                select calc.PresetName)
            {
                list.Add(str);
            }

            return list;
        }

        void initializePreset(in ICalculationPreset preset)
        {
            AttackTypeBox.DataSource = preset.AttackTypeData;
            AttackValueBox.Text = "0";
            ArmorTypeBox.DataSource = preset.ArmorTypeData;
            ArmorValueBox.Text = "0";
            totalDamageText.Text = "0";
            attack = new Attack();
            armor = new Armor();
        }
        public MainForm()
        {
            InitializeComponent();
            PresetBox.DataSource = getPresetsName();
            selectedPreset = calculationPreset[0];
            initializePreset(selectedPreset);
        }

        Attack attack;
        Armor armor;

        private void AttackTypeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            attack.Type = AttackTypeBox.SelectedIndex;
            totalDamageText.Text = selectedPreset.calculateDamage(attack, armor).ToString();
        }

        private void ArmorTypeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            armor.Type = ArmorTypeBox.SelectedIndex;
            totalDamageText.Text = selectedPreset.calculateDamage(attack, armor).ToString();
        }

        private void AttackValueBox_TextChanged(object sender, EventArgs e)
        {
            if (Single.TryParse(AttackValueBox.Text, out float damage))
            {
                attack.Value = damage;
                totalDamageText.Text = selectedPreset.calculateDamage(attack, armor).ToString();
            } else
            {
                totalDamageText.Text = "Ошибка!";
            }
        }

        private void ArmorValueBox_TextChanged(object sender, EventArgs e)
        {
            if (Single.TryParse(ArmorValueBox.Text, out float arm))
            {
                armor.Value = arm;
                totalDamageText.Text = selectedPreset.calculateDamage(attack, armor).ToString();
            }
            else
            {
                totalDamageText.Text = "Ошибка!";
            }
        }

        private void PresetBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedPreset = calculationPreset[PresetBox.SelectedIndex];
            initializePreset(selectedPreset);
        }
    }
}