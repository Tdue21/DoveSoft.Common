// ****************************************************************************
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

using System.Collections.Generic;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using DevExpress.Mvvm;
using DevExpress.Mvvm.UI;

namespace DoveSoft.Common.WPF
{
    /// <summary>
    /// 
    /// </summary>
    public class DialogService : ViewServiceBase, IDialogService
    {
        /// <summary>
        /// 
        /// </summary>
        public static readonly DependencyProperty DialogStyleProperty = XamlHelpers.RegisterDependency(nameof(DialogStyle), WindowStyle.SingleBorderWindow);

        /// <summary>
        /// 
        /// </summary>
        public static readonly DependencyProperty DialogStartupLocationProperty = XamlHelpers.RegisterDependency(nameof(DialogStartupLocation), WindowStartupLocation.CenterOwner);

        /// <summary>
        /// 
        /// </summary>
        public static readonly DependencyProperty OwnerWindowProperty = XamlHelpers.RegisterDependency<Window>(nameof(OwnerWindow));

        /// <summary>
        /// 
        /// </summary>
        public static readonly DependencyProperty OwnerControlProperty = XamlHelpers.RegisterDependency<ContentControl>(nameof(OwnerControl));

        /// <summary>
        /// 
        /// </summary>
        public static readonly DependencyProperty HeightProperty = XamlHelpers.RegisterDependency<double>(nameof(Height));

        /// <summary>
        /// 
        /// </summary>
        public static readonly DependencyProperty WidthProperty = XamlHelpers.RegisterDependency<double>(nameof(Width));

        /// <summary>
        /// 
        /// </summary>
        public static readonly DependencyProperty ResizableProperty = XamlHelpers.RegisterDependency(nameof(Resizable), false);

        /// <summary>
        /// 
        /// </summary>
        public static readonly DependencyProperty TitleProperty = XamlHelpers.RegisterDependency<string>(nameof(Title));

        /// <summary>
        /// 
        /// </summary>
        [DefaultValue(WindowStartupLocation.CenterOwner)]
        public WindowStartupLocation DialogStartupLocation
        {
            get => (WindowStartupLocation)GetValue(DialogStartupLocationProperty);
            set => SetValue(DialogStartupLocationProperty, value);
        }

        /// <summary>
        /// 
        /// </summary>
        [DefaultValue(WindowStyle.SingleBorderWindow)]
        public WindowStyle DialogStyle
        {
            get => (WindowStyle)GetValue(DialogStyleProperty);
            set => SetValue(DialogStyleProperty, value);
        }

        /// <summary>
        /// 
        /// </summary>
        public Window OwnerWindow
        {
            get => (Window)GetValue(OwnerWindowProperty);
            set => SetValue(OwnerWindowProperty, value);
        }

        /// <summary>
        /// 
        /// </summary>
        public ContentControl OwnerControl
        {
            get => (ContentControl)GetValue(OwnerControlProperty);
            set => SetValue(OwnerControlProperty, value);
        }

        /// <summary>
        /// 
        /// </summary>
        public double Height
        {
            get => (double)GetValue(HeightProperty);
            set => SetValue(HeightProperty, value);
        }

        /// <summary>
        /// 
        /// </summary>
        public double Width
        {
            get => (double)GetValue(WidthProperty);
            set => SetValue(WidthProperty, value);
        }

        /// <summary>
        /// 
        /// </summary>
        [DefaultValue(false)]
        public bool Resizable
        {
            get => (bool)GetValue(ResizableProperty);
            set => SetValue(ResizableProperty, value);
        }

        /// <summary>
        /// 
        /// </summary>
        public string Title
        {
            get => (string)GetValue(TitleProperty);
            set => SetValue(TitleProperty, value);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dialogCommands"></param>
        /// <param name="title"></param>
        /// <param name="documentType"></param>
        /// <param name="viewModel"></param>
        /// <param name="parameter"></param>
        /// <param name="parentViewModel"></param>
        /// <returns></returns>
        public UICommand ShowDialog(IEnumerable<UICommand> dialogCommands, string title, string documentType, object viewModel, object parameter, object parentViewModel)
        {
            var content = CreateAndInitializeView(documentType, viewModel, parameter, parentViewModel);
            var window = new DialogWindow
            {
                WindowStyle = DialogStyle,
                Height = Height + 40,
                Width = Width,
                ResizeMode = Resizable ? ResizeMode.CanResize : ResizeMode.NoResize,
                Owner = Application.Current.MainWindow,
                Title = Title,
                WindowStartupLocation = DialogStartupLocation,
                CommandsSource = dialogCommands,
                Content = content
            };

            window.ShowDialog();

            return window.Result;
        }
    }
}