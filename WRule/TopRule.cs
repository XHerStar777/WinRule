using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace WRule
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class TopRule : Form
	{
		public TopRule()
		{			
			InitializeComponent();
		}
		void TopRulePaint(object sender, PaintEventArgs e)
		{
			int a=5;
			while (a<505)
			{
				Graphics gr = e.Graphics;
            	Pen p = new Pen(Color.White, 1);
            	Point p1 = new Point(a,0);
            	Point p2 = new Point(a,45);
            	gr.DrawLine(p, p1, p2);
            	a=a+10;
			}
			int b=10;
			while (b<500)
			{
				Graphics gr = e.Graphics;
            	Pen p = new Pen(Color.White, 1);
            	Point p1 = new Point(b,0);
            	Point p2 = new Point(b,25);
            	gr.DrawLine(p, p1, p2);
            	b=b+10;
			}
		}
		void TopRuleKeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == '1')
    			{
					LeftRule newForm1 = new LeftRule();
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
		void TopRuleFormClosed(object sender, FormClosedEventArgs e)
		{
			Environment.Exit(0);
		}
	}
}
