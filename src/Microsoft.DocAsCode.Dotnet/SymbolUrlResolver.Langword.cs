﻿#nullable enable

using System.Text.Json;

namespace Microsoft.DocAsCode.Dotnet;

partial class SymbolUrlResolver
{
    private static readonly Lazy<JsonDocument> s_langwords = new(() => JsonDocument.Parse(CSharpLangwords.ToArray()));

    public static string? GetLangwordUrl(string langword)
    {
        return s_langwords.Value.RootElement.TryGetProperty(langword, out var url) ? url.GetString() : null;
    }

    // Generated by executing the following code in browser console:
    // https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/
    //
    // Object.fromEntries(Array.from(document.querySelectorAll('.content a>code')).map(c => {
    //   const keyword = c.innerText.replace(/\(.*\)/g, '').trim()
    //   const href = c.parentNode.href.replace('/en-us', '')
    //   return [keyword, href]
    // }))
    private static ReadOnlySpan<byte> CSharpLangwords =>
        """
        {
          "abstract": "https://learn.microsoft.com/dotnet/csharp/language-reference/keywords/abstract",
          "as": "https://learn.microsoft.com/dotnet/csharp/language-reference/operators/type-testing-and-cast#as-operator",
          "base": "https://learn.microsoft.com/dotnet/csharp/language-reference/keywords/base",
          "bool": "https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool",
          "break": "https://learn.microsoft.com/dotnet/csharp/language-reference/statements/jump-statements#the-break-statement",
          "byte": "https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/integral-numeric-types",
          "case": "https://learn.microsoft.com/dotnet/csharp/language-reference/statements/selection-statements#the-switch-statement",
          "catch": "https://learn.microsoft.com/dotnet/csharp/language-reference/keywords/try-catch",
          "char": "https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/char",
          "checked": "https://learn.microsoft.com/dotnet/csharp/language-reference/statements/checked-and-unchecked",
          "class": "https://learn.microsoft.com/dotnet/csharp/language-reference/keywords/class",
          "const": "https://learn.microsoft.com/dotnet/csharp/language-reference/keywords/const",
          "continue": "https://learn.microsoft.com/dotnet/csharp/language-reference/statements/jump-statements#the-continue-statement",
          "decimal": "https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/floating-point-numeric-types",
          "default": "https://learn.microsoft.com/dotnet/csharp/language-reference/keywords/default",
          "delegate": "https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/reference-types",
          "do": "https://learn.microsoft.com/dotnet/csharp/language-reference/statements/iteration-statements#the-do-statement",
          "double": "https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/floating-point-numeric-types",
          "else": "https://learn.microsoft.com/dotnet/csharp/language-reference/statements/selection-statements#the-if-statement",
          "enum": "https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/enum",
          "event": "https://learn.microsoft.com/dotnet/csharp/language-reference/keywords/event",
          "explicit": "https://learn.microsoft.com/dotnet/csharp/language-reference/operators/user-defined-conversion-operators",
          "extern": "https://learn.microsoft.com/dotnet/csharp/language-reference/keywords/extern",
          "false": "https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool",
          "finally": "https://learn.microsoft.com/dotnet/csharp/language-reference/keywords/try-finally",
          "fixed": "https://learn.microsoft.com/dotnet/csharp/language-reference/statements/fixed",
          "float": "https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/floating-point-numeric-types",
          "for": "https://learn.microsoft.com/dotnet/csharp/language-reference/statements/iteration-statements#the-for-statement",
          "foreach": "https://learn.microsoft.com/dotnet/csharp/language-reference/statements/iteration-statements#the-foreach-statement",
          "goto": "https://learn.microsoft.com/dotnet/csharp/language-reference/statements/jump-statements#the-goto-statement",
          "if": "https://learn.microsoft.com/dotnet/csharp/language-reference/statements/selection-statements#the-if-statement",
          "implicit": "https://learn.microsoft.com/dotnet/csharp/language-reference/operators/user-defined-conversion-operators",
          "in": "https://learn.microsoft.com/dotnet/csharp/language-reference/keywords/in",
          "int": "https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/integral-numeric-types",
          "interface": "https://learn.microsoft.com/dotnet/csharp/language-reference/keywords/interface",
          "internal": "https://learn.microsoft.com/dotnet/csharp/language-reference/keywords/internal",
          "is": "https://learn.microsoft.com/dotnet/csharp/language-reference/operators/is",
          "lock": "https://learn.microsoft.com/dotnet/csharp/language-reference/statements/lock",
          "long": "https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/integral-numeric-types",
          "namespace": "https://learn.microsoft.com/dotnet/csharp/language-reference/keywords/namespace",
          "new": "https://learn.microsoft.com/dotnet/csharp/language-reference/operators/new-operator",
          "null": "https://learn.microsoft.com/dotnet/csharp/language-reference/keywords/null",
          "object": "https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/reference-types",
          "operator": "https://learn.microsoft.com/dotnet/csharp/language-reference/operators/operator-overloading",
          "out": "https://learn.microsoft.com/dotnet/csharp/language-reference/keywords/out",
          "override": "https://learn.microsoft.com/dotnet/csharp/language-reference/keywords/override",
          "params": "https://learn.microsoft.com/dotnet/csharp/language-reference/keywords/params",
          "private": "https://learn.microsoft.com/dotnet/csharp/language-reference/keywords/private",
          "protected": "https://learn.microsoft.com/dotnet/csharp/language-reference/keywords/protected",
          "public": "https://learn.microsoft.com/dotnet/csharp/language-reference/keywords/public",
          "readonly": "https://learn.microsoft.com/dotnet/csharp/language-reference/keywords/readonly",
          "ref": "https://learn.microsoft.com/dotnet/csharp/language-reference/keywords/ref",
          "return": "https://learn.microsoft.com/dotnet/csharp/language-reference/statements/jump-statements#the-return-statement",
          "sbyte": "https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/integral-numeric-types",
          "sealed": "https://learn.microsoft.com/dotnet/csharp/language-reference/keywords/sealed",
          "short": "https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/integral-numeric-types",
          "sizeof": "https://learn.microsoft.com/dotnet/csharp/language-reference/operators/sizeof",
          "stackalloc": "https://learn.microsoft.com/dotnet/csharp/language-reference/operators/stackalloc",
          "static": "https://learn.microsoft.com/dotnet/csharp/language-reference/keywords/static",
          "string": "https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/reference-types",
          "struct": "https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/struct",
          "switch": "https://learn.microsoft.com/dotnet/csharp/language-reference/operators/switch-expression",
          "this": "https://learn.microsoft.com/dotnet/csharp/language-reference/keywords/this",
          "throw": "https://learn.microsoft.com/dotnet/csharp/language-reference/keywords/throw",
          "true": "https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool",
          "try": "https://learn.microsoft.com/dotnet/csharp/language-reference/keywords/try-catch",
          "typeof": "https://learn.microsoft.com/dotnet/csharp/language-reference/operators/type-testing-and-cast#typeof-operator",
          "uint": "https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/integral-numeric-types",
          "ulong": "https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/integral-numeric-types",
          "unchecked": "https://learn.microsoft.com/dotnet/csharp/language-reference/statements/checked-and-unchecked",
          "unsafe": "https://learn.microsoft.com/dotnet/csharp/language-reference/keywords/unsafe",
          "ushort": "https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/integral-numeric-types",
          "using": "https://learn.microsoft.com/dotnet/csharp/language-reference/keywords/using",
          "virtual": "https://learn.microsoft.com/dotnet/csharp/language-reference/keywords/virtual",
          "void": "https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/void",
          "volatile": "https://learn.microsoft.com/dotnet/csharp/language-reference/keywords/volatile",
          "while": "https://learn.microsoft.com/dotnet/csharp/language-reference/statements/iteration-statements#the-while-statement",
          "add": "https://learn.microsoft.com/dotnet/csharp/language-reference/keywords/add",
          "and": "https://learn.microsoft.com/dotnet/csharp/language-reference/operators/patterns#logical-patterns",
          "alias": "https://learn.microsoft.com/dotnet/csharp/language-reference/keywords/extern-alias",
          "ascending": "https://learn.microsoft.com/dotnet/csharp/language-reference/keywords/ascending",
          "args": "https://learn.microsoft.com/dotnet/csharp/fundamentals/program-structure/top-level-statements#args",
          "async": "https://learn.microsoft.com/dotnet/csharp/language-reference/keywords/async",
          "await": "https://learn.microsoft.com/dotnet/csharp/language-reference/operators/await",
          "by": "https://learn.microsoft.com/dotnet/csharp/language-reference/keywords/by",
          "descending": "https://learn.microsoft.com/dotnet/csharp/language-reference/keywords/descending",
          "dynamic": "https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/reference-types",
          "equals": "https://learn.microsoft.com/dotnet/csharp/language-reference/keywords/equals",
          "file": "https://learn.microsoft.com/dotnet/csharp/language-reference/keywords/file",
          "from": "https://learn.microsoft.com/dotnet/csharp/language-reference/keywords/from-clause",
          "get": "https://learn.microsoft.com/dotnet/csharp/language-reference/keywords/get",
          "global": "https://learn.microsoft.com/dotnet/csharp/language-reference/operators/namespace-alias-qualifier",
          "group": "https://learn.microsoft.com/dotnet/csharp/language-reference/keywords/group-clause",
          "init": "https://learn.microsoft.com/dotnet/csharp/language-reference/keywords/init",
          "into": "https://learn.microsoft.com/dotnet/csharp/language-reference/keywords/into",
          "join": "https://learn.microsoft.com/dotnet/csharp/language-reference/keywords/join-clause",
          "let": "https://learn.microsoft.com/dotnet/csharp/language-reference/keywords/let-clause",
          "managed": "https://learn.microsoft.com/dotnet/csharp/language-reference/unsafe-code#function-pointers",
          "nameof": "https://learn.microsoft.com/dotnet/csharp/language-reference/operators/nameof",
          "nint": "https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/integral-numeric-types",
          "not": "https://learn.microsoft.com/dotnet/csharp/language-reference/operators/patterns#logical-patterns",
          "notnull": "https://learn.microsoft.com/dotnet/csharp/programming-guide/generics/constraints-on-type-parameters#notnull-constraint",
          "nuint": "https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/integral-numeric-types",
          "on": "https://learn.microsoft.com/dotnet/csharp/language-reference/keywords/on",
          "or": "https://learn.microsoft.com/dotnet/csharp/language-reference/operators/patterns#logical-patterns",
          "orderby": "https://learn.microsoft.com/dotnet/csharp/language-reference/keywords/orderby-clause",
          "partial": "https://learn.microsoft.com/dotnet/csharp/language-reference/keywords/partial-method",
          "record": "https://learn.microsoft.com/dotnet/csharp/fundamentals/types/records",
          "remove": "https://learn.microsoft.com/dotnet/csharp/language-reference/keywords/remove",
          "required": "https://learn.microsoft.com/dotnet/csharp/language-reference/keywords/required",
          "scoped": "https://learn.microsoft.com/dotnet/csharp/language-reference/statements/declarations#scoped-ref",
          "select": "https://learn.microsoft.com/dotnet/csharp/language-reference/keywords/select-clause",
          "set": "https://learn.microsoft.com/dotnet/csharp/language-reference/keywords/set",
          "unmanaged": "https://learn.microsoft.com/dotnet/csharp/programming-guide/generics/constraints-on-type-parameters#unmanaged-constraint",
          "value": "https://learn.microsoft.com/dotnet/csharp/language-reference/keywords/value",
          "var": "https://learn.microsoft.com/dotnet/csharp/language-reference/statements/declarations#implicitly-typed-local-variables",
          "when": "https://learn.microsoft.com/dotnet/csharp/language-reference/keywords/when",
          "where": "https://learn.microsoft.com/dotnet/csharp/language-reference/keywords/where-clause",
          "with": "https://learn.microsoft.com/dotnet/csharp/language-reference/operators/with-expression",
          "yield": "https://learn.microsoft.com/dotnet/csharp/language-reference/statements/yield"
        }
        """u8;
}
