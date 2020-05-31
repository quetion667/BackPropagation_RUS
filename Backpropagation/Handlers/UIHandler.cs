﻿using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Backpropagation.Handlers
{
	public static class UiHandler
	{
		public static void PanelVisible(Panel visible, List<Panel> panels)
		{
			foreach (Panel panel in panels)
			{
				panel.Visible = panel.Equals(visible);
			}
		}

		public static void SetSlider(Panel panelSlider, int top, int height)
		{
			panelSlider.Top = top;
			panelSlider.Height = height;
		}

		public static void DecrementValue(TableLayoutPanel panel, int which)
		{
			int.TryParse(panel.Controls[which * 2 + 1].Text, out int amount);
			panel.Controls[which * 2 + 1].Text = (--amount).ToString();
			if (amount == 0)
				panel.Controls[which * 2].Enabled = false;
		}

		public static bool AllButtonsDisabled(TableLayoutPanel panel)
		{
			for (int i = 0; i < panel.Controls.Count; i++)
			{
				if (!(panel.Controls[i] is Button)) continue;
				if (panel.Controls[i].Enabled)
					return false;
			}
			return true;
		}
	}

	public class Mover
	{
		private bool _mouseDown;
		private Point _lastLocation;

		public void MouseDown(Point location)
		{
			_mouseDown = true;
			_lastLocation = location;
		}

		public bool MouseMove(Point mouseLocation, Point location, out Point newLocation)
		{
			newLocation = new Point();
			if (!_mouseDown) return false;
			newLocation = new Point(
				location.X - _lastLocation.X + mouseLocation.X, location.Y - _lastLocation.Y + mouseLocation.Y);
			return true;
		}

		public void MouseUp()
		{
			_mouseDown = false;
		}
	}
}