using Sandbox.Game.Gui;
using Sandbox.Game.Screens.Helpers;
using Sandbox.Graphics;
using Sandbox.Graphics.GUI;
using SpaceEngineers.Game.GUI;
using VRage.Utils;
using VRageMath;

namespace No_News_Plugin
{
	internal class MyModifiedMainMenu : MyGuiScreenMainMenu
	{
		private MyGuiControlElementGroup m_elemtents;
		public MyModifiedMainMenu()
		: this(pauseGame: false)
		{
		}

		public MyModifiedMainMenu(bool pauseGame)
			: base(pauseGame)
		{

		}

		public override void RecreateControls(bool constructor)
		{
			base.RecreateControls(constructor);
			if (!m_pauseGame)
			{
				m_elemtents = new MyGuiControlElementGroup();
				m_elemtents.HighlightChanged += OnHighlightChange;
				if (MyGuiScreenGamePlay.Static == null)
				{
					MyGuiControlNews News = null;
					foreach (var c in Controls)
					{
						if (c is MyGuiControlNews)
						{
							m_elemtents.Add(c);
							if (((MyGuiControlNews)c).Position == MyGuiManager.ComputeFullscreenGuiCoordinate(MyGuiDrawAlignEnum.HORISONTAL_RIGHT_AND_VERTICAL_BOTTOM) - 5f * MyGuiConstants.MENU_BUTTONS_POSITION_DELTA)
								News = (MyGuiControlNews)c;
						}
					}
					if (News != null)
					{
						int index = Controls.IndexOf(News);
						News = new MyGuiControlNews
						{
							Position = MyGuiManager.ComputeFullscreenGuiCoordinate(MyGuiDrawAlignEnum.HORISONTAL_RIGHT_AND_VERTICAL_BOTTOM, -1000, -1000),
							Size = new Vector2(0.1f, 0.1f),
							OriginAlign = MyGuiDrawAlignEnum.HORISONTAL_RIGHT_AND_VERTICAL_TOP
						};
						Controls.Add(News);
						Controls[index] = News;

					}
					MyGuiControlDLCBanners DlcBanners = null;
					foreach (var c in Controls)
					{
						if (c is MyGuiControlDLCBanners)
						{
							m_elemtents.Add(c);
							if (((MyGuiControlDLCBanners)c).Visible == false)
								DlcBanners = (MyGuiControlDLCBanners)c;
						}
					}
					if (DlcBanners != null)
					{
						int index = Controls.IndexOf(DlcBanners);
						DlcBanners = new MyGuiControlDLCBanners
						{
							Position = MyGuiManager.ComputeFullscreenGuiCoordinate(MyGuiDrawAlignEnum.HORISONTAL_RIGHT_AND_VERTICAL_BOTTOM, -1000, -1000),
							Size = new Vector2(0.1f, 0.1f),
							OriginAlign = MyGuiDrawAlignEnum.HORISONTAL_RIGHT_AND_VERTICAL_TOP
						};
						Controls.Add(DlcBanners);
						Controls[index] = DlcBanners;

					}
				}
			}
			if (m_pauseGame)
			{
				m_elemtents = new MyGuiControlElementGroup();
				m_elemtents.HighlightChanged += OnHighlightChange;
				MyGuiControlNews News = null;
				foreach (var c in Controls)
				{
					if (c is MyGuiControlNews)
					{
						m_elemtents.Add(c);
						if (((MyGuiControlNews)c).Position == MyGuiManager.ComputeFullscreenGuiCoordinate(MyGuiDrawAlignEnum.HORISONTAL_RIGHT_AND_VERTICAL_BOTTOM) - 5f * MyGuiConstants.MENU_BUTTONS_POSITION_DELTA)
							News = (MyGuiControlNews)c;
					}
				}
				if (News != null)
				{
					int index = Controls.IndexOf(News);
					News = new MyGuiControlNews
					{
						Position = MyGuiManager.ComputeFullscreenGuiCoordinate(MyGuiDrawAlignEnum.HORISONTAL_RIGHT_AND_VERTICAL_BOTTOM, -1000, -1000),
						Size = new Vector2(0.1f, 0.1f),
						OriginAlign = MyGuiDrawAlignEnum.HORISONTAL_RIGHT_AND_VERTICAL_TOP
					};
					Controls.Add(News);
					Controls[index] = News;

				}
				MyGuiControlDLCBanners DlcBanners = null;
				foreach (var c in Controls)
				{
					if (c is MyGuiControlDLCBanners)
					{
						m_elemtents.Add(c);
						if (((MyGuiControlDLCBanners)c).Visible == false)
							DlcBanners = (MyGuiControlDLCBanners)c;
					}
				}
				if (DlcBanners != null)
				{
					int index = Controls.IndexOf(DlcBanners);
					DlcBanners = new MyGuiControlDLCBanners
					{
						Position = MyGuiManager.ComputeFullscreenGuiCoordinate(MyGuiDrawAlignEnum.HORISONTAL_RIGHT_AND_VERTICAL_BOTTOM, -1000, -1000),
						Size = new Vector2(0.1f, 0.1f),
						OriginAlign = MyGuiDrawAlignEnum.HORISONTAL_RIGHT_AND_VERTICAL_TOP
					};
					Controls.Add(DlcBanners);
					Controls[index] = DlcBanners;
				}
			}
		}
		private void OnHighlightChange(MyGuiControlElementGroup obj)
        {
            foreach (var c in m_elemtents)
            {
                if (c.HasFocus && m_elemtents.SelectedIndex != obj.SelectedIndex)
                {
                    FocusedControl = c;
                    break;
                }
            }
        }
	}
}