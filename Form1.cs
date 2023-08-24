using OpenQA.Selenium.DevTools.V113.WebAuthn;

namespace Parsers
{
    public partial class Form1 : Form
    {
        private string PATHAPPCMD; private string PATHAPPSET;
        private bool SAVE = false;
        public Form1()
        {
            InitializeComponent();
            CreateDirectory(Environment.CurrentDirectory);
            comboActs.Items.Add("�������");
            comboActs.Items.Add("��������");
        }

        /// <summary>
        /// �������� ������� ����������
        /// </summary>
        /// <param name="currentDirectory"></param>
        private void CreateDirectory(string currentDirectory)
        {
            comboBox1.Items.Add("ldor");
            comboBox1.Items.Add("sitilink");
            PATHAPPCMD = currentDirectory + @"\AppComands\";
            PATHAPPSET = currentDirectory + @"\AppData\";
            Directory.CreateDirectory(PATHAPPCMD);
            Directory.CreateDirectory(PATHAPPSET);
            if (!File.Exists($@"{PATHAPPSET}settings.json"))
            {
                CheckSettings(PATHAPPSET);
            }
            else
            {
                var jsString = File.ReadAllText($@"{PATHAPPSET}settings.json");
                var settings = Newtonsoft.Json.JsonConvert.DeserializeObject<Settings>(jsString);
                foreach (var item in settings.AllItems)
                {
                    string jsStringIt = File.ReadAllText(item);
                    var it = Newtonsoft.Json.JsonConvert.DeserializeObject<Item>(jsStringIt);
                    comboItems.Items.Add(it.Name + " " + it.Creater);
                }
            }
        }


        /// <summary>
        /// �������� �������� ����-���
        /// </summary>
        /// <param name="pathappset"></param>
        private void CheckSettings(string pathappset)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    string[] files = Directory.GetFiles(fbd.SelectedPath);
                    var items = new Settings();
                    items.AllItems = new List<string>();
                    foreach (string file in files)
                    {
                        items.AllItems.Add(file);
                    }

                    var jsString = Newtonsoft.Json.JsonConvert.SerializeObject(items);
                    File.WriteAllText($@"{PATHAPPSET}settings.json", jsString);
                }
            }

            MessageBox.Show("������������� ���������� ��� ���������� ������");
        }


        /// <summary>
        /// ������ ��� ���������� �������
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonaAddCmd_Click(object sender, EventArgs e)
        {
            textCommands.Text += $"{comboActs.Text}>>{textValueCmd.Text}" + Environment.NewLine;
        }


        /// <summary>
        /// ������ ��� ���������� �������
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSave_Click(object sender, EventArgs e)
        {
            var cmds = new SeleniumCommands()
            {
                Hash = textBoxHash.Text,
                Platform = comboBox1.Text,
                BodyCommands = new List<BodyCommand>()
            };

            var commands = textCommands.Text.Split('\n');

            foreach (var command in commands)
            {
                if (command != "")
                {
                    var bodyCmd = new BodyCommand();
                    var act = command.Split(">>").First();
                    var val = command.Split(">>").Last();
                    val = val.Replace("\r", "");
                    bodyCmd.Action = act;
                    bodyCmd.Value = val;
                    cmds.BodyCommands.Add(bodyCmd);
                }
            }
            SaveCommand(cmds, $"{PATHAPPCMD}{textBoxHash.Text}_{comboBox1.Text}.json");
        }


        /// <summary>
        /// ����� ���������� ������� � JSON ����
        /// </summary>
        /// <param name="cmds"></param>
        /// <param name="path"></param>
        private void SaveCommand(SeleniumCommands cmds, string path)
        {
            try
            {
                string jsString = Newtonsoft.Json.JsonConvert.SerializeObject(cmds);
                File.WriteAllText(path, jsString);
                MessageBox.Show("������!");
                SAVE = true;
            }
            catch (Exception e)
            {
                SAVE = false;
            }
            
        }


        /// <summary>
        /// ������ ��� ������ ����� � ���������
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            CheckSettings(PATHAPPSET);
        }


        /// <summary>
        /// ������������ ������ ������� ��� ��������
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            string name = comboItems.Text;
            textCommands.Text = "";
            var jsString = File.ReadAllText($@"{PATHAPPSET}settings.json");
            var settings = Newtonsoft.Json.JsonConvert.DeserializeObject<Settings>(jsString);
            foreach (var item in settings.AllItems)
            {
                string jsStringIt = File.ReadAllText(item);
                var it = Newtonsoft.Json.JsonConvert.DeserializeObject<Item>(jsStringIt);
                if (it.Name + " " + it.Creater == name)
                {
                    textBoxHash.Text = it.Hash;
                }
            }
        }


        /// <summary>
        /// ������������ ������ ��������� ��� ��������
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SAVE)
            {
                textCommands.Text = "";
            }
            else
            {
                MessageBox.Show("������� �� ���������!");
            }
        }


        /// <summary>
        /// ����� ������� ������ �� ������ ������
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textValueCmd_DoubleClick(object sender, EventArgs e)
        {
            textValueCmd.Text = Clipboard.GetText();
        }


        /// <summary>
        /// ������������ ������ ��������
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboActs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboActs.Text == "��������")
            {
                label2.Text = "XPath:";
                
            }
            else if (comboActs.Text == "�������")
            {
                label2.Text = "������:";
            }
        }
    }
}