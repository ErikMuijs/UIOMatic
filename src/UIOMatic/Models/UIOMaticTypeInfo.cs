﻿using UIOMatic.Enums;

namespace UIOMatic.Models
{
    public class UIOMaticTypeInfo
    {
        public UIOMaticRenderType RenderType { get; set; }

        public string PrimaryKeyColumnName { get; set; }

        public string[] IgnoreColumnsFromListView { get; set; }

        public string NameField { get; set; }

        public bool ReadOnly { get; set; }

        public string[] ListViewRowCssDecorators { get; set; }

        public string[] ListViewCellContentDecorators { get; set; }

        public string[] ListViewLinkColumns { get; set; }

        public string[] CustomColumnsOrder { get; set; }
    }
}