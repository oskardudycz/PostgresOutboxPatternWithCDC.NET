using System.Text.Json.Serialization.Metadata;
using System.Text.Json.Serialization;
using Blumchen.Serialization;

namespace Publisher;

[MessageUrn("user-created:v1")]
internal record UserCreated(
    Guid Id,
    string Name
);

[MessageUrn("user-deleted:v1")]
internal record UserDeleted(
    Guid Id,
    string Name
);

[JsonSourceGenerationOptions(WriteIndented = true)]
[JsonSerializable(typeof(UserCreated))]
[JsonSerializable(typeof(UserDeleted))]
internal partial class SourceGenerationContext: JsonSerializerContext
{
}

internal class PublisherTypesResolver: ITypeResolver
{
    private static readonly TypeResolver Inner = new TypeResolver(SourceGenerationContext.Default, new AttributeNamingPolicy())
        .WhiteList<UserCreated>()
        .WhiteList<UserDeleted>();

    public ISet<string> RegisteredTypes { get; } = Inner.RegisteredTypes;
    public Type Resolve(string value) => Inner.Resolve(value);
    public (string, JsonTypeInfo) Resolve(Type type) => Inner.Resolve(type);
    public JsonSerializerContext SerializationContext => Inner.SerializationContext;
}
