using System;
using System.Drawing;
using System.Windows.Forms;

namespace WRule
{
	/// <summary>
	/// Description of RightRule.
	/// </summary>
	public partial class RightRule : Form
	{
		public RightRule()
		{
			InitializeComponent();
		}
		void RightRulePaint(object sender, PaintEventArgs e)
		{
			int a=5;
			while (a<505)
			{
				Graphics gr = e.Graphics;
            	Pen p = new Pen(Color.White, 1);
            	Point p1 = new Point(25,a);
            	Point p2 = new Point(90,a);
            	gr.DrawLine(p, p1, p2);
            	a=a+10;
			}
			int b=10;
			while (b<500)
			{
				Graphics gr = e.Graphics;
            	Pen p = new Pen(Color.White, 1);
            	Point p1 = new Point(45,b);
            	Point p2 = new Point(90,b);
            	gr.DrawLine(p, p1, p2);
            	b=b+10;
			}
		}
		void RightRuleFormClosed(object sender, FormClosedEventArgs e)
		{
			Environment.Exit(0);
		}
		void RightRuleKeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == '2')
    			{
					TopRule newForm1 = new TopRule();
    				newForm1.Show();
    				this.Hide();
    			}
			if (e.KeyChar == '1')
    			{
					LeftRule newForm1 = new LeftRule();
    				newForm1.Show();
    				this.Hide();
    			}
		}
	}
}
