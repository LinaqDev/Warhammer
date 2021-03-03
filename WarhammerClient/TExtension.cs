using System; 
using System.Reflection; 
using System.Windows;
using System.Windows.Markup;

namespace WarhammerClient
{
    public class TExtension : MarkupExtension
    {
        public TExtension() { }
        public TExtension(string key)
        {
            Key = key;
        }
        public string Key { get; set; }
        private FrameworkElement target;
        private PropertyInfo property;
        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            var data = (IProvideValueTarget)serviceProvider.GetService(typeof(IProvideValueTarget));
            target = (FrameworkElement)data.TargetObject;
            property = target.GetType().GetProperty(((DependencyProperty)data.TargetProperty).Name);
            LanguageProvider.Instance.TrackInstance(this);
            target.Unloaded += Target_Unloaded;
            return LanguageProvider.Instance.GetValue(Key);
        }
        public void CultureChanged()
            => property.SetValue(target, LanguageProvider.Instance.GetValue(Key));
        private void Target_Unloaded(object sender, RoutedEventArgs e)
        {
            target.Unloaded -= Target_Unloaded;
            LanguageProvider.Instance.StopTrackingInstance(this);
        }
    }
}
