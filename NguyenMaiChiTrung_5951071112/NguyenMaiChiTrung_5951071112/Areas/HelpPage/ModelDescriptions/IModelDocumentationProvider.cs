using System;
using System.Reflection;

namespace NguyenMaiChiTrung_5951071112.Areas.HelpPage.ModelDescriptions
{
    public interface IModelDocumentationProvider
    {
        string GetDocumentation(MemberInfo member);

        string GetDocumentation(Type type);
    }
}