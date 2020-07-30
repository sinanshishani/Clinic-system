using Abp.Dependency;
using Abp.Localization;
using System.ComponentModel;

namespace EClinic.Framework.Enums
{
    public class LocalizedDescriptionAttribute : DescriptionAttribute
    {
        private readonly ILocalizationManager _localizationManager;
        private readonly string _sourceName;
        private readonly string _resourceKey;

        public LocalizedDescriptionAttribute(string resourceKey, string sourceName = "LocalizationResource")
        {
            _localizationManager = IocManager.Instance.Resolve<ILocalizationManager>();
            _sourceName = sourceName;
            _resourceKey = resourceKey;
        }

        public override string Description
        {
            get
            {
                string displayName = _localizationManager.GetString(_sourceName, _resourceKey);

                return string.IsNullOrEmpty(displayName)
                    ? string.Format("[[{0}]]", _resourceKey)
                    : displayName;
            }
        }
    }
}