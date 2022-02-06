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
using System.Windows;
using DevExpress.Mvvm;

namespace DoveSoft.Common.WPF
{
    /// <summary>
    /// 
    /// </summary>
    public static class DialogServiceExtensions
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="dialog"></param>
        /// <param name="commands"></param>
        /// <param name="viewModel"></param>
        /// <param name="parameter"></param>
        /// <param name="parentViewModel"></param>
        /// <returns></returns>
        public static UICommand ShowDialog(this IDialogService dialog, IEnumerable<UICommand> commands, object viewModel, object parameter = null, object parentViewModel = null)
        {
            return dialog.ShowDialog(commands, null, null, viewModel, parameter, parentViewModel);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dialog"></param>
        /// <param name="viewModel"></param>
        /// <param name="parameter"></param>
        /// <param name="parentViewModel"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static UICommand ShowOkCancelDialog<T>(this IDialogService dialog, T viewModel, object parameter = null,
                                                      object parentViewModel = null) where T : OkCancelDialogViewModel
        {
            var commands = new List<UICommand>
                           {
                               new UICommand("OK", "Ok", viewModel.AcceptDialogCommand, true, false, MessageBoxResult.OK),
                               new UICommand("CANCEL", "Cancel", null, false, true, MessageBoxResult.Cancel),
                           };
            return dialog.ShowDialog(commands, null, null, viewModel, parameter, parentViewModel);
        }
    }
}