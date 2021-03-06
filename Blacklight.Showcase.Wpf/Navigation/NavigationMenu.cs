﻿//-----------------------------------------------------------------------
// <copyright file="NavigationMenu.cs" company="Microsoft Corporation copyright 2008.">
// (c) 2008 Microsoft Corporation. All rights reserved.
// This source is subject to the Microsoft Public License.
// See http://www.microsoft.com/resources/sharedsource/licensingbasics/sharedsourcelicenses.mspx.
// </copyright>
// <date>01-Oct-2008</date>
// <author>Martin Grayson</author>
// <summary>Class representing an application navigation menu.</summary>
//-----------------------------------------------------------------------
namespace Blacklight.Showcase.Wpf
{
    using System;
    using System.Net;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Documents;
    using System.Windows.Ink;
    using System.Windows.Input;
    using System.Windows.Media;
    using System.Windows.Media.Animation;
    using System.Windows.Shapes;
    using System.Collections.ObjectModel;

    /// <summary>
    /// Class representing an application navigation menu.
    /// </summary>
    public class NavigationMenu
    {
        /// <summary>
        /// Gets or sets the menu name.
        /// </summary>
        public string Name 
        { 
            get; 
            set; 
        }

        /// <summary>
        /// Gets or sets the collection of samples.
        /// </summary>
        public Collection<Sample> Samples 
        { 
            get; 
            set; 
        }
    }
}
