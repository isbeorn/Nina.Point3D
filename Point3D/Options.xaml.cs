﻿using System.ComponentModel.Composition;
using System.Windows;

namespace NINA.Point3d {

    [Export(typeof(ResourceDictionary))]
    partial class Options : ResourceDictionary {

        public Options() {
            InitializeComponent();
        }
    }
}