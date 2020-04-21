using System;
using SciterSharp;

namespace Biblia
{
	public class Window : SciterWindow
	{
		public Window()
		{
			var wnd = this;
			wnd.CreateMainWindow(1200, 800);
			wnd.CenterTopLevelWindow();
			wnd.Title = "Biblia";
			#if WINDOWS
			wnd.Icon = Properties.Resources.IconMain;
			#endif
		}
	}
}