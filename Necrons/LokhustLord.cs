﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Roster_Builder.Necrons
{
    public class LokhustLord : Datasheets
    {
        Necrons repo = new Necrons();
        public LokhustLord()
        {
            DEFAULT_POINTS = 105;
            TemplateCode = "2m_c";
            Points = DEFAULT_POINTS;
            Weapons.Add("Staff of Light");
            Weapons.Add("");
            Keywords.AddRange(new string[]
            {
                "NECRONS", "DESTROYER CULT", "<DYNASTY>",
                "INFANTRY", "CHARACTER", "FLY", "LOKHUST LORD"
            });
        }

        public override Datasheets CreateUnit()
        {
            return new LokhustLord();
        }

        public override void LoadDatasheets(Panel panel, Faction f)
        {
            repo = f as Necrons;
            Template.LoadTemplate(TemplateCode, panel);

            ComboBox cmbOption1 = panel.Controls["cmbOption1"] as ComboBox;
            ComboBox cmbOption2 = panel.Controls["cmbOption2"] as ComboBox;
            CheckBox cbWarlord = panel.Controls["cbWarlord"] as CheckBox;
            ComboBox cmbWarlord = panel.Controls["cmbWarlord"] as ComboBox;
            ComboBox cmbRelic = panel.Controls["cmbRelic"] as ComboBox;

            cmbOption1.Items.Clear();
            cmbOption1.Items.AddRange(new string[]
            {
                "Hyperphase Sword",
                "Staff of Light",
                "Voidblade",
                "Warscythe"
            });
            cmbOption1.SelectedIndex = cmbOption1.Items.IndexOf(Weapons[0]);

            cmbOption2.Items.Clear();
            cmbOption2.Items.AddRange(new string[]
            {
                "(None)",
                "Phylactery",
                "Resurrection Orb"
            });
            cmbOption2.SelectedIndex = cmbOption2.Items.IndexOf(Weapons[1]);

            if (isWarlord)
            {
                cbWarlord.Checked = true;
                cmbWarlord.Enabled = true;
                cmbWarlord.SelectedText = WarlordTrait;
            }
            else
            {
                cbWarlord.Checked = false;
                cmbWarlord.Enabled = false;
            }

            cmbRelic.Items.Clear();
            cmbRelic.Items.AddRange(repo.GetRelics(Keywords).ToArray());

            if (Relic != null)
            {
                cmbRelic.SelectedIndex = cmbRelic.Items.IndexOf(Relic);
            }
            else
            {
                cmbRelic.SelectedIndex = -1;
            }
        }

        public override void SaveDatasheets(int code, Panel panel)
        {
            ComboBox cmbOption1 = panel.Controls["cmbOption1"] as ComboBox;
            ComboBox cmbOption2 = panel.Controls["cmbOption2"] as ComboBox;
            CheckBox cbWarlord = panel.Controls["cbWarlord"] as CheckBox;
            ComboBox cmbWarlord = panel.Controls["cmbWarlord"] as ComboBox;
            ComboBox cmbRelic = panel.Controls["cmbRelic"] as ComboBox;

            switch (code)
            {
                case 11:
                    Weapons[0] = cmbOption1.SelectedItem.ToString();
                    break;
                case 12:
                    Weapons[1] = cmbOption2.SelectedItem.ToString();
                    break;
                case 15:
                    if (cmbWarlord.SelectedIndex != -1)
                    {
                        WarlordTrait = cmbWarlord.SelectedItem.ToString();
                    }
                    else
                    {
                        WarlordTrait = string.Empty;
                    }
                    break;
                case 17:
                    Relic = cmbRelic.SelectedItem.ToString(); 
                    
                    if (cmbRelic.SelectedItem.ToString() == "Blood Scythe")
                    {
                        cmbOption1.SelectedIndex = cmbOption1.Items.IndexOf("Warscythe");
                        cmbOption1.Enabled = false;
                    }
                    else
                    {
                        cmbOption1.Enabled = true;
                    }

                    if (cmbRelic.SelectedItem.ToString() == "Solar Staff")
                    {
                        cmbOption1.SelectedIndex = cmbOption1.Items.IndexOf("Staff of Light");
                        cmbOption1.Enabled = false;
                    }
                    else
                    {
                        cmbOption1.Enabled = true;
                    }

                    if (cmbRelic.SelectedItem.ToString() == "Resurrection Orb")
                    {
                        cmbOption1.SelectedIndex = cmbOption1.Items.IndexOf("Orb of Eternity");
                        cmbOption1.Enabled = false;
                    }
                    else
                    {
                        cmbOption1.Enabled = true;
                    }

                    if (cmbRelic.SelectedItem.ToString() == "Voidreaper")
                    {
                        cmbOption1.SelectedIndex = cmbOption1.Items.IndexOf("Warscythe");
                        cmbOption1.Enabled = false;
                    }
                    else
                    {
                        cmbOption1.Enabled = true;
                    }

                    if (cmbRelic.SelectedItem.ToString() == "Voltaic Staff")
                    {
                        cmbOption1.SelectedIndex = cmbOption1.Items.IndexOf("Staff of Light");
                        cmbOption1.Enabled = false;
                    }
                    else
                    {
                        cmbOption1.Enabled = true;
                    }
                    break;
                case 25:
                    if (cbWarlord.Checked)
                    {
                        this.isWarlord = true;
                    }
                    else { this.isWarlord = false; }
                    break;
            }

            Points = DEFAULT_POINTS;

            if(Weapons.Contains("Phylactery"))
            {
                Points += 5;
            }

            if(Weapons.Contains("Warscythe"))
            {
                Points += 5;
            }

            if(Weapons.Contains("Resurrection Orb"))
            {
                Points += 30;
            }
        }

        public override string ToString()
        {
            return "Lokhust Lord - " + Points + "pts";
        }
    }
}
