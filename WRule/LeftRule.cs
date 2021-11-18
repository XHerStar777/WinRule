using System;
using System.Drawing;
using System.Windows.Forms;

namespace WRule
{
	/// <summary>
	/// Description of LeftRule.
	/// </summary>
	public partial class LeftRule : Form
	{
		public LeftRule()
		{
			InitializeComponent();
		}
		void LeftRulePaint(object sender, PaintEventArgs e)
		{
			int a=5;
			while (a<505)
			{
				Graphics gr = e.Graphics;
            	Pen p = new Pen(Color.White, 1);
            	Point p1 = new Point(0,a);
            	Point p2 = new Point(45,a);
            	gr.DrawLine(p, p1, p2);
            	a=a+10;
			}
			int b=10;
			while (b<500)
			{
				Graphics gr = e.Graphics;
            	Pen p = new Pen(Color.White, 1);
            	Point p1 = new Point(0,b);
            	Point p2 = new Point(25,b);
            	gr.DrawLine(p, p1, p2);
            	b=b+10;
			}
		}
		void LeftRuleFormClosed(object sender, FormClosedEventArgs e)
		{
			Environment.Exit(0);
		}
		void LeftRuleKeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == '2')
    			{
					TopRule newForm1 = new TopRule();
    				newForm1.Show();
    				this.Hide();
    			}
			if (e.KeyChar == '3')
    			{
					RightRule newForm1 = new RightRule();
    				newForm1.Show();
    				this.Hide();
    			}
		}
	}
}
