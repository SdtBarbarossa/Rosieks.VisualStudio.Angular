﻿namespace Rosieks.VisualStudio.Angular.Completion
{
    using System.ComponentModel.Composition;
    using Microsoft.VisualStudio.Language.Intellisense;
    using Microsoft.VisualStudio.Text;
    using Microsoft.VisualStudio.Utilities;

    [Export(typeof(ICompletionSourceProvider))] 
 	[Order(Before = "High")] 
 	[ContentType("JavaScript")]
 	[Name("AngularControllerCompletion")]
    internal class ControllerCompletionSourceProvider : ICompletionSourceProvider
    {
        public ICompletionSource TryCreateCompletionSource(ITextBuffer textBuffer)
        {
            return textBuffer.Properties.GetOrCreateSingletonProperty(() => new ControllerCompletionSource(textBuffer)) as ICompletionSource;
        }
    }
}
