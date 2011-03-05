using System.ComponentModel;
using System.ComponentModel.Composition;
using System.Windows;
using System.Windows.Interactivity;

namespace Jounce.Framework.Views
{
    /// <summary>
    ///     Trigger to raise the visual state aggregator event
    /// </summary>
    public class VisualStateAggregatorTrigger : TriggerAction<FrameworkElement>
    {
        /// <summary>
        ///     On construction, resolve
        /// </summary>
        public VisualStateAggregatorTrigger()
        {
            if (!DesignerProperties.IsInDesignTool)
            {
                CompositionInitializer.SatisfyImports(this);
            }
        }

        /// <summary>
        ///     Reference to the aggregator
        /// </summary>
        [Import]
        public VisualStateAggregator Aggregator { get; set; }

        /// <summary>
        ///     Name of the event to raise
        /// </summary>
        public string EventName { get; set; }

        /// <summary>
        ///     Invoker will publish the event
        /// </summary>
        /// <param name="parameter"></param>
        protected override void Invoke(object parameter)
        {
            if (Aggregator != null)
            {
                Aggregator.PublishEvent(EventName);
            }
        }
    }

}