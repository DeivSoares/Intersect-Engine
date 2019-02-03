﻿using System.Windows.Forms;
using Intersect.Editor.Localization;
using Intersect.Editor.Maps;
using WeifenLuo.WinFormsUI.Docking;

namespace Intersect.Editor.Forms.DockingElements
{
    public partial class FrmMapProperties : DockContent
    {
        public FrmMapProperties()
        {
            InitializeComponent();
        }

        public void Init(MapInstance map)
        {
            if (gridMapProperties.InvokeRequired)
            {
                gridMapProperties.Invoke((MethodInvoker) delegate { Init(map); });
                return;
            }
            gridMapProperties.SelectedObject = new MapProperties(map);
            InitLocalization();
        }

        private void InitLocalization()
        {
            Text = Strings.MapProperties.title;
        }

        public void Update()
        {
            gridMapProperties.Refresh();
        }

        public GridItem Selection()
        {
            return gridMapProperties.SelectedGridItem;
        }
    }
}