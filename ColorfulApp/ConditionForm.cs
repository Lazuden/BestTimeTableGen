using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace ColorfulApp
{
    public partial class ConditionForm : Form
    {
        private BindingList<RuleItem> rules;

        public ConditionForm()
        {
            InitializeComponent();
            var cm = new ContextMenu();
            cm.MenuItems.Add(new MenuItem("География"));
            cm.MenuItems.Add(new MenuItem("Геометрия"));
            if (Data.Instance.OriginalRules != null)
            {
                rules = new BindingList<RuleItem>(Data.Instance.OriginalRules);
            }
            else
            {
                rules = new BindingList<RuleItem>();
            }
            //rules.Add(new RuleItem("правило 1", "∀t1,t2,k1, k2 (R(t1, s1, k1, c1, x1, d1) ⋀ EQ(c1, '8A')⋀R(t2, s2, k2, c2, x2, d2) ⋀ EQ(c2, '8A')⋀EQ(d2 - d1, 1)⋀ EQ(s1,'Химия') ⇒ NE(s2, 'Биология'))"));
            lbRuleList.DataSource = rules;
            lbRuleList.DisplayMember = "Name";
            tbRule.ContextMenu = cm;
        }

        private void insertSymbolInText(string symbol, int length = 1)
        {
            tbRule.Focus();
            int position = tbRule.SelectionStart;
            tbRule.SelectedText = symbol;
            tbRule.SelectionStart = position + length;
        }

        private void selectRule()
        {
            tbRuleName.Enabled = true;
            tbRuleName.Text = rules[lbRuleList.SelectedIndex].Name;
            tbRule.Text = rules[lbRuleList.SelectedIndex].Text;
        }

        private void clearSelected()
        {
            tbRuleName.Enabled = false;
            tbRuleName.Clear();
            tbRule.Clear();
        }

        private void btAll_Click(object sender, EventArgs e)
        {
            insertSymbolInText("∀");
        }

        private void btExist_Click(object sender, EventArgs e)
        {
            insertSymbolInText("∃");
        }

        private void btThen_Click(object sender, EventArgs e)
        {
            insertSymbolInText("⇒");
        }

        private void btRule_Click(object sender, EventArgs e)
        {
            insertSymbolInText("R()", 2);
        }

        private void btAnd_Click(object sender, EventArgs e)
        {
            insertSymbolInText("⋀");
        }

        private void btOr_Click(object sender, EventArgs e)
        {
            insertSymbolInText("⋁");
        }

        private void btEQ_Click(object sender, EventArgs e)
        {
            insertSymbolInText("EQ()", 3);
        }

        private void btNE_Click(object sender, EventArgs e)
        {
            insertSymbolInText("NE()", 3);
        }

        private void btGE_Click(object sender, EventArgs e)
        {
            insertSymbolInText("GE()", 3);
        }

        private void btLE_Click(object sender, EventArgs e)
        {
            insertSymbolInText("LE()", 3);
        }

        private void btGT_Click(object sender, EventArgs e)
        {
            insertSymbolInText("GT()", 3);
        }

        private void btLT_Click(object sender, EventArgs e)
        {
            insertSymbolInText("LT()", 3);
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            rules.Add(new RuleItem("Новое правило", ""));
            lbRuleList.SelectedIndex = rules.Count - 1;
            if (lbRuleList.SelectedIndex == 0)
            {
                selectRule();
            }
        }

        private void lbRuleList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbRuleList.SelectedIndex >= 0)
            {
                selectRule();
            }
            else
            {
                clearSelected();
            }
        }

        private void tbRuleName_TextChanged(object sender, EventArgs e)
        {
            if (lbRuleList.SelectedIndex >= 0)
            {
                rules[lbRuleList.SelectedIndex].Name = tbRuleName.Text;
                rules.ResetBindings();
            }
        }

        private void tbRule_TextChanged(object sender, EventArgs e)
        {
            if (lbRuleList.SelectedIndex >= 0)
            {
                rules[lbRuleList.SelectedIndex].Text = tbRule.Text;
            }
        }

        private void btRemove_Click(object sender, EventArgs e)
        {
            if (lbRuleList.SelectedIndex >= 0)
            {
                rules.RemoveAt(lbRuleList.SelectedIndex);
            }
        }

        private void btObj_Click(object sender, EventArgs e)
        {
            var insert = new InsertObject();
            insert.ShowDialog();
            if (insert.DialogResult == DialogResult.OK)
            {
                insertSymbolInText(insert.InsertedName, insert.InsertedName.Length);
            }
        }

        private void ConditionForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result = new List<string>();
            foreach (RuleItem r in rules)
            {
                if (r.Text.Trim() == "")
                    continue;
                Parser p = new Parser(r.Text);
                p.Parse();
                result.Add(p.Result);
            }
            Data.Instance.Rules = result;
            Data.Instance.OriginalRules = rules.ToList();
        }
    }
    public class RuleItem
    {
        public RuleItem(string name)
        {
            Name = name;
        }

        public RuleItem(string name, string text) : this(name)
        {
            Text = text;
        }

        public string Name { get; set; }
        public string Text { get; set; }
    }

    public class Parser
    {
        public string Result { get; set; }
        private string text;
        private Dictionary<string, Variable> vars;
        private int R_count;
        private VarTypes exprType;

        public Parser(string text) : this()
        {
            this.text = text;
        }

        public Parser()
        {
            vars = new Dictionary<string, Variable>();
        }

        public void Parse()
        {
            int r_index = -1;
            int r_number = 0;
            do
            {
                r_index = text.IndexOf('R', r_index + 1);
                if (r_index != -1)
                {
                    r_number++;
                    int left_bracket, right_bracket;
                    left_bracket = text.IndexOf('(', r_index);
                    right_bracket = text.IndexOf(')', r_index);
                    string variables_list = text.Substring(left_bracket + 1, right_bracket - left_bracket - 1);
                    parseVars(variables_list.Split(',').Select(elem => elem.Trim()), r_number);
                }
            }
            while (r_index >= 0);

            R_count = r_number;
            prepareString();
        }

        private void parseVars(IEnumerable<string> els, int r_number)
        {
            vars[els.ElementAt(0)] = new Variable(VarTypes.Teacher, r_number);
            vars[els.ElementAt(1)] = new Variable(VarTypes.Subject, r_number);
            vars[els.ElementAt(2)] = new Variable(VarTypes.Cabinet, r_number);
            vars[els.ElementAt(3)] = new Variable(VarTypes.Class, r_number);
            vars[els.ElementAt(4)] = new Variable(VarTypes.Time, r_number);
            vars[els.ElementAt(5)] = new Variable(VarTypes.Day, r_number);
        }

        private string parseExpr(Match m)
        {
            string exp = m.Value;
            string exprName = exp.Substring(0, 2);
            int commaIndex = exp.IndexOf(',');
            string firstArg = exp.Substring(3, commaIndex - 3);
            string secondArg = exp.Substring(commaIndex + 1, exp.Length - commaIndex - 1).Replace(')', ' ').Trim();

            return $"{convertArg(firstArg)} {mapExpr(exprName)} {convertArg(secondArg)}";
        }

        private string convertArg(string arg)
        {
            string res;
            Regex word = new Regex(@"\w+", RegexOptions.Compiled | RegexOptions.IgnoreCase);
            Regex cnst = new Regex(@"(?<=').+?(?=')", RegexOptions.Compiled | RegexOptions.IgnoreCase);            
            if (arg.Contains('\''))
                res = parseConst(cnst.Match(arg));
            else
                res = word.Replace(arg, parseArg);

            return res;
        }

        private string parseConst(Match m)
        {
            int id = 1;
            switch (exprType)
            {
                case VarTypes.Subject:
                    var subject = Data.Instance.SubjList.Where((Subject subj) => subj.Name == m.Value).First();
                    id = Data.Instance.SubjList.IndexOf(subject);
                    break;
                case VarTypes.Teacher:
                    var teacher = Data.Instance.Teachers.Values.Where((Teacher t) => t.Name == m.Value).First();
                    id = teacher.Id;
                    break;
                case VarTypes.Class:
                    var cls = Data.Instance.Classes.Values.Where((tClass c) => c.Name == m.Value).First();
                    id = cls.Id;
                    break;
            }
            return id.ToString();
        }

        private string parseArg(Match m)
        {
            if (vars.Keys.Contains(m.Value))
            {
                Variable v = vars[m.Value];
                exprType = v.VarType;
                return $"x{v.DeclareIn}.{mapVarType(v.VarType)}";
            }
            return m.Value;
        }

        private string mapExpr(string expr)
        {
            switch (expr)
            {
                case "EQ": return "=";
                case "NE": return "!=";
                case "GE": return ">=";
                case "LE": return "<=";
                case "GT": return ">";
                case "LT": return "<";
                default: return expr;
            }
        }

        private string mapVarType(VarTypes vt)
        {
            switch (vt)
            {
                case VarTypes.Teacher: return "t";
                case VarTypes.Subject: return "s";
                case VarTypes.Cabinet: return "k";
                case VarTypes.Class: return "c";
                case VarTypes.Time: return "x";
                case VarTypes.Day: return "d";
            }
            return "";
        }

        private void prepareString()
        {
            Regex rExp = new Regex(@"R.*?⋀", RegexOptions.Compiled | RegexOptions.IgnoreCase);
            text = rExp.Replace(text, "");
            int first_bracket = text.IndexOf('(');
            int last_bracket = text.LastIndexOf(')');
            text = text.Substring(first_bracket + 1, last_bracket - first_bracket - 1).Trim();

            Regex calcExp = new Regex(@"\w\w\(.*?\)", RegexOptions.Compiled | RegexOptions.IgnoreCase);
            Regex operExp = new Regex(@"[⋀⋁]", RegexOptions.Compiled);

            text = calcExp.Replace(text, parseExpr);
            text = operExp.Replace(text, replaceOperands);

            var textParts = text.Split('⇒');
            Result = "SELECT " + textParts[1] + " as res " + prepareFrom() +
                "WHERE " + textParts[0];
        }

        private string replaceOperands(Match m)
        {
            switch (m.Value)
            {
                case "⋀": return " AND ";
                case "⋁": return " OR ";
            }
            return m.Value;
        }

        private string prepareFrom()
        {
            string result = "FROM timetable as x1 ";
            for (int i = 2; i <= R_count; i++)
            {
                result += $"CROSS JOIN timetable as x{i} ";
            }
            return result;
        }
    }

    public enum VarTypes
    {
        Teacher,
        Subject,
        Cabinet,
        Class,
        Time,
        Day,
    }

    public struct Variable
    {
        public Variable(VarTypes v, int d)
        {
            VarType = v;
            DeclareIn = d;
        }
        public VarTypes VarType { get; }
        public int DeclareIn { get; }
    }
}
