// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Docfx.Common.Git;
using Newtonsoft.Json;
using YamlDotNet.Serialization;

namespace Docfx.DataContracts.Common;

public class SourceDetail
{
    [YamlMember(Alias = "remote")]
    [JsonProperty("remote")]
    public GitDetail Remote { get; set; }

    [YamlMember(Alias = "id")]
    [JsonProperty("id")]
    public string Name { get; set; }

    /// <summary>
    /// The url path for current source, should be resolved at some late stage
    /// </summary>
    [YamlMember(Alias = Constants.PropertyName.Href)]
    [JsonProperty(Constants.PropertyName.Href)]
    public string Href { get; set; }

    /// <summary>
    /// The local path for current source, should be resolved to be relative path at some late stage
    /// </summary>
    [YamlMember(Alias = "path")]
    [JsonProperty("path")]
    public string Path { get; set; }

    [YamlMember(Alias = "startLine")]
    [JsonProperty("startLine")]
    public int StartLine { get; set; }

    [YamlMember(Alias = "endLine")]
    [JsonProperty("endLine")]
    public int EndLine { get; set; }
}
