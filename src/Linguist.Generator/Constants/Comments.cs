﻿namespace Linguist.Generator
{
    internal static class Comments
    {
        public static readonly string [ ] Ordinals = new [ ] { "first", "second", "third", "fourth", "fifth", "sixth", "seventh", "eighth", "ninth", "tenth", "eleventh", "twelfth", "thirteenth", "fourteenth", "fifteenth", "sixteenth", "seventeenth", "eighteenth", "nineteenth", "twentieth", "nth" };

        public const string ClassSummary                    = "A strongly-typed resource class, for looking up and formatting localized strings, etc.";
        public const string ClassRemarksToollessFormat      = "This class was auto-generated by the {0} class.\nTo add or remove a member, edit your .ResX file then rerun the generator.";
        public const string ClassRemarksFormat              = "This class was auto-generated by the {0} class via the {1} custom tool.\nTo add or remove a member, edit your .ResX file then rerun the {1} custom tool or rebuild your VS project.";
        public const string SingletonBeforeFieldInitComment = "Explicit static constructor to tell compiler not to mark type as beforefieldinit";
        public const string ConstructorSummaryFormat        = "Initializes a {0} resource class.";
        public const string ResourceManagerPropertySummary  = "Returns the cached ResourceManager instance used by this class.";
        public const string LocalizerPropertySummary        = "Returns the cached Localizer instance used by this class.";
        public const string CultureInfoPropertySummary      = "Overrides the current thread's CurrentUICulture property for all resource lookups using this strongly typed resource class.";
        public const int    ResourcePreviewMaximumLength    = 512;
        public const string TruncatedResourcePreview        = "{0} [rest of string was truncated]\";";
        public const string ResourceCommentFormat           = "\n\n{0}";
        public const string StringPropertySummary           = "Looks up a localized string similar to '{0}'.";
        public const string NonStringPropertySummary        = "Looks up a resource '{0}'.";
        public const string FormatMethodSummary             = "Formats a localized string similar to '{0}'.";
        public const string FormatMultiParameterComment     = "The {0} object to format.";
        public const string FormatParameterComment          = "The object to format.";
        public const string FormatReturnComment             = "A copy of format in which the format items have been replaced by the string representation of the corresponding object arguments.";
        public const string ResourceKeyEnumNameSummary      = "Provides keys for named resources.";
        public const string ResourceKeyFieldSummaryFormat   = "Key for resource named '{0}'.";
    }
}