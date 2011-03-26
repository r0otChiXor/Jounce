﻿using System.ComponentModel.Composition;
using Jounce.Core.View;
using Jounce.Core.ViewModel;

namespace NonSharedViews.Views
{
    [ExportAsView("ContactView")]
    public partial class ContactView
    {
        public ContactView()
        {
            InitializeComponent();
        }

        [Export]
        public ViewModelRoute Binding
        {
            get { return ViewModelRoute.Create("ContactVM", "ContactView"); }
        }
    }
}