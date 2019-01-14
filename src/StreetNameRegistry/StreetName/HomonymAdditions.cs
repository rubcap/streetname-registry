namespace StreetNameRegistry.StreetName
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class HomonymAdditions : List<StreetNameHomonymAddition>
    {
        public bool HasMatch(Language? language, string homonymAddition)
            => this.Any(addition => addition.Language == language && addition.HomonymAddition == homonymAddition);

        public bool HasLanguage(Language? language)
            => this.Any(homonymAddition => homonymAddition.Language == language);

        public void AddOrUpdate(Language? language, string homonymAddition)
        {
            if (HasLanguage(language))
                Update(language, homonymAddition);
            else
                Add(language, homonymAddition);
        }

        public void Remove(Language? language)
        {
            var index = GetIndexByLanguage(language);
            if (index != -1)
                RemoveAt(index);
        }

        private void Update(Language? language, string homonymAddition)
        {
            if (!HasLanguage(language))
                throw new IndexOutOfRangeException();

            Remove(language);
            Add(language, homonymAddition);
        }

        private void Add(Language? language, string homonymAddition)
        {
            if (HasLanguage(language))
                throw new ApplicationException($"There is already a homonym addition present with language '{language}'");

            Add(new StreetNameHomonymAddition(homonymAddition, language));
        }

        private int GetIndexByLanguage(Language? language)
            => FindIndex(homonymAddition => homonymAddition.Language == language);
    }
}
