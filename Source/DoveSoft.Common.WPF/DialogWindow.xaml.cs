﻿// ****************************************************************************
// * The MIT License(MIT)
// * Copyright © 2022 DoveSoft
// *
// * Permission is hereby granted, free of charge, to any person obtaining a
// * copy of this software and associated documentation files (the “Software”),
// * to deal in the Software without restriction, including without limitation
// * the rights to use, copy, modify, merge, publish, distribute, sublicense,
// * and/or sell copies of the Software, and to permit persons to whom the
// * Software is furnished to do so, subject to the following conditions:
// *
// * The above copyright notice and this permission notice shall be included in
// * all copies or substantial portions of the Software.
// *
// * THE SOFTWARE IS PROVIDED “AS IS”, WITHOUT WARRANTY OF ANY KIND, EXPRESS
// * OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// * FITNESS FOR A PARTICULAR PURPOSE AND NON-INFRINGEMENT. IN NO EVENT SHALL
// * THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// * LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// * FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS
// * IN THE SOFTWARE.
// ****************************************************************************

using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using DevExpress.Mvvm;

namespace DoveSoft.Common.WPF
{
    /// <summary>
    ///     Interaction logic for DialogWindow.xaml
    /// </summary>
    public partial class DialogWindow
    {
        /// <summary>
        /// 
        /// </summary>
        public static readonly DependencyProperty CommandsSourceProperty =
            XamlHelpers.RegisterDependency<IEnumerable<UICommand>>(nameof(CommandsSource));

        /// <summary>
        /// 
        /// </summary>
        public DialogWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 
        /// </summary>
        public IEnumerable<UICommand> CommandsSource
        {
            get => (IEnumerable<UICommand>)GetValue(CommandsSourceProperty);
            set => SetValue(CommandsSourceProperty, value);
        }

        /// <summary>
        /// 
        /// </summary>
        public UICommand Result { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnDialogCommand(object sender, EventArgs e)
        {
            if (sender is Button { DataContext: UICommand command })
            {
                Result = command;
            }

            Close();
        }
    }
}