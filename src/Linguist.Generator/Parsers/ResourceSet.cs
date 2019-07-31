﻿using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.CodeDom;

namespace Linguist.Generator
{
    public delegate CodeExpression ResourceManagerInitializer      ( string resourcesBaseName, string className );
    public delegate CodeExpression LocalizationProviderInitializer ( CodeExpression resourceManager, CodeExpression resourceNamingStrategy );

    public class ResourceSet
    {
        public ResourceSet ( CodeTypeReference resourceManagerType, ResourceManagerInitializer resourceManagerInitializer, CodeTypeReference localizationProviderType, LocalizationProviderInitializer localizationProviderInitializer, IDictionary < string, Resource > resources )
        {
            ResourceManagerType             = resourceManagerType;
            ResourceManagerInitializer      = resourceManagerInitializer;
            LocalizationProviderType        = localizationProviderType;
            LocalizationProviderInitializer = localizationProviderInitializer;
            Resources                       = new ReadOnlyDictionary < string, Resource > ( resources );
        }

        public CodeTypeReference               ResourceManagerType             { get; }
        public ResourceManagerInitializer      ResourceManagerInitializer      { get; }
        public CodeTypeReference               LocalizationProviderType        { get; }
        public LocalizationProviderInitializer LocalizationProviderInitializer { get; }

        public ReadOnlyDictionary < string, Resource > Resources { get; }
    }

    #if NET35
    public class ReadOnlyDictionary < TKey, TValue > : Dictionary < TKey, TValue >
    {
        public ReadOnlyDictionary ( IDictionary < TKey, TValue > dictionary ) : base ( dictionary ) { }
    }
    #endif
}