﻿using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFUI.ViewModels
{
    public class NewViewModel : Screen
    {
        public void CloseApp()
        {
            TryClose();
        }
    }
}